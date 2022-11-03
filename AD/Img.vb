Public Class Img

    Public Function Guardar(nombreCarpeta As String, Imagen As String) As String
        Dim obj As New Random()
        Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim longitud As Integer = posibles.Length
        Dim letra As Char
        Dim longitudnuevacadena As Integer = 3
        Dim nuevacadena As String = ""
        For i As Integer = 0 To longitudnuevacadena - 1
            letra = posibles(obj.[Next](longitud))
            nuevacadena += letra.ToString()
        Next

        Dim fecha As String
        fecha = Date.Now.Year.ToString + Date.Now.Month.ToString + Date.Now.Day.ToString + Date.Now.TimeOfDay.TotalMinutes.ToString

        Dim nombre As String
        nombre = fecha & nuevacadena

        'Dim rutaServidor As String = "C:\Users\Guille\Desktop\TSDS\PP2\Proyecto\CRM_TERCERO\CRM_TERCERO\" & nombreCarpeta & "\" 'ImagenesEmpresas \

        Dim rutaServidor As String = "G:\FerozoWebHosting\institutosuperiorvilladelrosario.edu.ar\public_html\CRM\" & nombreCarpeta & "\"

        Dim urlBD As String = rutaServidor & nombre & "." & "png"

        Dim fileContents As Byte() = Convert.FromBase64String(Imagen.ToString()),
                    ruta As String = urlBD

        Dim fs As IO.FileStream
        fs = IO.File.Create(ruta)
        fs.Write(fileContents, 0, fileContents.Length)
        fs.Close()

        Dim rutaAbsoluta As String = "./" & nombreCarpeta & "/" & nombre & "." & "png"
        Return rutaAbsoluta
    End Function


End Class
