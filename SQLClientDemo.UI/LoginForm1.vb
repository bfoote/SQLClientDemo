Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        ' Save the username to the registry
        If My.User.IsAuthenticated Then

            SaveSetting(My.Application.Info.ProductName, "Startup", "UserName", UsernameTextBox.Text)
            frmSQLClientDemo.Show()
            Me.Hide()

        End If


        


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Get the setting from the registry
        If My.User.IsAuthenticated Then
            UsernameTextBox.Text = My.User.Name
        Else
            UsernameTextBox.Text = GetSetting(My.Application.Info.ProductName, "Startup", "UserName", "Enter your name")
        End If

    End Sub
End Class
