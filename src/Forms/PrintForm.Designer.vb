<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbPrinter = New System.Windows.Forms.ComboBox()
        Me.LblPrinter = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.txtPrintCount = New System.Windows.Forms.TextBox()
        Me.LblCopies = New System.Windows.Forms.Label()
        Me.cbPaper = New System.Windows.Forms.ComboBox()
        Me.LblPaper = New System.Windows.Forms.Label()
        Me.BtnPrinterSetup = New System.Windows.Forms.Button()
        Me.LblLayout = New System.Windows.Forms.Label()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtBottom = New System.Windows.Forms.TextBox()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.LblTop = New System.Windows.Forms.Label()
        Me.LblLeft = New System.Windows.Forms.Label()
        Me.LblBottom = New System.Windows.Forms.Label()
        Me.LblRight = New System.Windows.Forms.Label()
        Me.RbVertical = New System.Windows.Forms.RadioButton()
        Me.RbHorizonal = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cbPrinter
        '
        Me.cbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrinter.FormattingEnabled = True
        Me.cbPrinter.Location = New System.Drawing.Point(80, 6)
        Me.cbPrinter.Name = "cbPrinter"
        Me.cbPrinter.Size = New System.Drawing.Size(410, 23)
        Me.cbPrinter.TabIndex = 1
        '
        'LblPrinter
        '
        Me.LblPrinter.AutoSize = True
        Me.LblPrinter.Location = New System.Drawing.Point(8, 9)
        Me.LblPrinter.Name = "LblPrinter"
        Me.LblPrinter.Size = New System.Drawing.Size(60, 15)
        Me.LblPrinter.TabIndex = 1
        Me.LblPrinter.Text = "打印机:"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(266, 143)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(109, 49)
        Me.BtnPrint.TabIndex = 11
        Me.BtnPrint.Text = "打印(&P)"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(381, 143)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(109, 49)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "取消(&C)"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'txtPrintCount
        '
        Me.txtPrintCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrintCount.Location = New System.Drawing.Point(80, 39)
        Me.txtPrintCount.MaxLength = 2
        Me.txtPrintCount.Name = "txtPrintCount"
        Me.txtPrintCount.Size = New System.Drawing.Size(80, 25)
        Me.txtPrintCount.TabIndex = 2
        Me.txtPrintCount.Text = "1"
        '
        'LblCopies
        '
        Me.LblCopies.AutoSize = True
        Me.LblCopies.Location = New System.Drawing.Point(8, 41)
        Me.LblCopies.Name = "LblCopies"
        Me.LblCopies.Size = New System.Drawing.Size(45, 15)
        Me.LblCopies.TabIndex = 5
        Me.LblCopies.Text = "份数:"
        '
        'cbPaper
        '
        Me.cbPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaper.FormattingEnabled = True
        Me.cbPaper.Location = New System.Drawing.Point(246, 41)
        Me.cbPaper.Name = "cbPaper"
        Me.cbPaper.Size = New System.Drawing.Size(244, 23)
        Me.cbPaper.TabIndex = 3
        '
        'LblPaper
        '
        Me.LblPaper.AutoSize = True
        Me.LblPaper.Location = New System.Drawing.Point(174, 44)
        Me.LblPaper.Name = "LblPaper"
        Me.LblPaper.Size = New System.Drawing.Size(45, 15)
        Me.LblPaper.TabIndex = 7
        Me.LblPaper.Text = "纸张:"
        '
        'BtnPrinterSetup
        '
        Me.BtnPrinterSetup.Location = New System.Drawing.Point(15, 143)
        Me.BtnPrinterSetup.Name = "BtnPrinterSetup"
        Me.BtnPrinterSetup.Size = New System.Drawing.Size(141, 49)
        Me.BtnPrinterSetup.TabIndex = 10
        Me.BtnPrinterSetup.Text = "打印机管理(&M)"
        Me.BtnPrinterSetup.UseVisualStyleBackColor = True
        '
        'LblLayout
        '
        Me.LblLayout.AutoSize = True
        Me.LblLayout.Location = New System.Drawing.Point(332, 76)
        Me.LblLayout.Name = "LblLayout"
        Me.LblLayout.Size = New System.Drawing.Size(45, 15)
        Me.LblLayout.TabIndex = 10
        Me.LblLayout.Text = "布局:"
        '
        'txtTop
        '
        Me.txtTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTop.Location = New System.Drawing.Point(80, 73)
        Me.txtTop.MaxLength = 5
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(80, 25)
        Me.txtTop.TabIndex = 6
        Me.txtTop.Text = "25"
        '
        'txtBottom
        '
        Me.txtBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBottom.Location = New System.Drawing.Point(246, 73)
        Me.txtBottom.MaxLength = 5
        Me.txtBottom.Name = "txtBottom"
        Me.txtBottom.Size = New System.Drawing.Size(80, 25)
        Me.txtBottom.TabIndex = 7
        Me.txtBottom.Text = "25"
        '
        'txtLeft
        '
        Me.txtLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeft.Location = New System.Drawing.Point(80, 106)
        Me.txtLeft.MaxLength = 5
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(80, 25)
        Me.txtLeft.TabIndex = 8
        Me.txtLeft.Text = "25"
        '
        'txtRight
        '
        Me.txtRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRight.Location = New System.Drawing.Point(246, 106)
        Me.txtRight.MaxLength = 5
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(80, 25)
        Me.txtRight.TabIndex = 9
        Me.txtRight.Text = "25"
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Location = New System.Drawing.Point(8, 76)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(60, 15)
        Me.LblTop.TabIndex = 15
        Me.LblTop.Text = "上边距:"
        '
        'LblLeft
        '
        Me.LblLeft.AutoSize = True
        Me.LblLeft.Location = New System.Drawing.Point(8, 109)
        Me.LblLeft.Name = "LblLeft"
        Me.LblLeft.Size = New System.Drawing.Size(60, 15)
        Me.LblLeft.TabIndex = 16
        Me.LblLeft.Text = "左边距:"
        '
        'LblBottom
        '
        Me.LblBottom.AutoSize = True
        Me.LblBottom.Location = New System.Drawing.Point(174, 76)
        Me.LblBottom.Name = "LblBottom"
        Me.LblBottom.Size = New System.Drawing.Size(60, 15)
        Me.LblBottom.TabIndex = 17
        Me.LblBottom.Text = "下边距:"
        '
        'LblRight
        '
        Me.LblRight.AutoSize = True
        Me.LblRight.Location = New System.Drawing.Point(174, 109)
        Me.LblRight.Name = "LblRight"
        Me.LblRight.Size = New System.Drawing.Size(60, 15)
        Me.LblRight.TabIndex = 18
        Me.LblRight.Text = "右边距:"
        '
        'RbVertical
        '
        Me.RbVertical.AutoSize = True
        Me.RbVertical.Location = New System.Drawing.Point(407, 74)
        Me.RbVertical.Name = "RbVertical"
        Me.RbVertical.Size = New System.Drawing.Size(58, 19)
        Me.RbVertical.TabIndex = 4
        Me.RbVertical.Text = "纵向"
        Me.RbVertical.UseVisualStyleBackColor = True
        '
        'RbHorizonal
        '
        Me.RbHorizonal.AutoSize = True
        Me.RbHorizonal.Checked = True
        Me.RbHorizonal.Location = New System.Drawing.Point(407, 107)
        Me.RbHorizonal.Name = "RbHorizonal"
        Me.RbHorizonal.Size = New System.Drawing.Size(58, 19)
        Me.RbHorizonal.TabIndex = 5
        Me.RbHorizonal.TabStop = True
        Me.RbHorizonal.Text = "横向"
        Me.RbHorizonal.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.AcceptButton = Me.BtnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(502, 203)
        Me.Controls.Add(Me.RbHorizonal)
        Me.Controls.Add(Me.RbVertical)
        Me.Controls.Add(Me.LblRight)
        Me.Controls.Add(Me.LblBottom)
        Me.Controls.Add(Me.LblLeft)
        Me.Controls.Add(Me.LblTop)
        Me.Controls.Add(Me.txtRight)
        Me.Controls.Add(Me.txtLeft)
        Me.Controls.Add(Me.txtBottom)
        Me.Controls.Add(Me.txtTop)
        Me.Controls.Add(Me.LblLayout)
        Me.Controls.Add(Me.BtnPrinterSetup)
        Me.Controls.Add(Me.LblPaper)
        Me.Controls.Add(Me.cbPaper)
        Me.Controls.Add(Me.LblCopies)
        Me.Controls.Add(Me.txtPrintCount)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.LblPrinter)
        Me.Controls.Add(Me.cbPrinter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "打印"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPrinter As ComboBox
    Friend WithEvents LblPrinter As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents txtPrintCount As TextBox
    Friend WithEvents LblCopies As Label
    Friend WithEvents cbPaper As ComboBox
    Friend WithEvents LblPaper As Label
    Friend WithEvents BtnPrinterSetup As Button
    Friend WithEvents LblLayout As Label
    Friend WithEvents txtTop As TextBox
    Friend WithEvents txtBottom As TextBox
    Friend WithEvents txtLeft As TextBox
    Friend WithEvents txtRight As TextBox
    Friend WithEvents LblTop As Label
    Friend WithEvents LblLeft As Label
    Friend WithEvents LblBottom As Label
    Friend WithEvents LblRight As Label
    Friend WithEvents RbVertical As RadioButton
    Friend WithEvents RbHorizonal As RadioButton
End Class
