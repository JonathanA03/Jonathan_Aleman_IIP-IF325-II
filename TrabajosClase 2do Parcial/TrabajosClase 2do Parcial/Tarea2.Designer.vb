<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tarea2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarD = New System.Windows.Forms.Button()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkRegular = New System.Windows.Forms.CheckBox()
        Me.chkBasica = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbIntegrantes = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGReporte = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Integrantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dirección = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiarD)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.txtDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkRegular)
        Me.GroupBox1.Controls.Add(Me.chkBasica)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbIntegrantes)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 494)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del beneficiario"
        '
        'btnLimpiarD
        '
        Me.btnLimpiarD.Location = New System.Drawing.Point(239, 434)
        Me.btnLimpiarD.Name = "btnLimpiarD"
        Me.btnLimpiarD.Size = New System.Drawing.Size(80, 42)
        Me.btnLimpiarD.TabIndex = 1
        Me.btnLimpiarD.Text = "Limpiar datos"
        Me.btnLimpiarD.UseVisualStyleBackColor = True
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(6, 454)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(169, 22)
        Me.txtMunicipio.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Municipio:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(239, 377)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(80, 42)
        Me.btnVerificar.TabIndex = 1
        Me.btnVerificar.Text = "Entregar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(6, 397)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(169, 22)
        Me.txtDepartamento.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Departamento:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(34, 28)
        Me.txtID.MaxLength = 13
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(257, 22)
        Me.txtID.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(6, 268)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(285, 90)
        Me.txtDireccion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Dirección"
        '
        'chkRegular
        '
        Me.chkRegular.AutoSize = True
        Me.chkRegular.Location = New System.Drawing.Point(169, 215)
        Me.chkRegular.Name = "chkRegular"
        Me.chkRegular.Size = New System.Drawing.Size(80, 21)
        Me.chkRegular.TabIndex = 4
        Me.chkRegular.Text = "Regular"
        Me.chkRegular.UseVisualStyleBackColor = True
        '
        'chkBasica
        '
        Me.chkBasica.AutoSize = True
        Me.chkBasica.Location = New System.Drawing.Point(169, 188)
        Me.chkBasica.Name = "chkBasica"
        Me.chkBasica.Size = New System.Drawing.Size(72, 21)
        Me.chkBasica.TabIndex = 1
        Me.chkBasica.Text = "Básica"
        Me.chkBasica.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(6, 82)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(285, 22)
        Me.txtNombre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Integrantes"
        '
        'cmbIntegrantes
        '
        Me.cmbIntegrantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIntegrantes.FormattingEnabled = True
        Me.cmbIntegrantes.Items.AddRange(New Object() {"1 - 3 personas", "Más de 3 personas"})
        Me.cmbIntegrantes.Location = New System.Drawing.Point(6, 208)
        Me.cmbIntegrantes.Name = "cmbIntegrantes"
        Me.cmbIntegrantes.Size = New System.Drawing.Size(121, 24)
        Me.cmbIntegrantes.TabIndex = 1
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pobreza ", "Extrema pobreza"})
        Me.cmbEstado.Location = New System.Drawing.Point(6, 138)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 24)
        Me.cmbEstado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre completo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGReporte)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(873, 572)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'DGReporte
        '
        Me.DGReporte.AllowUserToAddRows = False
        Me.DGReporte.AllowUserToDeleteRows = False
        Me.DGReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Integrantes, Me.Estado, Me.Tipo, Me.Dirección})
        Me.DGReporte.Location = New System.Drawing.Point(6, 21)
        Me.DGReporte.Name = "DGReporte"
        Me.DGReporte.ReadOnly = True
        Me.DGReporte.RowHeadersWidth = 51
        Me.DGReporte.RowTemplate.Height = 24
        Me.DGReporte.Size = New System.Drawing.Size(861, 463)
        Me.DGReporte.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre Completo"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 125
        '
        'Integrantes
        '
        Me.Integrantes.HeaderText = "Integrantes"
        Me.Integrantes.MinimumWidth = 6
        Me.Integrantes.Name = "Integrantes"
        Me.Integrantes.ReadOnly = True
        Me.Integrantes.Width = 125
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 125
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo de bolsa"
        Me.Tipo.MinimumWidth = 6
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 125
        '
        'Dirección
        '
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.MinimumWidth = 6
        Me.Dirección.Name = "Dirección"
        Me.Dirección.ReadOnly = True
        Me.Dirección.Width = 220
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(10, 512)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 37)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(10, 555)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Tarea2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 592)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tarea2"
        Me.Text = "Tarea2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbIntegrantes As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkRegular As CheckBox
    Friend WithEvents chkBasica As CheckBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents DGReporte As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Integrantes As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Dirección As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiarD As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
