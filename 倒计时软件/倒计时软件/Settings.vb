Public Class Settings

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If Val(NumericUpDown1.Value) > 24 Then
            Label2.Visible = True
            submit.Enabled = False
        ElseIf Val(NumericUpDown1.Value) < 0 Then
            Label2.Visible = True
            submit.Enabled = False
        Else
            Label2.Visible = False
            submit.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        If Val(NumericUpDown2.Value) > 59 Then
            Label3.Visible = True
            submit.Enabled = False
        ElseIf Val(NumericUpDown2.Value) < 0 Then
            Label3.Visible = True
            submit.Enabled = False
        Else
            Label3.Visible = False
            submit.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        If Val(NumericUpDown3.Value) > 59 Then
            Label5.Visible = True
            submit.Enabled = False
        ElseIf Val(NumericUpDown3.Value) < 0 Then
            Label5.Visible = True
            submit.Enabled = False
        Else
            Label5.Visible = False
            submit.Enabled = True
        End If
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click

        Dim SS As Integer = Val(NumericUpDown1.Value) * 3600 + Val(NumericUpDown2.Value) * 60 + Val(NumericUpDown3.Value)
        Debug.Print(SS)
        Dim H As Integer = SS \ 3600
        Dim M As Integer = (SS Mod 3600) \ 60
        Dim S As Integer = (SS Mod 3600) Mod 60
        '1
        If H < 10 Then
            Main.Ho.Text = Replace("0" + Str(H), " ", "")
        Else
            Main.Ho.Text = Replace(Str(H), " ", "")
        End If

        If M < 10 Then
            Main.Mi.Text = Replace("0" + Str(M), " ", "")
        Else
            Main.Mi.Text = Replace(Str(M), " ", "")
        End If

        If S < 10 Then
            Main.Se.Text = Replace("0" + Str(S), " ", "")
        Else
            Main.Se.Text = Replace(Str(S), " ", "")
        End If
        '1

        Me.Close()

    End Sub
End Class