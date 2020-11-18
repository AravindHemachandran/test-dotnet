<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigation
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
        Me.btnGoToAdd = New System.Windows.Forms.Button()
        Me.btnGoToFillOrCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGoToAdd
        '
        Me.btnGoToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToAdd.Location = New System.Drawing.Point(124, 144)
        Me.btnGoToAdd.Name = "btnGoToAdd"
        Me.btnGoToAdd.Size = New System.Drawing.Size(139, 68)
        Me.btnGoToAdd.TabIndex = 0
        Me.btnGoToAdd.Text = "Add an Account"
        Me.btnGoToAdd.UseVisualStyleBackColor = True
        '
        'btnGoToFillOrCancel
        '
        Me.btnGoToFillOrCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToFillOrCancel.Location = New System.Drawing.Point(124, 268)
        Me.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel"
        Me.btnGoToFillOrCancel.Size = New System.Drawing.Size(139, 62)
        Me.btnGoToFillOrCancel.TabIndex = 1
        Me.btnGoToFillOrCancel.Text = "Fill or Cancel an Order"
        Me.btnGoToFillOrCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(633, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(66, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "What do you want to do?"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGoToFillOrCancel)
        Me.Controls.Add(Me.btnGoToAdd)
        Me.Name = "Navigation"
        Me.Text = "Navigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoToAdd As Button
    Friend WithEvents btnGoToFillOrCancel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents TextBox1 As TextBox
End Class
