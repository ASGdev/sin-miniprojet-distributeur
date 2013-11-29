Imports System.IO.Ports
Imports System.Threading


Public Class serialport_communication
    Dim s As New SerialPort

    Private Sub serialport_communication_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ports As String() = SerialPort.GetPortNames()
        Dim port As String
        For Each port In ports
            ListBox1.Items.Add(port)
        Next port
        If s.RtsEnable = True Then
            PictureBox1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            s.Close()
            s.PortName = ListBox1.SelectedItem
            s.BaudRate = 9600
            s.DataBits = 8
            s.Parity = Parity.None
            s.StopBits = StopBits.One
            s.Handshake = Handshake.None
        Catch ex As Exception
            MsgBox("Pas de port série trouvé", MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If s.IsOpen Then GoTo 1
            s.Open()
1:          s.RtsEnable = True
        Catch ex As Exception
            MsgBox("Veuillez sélectionner un port série", MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            s.RtsEnable = False
            s.Close()
        Catch ex As Exception
            MsgBox("Veuillez sélectionner un port série", MsgBoxStyle.Critical, "Erreur")
        End Try
    End Sub

    Sub desactive_rts_mainload()
        s.RtsEnable = False
        s.Close()
    End Sub

    Sub impulsion()
        Try
            'MsgBox("la")
            s.Open()
            s.RtsEnable = True
            Thread.Sleep(50)
            s.RtsEnable = False
            s.Close()
            'MsgBox("Fin")
        Catch ex As Exception
        End Try
    End Sub
End Class