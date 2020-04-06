Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication
    Private Shared countA As Integer
    Private Shared countP As Integer
    Private Shared listA As New List(Of String)
    Private Shared listP As New List(Of String)



    Shared Function Get_listA() As List(Of String)
        Return listA
    End Function
    Shared Function Get_listP() As List(Of String)
        Return listP
    End Function

    Shared Sub Update_AddList(ByVal email As String, ByVal l As List(Of String))
        l.Add(email)
    End Sub
    Shared Sub Update_RemoveList(ByVal email As String, ByVal l As List(Of String))
        l.Remove(email)
    End Sub

    Shared Function Get_CountA() As Integer
        Return countA
    End Function

    Shared Function Get_CountP() As Integer
        Return countP
    End Function

    Shared Sub Update_CountP(ByVal int As Integer)
        countP = countP + int
    End Sub

    Shared Sub Update_CountA(ByVal int As Integer)
        countA = countA + int
    End Sub


    '-----------------------------------------------------
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la sesión
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la aplicación
    End Sub

End Class