Imports System.IO.Ports
Imports System.Windows.Forms
Imports OrientusLibrary.ClassInCSharp

Public Class frmAquaPilot
    Public MyAquaPilot As New AquaPilot1
    Dim myResizer As New Resizer
    Dim gpsOpen As Boolean
    Dim gpsreadBuffer As String
    Dim hdtOpen As Boolean
    Dim frmHWration As Double
    Dim lineIndex As Integer
    Dim slineArray() As Survey1.DoubleXY
    Public currentBoatXY As Survey1.DoubleXY
    Public currentXTrack As Double
    Dim oldXTrack As Double
    Public speedXTrack As Double
    Dim dirXTrack As Double
    Dim oldSpeedXTrack As Double
    Dim oldDirXTrack As Double
    Public lineBearing As Double
    Dim gyroClass As OrientusLibrary.ClassInCSharp



    Private Sub frmAquaPilot_Load(sender As Object, e As EventArgs) Handles Me.Load
        gyroClass = New OrientusLibrary.ClassInCSharp

        MyAquaPilot.MySurvey1.InitNmeaInfo()
        frmHWration = Me.Width / Me.Height
        myResizer.FindAllControls(Me)
        ' device params 

        ' read avaiable COM Ports: 
        Dim Portnames As String() = System.IO.Ports.SerialPort.GetPortNames
        If Portnames Is Nothing Then
            MsgBox("There are no Com Ports detected!")
            Me.Close()
        End If
        Dim port As String
        For Each port In Portnames
            Debug.WriteLine(port)
        Next port

        'frmGPS.cboPort.Items.AddRange(Portnames)
        'frmGPS.cboPort.Text = Portnames(0)
        'frmGPS.cboBaud.Text = "9600"
        'cboComPort.Items.AddRange(Portnames)
        'cboComPort.Text = Portnames(0)
        'cboBaudRate.Text = "9600"
        ReDim MyAquaPilot.MissionPlanXY(2)
        MyAquaPilot.MissionPlanXY(0).x = 600400
        MyAquaPilot.MissionPlanXY(0).y = 1300000
        MyAquaPilot.MissionPlanXY(1).x = 600500
        MyAquaPilot.MissionPlanXY(1).y = 1300500
        MyAquaPilot.MissionLine = 0
        ReDim slineArray(2)
        slineArray(0).x = 600400
        slineArray(0).y = 1300000
        slineArray(1).x = 600500
        slineArray(1).y = 1300500
        lineIndex = 0
        MyAquaPilot.CurrentBoatX = 600400
        MyAquaPilot.CurrentBoatY = 1300050
        MyAquaPilot.WaypointX = 600100
        MyAquaPilot.WaypointY = 1300100
        InitializePorts()
        Timer1.Enabled = True
    End Sub

    Private Function InitializePorts() As Boolean
        'Dim comOpen As Boolean

        '        With GPSComm
        '        .ParityReplace = &H3B                    ' replace ";" when parity error occurs 
        '        .PortName = "COM3"
        '        .BaudRate = "9600"
        '        .Parity = IO.Ports.Parity.None
        '        .DataBits = 8
        '        .StopBits = IO.Ports.StopBits.One
        '        .Handshake = IO.Ports.Handshake.None
        '        .RtsEnable = False
        '        .ReceivedBytesThreshold = 1             'threshold: one byte in buffer > event is fired 
        '        .NewLine = vbCr         ' CR must be the last char in frame. This terminates the SerialPort.readLine 
        '        .ReadTimeout = 10000
        '        End With
        '        Try
        '        GPSComm.Open()
        '        gpsOpen = GPSComm.IsOpen
        '        Catch ex As Exception
        '        gpsOpen = False
        '        MsgBox("Error Open: " & ex.Message)
        '        End Try

        With HDTComm
            .ParityReplace = &H3B                    ' replace ";" when parity error occurs 
            .PortName = "COM21" 'frmGYRO.btnCom.Text
            .BaudRate = "115200" 'frmGYRO.btnBaud.Text
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .RtsEnable = False
            .ReceivedBytesThreshold = 1             'threshold: one byte in buffer > event is fired 
            .NewLine = vbCr         ' CR must be the last char in frame. This terminates the SerialPort.readLine 
            .ReadTimeout = 10000
        End With
        Try
            HDTComm.Open()
            hdtOpen = HDTComm.IsOpen
            'gyroClass.setBaudRate(115200)
            'gyroClass.setSerialPort(21)
            'gyroClass.connectToPort("COM21", 115200)
        Catch ex As Exception
            hdtOpen = False
            MsgBox("Error Open: " & ex.Message)
        End Try

        If hdtOpen = True Then ' add more checks as ports are added to function
            InitializePorts = True
        Else
            InitializePorts = False
        End If

    End Function
    Private Sub frmAquaPilot_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        myResizer.ResizeAllControls(Me)
    End Sub

    Private Sub GPSComm_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles GPSComm.DataReceived
        Dim InString As String
        InString = GPSComm.ReadLine()
        If gpsOpen Then
            Try
                gpsreadBuffer = GPSComm.ReadLine()
                MyAquaPilot.MySurvey1.parseNmea(gpsreadBuffer)
                MyAquaPilot.CurrentBoatLat = MyAquaPilot.MySurvey1.NmeaInfo.gga.lat
                MyAquaPilot.CurrentBoatLon = MyAquaPilot.MySurvey1.NmeaInfo.gga.lon

                'data to UI thread 
                Me.Invoke(New EventHandler(AddressOf DoUpdate))
            Catch ex As Exception
                MsgBox("read " & ex.Message)
            End Try
        End If
    End Sub

    ''' <summary> 
    ''' update received string in UI 
    ''' </summary> 
    Public Sub DoUpdate(ByVal sender As Object, ByVal e As System.EventArgs)
        MyAquaPilot.MySurvey1.parseNmea(gpsreadBuffer)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tempPoint As Survey1.DoubleXY

        oldXTrack = currentXTrack
        currentXTrack = MyAquaPilot.GetCrossTrackXY(slineArray, lineIndex, currentBoatXY)
        oldSpeedXTrack = speedXTrack
        oldDirXTrack = dirXTrack
        If currentXTrack > oldXTrack Then
            speedXTrack = currentXTrack - oldXTrack ' meters per second
            dirXTrack = -1
        ElseIf currentXTrack < oldXTrack Then
            speedXTrack = oldXTrack - currentXTrack ' meters per second
            dirXTrack = 1
        End If
        If currentXTrack < 0 And currentXTrack > -100 Then
            ProgressBar1.Value = Math.Abs(currentXTrack)
            ProgressBar2.Value = 0
            lblCrossTrack1.Text = Format(currentXTrack, "#####00.00")
            lblCrossTrack2.Text = "0.00"
        ElseIf currentXTrack > 0 And currentXTrack < 100 Then
            ProgressBar2.Value = currentXTrack
            ProgressBar1.Value = 0
            lblCrossTrack2.Text = Format(currentXTrack, "#####00.00")
            lblCrossTrack1.Text = "0.00"
        ElseIf currentXTrack > 100 Then
            ProgressBar2.Value = 100
            ProgressBar1.Value = 0
            lblCrossTrack2.Text = Format(currentXTrack, "#####00.00")
            lblCrossTrack1.Text = "0.00"
        ElseIf currentXTrack < -100 Then
            ProgressBar1.Value = 100
            ProgressBar2.Value = 0
            lblCrossTrack1.Text = Format(currentXTrack, "#####00.00")
            lblCrossTrack2.Text = "0.00"
        Else
            ProgressBar1.Value = 0
            ProgressBar2.Value = 0
            lblCrossTrack1.Text = "0.00"
            lblCrossTrack2.Text = "0.00"
        End If
        MyAquaPilot.MySurvey1.Inverse(currentBoatXY.x, currentBoatXY.y, MyAquaPilot.WaypointX, MyAquaPilot.WaypointY)
        MyAquaPilot.CurrentCourseToWaypoint = MyAquaPilot.MySurvey1.InverseBearing
        lineBearing = MyAquaPilot.GetLineBearingXY(slineArray, lineIndex)
        'lblHeading.Text = Format(MyAquaPilot.CurrentBoatHeading, "000.0 deg")
        HeadingGauge.Value = CSng(Format(MyAquaPilot.CurrentBoatHeading, "000.00"))

        ' update waypoint and velocity and course...
        tempPoint = MyAquaPilot.MakeWaypointXY()
        MyAquaPilot.WaypointX = tempPoint.x
        MyAquaPilot.WaypointY = tempPoint.y
    End Sub

    Private Sub frmAquaPilot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If gpsOpen Then
            ' clear input buffer 
            GPSComm.DiscardInBuffer()
            GPSComm.Close()
        End If
        If hdtOpen Then
            HDTComm.DiscardInBuffer()
            HDTComm.Close()
        End If
        End
    End Sub

    Private Sub frmAquaPilot_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.Width = Me.Height * frmHWration
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSIM.Show()
    End Sub

    Private Sub HDTComm_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles HDTComm.DataReceived
        Dim gyroPacket As OrientusLibrary.ClassInCSharp.McBayPacket
        gyroPacket = New McBayPacket
        Dim packetBuffer As OrientusLibrary.ANPacketDecoder
        packetBuffer = New OrientusLibrary.ANPacketDecoder

        If hdtOpen Then
            Try
                packetBuffer.bufferLength = packetBuffer.bufferLength + HDTComm.Read(packetBuffer.buffer, packetBuffer.bufferLength, packetBuffer.buffer.Length - packetBuffer.bufferLength)

                Dim tempPacket As OrientusLibrary.ANPacket
                tempPacket = New OrientusLibrary.ANPacket(packetBuffer.bufferLength, 12)
                Dim structX As OrientusLibrary.ClassInCSharp.McBayPacket
                'anPacket = New OrientusLibrary.ANPacket
                tempPacket = packetBuffer.packetDecode()
                If tempPacket IsNot Nothing Then
                    structX = gyroClass.decodePacketToStruct(tempPacket)
                    If structX.packetType = "ORIENTATION" Then
                        MyAquaPilot.CurrentRoll = (structX.orientationSection.orientation(0) * 180) / Math.PI
                        MyAquaPilot.CurrentPitch = (structX.orientationSection.orientation(1) * 180) / Math.PI
                        MyAquaPilot.CurrentBoatHeading = (structX.orientationSection.orientation(2) * 180) / Math.PI
                    End If
                End If
                'Debug.Print(structX.packetType)

                Me.Invoke(New EventHandler(AddressOf DoUpdate))
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If gpsOpen Then
            ' clear input buffer 
            GPSComm.DiscardInBuffer()
            GPSComm.Close()
        End If
        If hdtOpen Then
            HDTComm.DiscardInBuffer()
            HDTComm.Close()
        End If
        End
    End Sub

End Class