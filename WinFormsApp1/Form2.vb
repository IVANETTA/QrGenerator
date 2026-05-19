Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If CmbTextWifi.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, seleccione el tipo de seguridad.", "Aviso")
                Exit Sub
            End If

            'guardamos eltexto intoducido en nombre de red y contraseña
            Dim usuario As String = TxtRed.Text
            Dim password As String = TxtContr.Text
            'guardo el texto seleccionad en el comboText y lo convierto a string
            Dim seguridad As String = CmbTextWifi.SelectedItem.ToString()
            If CmbTextWifi.SelectedIndex = 4 Then
                seguridad = InputBox("Ingrese el tipo de seguridad:")
            End If

            'creo cadena para formato de QR de Wifi
            Dim CadenaFinal As String = $"WIFI:S:{usuario};t:{seguridad};P:{password};;"
            Form1.LinkLbl.Text = CadenaFinal
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Red invalida o inexistente " & ex.Message)
        End Try
    End Sub

End Class