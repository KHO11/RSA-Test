Imports System.IO
Imports System.Data
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Dim Span1 As Object



    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function UploadFile(FileUpload1 As FileUpload, GridView1 As GridView) As ActionResult
        ViewData("Message") = "Upload File page."
        Dim newFile As WeatherDetails = New WeatherDetails()
        Dim csvPath As String = Server.MapPath("~/csvFile/") + Path.GetFileName(FileUpload1.PostedFile.FileName)
        FileUpload1.SaveAs(csvPath)

        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn(2) {New DataColumn(newFile.Lat, GetType(Decimal)), New DataColumn(newFile.Longitude, GetType(Decimal)), New DataColumn(newFile.locatioName, GetType(String))})

        Dim csvData As String = System.IO.File.ReadAllText(csvPath)

        For Each row As String In csvData.Split(ControlChars.Lf)
            If Not String.IsNullOrEmpty(row) Then
                dt.Rows.Add()
                Dim i As Integer = 0

                'Execute a loop over the columns.
                For Each cell As String In row.Split(","c)
                    dt.Rows(dt.Rows.Count - 1)(i) = cell
                    i += 1
                Next
            End If
        Next


        GridView1.DataSource = dt
        GridView1.DataBind()
        Return View()
    End Function

End Class
