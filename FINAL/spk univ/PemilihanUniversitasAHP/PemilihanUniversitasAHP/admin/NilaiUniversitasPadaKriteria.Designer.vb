<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NilaiUniversitasPadaKriteria
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NilaiUniversitasPadaKriteria))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.KriteriaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.KriteriaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ReferenceKriteriaDEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonUniversitas = New System.Windows.Forms.Button
        Me.UniversitasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KriteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AhpUniversitasDataSet = New PemilihanUniversitasAHP.AhpUniversitasDataSet
        Me.KriteriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KriteriaTableAdapter = New PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.KriteriaTableAdapter
        Me.TableAdapterManager = New PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.TableAdapterManager
        Me.DirectentryTableAdapter = New PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.directentryTableAdapter
        Me.UniversitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniversitasTableAdapter = New PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.UniversitasTableAdapter
        Me.UniversitasDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.KriteriaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KriteriaBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenceKriteriaDEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KriteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhpUniversitasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(497, 436)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'KriteriaBindingNavigator
        '
        Me.KriteriaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KriteriaBindingNavigator.BindingSource = Me.KriteriaBindingSource
        Me.KriteriaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KriteriaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KriteriaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KriteriaBindingNavigatorSaveItem})
        Me.KriteriaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KriteriaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KriteriaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KriteriaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KriteriaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KriteriaBindingNavigator.Name = "KriteriaBindingNavigator"
        Me.KriteriaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KriteriaBindingNavigator.Size = New System.Drawing.Size(655, 25)
        Me.KriteriaBindingNavigator.TabIndex = 1
        Me.KriteriaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'KriteriaBindingNavigatorSaveItem
        '
        Me.KriteriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KriteriaBindingNavigatorSaveItem.Image = CType(resources.GetObject("KriteriaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KriteriaBindingNavigatorSaveItem.Name = "KriteriaBindingNavigatorSaveItem"
        Me.KriteriaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KriteriaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KriteriaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KriteriaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(312, 188)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UniversitasDataGridViewTextBoxColumn, Me.ValueDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ReferenceKriteriaDEBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 263)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(312, 165)
        Me.DataGridView2.TabIndex = 3
        '
        'ReferenceKriteriaDEBindingSource
        '
        Me.ReferenceKriteriaDEBindingSource.DataMember = "ReferenceKriteriaDE"
        Me.ReferenceKriteriaDEBindingSource.DataSource = Me.KriteriaBindingSource
        '
        'ButtonUniversitas
        '
        Me.ButtonUniversitas.Location = New System.Drawing.Point(12, 234)
        Me.ButtonUniversitas.Name = "ButtonUniversitas"
        Me.ButtonUniversitas.Size = New System.Drawing.Size(104, 23)
        Me.ButtonUniversitas.TabIndex = 4
        Me.ButtonUniversitas.Text = "Daftar Universitas"
        Me.ButtonUniversitas.UseVisualStyleBackColor = True
        '
        'UniversitasDataGridViewTextBoxColumn
        '
        Me.UniversitasDataGridViewTextBoxColumn.DataPropertyName = "Universitas"
        Me.UniversitasDataGridViewTextBoxColumn.HeaderText = "Universitas"
        Me.UniversitasDataGridViewTextBoxColumn.Name = "UniversitasDataGridViewTextBoxColumn"
        '
        'ValueDataGridViewTextBoxColumn
        '
        Me.ValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValueDataGridViewTextBoxColumn.DataPropertyName = "value"
        Me.ValueDataGridViewTextBoxColumn.HeaderText = "value"
        Me.ValueDataGridViewTextBoxColumn.Name = "ValueDataGridViewTextBoxColumn"
        '
        'KriteriaBindingSource
        '
        Me.KriteriaBindingSource.DataMember = "Kriteria"
        Me.KriteriaBindingSource.DataSource = Me.AhpUniversitasDataSet
        '
        'AhpUniversitasDataSet
        '
        Me.AhpUniversitasDataSet.DataSetName = "AhpUniversitasDataSet"
        Me.AhpUniversitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KriteriaDataGridViewTextBoxColumn
        '
        Me.KriteriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.KriteriaDataGridViewTextBoxColumn.DataPropertyName = "Kriteria"
        Me.KriteriaDataGridViewTextBoxColumn.HeaderText = "Kriteria"
        Me.KriteriaDataGridViewTextBoxColumn.Name = "KriteriaDataGridViewTextBoxColumn"
        '
        'KriteriaTableAdapter
        '
        Me.KriteriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.directentryTableAdapter = Me.DirectentryTableAdapter
        Me.TableAdapterManager.KriteriaTableAdapter = Me.KriteriaTableAdapter
        Me.TableAdapterManager.Universitas1TableAdapter = Nothing
        Me.TableAdapterManager.UniversitasPadaKriteriaTableAdapter = Nothing
        Me.TableAdapterManager.UniversitasTableAdapter = Me.UniversitasTableAdapter
        Me.TableAdapterManager.UpdateOrder = PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DirectentryTableAdapter
        '
        Me.DirectentryTableAdapter.ClearBeforeFill = True
        '
        'UniversitasBindingSource
        '
        Me.UniversitasBindingSource.DataMember = "Universitas"
        Me.UniversitasBindingSource.DataSource = Me.AhpUniversitasDataSet
        '
        'UniversitasTableAdapter
        '
        Me.UniversitasTableAdapter.ClearBeforeFill = True
        '
        'UniversitasDataGridView
        '
        Me.UniversitasDataGridView.AutoGenerateColumns = False
        Me.UniversitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UniversitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.UniversitasDataGridView.DataSource = Me.UniversitasBindingSource
        Me.UniversitasDataGridView.Location = New System.Drawing.Point(342, 130)
        Me.UniversitasDataGridView.Name = "UniversitasDataGridView"
        Me.UniversitasDataGridView.Size = New System.Drawing.Size(300, 298)
        Me.UniversitasDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Universitas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Universitas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Daftar Universitas"
        '
        'NilaiUniversitasPadaKriteria
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(655, 477)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UniversitasDataGridView)
        Me.Controls.Add(Me.ButtonUniversitas)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.KriteriaBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NilaiUniversitasPadaKriteria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NilaiUniversitasPadaKriteria"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.KriteriaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KriteriaBindingNavigator.ResumeLayout(False)
        Me.KriteriaBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenceKriteriaDEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KriteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhpUniversitasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniversitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniversitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents AhpUniversitasDataSet As PemilihanUniversitasAHP.AhpUniversitasDataSet
    Friend WithEvents KriteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KriteriaTableAdapter As PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.KriteriaTableAdapter
    Friend WithEvents TableAdapterManager As PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KriteriaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KriteriaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents KriteriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DirectentryTableAdapter As PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.directentryTableAdapter
    Friend WithEvents ReferenceKriteriaDEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UniversitasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonUniversitas As System.Windows.Forms.Button
    Friend WithEvents UniversitasTableAdapter As PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.UniversitasTableAdapter
    Friend WithEvents UniversitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UniversitasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
