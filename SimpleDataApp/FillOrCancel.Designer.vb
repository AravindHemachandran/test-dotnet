<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FillOrCancel
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
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFindByOrderID = New System.Windows.Forms.Button()
        Me.dtpFillDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnFillOrder = New System.Windows.Forms.Button()
        Me.btnFinishUpdates = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOrderID
        '
        Me.txtOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtOrderID.Location = New System.Drawing.Point(150, 49)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(312, 30)
        Me.txtOrderID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Id:"
        '
        'btnFindByOrderID
        '
        Me.btnFindByOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnFindByOrderID.Location = New System.Drawing.Point(621, 44)
        Me.btnFindByOrderID.Name = "btnFindByOrderID"
        Me.btnFindByOrderID.Size = New System.Drawing.Size(120, 35)
        Me.btnFindByOrderID.TabIndex = 2
        Me.btnFindByOrderID.Text = "Find Order"
        Me.btnFindByOrderID.BackColor = Color.Black
        Me.btnFindByOrderID.UseVisualStyleBackColor = True
        '
        'dtpFillDate
        '
        Me.dtpFillDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFillDate.Location = New System.Drawing.Point(588, 120)
        Me.dtpFillDate.Name = "dtpFillDate"
        Me.dtpFillDate.Size = New System.Drawing.Size(153, 30)
        Me.dtpFillDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(37, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "If filling an order, specify filled date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(42, 179)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.ReadOnly = True
        Me.dgvCustomerOrders.RowHeadersVisible = False
        Me.dgvCustomerOrders.RowHeadersWidth = 51
        Me.dgvCustomerOrders.RowTemplate.Height = 24
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(708, 178)
        Me.dgvCustomerOrders.TabIndex = 5
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCancelOrder.Location = New System.Drawing.Point(42, 382)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(149, 43)
        Me.btnCancelOrder.TabIndex = 6
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnFillOrder
        '
        Me.btnFillOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnFillOrder.Location = New System.Drawing.Point(216, 382)
        Me.btnFillOrder.Name = "btnFillOrder"
        Me.btnFillOrder.Size = New System.Drawing.Size(126, 43)
        Me.btnFillOrder.TabIndex = 7
        Me.btnFillOrder.Text = "Fill Order"
        Me.btnFillOrder.UseVisualStyleBackColor = True
        '
        'btnFinishUpdates
        '
        Me.btnFinishUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnFinishUpdates.Location = New System.Drawing.Point(617, 382)
        Me.btnFinishUpdates.Name = "btnFinishUpdates"
        Me.btnFinishUpdates.Size = New System.Drawing.Size(133, 43)
        Me.btnFinishUpdates.TabIndex = 8
        Me.btnFinishUpdates.Text = "Finish"
        Me.btnFinishUpdates.UseVisualStyleBackColor = True
        '
        'FillOrCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFinishUpdates)
        Me.Controls.Add(Me.btnFillOrder)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFillDate)
        Me.Controls.Add(Me.btnFindByOrderID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOrderID)
        Me.Name = "FillOrCancel"
        Me.Text = "FillOrCancel"
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFindByOrderID As Button
    Friend WithEvents dtpFillDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvCustomerOrders As DataGridView
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnFillOrder As Button
    Friend WithEvents btnFinishUpdates As Button
End Class
