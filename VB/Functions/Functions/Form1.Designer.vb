<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.PerimeterLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(356, 78)
        Me.LengthTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(112, 28)
        Me.LengthTextBox.TabIndex = 0
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(356, 136)
        Me.WidthTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(112, 28)
        Me.WidthTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 284)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Perimeter"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(356, 341)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(112, 23)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'AreaLabel
        '
        Me.AreaLabel.AutoSize = True
        Me.AreaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AreaLabel.Location = New System.Drawing.Point(356, 215)
        Me.AreaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AreaLabel.Name = "AreaLabel"
        Me.AreaLabel.Size = New System.Drawing.Size(66, 19)
        Me.AreaLabel.TabIndex = 7
        Me.AreaLabel.Text = "        "
        '
        'PerimeterLabel
        '
        Me.PerimeterLabel.AutoSize = True
        Me.PerimeterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PerimeterLabel.Location = New System.Drawing.Point(356, 284)
        Me.PerimeterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PerimeterLabel.Name = "PerimeterLabel"
        Me.PerimeterLabel.Size = New System.Drawing.Size(66, 19)
        Me.PerimeterLabel.TabIndex = 8
        Me.PerimeterLabel.Text = "        "
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(356, 400)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(112, 23)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(577, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 45)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(577, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 45)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button3.Location = New System.Drawing.Point(577, 138)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 45)
        Me.Button3.TabIndex = 12
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(547, 341)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Circle Area"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 477)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PerimeterLabel)
        Me.Controls.Add(Me.AreaLabel)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents AreaLabel As Label
    Friend WithEvents PerimeterLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
