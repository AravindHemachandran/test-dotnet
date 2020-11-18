<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numOrderAmount = New System.Windows.Forms.NumericUpDown()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnAddFinish = New System.Windows.Forms.Button()
        Me.btnAddAnotherAccount = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Account"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(147, 45)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(171, 22)
        Me.txtCustomerName.TabIndex = 0
        Me.txtCustomerName.Tag = ""
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(147, 108)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(171, 22)
        Me.txtCustomerID.TabIndex = 1
        Me.txtCustomerID.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpOrderDate)
        Me.GroupBox2.Controls.Add(Me.numOrderAmount)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 152)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Order Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Order Amount"
        '
        'numOrderAmount
        '
        Me.numOrderAmount.Location = New System.Drawing.Point(147, 48)
        Me.numOrderAmount.Name = "numOrderAmount"
        Me.numOrderAmount.Size = New System.Drawing.Size(171, 22)
        Me.numOrderAmount.TabIndex = 2
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Location = New System.Drawing.Point(147, 111)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(171, 22)
        Me.dtpOrderDate.TabIndex = 4
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCreateAccount.Location = New System.Drawing.Point(503, 116)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(132, 48)
        Me.btnCreateAccount.TabIndex = 2
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnPlaceOrder.Location = New System.Drawing.Point(503, 305)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(132, 39)
        Me.btnPlaceOrder.TabIndex = 3
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnAddFinish
        '
        Me.btnAddFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAddFinish.Location = New System.Drawing.Point(51, 386)
        Me.btnAddFinish.Name = "btnAddFinish"
        Me.btnAddFinish.Size = New System.Drawing.Size(130, 36)
        Me.btnAddFinish.TabIndex = 4
        Me.btnAddFinish.Text = "Finish"
        Me.btnAddFinish.UseVisualStyleBackColor = True
        '
        'btnAddAnotherAccount
        '
        Me.btnAddAnotherAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAddAnotherAccount.Location = New System.Drawing.Point(503, 386)
        Me.btnAddAnotherAccount.Name = "btnAddAnotherAccount"
        Me.btnAddAnotherAccount.Size = New System.Drawing.Size(179, 36)
        Me.btnAddAnotherAccount.TabIndex = 5
        Me.btnAddAnotherAccount.Text = "Add Another Account"
        Me.btnAddAnotherAccount.UseVisualStyleBackColor = True
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddAnotherAccount)
        Me.Controls.Add(Me.btnAddFinish)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewCustomer"
        Me.Text = "NewCustomer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents numOrderAmount As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnAddFinish As Button
    Friend WithEvents btnAddAnotherAccount As Button
End Class
