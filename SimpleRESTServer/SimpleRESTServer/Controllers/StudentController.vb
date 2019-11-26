Imports System.Net.Http
Imports System.Web.Http


Public Class StudentController
    Inherits ApiController


    Public Function Index() As IEnumerable(Of String)
        Dim students As IEnumerable(Of String) = Nothing

        Using client = New HttpClient()
            client.BaseAddress = New Uri("http://mmsce-uat.mentormedia.com:8080/wmwebservice_rest/INFOR_SCUAT_WMWHSE1/")
            Dim responseTask = client.GetAsync("items/336574-001/UPG")
            responseTask.Wait()
            Dim result = responseTask.Result

            If result.IsSuccessStatusCode Then
                Dim readTask = result.Content.ReadAsAsync(Of IList(Of String))()
                readTask.Wait()
                students = readTask.Result
            Else
                students = Enumerable.Empty(Of String)()
                ModelState.AddModelError(String.Empty, "Server error. Please contact administrator.")
            End If
        End Using

        'Return View(students)
    End Function
End Class
