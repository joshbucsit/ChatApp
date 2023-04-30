Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmMain

    'VARIABLE FOR DATABASE CONNECTION
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim host_name As String = Dns.GetHostName()
        Dim ip_address As String = Dns.GetHostEntry(host_name).AddressList(0).ToString()
        Me.Text = "SYSTEM IP: " & ip_address

    End Sub
    Public Sub loadMessage() 'USER DEFINED PROCEDURE
        'MySQL Database CONNECTION
        conn = New MySqlConnection
        conn.ConnectionString = "server=" & txtServerIP.Text & ";port=3306;userid=root;password='';database=vbchatapp"
        Try
            If conn.State = ConnectionState.Open Then
            Else
                conn.Open()
            End If
            'CONNECT TO TABLE
            Dim cmd As New MySqlCommand("SELECT * FROM `tblMessage` ", conn)
            dr = cmd.ExecuteReader
            'TRANSFER THE VALUE OF THE FIELD 'MESSAGE' IN THE RICH TEXTBOX
            While dr.Read
                rtbMessage.Text = dr.Item("Message")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        'RUNS THE CODE CONTINUESLY DEPENDING ON THE INTERVAL OF THE TIMER
        'THE LOWER THE INTERVAL THE FASTER THE EXECUTION OF THE CODE AND VICE VERSA
        Call loadMessage()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        'REQUIRES A USERNAME FOR IDENTIFICATION
        If txtuser.Text = "" Then MsgBox("Type a User name!!") : Exit Sub
        'REFRESH THE RICHBOX TO VIEW LATEST UPDATE/MESSAGE
        loadMessage()
        'DATABASE CONNECTION
        conn = New MySqlConnection
        conn.ConnectionString = "server=" & txtServerIP.Text & ";port=3306;userid=root;password='';database=vbchatapp"
        Try
            If conn.State = ConnectionState.Open Then
            Else
                conn.Open()
            End If

            'UPDATES THE FOLLOWING TABLE CONTENT TO BE VIEWED ON RICH TEXTBOX
            '1. STATUS OF CONNECTION
            '2. TIME OF CONNECTION AND DISCONNECTION
            '3. USER NAME
            Dim cmd As New MySqlCommand("UPDATE `tblMessage` SET `Message`=@Message", conn)
            cmd.Parameters.Clear()
            'CONNECTED
            If btnConnect.Text = "Connect" Then
                cmd.Parameters.AddWithValue("Message", UCase(txtuser.Text) & " | " & TimeOfDay.ToString("h:mm:ss tt") & " Connected!" & vbCrLf & vbCrLf & rtbMessage.Text)
                cmd.ExecuteNonQuery()
                btnConnect.Text = "Disconnect"
                txtServerIP.Enabled = False
                txtuser.Enabled = False
                loadMessage()
                Timer1.Enabled = True
                Timer1.Interval = 500
            Else
                'DISCONNECTED
                cmd.Parameters.AddWithValue("Message", UCase(txtuser.Text) & " | " & TimeOfDay.ToString("h:mm:ss tt") & " Disconnected!" & vbCrLf & vbCrLf & rtbMessage.Text)
                cmd.ExecuteNonQuery()
                btnConnect.Text = "Connect"
                txtMessage.Text = ""
                rtbMessage.Text = ""
                txtServerIP.Enabled = True
                txtuser.Enabled = True
                Timer1.Enabled = False
            End If
        Catch ex As Exception
            Timer1.Enabled = True
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtuser.Text = "" Then MsgBox("Type a User name!!") : Exit Sub
        If txtMessage.Text = "" Then MsgBox("Type a Message") : Exit Sub
        conn = New MySqlConnection
        conn.ConnectionString = "server=" & txtServerIP.Text & ";port=3306;userid=root;password='';database=vbchatapp"
        Try
            If conn.State = ConnectionState.Open Then
            Else
                conn.Open()
            End If
            Dim cmd As New MySqlCommand("UPDATE `tblMessage` SET `Message`=@Message", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Message", UCase(txtuser.Text) & " | " & TimeOfDay.ToString("h:mm:ss tt") & vbCrLf & "- " & txtMessage.Text & " -" & vbCrLf & vbCrLf & rtbMessage.Text)
            cmd.ExecuteNonQuery()
            loadMessage()
            txtMessage.Text = ""
            txtMessage.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call loadMessage()

    End Sub
End Class
