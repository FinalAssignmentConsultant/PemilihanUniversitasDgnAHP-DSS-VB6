Imports System.Windows.Forms

Public Class DialogUniversitas

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub UniversitasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UniversitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UniversitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AhpUniversitasDataSet)

    End Sub

    Private Sub DialogUniversitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AhpUniversitasDataSet.Universitas' table. You can move, or remove it, as needed.
        Me.UniversitasTableAdapter.Fill(Me.AhpUniversitasDataSet.Universitas)

    End Sub
End Class
