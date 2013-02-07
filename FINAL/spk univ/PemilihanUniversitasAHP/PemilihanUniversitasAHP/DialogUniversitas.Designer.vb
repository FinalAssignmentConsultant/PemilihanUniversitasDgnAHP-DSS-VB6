<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogUniversitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogUniversitas))
        Dim UniversitasLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.UniversitasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.UniversitasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.UniversitasDataGridView = New System.Windows.Forms.DataGridView
        Me.UniversitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AhpUniversitasDataSet = New PemilihanUniversitasAHP.AhpUniversitasDataSet
        Me.UniversitasTableAdapter = New PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.UniversitasTableAdapter
        Me.TableAdapterManager = New PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UniversitasTextBox = New System.Windows.Forms.TextBox
        UniversitasLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.UniversitasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UniversitasBindingNavigator.SuspendLayout()
        CType(Me.UniversitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhpUniversitasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(171, 305)
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
        'UniversitasBindingNavigator
        '
        Me.UniversitasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UniversitasBindingNavigator.BindingSource = Me.UniversitasBindingSource
        Me.UniversitasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UniversitasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UniversitasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UniversitasBindingNavigatorSaveItem})
        Me.UniversitasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UniversitasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UniversitasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UniversitasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UniversitasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UniversitasBindingNavigator.Name = "UniversitasBindingNavigator"
        Me.UniversitasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UniversitasBindingNavigator.Size = New System.Drawing.Size(329, 25)
        Me.UniversitasBindingNavigator.TabIndex = 1
        Me.UniversitasBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UniversitasBindingNavigatorSaveItem
        '
        Me.UniversitasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UniversitasBindingNavigatorSaveItem.Image = CType(resources.GetObject("UniversitasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UniversitasBindingNavigatorSaveItem.Name = "UniversitasBindingNavigatorSaveItem"
        Me.UniversitasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UniversitasBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UniversitasDataGridView
        '
        Me.UniversitasDataGridView.AutoGenerateColumns = False
        Me.UniversitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UniversitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.UniversitasDataGridView.DataSource = Me.UniversitasBindingSource
        Me.UniversitasDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.UniversitasDataGridView.Name = "UniversitasDataGridView"
        Me.UniversitasDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.UniversitasDataGridView.TabIndex = 2
        '
        'UniversitasBindingSource
        '
        Me.UniversitasBindingSource.DataMember = "Universitas"
        Me.UniversitasBindingSource.DataSource = Me.AhpUniversitasDataSet
        '
        'AhpUniversitasDataSet
        '
        Me.AhpUniversitasDataSet.DataSetName = "AhpUniversitasDataSet"
        Me.AhpUniversitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UniversitasTableAdapter
        '
        Me.UniversitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        '    Me.TableAdapterManager.AlternatifPadaKriteriaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KriteriaTableAdapter = Nothing
        Me.TableAdapterManager.Universitas1TableAdapter = Nothing
        Me.TableAdapterManager.UniversitasTableAdapter = Me.UniversitasTableAdapter
        Me.TableAdapterManager.UpdateOrder = PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Universitas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Universitas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'UniversitasLabel
        '
        UniversitasLabel.AutoSize = True
        UniversitasLabel.Location = New System.Drawing.Point(11, 45)
        UniversitasLabel.Name = "UniversitasLabel"
        UniversitasLabel.Size = New System.Drawing.Size(62, 13)
        UniversitasLabel.TabIndex = 3
        UniversitasLabel.Text = "Universitas:"
        '
        'UniversitasTextBox
        '
        Me.UniversitasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UniversitasBindingSource, "Universitas", True))
        Me.UniversitasTextBox.Location = New System.Drawing.Point(79, 42)
        Me.UniversitasTextBox.Name = "UniversitasTextBox"
        Me.UniversitasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UniversitasTextBox.TabIndex = 4
        '
        'DialogUniversitas
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(329, 346)
        Me.Controls.Add(UniversitasLabel)
        Me.Controls.Add(Me.UniversitasTextBox)
        Me.Controls.Add(Me.UniversitasDataGridView)
        Me.Controls.Add(Me.UniversitasBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogUniversitas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogUniversitas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.UniversitasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UniversitasBindingNavigator.ResumeLayout(False)
        Me.UniversitasBindingNavigator.PerformLayout()
        CType(Me.UniversitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniversitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhpUniversitasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents AhpUniversitasDataSet As PemilihanUniversitasAHP.AhpUniversitasDataSet
    Friend WithEvents UniversitasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UniversitasTableAdapter As PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.UniversitasTableAdapter
    Friend WithEvents TableAdapterManager As PemilihanUniversitasAHP.AhpUniversitasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UniversitasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UniversitasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UniversitasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UniversitasTextBox As System.Windows.Forms.TextBox

End Class
