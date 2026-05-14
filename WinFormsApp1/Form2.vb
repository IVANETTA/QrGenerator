Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'guardamos eltexto intoducido en nombre de red y contraseña
        Dim usuario As String = TxtRed.Text
        Dim password As String = TxtContr.Text
        'guardo el texto seleccionad en el comboText y lo convierto a string
        Dim seguridad As String = CmbTextWifi.SelectedItem.ToString()
        'creo cadena para formato de QR de Wifi
        Dim CadenaFinal As String = $"WIFI:S:{usuario};t:{seguridad};P:{password};;"
        Form1.LinkLbl.Text = CadenaFinal
        Me.Close()

    End Sub

End Class