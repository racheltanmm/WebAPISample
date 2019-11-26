Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class ItemController
        Inherits ApiController


        Public Function GetValues() As String
            'Return New String() {"Person1", "Person2"}
            Return LoadAPIFunction("GET", "", "")


        End Function

        ' GET: api/Person/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "Person" & id
        End Function



    End Class
End Namespace