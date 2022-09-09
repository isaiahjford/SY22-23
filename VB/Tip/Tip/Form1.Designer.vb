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
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.GrandtotalLabel = New System.Windows.Forms.Label()
        Me.TipTextBox = New System.Windows.Forms.TextBox()
        Me.tipLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(325, 210)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(173, 42)
        Me.CalcButton.TabIndex = 0
        Me.CalcButton.Text = "Calculate total"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(358, 284)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox.TabIndex = 1
        '
        'GrandtotalLabel
        '
        Me.GrandtotalLabel.AutoSize = True
        Me.GrandtotalLabel.Location = New System.Drawing.Point(371, 331)
        Me.GrandtotalLabel.Name = "GrandtotalLabel"
        Me.GrandtotalLabel.Size = New System.Drawing.Size(72, 16)
        Me.GrandtotalLabel.TabIndex = 2
        Me.GrandtotalLabel.Text = "Grand total"
        '
        'TipTextBox
        '
        Me.TipTextBox.Location = New System.Drawing.Point(151, 284)
        Me.TipTextBox.Name = "TipTextBox"
        Me.TipTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TipTextBox.TabIndex = 3
        '
        'tipLabel
        '
        Me.tipLabel.AutoSize = True
        Me.tipLabel.Location = New System.Drawing.Point(184, 256)
        Me.tipLabel.Name = "tipLabel"
        Me.tipLabel.Size = New System.Drawing.Size(27, 16)
        Me.tipLabel.TabIndex = 4
        Me.tipLabel.Text = "Tip"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Tip.My.Resources.Resources.download__10_
        Me.PictureBox2.Image = Global.Tip.My.Resources.Resources.images
        Me.PictureBox2.Location = New System.Drawing.Point(271, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(276, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Tip.My.Resources.Resources.download__7_
        Me.PictureBox1.Location = New System.Drawing.Point(548, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tipLabel)
        Me.Controls.Add(Me.TipTextBox)
        Me.Controls.Add(Me.GrandtotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.CalcButton)
        Me.Name = "Form1"
        Me.Text = "Tip"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalcButton As Button
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents GrandtotalLabel As Label
    Friend WithEvents TipTextBox As TextBox
    Friend WithEvents tipLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
