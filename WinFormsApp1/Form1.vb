Imports QRCoder
Imports System.Drawing
Public Class Form1
    Dim imagenFondoQR As Bitmap = Nothing
    Dim Explorador As New OpenFileDialog()

    Public Sub GenerarQR()
        Try
            If String.IsNullOrWhiteSpace(LinkLbl.Text) Then Return
            Dim generadorQR As New QRCodeGenerator
            Dim qrCodeDato As QRCodeData = generadorQR.CreateQrCode(LinkLbl.Text, QRCodeGenerator.ECCLevel.H)
            Dim qrCode As New QRCode(qrCodeDato)
            Dim colorCuadritos As Color = Color.Black
            Dim colorFondo As Color = If(RadioBtnImage.Checked, Color.Transparent, Color.White)
            Dim qrImage As Bitmap = qrCode.GetGraphic(20, Color.Black, colorFondo, Nothing, 15)
            Dim resultadoFinal As New Bitmap(qrImage.Width, qrImage.Height)
            Dim imagenFondoQr As Bitmap = Nothing

            'pinto el panel de btn radio color
            If RadioBtnColor.Checked Then

                'pinto el panel con el color elegido
                colorFondo = PnlMuestraColor.BackColor

                'genero el QR con el color elegido
                PicBoxPrevia.Image = qrCode.GetGraphic(20, Color.Black, colorFondo, Nothing, 15)



            ElseIf RadioBtnImage.Checked Then

                PicBoxPrevia.Image = qrCode.GetGraphic(20, Color.Black, Color.Transparent, resultadoFinal, 15)

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'limpiamos label link para que muestre la direccion del QR'
        LinkLbl.Text = ""
        Select Case ComboBox1.SelectedIndex
            Case 0
                TxtBoxDetalles.Enabled = False
                TxtBoxDetalles.Text = ("Seleccione una opcion del paso 1")
                TxtBoxDetalles.ForeColor = Color.Gray


                '           Case 1, 4
                '              BtnExaminar.Enabled = False

                'contacto o texto para abrir el explorador de archivos
                '              TxtBoxDetalles.Enabled = False
                '             Explorador.Title = "Seleccione el archivo"
                '            If Explorador.ShowDialog = DialogResult.OK Then
                '           Dim Ruta As String = Explorador.FileName
                '
                '     'mostramos la ruta del archivo en el Txtbox del paso 2
                '     TxtBoxDetalles.Text = Ruta

                'ahora la mostramos en el link label
                '     LinkLbl.Text = Ruta

           '     End If

            Case 2
                BtnExaminar.Enabled = False
                TxtBoxDetalles.Enabled = False
                Dim Ventana As New Form2()
                Ventana.ShowDialog()


            Case 3, 1, 4
                'desactivo el boton de examinar y el textbox para que no se pueda escribir nada
                BtnExaminar.Enabled = False
                TxtBoxDetalles.Enabled = False

                'creo variable para guardar el resultado del inputbox y agrego que debe empezar con https://
                Dim url As String = InputBox("Ingrese la dirección web:", "Ingrese el URL", "https://")

                'valido que no deje el input vacio
                If String.IsNullOrEmpty(url) Then
                    MessageBox.Show("Operación cancelada por el usuario.", "Aviso")
                    Exit Sub
                End If
                'valido que el url empiece con https:// y si no es asi le agrego https:// al inicio
                If Not url.StartsWith("https://") AndAlso Not url.StartsWith("http://") Then
                    url = "https://" & url
                End If
                'muestro la Url en el link label
                LinkLbl.Text = url


            Case 5
                TxtBoxDetalles.Text = ("Escriba o adjunte lo que desea compartir en el QR")
                BtnExaminar.Enabled = True
                TxtBoxDetalles.Enabled = True
                TxtBoxDetalles.Text = ("Escribir o adjuntar lo que desea compartir en el QR")






        End Select
    End Sub

    Private Sub RadioBtnColor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtnColor.CheckedChanged
        If RadioBtnColor.Checked Then

            ' 1. Creamos la instancia del selector de colores de Windows
            Dim selectorColor As New ColorDialog()

            ' 2. Opcional: Permitir que el usuario defina colores personalizados
            selectorColor.FullOpen = True
            selectorColor.Color = Color.White ' Color inicial por defecto

            ' 3. Abrimos el formulario de colores y verificamos si el usuario dio a "Aceptar"
            If selectorColor.ShowDialog() = DialogResult.OK Then

                'mostramos el color elegido en el panel
                PnlMuestraColor.BackColor = selectorColor.Color


                ' 5. ¡Generamos el QR con el nuevo color!
                GenerarQR()
            Else
                ' Si el usuario cancela, podemos desmarcar el RadioButton 
                ' o volver al color simple para evitar errores
                RadioBtnSimple.Checked = True
            End If
        End If
    End Sub

    Private Sub RadioBtnImage_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBtnImage.CheckedChanged
        If RadioBtnImage.Checked Then
            Using Explorador As New OpenFileDialog()
                Explorador.Title = "Seleccione una imagen"
                Explorador.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"
                If Explorador.ShowDialog = DialogResult.OK Then
                    imagenFondoQR = New Bitmap(Explorador.FileName)
                    GenerarQR()

                Else
                    RadioBtnSimple.Checked = True

                End If
            End Using

        End If

    End Sub

    Private Sub BtnAgregarLogo_Click(sender As Object, e As EventArgs) Handles BtnAgregarLogo.Click
        Using Explorador As New OpenFileDialog()
            Explorador.Filter = "Imágenes|*.jpg;*.png;*.bmp"
            If Explorador.ShowDialog() = DialogResult.OK Then
                ' Guardamos la imagen y marcamos el RadioButton de fondo
                imagenFondoQR = New Bitmap(Explorador.FileName)
                RadioBtnImage.Checked = True ' Esto disparará el evento y llamará a GenerarQR()
                GenerarQR() ' Por seguridad lo llamamos manualmente también
            End If
        End Using
    End Sub

    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles BtnExaminar.Click
        Using Explorador As New OpenFileDialog()
            Explorador.Title = "Seleccione un archivo"
            If Explorador.ShowDialog = DialogResult.OK Then
                LinkLbl.Text = Explorador.FileName

            End If
        End Using
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click

    End Sub
End Class
