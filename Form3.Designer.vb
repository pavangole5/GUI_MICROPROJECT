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
        Me.btnFindByOrderID = New System.Windows.Forms.Button()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFillDate = New System.Windows.Forms.DateTimePicker()
        Me.btnFinishUpdates = New System.Windows.Forms.Button()
        Me.btnFillOrder = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFindByOrderID
        '
        Me.btnFindByOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindByOrderID.Location = New System.Drawing.Point(436, 59)
        Me.btnFindByOrderID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFindByOrderID.Name = "btnFindByOrderID"
        Me.btnFindByOrderID.Size = New System.Drawing.Size(197, 41)
        Me.btnFindByOrderID.TabIndex = 0
        Me.btnFindByOrderID.Text = "Find Order"
        Me.btnFindByOrderID.UseVisualStyleBackColor = True
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(225, 65)
        Me.txtOrderID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOrderID.Multiline = True
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(172, 27)
        Me.txtOrderID.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Order ID:"
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvCustomerOrders.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(97, 234)
        Me.dgvCustomerOrders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.ReadOnly = True
        Me.dgvCustomerOrders.RowHeadersVisible = False
        Me.dgvCustomerOrders.RowHeadersWidth = 51
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(559, 110)
        Me.dgvCustomerOrders.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "If filling an order, specify filled date"
        '
        'dtpFillDate
        '
        Me.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFillDate.Location = New System.Drawing.Point(459, 154)
        Me.dtpFillDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFillDate.Name = "dtpFillDate"
        Me.dtpFillDate.Size = New System.Drawing.Size(136, 22)
        Me.dtpFillDate.TabIndex = 8
        '
        'btnFinishUpdates
        '
        Me.btnFinishUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishUpdates.Location = New System.Drawing.Point(505, 382)
        Me.btnFinishUpdates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFinishUpdates.Name = "btnFinishUpdates"
        Me.btnFinishUpdates.Size = New System.Drawing.Size(151, 41)
        Me.btnFinishUpdates.TabIndex = 9
        Me.btnFinishUpdates.Text = "Finish"
        Me.btnFinishUpdates.UseVisualStyleBackColor = True
        '
        'btnFillOrder
        '
        Me.btnFillOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillOrder.Location = New System.Drawing.Point(280, 382)
        Me.btnFillOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFillOrder.Name = "btnFillOrder"
        Me.btnFillOrder.Size = New System.Drawing.Size(147, 41)
        Me.btnFillOrder.TabIndex = 10
        Me.btnFillOrder.Text = "Fill Order"
        Me.btnFillOrder.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelOrder.Location = New System.Drawing.Point(97, 382)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(175, 41)
        Me.btnCancelOrder.TabIndex = 11
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'FillOrCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.btnFillOrder)
        Me.Controls.Add(Me.btnFinishUpdates)
        Me.Controls.Add(Me.dtpFillDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.btnFindByOrderID)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FillOrCancel"
        Me.Text = "FillOrCancel"
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFindByOrderID As Button
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCustomerOrders As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFillDate As DateTimePicker
    Friend WithEvents btnFinishUpdates As Button
    Friend WithEvents btnFillOrder As Button
    Friend WithEvents btnCancelOrder As Button
End Class
