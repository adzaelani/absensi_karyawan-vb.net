<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formabsen
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
        Me.components = New System.ComponentModel.Container()
        Me.txtcl = New System.Windows.Forms.MonthCalendar()
        Me.tbnik = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnm = New System.Windows.Forms.Label()
        Me.txtin = New System.Windows.Forms.Label()
        Me.txtout = New System.Windows.Forms.Label()
        Me.txtket = New System.Windows.Forms.Label()
        Me.rbm = New System.Windows.Forms.RadioButton()
        Me.rbp = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txttg = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcl
        '
        Me.txtcl.Enabled = False
        Me.txtcl.Location = New System.Drawing.Point(18, 47)
        Me.txtcl.Name = "txtcl"
        Me.txtcl.TabIndex = 0
        '
        'tbnik
        '
        Me.tbnik.Location = New System.Drawing.Point(135, 253)
        Me.tbnik.Name = "tbnik"
        Me.tbnik.Size = New System.Drawing.Size(157, 20)
        Me.tbnik.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JAM"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MASUKAN NIK ANDA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "WAKTU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NAMA          :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CHECK IN    :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CHECK OUT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "KET             :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(156, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 29)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "CHECKER"
        '
        'txtnm
        '
        Me.txtnm.AutoSize = True
        Me.txtnm.Location = New System.Drawing.Point(140, 286)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(10, 13)
        Me.txtnm.TabIndex = 10
        Me.txtnm.Text = "-"
        '
        'txtin
        '
        Me.txtin.AutoSize = True
        Me.txtin.Location = New System.Drawing.Point(141, 335)
        Me.txtin.Name = "txtin"
        Me.txtin.Size = New System.Drawing.Size(10, 13)
        Me.txtin.TabIndex = 11
        Me.txtin.Text = "-"
        '
        'txtout
        '
        Me.txtout.AutoSize = True
        Me.txtout.Location = New System.Drawing.Point(141, 362)
        Me.txtout.Name = "txtout"
        Me.txtout.Size = New System.Drawing.Size(10, 13)
        Me.txtout.TabIndex = 12
        Me.txtout.Text = "-"
        '
        'txtket
        '
        Me.txtket.AutoSize = True
        Me.txtket.Location = New System.Drawing.Point(141, 385)
        Me.txtket.Name = "txtket"
        Me.txtket.Size = New System.Drawing.Size(10, 13)
        Me.txtket.TabIndex = 13
        Me.txtket.Text = "-"
        '
        'rbm
        '
        Me.rbm.AutoSize = True
        Me.rbm.Location = New System.Drawing.Point(135, 230)
        Me.rbm.Name = "rbm"
        Me.rbm.Size = New System.Drawing.Size(66, 17)
        Me.rbm.TabIndex = 14
        Me.rbm.TabStop = True
        Me.rbm.Text = "MASUK "
        Me.rbm.UseVisualStyleBackColor = True
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(223, 230)
        Me.rbp.Name = "rbp"
        Me.rbp.Size = New System.Drawing.Size(69, 17)
        Me.rbp.TabIndex = 15
        Me.rbp.TabStop = True
        Me.rbp.Text = "PULANG"
        Me.rbp.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txttg
        '
        Me.txttg.AutoSize = True
        Me.txttg.Location = New System.Drawing.Point(142, 308)
        Me.txttg.Name = "txttg"
        Me.txttg.Size = New System.Drawing.Size(10, 13)
        Me.txttg.TabIndex = 18
        Me.txttg.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(66, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "TANGGAL   :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "LOGIN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Formabsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 409)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txttg)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rbp)
        Me.Controls.Add(Me.rbm)
        Me.Controls.Add(Me.txtket)
        Me.Controls.Add(Me.txtout)
        Me.Controls.Add(Me.txtin)
        Me.Controls.Add(Me.txtnm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbnik)
        Me.Controls.Add(Me.txtcl)
        Me.Name = "Formabsen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formabsen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcl As System.Windows.Forms.MonthCalendar
    Friend WithEvents tbnik As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnm As System.Windows.Forms.Label
    Friend WithEvents txtin As System.Windows.Forms.Label
    Friend WithEvents txtout As System.Windows.Forms.Label
    Friend WithEvents txtket As System.Windows.Forms.Label
    Friend WithEvents rbm As System.Windows.Forms.RadioButton
    Friend WithEvents rbp As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txttg As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
