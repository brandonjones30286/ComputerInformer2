﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputerInformer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComputerInformer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIpAddressA = New System.Windows.Forms.Label()
        Me.lblIpAddress = New System.Windows.Forms.Label()
        Me.lblComputerName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpKeyboard = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScrollLockStat = New System.Windows.Forms.Label()
        Me.lblNumLockStat = New System.Windows.Forms.Label()
        Me.lblCapsStat = New System.Windows.Forms.Label()
        Me.lblScrollLock = New System.Windows.Forms.Label()
        Me.lblNumLock = New System.Windows.Forms.Label()
        Me.lblCapsLock = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblmemoryAvail = New System.Windows.Forms.Label()
        Me.lblMemoryInstalled = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.grpKeyboard.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem, Me.SupportToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SupportToolStripMenuItem.Text = "Support"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem})
        Me.ColorToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.OrangeToolStripMenuItem})
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIpAddressA)
        Me.GroupBox2.Controls.Add(Me.lblIpAddress)
        Me.GroupBox2.Controls.Add(Me.lblComputerName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 120)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Network"
        '
        'lblIpAddressA
        '
        Me.lblIpAddressA.AutoSize = true
        Me.lblIpAddressA.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblIpAddressA.Location = New System.Drawing.Point(108, 47)
        Me.lblIpAddressA.Name = "lblIpAddressA"
        Me.lblIpAddressA.Size = New System.Drawing.Size(97, 15)
        Me.lblIpAddressA.TabIndex = 3
        Me.lblIpAddressA.Text = "Comming Soon!"
        '
        'lblIpAddress
        '
        Me.lblIpAddress.AutoSize = true
        Me.lblIpAddress.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblIpAddress.Location = New System.Drawing.Point(5, 50)
        Me.lblIpAddress.Name = "lblIpAddress"
        Me.lblIpAddress.Size = New System.Drawing.Size(65, 15)
        Me.lblIpAddress.TabIndex = 2
        Me.lblIpAddress.Text = "Ip Address"
        '
        'lblComputerName
        '
        Me.lblComputerName.AutoSize = true
        Me.lblComputerName.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblComputerName.Location = New System.Drawing.Point(108, 22)
        Me.lblComputerName.Name = "lblComputerName"
        Me.lblComputerName.Size = New System.Drawing.Size(106, 15)
        Me.lblComputerName.TabIndex = 1
        Me.lblComputerName.Text = "lbComputerName"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Computer Name:"
        '
        'grpKeyboard
        '
        Me.grpKeyboard.Controls.Add(Me.TextBox1)
        Me.grpKeyboard.Controls.Add(Me.Label1)
        Me.grpKeyboard.Controls.Add(Me.lblScrollLockStat)
        Me.grpKeyboard.Controls.Add(Me.lblNumLockStat)
        Me.grpKeyboard.Controls.Add(Me.lblCapsStat)
        Me.grpKeyboard.Controls.Add(Me.lblScrollLock)
        Me.grpKeyboard.Controls.Add(Me.lblNumLock)
        Me.grpKeyboard.Controls.Add(Me.lblCapsLock)
        Me.grpKeyboard.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.grpKeyboard.Location = New System.Drawing.Point(12, 168)
        Me.grpKeyboard.Name = "grpKeyboard"
        Me.grpKeyboard.Size = New System.Drawing.Size(193, 179)
        Me.grpKeyboard.TabIndex = 5
        Me.grpKeyboard.TabStop = false
        Me.grpKeyboard.Text = "Keyboard"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 145)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Click in the textbox below to type"
        '
        'lblScrollLockStat
        '
        Me.lblScrollLockStat.AutoSize = true
        Me.lblScrollLockStat.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblScrollLockStat.Location = New System.Drawing.Point(86, 87)
        Me.lblScrollLockStat.Name = "lblScrollLockStat"
        Me.lblScrollLockStat.Size = New System.Drawing.Size(45, 15)
        Me.lblScrollLockStat.TabIndex = 5
        Me.lblScrollLockStat.Text = "Label6"
        '
        'lblNumLockStat
        '
        Me.lblNumLockStat.AutoSize = true
        Me.lblNumLockStat.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNumLockStat.Location = New System.Drawing.Point(86, 55)
        Me.lblNumLockStat.Name = "lblNumLockStat"
        Me.lblNumLockStat.Size = New System.Drawing.Size(45, 15)
        Me.lblNumLockStat.TabIndex = 4
        Me.lblNumLockStat.Text = "Label5"
        '
        'lblCapsStat
        '
        Me.lblCapsStat.AutoSize = true
        Me.lblCapsStat.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCapsStat.Location = New System.Drawing.Point(86, 27)
        Me.lblCapsStat.Name = "lblCapsStat"
        Me.lblCapsStat.Size = New System.Drawing.Size(45, 15)
        Me.lblCapsStat.TabIndex = 3
        Me.lblCapsStat.Text = "Label4"
        '
        'lblScrollLock
        '
        Me.lblScrollLock.AutoSize = true
        Me.lblScrollLock.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblScrollLock.Location = New System.Drawing.Point(17, 87)
        Me.lblScrollLock.Name = "lblScrollLock"
        Me.lblScrollLock.Size = New System.Drawing.Size(70, 15)
        Me.lblScrollLock.TabIndex = 2
        Me.lblScrollLock.Text = "Scroll Lock:"
        '
        'lblNumLock
        '
        Me.lblNumLock.AutoSize = true
        Me.lblNumLock.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNumLock.Location = New System.Drawing.Point(6, 55)
        Me.lblNumLock.Name = "lblNumLock"
        Me.lblNumLock.Size = New System.Drawing.Size(84, 15)
        Me.lblNumLock.TabIndex = 1
        Me.lblNumLock.Text = "Number Lock:"
        '
        'lblCapsLock
        '
        Me.lblCapsLock.AutoSize = true
        Me.lblCapsLock.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCapsLock.Location = New System.Drawing.Point(19, 27)
        Me.lblCapsLock.Name = "lblCapsLock"
        Me.lblCapsLock.Size = New System.Drawing.Size(69, 15)
        Me.lblCapsLock.TabIndex = 0
        Me.lblCapsLock.Text = "Caps Lock:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblmemoryAvail)
        Me.GroupBox1.Controls.Add(Me.lblMemoryInstalled)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(322, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 123)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Memory"
        '
        'lblmemoryAvail
        '
        Me.lblmemoryAvail.AutoSize = true
        Me.lblmemoryAvail.Location = New System.Drawing.Point(147, 84)
        Me.lblmemoryAvail.Name = "lblmemoryAvail"
        Me.lblmemoryAvail.Size = New System.Drawing.Size(113, 18)
        Me.lblmemoryAvail.TabIndex = 3
        Me.lblmemoryAvail.Text = "lblMemoryAvail"
        '
        'lblMemoryInstalled
        '
        Me.lblMemoryInstalled.AutoSize = true
        Me.lblMemoryInstalled.Location = New System.Drawing.Point(147, 36)
        Me.lblMemoryInstalled.Name = "lblMemoryInstalled"
        Me.lblMemoryInstalled.Size = New System.Drawing.Size(135, 18)
        Me.lblMemoryInstalled.TabIndex = 2
        Me.lblMemoryInstalled.Text = "lblMemoryInstalled"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(-1, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Memory Available:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Memory Installed:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'frmComputerInformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpKeyboard)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "frmComputerInformer"
        Me.Text = "ComputerInformer"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.grpKeyboard.ResumeLayout(false)
        Me.grpKeyboard.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIpAddressA As System.Windows.Forms.Label
    Friend WithEvents lblIpAddress As System.Windows.Forms.Label
    Friend WithEvents lblComputerName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpKeyboard As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScrollLockStat As System.Windows.Forms.Label
    Friend WithEvents lblNumLockStat As System.Windows.Forms.Label
    Friend WithEvents lblCapsStat As System.Windows.Forms.Label
    Friend WithEvents lblScrollLock As System.Windows.Forms.Label
    Friend WithEvents lblNumLock As System.Windows.Forms.Label
    Friend WithEvents lblCapsLock As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmemoryAvail As System.Windows.Forms.Label
    Friend WithEvents lblMemoryInstalled As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
