Public Class frmSIM
    Private Sub HScrollBar1_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        vCourse.Text = HScrollBar1.Value
        frmAquaPilot.MyAquaPilot.CurrentBoatCourse = CDbl(vCourse.Text)
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        vSpeed.Text = HScrollBar2.Value
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar3.Scroll
        lBearing.Text = HScrollBar3.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        rAngle.Text = CStr(frmAquaPilot.MyAquaPilot.CurrentRudderAngle)
        wCourse.Text = CStr(frmAquaPilot.MyAquaPilot.CurrentCourseToWaypoint)
        xTrack.Text = CStr(frmAquaPilot.currentXTrack)
        'Debug.Print(CInt(frmAquaPilot.lineBearing))
        HScrollBar3.Value = CInt(frmAquaPilot.lineBearing)
        lBearing.Text = HScrollBar3.Value
        boatHeading.Text = frmAquaPilot.MyAquaPilot.CurrentBoatHeading



    End Sub

    Private Sub boatX_TextChanged(sender As Object, e As EventArgs) Handles boatX.TextChanged
        frmAquaPilot.currentBoatXY.x = CDbl(boatX.Text)
    End Sub

    Private Sub boatY_TextChanged(sender As Object, e As EventArgs) Handles boatY.TextChanged
        frmAquaPilot.currentBoatXY.y = CDbl(boatY.Text)
    End Sub

    Private Sub wptX_TextChanged(sender As Object, e As EventArgs) Handles wptX.TextChanged
        frmAquaPilot.MyAquaPilot.WaypointX = CDbl(wptX.Text)
    End Sub

    Private Sub wptY_TextChanged(sender As Object, e As EventArgs) Handles wptY.TextChanged
        frmAquaPilot.MyAquaPilot.WaypointY = CDbl(wptY.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.Text = "Stop"
            Timer1.Enabled = True
        Else
            CheckBox1.Text = "Start"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub frmSim_Load(sender As Object, e As EventArgs) Handles Me.Load
        'frmAquaPilot.MyAquaPilot.CurrentBoatX = CDbl(boatX.Text)
        'frmAquaPilot.MyAquaPilot.CurrentBoatY = CDbl(boatY.Text)
        'frmAquaPilot.MyAquaPilot.WaypointX = CDbl(wptX.Text)
        'frmAquaPilot.MyAquaPilot.WaypointY = CDbl(wptY.Text)
        boatX.Text = frmAquaPilot.MyAquaPilot.CurrentBoatX
        boatY.Text = frmAquaPilot.MyAquaPilot.CurrentBoatY
        wptX.Text = frmAquaPilot.MyAquaPilot.WaypointX
        wptY.Text = frmAquaPilot.MyAquaPilot.WaypointY
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        boatX.Text = CInt(Val(boatX.Text) - 5)
        frmAquaPilot.currentBoatXY.x = Val(boatX.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        boatX.Text = CInt(Val(boatX.Text) + 5)
        frmAquaPilot.currentBoatXY.x = Val(boatX.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim count As Integer
        ' send commands to move rudders in each direction for predive test
        For count = 0 To -45 Step -5
            frmAquaPilot.MyAquaPilot.SetRudderAngle(count)
            RudderTest1.Value = count
            lblAngle.Text = Format(count, "Rudder Angle: 000")
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
        For count = -45 To 0 Step 5
            frmAquaPilot.MyAquaPilot.SetRudderAngle(count)
            RudderTest1.Value = count
            lblAngle.Text = Format(count, "Rudder Angle: 000")
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
        For count = 0 To 45 Step 5
            frmAquaPilot.MyAquaPilot.SetRudderAngle(count)
            RudderTest1.Value = count
            lblAngle.Text = Format(count, "Rudder Angle: 000")
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
        For count = 45 To 0 Step -5
            frmAquaPilot.MyAquaPilot.SetRudderAngle(count)
            RudderTest1.Value = count
            lblAngle.Text = Format(count, "Rudder Angle: 000")
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim count As Integer

        For count = 0 To 100 Step 5
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(1, count)
            SpeedBar1.Value = count
            SpeedBar1.Update()
            lblSpeed.Text = Format(count, "000")
            lblSpeed.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(2, count)
            SpeedBar2.Value = count
            SpeedBar2.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
        For count = 100 To 0 Step -5
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(1, count)
            SpeedBar1.Value = count
            SpeedBar1.Update()
            lblSpeed.Text = Format(count, "000")
            lblSpeed.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(2, count)
            SpeedBar2.Value = count
            SpeedBar2.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
        For count = 0 To 100 Step 5
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(1, -count)
            SpeedBar1.Value = count
            SpeedBar1.Update()
            lblSpeed.Text = Format(-count, "000")
            lblSpeed.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(2, -count)
            SpeedBar2.Value = count
            SpeedBar2.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
        For count = 100 To 0 Step -5
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(1, -count)
            SpeedBar1.Value = count
            SpeedBar1.Update()
            lblSpeed.Text = Format(-count, "000")
            lblSpeed.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
            frmAquaPilot.MyAquaPilot.SetMotorSpeed(2, -count)
            SpeedBar2.Value = count
            SpeedBar2.Update()
            frmAquaPilot.MyAquaPilot.MySurvey1.sm_wait(100)
        Next
    End Sub
End Class