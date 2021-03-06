﻿
Imports System.Runtime.InteropServices



Public Class UI

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnMaximisar_Click(sender As Object, e As EventArgs) Handles btnMaximisar.Click
        btnMaximisar.Visible = False
        btnRestaurar.Visible = True
        'Me.WindowState = FormWindowState.Maximized
        'Cambia el tamaño del formulario sin ocultar la barra
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        'El formulario se ubique en toda la pantalla
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnMinimisar_Click(sender As Object, e As EventArgs) Handles btnMinimisar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximisar.Visible = True
        ' Me.WindowState = FormWindowState.Normal

        Me.Size = New System.Drawing.Size(1100, 560)
        'Centrar el formulario en la pantalla
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub PanelSuperior_MouseHover(sender As Object, e As EventArgs) Handles PanelSuperior.MouseHover
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If PanelLateral.Width <= 45 Then
            Me.TimerOcultar.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width - 20
        End If
    End Sub
    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If PanelLateral.Width >= 165 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width + 20
        End If
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelLateral.Width = 165 Then
            TimerOcultar.Enabled = True
        ElseIf PanelLateral.Width = 45 Then
            TimerMostrar.Enabled = True
        End If
    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelForm.Controls.Count > 0 Then
            Me.PanelForm.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelForm.Controls.Add(frm)
        Me.PanelForm.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        abrirFormulario(frmProductos)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        abrirFormulario(frmEmpleados)
    End Sub


End Class
