<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderMakanan
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
        Me.CBMakana = New System.Windows.Forms.ComboBox()
        Me.CBMinuman = New System.Windows.Forms.ComboBox()
        Me.ChkBoxPlus = New System.Windows.Forms.CheckBox()
        Me.TBporMakanan = New System.Windows.Forms.TextBox()
        Me.TBporMinuman = New System.Windows.Forms.TextBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelHMakana = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelHMinuman = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBMakana
        '
        Me.CBMakana.FormattingEnabled = True
        Me.CBMakana.Items.AddRange(New Object() {"Nasi Uduk", "Bakso", "Mie Ayam"})
        Me.CBMakana.Location = New System.Drawing.Point(12, 12)
        Me.CBMakana.Name = "CBMakana"
        Me.CBMakana.Size = New System.Drawing.Size(121, 21)
        Me.CBMakana.TabIndex = 0
        '
        'CBMinuman
        '
        Me.CBMinuman.FormattingEnabled = True
        Me.CBMinuman.Items.AddRange(New Object() {"Es Jeruk", "Jus Alpukat", "Teh Manis"})
        Me.CBMinuman.Location = New System.Drawing.Point(12, 88)
        Me.CBMinuman.Name = "CBMinuman"
        Me.CBMinuman.Size = New System.Drawing.Size(121, 21)
        Me.CBMinuman.TabIndex = 1
        '
        'ChkBoxPlus
        '
        Me.ChkBoxPlus.AutoSize = True
        Me.ChkBoxPlus.Location = New System.Drawing.Point(12, 51)
        Me.ChkBoxPlus.Name = "ChkBoxPlus"
        Me.ChkBoxPlus.Size = New System.Drawing.Size(157, 17)
        Me.ChkBoxPlus.TabIndex = 2
        Me.ChkBoxPlus.Text = "Termasuk dengan minuman"
        Me.ChkBoxPlus.UseVisualStyleBackColor = True
        '
        'TBporMakanan
        '
        Me.TBporMakanan.Location = New System.Drawing.Point(232, 23)
        Me.TBporMakanan.Name = "TBporMakanan"
        Me.TBporMakanan.Size = New System.Drawing.Size(100, 20)
        Me.TBporMakanan.TabIndex = 3
        '
        'TBporMinuman
        '
        Me.TBporMinuman.Location = New System.Drawing.Point(232, 58)
        Me.TBporMinuman.Name = "TBporMinuman"
        Me.TBporMinuman.Size = New System.Drawing.Size(100, 20)
        Me.TBporMinuman.TabIndex = 4
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(39, 98)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 23)
        Me.BtnHitung.TabIndex = 5
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBporMakanan)
        Me.GroupBox1.Controls.Add(Me.BtnHitung)
        Me.GroupBox1.Controls.Add(Me.TBporMinuman)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 140)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Pesanan"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(229, 103)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(24, 13)
        Me.LabelTotal.TabIndex = 13
        Me.LabelTotal.Text = "Rp."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Berapa porsi minuman"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Berapa porsi makana"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Harga"
        '
        'LabelHMakana
        '
        Me.LabelHMakana.AutoSize = True
        Me.LabelHMakana.Location = New System.Drawing.Point(288, 15)
        Me.LabelHMakana.Name = "LabelHMakana"
        Me.LabelHMakana.Size = New System.Drawing.Size(24, 13)
        Me.LabelHMakana.TabIndex = 8
        Me.LabelHMakana.Text = "Rp."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Harga"
        '
        'LabelHMinuman
        '
        Me.LabelHMinuman.AutoSize = True
        Me.LabelHMinuman.Location = New System.Drawing.Point(288, 91)
        Me.LabelHMinuman.Name = "LabelHMinuman"
        Me.LabelHMinuman.Size = New System.Drawing.Size(24, 13)
        Me.LabelHMinuman.TabIndex = 10
        Me.LabelHMinuman.Text = "Rp."
        '
        'OrderMakanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 289)
        Me.Controls.Add(Me.LabelHMinuman)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelHMakana)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkBoxPlus)
        Me.Controls.Add(Me.CBMinuman)
        Me.Controls.Add(Me.CBMakana)
        Me.Name = "OrderMakanan"
        Me.Text = "Order Makanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBMakana As ComboBox
    Friend WithEvents CBMinuman As ComboBox
    Friend WithEvents ChkBoxPlus As CheckBox
    Friend WithEvents TBporMakanan As TextBox
    Friend WithEvents TBporMinuman As TextBox
    Friend WithEvents BtnHitung As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelHMakana As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelHMinuman As Label
End Class
