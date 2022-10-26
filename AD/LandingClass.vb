Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class LandingClass
    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub

    Public Function LandingBuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("LandingsBuscarTodos")
    End Function

    Public Function LandingAgregar(Nombre As String, Apellido As String, CorreoElectronico As String, Telefono As String, IdCanal As Integer, FechaIngreso As Date, AlgoMas As String) As DataSet
        o_Database.ExecuteScalar("LandingsAgregar", Nombre, Apellido, CorreoElectronico, Telefono, IdCanal, FechaIngreso, AlgoMas)
        Return Nothing
    End Function
End Class
