Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Informacion
    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function BuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("InformacionesBuscarTodos")
    End Function
    Public Function BuscarPorId(ByVal IdInformacion As Integer) As DataSet
        Return o_Database.ExecuteDataSet("InformacionesBuscarPorId", IdInformacion)
    End Function
    Public Function Agregar(ByVal IdEmpresa As Integer, ByVal Observaciones As String, ByVal Prioridad As Integer, ByVal Estado As Integer) As DataSet
        o_Database.ExecuteDataSet("InformacionesAgregar", IdEmpresa, Observaciones, Prioridad, Estado)
        Return Nothing
    End Function
    Public Function Modificar(ByVal IdInformacion As Integer, ByVal IdEmpresa As Integer, ByVal Observaciones As String, ByVal Prioridad As Integer, ByVal Estado As Integer) As DataSet
        o_Database.ExecuteDataSet("InformacionesModificar", IdInformacion, IdEmpresa, Observaciones, Prioridad, Estado)
        Return Nothing
    End Function
    Public Function Eliminar(ByVal IdInformacion As Integer) As DataSet
        o_Database.ExecuteDataSet("InformacionesEliminar", IdInformacion)
        Return Nothing
    End Function
    Public Sub CambiarEstado(IdInformacion As Integer)
        o_Database.ExecuteScalar("InformacionesModificarEstado", IdInformacion)
    End Sub
    Public Function CboEmpresa() As DataSet
        Return o_Database.ExecuteDataSet("InformacionesCboEmpresas")
    End Function
End Class
