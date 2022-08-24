Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class Empresa

    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function BuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("EmpresasBuscarTodo")
    End Function
    Public Sub Agregar(dict)
        Dim RazonSocial = dict(0).RazonSocial.ToString
        Dim Fantasia = dict(0).Fantasia.ToString
        Dim NroCuit = dict(0).NroCuit.ToString
        Dim IdLocalidad = dict(0).IdLocalidad.ToString
        Dim Domicilio = dict(0).Domicilio.ToString
        Dim Lat = dict(0).Lat.ToString
        Dim Lng = dict(0).Lng.ToString
        Dim Imagen = dict(0).Imagen.ToString
        Dim EmpresaTipo = dict(0).EmpresaTipo.ToString
        Dim Observaciones = dict(0).Observaciones.ToString
        Dim Prioridad = dict(0).Prioridad.ToString
        Dim FechaInicioActividad = dict(0).FechaInicioActividad.ToString
        Dim Estado = dict(0).Estado.ToString
        Dim rutaAbsoluta As String = New Img().Guardar("ImagenesEmpresas", Imagen)

        o_Database.ExecuteScalar("EmpresasAgregar", RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, rutaAbsoluta, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)
    End Sub
    Public Sub Modificar(IdEmpresa As Integer, RazonSocial As String, Fantasia As String, NroCuit As String, IdLocalidad As Integer, Domicilio As String, Lat As String, Lng As String, Imagen As String, EmpresaTipo As Integer, Observaciones As String, Prioridad As Integer, FechaInicioActividad As Date, Estado As Integer)
        o_Database.ExecuteScalar("EmpresasModificar", IdEmpresa, RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, Imagen, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)
    End Sub
    Public Function BuscarPorId(IdEmpresa As Integer) As DataSet
        Return o_Database.ExecuteDataSet("EmpresasBuscarPorId", IdEmpresa)
    End Function
    Public Sub CambiarEstado(IdEmresa As Integer)
        o_Database.ExecuteScalar("EmpresasModificarEstado", IdEmresa)
    End Sub

End Class
