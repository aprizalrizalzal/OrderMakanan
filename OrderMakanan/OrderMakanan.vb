Public Class OrderMakanan
    Public hargaMakanan, hargaMinuman As Integer

    Private Sub CBMakana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMakana.SelectedIndexChanged
        Select Case CBMakana.Text
            Case "Nasi Uduk"
                LabelHMakana.Text = "Rp.3500"
                hargaMakanan = 3500
            Case "Bakso"
                LabelHMakana.Text = "Rp.6000"
                hargaMakanan = 6000
            Case "Mie Ayam"
                LabelHMakana.Text = "Rp.7000"
                hargaMakanan = 7000
        End Select
    End Sub

    Private Sub CBMinuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMinuman.SelectedIndexChanged
        Select Case CBMinuman.Text
            Case "Es Jeruk"
                LabelHMinuman.Text = "Rp.3000"
                hargaMinuman = 3000
            Case "Jus Alpukat"
                LabelHMinuman.Text = "Rp.7000"
                hargaMinuman = 6000
            Case "Teh Manis"
                LabelHMinuman.Text = "Rp.4000"
                hargaMinuman = 4000
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        CBMinuman.Visible = False
        Label3.Visible = False
        LabelHMinuman.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ChkBoxPlus_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxPlus.CheckedChanged
        If ChkBoxPlus.Checked = False Then
            CBMinuman.Visible = False
            Label3.Visible = False
            LabelHMinuman.Visible = False
        Else
            CBMinuman.Visible = True
            Label3.Visible = True
            LabelHMinuman.Visible = True
        End If
    End Sub
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim porsiMaknan, porsiMinuman, jummlah As Integer
        porsiMaknan = TBporMakanan.Text
        porsiMinuman = TBporMinuman.Text
        jummlah = (hargaMakanan * porsiMaknan) + (hargaMinuman * porsiMinuman)
        LabelTotal.Text = "Rp. " & jummlah.ToString
    End Sub
End Class
