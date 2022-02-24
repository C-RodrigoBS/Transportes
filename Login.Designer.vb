<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.ImgLogin = New System.Windows.Forms.PictureBox()
        Me.linkRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bienvenido = New System.Windows.Forms.Label()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        CType(Me.ImgLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PanelLogin)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(883, 478)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelLogin.Controls.Add(Me.ImgLogin)
        Me.PanelLogin.Controls.Add(Me.linkRegistrarse)
        Me.PanelLogin.Controls.Add(Me.btnAtras)
        Me.PanelLogin.Controls.Add(Me.btnIniciarSesion)
        Me.PanelLogin.Controls.Add(Me.TextBox2)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.TextBox1)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.Bienvenido)
        Me.PanelLogin.Location = New System.Drawing.Point(196, 31)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(462, 414)
        Me.PanelLogin.TabIndex = 0
        '
        'ImgLogin
        '
        Me.ImgLogin.Image = CType(resources.GetObject("ImgLogin.Image"), System.Drawing.Image)
        Me.ImgLogin.Location = New System.Drawing.Point(200, 74)
        Me.ImgLogin.Name = "ImgLogin"
        Me.ImgLogin.Size = New System.Drawing.Size(78, 73)
        Me.ImgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLogin.TabIndex = 8
        Me.ImgLogin.TabStop = False
        '
        'linkRegistrarse
        '
        Me.linkRegistrarse.AutoSize = True
        Me.linkRegistrarse.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.linkRegistrarse.Location = New System.Drawing.Point(182, 353)
        Me.linkRegistrarse.Name = "linkRegistrarse"
        Me.linkRegistrarse.Size = New System.Drawing.Size(96, 23)
        Me.linkRegistrarse.TabIndex = 7
        Me.linkRegistrarse.TabStop = True
        Me.linkRegistrarse.Text = "Registrarse"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.btnAtras.Location = New System.Drawing.Point(94, 296)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(99, 37)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "Cerrar"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.btnIniciarSesion.Location = New System.Drawing.Point(268, 296)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(133, 37)
        Me.btnIniciarSesion.TabIndex = 5
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(185, 165)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(164, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(76, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 239)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Bienvenido
        '
        Me.Bienvenido.AutoSize = True
        Me.Bienvenido.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bienvenido.Location = New System.Drawing.Point(151, 28)
        Me.Bienvenido.Name = "Bienvenido"
        Me.Bienvenido.Size = New System.Drawing.Size(186, 32)
        Me.Bienvenido.TabIndex = 0
        Me.Bienvenido.Text = "BIENVENIDO"
        Me.Bienvenido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 478)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.ImgLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Bienvenido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ImgLogin As PictureBox
    Friend WithEvents linkRegistrarse As LinkLabel
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents TextBox2 As TextBox
End Class
