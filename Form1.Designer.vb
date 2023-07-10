<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmainform
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
        Me.txtmaximumbudget = New System.Windows.Forms.TextBox()
        Me.txtwidth = New System.Windows.Forms.TextBox()
        Me.txtlength = New System.Windows.Forms.TextBox()
        Me.btnenterspecifications = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lblcustominstallation = New System.Windows.Forms.Label()
        Me.lblfinalcost = New System.Windows.Forms.Label()
        Me.btnpurchase = New System.Windows.Forms.Button()
        Me.btnselectkitchen = New System.Windows.Forms.Button()
        Me.cbxKitchendesignstyles = New System.Windows.Forms.ComboBox()
        Me.cbxoptionalkitchenappliances = New System.Windows.Forms.ComboBox()
        Me.Ccbcustominstallation = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LENGTH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "WIDTH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(366, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BUDGET(€,)"
        '
        'txtmaximumbudget
        '
        Me.txtmaximumbudget.Location = New System.Drawing.Point(192, 24)
        Me.txtmaximumbudget.Name = "txtmaximumbudget"
        Me.txtmaximumbudget.Size = New System.Drawing.Size(168, 20)
        Me.txtmaximumbudget.TabIndex = 3
        '
        'txtwidth
        '
        Me.txtwidth.Location = New System.Drawing.Point(6, 71)
        Me.txtwidth.Name = "txtwidth"
        Me.txtwidth.Size = New System.Drawing.Size(168, 20)
        Me.txtwidth.TabIndex = 4
        '
        'txtlength
        '
        Me.txtlength.Location = New System.Drawing.Point(6, 24)
        Me.txtlength.Name = "txtlength"
        Me.txtlength.Size = New System.Drawing.Size(168, 20)
        Me.txtlength.TabIndex = 5
        '
        'btnenterspecifications
        '
        Me.btnenterspecifications.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnenterspecifications.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnenterspecifications.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenterspecifications.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnenterspecifications.Location = New System.Drawing.Point(192, 94)
        Me.btnenterspecifications.Name = "btnenterspecifications"
        Me.btnenterspecifications.Size = New System.Drawing.Size(168, 59)
        Me.btnenterspecifications.TabIndex = 6
        Me.btnenterspecifications.Text = "Enter Specifications"
        Me.btnenterspecifications.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Lblcustominstallation)
        Me.Panel1.Controls.Add(Me.lblfinalcost)
        Me.Panel1.Controls.Add(Me.btnpurchase)
        Me.Panel1.Controls.Add(Me.btnselectkitchen)
        Me.Panel1.Controls.Add(Me.cbxKitchendesignstyles)
        Me.Panel1.Controls.Add(Me.cbxoptionalkitchenappliances)
        Me.Panel1.Controls.Add(Me.Ccbcustominstallation)
        Me.Panel1.Location = New System.Drawing.Point(16, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 234)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'Lblcustominstallation
        '
        Me.Lblcustominstallation.AutoSize = True
        Me.Lblcustominstallation.Location = New System.Drawing.Point(16, 76)
        Me.Lblcustominstallation.Name = "Lblcustominstallation"
        Me.Lblcustominstallation.Size = New System.Drawing.Size(19, 13)
        Me.Lblcustominstallation.TabIndex = 7
        Me.Lblcustominstallation.Text = "00"
        '
        'lblfinalcost
        '
        Me.lblfinalcost.AutoSize = True
        Me.lblfinalcost.Location = New System.Drawing.Point(399, 75)
        Me.lblfinalcost.Name = "lblfinalcost"
        Me.lblfinalcost.Size = New System.Drawing.Size(19, 13)
        Me.lblfinalcost.TabIndex = 6
        Me.lblfinalcost.Text = "00"
        '
        'btnpurchase
        '
        Me.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpurchase.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurchase.Location = New System.Drawing.Point(465, 178)
        Me.btnpurchase.Name = "btnpurchase"
        Me.btnpurchase.Size = New System.Drawing.Size(116, 39)
        Me.btnpurchase.TabIndex = 5
        Me.btnpurchase.Text = "Purchase"
        Me.btnpurchase.UseVisualStyleBackColor = True
        '
        'btnselectkitchen
        '
        Me.btnselectkitchen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnselectkitchen.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectkitchen.Location = New System.Drawing.Point(16, 113)
        Me.btnselectkitchen.Name = "btnselectkitchen"
        Me.btnselectkitchen.Size = New System.Drawing.Size(149, 33)
        Me.btnselectkitchen.TabIndex = 3
        Me.btnselectkitchen.Text = "Select Kitchen"
        Me.btnselectkitchen.UseVisualStyleBackColor = True
        '
        'cbxKitchendesignstyles
        '
        Me.cbxKitchendesignstyles.FormattingEnabled = True
        Me.cbxKitchendesignstyles.Location = New System.Drawing.Point(16, 17)
        Me.cbxKitchendesignstyles.Name = "cbxKitchendesignstyles"
        Me.cbxKitchendesignstyles.Size = New System.Drawing.Size(344, 21)
        Me.cbxKitchendesignstyles.TabIndex = 2
        '
        'cbxoptionalkitchenappliances
        '
        Me.cbxoptionalkitchenappliances.FormattingEnabled = True
        Me.cbxoptionalkitchenappliances.Location = New System.Drawing.Point(382, 17)
        Me.cbxoptionalkitchenappliances.Name = "cbxoptionalkitchenappliances"
        Me.cbxoptionalkitchenappliances.Size = New System.Drawing.Size(208, 21)
        Me.cbxoptionalkitchenappliances.TabIndex = 1
        '
        'Ccbcustominstallation
        '
        Me.Ccbcustominstallation.AutoSize = True
        Me.Ccbcustominstallation.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Ccbcustominstallation.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ccbcustominstallation.Location = New System.Drawing.Point(16, 44)
        Me.Ccbcustominstallation.Name = "Ccbcustominstallation"
        Me.Ccbcustominstallation.Size = New System.Drawing.Size(217, 25)
        Me.Ccbcustominstallation.TabIndex = 0
        Me.Ccbcustominstallation.Text = "CUSTOM INSTALLATIONS"
        Me.Ccbcustominstallation.UseVisualStyleBackColor = False
        '
        'frmmainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(644, 454)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnenterspecifications)
        Me.Controls.Add(Me.txtlength)
        Me.Controls.Add(Me.txtwidth)
        Me.Controls.Add(Me.txtmaximumbudget)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Specifications"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmaximumbudget As System.Windows.Forms.TextBox
    Friend WithEvents txtwidth As System.Windows.Forms.TextBox
    Friend WithEvents txtlength As System.Windows.Forms.TextBox
    Friend WithEvents btnenterspecifications As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnpurchase As System.Windows.Forms.Button
    Friend WithEvents cbxKitchendesignstyles As System.Windows.Forms.ComboBox
    Friend WithEvents cbxoptionalkitchenappliances As System.Windows.Forms.ComboBox
    Friend WithEvents Ccbcustominstallation As System.Windows.Forms.CheckBox
    Friend WithEvents btnselectkitchen As System.Windows.Forms.Button
    Friend WithEvents lblfinalcost As System.Windows.Forms.Label
    Friend WithEvents Lblcustominstallation As System.Windows.Forms.Label

End Class
