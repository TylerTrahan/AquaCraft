﻿Public Class frmSIM
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
        wCourse.Text = Format(frmAquaPilot.MyAquaPilot.CurrentCourseToWaypoint, "0.00")
        xTrack.Text = Format(frmAquaPilot.currentXTrack, "0.00")
        'Debug.Print(CInt(frmAquaPilot.lineBearing))
        HScrollBar3.Value = CInt(frmAquaPilot.lineBearing)
        lBearing.Text = HScrollBar3.Value
        boatHeading.Text = frmAquaPilot.MyAquaPilot.CurrentBoatHeading
        wptX.Text = Format(frmAquaPilot.MyAquaPilot.WaypointX, "0.00")
        wptY.Text = Format(frmAquaPilot.MyAquaPilot.WaypointY, "0.00")
        If frmAquaPilot.MyAquaPilot.OnLine = True Then
            LineStat.Text = "ONLINE"
            LineStat.ForeColor = Drawing.Color.Green
        Else
            LineStat.Text = "OFFLINE"
            LineStat.ForeColor = Drawing.Color.Red
        End If

    End Sub

    Private Sub boatX_TextChanged(sender As Object, e As EventArgs) Handles boatX.TextChanged
        frmAquaPilot.currentBoatXY.x = CDbl(boatX.Text)
        frmAquaPilot.MyAquaPilot.CurrentBoatX = CDbl(boatX.Text)
    End Sub

    Private Sub boatY_TextChanged(sender As Object, e As EventArgs) Handles boatY.TextChanged
        frmAquaPilot.currentBoatXY.y = CDbl(boatY.Text)
        frmAquaPilot.MyAquaPilot.CurrentBoatY = CDbl(boatY.Text)
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
        boatHeading.Text = frmAquaPilot.MyAquaPilot.CurrentBoatHeading
        vHeading.Text = boatHeading.Text
        boatX.Text = frmAquaPilot.MyAquaPilot.CurrentBoatX
        boatY.Text = frmAquaPilot.MyAquaPilot.CurrentBoatY
        wptX.Text = frmAquaPilot.MyAquaPilot.WaypointX
        wptY.Text = frmAquaPilot.MyAquaPilot.WaypointY
        StartY.Text = frmAquaPilot.MyAquaPilot.MissionPlanXY(frmAquaPilot.MyAquaPilot.MissionLine).y
        StartX.Text = frmAquaPilot.MyAquaPilot.MissionPlanXY(frmAquaPilot.MyAquaPilot.MissionLine).x
        EndY.Text = frmAquaPilot.MyAquaPilot.MissionPlanXY(frmAquaPilot.MyAquaPilot.MissionLine + 1).y
        EndX.Text = frmAquaPilot.MyAquaPilot.MissionPlanXY(frmAquaPilot.MyAquaPilot.MissionLine + 1).x


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        boatY.Text = CInt(Val(boatY.Text) + 5)
        frmAquaPilot.currentBoatXY.y = Val(boatY.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        boatY.Text = CInt(Val(boatY.Text) - 5)
        frmAquaPilot.currentBoatXY.y = Val(boatY.Text)
    End Sub

    Private Sub HScrollBar4_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar4.Scroll
        frmAquaPilot.MyAquaPilot.CurrentBoatHeading = HScrollBar4.Value
        vHeading.Text = boatHeading.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True Then
            If frmAquaPilot.sonarOpen = True Then
                'frmAquaPilot.SonarComm.WriteLine("PM2" & vbCr)
                frmAquaPilot.SonarComm.WriteLine("VE0.25" & vbCr)
                frmAquaPilot.SonarComm.WriteLine("DI-360000" & vbCr)
                frmAquaPilot.SonarComm.WriteLine("FL" & vbCr)
            End If
        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True Then
            If frmAquaPilot.sonarOpen = True Then
                'frmAquaPilot.SonarComm.WriteLine("PM2" & vbCr)
                frmAquaPilot.SonarComm.WriteLine("VE0.25" & vbCr)
                frmAquaPilot.SonarComm.WriteLine("DI360000" & vbCr)
                frmAquaPilot.SonarComm.WriteLine("FL" & vbCr)
            End If
        End If
    End Sub
End Class