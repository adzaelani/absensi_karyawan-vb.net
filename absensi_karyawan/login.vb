Imports System.Data.OleDb
Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        konekt()
        cmd = New OleDbCommand("select * from tbllogin where username='" & unam.Text & "' and password ='" & pass.Text & "'", connect)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Form1.Show()
            Me.Hide()
            unam.Text = ""
            pass.Text = ""
        Else
            MsgBox("username atau password salah!")
            unam.Text = ""
            pass.Text = ""
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_option.Show()
        Me.Hide()

    End Sub
End Class