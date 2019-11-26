Imports System.Net
Imports System.Web.Http

Public Class CarController
    Inherits ApiController

    Private cars As Car() = New Car() _
    {New Car() With {
        .ID = 1,
        .Make = "Aston Martin",
        .Model = "V8 Vantage"
    }, New Car() With {
        .ID = 2,
        .Make = "BMW",
        .Model = "Z8"
    }, New Car() With {
        .ID = 3,
        .Make = "Ferrari",
        .Model = "California"
    }, New Car() With {
        .ID = 4,
        .Make = "Pagani",
        .Model = "Zonda"
    }
    }

    Public Function GetCars() As IEnumerable(Of Car)
        Return cars
    End Function

End Class
