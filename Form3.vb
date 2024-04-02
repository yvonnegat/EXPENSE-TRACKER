Imports System.Data.OleDb

Public Class form3
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Downloads\expenseTracker.accdb;"

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
        Usernamelabel.ForeColor = Color.White
        Passwordlabel.ForeColor = Color.White
        signuplabel.ForeColor = Color.Blue
        SIGNUPbtn.BackColor = Color.Blue
    End Sub

    Private Sub SIGNUPbtn_Click(sender As Object, e As EventArgs) Handles SIGNUPbtn.Click
        Dim username As String = usernametextbox.Text
        Dim password As String = passwordtextbox.Text

        ' Check if username and password are not empty
        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        ' Check if username already exists
        If UsernameExists(username) Then
            MessageBox.Show("Username already exists. Please choose a different one.")
            Return
        End If

        ' Create new user
        If CreateUser(username, password) Then
            MessageBox.Show("User created successfully!")
            ' Optionally clear the textboxes after successful registration
            usernametextbox.Clear()
            passwordtextbox.Clear()

            Dim form4 As New Form4()
            form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failed to create user. Please try again.")
        End If
    End Sub

    Private Function UsernameExists(username As String) As Boolean
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM userDetails WHERE Username = @Username"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function CreateUser(username As String, password As String) As Boolean
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO userDetails (Username, [Password]) VALUES (@Username, @Password)"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        End Using
    End Function
End Class
