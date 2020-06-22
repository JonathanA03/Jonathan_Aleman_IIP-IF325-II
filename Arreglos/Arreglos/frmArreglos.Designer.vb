<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArreglos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnPrecios = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCompus = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtCantidadIngresar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRcantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.txtVender = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbPrecios)
        Me.GroupBox1.Controls.Add(Me.btnPrecios)
        Me.GroupBox1.Controls.Add(Me.cmbComputadoras)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensionales"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(127, 222)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 27)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(201, 164)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(121, 24)
        Me.cmbPrecios.TabIndex = 4
        '
        'btnPrecios
        '
        Me.btnPrecios.Location = New System.Drawing.Point(210, 53)
        Me.btnPrecios.Name = "btnPrecios"
        Me.btnPrecios.Size = New System.Drawing.Size(95, 49)
        Me.btnPrecios.TabIndex = 3
        Me.btnPrecios.Text = "Generar Precios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnPrecios.UseVisualStyleBackColor = True
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(6, 164)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(121, 24)
        Me.cmbComputadoras.TabIndex = 0
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(18, 53)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(95, 49)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar computador"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCompus)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 335)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 204)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinamico"
        '
        'cmbCompus
        '
        Me.cmbCompus.FormattingEnabled = True
        Me.cmbCompus.Location = New System.Drawing.Point(9, 164)
        Me.cmbCompus.Name = "cmbCompus"
        Me.cmbCompus.Size = New System.Drawing.Size(162, 24)
        Me.cmbCompus.TabIndex = 3
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(159, 95)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(82, 31)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(159, 53)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Can. Computadoras"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRegistrar)
        Me.GroupBox3.Controls.Add(Me.txtCantidadIngresar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(376, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 120)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(122, 67)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(101, 33)
        Me.btnRegistrar.TabIndex = 6
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtCantidadIngresar
        '
        Me.txtCantidadIngresar.Location = New System.Drawing.Point(145, 27)
        Me.txtCantidadIngresar.Name = "txtCantidadIngresar"
        Me.txtCantidadIngresar.Size = New System.Drawing.Size(159, 22)
        Me.txtCantidadIngresar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Can. Computadoras"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRcantidad)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtModelo)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.txtMarca)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(376, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(367, 204)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro"
        '
        'txtRcantidad
        '
        Me.txtRcantidad.Location = New System.Drawing.Point(83, 128)
        Me.txtRcantidad.Name = "txtRcantidad"
        Me.txtRcantidad.Size = New System.Drawing.Size(159, 22)
        Me.txtRcantidad.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(83, 90)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(159, 22)
        Me.txtPrecio.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(83, 55)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(159, 22)
        Me.txtModelo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Modelo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(260, 154)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(101, 33)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(83, 24)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(159, 22)
        Me.txtMarca.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnVender)
        Me.GroupBox5.Controls.Add(Me.txtVender)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(376, 350)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(367, 111)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Registro"
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(122, 67)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(101, 33)
        Me.btnVender.TabIndex = 6
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'txtVender
        '
        Me.txtVender.Location = New System.Drawing.Point(145, 27)
        Me.txtVender.Name = "txtVender"
        Me.txtVender.Size = New System.Drawing.Size(159, 22)
        Me.txtVender.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Can. Vender"
        '
        'frmArreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmArreglos"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents btnPrecios As Button
    Friend WithEvents cmbCompus As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtCantidadIngresar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRcantidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnVender As Button
    Friend WithEvents txtVender As TextBox
    Friend WithEvents Label7 As Label
End Class
