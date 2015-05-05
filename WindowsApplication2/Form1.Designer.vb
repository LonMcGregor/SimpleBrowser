<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.browser1 = New System.Windows.Forms.WebBrowser()
        Me.cmdGo = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.addressBar = New System.Windows.Forms.TextBox()
        Me.cmdForward = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.hideControl = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.addFav4 = New System.Windows.Forms.Button()
        Me.linkFav4 = New System.Windows.Forms.Button()
        Me.addFav3 = New System.Windows.Forms.Button()
        Me.linkFav3 = New System.Windows.Forms.Button()
        Me.addFav2 = New System.Windows.Forms.Button()
        Me.linkFav2 = New System.Windows.Forms.Button()
        Me.addFav1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.linkTweet = New System.Windows.Forms.PictureBox()
        Me.linkSearch = New System.Windows.Forms.PictureBox()
        Me.linkWiki = New System.Windows.Forms.PictureBox()
        Me.linkMail = New System.Windows.Forms.PictureBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.linkTweet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkWiki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'browser1
        '
        Me.browser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser1.Location = New System.Drawing.Point(0, 0)
        Me.browser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser1.Name = "browser1"
        Me.browser1.Size = New System.Drawing.Size(886, 609)
        Me.browser1.TabIndex = 1
        Me.browser1.Url = New System.Uri("http://www.duckduckgo.com", System.UriKind.Absolute)
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(709, 5)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(73, 33)
        Me.cmdGo.TabIndex = 3
        Me.cmdGo.Text = "Go"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(3, 5)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(43, 33)
        Me.cmdBack.TabIndex = 4
        Me.cmdBack.Text = "<-"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'addressBar
        '
        Me.addressBar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.addressBar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressBar.ForeColor = System.Drawing.SystemColors.Window
        Me.addressBar.Location = New System.Drawing.Point(101, 6)
        Me.addressBar.Name = "addressBar"
        Me.addressBar.Size = New System.Drawing.Size(524, 32)
        Me.addressBar.TabIndex = 5
        '
        'cmdForward
        '
        Me.cmdForward.Location = New System.Drawing.Point(52, 5)
        Me.cmdForward.Name = "cmdForward"
        Me.cmdForward.Size = New System.Drawing.Size(43, 33)
        Me.cmdForward.TabIndex = 6
        Me.cmdForward.Text = "->"
        Me.cmdForward.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(670, 5)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(33, 33)
        Me.cmdRefresh.TabIndex = 7
        Me.cmdRefresh.Text = "(R)"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(631, 6)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(33, 33)
        Me.cmdStop.TabIndex = 8
        Me.cmdStop.Text = "/!\"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.browser1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 609)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.cmdGo)
        Me.Panel2.Controls.Add(Me.cmdBack)
        Me.Panel2.Controls.Add(Me.cmdStop)
        Me.Panel2.Controls.Add(Me.addressBar)
        Me.Panel2.Controls.Add(Me.cmdRefresh)
        Me.Panel2.Controls.Add(Me.cmdForward)
        Me.Panel2.Location = New System.Drawing.Point(57, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 41)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.hideControl)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.cmdAdd)
        Me.Panel3.Location = New System.Drawing.Point(8, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(46, 335)
        Me.Panel3.TabIndex = 2
        '
        'hideControl
        '
        Me.hideControl.Location = New System.Drawing.Point(22, 3)
        Me.hideControl.Name = "hideControl"
        Me.hideControl.Size = New System.Drawing.Size(18, 20)
        Me.hideControl.TabIndex = 4
        Me.hideControl.Text = "="
        Me.hideControl.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.addFav4)
        Me.Panel4.Controls.Add(Me.linkFav4)
        Me.Panel4.Controls.Add(Me.addFav3)
        Me.Panel4.Controls.Add(Me.linkFav3)
        Me.Panel4.Controls.Add(Me.addFav2)
        Me.Panel4.Controls.Add(Me.linkFav2)
        Me.Panel4.Controls.Add(Me.addFav1)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.linkTweet)
        Me.Panel4.Controls.Add(Me.linkSearch)
        Me.Panel4.Controls.Add(Me.linkWiki)
        Me.Panel4.Controls.Add(Me.linkMail)
        Me.Panel4.Location = New System.Drawing.Point(3, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(40, 303)
        Me.Panel4.TabIndex = 3
        '
        'addFav4
        '
        Me.addFav4.Location = New System.Drawing.Point(21, 268)
        Me.addFav4.Name = "addFav4"
        Me.addFav4.Size = New System.Drawing.Size(16, 32)
        Me.addFav4.TabIndex = 15
        Me.addFav4.Text = "+"
        Me.addFav4.UseVisualStyleBackColor = True
        '
        'linkFav4
        '
        Me.linkFav4.Location = New System.Drawing.Point(3, 268)
        Me.linkFav4.Name = "linkFav4"
        Me.linkFav4.Size = New System.Drawing.Size(18, 32)
        Me.linkFav4.TabIndex = 14
        Me.linkFav4.Text = "4"
        Me.linkFav4.UseVisualStyleBackColor = True
        '
        'addFav3
        '
        Me.addFav3.Location = New System.Drawing.Point(21, 230)
        Me.addFav3.Name = "addFav3"
        Me.addFav3.Size = New System.Drawing.Size(16, 32)
        Me.addFav3.TabIndex = 13
        Me.addFav3.Text = "+"
        Me.addFav3.UseVisualStyleBackColor = True
        '
        'linkFav3
        '
        Me.linkFav3.Location = New System.Drawing.Point(3, 230)
        Me.linkFav3.Name = "linkFav3"
        Me.linkFav3.Size = New System.Drawing.Size(18, 32)
        Me.linkFav3.TabIndex = 12
        Me.linkFav3.Text = "3"
        Me.linkFav3.UseVisualStyleBackColor = True
        '
        'addFav2
        '
        Me.addFav2.Location = New System.Drawing.Point(21, 192)
        Me.addFav2.Name = "addFav2"
        Me.addFav2.Size = New System.Drawing.Size(16, 32)
        Me.addFav2.TabIndex = 11
        Me.addFav2.Text = "+"
        Me.addFav2.UseVisualStyleBackColor = True
        '
        'linkFav2
        '
        Me.linkFav2.Location = New System.Drawing.Point(3, 192)
        Me.linkFav2.Name = "linkFav2"
        Me.linkFav2.Size = New System.Drawing.Size(18, 32)
        Me.linkFav2.TabIndex = 10
        Me.linkFav2.Text = "2"
        Me.linkFav2.UseVisualStyleBackColor = True
        '
        'addFav1
        '
        Me.addFav1.Location = New System.Drawing.Point(21, 154)
        Me.addFav1.Name = "addFav1"
        Me.addFav1.Size = New System.Drawing.Size(16, 32)
        Me.addFav1.TabIndex = 9
        Me.addFav1.Text = "+"
        Me.addFav1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'linkTweet
        '
        Me.linkTweet.Image = Global.LonMcGregorBrowser.My.Resources.Resources.tweet
        Me.linkTweet.Location = New System.Drawing.Point(3, 40)
        Me.linkTweet.Name = "linkTweet"
        Me.linkTweet.Size = New System.Drawing.Size(32, 32)
        Me.linkTweet.TabIndex = 7
        Me.linkTweet.TabStop = False
        '
        'linkSearch
        '
        Me.linkSearch.Image = Global.LonMcGregorBrowser.My.Resources.Resources.search
        Me.linkSearch.Location = New System.Drawing.Point(3, 78)
        Me.linkSearch.Name = "linkSearch"
        Me.linkSearch.Size = New System.Drawing.Size(32, 32)
        Me.linkSearch.TabIndex = 6
        Me.linkSearch.TabStop = False
        '
        'linkWiki
        '
        Me.linkWiki.Image = Global.LonMcGregorBrowser.My.Resources.Resources.wikipedia
        Me.linkWiki.Location = New System.Drawing.Point(3, 116)
        Me.linkWiki.Name = "linkWiki"
        Me.linkWiki.Size = New System.Drawing.Size(32, 32)
        Me.linkWiki.TabIndex = 5
        Me.linkWiki.TabStop = False
        '
        'linkMail
        '
        Me.linkMail.Image = Global.LonMcGregorBrowser.My.Resources.Resources.mail
        Me.linkMail.Location = New System.Drawing.Point(3, 2)
        Me.linkMail.Name = "linkMail"
        Me.linkMail.Size = New System.Drawing.Size(32, 32)
        Me.linkMail.TabIndex = 4
        Me.linkMail.TabStop = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(6, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(18, 20)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "+"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(886, 609)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Simple Browser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.linkTweet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkWiki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents browser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents addressBar As System.Windows.Forms.TextBox
    Friend WithEvents cmdForward As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents linkMail As System.Windows.Forms.PictureBox
    Friend WithEvents linkWiki As System.Windows.Forms.PictureBox
    Friend WithEvents linkSearch As System.Windows.Forms.PictureBox
    Friend WithEvents linkTweet As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents addFav1 As System.Windows.Forms.Button
    Friend WithEvents addFav2 As System.Windows.Forms.Button
    Friend WithEvents linkFav2 As System.Windows.Forms.Button
    Friend WithEvents addFav4 As System.Windows.Forms.Button
    Friend WithEvents linkFav4 As System.Windows.Forms.Button
    Friend WithEvents addFav3 As System.Windows.Forms.Button
    Friend WithEvents linkFav3 As System.Windows.Forms.Button
    Friend WithEvents hideControl As System.Windows.Forms.Button

End Class
