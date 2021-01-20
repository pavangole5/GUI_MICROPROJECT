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
        Me.components = New System.ComponentModel.Container()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnAddAnotherAccount = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnAddFinish = New System.Windows.Forms.Button()
        Me.numOrderAmount = New System.Windows.Forms.NumericUpDown()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataSet = New Sample___Data_APP.SalesDataSet()
        Me.CustomerTableAdapter = New Sample___Data_APP.SalesDataSetTableAdapters.CustomerTableAdapter()
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(243, 39)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(167, 23)
        Me.txtCustomerName.TabIndex = 0
        Me.txtCustomerName.UseWaitCursor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCustomerID.Location = New System.Drawing.Point(276, 82)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(133, 23)
        Me.txtCustomerID.TabIndex = 1
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(517, 258)
        Me.btnPlaceOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(189, 37)
        Me.btnPlaceOrder.TabIndex = 2
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnAddAnotherAccount
        '
        Me.btnAddAnotherAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAnotherAccount.Location = New System.Drawing.Point(435, 369)
        Me.btnAddAnotherAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddAnotherAccount.Name = "btnAddAnotherAccount"
        Me.btnAddAnotherAccount.Size = New System.Drawing.Size(272, 39)
        Me.btnAddAnotherAccount.TabIndex = 3
        Me.btnAddAnotherAccount.Text = "Add Another Account"
        Me.btnAddAnotherAccount.UseVisualStyleBackColor = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.Location = New System.Drawing.Point(517, 107)
        Me.btnCreateAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(189, 37)
        Me.btnCreateAccount.TabIndex = 4
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnAddFinish
        '
        Me.btnAddFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFinish.Location = New System.Drawing.Point(117, 372)
        Me.btnAddFinish.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddFinish.Name = "btnAddFinish"
        Me.btnAddFinish.Size = New System.Drawing.Size(152, 37)
        Me.btnAddFinish.TabIndex = 5
        Me.btnAddFinish.Text = "Finish"
        Me.btnAddFinish.UseVisualStyleBackColor = True
        '
        'numOrderAmount
        '
        Me.numOrderAmount.AllowDrop = True
        Me.numOrderAmount.Location = New System.Drawing.Point(241, 75)
        Me.numOrderAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.numOrderAmount.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numOrderAmount.Name = "numOrderAmount"
        Me.numOrderAmount.ReadOnly = True
        Me.numOrderAmount.Size = New System.Drawing.Size(168, 23)
        Me.numOrderAmount.TabIndex = 6
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(242, 121)
        Me.dtpOrderDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(167, 23)
        Me.dtpOrderDate.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(47, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(448, 123)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpOrderDate)
        Me.GroupBox2.Controls.Add(Me.numOrderAmount)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(47, 177)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(448, 184)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create Order"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Light LED", "Cable", "Fuse", "TV", "Remote"})
        Me.ComboBox1.Location = New System.Drawing.Point(260, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 25)
        Me.ComboBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Product:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Order Amount:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.SalesDataSet
        '
        'SalesDataSet
        '
        Me.SalesDataSet.DataSetName = "SalesDataSet"
        Me.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1009, 554)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddFinish)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.btnAddAnotherAccount)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewCustomer"
        Me.Text = "NewCustomer"
        CType(Me.numOrderAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnAddAnotherAccount As Button
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnAddFinish As Button
    Friend WithEvents numOrderAmount As NumericUpDown
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SalesDataSet As SalesDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As SalesDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
End Class
