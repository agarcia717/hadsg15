Imports System.Net.Mail

Public Class Class1
    Public Function EnviarEmail(ByVal email As String, ByVal link As String) As Boolean
        Try
            'Direccion de origen
            Dim from_address As New MailAddress("agarcia717@ikasle.ehu.eus", "HADSG15")
            'Direccion de destino
            Dim to_address As New MailAddress(email)
            'Password de la cuenta
            Dim from_pass As String = "Ondarri2"
            'Objeto para el cliente smtp
            Dim smtp As New SmtpClient
            'Host en este caso el servidor de gmail
            smtp.Host = "smtp.ehu.eus"
            'Puerto
            smtp.Port = 587
            'SSL activado para que se manden correos de manera segura
            smtp.EnableSsl = True
            'No usar los credenciales por defecto ya que si no no funciona
            smtp.UseDefaultCredentials = False
            'Credenciales
            smtp.Credentials = New System.Net.NetworkCredential(from_address.Address, from_pass)
            'Creamos el mensaje con los parametros de origen y destino
            Dim message As New MailMessage(from_address, to_address)
            'Añadimos el asunto
            message.Subject = "Registro HADS"
            'Concatenamos el cuerpo del mensaje a la plantilla
            message.Body = "<html><head></head><body>Para confirmar el registro clica en el siguiente enlace <br><a href='" + link + "'>Verificar</a></body></html>"
            'Definimos el cuerpo como html para poder escoger mejor como lo mandamos
            message.IsBodyHtml = True
            'Se envia el correo
            smtp.Send(message)
        Catch e As Exception
            Return False
        End Try
        Return True



    End Function



    Public Function EnviarEmailclave(ByVal email As String, ByVal clave As String) As Boolean
        Try
            'Direccion de origen
            Dim from_address As New MailAddress("agarcia717@ikasle.ehu.eus", "HADSG15")
            'Direccion de destino
            Dim to_address As New MailAddress(email)
            'Password de la cuenta
            Dim from_pass As String = "Ondarri2"
            'Objeto para el cliente smtp
            Dim smtp As New SmtpClient
            'Host en este caso el servidor de gmail
            smtp.Host = "smtp.ehu.eus"
            'Puerto
            smtp.Port = 587
            'SSL activado para que se manden correos de manera segura
            smtp.EnableSsl = True
            'No usar los credenciales por defecto ya que si no no funciona
            smtp.UseDefaultCredentials = False
            'Credenciales
            smtp.Credentials = New System.Net.NetworkCredential(from_address.Address, from_pass)
            'Creamos el mensaje con los parametros de origen y destino
            Dim message As New MailMessage(from_address, to_address)
            'Añadimos el asunto
            message.Subject = "Clave HADS"
            'Concatenamos el cuerpo del mensaje a la plantilla
            message.Body = "<html><head></head><body>" + "Esta es la clave: " + clave + " con ella podra modificar su contraseña" + "</body></html>"
            'Definimos el cuerpo como html para poder escojer mejor como lo mandamos
            message.IsBodyHtml = True
            'Se envia el correo
            smtp.Send(message)
        Catch e As Exception
            Return False
        End Try
        Return True



    End Function


End Class
