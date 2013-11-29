Imports System.Media

Public Class main
    Dim monnaie As Single = 0.0 'C'est l'argent de l'utilisateur'
    Public achat As String
    Dim curseur As Cursor
    Dim ico As Icon
    Dim monnaie_rendu As Single
    Dim moins As Single = 1.0
    Dim essai As Bitmap

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mars.Image = My.Resources.Mars
        Twix.Image = My.Resources.Twix
        Bounty.Image = My.Resources.Bounty
        mnms.Image = My.Resources.m_m_s
        Snickers.Image = My.Resources.Snickers
        PictureBox6.Image = My.Resources.Lion

        Dim x, y, height, width As Integer
        x = Me.Location.X
        y = Me.Location.Y
        height = Me.Height
        width = Me.Width

        essai = PictureBox9.Image
        essai.MakeTransparent(Color.White)
        stock.Location = New Point(x - 300, y - 70)

        voyant_lumineux.FillColor = Color.Transparent
        stock.Show()

        serialport_communication.Show()
        serialport_communication.Hide()


    End Sub

    Private Sub Mars_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mars.Click
        If monnaie >= 1 Then
            monnaie = monnaie - 1
            monnaie = Math.Round(monnaie, 2)
            Label3.Text = monnaie
            achat = "mars"
            stock.mars_stock = stock.mars_stock - 1
            AddHandler Mars.MouseLeave, AddressOf stock.affichage
            serialport_communication.impulsion()
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        monnaie = monnaie + 1.0
        Dim bmp As New Bitmap(My.Resources.curseur_1)
        ico = Icon.FromHandle(bmp.GetHicon)
        curseur = New Cursor(ico.Handle)
        Me.Cursor = curseur
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If Me.Cursor = curseur Then
            Dim sndPing As New SoundPlayer(My.Resources.coins)
            sndPing.Play()
            Me.Cursor = Cursors.Arrow
        End If
        allumer_diode_monnaie(monnaie)

    End Sub

    Private Sub Twix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Twix.Click
        If monnaie >= 1 Then
            monnaie = monnaie - moins
            monnaie = Math.Round(monnaie, 2)
            Label3.Text = monnaie
            achat = "Twix"
            stock.twix_stock = stock.twix_stock - 1
            serialport_communication.impulsion()
            AddHandler Twix.MouseLeave, AddressOf stock.affichage
            serialport_communication.impulsion()
        End If
    End Sub

    Private Sub Bounty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bounty.Click
        If monnaie >= 1 Then
            monnaie = monnaie - moins
            monnaie = Math.Round(monnaie, 2)
            Label3.Text = monnaie
            achat = "Bounty"
            stock.bounty_stock = stock.bounty_stock - 1
            AddHandler Bounty.MouseLeave, AddressOf stock.affichage
            serialport_communication.impulsion()
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Dim bmp As New Bitmap(My.Resources.curseur_2)
        ico = Icon.FromHandle(bmp.GetHicon)
        curseur = New Cursor(ico.Handle)
        Me.Cursor = curseur
        monnaie = monnaie + 2
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Dim bmp As New Bitmap(My.Resources.curseur_3)
        ico = Icon.FromHandle(bmp.GetHicon)
        curseur = New Cursor(ico.Handle)
        Me.Cursor = curseur
        monnaie = monnaie + 0.5
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Dim bmp As New Bitmap(My.Resources.curseur_4)
        ico = Icon.FromHandle(bmp.GetHicon)
        curseur = New Cursor(ico.Handle)
        Me.Cursor = curseur
        monnaie = monnaie + 0.2
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Dim bmp As New Bitmap(My.Resources.curseur_5)
        ico = Icon.FromHandle(bmp.GetHicon)
        curseur = New Cursor(ico.Handle)
        Me.Cursor = curseur
        monnaie = monnaie + 0.1
    End Sub

    Private Sub mnms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnms.Click
        If monnaie >= 1 Then
            monnaie = monnaie - moins
            monnaie = Math.Round(monnaie, 2)
            Label3.Text = monnaie
            achat = "M&M's"
            stock.mms_stock = stock.mms_stock - 1
            AddHandler mnms.MouseLeave, AddressOf stock.affichage
            serialport_communication.impulsion()
        End If
    End Sub

    Private Sub Snickers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Snickers.Click
        If monnaie >= 1 Then
            monnaie = monnaie - moins
            monnaie = Math.Round(monnaie, 2)
            Label3.Text = monnaie
            achat = "Snickers"
            stock.snickers_stock = stock.snickers_stock - 1
            AddHandler Snickers.MouseLeave, AddressOf stock.affichage
            serialport_communication.impulsion()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        monnaie = 0
        Label3.Text = ""
        Me.Cursor = Cursors.Default
        allumer_diode_monnaie(monnaie)
    End Sub

    Sub allumer_diode_monnaie(ByVal monnaie As Double)
        If monnaie >= 1 Then
            voyant_lumineux.FillColor = Color.GreenYellow
        End If
        If monnaie < 1 Then
            voyant_lumineux.FillColor = Color.Red
        End If
    End Sub

    Private Sub Lion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lion.Click
        If monnaie >= 1 Then
            monnaie = monnaie - moins
            monnaie = Math.Round(monnaie, 2)
            Label3.Text = monnaie
            achat = "Lion"
            stock.lion_stock = stock.lion_stock - 1
            AddHandler Lion.MouseLeave, AddressOf stock.affichage
            serialport_communication.impulsion()
        End If
    End Sub

End Class
