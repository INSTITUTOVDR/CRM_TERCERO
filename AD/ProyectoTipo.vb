Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class ProyectoTipo

    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function ProyectoTipoBuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("ProyectosTipoBuscarTodos")
    End Function
    Public Function ProyectoTipoBuscarPorId(ByVal IdProyectoTipo As Integer) As DataSet
        Return o_Database.ExecuteDataSet("ProyectosTipoBuscarPorId", IdProyectoTipo)
    End Function
    Public Function ProyectoTipoAgregar(ByVal Nombre As String, ByVal Descripcion As String, ByVal Imagen As String, ByVal IdEstado As Integer) As DataSet
        o_Database.ExecuteDataSet("ProyectosTipoAgregar", Nombre, Descripcion, Imagen, IdEstado)
        Return Nothing
    End Function
    Public Function ProyectoTipoModificar(ByVal IdProyectoTipo As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal Imagen As String, ByVal IdEstado As Integer) As DataSet
        o_Database.ExecuteDataSet("ProyectosTipoModificar", IdProyectoTipo, Nombre, Descripcion, Imagen, IdEstado)
        Return Nothing
    End Function
    Public Function ProyectoTipoEliminar(ByVal IdProyectoTipo As Integer) As DataSet
        o_Database.ExecuteDataSet("ProyectosTipoEliminar", IdProyectoTipo)
        Return Nothing
    End Function





End Class
