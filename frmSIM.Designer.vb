<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSIM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vCourse = New System.Windows.Forms.Label()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vSpeed = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rAngle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xTrack = New System.Windows.Forms.Label()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lBearing = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.boatX = New System.Windows.Forms.TextBox()
        Me.boatY = New System.Windows.Forms.TextBox()
        Me.wptX = New System.Windows.Forms.TextBox()
        Me.wptY = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.wCourse = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.boatHeading = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.frmRudderTest = New System.Windows.Forms.GroupBox()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RudderTest1 = New AquaControls.AquaGauge()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SpeedBar2 = New VerticalProgressBar.VerticalProgressBar()
        Me.SpeedBar1 = New VerticalProgressBar.VerticalProgressBar()
        Me.StartX = New System.Windows.Forms.TextBox()
        Me.StartY = New System.Windows.Forms.TextBox()
        Me.EndX = New System.Windows.Forms.TextBox()
        Me.EndY = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LineStat = New System.Windows.Forms.Label()
        Me.HScrollBar4 = New System.Windows.Forms.HScrollBar()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.vHeading = New System.Windows.Forms.Label()
        Me.Deploy1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.frmRudderTest.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Deploy1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(23, 64)
        Me.HScrollBar1.Maximum = 369
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(166, 17)
        Me.HScrollBar1.TabIndex = 0
        Me.HScrollBar1.Value = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vessel Course"
        '
        'vCourse
        '
        Me.vCourse.AutoSize = True
        Me.vCourse.Location = New System.Drawing.Point(100, 48)
        Me.vCourse.Name = "vCourse"
        Me.vCourse.Size = New System.Drawing.Size(25, 13)
        Me.vCourse.TabIndex = 2
        Me.vCourse.Text = "200"
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(23, 100)
        Me.HScrollBar2.Maximum = 29
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(166, 17)
        Me.HScrollBar2.TabIndex = 3
        Me.HScrollBar2.Value = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vessel Speed"
        '
        'vSpeed
        '
        Me.vSpeed.AutoSize = True
        Me.vSpeed.Location = New System.Drawing.Point(100, 84)
        Me.vSpeed.Name = "vSpeed"
        Me.vSpeed.Size = New System.Drawing.Size(19, 13)
        Me.vSpeed.TabIndex = 5
        Me.vSpeed.Text = "20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rudder Angle"
        '
        'rAngle
        '
        Me.rAngle.AutoSize = True
        Me.rAngle.Location = New System.Drawing.Point(304, 47)
        Me.rAngle.Name = "rAngle"
        Me.rAngle.Size = New System.Drawing.Size(19, 13)
        Me.rAngle.TabIndex = 7
        Me.rAngle.Text = "80"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cross Track"
        '
        'xTrack
        '
        Me.xTrack.AutoSize = True
        Me.xTrack.Location = New System.Drawing.Point(304, 67)
        Me.xTrack.Name = "xTrack"
        Me.xTrack.Size = New System.Drawing.Size(25, 13)
        Me.xTrack.TabIndex = 9
        Me.xTrack.Text = "100"
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(23, 28)
        Me.HScrollBar3.Maximum = 368
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(166, 17)
        Me.HScrollBar3.TabIndex = 10
        Me.HScrollBar3.Value = 205
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Line Bearing"
        '
        'lBearing
        '
        Me.lBearing.AutoSize = True
        Me.lBearing.Location = New System.Drawing.Point(100, 12)
        Me.lBearing.Name = "lBearing"
        Me.lBearing.Size = New System.Drawing.Size(25, 13)
        Me.lBearing.TabIndex = 12
        Me.lBearing.Text = "205"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Vessel X Coordinate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Vessel Y Coordinate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(160, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Waypoint X Coordinate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Waypoint Y Coordinate"
        '
        'boatX
        '
        Me.boatX.Location = New System.Drawing.Point(24, 188)
        Me.boatX.Name = "boatX"
        Me.boatX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.boatX.Size = New System.Drawing.Size(100, 20)
        Me.boatX.TabIndex = 21
        Me.boatX.Text = "600000"
        '
        'boatY
        '
        Me.boatY.Location = New System.Drawing.Point(24, 227)
        Me.boatY.Name = "boatY"
        Me.boatY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.boatY.Size = New System.Drawing.Size(100, 20)
        Me.boatY.TabIndex = 22
        Me.boatY.Text = "1300000"
        '
        'wptX
        '
        Me.wptX.Location = New System.Drawing.Point(163, 188)
        Me.wptX.Name = "wptX"
        Me.wptX.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.wptX.Size = New System.Drawing.Size(100, 20)
        Me.wptX.TabIndex = 23
        Me.wptX.Text = "600100"
        '
        'wptY
        '
        Me.wptY.Location = New System.Drawing.Point(163, 227)
        Me.wptY.Name = "wptY"
        Me.wptY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.wptY.Size = New System.Drawing.Size(100, 20)
        Me.wptY.TabIndex = 24
        Me.wptY.Text = "1300200"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Course to Wpt"
        '
        'wCourse
        '
        Me.wCourse.AutoSize = True
        Me.wCourse.Location = New System.Drawing.Point(304, 28)
        Me.wCourse.Name = "wCourse"
        Me.wCourse.Size = New System.Drawing.Size(25, 13)
        Me.wCourse.TabIndex = 26
        Me.wCourse.Text = "200"
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(290, 338)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(39, 23)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Start"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(211, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Boat Heading"
        '
        'boatHeading
        '
        Me.boatHeading.AutoSize = True
        Me.boatHeading.Location = New System.Drawing.Point(304, 87)
        Me.boatHeading.Name = "boatHeading"
        Me.boatHeading.Size = New System.Drawing.Size(25, 13)
        Me.boatHeading.TabIndex = 29
        Me.boatHeading.Text = "100"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "<---"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(74, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "--->"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(130, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "FWD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(177, 249)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "REV"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmRudderTest
        '
        Me.frmRudderTest.Controls.Add(Me.lblAngle)
        Me.frmRudderTest.Controls.Add(Me.Button5)
        Me.frmRudderTest.Controls.Add(Me.RudderTest1)
        Me.frmRudderTest.Location = New System.Drawing.Point(341, 17)
        Me.frmRudderTest.Name = "frmRudderTest"
        Me.frmRudderTest.Size = New System.Drawing.Size(276, 165)
        Me.frmRudderTest.TabIndex = 34
        Me.frmRudderTest.TabStop = False
        Me.frmRudderTest.Text = "Rudder Test"
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAngle.Location = New System.Drawing.Point(6, 110)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(113, 13)
        Me.lblAngle.TabIndex = 2
        Me.lblAngle.Text = "Rudder Angle: 000"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(24, 39)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 54)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Test Rudders"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RudderTest1
        '
        Me.RudderTest1.BackColor = System.Drawing.Color.Transparent
        Me.RudderTest1.DialColor = System.Drawing.Color.MidnightBlue
        Me.RudderTest1.DialText = "Rudder"
        Me.RudderTest1.FromAngle = -180.0!
        Me.RudderTest1.Glossiness = 11.36364!
        Me.RudderTest1.Location = New System.Drawing.Point(124, 8)
        Me.RudderTest1.MaxValue = 90.0!
        Me.RudderTest1.MinValue = -90.0!
        Me.RudderTest1.Name = "RudderTest1"
        Me.RudderTest1.NoOfDivisions = 6
        Me.RudderTest1.NoOfSubDivisions = 2
        Me.RudderTest1.RecommendedValue = 0!
        Me.RudderTest1.Size = New System.Drawing.Size(146, 146)
        Me.RudderTest1.TabIndex = 0
        Me.RudderTest1.ThresholdPercent = 0!
        Me.RudderTest1.ToAngle = 0!
        Me.RudderTest1.Value = 0!
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSpeed)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.SpeedBar2)
        Me.GroupBox1.Controls.Add(Me.SpeedBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 173)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motor Test"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.Location = New System.Drawing.Point(104, 120)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(28, 13)
        Me.lblSpeed.TabIndex = 42
        Me.lblSpeed.Text = "100"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(77, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Motor Speed:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(85, 25)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 52)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Test Motors"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(50, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Stbd"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Port"
        '
        'SpeedBar2
        '
        Me.SpeedBar2.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.SpeedBar2.Color = System.Drawing.Color.Green
        Me.SpeedBar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.SpeedBar2.Location = New System.Drawing.Point(53, 47)
        Me.SpeedBar2.Maximum = 100
        Me.SpeedBar2.Minimum = 0
        Me.SpeedBar2.Name = "SpeedBar2"
        Me.SpeedBar2.Size = New System.Drawing.Size(13, 120)
        Me.SpeedBar2.Step = 5
        Me.SpeedBar2.Style = VerticalProgressBar.Styles.Solid
        Me.SpeedBar2.TabIndex = 37
        Me.SpeedBar2.Value = 0
        '
        'SpeedBar1
        '
        Me.SpeedBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.SpeedBar1.Color = System.Drawing.Color.Red
        Me.SpeedBar1.Location = New System.Drawing.Point(24, 47)
        Me.SpeedBar1.Maximum = 100
        Me.SpeedBar1.Minimum = 0
        Me.SpeedBar1.Name = "SpeedBar1"
        Me.SpeedBar1.Size = New System.Drawing.Size(13, 120)
        Me.SpeedBar1.Step = 5
        Me.SpeedBar1.Style = VerticalProgressBar.Styles.Solid
        Me.SpeedBar1.TabIndex = 36
        Me.SpeedBar1.Value = 0
        '
        'StartX
        '
        Me.StartX.Location = New System.Drawing.Point(24, 305)
        Me.StartX.Name = "StartX"
        Me.StartX.Size = New System.Drawing.Size(100, 20)
        Me.StartX.TabIndex = 35
        '
        'StartY
        '
        Me.StartY.Location = New System.Drawing.Point(24, 341)
        Me.StartY.Name = "StartY"
        Me.StartY.Size = New System.Drawing.Size(100, 20)
        Me.StartY.TabIndex = 36
        '
        'EndX
        '
        Me.EndX.Location = New System.Drawing.Point(163, 305)
        Me.EndX.Name = "EndX"
        Me.EndX.Size = New System.Drawing.Size(100, 20)
        Me.EndX.TabIndex = 37
        '
        'EndY
        '
        Me.EndY.Location = New System.Drawing.Point(163, 341)
        Me.EndY.Name = "EndY"
        Me.EndY.Size = New System.Drawing.Size(100, 20)
        Me.EndY.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Line Start X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 325)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Line Start Y"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(160, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Line End X"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(160, 325)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Line End Y"
        '
        'LineStat
        '
        Me.LineStat.AutoSize = True
        Me.LineStat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LineStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineStat.ForeColor = System.Drawing.Color.Red
        Me.LineStat.Location = New System.Drawing.Point(246, 133)
        Me.LineStat.Name = "LineStat"
        Me.LineStat.Size = New System.Drawing.Size(60, 15)
        Me.LineStat.TabIndex = 43
        Me.LineStat.Text = "OFFLINE"
        '
        'HScrollBar4
        '
        Me.HScrollBar4.Location = New System.Drawing.Point(23, 133)
        Me.HScrollBar4.Maximum = 369
        Me.HScrollBar4.Minimum = 1
        Me.HScrollBar4.Name = "HScrollBar4"
        Me.HScrollBar4.Size = New System.Drawing.Size(166, 17)
        Me.HScrollBar4.TabIndex = 44
        Me.HScrollBar4.Value = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Vessel Heading"
        '
        'vHeading
        '
        Me.vHeading.AutoSize = True
        Me.vHeading.Location = New System.Drawing.Point(100, 117)
        Me.vHeading.Name = "vHeading"
        Me.vHeading.Size = New System.Drawing.Size(19, 13)
        Me.vHeading.TabIndex = 46
        Me.vHeading.Text = "20"
        '
        'Deploy1
        '
        Me.Deploy1.Controls.Add(Me.RadioButton2)
        Me.Deploy1.Controls.Add(Me.RadioButton1)
        Me.Deploy1.Location = New System.Drawing.Point(517, 188)
        Me.Deploy1.Name = "Deploy1"
        Me.Deploy1.Size = New System.Drawing.Size(100, 173)
        Me.Deploy1.TabIndex = 47
        Me.Deploy1.TabStop = False
        Me.Deploy1.Text = "Deployment"
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(5, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 23)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Sonar Up"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(5, 98)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 23)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Sonar Down"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'frmSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 367)
        Me.Controls.Add(Me.Deploy1)
        Me.Controls.Add(Me.vHeading)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.HScrollBar4)
        Me.Controls.Add(Me.LineStat)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.EndY)
        Me.Controls.Add(Me.EndX)
        Me.Controls.Add(Me.StartY)
        Me.Controls.Add(Me.StartX)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.frmRudderTest)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.boatHeading)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.wCourse)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.wptY)
        Me.Controls.Add(Me.wptX)
        Me.Controls.Add(Me.boatY)
        Me.Controls.Add(Me.boatX)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lBearing)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HScrollBar3)
        Me.Controls.Add(Me.xTrack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rAngle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.vSpeed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.vCourse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.MaximizeBox = False
        Me.Name = "frmSIM"
        Me.Text = "Simulator"
        Me.frmRudderTest.ResumeLayout(False)
        Me.frmRudderTest.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Deploy1.ResumeLayout(False)
        Me.Deploy1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vCourse As System.Windows.Forms.Label
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vSpeed As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rAngle As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xTrack As System.Windows.Forms.Label
    Friend WithEvents HScrollBar3 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lBearing As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents boatX As System.Windows.Forms.TextBox
    Friend WithEvents boatY As System.Windows.Forms.TextBox
    Friend WithEvents wptX As System.Windows.Forms.TextBox
    Friend WithEvents wptY As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents wCourse As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents boatHeading As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents frmRudderTest As System.Windows.Forms.GroupBox
    Friend WithEvents lblAngle As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents RudderTest1 As AquaControls.AquaGauge
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SpeedBar2 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents SpeedBar1 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StartX As System.Windows.Forms.TextBox
    Friend WithEvents StartY As System.Windows.Forms.TextBox
    Friend WithEvents EndX As System.Windows.Forms.TextBox
    Friend WithEvents EndY As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LineStat As System.Windows.Forms.Label
    Friend WithEvents HScrollBar4 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents vHeading As System.Windows.Forms.Label
    Friend WithEvents Deploy1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
