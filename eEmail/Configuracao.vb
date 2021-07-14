Public Class Configuracao
    Public Property cod_ssl() As Integer
        Get
            Return m_cod_ssl
        End Get
        Set(ByVal value As Integer)
            m_cod_ssl = value
        End Set
    End Property
    Private m_cod_ssl As Integer

    Public Property cod_porta() As Integer
        Get
            Return m_cod_porta
        End Get
        Set(ByVal value As Integer)
            m_cod_porta = value
        End Set
    End Property
    Private m_cod_porta As Integer
    Public Property txt_conta_email() As String
        Get
            Return m_txt_conta_email
        End Get
        Set(ByVal value As String)
            m_txt_conta_email = value
        End Set
    End Property
    Private m_txt_conta_email As String

    Public Property txt_servidor_smtp() As String
        Get
            Return m_txt_servidor_smtp
        End Get
        Set(ByVal value As String)
            m_txt_servidor_smtp = value
        End Set
    End Property
    Private m_txt_servidor_smtp As String

    Public Property txt_servidor_smtp_usuario() As String
        Get
            Return m_txt_servidor_smtp_usuario
        End Get
        Set(ByVal value As String)
            m_txt_servidor_smtp_usuario = value
        End Set
    End Property
    Private m_txt_servidor_smtp_usuario As String

    Public Property txt_servidor_smtp_senha() As String
        Get
            Return m_txt_servidor_smtp_senha
        End Get
        Set(ByVal value As String)
            m_txt_servidor_smtp_senha = value
        End Set
    End Property
    Private m_txt_servidor_smtp_senha As String

    Public Property txt_remetente() As String
        Get
            Return m_txt_remetente
        End Get
        Set(ByVal value As String)
            m_txt_remetente = value
        End Set
    End Property
    Private m_txt_remetente As String

    Public Property txt_destinatario() As String
        Get
            Return m_txt_destinatario
        End Get
        Set(ByVal value As String)
            m_txt_destinatario = value
        End Set
    End Property
    Private m_txt_destinatario As String

    Public Property txt_mensagem() As String
        Get
            Return m_txt_mensagem
        End Get
        Set(ByVal value As String)
            m_txt_mensagem = value
        End Set
    End Property
    Private m_txt_mensagem As String

    Public Property txt_assunto() As String
        Get
            Return m_txt_assunto
        End Get
        Set(ByVal value As String)
            m_txt_assunto = value
        End Set
    End Property
    Private m_txt_assunto As String

    Public Property txt_email_padrao() As String
        Get
            Return m_txt_email_padrao
        End Get
        Set(ByVal value As String)
            m_txt_email_padrao = value
        End Set
    End Property
    Private m_txt_email_padrao As String

    Public Property txt_status() As String
        Get
            Return m_txt_status
        End Get
        Set(ByVal value As String)
            m_txt_status = value
        End Set
    End Property
    Private m_txt_status As String
End Class
