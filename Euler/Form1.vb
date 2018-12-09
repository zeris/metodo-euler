Imports info.lundin.math

Public Class Calcular
    Dim i As Integer
    Dim cs As Single
    Dim x, y, auxiliar, h, valorFinal As Single

    Private Sub btnEulerMejorado_Click(sender As Object, e As EventArgs) Handles btnEulerMejorado.Click
        i = 0
        x = tbX.Text
        y = tbY.Text
        h = tbH.Text
        valorFinal = tbValorAEvaluar.Text
        cs = tbCS.Text
        redon = cs + 2

        Salida.Rows.Add("Y" + i.ToString, x, y)

        Do While valorFinal > x
            auxiliar = y + h * f(x, y)
            y = y + (h / 2) * ((f(x, y)) + (f((x + h), auxiliar)))
            x = x + h
            i = i + 1
            Salida.Rows.Add("Y" + i.ToString, x, Math.Round(y, redon))
        Loop

        Salida.Rows.Add("Por lo tanto", "y(" + valorFinal.ToString + ") = ", Math.Round(y, redon))
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        tbFuncion.Text = ""
        tbH.Text = ""
        tbX.Text = ""
        tbY.Text = ""
        tbValorAEvaluar.Text = ""
        Salida.Rows.Clear()
    End Sub

    Dim redon As Integer

    Function f(x As Single, y As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("pi", 3.1416)
        parser.Values.Add("e", 2.7183)
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        Return parser.Parse(tbFuncion.Text)
    End Function

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        i = 0
        x = tbX.Text
        y = tbY.Text
        h = tbH.Text
        cs = tbCS.Text
        redon = cs + 2
        valorFinal = tbValorAEvaluar.Text


        Salida.Rows.Add("Y" + i.ToString, x, y)

        Do While valorFinal > x
            y = y + h * f(x, y)
            x = x + h
            i = i + 1
            Salida.Rows.Add("Y" + i.ToString, x, Math.Round(y, redon))
        Loop

        Salida.Rows.Add("Por lo tanto", "y(" + valorFinal.ToString + ") = ", Math.Round(y, redon))

    End Sub

    Private Sub Calcular_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
