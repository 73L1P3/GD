Imports System.Data.SqlClient

Public Class MetodosProductos
    Public Shared Function ListarProductos() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("Sp_ListarProductos", CN)
                Using Tabla As New DataTable
                    DA.Fill(Tabla)
                    Return Tabla
                End Using
            End Using
        End Using
    End Function
End Class
