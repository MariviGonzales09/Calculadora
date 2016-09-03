Public Class Form1
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String
    Private Sub calcular()
        Select Case signo
            Case "+"
                Txt1.Text = memoria1 + memoria2
            Case "-"
                Txt1.Text = memoria1 - memoria2
            Case "*"
                Txt1.Text = memoria1 * memoria2
            Case "/"
                Txt1.Text = memoria1 / memoria2
            Case Else
                MsgBox("Error")
        End Select
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Txt1_TextChanged(sender As Object, e As EventArgs) Handles Txt1.TextChanged

    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Txt1.Text = Txt1.Text & "0"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Txt1.Text = Txt1.Text & "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Txt1.Text = Txt1.Text & "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Txt1.Text = Txt1.Text & "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Txt1.Text = Txt1.Text & "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Txt1.Text = Txt1.Text & "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Txt1.Text = Txt1.Text & "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Txt1.Text = Txt1.Text & "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Txt1.Text = Txt1.Text & "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Txt1.Text = Txt1.Text & "9"
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Try
            Dim largo As Integer
            If Txt1.Text <> "" Then
                largo = Txt1.Text.Length
                Txt1.Text = Mid(Txt1.Text, 1, largo - 1)

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        Try
            If Txt1.Text <> "" Then
                memoria1 = Val(Txt1.Text)
                signo = "+"
                Txt2.Clear()
                Txt2.Text = Txt1.Text & "+"
                Txt1.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        Try
            If Txt1.Text <> "" Then
                memoria1 = Val(Txt1.Text)
                signo = "-"
                Txt2.Clear()
                Txt2.Text = Txt1.Text & "-"
                Txt1.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click
        Try
            If Txt1.Text <> "" And memoria1 <> 0.0 Then
                memoria2 = Txt1.Text
                Txt2.Text = Txt2.Text & Txt1.Text & "="
                calcular()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click
        Try
            If Txt1.Text <> "" Then
                memoria1 = Val(Txt1.Text)
                signo = "*"
                Txt2.Clear()
                Txt2.Text = Txt1.Text & "x"
                Txt1.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click
        Try
            If Txt1.Text <> "" Then
                memoria1 = Val(Txt1.Text)
                signo = "/"
                Txt2.Clear()
                Txt2.Text = Txt1.Text & "/"
                Txt1.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function existepunto(ByVal cadena As String) As Boolean
        Dim largo As Integer
        Dim respuesta As Boolean = False
        largo = cadena.Length

        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "." Then
                respuesta = True
            End If
        Next

        Return respuesta
    End Function
    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        If Txt1.Text = "" Then
            Txt1.Text = "0."
        ElseIf existepunto(Txt1.Text) = False Then
            Txt1.Text = Txt1.Text & "."
        End If
    End Sub
End Class
