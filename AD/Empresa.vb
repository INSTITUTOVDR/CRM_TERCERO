Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class Empresa

    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("Conn")
    End Sub
    Public Function BuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("EmpresasBuscarTodo")
    End Function
    Public Sub Agregar(RazonSocial As String, Fantasia As String, NroCuit As String, IdLocalidad As Integer, Domicilio As String, Lat As String, Lng As String, Imagen As String, EmpresaTipo As Integer, Observaciones As String, Prioridad As Integer, FechaInicioActividad As Date, Estado As Integer)
        o_Database.ExecuteScalar("EmpresasAgregar", RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, Imagen, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)
    End Sub
    Public Sub Modificar(IdEmpresa As Integer, RazonSocial As String, Fantasia As String, NroCuit As String, IdLocalidad As Integer, Domicilio As String, Lat As String, Lng As String, Imagen As String, EmpresaTipo As Integer, Observaciones As String, Prioridad As Integer, FechaInicioActividad As Date, Estado As Integer)
        o_Database.ExecuteScalar("EmpresasModificar", IdEmpresa, RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, Imagen, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)
    End Sub
    Public Function BuscarPorId(IdEmpresa As Integer) As DataSet
        Return o_Database.ExecuteDataSet("EmpresasBuscarPorId", IdEmpresa)
    End Function
End Class
