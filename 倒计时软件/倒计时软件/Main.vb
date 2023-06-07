Public Class Main
    Public Memoey As Integer = 0
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Ho.Text = "00"
        Mi.Text = "00"
        Se.Text = "00"
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Ho.Text = "00"
        Mi.Text = "00"
        Se.Text = "30"
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Ho.Text = "00"
        Mi.Text = "01"
        Se.Text = "00"
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Ho.Text = "00"
        Mi.Text = "02"
        Se.Text = "00"
    End Sub

    Private Sub btn_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        Timer1.Enabled = True

        Dim SS As Integer
        SS = Int(Val(Ho.Text)) * 3600 + Int(Val(Mi.Text)) * 60 + Int(Val(Se.Text))


        Memoey = SS
    End Sub

    Private Sub Btn_pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pause.Click
        Timer1.Enabled = False
        
    End Sub

    Private Sub Btn_Re_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Re.Click
        Dim SS As Integer = Memoey
        Dim H As Integer = SS \ 3600
        Dim M As Integer = (SS Mod 3600) \ 60
        Dim S As Integer = (SS Mod 3600) Mod 60
        '1
        If H < 10 Then
            Ho.Text = Replace("0" + Str(H), " ", "")
        Else
            Ho.Text = Replace(Str(H), " ", "")
        End If

        If M < 10 Then
            Mi.Text = Replace("0" + Str(M), " ", "")
        Else
            Mi.Text = Replace(Str(M), " ", "")
        End If

        If S < 10 Then
            Se.Text = Replace("0" + Str(S), " ", "")
        Else
            Se.Text = Replace(Str(S), " ", "")
        End If
        '1
    End Sub

    Private Sub Btn_to_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_to_0.Click
        Ho.Text = "00"
        Mi.Text = "00"
        Se.Text = "00"
    End Sub

    Private Sub Btn_finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_finish.Click
        Timer1.Enabled = False
        Ho.Text = "00"
        Mi.Text = "00"
        Se.Text = "00"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim SS As Integer
        SS = Int(Val(Ho.Text)) * 3600 + Int(Val(Mi.Text)) * 60 + Int(Val(Se.Text))


        If SS = 0 Then
            Timer1.Enabled = False
            MsgBox("倒计时结束！", vbInformation)
            Exit Sub
        End If
        SS -= 1

        '1
        Dim H As Integer = SS \ 3600
        Dim M As Integer = (SS Mod 3600) \ 60
        Dim S As Integer = (SS Mod 3600) Mod 60

        If H < 10 Then
            Ho.Text = Replace("0" + Str(H), " ", "")
        Else
            Ho.Text = Replace(Str(H), " ", "")
        End If

        If M < 10 Then
            Mi.Text = Replace("0" + Str(M), " ", "")
        Else
            Mi.Text = Replace(Str(M), " ", "")
        End If

        If S < 10 Then
            Se.Text = Replace("0" + Str(S), " ", "")
        Else
            Se.Text = Replace(Str(S), " ", "")
        End If
        '1
        
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Settings.Show()
    End Sub


    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Process.Start("https://github.com/SWX200708/countdown")
    End Sub
End Class
