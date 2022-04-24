<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label_ad = New System.Windows.Forms.LinkLabel()
        Me.triggerfileLocation = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.optionfileLocation = New System.Windows.Forms.TextBox()
        Me.mainTitle = New System.Windows.Forms.Label()
        Me.label_optionfileLocation = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.label_optionfileExtension = New System.Windows.Forms.Label()
        Me.optionfileExtension1 = New System.Windows.Forms.TextBox()
        Me.label_optionfileName = New System.Windows.Forms.Label()
        Me.optionfileName = New System.Windows.Forms.TextBox()
        Me.triggerCreate = New System.Windows.Forms.Button()
        Me.label_optionfileSize = New System.Windows.Forms.Label()
        Me.optionfileSize = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'label_ad
        '
        Me.label_ad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_ad.Location = New System.Drawing.Point(12, 268)
        Me.label_ad.Name = "label_ad"
        Me.label_ad.Size = New System.Drawing.Size(380, 26)
        Me.label_ad.TabIndex = 0
        Me.label_ad.TabStop = True
        Me.label_ad.Text = "Author and Source Code"
        Me.label_ad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'triggerfileLocation
        '
        Me.triggerfileLocation.Location = New System.Drawing.Point(340, 73)
        Me.triggerfileLocation.Name = "triggerfileLocation"
        Me.triggerfileLocation.Size = New System.Drawing.Size(54, 29)
        Me.triggerfileLocation.TabIndex = 1
        Me.triggerfileLocation.Text = "..."
        Me.triggerfileLocation.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 297)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(380, 12)
        Me.ProgressBar.TabIndex = 2
        '
        'optionfileLocation
        '
        Me.optionfileLocation.Location = New System.Drawing.Point(15, 73)
        Me.optionfileLocation.Multiline = True
        Me.optionfileLocation.Name = "optionfileLocation"
        Me.optionfileLocation.Size = New System.Drawing.Size(319, 29)
        Me.optionfileLocation.TabIndex = 3
        '
        'mainTitle
        '
        Me.mainTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.mainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainTitle.Location = New System.Drawing.Point(0, 0)
        Me.mainTitle.Name = "mainTitle"
        Me.mainTitle.Size = New System.Drawing.Size(404, 57)
        Me.mainTitle.TabIndex = 4
        Me.mainTitle.Text = "FakeDocumentGenerator"
        Me.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mainTitle.UseCompatibleTextRendering = True
        '
        'label_optionfileLocation
        '
        Me.label_optionfileLocation.AutoSize = True
        Me.label_optionfileLocation.Location = New System.Drawing.Point(12, 57)
        Me.label_optionfileLocation.Name = "label_optionfileLocation"
        Me.label_optionfileLocation.Size = New System.Drawing.Size(63, 13)
        Me.label_optionfileLocation.TabIndex = 5
        Me.label_optionfileLocation.Text = "File location"
        '
        'label_optionfileExtension
        '
        Me.label_optionfileExtension.AutoSize = True
        Me.label_optionfileExtension.Location = New System.Drawing.Point(12, 125)
        Me.label_optionfileExtension.Name = "label_optionfileExtension"
        Me.label_optionfileExtension.Size = New System.Drawing.Size(135, 13)
        Me.label_optionfileExtension.TabIndex = 6
        Me.label_optionfileExtension.Text = "File extension (without dot!)"
        '
        'optionfileExtension1
        '
        Me.optionfileExtension1.Location = New System.Drawing.Point(15, 141)
        Me.optionfileExtension1.MaxLength = 10
        Me.optionfileExtension1.Name = "optionfileExtension1"
        Me.optionfileExtension1.Size = New System.Drawing.Size(178, 20)
        Me.optionfileExtension1.TabIndex = 7
        '
        'label_optionfileName
        '
        Me.label_optionfileName.AutoSize = True
        Me.label_optionfileName.Location = New System.Drawing.Point(12, 184)
        Me.label_optionfileName.Name = "label_optionfileName"
        Me.label_optionfileName.Size = New System.Drawing.Size(52, 13)
        Me.label_optionfileName.TabIndex = 9
        Me.label_optionfileName.Text = "File name"
        '
        'optionfileName
        '
        Me.optionfileName.Location = New System.Drawing.Point(15, 200)
        Me.optionfileName.MaxLength = 100
        Me.optionfileName.Name = "optionfileName"
        Me.optionfileName.Size = New System.Drawing.Size(178, 20)
        Me.optionfileName.TabIndex = 10
        '
        'triggerCreate
        '
        Me.triggerCreate.Location = New System.Drawing.Point(15, 235)
        Me.triggerCreate.Name = "triggerCreate"
        Me.triggerCreate.Size = New System.Drawing.Size(377, 30)
        Me.triggerCreate.TabIndex = 11
        Me.triggerCreate.Text = "Create"
        Me.triggerCreate.UseVisualStyleBackColor = True
        '
        'label_optionfileSize
        '
        Me.label_optionfileSize.AutoSize = True
        Me.label_optionfileSize.Location = New System.Drawing.Point(211, 184)
        Me.label_optionfileSize.Name = "label_optionfileSize"
        Me.label_optionfileSize.Size = New System.Drawing.Size(67, 13)
        Me.label_optionfileSize.TabIndex = 12
        Me.label_optionfileSize.Text = "File size (KB)"
        '
        'optionfileSize
        '
        Me.optionfileSize.Location = New System.Drawing.Point(214, 200)
        Me.optionfileSize.Name = "optionfileSize"
        Me.optionfileSize.Size = New System.Drawing.Size(178, 20)
        Me.optionfileSize.TabIndex = 13
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(211, 144)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 13)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "List of known file extensions"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(404, 321)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.optionfileSize)
        Me.Controls.Add(Me.label_optionfileSize)
        Me.Controls.Add(Me.triggerCreate)
        Me.Controls.Add(Me.optionfileName)
        Me.Controls.Add(Me.label_optionfileName)
        Me.Controls.Add(Me.optionfileExtension1)
        Me.Controls.Add(Me.label_optionfileExtension)
        Me.Controls.Add(Me.label_optionfileLocation)
        Me.Controls.Add(Me.mainTitle)
        Me.Controls.Add(Me.optionfileLocation)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.triggerfileLocation)
        Me.Controls.Add(Me.label_ad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FDG >> Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_ad As LinkLabel
    Friend WithEvents triggerfileLocation As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents optionfileLocation As TextBox
    Friend WithEvents mainTitle As Label
    Friend WithEvents label_optionfileLocation As Label
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents label_optionfileExtension As Label
    Friend WithEvents optionfileExtension1 As TextBox
    Friend WithEvents label_optionfileName As Label
    Friend WithEvents optionfileName As TextBox
    Friend WithEvents triggerCreate As Button
    Friend WithEvents label_optionfileSize As Label
    Friend WithEvents optionfileSize As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
