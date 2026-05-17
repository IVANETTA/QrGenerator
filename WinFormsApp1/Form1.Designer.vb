<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SplitContainer1 = New SplitContainer()
        BtnExaminar = New Button()
        PnlMuestraColor = New Panel()
        RadioBtnSimple = New RadioButton()
        Label7 = New Label()
        RadioBtnImage = New RadioButton()
        TxtBoxDetalles = New TextBox()
        RadioBtnColor = New RadioButton()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        SplitContainer2 = New SplitContainer()
        LinkLbl = New LinkLabel()
        BtnAgregarLogo = New Button()
        Label3 = New Label()
        PicBoxPrevia = New PictureBox()
        BtnGenerar = New Button()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label6 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        ColorDialog = New ColorDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(PicBoxPrevia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(822, 72)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MV Boli", 18.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.IndianRed
        Label2.Location = New Point(118, 11)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(296, 32)
        Label2.TabIndex = 3
        Label2.Text = "QR Custom PRO v2.0.1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 11)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.QR_Code_PNG_Background_Image
        PictureBox1.InitialImage = My.Resources.Resources.QR_Code_PNG_Background_Image
        PictureBox1.Location = New Point(16, 3)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(88, 66)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.Controls.Add(Button2)
        FlowLayoutPanel1.Controls.Add(Button3)
        FlowLayoutPanel1.Dock = DockStyle.Right
        FlowLayoutPanel1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FlowLayoutPanel1.Location = New Point(469, 0)
        FlowLayoutPanel1.Margin = New Padding(0, 3, 4, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(353, 72)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(4, 3)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 23)
        Button1.TabIndex = 0
        Button1.Text = "Configuración"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(133, 3)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 23)
        Button2.TabIndex = 1
        Button2.Text = "Ayuda"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(238, 3)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 23)
        Button3.TabIndex = 2
        Button3.Text = "Acerca de..."
        Button3.UseVisualStyleBackColor = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 72)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(BtnExaminar)
        SplitContainer1.Panel1.Controls.Add(PnlMuestraColor)
        SplitContainer1.Panel1.Controls.Add(RadioBtnSimple)
        SplitContainer1.Panel1.Controls.Add(Label7)
        SplitContainer1.Panel1.Controls.Add(RadioBtnImage)
        SplitContainer1.Panel1.Controls.Add(TxtBoxDetalles)
        SplitContainer1.Panel1.Controls.Add(RadioBtnColor)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(ComboBox1)
        SplitContainer1.Panel1.Controls.Add(Label4)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(822, 249)
        SplitContainer1.SplitterDistance = 245
        SplitContainer1.TabIndex = 1
        ' 
        ' BtnExaminar
        ' 
        BtnExaminar.Font = New Font("Mongolian Baiti", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnExaminar.Location = New Point(168, 87)
        BtnExaminar.Name = "BtnExaminar"
        BtnExaminar.Size = New Size(74, 20)
        BtnExaminar.TabIndex = 6
        BtnExaminar.Text = "examinar"
        BtnExaminar.UseVisualStyleBackColor = True
        ' 
        ' PnlMuestraColor
        ' 
        PnlMuestraColor.Location = New Point(159, 149)
        PnlMuestraColor.Name = "PnlMuestraColor"
        PnlMuestraColor.Size = New Size(37, 31)
        PnlMuestraColor.TabIndex = 5
        ' 
        ' RadioBtnSimple
        ' 
        RadioBtnSimple.AutoSize = True
        RadioBtnSimple.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Italic)
        RadioBtnSimple.Location = New Point(8, 210)
        RadioBtnSimple.Name = "RadioBtnSimple"
        RadioBtnSimple.Size = New Size(77, 20)
        RadioBtnSimple.TabIndex = 3
        RadioBtnSimple.TabStop = True
        RadioBtnSimple.Text = "QR simple"
        RadioBtnSimple.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(8, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(188, 18)
        Label7.TabIndex = 4
        Label7.Text = "3. Selecciona una opcíon:"
        ' 
        ' RadioBtnImage
        ' 
        RadioBtnImage.AutoSize = True
        RadioBtnImage.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Italic)
        RadioBtnImage.Location = New Point(8, 185)
        RadioBtnImage.Name = "RadioBtnImage"
        RadioBtnImage.Size = New Size(150, 20)
        RadioBtnImage.TabIndex = 1
        RadioBtnImage.TabStop = True
        RadioBtnImage.Text = "QR con imagen de fondo"
        RadioBtnImage.UseVisualStyleBackColor = True
        ' 
        ' TxtBoxDetalles
        ' 
        TxtBoxDetalles.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBoxDetalles.ForeColor = SystemColors.WindowFrame
        TxtBoxDetalles.HideSelection = False
        TxtBoxDetalles.Location = New Point(8, 87)
        TxtBoxDetalles.Name = "TxtBoxDetalles"
        TxtBoxDetalles.Size = New Size(150, 20)
        TxtBoxDetalles.TabIndex = 4
        TxtBoxDetalles.Text = "en el caso de seleccionar ""otro"""
        ' 
        ' RadioBtnColor
        ' 
        RadioBtnColor.AutoSize = True
        RadioBtnColor.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RadioBtnColor.Location = New Point(8, 160)
        RadioBtnColor.Name = "RadioBtnColor"
        RadioBtnColor.Size = New Size(140, 20)
        RadioBtnColor.TabIndex = 0
        RadioBtnColor.TabStop = True
        RadioBtnColor.Text = "QR con color de fondo"
        RadioBtnColor.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(8, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 18)
        Label5.TabIndex = 3
        Label5.Text = "2. Ingrese Detalles"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Selecciona una opción", "Contactos (vCard)", "Wi-Fi Network ", "Website URL", "Texto", "Otro"})
        ComboBox1.Location = New Point(8, 30)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(168, 22)
        ComboBox1.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(8, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 18)
        Label4.TabIndex = 0
        Label4.Text = "1. Configure su código QR!"
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(LinkLbl)
        SplitContainer2.Panel1.Controls.Add(BtnAgregarLogo)
        SplitContainer2.Panel1.Controls.Add(Label3)
        SplitContainer2.Panel1.Controls.Add(PicBoxPrevia)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(BtnGenerar)
        SplitContainer2.Panel2.Controls.Add(RadioButton8)
        SplitContainer2.Panel2.Controls.Add(RadioButton7)
        SplitContainer2.Panel2.Controls.Add(RadioButton6)
        SplitContainer2.Panel2.Controls.Add(RadioButton5)
        SplitContainer2.Panel2.Controls.Add(RadioButton4)
        SplitContainer2.Panel2.Controls.Add(Label6)
        SplitContainer2.Size = New Size(573, 249)
        SplitContainer2.SplitterDistance = 306
        SplitContainer2.TabIndex = 0
        ' 
        ' LinkLbl
        ' 
        LinkLbl.AutoSize = True
        LinkLbl.Font = New Font("Cambria", 9.75F, FontStyle.Bold)
        LinkLbl.Location = New Point(67, 198)
        LinkLbl.Name = "LinkLbl"
        LinkLbl.Size = New Size(149, 15)
        LinkLbl.TabIndex = 4
        LinkLbl.TabStop = True
        LinkLbl.Text = "Dirección del código QR"
        ' 
        ' BtnAgregarLogo
        ' 
        BtnAgregarLogo.Font = New Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAgregarLogo.Location = New Point(41, 223)
        BtnAgregarLogo.Name = "BtnAgregarLogo"
        BtnAgregarLogo.Size = New Size(190, 23)
        BtnAgregarLogo.TabIndex = 2
        BtnAgregarLogo.Text = "Agregar Logo"
        BtnAgregarLogo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(78, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 15)
        Label3.TabIndex = 3
        Label3.Text = "Vista previa:"
        ' 
        ' PicBoxPrevia
        ' 
        PicBoxPrevia.Image = My.Resources.Resources.png_transparent_waiting_illustration
        PicBoxPrevia.Location = New Point(41, 30)
        PicBoxPrevia.Name = "PicBoxPrevia"
        PicBoxPrevia.Size = New Size(190, 152)
        PicBoxPrevia.SizeMode = PictureBoxSizeMode.Zoom
        PicBoxPrevia.TabIndex = 0
        PicBoxPrevia.TabStop = False
        ' 
        ' BtnGenerar
        ' 
        BtnGenerar.Location = New Point(57, 198)
        BtnGenerar.Name = "BtnGenerar"
        BtnGenerar.Size = New Size(138, 23)
        BtnGenerar.TabIndex = 6
        BtnGenerar.Text = "Generar QR!"
        BtnGenerar.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Font = New Font("Cambria", 9.75F, FontStyle.Bold)
        RadioButton8.Location = New Point(7, 142)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(85, 19)
        RadioButton8.TabIndex = 5
        RadioButton8.TabStop = True
        RadioButton8.Text = "Copiar QR"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Font = New Font("Cambria", 9.75F, FontStyle.Bold)
        RadioButton7.Location = New Point(7, 117)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(103, 19)
        RadioButton7.TabIndex = 4
        RadioButton7.TabStop = True
        RadioButton7.Text = "Imprimir QR"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Font = New Font("Cambria", 9.75F, FontStyle.Bold)
        RadioButton6.Location = New Point(7, 92)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(99, 19)
        RadioButton6.TabIndex = 3
        RadioButton6.TabStop = True
        RadioButton6.Text = "SVG (Vector)"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Cambria", 9.75F, FontStyle.Bold)
        RadioButton5.Location = New Point(7, 67)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(104, 19)
        RadioButton5.TabIndex = 2
        RadioButton5.TabStop = True
        RadioButton5.Text = "JPG (Imagen)"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(186))
        RadioButton4.Location = New Point(7, 42)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(109, 19)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "PNG (Imagen)"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 15)
        Label6.TabIndex = 0
        Label6.Text = "Guardar como:"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 321)
        Controls.Add(SplitContainer1)
        Controls.Add(Panel1)
        Font = New Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "QR Code Generator "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        SplitContainer2.Panel2.PerformLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(PicBoxPrevia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents PicBoxPrevia As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAgregarLogo As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioBtnImage As RadioButton
    Friend WithEvents RadioBtnColor As RadioButton
    Friend WithEvents RadioBtnSimple As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents LinkLbl As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Public WithEvents TxtBoxDetalles As TextBox
    Friend WithEvents PnlMuestraColor As Panel
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents BtnExaminar As Button

End Class
