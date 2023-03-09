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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PDDataSet = New WindowsApplication1.PDDataSet()
        Me.PDTableAdapter = New WindowsApplication1.PDDataSetTableAdapters.PDTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PDDataSet1 = New WindowsApplication1.PDDataSet1()
        Me.PDBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PDTableAdapter1 = New WindowsApplication1.PDDataSet1TableAdapters.PDTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Turquoise
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PDBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(63, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 368)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "Mobile number"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile number"
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        '
        'PDBindingSource
        '
        Me.PDBindingSource.DataMember = "PD"
        Me.PDBindingSource.DataSource = Me.PDDataSet
        '
        'PDDataSet
        '
        Me.PDDataSet.DataSetName = "PDDataSet"
        Me.PDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PDTableAdapter
        '
        Me.PDTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(668, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(668, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(293, 44)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "MOVE FIRST"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(668, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(293, 44)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "MOVE PREVIOUS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(668, 166)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(293, 44)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "MOVE LAST"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Crimson
        Me.Button5.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(668, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(293, 44)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "MOVE NEXT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Crimson
        Me.Button6.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Location = New System.Drawing.Point(668, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(293, 44)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "REMOVE CURRENT"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Crimson
        Me.Button7.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Location = New System.Drawing.Point(668, 296)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(293, 44)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "EXIT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Magenta
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(832, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "HEMALATHA. B"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Magenta
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(848, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "19BCS0073"
        '
        'PDDataSet1
        '
        Me.PDDataSet1.DataSetName = "PDDataSet1"
        Me.PDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PDBindingSource1
        '
        Me.PDBindingSource1.DataMember = "PD"
        Me.PDBindingSource1.DataSource = Me.PDDataSet1
        '
        'PDTableAdapter1
        '
        Me.PDTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1029, 439)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "19BCS0073"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PDDataSet As WindowsApplication1.PDDataSet
    Friend WithEvents PDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PDTableAdapter As WindowsApplication1.PDDataSetTableAdapters.PDTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PDDataSet1 As WindowsApplication1.PDDataSet1
    Friend WithEvents PDBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PDTableAdapter1 As WindowsApplication1.PDDataSet1TableAdapters.PDTableAdapter

End Class
