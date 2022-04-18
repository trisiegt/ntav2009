<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_motto = New System.Windows.Forms.Label()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_activate = New System.Windows.Forms.Button()
        Me.viruslist = New System.Windows.Forms.PictureBox()
        Me.btn_remove_trial = New System.Windows.Forms.Button()
        Me.activationkey = New System.Windows.Forms.TextBox()
        Me.lbl_activated = New System.Windows.Forms.Label()
        Me.btn_remove = New System.Windows.Forms.Button()
        CType(Me.viruslist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(143, 15)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Windows AntiVirus 2009"
        '
        'lbl_motto
        '
        Me.lbl_motto.AutoSize = True
        Me.lbl_motto.Font = New System.Drawing.Font("Sitka Display", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_motto.Location = New System.Drawing.Point(12, 34)
        Me.lbl_motto.Name = "lbl_motto"
        Me.lbl_motto.Size = New System.Drawing.Size(432, 42)
        Me.lbl_motto.TabIndex = 1
        Me.lbl_motto.Text = "The only AntVrus youll ever need!"
        '
        'btn_scan
        '
        Me.btn_scan.Location = New System.Drawing.Point(13, 99)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(126, 23)
        Me.btn_scan.TabIndex = 2
        Me.btn_scan.Text = "Reset activation"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'btn_activate
        '
        Me.btn_activate.Location = New System.Drawing.Point(13, 415)
        Me.btn_activate.Name = "btn_activate"
        Me.btn_activate.Size = New System.Drawing.Size(293, 23)
        Me.btn_activate.TabIndex = 3
        Me.btn_activate.Text = "Activate NOW and get ULTIMAT VRUS PROTECTIOM!"
        Me.btn_activate.UseVisualStyleBackColor = True
        '
        'viruslist
        '
        Me.viruslist.Image = Global.ntav2009.My.Resources.Resources.icon
        Me.viruslist.Location = New System.Drawing.Point(426, 99)
        Me.viruslist.Name = "viruslist"
        Me.viruslist.Size = New System.Drawing.Size(239, 135)
        Me.viruslist.TabIndex = 4
        Me.viruslist.TabStop = False
        '
        'btn_remove_trial
        '
        Me.btn_remove_trial.Location = New System.Drawing.Point(499, 294)
        Me.btn_remove_trial.Name = "btn_remove_trial"
        Me.btn_remove_trial.Size = New System.Drawing.Size(75, 23)
        Me.btn_remove_trial.TabIndex = 5
        Me.btn_remove_trial.Text = "remove"
        Me.btn_remove_trial.UseVisualStyleBackColor = True
        '
        'activationkey
        '
        Me.activationkey.Location = New System.Drawing.Point(485, 265)
        Me.activationkey.Name = "activationkey"
        Me.activationkey.Size = New System.Drawing.Size(303, 23)
        Me.activationkey.TabIndex = 6
        Me.activationkey.Visible = False
        '
        'lbl_activated
        '
        Me.lbl_activated.AutoSize = True
        Me.lbl_activated.Location = New System.Drawing.Point(18, 392)
        Me.lbl_activated.Name = "lbl_activated"
        Me.lbl_activated.Size = New System.Drawing.Size(162, 15)
        Me.lbl_activated.TabIndex = 7
        Me.lbl_activated.Text = "All AntiVrus protectiom is on!"
        Me.lbl_activated.Visible = False
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(502, 326)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(75, 23)
        Me.btn_remove.TabIndex = 8
        Me.btn_remove.Text = "remove"
        Me.btn_remove.UseVisualStyleBackColor = True
        Me.btn_remove.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.lbl_activated)
        Me.Controls.Add(Me.activationkey)
        Me.Controls.Add(Me.btn_remove_trial)
        Me.Controls.Add(Me.viruslist)
        Me.Controls.Add(Me.btn_activate)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.lbl_motto)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "Form1"
        Me.Text = "Windows AntiVirus 2009"
        CType(Me.viruslist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_motto As Label
    Friend WithEvents btn_scan As Button
    Friend WithEvents btn_activate As Button
    Friend WithEvents viruslist As PictureBox
    Friend WithEvents btn_remove_trial As Button
    Friend WithEvents activationkey As TextBox
    Friend WithEvents lbl_activated As Label
    Friend WithEvents btn_remove As Button
End Class
