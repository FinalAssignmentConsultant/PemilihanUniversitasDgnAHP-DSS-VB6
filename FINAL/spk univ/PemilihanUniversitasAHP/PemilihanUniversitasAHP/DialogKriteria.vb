Imports System.Windows.Forms

Public Class DialogKriteria

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub KriteriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KriteriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KriteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AhpUniversitasDataSet)

    End Sub

    Private Sub DialogKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AhpUniversitasDataSet.Kriteria' table. You can move, or remove it, as needed.
        Me.KriteriaTableAdapter.Fill(Me.AhpUniversitasDataSet.Kriteria)

    End Sub
End Class
