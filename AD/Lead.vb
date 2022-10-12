Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class Lead
    Public Property Mes As String
    Public Property Cantidad As Integer
    Public Property Canal As String


    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function BuscarPorMes() As DataSet
        Return o_Database.ExecuteDataSet("LeadsGetXMes")
    End Function
    Public Function BuscarPorCanal() As DataSet
        Return o_Database.ExecuteDataSet("LeadsGetXCanal")
    End Function
    Public Function BuscarPorCanalPorMes() As DataSet
        Return o_Database.ExecuteDataSet("LeadsGetXCanalXMes")
    End Function
End Class
