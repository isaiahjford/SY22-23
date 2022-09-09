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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Squareshape = New System.Windows.Forms.Button()
        Me.redTextBox = New System.Windows.Forms.TextBox()
        Me.GreentextBox = New System.Windows.Forms.TextBox()
        Me.blueTextBox = New System.Windows.Forms.TextBox()
        Me.ViewcolorButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red (0 to 225):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Green (0 to 225)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue (0 to 225)"
        '
        'Squareshape
        '
        Me.Squareshape.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Squareshape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Squareshape.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Squareshape.Location = New System.Drawing.Point(353, 11)
        Me.Squareshape.Name = "Squareshape"
        Me.Squareshape.Size = New System.Drawing.Size(414, 409)
        Me.Squareshape.TabIndex = 3
        Me.Squareshape.UseVisualStyleBackColor = False
        '
        'redTextBox
        '
        Me.redTextBox.Location = New System.Drawing.Point(204, 94)
        Me.redTextBox.Name = "redTextBox"
        Me.redTextBox.Size = New System.Drawing.Size(100, 22)
        Me.redTextBox.TabIndex = 4
        '
        'GreentextBox
        '
        Me.GreentextBox.Location = New System.Drawing.Point(204, 191)
        Me.GreentextBox.Name = "GreentextBox"
        Me.GreentextBox.Size = New System.Drawing.Size(100, 22)
        Me.GreentextBox.TabIndex = 5
        '
        'blueTextBox
        '
        Me.blueTextBox.Location = New System.Drawing.Point(202, 293)
        Me.blueTextBox.Name = "blueTextBox"
        Me.blueTextBox.Size = New System.Drawing.Size(100, 22)
        Me.blueTextBox.TabIndex = 6
        '
        'ViewcolorButton
        '
        Me.ViewcolorButton.Location = New System.Drawing.Point(56, 386)
        Me.ViewcolorButton.Name = "ViewcolorButton"
        Me.ViewcolorButton.Size = New System.Drawing.Size(115, 34)
        Me.ViewcolorButton.TabIndex = 8
        Me.ViewcolorButton.Text = "View Color"
        Me.ViewcolorButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(202, 386)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(107, 34)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ViewcolorButton)
        Me.Controls.Add(Me.blueTextBox)
        Me.Controls.Add(Me.GreentextBox)
        Me.Controls.Add(Me.redTextBox)
        Me.Controls.Add(Me.Squareshape)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ColorChanger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Squareshape As Button
    Friend WithEvents redTextBox As TextBox
    Friend WithEvents GreentextBox As TextBox
    Friend WithEvents blueTextBox As TextBox
    Friend WithEvents ViewcolorButton As Button
    Friend WithEvents ExitButton As Button
End Class
