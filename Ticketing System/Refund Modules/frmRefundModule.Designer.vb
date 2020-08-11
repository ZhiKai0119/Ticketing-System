<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRefund))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lstTicket = New System.Windows.Forms.ListBox()
        Me.lblTotalRefund = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOthers = New System.Windows.Forms.RadioButton()
        Me.radSomethinngToDo = New System.Windows.Forms.RadioButton()
        Me.radWrongMovie = New System.Windows.Forms.RadioButton()
        Me.radWrongTime = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstRefundHistory = New System.Windows.Forms.ListBox()
        Me.txtCustomerId2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnChangeInfo = New System.Windows.Forms.Button()
        Me.lstRefundHistory2 = New System.Windows.Forms.ListBox()
        Me.txtCustomerId3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtCustomerId4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstRedfundHistory3 = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Customer ID:"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(150, 48)
        Me.txtCustomerId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(194, 27)
        Me.txtCustomerId.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(13, 349)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 412)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.lblTime)
        Me.TabPage1.Controls.Add(Me.lblDate)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.label5)
        Me.TabPage1.Controls.Add(Me.btnConfirm)
        Me.TabPage1.Controls.Add(Me.lstTicket)
        Me.TabPage1.Controls.Add(Me.lblTotalRefund)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txtCustomerId)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(966, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cancel Ticket"
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(732, 65)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(87, 20)
        Me.lblTime.TabIndex = 12
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(732, 31)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(87, 20)
        Me.lblDate.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(644, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Time:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(645, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date:"
        '
        'label5
        '
        Me.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label5.Location = New System.Drawing.Point(620, 20)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(327, 75)
        Me.label5.TabIndex = 8
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(776, 336)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(171, 31)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "Confirm &Refund"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lstTicket
        '
        Me.lstTicket.FormattingEnabled = True
        Me.lstTicket.ItemHeight = 20
        Me.lstTicket.Location = New System.Drawing.Point(620, 109)
        Me.lstTicket.Name = "lstTicket"
        Me.lstTicket.Size = New System.Drawing.Size(327, 204)
        Me.lstTicket.TabIndex = 6
        '
        'lblTotalRefund
        '
        Me.lblTotalRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalRefund.Location = New System.Drawing.Point(148, 340)
        Me.lblTotalRefund.Name = "lblTotalRefund"
        Me.lblTotalRefund.Size = New System.Drawing.Size(155, 28)
        Me.lblTotalRefund.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Refund:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOthers)
        Me.GroupBox1.Controls.Add(Me.radSomethinngToDo)
        Me.GroupBox1.Controls.Add(Me.radWrongMovie)
        Me.GroupBox1.Controls.Add(Me.radWrongTime)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(557, 218)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Why You Want To Refund?"
        '
        'radOthers
        '
        Me.radOthers.AutoSize = True
        Me.radOthers.Location = New System.Drawing.Point(20, 183)
        Me.radOthers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radOthers.Name = "radOthers"
        Me.radOthers.Size = New System.Drawing.Size(81, 24)
        Me.radOthers.TabIndex = 3
        Me.radOthers.TabStop = True
        Me.radOthers.Text = "Others"
        Me.radOthers.UseVisualStyleBackColor = True
        '
        'radSomethinngToDo
        '
        Me.radSomethinngToDo.AutoSize = True
        Me.radSomethinngToDo.Location = New System.Drawing.Point(20, 138)
        Me.radSomethinngToDo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radSomethinngToDo.Name = "radSomethinngToDo"
        Me.radSomethinngToDo.Size = New System.Drawing.Size(306, 24)
        Me.radSomethinngToDo.TabIndex = 2
        Me.radSomethinngToDo.TabStop = True
        Me.radSomethinngToDo.Text = "There is something to do on that day."
        Me.radSomethinngToDo.UseVisualStyleBackColor = True
        '
        'radWrongMovie
        '
        Me.radWrongMovie.AutoSize = True
        Me.radWrongMovie.Location = New System.Drawing.Point(20, 87)
        Me.radWrongMovie.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radWrongMovie.Name = "radWrongMovie"
        Me.radWrongMovie.Size = New System.Drawing.Size(351, 24)
        Me.radWrongMovie.TabIndex = 1
        Me.radWrongMovie.TabStop = True
        Me.radWrongMovie.Text = "Accidentally bought the wrong movie ticket."
        Me.radWrongMovie.UseVisualStyleBackColor = True
        '
        'radWrongTime
        '
        Me.radWrongTime.AutoSize = True
        Me.radWrongTime.Location = New System.Drawing.Point(20, 38)
        Me.radWrongTime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radWrongTime.Name = "radWrongTime"
        Me.radWrongTime.Size = New System.Drawing.Size(339, 24)
        Me.radWrongTime.TabIndex = 0
        Me.radWrongTime.TabStop = True
        Me.radWrongTime.Text = "Accidentally bought the wrong ticket time."
        Me.radWrongTime.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstRefundHistory)
        Me.TabPage2.Controls.Add(Me.txtCustomerId2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Size = New System.Drawing.Size(966, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Refund History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstRefundHistory
        '
        Me.lstRefundHistory.FormattingEnabled = True
        Me.lstRefundHistory.ItemHeight = 20
        Me.lstRefundHistory.Location = New System.Drawing.Point(30, 68)
        Me.lstRefundHistory.Name = "lstRefundHistory"
        Me.lstRefundHistory.Size = New System.Drawing.Size(910, 284)
        Me.lstRefundHistory.TabIndex = 3
        '
        'txtCustomerId2
        '
        Me.txtCustomerId2.Location = New System.Drawing.Point(141, 31)
        Me.txtCustomerId2.Name = "txtCustomerId2"
        Me.txtCustomerId2.Size = New System.Drawing.Size(207, 27)
        Me.txtCustomerId2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Customer ID:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnChangeInfo)
        Me.TabPage3.Controls.Add(Me.lstRefundHistory2)
        Me.TabPage3.Controls.Add(Me.txtCustomerId3)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(966, 379)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Update Refund"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnChangeInfo
        '
        Me.btnChangeInfo.Location = New System.Drawing.Point(718, 326)
        Me.btnChangeInfo.Name = "btnChangeInfo"
        Me.btnChangeInfo.Size = New System.Drawing.Size(203, 28)
        Me.btnChangeInfo.TabIndex = 6
        Me.btnChangeInfo.Text = "Change &Information"
        Me.btnChangeInfo.UseVisualStyleBackColor = True
        '
        'lstRefundHistory2
        '
        Me.lstRefundHistory2.FormattingEnabled = True
        Me.lstRefundHistory2.ItemHeight = 20
        Me.lstRefundHistory2.Location = New System.Drawing.Point(46, 73)
        Me.lstRefundHistory2.Name = "lstRefundHistory2"
        Me.lstRefundHistory2.Size = New System.Drawing.Size(880, 244)
        Me.lstRefundHistory2.TabIndex = 5
        '
        'txtCustomerId3
        '
        Me.txtCustomerId3.Location = New System.Drawing.Point(157, 27)
        Me.txtCustomerId3.Name = "txtCustomerId3"
        Me.txtCustomerId3.Size = New System.Drawing.Size(207, 27)
        Me.txtCustomerId3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Customer ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(974, 281)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnClearAll)
        Me.TabPage4.Controls.Add(Me.btnRemove)
        Me.TabPage4.Controls.Add(Me.lstRedfundHistory3)
        Me.TabPage4.Controls.Add(Me.txtCustomerId4)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(966, 379)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Delete Refund History"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtCustomerId4
        '
        Me.txtCustomerId4.Location = New System.Drawing.Point(153, 24)
        Me.txtCustomerId4.Name = "txtCustomerId4"
        Me.txtCustomerId4.Size = New System.Drawing.Size(207, 27)
        Me.txtCustomerId4.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "&Customer ID:"
        '
        'lstRedfundHistory3
        '
        Me.lstRedfundHistory3.FormattingEnabled = True
        Me.lstRedfundHistory3.ItemHeight = 20
        Me.lstRedfundHistory3.Location = New System.Drawing.Point(42, 66)
        Me.lstRedfundHistory3.Name = "lstRedfundHistory3"
        Me.lstRedfundHistory3.Size = New System.Drawing.Size(886, 244)
        Me.lstRedfundHistory3.TabIndex = 7
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(555, 325)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(173, 34)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "&Remove History"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(748, 325)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(180, 34)
        Me.btnClearAll.TabIndex = 9
        Me.btnClearAll.Text = "ClearAll &History"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'frmRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 763)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmRefund"
        Me.Text = "Refund Module"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstTicket As ListBox
    Friend WithEvents lblTotalRefund As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOthers As RadioButton
    Friend WithEvents radSomethinngToDo As RadioButton
    Friend WithEvents radWrongMovie As RadioButton
    Friend WithEvents radWrongTime As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lstRefundHistory As ListBox
    Friend WithEvents txtCustomerId2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnChangeInfo As Button
    Friend WithEvents lstRefundHistory2 As ListBox
    Friend WithEvents txtCustomerId3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents lstRedfundHistory3 As ListBox
    Friend WithEvents txtCustomerId4 As TextBox
    Friend WithEvents Label8 As Label
End Class
