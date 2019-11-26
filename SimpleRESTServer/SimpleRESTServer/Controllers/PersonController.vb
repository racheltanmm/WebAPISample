﻿Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class PersonController
        Inherits ApiController

        ' GET: api/Person
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"Person1", "Person2"}
        End Function

        ' GET: api/Person/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "Person" & id
        End Function

        ' POST: api/Person
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Person/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Person/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace