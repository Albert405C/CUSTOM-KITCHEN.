<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcustomerdetails
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
        Me.lblemail = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txthousenumber = New System.Windows.Forms.TextBox()
        Me.txtcreditcardinformation = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.btngeneratereceipt = New System.Windows.Forms.Button()
        Me.Txtstreetname = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtpostalcode = New System.Windows.Forms.TextBox()
        Me.lblpostalcode = New System.Windows.Forms.Label()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lbkstreetname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(437, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HOUSE NUMBER"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(119, 137)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(63, 21)
        Me.lblemail.TabIndex = 2
        Me.lblemail.Text = "E-MAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CREDIT CARD INFORMATION"
        '
        'txthousenumber
        '
        Me.txthousenumber.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txthousenumber.Location = New System.Drawing.Point(344, 15)
        Me.txthousenumber.Margin = New System.Windows.Forms.Padding(6)
        Me.txthousenumber.Name = "txthousenumber"
        Me.txthousenumber.Size = New System.Drawing.Size(298, 33)
        Me.txthousenumber.TabIndex = 5
        '
        'txtcreditcardinformation
        '
        Me.txtcreditcardinformation.Location = New System.Drawing.Point(344, 89)
        Me.txtcreditcardinformation.Margin = New System.Windows.Forms.Padding(6)
        Me.txtcreditcardinformation.Name = "txtcreditcardinformation"
        Me.txtcreditcardinformation.Size = New System.Drawing.Size(298, 33)
        Me.txtcreditcardinformation.TabIndex = 7
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(15, 15)
        Me.txtname.Margin = New System.Windows.Forms.Padding(6)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(297, 33)
        Me.txtname.TabIndex = 8
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(15, 89)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(6)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(297, 33)
        Me.txtemail.TabIndex = 9
        '
        'btngeneratereceipt
        '
        Me.btngeneratereceipt.Location = New System.Drawing.Point(414, 258)
        Me.btngeneratereceipt.Name = "btngeneratereceipt"
        Me.btngeneratereceipt.Size = New System.Drawing.Size(155, 67)
        Me.btngeneratereceipt.TabIndex = 10
        Me.btngeneratereceipt.Text = "Generate Receipt"
        Me.btngeneratereceipt.UseVisualStyleBackColor = True
        '
        'Txtstreetname
        '
        Me.Txtstreetname.Location = New System.Drawing.Point(15, 169)
        Me.Txtstreetname.Margin = New System.Windows.Forms.Padding(6)
        Me.Txtstreetname.Name = "Txtstreetname"
        Me.Txtstreetname.Size = New System.Drawing.Size(297, 33)
        Me.Txtstreetname.TabIndex = 11
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(344, 169)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(6)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(297, 33)
        Me.txtcity.TabIndex = 12
        '
        'txtpostalcode
        '
        Me.txtpostalcode.Location = New System.Drawing.Point(15, 243)
        Me.txtpostalcode.Margin = New System.Windows.Forms.Padding(6)
        Me.txtpostalcode.Name = "txtpostalcode"
        Me.txtpostalcode.Size = New System.Drawing.Size(297, 33)
        Me.txtpostalcode.TabIndex = 13
        '
        'lblpostalcode
        '
        Me.lblpostalcode.AutoSize = True
        Me.lblpostalcode.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpostalcode.Location = New System.Drawing.Point(95, 282)
        Me.lblpostalcode.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblpostalcode.Name = "lblpostalcode"
        Me.lblpostalcode.Size = New System.Drawing.Size(112, 21)
        Me.lblpostalcode.TabIndex = 15
        Me.lblpostalcode.Text = "POSTAL CODE"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.Location = New System.Drawing.Point(456, 208)
        Me.lblcity.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(98, 21)
        Me.lblcity.TabIndex = 16
        Me.lblcity.Text = "TOWN/CITY"
        '
        'lbkstreetname
        '
        Me.lbkstreetname.AutoSize = True
        Me.lbkstreetname.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkstreetname.Location = New System.Drawing.Point(95, 208)
        Me.lbkstreetname.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbkstreetname.Name = "lbkstreetname"
        Me.lbkstreetname.Size = New System.Drawing.Size(113, 21)
        Me.lbkstreetname.TabIndex = 18
        Me.lbkstreetname.Text = "STREET NAME"
        '
        'Frmcustomerdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(657, 355)
        Me.Controls.Add(Me.lbkstreetname)
        Me.Controls.Add(Me.lblcity)
        Me.Controls.Add(Me.lblpostalcode)
        Me.Controls.Add(Me.txtpostalcode)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.Txtstreetname)
        Me.Controls.Add(Me.btngeneratereceipt)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtcreditcardinformation)
        Me.Controls.Add(Me.txthousenumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Frmcustomerdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmcustomerdetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txthousenumber As System.Windows.Forms.TextBox
    Friend WithEvents txtcreditcardinformation As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents btngeneratereceipt As System.Windows.Forms.Button
    Friend WithEvents Txtstreetname As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtpostalcode As System.Windows.Forms.TextBox
    Friend WithEvents lblpostalcode As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lbkstreetname As System.Windows.Forms.Label
End Class
