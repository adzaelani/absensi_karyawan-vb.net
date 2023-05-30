Imports System.Data.OleDb
Public Class presence
    
    Private Sub presence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilData()

    End Sub

    Sub tampilData()
        co()
        da = New OleDbDataAdapter("select * from dtabsen", con)
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
        discon()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcr.TextChanged
        co()
        cmd = New OleDbCommand("select * from dtabsen where NAMA like '%" & txtcr.Text & "%'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            konek()
            da = New OleDbDataAdapter("select * from dtabsen where NAMA like '%" & txtcr.Text & "%'", con)
            ds = New DataSet
            da.Fill(ds)
            dgv.DataSource = ds.Tables(0)
        Else
            MsgBox("data tidak ada")

        End If
    End Sub
End Class