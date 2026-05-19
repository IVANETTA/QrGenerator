<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Label1 = New Label()
        Label2 = New Label()
        TxtRed = New TextBox()
        TxtContr = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        CmbTextWifi = New ComboBox()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "Red:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña:"
        ' 
        ' TxtRed
        ' 
        TxtRed.Location = New Point(95, 25)
        TxtRed.Name = "TxtRed"
        TxtRed.Size = New Size(100, 23)
        TxtRed.TabIndex = 3
        ' 
        ' TxtContr
        ' 
        TxtContr.Location = New Point(95, 54)
        TxtContr.Name = "TxtContr"
        TxtContr.Size = New Size(100, 23)
        TxtContr.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(95, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 6
        Label3.Text = "Seguridad:"
        ' 
        ' CmbTextWifi
        ' 
        CmbTextWifi.DropDownStyle = ComboBoxStyle.DropDownList
        CmbTextWifi.FormattingEnabled = True
        CmbTextWifi.Items.AddRange(New Object() {"Seleccione tipo de seguridad:", "WPA", "WEP", "Ninguna", "otro..."})
        CmbTextWifi.Location = New Point(88, 86)
        CmbTextWifi.Name = "CmbTextWifi"
        CmbTextWifi.Size = New Size(121, 23)
        CmbTextWifi.TabIndex = 7
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 161)
        Controls.Add(CmbTextWifi)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(TxtContr)
        Controls.Add(TxtRed)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        Text = "Guardar Red Wi-Fi"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContr As TextBox
    Friend WithEvents TxtRed As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbTextWifi As ComboBox
End Class
