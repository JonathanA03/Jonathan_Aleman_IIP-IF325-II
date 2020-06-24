<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarea1
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
        Me.btnLimpiarR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.txtMontoT = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLimpiarV = New System.Windows.Forms.Button()
        Me.brnSalir = New System.Windows.Forms.Button()
        Me.datainf = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.datainf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiarR)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtPais)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apertura de cuenta"
        '
        'btnLimpiarR
        '
        Me.btnLimpiarR.Location = New System.Drawing.Point(180, 215)
        Me.btnLimpiarR.Name = "btnLimpiarR"
        Me.btnLimpiarR.Size = New System.Drawing.Size(75, 43)
        Me.btnLimpiarR.TabIndex = 12
        Me.btnLimpiarR.Text = "Limpiar registro"
        Me.btnLimpiarR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aperturar cuenta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(70, 168)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(156, 22)
        Me.txtMonto.TabIndex = 11
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(70, 140)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(156, 22)
        Me.txtCiudad.TabIndex = 10
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(70, 112)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(156, 22)
        Me.txtPais.TabIndex = 9
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(70, 84)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(156, 22)
        Me.txtEdad.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(70, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(156, 22)
        Me.txtID.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(70, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(156, 22)
        Me.txtNombre.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Monto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ciudad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "País"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDepositar)
        Me.GroupBox2.Controls.Add(Me.btnRetirar)
        Me.GroupBox2.Controls.Add(Me.txtMontoT)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacción"
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(135, 98)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(82, 23)
        Me.btnDepositar.TabIndex = 5
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(6, 98)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirar.TabIndex = 4
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'txtMontoT
        '
        Me.txtMontoT.Location = New System.Drawing.Point(80, 64)
        Me.txtMontoT.Name = "txtMontoT"
        Me.txtMontoT.Size = New System.Drawing.Size(184, 22)
        Me.txtMontoT.TabIndex = 3
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(80, 21)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(184, 22)
        Me.txtCliente.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Monto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.datainf)
        Me.GroupBox3.Controls.Add(Me.mtID)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 291)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(713, 346)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del cliente"
        '
        'mtID
        '
        Me.mtID.Location = New System.Drawing.Point(80, 28)
        Me.mtID.Name = "mtID"
        Me.mtID.Size = New System.Drawing.Size(137, 22)
        Me.mtID.TabIndex = 12
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(228, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ID Cliente"
        '
        'btnLimpiarV
        '
        Me.btnLimpiarV.Location = New System.Drawing.Point(650, 180)
        Me.btnLimpiarV.Name = "btnLimpiarV"
        Me.btnLimpiarV.Size = New System.Drawing.Size(75, 52)
        Me.btnLimpiarV.TabIndex = 3
        Me.btnLimpiarV.Text = "Limpiar ventana"
        Me.btnLimpiarV.UseVisualStyleBackColor = True
        '
        'brnSalir
        '
        Me.brnSalir.Location = New System.Drawing.Point(650, 245)
        Me.brnSalir.Name = "brnSalir"
        Me.brnSalir.Size = New System.Drawing.Size(75, 31)
        Me.brnSalir.TabIndex = 4
        Me.brnSalir.Text = "Salir"
        Me.brnSalir.UseVisualStyleBackColor = True
        '
        'datainf
        '
        Me.datainf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datainf.Location = New System.Drawing.Point(9, 60)
        Me.datainf.Name = "datainf"
        Me.datainf.RowHeadersWidth = 51
        Me.datainf.RowTemplate.Height = 24
        Me.datainf.Size = New System.Drawing.Size(698, 280)
        Me.datainf.TabIndex = 5
        '
        'frmTarea1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 644)
        Me.Controls.Add(Me.brnSalir)
        Me.Controls.Add(Me.btnLimpiarV)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTarea1"
        Me.Text = "frmTarea1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.datainf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents txtMontoT As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnLimpiarV As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents brnSalir As Button
    Friend WithEvents mtID As TextBox
    Friend WithEvents btnLimpiarR As Button
    Friend WithEvents datainf As DataGridView
End Class
