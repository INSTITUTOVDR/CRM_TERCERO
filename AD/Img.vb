Imports System.IO
Imports System.Web

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

        'Dim rutaServidor As String = "G:\FerozoWebHosting\institutosuperiorvilladelrosario.edu.ar\CRM\" & nombreCarpeta & "\"
        Dim imagenfinal() As String
        Dim imagee As System.Drawing.Image
        If Imagen <> Nothing Then
            imagenfinal = Imagen.Split(",")
            imagenfinal(0).ToString()
            'Setup image and get data stream together
            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
            Dim b64 As String = imagenfinal(0).ToString().Replace(" ", "+")
            Dim b() As Byte
            'Converts the base64 encoded msg to image data
            b = Convert.FromBase64String(b64)
            MS = New System.IO.MemoryStream(b)
            'creates image
            imagee = System.Drawing.Image.FromStream(MS)
            'img.Save(HttpContext.Current.Server.MapPath("img/img_1.png"))
        End If
        If Imagen <> Nothing Then

            Dim path__1 As [String] = HttpContext.Current.Server.MapPath("./" & nombreCarpeta & "/")
            'Path
            'Check if directory exist
            If Not System.IO.Directory.Exists(path__1) Then
                'Create directory if it doesn't exist
                System.IO.Directory.CreateDirectory(path__1)
            End If
            Dim imageName As String = nombre & Convert.ToString(".png")
            'set the image path
            Dim imgPath As String = Path.Combine(path__1, imageName)
            imagee.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg)

            'Dim urlBD As String = rutaServidor & nombre & "." & "png"

            'Dim fileContents As Byte() = Convert.FromBase64String(Imagen.ToString()),
            '            ruta As String = urlBD

            'Dim fs As IO.FileStream
            'fs = IO.File.Create(ruta)
            'fs.Write(fileContents, 0, fileContents.Length)
            'fs.Close()
        End If
        Dim rutaAbsoluta As String = "./" & nombreCarpeta & "/" & nombre & "." & "png"
        Return rutaAbsoluta
    End Function


End Class
