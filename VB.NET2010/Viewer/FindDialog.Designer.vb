<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.lblsearching = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 135)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Find"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(71, 38)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(144, 20)
        Me.txtFind.TabIndex = 2
        '
        'btnprevious
        '
        Me.btnprevious.Location = New System.Drawing.Point(30, 124)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(87, 35)
        Me.btnprevious.TabIndex = 3
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(126, 125)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(88, 33)
        Me.btnnext.TabIndex = 4
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'lblsearching
        '
        Me.lblsearching.AutoSize = True
        Me.lblsearching.Location = New System.Drawing.Point(32, 77)
        Me.lblsearching.Name = "lblsearching"
        Me.lblsearching.Size = New System.Drawing.Size(58, 13)
        Me.lblsearching.TabIndex = 5
        Me.lblsearching.Text = "Searching:"
        '
        'FindDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 176)
        Me.Controls.Add(Me.lblsearching)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnprevious As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents lblsearching As System.Windows.Forms.Label

End Class
