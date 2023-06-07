<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btn_start = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_finish = New System.Windows.Forms.Button()
        Me.Btn_pause = New System.Windows.Forms.Button()
        Me.Btn_Re = New System.Windows.Forms.Button()
        Me.Btn_to_0 = New System.Windows.Forms.Button()
        Me.Ho = New System.Windows.Forms.Label()
        Me.Mi = New System.Windows.Forms.Label()
        Me.Se = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(36, 465)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(175, 55)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "开始"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton5, Me.ToolStripSeparator5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1178, 37)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(121, 34)
        Me.ToolStripButton1.Text = "设置时间"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(121, 34)
        Me.ToolStripButton2.Text = "时间归零"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(191, 34)
        Me.ToolStripButton3.Text = "30秒快速倒计时"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(200, 34)
        Me.ToolStripButton4.Text = "1分钟快速倒计时"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(200, 34)
        Me.ToolStripButton5.Text = "2分钟快速倒计时"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 37)
        '
        'Btn_finish
        '
        Me.Btn_finish.Location = New System.Drawing.Point(970, 465)
        Me.Btn_finish.Name = "Btn_finish"
        Me.Btn_finish.Size = New System.Drawing.Size(175, 55)
        Me.Btn_finish.TabIndex = 2
        Me.Btn_finish.Text = "停止"
        Me.Btn_finish.UseVisualStyleBackColor = True
        '
        'Btn_pause
        '
        Me.Btn_pause.Location = New System.Drawing.Point(275, 465)
        Me.Btn_pause.Name = "Btn_pause"
        Me.Btn_pause.Size = New System.Drawing.Size(175, 55)
        Me.Btn_pause.TabIndex = 3
        Me.Btn_pause.Text = "暂停"
        Me.Btn_pause.UseVisualStyleBackColor = True
        '
        'Btn_Re
        '
        Me.Btn_Re.Location = New System.Drawing.Point(509, 465)
        Me.Btn_Re.Name = "Btn_Re"
        Me.Btn_Re.Size = New System.Drawing.Size(175, 55)
        Me.Btn_Re.TabIndex = 4
        Me.Btn_Re.Text = "复位"
        Me.Btn_Re.UseVisualStyleBackColor = True
        '
        'Btn_to_0
        '
        Me.Btn_to_0.Location = New System.Drawing.Point(741, 465)
        Me.Btn_to_0.Name = "Btn_to_0"
        Me.Btn_to_0.Size = New System.Drawing.Size(175, 55)
        Me.Btn_to_0.TabIndex = 5
        Me.Btn_to_0.Text = "归零"
        Me.Btn_to_0.UseVisualStyleBackColor = True
        '
        'Ho
        '
        Me.Ho.AutoSize = True
        Me.Ho.Font = New System.Drawing.Font("Arial", 100.0!)
        Me.Ho.Location = New System.Drawing.Point(46, 142)
        Me.Ho.Name = "Ho"
        Me.Ho.Size = New System.Drawing.Size(316, 223)
        Me.Ho.TabIndex = 6
        Me.Ho.Text = "00"
        '
        'Mi
        '
        Me.Mi.AutoSize = True
        Me.Mi.Font = New System.Drawing.Font("Arial", 100.0!)
        Me.Mi.Location = New System.Drawing.Point(433, 142)
        Me.Mi.Name = "Mi"
        Me.Mi.Size = New System.Drawing.Size(316, 223)
        Me.Mi.TabIndex = 7
        Me.Mi.Text = "00"
        '
        'Se
        '
        Me.Se.AutoSize = True
        Me.Se.Font = New System.Drawing.Font("Arial", 100.0!)
        Me.Se.Location = New System.Drawing.Point(814, 142)
        Me.Se.Name = "Se"
        Me.Se.Size = New System.Drawing.Size(316, 223)
        Me.Se.TabIndex = 8
        Me.Se.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 100.0!)
        Me.Label1.Location = New System.Drawing.Point(318, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 223)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 100.0!)
        Me.Label2.Location = New System.Drawing.Point(703, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 223)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = ":"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("黑体", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(372, 50)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "倒计时还剩余："
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(277, 34)
        Me.ToolStripButton6.Text = "源代码：沈文轩 于GitHub开源"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1178, 544)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Se)
        Me.Controls.Add(Me.Mi)
        Me.Controls.Add(Me.Ho)
        Me.Controls.Add(Me.Btn_to_0)
        Me.Controls.Add(Me.Btn_Re)
        Me.Controls.Add(Me.Btn_pause)
        Me.Controls.Add(Me.Btn_finish)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_start)
        Me.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "倒计时软件"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Btn_finish As System.Windows.Forms.Button
    Friend WithEvents Btn_pause As System.Windows.Forms.Button
    Friend WithEvents Btn_Re As System.Windows.Forms.Button
    Friend WithEvents Btn_to_0 As System.Windows.Forms.Button
    Friend WithEvents Ho As System.Windows.Forms.Label
    Friend WithEvents Mi As System.Windows.Forms.Label
    Friend WithEvents Se As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton

End Class
