<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.btnAddanother = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnfillorcancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddanother
        '
        Me.btnAddanother.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddanother.Location = New System.Drawing.Point(286, 150)
        Me.btnAddanother.Name = "btnAddanother"
        Me.btnAddanother.Size = New System.Drawing.Size(204, 42)
        Me.btnAddanother.TabIndex = 0
        Me.btnAddanother.Text = "Add an Account"
        Me.btnAddanother.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What do you want?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(516, 330)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(118, 36)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnfillorcancel
        '
        Me.btnfillorcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfillorcancel.Location = New System.Drawing.Point(259, 210)
        Me.btnfillorcancel.Name = "btnfillorcancel"
        Me.btnfillorcancel.Size = New System.Drawing.Size(257, 41)
        Me.btnfillorcancel.TabIndex = 3
        Me.btnfillorcancel.Text = "Fill or cancel an order"
        Me.btnfillorcancel.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnfillorcancel)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddanother)
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddanother As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents btnfillorcancel As Button
End Class
