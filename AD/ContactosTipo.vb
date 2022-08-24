Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ContactosTipo
    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function BuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("ContactosTipoBuscarTodo")
    End Function
End Class
