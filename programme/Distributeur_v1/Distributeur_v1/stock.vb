Public Class stock
    Public mars_stock As Integer = 50
    Public twix_stock As Integer = 50
    Public bounty_stock As Integer = 50
    Public mms_stock As Integer = 50
    Public snickers_stock As Integer = 50
    Public lion_stock As Integer = 50
    Dim stock As String = "/50"
    'Dim les_labels As Label

    Private Sub stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = mars_stock & stock
        Label2.Text = twix_stock & stock
        Label3.Text = bounty_stock & stock
        Label4.Text = mms_stock & stock
        Label5.Text = snickers_stock & stock
        Label6.Text = lion_stock & stock

        PictureBox1.Image = My.Resources.Mars
        PictureBox2.Image = My.Resources.Twix
        PictureBox3.Image = My.Resources.Bounty
        PictureBox4.Image = My.Resources.m_m_s
        PictureBox5.Image = My.Resources.Snickers
        PictureBox6.Image = My.Resources.Lion
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Attention, cela ne réinitialisera pas le compteur électronique", MsgBoxStyle.Information, "A propos du compteur électronique")
        mars_stock = 50
        twix_stock = 50
        bounty_stock = 50
        mms_stock = 50
        snickers_stock = 50
        lion_stock = 50
        affichage()

    End Sub

    Sub affichage()
        Label1.Text = mars_stock & stock
        Label2.Text = twix_stock & stock
        Label3.Text = bounty_stock & stock
        Label4.Text = mms_stock & stock
        Label5.Text = snickers_stock & stock
        Label6.Text = lion_stock & stock
        'AddHandler Label1.TextChanged
        AddHandler Label1.TextChanged, AddressOf verification_sup_a_zero
        AddHandler Label2.TextChanged, AddressOf verification_sup_a_zero
        AddHandler Label3.TextChanged, AddressOf verification_sup_a_zero
        AddHandler Label4.TextChanged, AddressOf verification_sup_a_zero
        AddHandler Label5.TextChanged, AddressOf verification_sup_a_zero
        AddHandler Label6.TextChanged, AddressOf verification_sup_a_zero
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        serialport_communication.Show()
    End Sub

    Private Sub verification_sup_a_zero()

    End Sub
End Class
