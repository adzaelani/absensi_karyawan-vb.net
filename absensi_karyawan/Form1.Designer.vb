<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nik = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.join = New System.Windows.Forms.DateTimePicker()
        Me.jbt = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnu = New System.Windows.Forms.Button()
        Me.btnsp = New System.Windows.Forms.Button()
        Me.file = New System.Windows.Forms.TextBox()
        Me.btnup = New System.Windows.Forms.Button()
        Me.btnhps = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.buka = New System.Windows.Forms.OpenFileDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Pb = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stts = New System.Windows.Forms.ComboBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPresenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAMA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "JOIN"
        '
        'nik
        '
        Me.nik.Location = New System.Drawing.Point(149, 109)
        Me.nik.Name = "nik"
        Me.nik.Size = New System.Drawing.Size(200, 20)
        Me.nik.TabIndex = 9
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(149, 140)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(200, 20)
        Me.nama.TabIndex = 10
        '
        'join
        '
        Me.join.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.join.Location = New System.Drawing.Point(149, 222)
        Me.join.Name = "join"
        Me.join.Size = New System.Drawing.Size(200, 20)
        Me.join.TabIndex = 16
        '
        'jbt
        '
        Me.jbt.FormattingEnabled = True
        Me.jbt.Items.AddRange(New Object() {"DIREKSI", "DIREKTUR", "MANAGER", "DIVISI", "OPERATOR PRODUKSI"})
        Me.jbt.Location = New System.Drawing.Point(149, 265)
        Me.jbt.Name = "jbt"
        Me.jbt.Size = New System.Drawing.Size(200, 21)
        Me.jbt.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "JABATAN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(486, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "FOTO"
        '
        'btnu
        '
        Me.btnu.Location = New System.Drawing.Point(568, 224)
        Me.btnu.Name = "btnu"
        Me.btnu.Size = New System.Drawing.Size(125, 23)
        Me.btnu.TabIndex = 23
        Me.btnu.Text = "UNGGAH FILE"
        Me.btnu.UseVisualStyleBackColor = True
        '
        'btnsp
        '
        Me.btnsp.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnsp.Location = New System.Drawing.Point(36, 320)
        Me.btnsp.Name = "btnsp"
        Me.btnsp.Size = New System.Drawing.Size(125, 23)
        Me.btnsp.TabIndex = 24
        Me.btnsp.Text = "SIMPAN"
        Me.btnsp.UseVisualStyleBackColor = True
        '
        'file
        '
        Me.file.Location = New System.Drawing.Point(568, 198)
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(125, 20)
        Me.file.TabIndex = 25
        '
        'btnup
        '
        Me.btnup.Location = New System.Drawing.Point(319, 320)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(125, 23)
        Me.btnup.TabIndex = 26
        Me.btnup.Text = "UPDATE "
        Me.btnup.UseVisualStyleBackColor = True
        '
        'btnhps
        '
        Me.btnhps.Location = New System.Drawing.Point(568, 320)
        Me.btnhps.Name = "btnhps"
        Me.btnhps.Size = New System.Drawing.Size(125, 23)
        Me.btnhps.TabIndex = 27
        Me.btnhps.Text = "DELETE"
        Me.btnhps.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(2, 418)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(789, 288)
        Me.dg.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(568, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "FILE:"
        '
        'Pb
        '
        Me.Pb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Pb.ErrorImage = Nothing
        Me.Pb.Image = Global.absensi_karyawan.My.Resources.Resources.blank_profile_picture_973460_960_720
        Me.Pb.InitialImage = Nothing
        Me.Pb.Location = New System.Drawing.Point(453, 110)
        Me.Pb.Name = "Pb"
        Me.Pb.Size = New System.Drawing.Size(109, 137)
        Me.Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb.TabIndex = 20
        Me.Pb.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "STATUS KERJA"
        '
        'stts
        '
        Me.stts.FormattingEnabled = True
        Me.stts.Items.AddRange(New Object() {"KARYAWAN", "KONTRAK"})
        Me.stts.Location = New System.Drawing.Point(149, 182)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(200, 21)
        Me.stts.TabIndex = 34
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(90, 392)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(190, 20)
        Me.txtcari.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "cari karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA KARYAWAN"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(683, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "LOG OUT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1311, 61)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(791, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.InputDataToolStripMenuItem.Text = "New Data"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPresenceToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ViewToolStripMenuItem.Text = "view"
        '
        'ViewPresenceToolStripMenuItem
        '
        Me.ViewPresenceToolStripMenuItem.Name = "ViewPresenceToolStripMenuItem"
        Me.ViewPresenceToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ViewPresenceToolStripMenuItem.Text = "View Presence"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(791, 694)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.stts)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btnhps)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.file)
        Me.Controls.Add(Me.btnsp)
        Me.Controls.Add(Me.btnu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Pb)
        Me.Controls.Add(Me.jbt)
        Me.Controls.Add(Me.join)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nik)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUT "
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nik As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents join As System.Windows.Forms.DateTimePicker
    Friend WithEvents jbt As System.Windows.Forms.ComboBox
    Friend WithEvents Pb As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnu As System.Windows.Forms.Button
    Friend WithEvents btnsp As System.Windows.Forms.Button
    Friend WithEvents file As System.Windows.Forms.TextBox
    Friend WithEvents btnup As System.Windows.Forms.Button
    Friend WithEvents btnhps As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents buka As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents stts As System.Windows.Forms.ComboBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPresenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
