<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.PanelRegistro = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtConfirmarContra = New System.Windows.Forms.TextBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.varTipoUsuario = New System.Windows.Forms.DomainUpDown()
        Me.imgRegistro = New System.Windows.Forms.PictureBox()
        Me.PanelRegistro.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.imgRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRegistro
        '
        Me.PanelRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelRegistro.Controls.Add(Me.Panel2)
        Me.PanelRegistro.Controls.Add(Me.Panel1)
        Me.PanelRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRegistro.Location = New System.Drawing.Point(0, 0)
        Me.PanelRegistro.Name = "PanelRegistro"
        Me.PanelRegistro.Size = New System.Drawing.Size(800, 450)
        Me.PanelRegistro.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.varTipoUsuario)
        Me.Panel1.Controls.Add(Me.btnRegistro)
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Controls.Add(Me.txtConfirmarContra)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtCelular)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.txtDni)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 450)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.imgRegistro)
        Me.Panel2.Location = New System.Drawing.Point(409, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 450)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(78, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUEVO USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(33, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(136, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DNI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(38, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo Electrónico:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(37, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Número de celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(87, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(15, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Confirmar contraseña:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label8.Location = New System.Drawing.Point(54, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo de usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(186, 84)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(190, 20)
        Me.txtUsuario.TabIndex = 8
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(186, 119)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(190, 20)
        Me.txtDni.TabIndex = 9
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(186, 158)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(190, 20)
        Me.txtCorreo.TabIndex = 10
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(186, 201)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(190, 20)
        Me.txtCelular.TabIndex = 11
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(186, 238)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(190, 20)
        Me.txtContraseña.TabIndex = 12
        '
        'txtConfirmarContra
        '
        Me.txtConfirmarContra.Location = New System.Drawing.Point(186, 280)
        Me.txtConfirmarContra.Name = "txtConfirmarContra"
        Me.txtConfirmarContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarContra.Size = New System.Drawing.Size(190, 20)
        Me.txtConfirmarContra.TabIndex = 13
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.btnAtras.Location = New System.Drawing.Point(84, 375)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(88, 40)
        Me.btnAtras.TabIndex = 15
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.btnRegistro.Location = New System.Drawing.Point(239, 375)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(109, 40)
        Me.btnRegistro.TabIndex = 16
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'varTipoUsuario
        '
        Me.varTipoUsuario.Location = New System.Drawing.Point(186, 315)
        Me.varTipoUsuario.Name = "varTipoUsuario"
        Me.varTipoUsuario.Size = New System.Drawing.Size(190, 20)
        Me.varTipoUsuario.TabIndex = 17
        Me.varTipoUsuario.Text = "DomainUpDown1"
        '
        'imgRegistro
        '
        Me.imgRegistro.Image = CType(resources.GetObject("imgRegistro.Image"), System.Drawing.Image)
        Me.imgRegistro.Location = New System.Drawing.Point(48, 57)
        Me.imgRegistro.Name = "imgRegistro"
        Me.imgRegistro.Size = New System.Drawing.Size(307, 331)
        Me.imgRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgRegistro.TabIndex = 0
        Me.imgRegistro.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.PanelRegistro.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.imgRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRegistro As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmarContra As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents varTipoUsuario As DomainUpDown
    Friend WithEvents btnRegistro As Button
    Friend WithEvents imgRegistro As PictureBox
End Class
