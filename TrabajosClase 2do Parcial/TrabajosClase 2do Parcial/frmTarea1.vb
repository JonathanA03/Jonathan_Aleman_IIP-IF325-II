Public Class frmTarea1
    Private mClientes(,) As String
    Private contador As Integer
    Private encuentra As Boolean = False
    Private Sub activarControles()
        txtCiudad.Enabled = True
        txtMontoT.Enabled = True
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub

    Private Sub activarControles2()
        mtID.Enabled = True
    End Sub

    Private Sub desactiveControles()
        txtCliente.Enabled = False
        txtMontoT.Enabled = False
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
        mtID.Enabled = False
    End Sub

    Private Sub limpiar()
        desactiveControles()
        txtNombre.Clear()
        txtID.Clear()
        txtEdad.Clear()
        txtPais.Clear()
        txtCiudad.Clear()
        txtMonto.Clear()
        txtCliente.Clear()
        txtMontoT.Clear()
        mtID.Clear()
    End Sub

    Private Sub frmTarea1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactiveControles()
        ReDim mClientes(1000, 5)
        contador = 0
        datainf.Columns.Add("Nombre", "Nombre")
        datainf.Columns.Add("ID", "ID")
        datainf.Columns.Add("Edad", "Edad")
        datainf.Columns.Add("Pais", "Pais")
        datainf.Columns.Add("Ciudad", "Ciudad")
        datainf.Columns.Add("Total", "Total")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mClientes(contador, 0) = txtNombre.Text
        mClientes(contador, 1) = txtID.Text
        mClientes(contador, 2) = txtEdad.Text
        mClientes(contador, 3) = txtPais.Text
        mClientes(contador, 4) = txtCiudad.Text
        mClientes(contador, 5) = txtMonto.Text

        contador = contador + 1

        activarControles()
        activarControles2()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim idC As Integer
        idC = txtID.Text
        For i = 0 To (contador - 1) Step 1
            If (mClientes(i, 1) = idC) Then
                If (txtMontoT.Text < mClientes(i, 1)) Then

                Else
                    MessageBox.Show("Saldo insuficiente", "Deposite más", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim idC As String
        idC = mtID.Text
        For i = 0 To (contador - 1) Step 1
            If (mClientes(i, 1) = idC) Then
                MessageBox.Show("Si se encuentra el id")
                datainf.Rows.Add(mClientes(i, 0), mClientes(i, 1), mClientes(i, 2), mClientes(i, 3), mClientes(i, 4), mClientes(i, 5))
                encuentra = True
            End If
            If (encuentra = False) Then
                MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                encuentra = False
            End If
        Next
    End Sub

    Private Sub brnSalir_Click(sender As Object, e As EventArgs) Handles brnSalir.Click
        End
    End Sub

    Private Sub btnLimpiarR_Click(sender As Object, e As EventArgs) Handles btnLimpiarR.Click
        txtNombre.Clear()
        txtID.Clear()
        txtEdad.Clear()
        txtPais.Clear()
        txtCiudad.Clear()
        txtMonto.Clear()
    End Sub
End Class
