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
        Me.btn_set_number_of_shops = New System.Windows.Forms.Button()
        Me.btn_set_number_of_Days = New System.Windows.Forms.Button()
        Me.grd_num_of_days_and_shops = New UJGrid.UJGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_registrer_egg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_set_number_of_shops
        '
        Me.btn_set_number_of_shops.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set_number_of_shops.Location = New System.Drawing.Point(13, 103)
        Me.btn_set_number_of_shops.Name = "btn_set_number_of_shops"
        Me.btn_set_number_of_shops.Size = New System.Drawing.Size(290, 71)
        Me.btn_set_number_of_shops.TabIndex = 0
        Me.btn_set_number_of_shops.Text = "Set Number Of Shops The Eggs Were Sold"
        Me.btn_set_number_of_shops.UseVisualStyleBackColor = True
        '
        'btn_set_number_of_Days
        '
        Me.btn_set_number_of_Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set_number_of_Days.Location = New System.Drawing.Point(12, 180)
        Me.btn_set_number_of_Days.Name = "btn_set_number_of_Days"
        Me.btn_set_number_of_Days.Size = New System.Drawing.Size(291, 66)
        Me.btn_set_number_of_Days.TabIndex = 1
        Me.btn_set_number_of_Days.Text = "Set Number Of Days The Eggs Were Sold"
        Me.btn_set_number_of_Days.UseVisualStyleBackColor = True
        '
        'grd_num_of_days_and_shops
        '
        Me.grd_num_of_days_and_shops.FixedCols = 1
        Me.grd_num_of_days_and_shops.FixedRows = 1
        Me.grd_num_of_days_and_shops.Location = New System.Drawing.Point(310, 105)
        Me.grd_num_of_days_and_shops.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_num_of_days_and_shops.Name = "grd_num_of_days_and_shops"
        Me.grd_num_of_days_and_shops.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grd_num_of_days_and_shops.Size = New System.Drawing.Size(1023, 628)
        Me.grd_num_of_days_and_shops.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(448, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number Of Eggs Sold In Each Shop Per Day"
        '
        'btn_registrer_egg
        '
        Me.btn_registrer_egg.BackColor = System.Drawing.Color.LightCoral
        Me.btn_registrer_egg.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrer_egg.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_registrer_egg.Location = New System.Drawing.Point(12, 253)
        Me.btn_registrer_egg.Name = "btn_registrer_egg"
        Me.btn_registrer_egg.Size = New System.Drawing.Size(291, 71)
        Me.btn_registrer_egg.TabIndex = 4
        Me.btn_registrer_egg.Text = "Register Eggs"
        Me.btn_registrer_egg.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 736)
        Me.Controls.Add(Me.btn_registrer_egg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_num_of_days_and_shops)
        Me.Controls.Add(Me.btn_set_number_of_Days)
        Me.Controls.Add(Me.btn_set_number_of_shops)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_set_number_of_shops As Button
    Friend WithEvents btn_set_number_of_Days As Button
    Friend WithEvents grd_num_of_days_and_shops As UJGrid.UJGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_registrer_egg As Button
End Class
