Public Class FormAdmin

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKluarAdmin.Click
        End
    End Sub

    Private Sub btnTambahKrit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahKrit.Click
        FormTambahKriteria.ShowDialog()
    End Sub

    Private Sub btnHapusKrit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusKrit.Click
        FormHapusKriteria.ShowDialog()
    End Sub

    Private Sub btnTambahUniv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahUniv.Click
        FormTambahUniversitas.ShowDialog()
    End Sub

    Private Sub btnHapusUniv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusUniv.Click
        FormHapusUniversitas.ShowDialog()
    End Sub
End Class