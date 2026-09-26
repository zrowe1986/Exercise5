<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTitle = New Label()
        lblLength = New Label()
        lblWidth = New Label()
        txtLength = New TextBox()
        txtWidth = New TextBox()
        lblVolume = New Label()
        lblCost = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnQuit = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(54, 39)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(870, 86)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Driveway Concrete Calculator"
        ' 
        ' lblLength
        ' 
        lblLength.AutoSize = True
        lblLength.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLength.Location = New Point(80, 187)
        lblLength.Name = "lblLength"
        lblLength.Size = New Size(317, 48)
        lblLength.TabIndex = 1
        lblLength.Text = "Enter Length (ft)"
        ' 
        ' lblWidth
        ' 
        lblWidth.AutoSize = True
        lblWidth.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWidth.Location = New Point(80, 287)
        lblWidth.Name = "lblWidth"
        lblWidth.Size = New Size(304, 48)
        lblWidth.TabIndex = 2
        lblWidth.Text = "Enter Width (ft)"
        ' 
        ' txtLength
        ' 
        txtLength.Location = New Point(595, 180)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(300, 55)
        txtLength.TabIndex = 3
        ' 
        ' txtWidth
        ' 
        txtWidth.Location = New Point(595, 280)
        txtWidth.Name = "txtWidth"
        txtWidth.Size = New Size(300, 55)
        txtWidth.TabIndex = 4
        ' 
        ' lblVolume
        ' 
        lblVolume.AutoSize = True
        lblVolume.BackColor = SystemColors.Info
        lblVolume.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVolume.Location = New Point(80, 442)
        lblVolume.Name = "lblVolume"
        lblVolume.Size = New Size(751, 65)
        lblVolume.TabIndex = 5
        lblVolume.Text = "Volume: 0.00 cu ft / 0.00 cu yd"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.BackColor = SystemColors.Info
        lblCost.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCost.Location = New Point(80, 560)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(290, 65)
        lblCost.TabIndex = 6
        lblCost.Text = "Cost: $0.00"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.Highlight
        btnCalculate.ForeColor = SystemColors.ButtonHighlight
        btnCalculate.Location = New Point(75, 775)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(398, 149)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Highlight
        btnClear.ForeColor = SystemColors.ButtonHighlight
        btnClear.Location = New Point(526, 775)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(398, 149)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear Values"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnQuit
        ' 
        btnQuit.BackColor = SystemColors.Highlight
        btnQuit.ForeColor = SystemColors.ButtonHighlight
        btnQuit.Location = New Point(978, 775)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(398, 149)
        btnQuit.TabIndex = 9
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(20F, 48F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(1462, 1004)
        Controls.Add(btnQuit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(lblCost)
        Controls.Add(lblVolume)
        Controls.Add(txtWidth)
        Controls.Add(txtLength)
        Controls.Add(lblWidth)
        Controls.Add(lblLength)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Driveway Concrete Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lblVolume As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button

End Class
