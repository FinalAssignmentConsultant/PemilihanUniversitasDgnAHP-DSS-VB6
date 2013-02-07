Public Class xFormInfoPreferensi

    Private Sub FormInfoPreferensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub info(ByVal i As Integer)
        Dim pref As Integer
        If i = 9 Then
            pref = 1
        ElseIf i < 9 Then
            pref = 10 - i
        ElseIf i > 9 Then
            pref = i - 8
        End If
        lblAngka.Text = pref

        Select Case pref
            Case 1
                lblInfo.Text = "Kedua elemen sama pentingnya"
            Case 2, 4, 6, 8
                lblInfo.Text = "Nilai-nilai antara dua nilai pertimbangan-pertimbangan  yang berdekatan"
            Case 3
                lblInfo.Text = "Elemen yang satu sedikit lebih penting daripada elemen yang lainnya"
            Case 5
                lblInfo.Text = "Elemen yang satu lebih penting daripada yang lainnya"
            Case 7
                lblInfo.Text = "Satu elemen jelas lebih mutlak penting daripada elemen lainnya"
            Case 9
                lblInfo.Text = "Satu elemen mutlak penting daripada elemen lainnya"
        End Select


    End Sub
End Class