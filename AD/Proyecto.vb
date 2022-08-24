Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class Proyecto

    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function ProyectoBuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("ProyectosBuscarTodos")
    End Function
    Public Function ProyectoBuscarPorId(ByVal IdProyecto As Integer) As DataSet
        Return o_Database.ExecuteDataSet("ProyectosBuscarPorId", IdProyecto)
    End Function

    Public Function ProyectoAgregar(Nombre As String, Descripcion As String, IdEmpresa As Integer, IdSucursal As Integer, IdProyectoTipo As Integer, Imagen As String, IdEstado As Integer) As Double
        Try
            Return o_Database.ExecuteScalar("ProyectosAgregar", Nombre, Descripcion, IdEmpresa, IdSucursal, IdProyectoTipo, Imagen, IdEstado)
        Catch ex As Exception
        End Try
    End Function

    'Public Function ProyectoAgregar(ByVal Nombre As String, ByVal Descripcion As String, ByVal IdEmpresa As Integer, ByVal IdSucursal As Integer, ByVal IdProyectoTipo As Integer, ByVal Imagen As String, ByVal IdEstado As Integer) As Double
    '    o_Database.ExecuteScalar("ProyectosAgregar", Nombre, Descripcion, IdEmpresa, IdSucursal, IdProyectoTipo, Imagen, IdEstado)
    '    Return Nothing
    'End Function
    Public Function ProyectoModificar(ByVal IdProyecto As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal IdEmpresa As Integer, ByVal IdSucursal As Integer, ByVal IdProyectoTipo As Integer, ByVal Imagen As String, ByVal IdEstado As Integer) As DataSet
        o_Database.ExecuteDataSet("ProyectosModificar", IdProyecto, Nombre, Descripcion, IdEmpresa, IdSucursal, IdProyectoTipo, Imagen, IdEstado)
        Return Nothing
    End Function
    Public Function ProyectoEliminar(ByVal IdProyecto As Integer) As DataSet
        o_Database.ExecuteDataSet("ProyectosEliminar", IdProyecto)
        Return Nothing
    End Function

    Public Function ProyectoEstadoAgregar(ByVal IdProyecto As Integer, ByVal IdEstado As Integer) As DataSet
        o_Database.ExecuteDataSet("ProyectosEstadosAgregar", IdProyecto, IdEstado)
        Return Nothing
    End Function
End Class
