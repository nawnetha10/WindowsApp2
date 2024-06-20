Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class Form3
    Private submissions As New List(Of Submission)()
    Private currentIndex As Integer = 0
    Private ReadOnly client As HttpClient

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize HttpClient
        client = New HttpClient()

        ' Load submissions from the backend
        LoadSubmissionsAsync().GetAwaiter().GetResult()
        DisplaySubmission()
    End Sub

    Private Async Function LoadSubmissionsAsync() As Task
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:8000/api/Submission")
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(responseBody)
        Catch e As HttpRequestException
            MessageBox.Show($"Request error: {e.Message}")
        Catch e As TaskCanceledException
            MessageBox.Show($"Request timed out: {e.Message}")
        Catch e As Exception
            MessageBox.Show($"Unexpected error: {e.Message}")
        End Try
    End Function

    Private Sub DisplaySubmission()
        If submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submission = submissions(currentIndex)
            TextBox1.Text = submission.Name
            TextBox2.Text = submission.Email
            TextBox3.Text = submission.Phone
            TextBox4.Text = submission.GithubLink
            TextBox5.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
