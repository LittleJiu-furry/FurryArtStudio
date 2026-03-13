<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
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
        Me.GrpInfo = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GrpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpInfo
        '
        Me.GrpInfo.Controls.Add(Me.Button2)
        Me.GrpInfo.Controls.Add(Me.Button1)
        Me.GrpInfo.Controls.Add(Me.Label1)
        Me.GrpInfo.Location = New System.Drawing.Point(12, 12)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Size = New System.Drawing.Size(300, 380)
        Me.GrpInfo.TabIndex = 0
        Me.GrpInfo.TabStop = False
        Me.GrpInfo.Text = "基础信息"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(408, 350)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(119, 41)
        Me.BtnClose.TabIndex = 59
        Me.BtnClose.Text = "关闭(&C)"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "文件类型:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 39)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "打开(&O)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 39)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(542, 403)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrpInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InfoForm"
        Me.Text = "属性"
        Me.GrpInfo.ResumeLayout(False)
        Me.GrpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpInfo As GroupBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
