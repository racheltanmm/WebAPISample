Imports System.Net.Http


Module vbCommon


    Public Function LoadAPIFunction(ByVal RequestMethod As String, ByVal MethodName As String, ByVal Parameter As String) As String

        Using client = New HttpClient()

            client.BaseAddress = New Uri("http://mmsce-uat.mentormedia.com:8080/wmwebservice_rest/INFOR_SCUAT_WMWHSE1/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Add("Username", "rachel_tan")
            client.DefaultRequestHeaders.Add("Password", "Ll349329Ll")
            client.DefaultRequestHeaders.Add("Tenant", "INFOR")
            client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

            Dim responseTask = client.GetAsync("items/336574-001/UPG")
            Dim result = responseTask.Result

            If result.IsSuccessStatusCode Then
                Dim rtn = result.Content.ReadAsStringAsync().Result
                Return rtn

            Else
                Return "Error"
            End If
        End Using

    End Function


End Module
