﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ATextBox = New System.Windows.Forms.TextBox()
        Me.BTextBox = New System.Windows.Forms.TextBox()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.GetvaluesButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(681, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'ATextBox
        '
        Me.ATextBox.Location = New System.Drawing.Point(150, 261)
        Me.ATextBox.Name = "ATextBox"
        Me.ATextBox.Size = New System.Drawing.Size(100, 26)
        Me.ATextBox.TabIndex = 3
        '
        'BTextBox
        '
        Me.BTextBox.Location = New System.Drawing.Point(402, 261)
        Me.BTextBox.Name = "BTextBox"
        Me.BTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BTextBox.TabIndex = 4
        '
        'CTextBox
        '
        Me.CTextBox.Location = New System.Drawing.Point(662, 261)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CTextBox.TabIndex = 5
        '
        'GetvaluesButton
        '
        Me.GetvaluesButton.Location = New System.Drawing.Point(402, 383)
        Me.GetvaluesButton.Name = "GetvaluesButton"
        Me.GetvaluesButton.Size = New System.Drawing.Size(107, 56)
        Me.GetvaluesButton.TabIndex = 6
        Me.GetvaluesButton.Text = "Get Values"
        Me.GetvaluesButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(561, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 56)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Form2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 56)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Form3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GetvaluesButton)
        Me.Controls.Add(Me.CTextBox)
        Me.Controls.Add(Me.BTextBox)
        Me.Controls.Add(Me.ATextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Multiform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ATextBox As TextBox
    Friend WithEvents BTextBox As TextBox
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents GetvaluesButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
