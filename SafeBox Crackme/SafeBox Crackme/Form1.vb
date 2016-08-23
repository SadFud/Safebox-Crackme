Public Class Form1
    Private Hora As Integer = 0
    Private Minuto As Integer = 0
    Private Segundo As Integer = 0
    Private Milisegundo As Integer = 0
    Dim numAleatorio1 As New Random()
    Dim valor1 As Integer = numAleatorio1.Next(0, 9)
    Dim numAleatorio2 As New Random()
    Dim valor2 As Integer = numAleatorio2.Next(0, 9)
    Dim numAleatorio3 As New Random()
    Dim valor3 As Integer = numAleatorio3.Next(0, 9)
    Dim numAleatorio4 As New Random()
    Dim valor4 As Integer = numAleatorio4.Next(0, 9)
    Dim numAleatorio5 As New Random()
    Dim valor5 As Integer = numAleatorio5.Next(0, 9)


    Sub MostrarTiempo()
        LblTiempo.Text = Hora.ToString.PadLeft(2, "0") & ":"
        LblTiempo.Text &= Minuto.ToString.PadLeft(2, "0") & ":"
        LblTiempo.Text &= Segundo.ToString.PadLeft(2, "0") & ":"
        LblTiempo.Text &= Milisegundo.ToString.PadLeft(1, "0")
        LblTiempo.Refresh()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label1.Text = TrackBar1.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label2.Text = TrackBar2.Value
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Label3.Text = TrackBar3.Value
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Label4.Text = TrackBar4.Value
    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        Label5.Text = TrackBar5.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Milisegundo += 1
        If Milisegundo = 9 Then
            Milisegundo = 0
            Segundo += 1
            If Segundo = 59 Then
                Segundo = 0
                Minuto += 1
                If Minuto = 59 Then
                    Minuto += 1
                    Hora += 1
                End If
            End If
        End If
        MostrarTiempo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TrackBar1.Value = valor1 And TrackBar2.Value = valor2 And TrackBar3.Value = valor3 And TrackBar4.Value = valor4 And TrackBar5.Value = valor5 Then
            MsgBox("enhorabuena")
        Else
            MsgBox("Combinacion incorrecta")

        End If
    End Sub
End Class
