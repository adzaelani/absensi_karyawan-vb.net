Imports System.Data.OleDb
Public Class Formabsen

    Sub delete()
        tbnik.Text = ""
        rbm.Checked = False
        rbp.Checked = False
        txtnm.Text = ""
        txtin.Text = ""
        txtout.Text = ""
        txtket.Text = ""
        txttg.Text = ""
    End Sub
    Private Sub Formabsen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbnik.KeyPress
        If e.KeyChar = Chr(13) Then
            konek()
            cmd = New OleDbCommand("SELECT * from tblabsen where NIK = '" & tbnik.Text & "' ", koneksi)
            dr = cmd.ExecuteReader


            If dr.Read Then
                txtnm.Text = dr.Item(1)
                If rbm.Checked Then
                    txtin.Text = TimeOfDay
                    txttg.Text = txtcl.SelectionStart



                    co()
                    cmd = New OleDbCommand("INSERT INTO dtabsen VALUES ('" & tbnik.Text & "','" & txtnm.Text & "','" & txttg.Text & "','" & txtin.Text & "','" & txtout.Text & "','" & txtket.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    'MsgBox("data berhasil di simpan")
                Else
                    txtout.Text = TimeOfDay
                    txttg.Text = txtcl.SelectionStart

                    co()
                    cmd = New OleDbCommand("SELECT * from dtabsen where NIK = '" & tbnik.Text & "' ", con)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    txtin.Text = dr.Item(3)

                    cmd = New OleDbCommand("UPDATE dtabsen SET NAMA= '" & txtnm.Text & "',PULANG= '" & txtout.Text & "' WHERE NIK = '" & tbnik.Text & "'", con)
                    cmd.ExecuteNonQuery()
                    'MsgBox("data berhasil di simpan")

                End If


                    'MsgBox("data berhasil di simpan")

                    ketemu = True
                Else
                    ketemu = False
                    MsgBox("data tidak ada")

                    tbnik.Text = ""
                    rbm.Checked = False
                    rbp.Checked = False
                End If
            End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        delete()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form_option.Show()
        Me.Hide()
    End Sub
End Class