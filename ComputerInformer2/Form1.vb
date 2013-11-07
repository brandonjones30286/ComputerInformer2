Imports System.Net
Public Class frmComputerInformer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Visible = True
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'displays the total amount of RAM installed
        Dim memory As Int64
        memory = My.Computer.Info.TotalPhysicalMemory
        lblMemoryInstalled.Text = memory.ToString / 1073741824

        'displays the name of the computer
        lblComputerName.Text = My.Computer.Name

        Try
            Dim ipshost As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
            lblIpAddressA.Text = ipshost.AddressList(0).ToString

        Catch ex As Exception
            MsgBox("You May Not be connected to the Internet.")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Displays the Caps Lock Key Status
        If My.Computer.Keyboard.CapsLock = True Then lblCapsStat.Text = "On" Else lblCapsStat.Text = "Off"
        ''Displays the Number Lock Key Status
        If My.Computer.Keyboard.NumLock = True Then lblNumLockStat.Text = "On" Else lblNumLockStat.Text = "Off"
        ''Displays the Scroll Lock Key Status
        If My.Computer.Keyboard.ScrollLock = True Then lblScrollLockStat.Text = "On" Else lblScrollLockStat.Text = "Off"
        'Diaplays the availabe amount of RAM in realtime
        Dim memory As String
        memory = My.Computer.Info.AvailablePhysicalMemory
        lblmemoryAvail.Text = memory.ToString / 1073741824


    End Sub

    Private Sub SupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportToolStripMenuItem.Click
        MsgBox("If you need support, please create a new post at https://sourceforge.net/p/computerinformer/discussion/support/ ", MsgBoxStyle.Information, )
    End Sub

    Private Function IPHostEntry() As String
        Throw New NotImplementedException
    End Function

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

  


           



    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.SkyBlue
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.BackColor = Color.OrangeRed
    End Sub
End Class
