<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefundContinue
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtAccNo = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHomeExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMovie = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateMovieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromotionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentRefund = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Refund Information"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(35, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(574, 175)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&User Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Bank:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bank &Account No:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Hong Leong Bank", "Public Bank", "CIMB Bank", "Maybank", "RHB Bank", "AmBank"})
        Me.ComboBox1.Location = New System.Drawing.Point(238, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 30)
        Me.ComboBox1.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(238, 85)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(347, 28)
        Me.txtUsername.TabIndex = 6
        '
        'txtAccNo
        '
        Me.txtAccNo.Location = New System.Drawing.Point(238, 181)
        Me.txtAccNo.MaxLength = 20
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(347, 28)
        Me.txtAccNo.TabIndex = 7
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(325, 252)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(130, 30)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(480, 252)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 30)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuMovie, Me.BookingToolStripMenuItem, Me.PromotionToolStripMenuItem, Me.mnuPayment, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHome
        '
        Me.mnuHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserProfileToolStripMenuItem, Me.mnuHomeExit})
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(62, 24)
        Me.mnuHome.Text = "&Home"
        '
        'UserProfileToolStripMenuItem
        '
        Me.UserProfileToolStripMenuItem.Name = "UserProfileToolStripMenuItem"
        Me.UserProfileToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.UserProfileToolStripMenuItem.Text = "User Profile"
        '
        'mnuHomeExit
        '
        Me.mnuHomeExit.Name = "mnuHomeExit"
        Me.mnuHomeExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuHomeExit.Size = New System.Drawing.Size(161, 26)
        Me.mnuHomeExit.Text = "E&xit"
        '
        'mnuMovie
        '
        Me.mnuMovie.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateMovieToolStripMenuItem, Me.UpdateMovieToolStripMenuItem1, Me.DisplayMovieToolStripMenuItem, Me.DeleteMovieToolStripMenuItem})
        Me.mnuMovie.Name = "mnuMovie"
        Me.mnuMovie.Size = New System.Drawing.Size(62, 24)
        Me.mnuMovie.Text = "&Movie"
        '
        'UpdateMovieToolStripMenuItem
        '
        Me.UpdateMovieToolStripMenuItem.Name = "UpdateMovieToolStripMenuItem"
        Me.UpdateMovieToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.UpdateMovieToolStripMenuItem.Text = "Create Movie"
        '
        'UpdateMovieToolStripMenuItem1
        '
        Me.UpdateMovieToolStripMenuItem1.Name = "UpdateMovieToolStripMenuItem1"
        Me.UpdateMovieToolStripMenuItem1.Size = New System.Drawing.Size(178, 26)
        Me.UpdateMovieToolStripMenuItem1.Text = "Update Movie"
        '
        'DisplayMovieToolStripMenuItem
        '
        Me.DisplayMovieToolStripMenuItem.Name = "DisplayMovieToolStripMenuItem"
        Me.DisplayMovieToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.DisplayMovieToolStripMenuItem.Text = "Display Movie"
        '
        'DeleteMovieToolStripMenuItem
        '
        Me.DeleteMovieToolStripMenuItem.Name = "DeleteMovieToolStripMenuItem"
        Me.DeleteMovieToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.DeleteMovieToolStripMenuItem.Text = "Delete Movie"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.BookingToolStripMenuItem.Text = "&Booking Ticket"
        '
        'PromotionToolStripMenuItem
        '
        Me.PromotionToolStripMenuItem.Name = "PromotionToolStripMenuItem"
        Me.PromotionToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.PromotionToolStripMenuItem.Text = "&Promotion"
        '
        'mnuPayment
        '
        Me.mnuPayment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentToolStripMenuItem, Me.mnuPaymentReceipt, Me.mnuPaymentRefund})
        Me.mnuPayment.Name = "mnuPayment"
        Me.mnuPayment.Size = New System.Drawing.Size(127, 24)
        Me.mnuPayment.Text = "&Payment Details"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'mnuPaymentReceipt
        '
        Me.mnuPaymentReceipt.Name = "mnuPaymentReceipt"
        Me.mnuPaymentReceipt.Size = New System.Drawing.Size(140, 26)
        Me.mnuPaymentReceipt.Text = "Re&ceipt"
        '
        'mnuPaymentRefund
        '
        Me.mnuPaymentRefund.Name = "mnuPaymentRefund"
        Me.mnuPaymentRefund.Size = New System.Drawing.Size(140, 26)
        Me.mnuPaymentRefund.Text = "Re&fund"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuHelpAbout.Size = New System.Drawing.Size(182, 26)
        Me.mnuHelpAbout.Text = "&About"
        '
        'frmRefundContinue
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(649, 294)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtAccNo)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRefundContinue"
        Me.Text = "RefundContinue"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtAccNo As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents UserProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHomeExit As ToolStripMenuItem
    Friend WithEvents mnuMovie As ToolStripMenuItem
    Friend WithEvents UpdateMovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateMovieToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DisplayMovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMovieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromotionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPayment As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPaymentReceipt As ToolStripMenuItem
    Friend WithEvents mnuPaymentRefund As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
End Class
