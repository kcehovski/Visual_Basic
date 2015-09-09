Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class Form1
    Dim connectionString As String
    Dim cnn As New SqlConnection
    Dim dt As New DataTable
    Dim iIndex As Integer = 0
    Dim iRecCount As Integer


    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        Dim sw As StreamWriter
        Dim sWriteFIle As String

        sWriteFIle = "..\..\FromDatabase.txt"
        If File.Exists(sWriteFIle) Then
            File.Delete(sWriteFIle)
        End If
        sw = New StreamWriter(sWriteFIle, True)

        connectionString = "C:\Users\blue4\Documents\vsprojects\Visual_Basic\projectReadingAndWriting\Database.mdf"
        cnn = New SqlConnection(connectionString)

        Try
            cnn.Open()
            Dim str As String = "SELECT * FROM Customers"
            Dim da As New SqlDataAdapter(str, cnn)
            da.Fill(dt)
            iRecCount = dt.Rows.Count

            For Me.iIndex = 0 To iRecCount - 1
                sw.Write(Trim(dt.Rows(iIndex).Item(2)) & ", " &
                         Trim(dt.Rows(iIndex).Item(1)) & vbNewLine)
            Next iIndex

            sw.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If cnn.State() = ConnectionState.Open Then
            cnn.Close()
        End If
        Me.Close()
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        WriteToTextBox()
        WriteToTextFile()
    End Sub

    Private Sub WriteToTextBox()
        Dim sr As StreamReader
        Dim sReadFile As String

        sReadFile = "..\..\FromDatabase.txt"

        Try
            sr = New StreamReader(sReadFile)
            Dim strLine As String = ""

            Do While sr.Peek() <> -1
                strLine = strLine & sr.ReadLine & vbNewLine
            Loop
            txtOutput.Text = strLine
            sr.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub WriteToTextFile()
        Dim sr As StreamReader
        Dim sReadFile As String
        Dim sw As StreamWriter
        Dim sWriteFile As String

        sReadFile = "..\..\FromDatabase.txt"
        sWriteFile = "..\..\Output.txt"

        If File.Exists(sWriteFile) Then
            File.Delete(sWriteFile)
        End If

        Try
            sr = New StreamReader(sReadFile)
            sw = New StreamWriter(sWriteFile)

            Dim strLine As String = ""
            Do While sr.Peek() <> -1
                strLine = sr.ReadLine() & vbNewLine
                sw.Write(strLine)
            Loop

            sr.Close()
            sw.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
