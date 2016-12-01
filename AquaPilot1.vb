Imports Pololu.UsbWrapper
Imports Pololu.Usc
Imports System.Windows.Forms
Imports System.Text
Imports System.ComponentModel
'Imports AquaPilot1.Survey1

Public Class AquaPilot1
    Public Structure PilotInfo
        Public RudderAngle As Double
        Public PortSpeed As Double
        Public StbdSpeed As Double
        Public GyroHeading As Double
        Public GroundCourse As Double
        Public GroundSpeed As Double
        Public AcrossTrack As Double
        Public ApproachRate As Double
        Public ApproachAngle As Double
        Public PilotOn As Boolean
    End Structure

    Public MissionPlanLL() As Survey1.DoubleLL ' mission waypoints in LL pairs (dd.d)
    Public MissionPlanXY() As Survey1.DoubleXY ' mission waypoints in XY pairs (mm.m)
    Public AcrossTrack() As Double ' cross track distance (last 10)
    Public Velocity() As Double ' velocity from gps (last 10)
    Public Course() As Double ' course from gps (last 10)
    Public RudderAngle As Double
    Public MissionLine As Integer ' index into missionplan array
    Public CurrentBoatLat As Double ' boat lat from gps
    Public CurrentBoatLon As Double ' boat lon from gps
    Public CurrentBoatX As Double
    Public CurrentBoatY As Double
    Public CurrentBoatHeading As Double ' boat heading from gyro
    Public CurrentBoatCourse As Double ' calculated course
    Public CurrentBoatSpeed As Double ' speed from gps
    Public CurrentRudderAngle As Double
    Public CurrentCourseToWaypoint As Double
    Public CurrentRoll As Double
    Public CurrentPitch As Double
    Public OldRudderAngle As Double
    Public OldBoatCourse As Double
    Public OldBoatHeading As Double
    Public WaypointLat As Double ' waypoint lat from virtual
    Public WaypointLon As Double ' waypoint lon from virtual
    Public WaypointX As Double
    Public WaypointY As Double
    Public OnLine As Boolean
    Public PortMotorSpeed As Integer
    Public StbdMotorSpeed As Integer
    Public MySurvey1 As New Survey1

    Public Function SetMotorSpeed(motor As Integer, speed As Integer) As Integer
        ' set motor speed 0=Port 1=Stbd, speed expressed as -100 to 100
        Dim spdRev As Integer = 1000
        Dim spdZero As Integer = 1500
        Dim spdFwd As Integer = 2000

        Select Case motor
            Case 1
                If speed <> 0 Then
                    If speed < 0 Then
                        PortMotorSpeed = (spdZero - (Math.Abs(speed) * 5)) * 4
                    ElseIf speed > 0 Then
                        PortMotorSpeed = (spdZero + (speed * 5)) * 4
                    End If
                Else
                    PortMotorSpeed = spdZero * 4
                End If
                TrySetTarget(1, PortMotorSpeed)
                SetMotorSpeed = PortMotorSpeed
                'set port motor speed 1000 to 2000, 1500 = Stop
                'Target, in units of quarter microseconds.  For typical servos,
                '6000 is neutral and the acceptable range is 4000-8000.
            Case 2
                If speed <> 0 Then
                    If speed < 0 Then
                        StbdMotorSpeed = (spdZero - (Math.Abs(speed) * 5)) * 4
                    ElseIf speed > 0 Then
                        StbdMotorSpeed = (spdZero + (speed * 5)) * 4
                    End If
                Else
                    StbdMotorSpeed = spdZero * 4
                End If
                TrySetTarget(2, StbdMotorSpeed)
                SetMotorSpeed = StbdMotorSpeed
                'set port motor speed 1000 to 2000, 1500 = Stop
                'Target, in units of quarter microseconds.  For typical servos,
                '6000 is neutral and the acceptable range is 4000-8000.
            Case Else
                'set motor speed to 0=emergency stop both engines
                PortMotorSpeed = spdZero * 4
                TrySetTarget(1, PortMotorSpeed)
                MySurvey1.sm_wait(100)
                StbdMotorSpeed = spdZero * 4
                TrySetTarget(2, StbdMotorSpeed)
                SetMotorSpeed = spdZero
        End Select
    End Function

    ''' <summary>
    ''' Attempts to set the target of 
    ''' </summary>
    ''' <param name="channel">Channel number from 0 to 23.</param>
    ''' <param name="target">
    '''   Target, in units of quarter microseconds.  For typical servos,
    '''   6000 is neutral and the acceptable range is 4000-8000.
    ''' </param>
    Sub TrySetTarget(ByVal channel As Integer, ByVal target As UInt16)
        Try
            Using device As Usc = connectToDevice() ' Find a device and temporarily connect.
                device.setTarget(channel, target)
                ' device.Dispose() is called automatically when the "Using" block ends,
                ' allowing other functions and processes to use the device.
            End Using
        Catch exception As Exception  ' Handle exceptions by displaying them to the user.
            displayException(exception)
        End Try
    End Sub

    ''' <summary>
    ''' Connects to a Maestro using native USB and returns the Usc object
    ''' representing that connection.  When you are done with the
    ''' connection, you should close it using the Dispose() method so that
    ''' other processes or functions can connect to the device later.  The
    ''' "Using" statement can do this automatically for you.
    ''' </summary>
    Function connectToDevice() As Usc
        ' Get a list of all connected devices of this type.
        Dim connectedDevices As List(Of DeviceListItem) = Usc.getConnectedDevices()

        For Each dli As DeviceListItem In connectedDevices
            ' If you have multiple devices connected and want to select a particular
            ' device by serial number, you could simply add some code like this:
            '    If dli.serialNumber <> "00012345" Then
            '        Continue For
            '    End If
            Dim device As Usc = New Usc(dli)  ' Connect to the device.
            Return device                     ' Return the device.
        Next
        'Dim Returndevice As Usc = New Usc(connectedDevices.Item(deviceNum))  'Create a new USC object and initialize with a DeviceListItem
        'Return Returndevice   'Return the USC object from the line above

        Throw New Exception("Could not find device.  Make sure it is plugged in to " &
            "USB and check your Device Manager.")
    End Function

    ''' <summary>
    ''' Displays an exception (error) to the user by popping up a message box.
    ''' </summary>
    Sub displayException(ByVal exception As Exception)
        Dim stringBuilder As StringBuilder = New StringBuilder()
        Do
            stringBuilder.Append(exception.Message & "  ")
            If TypeOf exception Is Win32Exception Then
                Dim win32Exception As Win32Exception = DirectCast(exception, Win32Exception)
                stringBuilder.Append("Error code 0x" + win32Exception.NativeErrorCode.ToString("x") + ".  ")
            End If
            exception = exception.InnerException
        Loop Until (exception Is Nothing)
        MessageBox.Show(stringBuilder.ToString(), "Motor Control", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ReadLineFile(lineFile As String, lineArray() As Survey1.DoubleXY) As Integer
        ' need final definition from Tyler
        Dim numPoints As Integer

        ReadLineFile = numPoints
    End Function

    Public Function TrackWaypointLL(pointLat As Double, pointLon As Double) As Integer
        Dim HeadingToWaypoint As Double
        Dim HeadingDifference As Double
        Dim RAngle As Double

        HeadingToWaypoint = MySurvey1.InitialHeading(CurrentBoatLat, CurrentBoatLon, pointLat, pointLon)
        HeadingDifference = CurrentBoatCourse - HeadingToWaypoint
        ' Normalize Heading...
        If HeadingDifference < -180 Then
            HeadingDifference = HeadingDifference + 360
        ElseIf HeadingDifference > 180 Then
            HeadingDifference = HeadingDifference - 360
        End If

        RAngle = SetRudderAngle(HeadingDifference)
        TrackWaypointLL = 1
    End Function

    Public Function TrackWaypointXY(pointX As Double, pointY As Double) As Integer
        Dim CourseToWaypoint As Double
        Dim CourseDifference As Double
        Dim RAngle As Double

        MySurvey1.Inverse(CurrentBoatX, CurrentBoatY, pointX, pointY)
        CourseToWaypoint = MySurvey1.InverseBearing
        CurrentCourseToWaypoint = CourseToWaypoint
        CourseDifference = CurrentBoatCourse - CourseToWaypoint
        ' Normalize Heading...
        If CourseDifference < -180 Then
            CourseDifference = CourseDifference + 360
        ElseIf CourseDifference > 180 Then
            CourseDifference = CourseDifference - 360
        End If
        If CourseDifference > 90 Then
            RAngle = SetRudderAngle(90)
        ElseIf CourseDifference < -90 Then
            RAngle = SetRudderAngle(-90)
        Else
            RAngle = SetRudderAngle(CourseDifference)
        End If

        TrackWaypointXY = 1
    End Function

    Public Function SetRudderAngle(RAngle As Double) As Double
        Dim rdrPort As Integer = 1000 ' may be 90 degrees, need to verify
        Dim rdrCent As Integer = 1500
        Dim rdrStbd As Integer = 2000
        Dim NewRudderAngle As Double

        ' come up with a scaleable factor ; relationship between heading and rudder angle
        '        OldRudderAngle = CurrentRudderAngle
        '        If CurrentRudderAngle + RAngle > 90 Then
        '        NewRudderAngle = (90 * 5) + rdrCent
        '        ElseIf CurrentRudderAngle + RAngle < -90 Then
        '        NewRudderAngle = (-90 * 5) + rdrCent
        '        Else
        '        NewRudderAngle = ((CurrentRudderAngle + RAngle) * 5) + rdrCent
        '        End If
        ' scale RAngle to fit...
        If RAngle < 0 And RAngle > -90.1 Then
            NewRudderAngle = rdrCent - (Math.Abs(RAngle) * 5.55)
        ElseIf RAngle > 0 And RAngle < 90.1 Then
            NewRudderAngle = (RAngle * 5.55) + rdrCent
        ElseIf RAngle > 90 Then
            NewRudderAngle = (90 * 5.55) + rdrCent
        ElseIf RAngle < -90 Then
            NewRudderAngle = rdrCent - (RAngle * 5.5)
        Else
            NewRudderAngle = rdrCent
        End If

        ' 1.5ms is center position of the servo, target takes 1/4 microseconds, 1.5ms = 1.5*4000?
        ' full left rudder then would be 4000, full right rudder 8000, center rudder 6000
        TrySetTarget(0, CInt(NewRudderAngle * 4)) ' convert to 1/4 microseconds
        CurrentRudderAngle = CurrentRudderAngle + RAngle
        SetRudderAngle = NewRudderAngle
    End Function

    Public Function MakeWaypointLL() As Survey1.DoubleLL



    End Function

    Public Function MakeWaypointXY(CurrentLocation As Survey1.DoubleXY) As Survey1.DoubleXY
        Static NewBearing As Double
        Static CrossTrackDist As Double
        Static OldCrossTrackDist As Double
        Dim DistPoint As Double
        Dim BrngPoint As Double
        Dim ResetFlag As Boolean

        If NewBearing = Nothing Then
            NewBearing = frmAquaPilot.lineBearing
            ResetFlag = False
        End If
        CrossTrackDist = GetCrossTrackXY(MissionPlanXY, MissionLine, CurrentLocation)
        DistPoint = MySurvey1.DistanceToLine(MissionPlanXY(MissionLine).x, MissionPlanXY(MissionLine).y, MissionPlanXY(MissionLine + 1).x, MissionPlanXY(MissionLine + 1).y, CurrentLocation.x, CurrentLocation.y)
        Call MySurvey1.Inverse(CurrentLocation.x, CurrentLocation.y, MySurvey1.IntersectCoord.x, MySurvey1.IntersectCoord.y)
        BrngPoint = MySurvey1.InverseBearing
        Debug.WriteLine("LineBearing " & frmAquaPilot.lineBearing)
        Debug.WriteLine("PointBearing " & BrngPoint)
        Debug.WriteLine("DistanceToLine " & DistPoint)

        If CrossTrackDist > 0 Then
            ' calc some percentage to control the bearing change
            If CrossTrackDist > 90 Then
                NewBearing = frmAquaPilot.lineBearing - 90
                ResetFlag = True
            ElseIf Math.Abs((frmAquaPilot.lineBearing + 360) - (CurrentBoatCourse + 360)) > 10 Then
                If ResetFlag = True Then
                    NewBearing = frmAquaPilot.lineBearing
                    ResetFlag = False
                    Beep()
                End If
                NewBearing = NewBearing - (CrossTrackDist / 100)
            End If
            'NewBearing = NewBearing - 5
        ElseIf CrossTrackDist < 0 Then
            If CrossTrackDist < -90 Then
                NewBearing = frmAquaPilot.lineBearing + 90
                ResetFlag = True
            ElseIf Math.Abs((frmAquaPilot.lineBearing + 360) - (CurrentBoatCourse + 360)) > 10 Then
                If ResetFlag = True Then
                    NewBearing = frmAquaPilot.lineBearing
                    ResetFlag = False
                    Beep()
                End If
                NewBearing = NewBearing - (CrossTrackDist / 100)
            End If
            'NewBearing = NewBearing + 5
        End If
        MySurvey1.Traverse(CurrentBoatX, CurrentBoatY, NewBearing, 100)

        OldCrossTrackDist = CrossTrackDist
        MakeWaypointXY.x = MySurvey1.TraverseX
        MakeWaypointXY.y = MySurvey1.TraverseY

    End Function

    Public Function GetCrossTrackLL(lineArray() As Survey1.DoubleLL, index As Integer, point As Survey1.DoubleLL) As Double
        GetCrossTrackLL = MySurvey1.CrossTrack(lineArray(index).lat, lineArray(index).lon, lineArray(index + 1).lat, lineArray(index + 1).lon, point.lat, point.lon)
    End Function

    Public Function GetCrossTrackXY(lArray As Survey1.DoubleXY(), index As Integer, point As Survey1.DoubleXY) As Double
        Dim LineBearing As Double
        Dim CrossBearing As Double
        Dim TestBearing As Double
        Dim CrossTrack As Double
        'Dim MySurvey1 As New Survey1

        CrossTrack = MySurvey1.DistanceToLine(lArray(index).x, lArray(index).y, lArray(index + 1).x, lArray(index + 1).y, point.x, point.y)
        Call MySurvey1.Inverse(lArray(index).x, lArray(index).y, lArray(index + 1).x, lArray(index + 1).y)
        LineBearing = MySurvey1.InverseBearing
        Call MySurvey1.Inverse(MySurvey1.IntersectCoord.x, MySurvey1.IntersectCoord.y, point.x, point.y)
        CrossBearing = MySurvey1.InverseBearing
        TestBearing = LineBearing + 90
        If TestBearing > 360 Then
            TestBearing = TestBearing - 360
        ElseIf TestBearing < 0 Then
            TestBearing = TestBearing + 360
        End If
        If Math.Abs(TestBearing - CrossBearing) < 5 Then
            'boat is to the startboard of line
            Return CrossTrack
            Exit Function
        Else
            TestBearing = LineBearing - 90
        End If
        If TestBearing > 360 Then
            TestBearing = TestBearing - 360
        ElseIf TestBearing < 0 Then
            TestBearing = TestBearing + 360
        End If
        If Math.Abs(TestBearing - CrossBearing) < 5 Then
            'boat is to the port of line
            CrossTrack = CrossTrack * -1
            Return CrossTrack
            Exit Function
        End If
        Return CrossTrack
    End Function

    Public Function GetLineBearingLL(lineArray() As Survey1.DoubleLL, index As Integer) As Double
        GetLineBearingLL = MySurvey1.InitialHeading(lineArray(index).lat, lineArray(index).lon, lineArray(index + 1).lat, lineArray(index + 1).lon) ' return heading
    End Function

    Public Function GetLineBearingXY(lineArray() As Survey1.DoubleXY, index As Integer) As Double
        Call MySurvey1.Inverse(lineArray(index).x, lineArray(index).y, lineArray(index + 1).x, lineArray(index + 1).y)
        If MySurvey1.InverseBearing < 1 Then
            GetLineBearingXY = 360
        Else
            GetLineBearingXY = MySurvey1.InverseBearing ' return bearing
        End If
    End Function

    Public Function GetUTMZone(inLat As Double, inLon As Double) As String
        ' returns a string indicating UTM zone
        Dim utmFile As Integer
        Dim lineStr As String
        Dim hemisphere As String
        Dim TempArray(1) As String

        GetUTMZone = ""
        utmFile = FreeFile()
        ChDir(System.AppDomain.CurrentDomain.BaseDirectory)
        FileOpen(utmFile, ".\utmzones.txt", OpenMode.Input)
        Do While Not EOF(utmFile)
            lineStr = LineInput(utmFile) ' get a line from the file
            Call MySurvey1.sm_parse(lineStr, " ", TempArray) ' parse the values into an array
            hemisphere = Right(TempArray(0), 1) ' check for N or S hemiphere
            If (inLat > 0 And hemisphere = "N") Or (inLat < 0 And hemisphere = "S") Then
                If inLon > 0 Then ' if Lon is + (E) see which zone it falls in
                    If inLon > CDbl(TempArray(1)) And inLon < CDbl(TempArray(2)) Then
                        GetUTMZone = TempArray(0) ' return zone
                        Exit Do
                    End If
                ElseIf inLon < 0 Then ' if Lon is - (W) see which zone it falls in
                    If inLon > CDbl(TempArray(1)) And inLon < CDbl(TempArray(2)) Then
                        GetUTMZone = TempArray(0) ' return zone
                        Exit Do
                    End If
                Else
                    GetUTMZone = ""
                End If
            End If
        Loop

        FileClose(utmFile)

    End Function


End Class
