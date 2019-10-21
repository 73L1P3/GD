Public Class FrmBusquedaProductos
    Private Sub FrmBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = CapaDatos.MetodosProductos.ListarProductos
    End Sub
End Class
