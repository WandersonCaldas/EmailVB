Module Module1

    Sub Main()
        Dim objConfiguracao As New Configuracao

        'Cria objeto com dados do e-mail.
        Dim objEmail As New System.Net.Mail.MailMessage()

        'Define o remetente do e-mail.
        objEmail.From = New System.Net.Mail.MailAddress(objConfiguracao.txt_servidor_smtp_usuario, objConfiguracao.txt_remetente, System.Text.Encoding.UTF8)

        'Define os destinatários do e-mail.
        objEmail.To.Add(objConfiguracao.txt_destinatario)

        'Define a prioridade do e-mail.
        objEmail.Priority = System.Net.Mail.MailPriority.Normal

        'Define o formato do e-mail HTML (caso não queira HTML alocar valor false)
        objEmail.IsBodyHtml = True

        'Define o título do e-mail.
        objEmail.Subject = objConfiguracao.txt_assunto

        'Define o corpo do e-mail.        
        objEmail.Body = objConfiguracao.txt_mensagem

        'Para evitar problemas com caracteres "estranhos", configuramos o Charset para "ISO-8859-1"
        objEmail.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")
        objEmail.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1")

        'Cria objeto com os dados do SMTP
        Dim objSmtp As New System.Net.Mail.SmtpClient

        'Alocamos o endereço do host para enviar os e-mails:
        objSmtp.Host = objConfiguracao.txt_servidor_smtp
        objSmtp.UseDefaultCredentials = False
        objSmtp.Credentials = New System.Net.NetworkCredential(objConfiguracao.txt_servidor_smtp_usuario, objConfiguracao.txt_servidor_smtp_senha)
        objSmtp.Port = objConfiguracao.cod_porta
        objSmtp.EnableSsl = True

        Dim erro As String = ""
        'Enviamos o e-mail através do método .Send()
        Try
            objSmtp.Send(objEmail)
        Catch ex As Exception
            erro = ex.Source & "<br />" & ex.Message & "<br />" & ex.StackTrace
        Finally
            'Excluímos o objeto de e-mail da memória, é opcional
            objEmail.Dispose()
        End Try

    End Sub

End Module
