Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class EmpresaTipo

    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub
    Public Function BuscarTodos() As EmpresaTipoWS()
        Dim IdTabla As Integer = 0
        Dim oDs As DataSet = o_Database.ExecuteDataSet("EmpresaTiposBuscarTodo")

        Dim e As EmpresaTipoWS() = New EmpresaTipoWS(oDs.Tables(IdTabla).Rows.Count - 1) {}
        For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
            e(i) = New EmpresaTipoWS With {
                    .IdEmpresaTipo = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresaTipo").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString(),
                    .Activo = oDs.Tables(IdTabla).Rows(i).Item("Activo").ToString()
                }
        Next

        Return e
    End Function
End Class
