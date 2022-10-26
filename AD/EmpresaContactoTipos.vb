Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class EmpresaContactoTipos
    Dim o_Database As Database
    Public Sub New()
        o_Database = DatabaseFactory.CreateDatabase("ConnCRM")
    End Sub

    Public Sub Agregar(FormasContacto As List(Of EmpresaContactoTipoWS), IdEmpresa As Integer)
        For Each FC In FormasContacto
            If FC IsNot Nothing Then
                o_Database.ExecuteScalar("EmpresaContactoTipoAgregar", IdEmpresa, FC.IdConactoTipo, FC.Valor, FC.Cargo, FC.Activo)
            End If
        Next
    End Sub
End Class
