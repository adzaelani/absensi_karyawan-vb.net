Imports System.Data.OleDb
Module Mdkoneksi
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dt As DataTable
    Public ds As DataSet
    Public ketemu As Boolean

    Public koneksi As New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0; Data Source=dbabsensi.accdb ")

    Sub konek()
        Try
            koneksi.Open()
            'MsgBox("koneksi berhasil")
        Catch ex As Exception
            'MsgBox(ex.Message)
            'MsgBox("koneksi gagal")
        End Try
    End Sub

    Sub diskonek()
        koneksi.Close()
    End Sub

    Public connect As New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0; Data Source=dblogin.accdb ")

    Sub konekt()
        Try
            connect.Open()
            'MsgBox("koneksi berhasil")
        Catch ex As Exception
            'MsgBox(ex.Message)
            'MsgBox("koneksi gagal")
        End Try
    End Sub

    Public con As New OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0; Data Source=dbcheck.accdb ")

    Sub co()
        Try
            con.Open()
            'MsgBox("koneksi berhasil")
        Catch ex As Exception
            'MsgBox(ex.Message)
            'MsgBox("koneksi gagal")
        End Try
    End Sub

    Sub discon()
        con.Close()

    End Sub


End Module
