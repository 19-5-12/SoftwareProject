<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List))
        Me.Fill = New System.Windows.Forms.Panel()
        Me.shadowBottom = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shadowTop = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnadminpfp = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Fill.SuspendLayout()
        Me.shadowBottom.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.shadowTop.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fill
        '
        Me.Fill.BackColor = System.Drawing.Color.Gainsboro
        Me.Fill.Controls.Add(Me.shadowBottom)
        Me.Fill.Controls.Add(Me.shadowTop)
        Me.Fill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fill.Location = New System.Drawing.Point(0, 0)
        Me.Fill.Name = "Fill"
        Me.Fill.Size = New System.Drawing.Size(959, 543)
        Me.Fill.TabIndex = 1
        '
        'shadowBottom
        '
        Me.shadowBottom.BackColor = System.Drawing.Color.SkyBlue
        Me.shadowBottom.Controls.Add(Me.Panel2)
        Me.shadowBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shadowBottom.Location = New System.Drawing.Point(0, 128)
        Me.shadowBottom.Name = "shadowBottom"
        Me.shadowBottom.Size = New System.Drawing.Size(959, 415)
        Me.shadowBottom.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(20, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(918, 384)
        Me.Panel2.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(918, 343)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(918, 41)
        Me.Panel5.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(379, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LIST OF APPOINTMENTS"
        '
        'shadowTop
        '
        Me.shadowTop.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.shadowTop.Controls.Add(Me.Panel14)
        Me.shadowTop.Controls.Add(Me.Panel4)
        Me.shadowTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.shadowTop.Location = New System.Drawing.Point(0, 0)
        Me.shadowTop.Name = "shadowTop"
        Me.shadowTop.Size = New System.Drawing.Size(959, 128)
        Me.shadowTop.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel14.BackColor = System.Drawing.Color.LightGray
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.PictureBox1)
        Me.Panel14.Location = New System.Drawing.Point(405, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(150, 111)
        Me.Panel14.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.btnadminpfp)
        Me.Panel4.Controls.Add(Me.btnlogout)
        Me.Panel4.Location = New System.Drawing.Point(724, 65)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(206, 46)
        Me.Panel4.TabIndex = 5
        '
        'btnadminpfp
        '
        Me.btnadminpfp.BackColor = System.Drawing.Color.LightGray
        Me.btnadminpfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnadminpfp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadminpfp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnadminpfp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadminpfp.Location = New System.Drawing.Point(106, 0)
        Me.btnadminpfp.Name = "btnadminpfp"
        Me.btnadminpfp.Size = New System.Drawing.Size(100, 46)
        Me.btnadminpfp.TabIndex = 1
        Me.btnadminpfp.Text = "Profile"
        Me.btnadminpfp.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.LightGray
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Location = New System.Drawing.Point(0, 0)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(100, 46)
        Me.btnlogout.TabIndex = 0
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 543)
        Me.Controls.Add(Me.Fill)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List"
        Me.Fill.ResumeLayout(False)
        Me.shadowBottom.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.shadowTop.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fill As Panel
    Friend WithEvents shadowTop As Panel
    Friend WithEvents shadowBottom As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnadminpfp As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
