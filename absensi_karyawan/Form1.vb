Imports System.Data.OleDb
Public Class Form1
    Dim jekel As String
    Dim status As String
    Dim simpan As String
   
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilData()

        dg.Columns(0).Width = 100
        dg.Columns(1).Width = 100
        dg.Columns(2).Width = 100
        dg.Columns(3).Width = 100
        dg.Columns(4).Width = 100
        dg.Columns(5).Width = 250


    End Sub

    Sub tampilData()
        konek()
        da = New OleDbDataAdapter("select * from tblabsen", koneksi)
        dt = New DataTable
        da.Fill(dt)
        dg.DataSource = dt
        diskonek()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsp.Click
       
        konek()
        cmd = New OleDbCommand("INSERT INTO tblabsen VALUES ('" & nik.Text & "','" & nama.Text & "','" & stts.Text & "','" & join.Text & "','" & jbt.Text & "','" & file.Text & "')", koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("data berhasil di simpan")
        nik.Text = ""
        nama.Text = ""
        stts.Text = ""
        join.Text = ""
        jbt.Text = ""
        file.Text = ""
        Pb.ImageLocation = ""
        diskonek()
        tampilData()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick
        dg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
    End Sub

    Private Sub alamat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnup.Click
        konek()
        cmd = New OleDbCommand(" UPDATE tblabsen set NAMA = '" & nama.Text & "',STATUS_KERJA = '" & stts.Text & "',JABATAN = '" & jbt.Text & "',FOTO = '" & file.Text & "' WHERE NIK = '" & nik.Text & "'", koneksi)
        cmd.ExecuteNonQuery()
        MsgBox("DATA TELAH DI UPDATE")
        nik.Text = ""
        nama.Text = ""
        stts.Text = ""
        join.Text = ""
        jbt.Text = ""
        file.Text = ""
        Pb.ImageLocation = ""
        diskonek()
        tampilData()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb.Click
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnu.Click
        buka.Filter = "*.jpg |"
        buka.ShowDialog()
        file.Text = buka.FileName
        Pb.ImageLocation = file.Text
        Pb.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub dg_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dg.CellMouseClick
        On Error Resume Next
        nik.Text = dg.Rows(e.RowIndex).Cells(0).Value
        nama.Text = dg.Rows(e.RowIndex).Cells(1).Value
        jbt.Text = dg.Rows(e.RowIndex).Cells(4).Value
        join.Text = dg.Rows(e.RowIndex).Cells(3).Value
        stts.Text = dg.Rows(e.RowIndex).Cells(2).Value
        file.Text = dg.Rows(e.RowIndex).Cells(5).Value

        Pb.ImageLocation = file.Text
    End Sub

    Private Sub btnhps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhps.Click
        Dim pilih = MessageBox.Show("apakah yakin data ini akan di hapus?", "perhatian", MessageBoxButtons.YesNo)
        If pilih = vbYes Then
            konek()
            cmd = New OleDbCommand("DELETE FROM tblabsen WHERE  NIK ='" & nik.Text & "'", koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil di hapus")
            nik.Text = ""
            nama.Text = ""
            stts.Text = ""
            join.Text = ""
            jbt.Text = ""
            file.Text = ""
            Pb.ImageLocation = ""
            diskonek()
            tampilData()

        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        konek()
        cmd = New OleDbCommand("select * from tblabsen where NAMA like '%" & txtcari.Text & "%'", koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            konek()
            da = New OleDbDataAdapter("select * from tblabsen where NAMA like '%" & txtcari.Text & "%'", koneksi)
            ds = New DataSet
            da.Fill(ds)
            dg.DataSource = ds.Tables(0)
        Else
            MsgBox("data tidak ada")

        End If
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub InputDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputDataToolStripMenuItem.Click

        Me.Hide()
        Me.Show()
    End Sub

    Private Sub ViewPresenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPresenceToolStripMenuItem.Click
        presence.Show()
        Me.Hide()

    End Sub
End Class
