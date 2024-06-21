
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json

Public Class Form2
    Dim elapsedTime As TimeSpan
    Dim isRunning As Boolean = False

    Private Sub BtnStartPause_Click(sender As Object, e As EventArgs) Handles BtnStartPause.Click
        If Not isRunning Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
        isRunning = Not isRunning
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        UpdateTimerDisplay()
    End Sub

    Private Sub UpdateTimerDisplay()
        If InvokeRequired Then
            Invoke(Sub() UpdateTimerDisplay())
        Else
            Label4.Text = elapsedTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Async Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim submission As New Submission() With {
            .Name = TextBox1.Text,
            .Email = TextBox2.Text,
            .Phone = TextBox3.Text,
            .GithubLink = TextBox4.Text,
            .StopwatchTime = Label4.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)

        Try
            Await SubmitToBackendAsync(json)
        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message)
        End Try
    End Sub

    Private Async Function SubmitToBackendAsync(json As String) As Task
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8000")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync("/api/Submission", content)
            response.EnsureSuccessStatusCode()

            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            MessageBox.Show("Submission successful: " & responseBody)
        End Using
    End Function

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String
    End Class

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Submit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ' Toggle action (replace this with your actual toggle logic)
            BtnStartPause.PerformClick()
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class
