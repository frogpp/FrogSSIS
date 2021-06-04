<Authorize>
Public Class HomeController
    Inherits Controller

    Public Function Index() As ActionResult
        ViewBag.Title = "Home Page"
        Return View()
    End Function
End Class
