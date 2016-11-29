<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAquaPilot
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
        Me.WinformsMap1 = New ThinkGeo.MapSuite.DesktopEdition.WinformsMap()
        Me.HeadingGauge = New AquaControls.AquaGauge()
        Me.CourseGauge = New AquaControls.AquaGauge()
        Me.RudderGauge = New AquaControls.AquaGauge()
        Me.GPSComm = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblCrossTrack1 = New System.Windows.Forms.Label()
        Me.lblCrossTrack2 = New System.Windows.Forms.Label()
        Me.HDTComm = New System.IO.Ports.SerialPort(Me.components)
        Me.DPTComm = New System.IO.Ports.SerialPort(Me.components)
        Me.DriveComm = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WinformsMap1
        '
        Me.WinformsMap1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.WinformsMap1.BackColor = System.Drawing.Color.White
        Me.WinformsMap1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.[Default]
        Me.WinformsMap1.CurrentScale = 590591790.0R
        Me.WinformsMap1.DrawingQuality = ThinkGeo.MapSuite.Core.DrawingQuality.[Default]
        Me.WinformsMap1.Location = New System.Drawing.Point(287, 50)
        Me.WinformsMap1.MapFocusMode = ThinkGeo.MapSuite.DesktopEdition.MapFocusMode.[Default]
        Me.WinformsMap1.MapResizeMode = ThinkGeo.MapSuite.Core.MapResizeMode.PreserveScale
        Me.WinformsMap1.MapUnit = ThinkGeo.MapSuite.Core.GeographyUnit.DecimalDegree
        Me.WinformsMap1.MaximumScale = 80000000000000.0R
        Me.WinformsMap1.MinimumScale = 200.0R
        Me.WinformsMap1.Name = "WinformsMap1"
        Me.WinformsMap1.Size = New System.Drawing.Size(634, 523)
        Me.WinformsMap1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        Me.WinformsMap1.TabIndex = 0
        Me.WinformsMap1.Text = "WinformsMap1"
        Me.WinformsMap1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.WinformsMap1.ThreadingMode = ThinkGeo.MapSuite.DesktopEdition.MapThreadingMode.[Default]
        Me.WinformsMap1.ZoomLevelSnapping = ThinkGeo.MapSuite.DesktopEdition.ZoomLevelSnappingMode.[Default]
        '
        'HeadingGauge
        '
        Me.HeadingGauge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HeadingGauge.BackColor = System.Drawing.Color.Transparent
        Me.HeadingGauge.DialColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HeadingGauge.DialText = "Heading"
        Me.HeadingGauge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadingGauge.ForeColor = System.Drawing.Color.Red
        Me.HeadingGauge.FromAngle = 270.0!
        Me.HeadingGauge.Glossiness = 100.0!
        Me.HeadingGauge.Location = New System.Drawing.Point(3, 1)
        Me.HeadingGauge.Margin = New System.Windows.Forms.Padding(4)
        Me.HeadingGauge.MaxValue = 360.0!
        Me.HeadingGauge.MinValue = 0!
        Me.HeadingGauge.Name = "HeadingGauge"
        Me.HeadingGauge.NoOfDivisions = 12
        Me.HeadingGauge.NoOfSubDivisions = 2
        Me.HeadingGauge.RecommendedValue = 630.0!
        Me.HeadingGauge.Size = New System.Drawing.Size(136, 136)
        Me.HeadingGauge.TabIndex = 2
        Me.HeadingGauge.ThresholdPercent = 0!
        Me.HeadingGauge.ToAngle = 630.0!
        Me.HeadingGauge.Value = 60.0!
        '
        'CourseGauge
        '
        Me.CourseGauge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CourseGauge.BackColor = System.Drawing.Color.Transparent
        Me.CourseGauge.DialColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CourseGauge.DialText = "Course"
        Me.CourseGauge.ForeColor = System.Drawing.Color.Red
        Me.CourseGauge.FromAngle = 270.0!
        Me.CourseGauge.Glossiness = 100.0!
        Me.CourseGauge.Location = New System.Drawing.Point(134, 2)
        Me.CourseGauge.MaxValue = 360.0!
        Me.CourseGauge.MinValue = 0!
        Me.CourseGauge.Name = "CourseGauge"
        Me.CourseGauge.NoOfDivisions = 12
        Me.CourseGauge.NoOfSubDivisions = 2
        Me.CourseGauge.RecommendedValue = 630.0!
        Me.CourseGauge.Size = New System.Drawing.Size(136, 136)
        Me.CourseGauge.TabIndex = 3
        Me.CourseGauge.ThresholdPercent = 0!
        Me.CourseGauge.ToAngle = 630.0!
        Me.CourseGauge.Value = 65.0!
        '
        'RudderGauge
        '
        Me.RudderGauge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RudderGauge.BackColor = System.Drawing.Color.Transparent
        Me.RudderGauge.DialColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RudderGauge.DialText = "Rudder Angle"
        Me.RudderGauge.DisplayTop = True
        Me.RudderGauge.FromAngle = 180.0!
        Me.RudderGauge.Glossiness = 100.0!
        Me.RudderGauge.Location = New System.Drawing.Point(3, 127)
        Me.RudderGauge.MaxValue = 90.0!
        Me.RudderGauge.MinValue = -90.0!
        Me.RudderGauge.Name = "RudderGauge"
        Me.RudderGauge.NoOfDivisions = 6
        Me.RudderGauge.NoOfSubDivisions = 2
        Me.RudderGauge.RecommendedValue = 360.0!
        Me.RudderGauge.Size = New System.Drawing.Size(136, 136)
        Me.RudderGauge.TabIndex = 4
        Me.RudderGauge.ThresholdPercent = 0!
        Me.RudderGauge.ToAngle = 360.0!
        Me.RudderGauge.Value = 0!
        '
        'GPSComm
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ProgressBar2)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.lblCrossTrack1)
        Me.Panel2.Controls.Add(Me.lblCrossTrack2)
        Me.Panel2.Location = New System.Drawing.Point(287, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 48)
        Me.Panel2.TabIndex = 18
        '
        'ProgressBar2
        '
        Me.ProgressBar2.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar2.Location = New System.Drawing.Point(317, 23)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(317, 24)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 18
        Me.ProgressBar2.Value = 30
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 23)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(317, 24)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 17
        Me.ProgressBar1.Value = 30
        '
        'lblCrossTrack1
        '
        Me.lblCrossTrack1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrossTrack1.ForeColor = System.Drawing.Color.Red
        Me.lblCrossTrack1.Location = New System.Drawing.Point(133, 0)
        Me.lblCrossTrack1.Name = "lblCrossTrack1"
        Me.lblCrossTrack1.Size = New System.Drawing.Size(69, 20)
        Me.lblCrossTrack1.TabIndex = 19
        Me.lblCrossTrack1.Text = "-23.5 m"
        '
        'lblCrossTrack2
        '
        Me.lblCrossTrack2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrossTrack2.ForeColor = System.Drawing.Color.Lime
        Me.lblCrossTrack2.Location = New System.Drawing.Point(428, 0)
        Me.lblCrossTrack2.Name = "lblCrossTrack2"
        Me.lblCrossTrack2.Size = New System.Drawing.Size(69, 20)
        Me.lblCrossTrack2.TabIndex = 20
        Me.lblCrossTrack2.Text = "23.5 m"
        '
        'HDTComm
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 37)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "SIMULATOR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(122, 536)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 37)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmAquaPilot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 585)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RudderGauge)
        Me.Controls.Add(Me.CourseGauge)
        Me.Controls.Add(Me.HeadingGauge)
        Me.Controls.Add(Me.WinformsMap1)
        Me.MaximizeBox = False
        Me.Name = "frmAquaPilot"
        Me.Text = "Aqua Pilot"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WinformsMap1 As ThinkGeo.MapSuite.DesktopEdition.WinformsMap
    Friend WithEvents HeadingGauge As AquaControls.AquaGauge
    Friend WithEvents CourseGauge As AquaControls.AquaGauge
    Friend WithEvents RudderGauge As AquaControls.AquaGauge
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDepth As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents GPSComm As IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCrossTrack1 As System.Windows.Forms.Label
    Friend WithEvents lblCrossTrack2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VerticalProgressBar2 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents VerticalProgressBar1 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents HDTComm As IO.Ports.SerialPort
    Friend WithEvents DPTComm As IO.Ports.SerialPort
    Friend WithEvents DriveComm As IO.Ports.SerialPort
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
