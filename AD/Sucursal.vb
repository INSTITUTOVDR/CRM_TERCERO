Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Sucursal
    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function BuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("SucursalesBuscarTodos")
    End Function
    Public Function BuscarPorId(ByVal IdSucursal As String) As DataSet
        Return o_Database.ExecuteDataSet("SucursalesBuscarPorId", IdSucursal)
    End Function
    Public Function Agregar(ByVal IdEmpresa As Integer, ByVal Nombre As String, ByVal Fantasia As String, ByVal IdLocalidad As Integer, ByVal Domicilio As String, ByVal Lat As String, ByVal Lng As String, ByVal Observaciones As String, ByVal Prioridad As Integer, ByVal Estado As Integer) As DataSet
        o_Database.ExecuteDataSet("SucursalesAgregar", IdEmpresa, Nombre, Fantasia, IdLocalidad, Domicilio, Lat, Lng, Observaciones, Prioridad, Estado)
        Return Nothing
    End Function
    Public Function Modificar(IdSucursal As Integer, ByVal IdEmpresa As Integer, ByVal Nombre As String, ByVal Fantasia As String, ByVal IdLocalidad As Integer, ByVal Domicilio As String, ByVal Lat As String, ByVal Lng As String, ByVal Observaciones As String, ByVal Prioridad As Integer, ByVal Estado As Integer) As DataSet
        o_Database.ExecuteDataSet("SucursalesModificar", IdSucursal, IdEmpresa, Nombre, Fantasia, IdLocalidad, Domicilio, Lat, Lng, Observaciones, Prioridad, Estado)
        Return Nothing
    End Function
    Public Function Eliminar(ByVal IdSucursal As Integer) As DataSet
        o_Database.ExecuteDataSet("SucursalesEliminar", IdSucursal)
        Return Nothing
    End Function
    Public Function CboEmpresa() As DataSet
        Return o_Database.ExecuteDataSet("SucursalesCboEmpresas")
    End Function
    Public Function BuscarPorIdEmpresa(ByVal IdEmpresa As Integer) As DataSet
        Return o_Database.ExecuteDataSet("SucursalesBuscarPorIdEmpresa", IdEmpresa)
    End Function
End Class
