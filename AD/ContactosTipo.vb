
Public Class ContactosTipo
    Public Function BuscarTodos() As DataSet
        Return o_Database.ExecuteDataSet("ContactosTipoBuscarTodo")
    End Function
End Class
