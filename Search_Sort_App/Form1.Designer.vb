<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchSort
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
        Me.cmbAlgorithm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbRandom = New System.Windows.Forms.RadioButton()
        Me.rbFile = New System.Windows.Forms.RadioButton()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.lbSteps = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbAlgorithm
        '
        Me.cmbAlgorithm.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmbAlgorithm.FormattingEnabled = True
        Me.cmbAlgorithm.Items.AddRange(New Object() {"Bubble Sort", "Insertion Sort", "Linear Search", "Binary Search"})
        Me.cmbAlgorithm.Location = New System.Drawing.Point(185, 35)
        Me.cmbAlgorithm.Name = "cmbAlgorithm"
        Me.cmbAlgorithm.Size = New System.Drawing.Size(253, 28)
        Me.cmbAlgorithm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Algorithm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Data Source"
        '
        'rbRandom
        '
        Me.rbRandom.AutoSize = True
        Me.rbRandom.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbRandom.Location = New System.Drawing.Point(185, 99)
        Me.rbRandom.Name = "rbRandom"
        Me.rbRandom.Size = New System.Drawing.Size(120, 24)
        Me.rbRandom.TabIndex = 3
        Me.rbRandom.TabStop = True
        Me.rbRandom.Text = "Random Data"
        Me.rbRandom.UseVisualStyleBackColor = True
        '
        'rbFile
        '
        Me.rbFile.AutoSize = True
        Me.rbFile.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rbFile.Location = New System.Drawing.Point(311, 99)
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Size = New System.Drawing.Size(138, 24)
        Me.rbFile.TabIndex = 3
        Me.rbFile.TabStop = True
        Me.rbFile.Text = "Import from File"
        Me.rbFile.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExecute.Location = New System.Drawing.Point(151, 157)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(154, 35)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'lbSteps
        '
        Me.lbSteps.FormattingEnabled = True
        Me.lbSteps.HorizontalScrollbar = True
        Me.lbSteps.ItemHeight = 15
        Me.lbSteps.Location = New System.Drawing.Point(21, 251)
        Me.lbSteps.Name = "lbSteps"
        Me.lbSteps.ScrollAlwaysVisible = True
        Me.lbSteps.Size = New System.Drawing.Size(428, 199)
        Me.lbSteps.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(151, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Step of the algorithm"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 497)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(428, 23)
        Me.TextBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(200, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Result"
        '
        'SearchSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 542)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbSteps)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.rbFile)
        Me.Controls.Add(Me.rbRandom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAlgorithm)
        Me.MaximumSize = New System.Drawing.Size(496, 581)
        Me.MinimumSize = New System.Drawing.Size(496, 581)
        Me.Name = "SearchSort"
        Me.Text = "Search and Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAlgorithm As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbRandom As RadioButton
    Friend WithEvents rbFile As RadioButton
    Friend WithEvents btnExecute As Button
    Friend WithEvents lbSteps As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
