Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        viruslist.Visible = True
        btn_remove.Visible = False
        btn_remove_trial.Visible = True
        btn_activate.Visible = True
        lbl_activated.Visible = False
    End Sub

    Private Sub activationkey_TextChanged(sender As Object, e As EventArgs) Handles activationkey.TextChanged
        If activationkey.Text.Contains("Q5A49FEUYVL9ZX00") Then
            MsgBox("Well done! Windows AntiVirus 2009 has been activated and younow have ULTIMAT VRUS PROTECTIOM!")
            activationkey.Visible = False
            btn_remove_trial.Visible = False
            lbl_activated.Visible = True
            btn_activate.Visible = False
            viruslist.Visible = True
            btn_remove.Visible = True
        End If
    End Sub

    Private Sub btn_activate_Click(sender As Object, e As EventArgs) Handles btn_activate.Click
        activationkey.Visible = True
        btn_remove_trial.Visible = False
        viruslist.Visible = False
    End Sub

    Private Sub btn_remove_trial_Click(sender As Object, e As EventArgs) Handles btn_remove_trial.Click
        MsgBox("You need to activate to use this feature.", vbCritical + vbOKOnly, "Hold up...")
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        MsgBox("All vruses r removed!1111111!!!! ")
    End Sub
End Class
