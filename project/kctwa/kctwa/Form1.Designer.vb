<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_remember = New System.Windows.Forms.CheckBox()
        Me.Button_stop = New System.Windows.Forms.Button()
        Me.Button_run = New System.Windows.Forms.Button()
        Me.TextBox_PW = New System.Windows.Forms.TextBox()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.BackGroundBrowser = New System.Windows.Forms.WebBrowser()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_n = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_option = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CycleCounter = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip_n.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox_remember)
        Me.GroupBox1.Controls.Add(Me.Button_stop)
        Me.GroupBox1.Controls.Add(Me.Button_run)
        Me.GroupBox1.Controls.Add(Me.TextBox_PW)
        Me.GroupBox1.Controls.Add(Me.TextBox_ID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CheckBox_remember
        '
        Me.CheckBox_remember.AutoSize = True
        Me.CheckBox_remember.Location = New System.Drawing.Point(108, 102)
        Me.CheckBox_remember.Name = "CheckBox_remember"
        Me.CheckBox_remember.Size = New System.Drawing.Size(97, 16)
        Me.CheckBox_remember.TabIndex = 6
        Me.CheckBox_remember.Text = "Remember me"
        Me.CheckBox_remember.UseVisualStyleBackColor = True
        '
        'Button_stop
        '
        Me.Button_stop.Enabled = False
        Me.Button_stop.Location = New System.Drawing.Point(130, 135)
        Me.Button_stop.Name = "Button_stop"
        Me.Button_stop.Size = New System.Drawing.Size(75, 23)
        Me.Button_stop.TabIndex = 5
        Me.Button_stop.Text = "stop"
        Me.Button_stop.UseVisualStyleBackColor = True
        '
        'Button_run
        '
        Me.Button_run.Location = New System.Drawing.Point(25, 135)
        Me.Button_run.Name = "Button_run"
        Me.Button_run.Size = New System.Drawing.Size(75, 23)
        Me.Button_run.TabIndex = 4
        Me.Button_run.Text = "run"
        Me.Button_run.UseVisualStyleBackColor = True
        '
        'TextBox_PW
        '
        Me.TextBox_PW.Location = New System.Drawing.Point(75, 66)
        Me.TextBox_PW.Name = "TextBox_PW"
        Me.TextBox_PW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.TextBox_PW.Size = New System.Drawing.Size(130, 19)
        Me.TextBox_PW.TabIndex = 3
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Location = New System.Drawing.Point(75, 28)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(130, 19)
        Me.TextBox_ID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PW"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Button_close
        '
        Me.Button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_close.Location = New System.Drawing.Point(166, 200)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(75, 23)
        Me.Button_close.TabIndex = 1
        Me.Button_close.Text = "close"
        Me.Button_close.UseVisualStyleBackColor = True
        '
        'BackGroundBrowser
        '
        Me.BackGroundBrowser.Location = New System.Drawing.Point(265, 12)
        Me.BackGroundBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.BackGroundBrowser.Name = "BackGroundBrowser"
        Me.BackGroundBrowser.Size = New System.Drawing.Size(116, 100)
        Me.BackGroundBrowser.TabIndex = 2
        Me.BackGroundBrowser.Visible = False
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "kctwa"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuStrip_n
        '
        Me.ContextMenuStrip_n.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_option, Me.Menu_exit})
        Me.ContextMenuStrip_n.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_n.Size = New System.Drawing.Size(99, 48)
        '
        'Menu_option
        '
        Me.Menu_option.Name = "Menu_option"
        Me.Menu_option.Size = New System.Drawing.Size(98, 22)
        Me.Menu_option.Text = "設定"
        '
        'Menu_exit
        '
        Me.Menu_exit.Name = "Menu_exit"
        Me.Menu_exit.Size = New System.Drawing.Size(98, 22)
        Me.Menu_exit.Text = "終了"
        '
        'CycleCounter
        '
        Me.CycleCounter.Interval = 5000
        '
        'Form1
        '
        Me.AcceptButton = Me.Button_run
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button_close
        Me.ClientSize = New System.Drawing.Size(253, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.BackGroundBrowser)
        Me.Controls.Add(Me.Button_close)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "kctwa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip_n.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_stop As Button
    Friend WithEvents Button_run As Button
    Friend WithEvents TextBox_PW As TextBox
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_close As Button
    Friend WithEvents BackGroundBrowser As WebBrowser
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents ContextMenuStrip_n As ContextMenuStrip
    Friend WithEvents CycleCounter As Timer
    Friend WithEvents Menu_option As ToolStripMenuItem
    Friend WithEvents Menu_exit As ToolStripMenuItem
    Friend WithEvents CheckBox_remember As CheckBox
End Class
