Imports Newtonsoft.Json
Imports System.Net.Http
Imports WindowsApp1.Form2

Public Class Form3
    ' List to hold the submissions
    Private Submissions As List(Of Submission)
    ' Variable to track the current submission index
    Private CurrentIndex As Integer

    ' Form Load event
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize submissions list by fetching from the backend
        Submissions = Await GetSubmissionsFromBackend()
        ' Set the current index to 0 (first submission)
        CurrentIndex = 0
        ' Display the first submission
        DisplaySubmission()
    End Sub

    ' Function to fetch submissions from backend
    Private Async Function GetSubmissionsFromBackend() As Task(Of List(Of Submission))
        Dim client As New HttpClient()
        Dim submissions As New List(Of Submission)
        Dim index As Integer = 0

        While True
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:8000/api/Submission?index={index}")
            If response.StatusCode = Net.HttpStatusCode.NotFound Then
                Exit While
            End If
            Dim jsonString As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonString)
            submissions.Add(submission)
            index += 1
        End While

        Return submissions
    End Function

    ' Function to display the current submission
    Private Sub DisplaySubmission()
        If Submissions IsNot Nothing AndAlso Submissions.Count > 0 Then
            TextBox1.Text = Submissions(CurrentIndex).Name
            TextBox2.Text = Submissions(CurrentIndex).Email
            TextBox3.Text = Submissions(CurrentIndex).Phone
            TextBox4.Text = Submissions(CurrentIndex).GithubLink
            TextBox5.Text = Submissions(CurrentIndex).StopwatchTime
        Else
            TextBox1.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox5.Text = String.Empty

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CurrentIndex > 0 Then
            CurrentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CurrentIndex < Submissions.Count - 1 Then
            CurrentIndex += 1
            DisplaySubmission()
        End If
    End Sub
    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class
End Class