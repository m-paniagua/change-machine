<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeMachine))
        Me.picVCM = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblStaticQuarters = New System.Windows.Forms.Label()
        Me.lblStaticDimes = New System.Windows.Forms.Label()
        Me.lblStaticNickels = New System.Windows.Forms.Label()
        Me.lblStaticPennies = New System.Windows.Forms.Label()
        Me.lblStaticDollars = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblDollars = New System.Windows.Forms.Label()
        CType(Me.picVCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picVCM
        '
        Me.picVCM.Image = CType(resources.GetObject("picVCM.Image"), System.Drawing.Image)
        Me.picVCM.Location = New System.Drawing.Point(246, 158)
        Me.picVCM.Name = "picVCM"
        Me.picVCM.Size = New System.Drawing.Size(200, 242)
        Me.picVCM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVCM.TabIndex = 0
        Me.picVCM.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.OliveDrab
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeader.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Ivory
        Me.lblHeader.Location = New System.Drawing.Point(71, 33)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(319, 32)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Virtual Change Machine"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(12, 103)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(223, 19)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Input Amount of Pennies:"
        '
        'txtPennies
        '
        Me.txtPennies.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPennies.Location = New System.Drawing.Point(252, 99)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(46, 27)
        Me.txtPennies.TabIndex = 0
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConvert.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnConvert.Location = New System.Drawing.Point(315, 99)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(131, 27)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "&Convert Pennies"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Enabled = False
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Location = New System.Drawing.Point(131, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 27)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightCyan
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Enabled = False
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Teal
        Me.btnClear.Location = New System.Drawing.Point(16, 337)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 27)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblStaticQuarters
        '
        Me.lblStaticQuarters.AutoSize = True
        Me.lblStaticQuarters.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticQuarters.Location = New System.Drawing.Point(12, 181)
        Me.lblStaticQuarters.Name = "lblStaticQuarters"
        Me.lblStaticQuarters.Size = New System.Drawing.Size(92, 19)
        Me.lblStaticQuarters.TabIndex = 7
        Me.lblStaticQuarters.Text = "Quarters: "
        '
        'lblStaticDimes
        '
        Me.lblStaticDimes.AutoSize = True
        Me.lblStaticDimes.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticDimes.Location = New System.Drawing.Point(12, 220)
        Me.lblStaticDimes.Name = "lblStaticDimes"
        Me.lblStaticDimes.Size = New System.Drawing.Size(69, 19)
        Me.lblStaticDimes.TabIndex = 8
        Me.lblStaticDimes.Text = "Dimes: "
        '
        'lblStaticNickels
        '
        Me.lblStaticNickels.AutoSize = True
        Me.lblStaticNickels.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticNickels.Location = New System.Drawing.Point(12, 259)
        Me.lblStaticNickels.Name = "lblStaticNickels"
        Me.lblStaticNickels.Size = New System.Drawing.Size(75, 19)
        Me.lblStaticNickels.TabIndex = 9
        Me.lblStaticNickels.Text = "Nickels:"
        '
        'lblStaticPennies
        '
        Me.lblStaticPennies.AutoSize = True
        Me.lblStaticPennies.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticPennies.Location = New System.Drawing.Point(12, 298)
        Me.lblStaticPennies.Name = "lblStaticPennies"
        Me.lblStaticPennies.Size = New System.Drawing.Size(84, 19)
        Me.lblStaticPennies.TabIndex = 10
        Me.lblStaticPennies.Text = "Pennies: "
        '
        'lblStaticDollars
        '
        Me.lblStaticDollars.AutoSize = True
        Me.lblStaticDollars.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticDollars.Location = New System.Drawing.Point(12, 142)
        Me.lblStaticDollars.Name = "lblStaticDollars"
        Me.lblStaticDollars.Size = New System.Drawing.Size(79, 19)
        Me.lblStaticDollars.TabIndex = 11
        Me.lblStaticDollars.Text = "Dollars: "
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(190, 181)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(0, 19)
        Me.lblQuarters.TabIndex = 12
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(190, 220)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(0, 19)
        Me.lblDimes.TabIndex = 13
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(190, 259)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(0, 19)
        Me.lblNickels.TabIndex = 14
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(190, 298)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(0, 19)
        Me.lblPennies.TabIndex = 15
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollars.Location = New System.Drawing.Point(190, 142)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(0, 19)
        Me.lblDollars.TabIndex = 16
        '
        'frmChangeMachine
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(459, 412)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblStaticDollars)
        Me.Controls.Add(Me.lblStaticPennies)
        Me.Controls.Add(Me.lblStaticNickels)
        Me.Controls.Add(Me.lblStaticDimes)
        Me.Controls.Add(Me.lblStaticQuarters)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picVCM)
        Me.Name = "frmChangeMachine"
        Me.Text = "VCM"
        CType(Me.picVCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picVCM As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents txtPennies As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblStaticQuarters As System.Windows.Forms.Label
    Friend WithEvents lblStaticDimes As System.Windows.Forms.Label
    Friend WithEvents lblStaticNickels As System.Windows.Forms.Label
    Friend WithEvents lblStaticPennies As System.Windows.Forms.Label
    Friend WithEvents lblStaticDollars As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents lblDollars As System.Windows.Forms.Label

End Class
