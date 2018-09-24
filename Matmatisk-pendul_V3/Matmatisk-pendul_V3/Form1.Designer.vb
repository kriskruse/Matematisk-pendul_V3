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
        Me.components = New System.ComponentModel.Container()
        Me.btnStartExact = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStartEuler = New System.Windows.Forms.Button()
        Me.TimerExact = New System.Windows.Forms.Timer(Me.components)
        Me.TimerEuler = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTidsInverval = New System.Windows.Forms.TextBox()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtSnorlængde = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStartExact
        '
        Me.btnStartExact.Location = New System.Drawing.Point(12, 12)
        Me.btnStartExact.Name = "btnStartExact"
        Me.btnStartExact.Size = New System.Drawing.Size(92, 31)
        Me.btnStartExact.TabIndex = 0
        Me.btnStartExact.Text = "Start Exact"
        Me.btnStartExact.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(12, 86)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(92, 31)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStartEuler
        '
        Me.btnStartEuler.Location = New System.Drawing.Point(12, 49)
        Me.btnStartEuler.Name = "btnStartEuler"
        Me.btnStartEuler.Size = New System.Drawing.Size(92, 31)
        Me.btnStartEuler.TabIndex = 2
        Me.btnStartEuler.Text = "Start Euler"
        Me.btnStartEuler.UseVisualStyleBackColor = True
        '
        'TimerExact
        '
        Me.TimerExact.Interval = 1
        '
        'TimerEuler
        '
        Me.TimerEuler.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tidsinterval (msec)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Snorlængde (cm)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tyngedeacceleration (m/s^2)"
        '
        'txtTidsInverval
        '
        Me.txtTidsInverval.Location = New System.Drawing.Point(15, 162)
        Me.txtTidsInverval.Name = "txtTidsInverval"
        Me.txtTidsInverval.Size = New System.Drawing.Size(100, 22)
        Me.txtTidsInverval.TabIndex = 6
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(12, 287)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(100, 22)
        Me.txtG.TabIndex = 7
        '
        'txtSnorlængde
        '
        Me.txtSnorlængde.Location = New System.Drawing.Point(12, 225)
        Me.txtSnorlængde.Name = "txtSnorlængde"
        Me.txtSnorlængde.Size = New System.Drawing.Size(100, 22)
        Me.txtSnorlængde.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSnorlængde)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtTidsInverval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStartEuler)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStartExact)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartExact As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStartEuler As Button
    Friend WithEvents TimerExact As Timer
    Friend WithEvents TimerEuler As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTidsInverval As TextBox
    Friend WithEvents txtG As TextBox
    Friend WithEvents txtSnorlængde As TextBox
End Class
