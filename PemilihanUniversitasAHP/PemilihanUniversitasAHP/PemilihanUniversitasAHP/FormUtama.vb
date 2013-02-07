Public Class FormUtama
    Dim MatrixKriteria(,) As Single = New Single(4, 4) {}

    Dim MatrixKriteria1Alternatif(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria2Alternatif(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria3Alternatif(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria4Alternatif(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria5Alternatif(,) As Single = New Single(4, 4) {}

    Dim MatrixKriteriaValue(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria1AlternatifValue(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria2AlternatifValue(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria3AlternatifValue(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria4AlternatifValue(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteria5AlternatifValue(,) As Single = New Single(4, 4) {}

    Dim MatrixKriteriaBobot() As Single = New Single(4) {}
    Dim MatrixKriteria1AlternatifBobot() As Single = New Single(4) {}
    Dim MatrixKriteria2AlternatifBobot() As Single = New Single(4) {}
    Dim MatrixKriteria3AlternatifBobot() As Single = New Single(4) {}
    Dim MatrixKriteria4AlternatifBobot() As Single = New Single(4) {}
    Dim MatrixKriteria5AlternatifBobot() As Single = New Single(4) {}

    Dim MatrixKriteriaTotalKolom() As Single = New Single(4) {}
    Dim MatrixKriteria1AlternatifTotalKolom() As Single = New Single(4) {}
    Dim MatrixKriteria2AlternatifTotalKolom() As Single = New Single(4) {}
    Dim MatrixKriteria3AlternatifTotalKolom() As Single = New Single(4) {}
    Dim MatrixKriteria4AlternatifTotalKolom() As Single = New Single(4) {}
    Dim MatrixKriteria5AlternatifTotalKolom() As Single = New Single(4) {}

    Dim MatrixKriteriaTotalBaris() As Single = New Single(4) {}
    Dim MatrixKriteria1AlternatifTotalBaris() As Single = New Single(4) {}
    Dim MatrixKriteria2AlternatifTotalBaris() As Single = New Single(4) {}
    Dim MatrixKriteria3AlternatifTotalBaris() As Single = New Single(4) {}
    Dim MatrixKriteria4AlternatifTotalBaris() As Single = New Single(4) {}
    Dim MatrixKriteria5AlternatifTotalBaris() As Single = New Single(4) {}

    Dim ScoreAkhirAlternatif() As Single = New Single(4) {}

    Dim MatrixRI() As Single = New Single(14) {0, 0, 0.58, 0.9, 1.12, 1.24, 1.32, 1.41, 1.45, 1.49, 1.51, 1.48, 1.56, 1.57, 1.59}
    Dim MatrixKriteriaForConsistency(,) As Single = New Single(4, 4) {}
    Dim MatrixKriteriaForConsistencyTotalBaris() As Single = New Single(4) {}
    Dim MatrixKriteriaForConsistencyTotalBarisLambda() As Single = New Single(4) {}

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub btnAturAHP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPengaturan.ShowDialog()
    End Sub
    Private Sub updnJumlahKriteria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updnJumlahKriteria.ValueChanged

        prosesAhpModel()
    End Sub
    Private Sub validateIt()
        cboKriteria1.Visible = False
        cboKriteria2.Visible = False
        cboKriteria3.Visible = False
        cboKriteria4.Visible = False
        cboKriteria5.Visible = False
        Select Case updnJumlahKriteria.Value
            Case 3
                cboKriteria1.Visible = True
                cboKriteria2.Visible = True
                cboKriteria3.Visible = True
            Case 4
                cboKriteria1.Visible = True
                cboKriteria2.Visible = True
                cboKriteria3.Visible = True
                cboKriteria4.Visible = True
            Case 5
                cboKriteria1.Visible = True
                cboKriteria2.Visible = True
                cboKriteria3.Visible = True
                cboKriteria4.Visible = True
                cboKriteria5.Visible = True
        End Select

        cboAlternatif1.Visible = False
        cboAlternatif2.Visible = False
        cboAlternatif3.Visible = False
        cboAlternatif4.Visible = False
        cboAlternatif5.Visible = False

        lblKriteria1Alternatif4.Visible = False
        lblKriteria1Alternatif3.Visible = False
        lblKriteria1Alternatif4Alternatif5.Visible = False

        lblKriteria1Alternatif1Alternatif4.Visible = False
        lblKriteria1Alternatif2Alternatif4.Visible = False
        lblKriteria1Alternatif3Alternatif4.Visible = False

        lblKriteria1Alternatif1Alternatif5.Visible = False
        lblKriteria1Alternatif2Alternatif5.Visible = False
        lblKriteria1Alternatif3Alternatif5.Visible = False
        lblKriteria1Alternatif4Alternatif5.Visible = False

        'kriteria1
        trkKriteria1Alternatif1Alternatif4.Visible = False
        trkKriteria1Alternatif2Alternatif4.Visible = False
        trkKriteria1Alternatif3Alternatif4.Visible = False

        trkKriteria1Alternatif1Alternatif5.Visible = False
        trkKriteria1Alternatif2Alternatif5.Visible = False
        trkKriteria1Alternatif3Alternatif5.Visible = False
        trkKriteria1Alternatif4Alternatif5.Visible = False

        'kriteria2
        trkKriteria2Alternatif1Alternatif4.Visible = False
        trkKriteria2Alternatif2Alternatif4.Visible = False
        trkKriteria2Alternatif3Alternatif4.Visible = False

        trkKriteria2Alternatif1Alternatif5.Visible = False
        trkKriteria2Alternatif2Alternatif5.Visible = False
        trkKriteria2Alternatif3Alternatif5.Visible = False
        trkKriteria2Alternatif4Alternatif5.Visible = False

        lblKriteria2Alternatif1Alternatif4.Visible = False
        lblKriteria2Alternatif2Alternatif4.Visible = False
        lblKriteria2Alternatif3Alternatif4.Visible = False
        lblKriteria2Alternatif3.Visible = False


        lblKriteria2Alternatif4Alternatif5.Visible = False
        lblKriteria2Alternatif1Alternatif5.Visible = False
        lblKriteria2Alternatif2Alternatif5.Visible = False
        lblKriteria2Alternatif3Alternatif5.Visible = False
        lblKriteria2Alternatif4Alternatif5.Visible = False
        lblKriteria2Alternatif1Alternatif5.Visible = False
        lblKriteria2Alternatif4.Visible = False

        'kriteria3
        trkKriteria3Alternatif1Alternatif4.Visible = False
        trkKriteria3Alternatif2Alternatif4.Visible = False
        trkKriteria3Alternatif3Alternatif4.Visible = False

        trkKriteria3Alternatif1Alternatif5.Visible = False
        trkKriteria3Alternatif2Alternatif5.Visible = False
        trkKriteria3Alternatif3Alternatif5.Visible = False
        trkKriteria3Alternatif4Alternatif5.Visible = False

        lblKriteria3Alternatif1Alternatif4.Visible = False
        lblKriteria3Alternatif2Alternatif4.Visible = False
        lblKriteria3Alternatif3Alternatif4.Visible = False
        lblKriteria3Alternatif3.Visible = False


        lblKriteria3Alternatif4Alternatif5.Visible = False
        lblKriteria3Alternatif1Alternatif5.Visible = False
        lblKriteria3Alternatif2Alternatif5.Visible = False
        lblKriteria3Alternatif3Alternatif5.Visible = False
        lblKriteria3Alternatif4Alternatif5.Visible = False
        lblKriteria3Alternatif1Alternatif5.Visible = False
        lblKriteria3Alternatif4.Visible = False

        'kriteria4
        trkKriteria4Alternatif1Alternatif4.Visible = False
        trkKriteria4Alternatif2Alternatif4.Visible = False
        trkKriteria4Alternatif3Alternatif4.Visible = False

        trkKriteria4Alternatif1Alternatif5.Visible = False
        trkKriteria4Alternatif2Alternatif5.Visible = False
        trkKriteria4Alternatif3Alternatif5.Visible = False
        trkKriteria4Alternatif4Alternatif5.Visible = False

        lblKriteria4Alternatif1Alternatif4.Visible = False
        lblKriteria4Alternatif2Alternatif4.Visible = False
        lblKriteria4Alternatif3Alternatif4.Visible = False
        lblKriteria4Alternatif3.Visible = False

        lblKriteria4Alternatif4Alternatif5.Visible = False
        lblKriteria4Alternatif1Alternatif5.Visible = False
        lblKriteria4Alternatif2Alternatif5.Visible = False
        lblKriteria4Alternatif3Alternatif5.Visible = False
        lblKriteria4Alternatif4Alternatif5.Visible = False
        lblKriteria4Alternatif1Alternatif5.Visible = False
        lblKriteria4Alternatif4.Visible = False

        'kriteria5
        trkKriteria5Alternatif1Alternatif4.Visible = False
        trkKriteria5Alternatif2Alternatif4.Visible = False
        trkKriteria5Alternatif3Alternatif4.Visible = False

        trkKriteria5Alternatif1Alternatif5.Visible = False
        trkKriteria5Alternatif2Alternatif5.Visible = False
        trkKriteria5Alternatif3Alternatif5.Visible = False
        trkKriteria5Alternatif4Alternatif5.Visible = False

        lblKriteria5Alternatif1Alternatif4.Visible = False
        lblKriteria5Alternatif2Alternatif4.Visible = False
        lblKriteria5Alternatif3Alternatif4.Visible = False
        lblKriteria5Alternatif3.Visible = False

        lblKriteria5Alternatif4Alternatif5.Visible = False
        lblKriteria5Alternatif1Alternatif5.Visible = False
        lblKriteria5Alternatif2Alternatif5.Visible = False
        lblKriteria5Alternatif3Alternatif5.Visible = False
        lblKriteria5Alternatif4Alternatif5.Visible = False
        lblKriteria5Alternatif1Alternatif5.Visible = False
        lblKriteria5Alternatif4.Visible = False

        Select Case updnJumlahAlternatif.Value
            Case 3
                cboAlternatif1.Visible = True
                cboAlternatif2.Visible = True
                cboAlternatif3.Visible = True
            Case 4
                cboAlternatif1.Visible = True
                cboAlternatif2.Visible = True
                cboAlternatif3.Visible = True
                cboAlternatif4.Visible = True

                lblKriteria1Alternatif3.Visible = True




                'kriteria1
                trkKriteria1Alternatif1Alternatif4.Visible = True
                trkKriteria1Alternatif2Alternatif4.Visible = True
                trkKriteria1Alternatif3Alternatif4.Visible = True

                lblKriteria1Alternatif1Alternatif4.Visible = True
                lblKriteria1Alternatif2Alternatif4.Visible = True
                lblKriteria1Alternatif3Alternatif4.Visible = True

                'kriteria2
                trkKriteria2Alternatif1Alternatif4.Visible = True
                trkKriteria2Alternatif2Alternatif4.Visible = True
                trkKriteria2Alternatif3Alternatif4.Visible = True

                lblKriteria2Alternatif1Alternatif4.Visible = True
                lblKriteria2Alternatif2Alternatif4.Visible = True
                lblKriteria2Alternatif3Alternatif4.Visible = True
                lblKriteria2Alternatif3.Visible = True

                'kriteria3
                trkKriteria3Alternatif1Alternatif4.Visible = True
                trkKriteria3Alternatif2Alternatif4.Visible = True
                trkKriteria3Alternatif3Alternatif4.Visible = True

                lblKriteria3Alternatif1Alternatif4.Visible = True
                lblKriteria3Alternatif2Alternatif4.Visible = True
                lblKriteria3Alternatif3Alternatif4.Visible = True
                lblKriteria3Alternatif3.Visible = True

                'kriteria4
                trkKriteria4Alternatif1Alternatif4.Visible = True
                trkKriteria4Alternatif2Alternatif4.Visible = True
                trkKriteria4Alternatif3Alternatif4.Visible = True

                lblKriteria4Alternatif1Alternatif4.Visible = True
                lblKriteria4Alternatif2Alternatif4.Visible = True
                lblKriteria4Alternatif3Alternatif4.Visible = True
                lblKriteria4Alternatif3.Visible = True

                'kriteria 5
                trkKriteria5Alternatif1Alternatif4.Visible = True
                trkKriteria5Alternatif2Alternatif4.Visible = True
                lblKriteria5Alternatif2Alternatif4.Visible = True
                lblKriteria5Alternatif3Alternatif4.Visible = True
                trkKriteria5Alternatif3Alternatif4.Visible = True
                lblKriteria5Alternatif3.Visible = True
                lblKriteria5Alternatif1Alternatif4.Visible = True
            Case 5
                cboAlternatif1.Visible = True
                cboAlternatif2.Visible = True
                cboAlternatif3.Visible = True
                cboAlternatif4.Visible = True
                cboAlternatif5.Visible = True

                lblKriteria1Alternatif3.Visible = True
                lblKriteria1Alternatif4.Visible = True
                lblKriteria1Alternatif1Alternatif4.Visible = True
                lblKriteria1Alternatif2Alternatif4.Visible = True
                lblKriteria1Alternatif3Alternatif4.Visible = True

                lblKriteria1Alternatif4Alternatif5.Visible = True
                lblKriteria1Alternatif1Alternatif5.Visible = True
                lblKriteria1Alternatif2Alternatif5.Visible = True
                lblKriteria1Alternatif3Alternatif5.Visible = True
                lblKriteria1Alternatif4Alternatif5.Visible = True

                lblKriteria1Alternatif1Alternatif4.Visible = True
                lblKriteria1Alternatif2Alternatif4.Visible = True
                lblKriteria1Alternatif3Alternatif4.Visible = True

                trkKriteria1Alternatif1Alternatif4.Visible = True
                trkKriteria1Alternatif1Alternatif5.Visible = True
                trkKriteria1Alternatif2Alternatif5.Visible = True
                trkKriteria1Alternatif2Alternatif4.Visible = True
                trkKriteria1Alternatif3Alternatif4.Visible = True
                trkKriteria1Alternatif3Alternatif5.Visible = True
                trkKriteria1Alternatif4Alternatif5.Visible = True

                'kriteria2

                lblKriteria2Alternatif4Alternatif5.Visible = True
                lblKriteria2Alternatif1Alternatif5.Visible = True
                lblKriteria2Alternatif2Alternatif5.Visible = True
                lblKriteria2Alternatif3Alternatif5.Visible = True
                lblKriteria2Alternatif4Alternatif5.Visible = True
                lblKriteria2Alternatif1Alternatif5.Visible = True
                lblKriteria2Alternatif4.Visible = True

                trkKriteria2Alternatif1Alternatif5.Visible = True
                trkKriteria2Alternatif2Alternatif5.Visible = True
                trkKriteria2Alternatif3Alternatif5.Visible = True
                trkKriteria2Alternatif4Alternatif5.Visible = True
                trkKriteria2Alternatif1Alternatif4.Visible = True
                trkKriteria2Alternatif2Alternatif4.Visible = True
                lblKriteria2Alternatif2Alternatif4.Visible = True
                lblKriteria2Alternatif3Alternatif4.Visible = True
                trkKriteria2Alternatif3Alternatif4.Visible = True
                lblKriteria2Alternatif3.Visible = True

                'kriteria3

                lblKriteria3Alternatif4Alternatif5.Visible = True
                lblKriteria3Alternatif1Alternatif5.Visible = True
                lblKriteria3Alternatif2Alternatif5.Visible = True
                lblKriteria3Alternatif3Alternatif5.Visible = True
                lblKriteria3Alternatif4Alternatif5.Visible = True
                lblKriteria3Alternatif1Alternatif5.Visible = True
                lblKriteria3Alternatif4.Visible = True

                trkKriteria3Alternatif1Alternatif5.Visible = True
                trkKriteria3Alternatif2Alternatif5.Visible = True
                trkKriteria3Alternatif3Alternatif5.Visible = True
                trkKriteria3Alternatif4Alternatif5.Visible = True
                trkKriteria3Alternatif1Alternatif4.Visible = True
                trkKriteria3Alternatif2Alternatif4.Visible = True
                lblKriteria3Alternatif2Alternatif4.Visible = True
                lblKriteria3Alternatif3Alternatif4.Visible = True
                trkKriteria3Alternatif3Alternatif4.Visible = True
                lblKriteria3Alternatif3.Visible = True

                'kriteria4

                'kriteria4
                trkKriteria4Alternatif1Alternatif4.Visible = True
                trkKriteria4Alternatif2Alternatif4.Visible = True
                trkKriteria4Alternatif3Alternatif4.Visible = True

                lblKriteria4Alternatif1Alternatif4.Visible = True
                lblKriteria4Alternatif2Alternatif4.Visible = True
                lblKriteria4Alternatif3Alternatif4.Visible = True
                lblKriteria4Alternatif3.Visible = True

                lblKriteria4Alternatif4Alternatif5.Visible = True
                lblKriteria4Alternatif1Alternatif5.Visible = True
                lblKriteria4Alternatif2Alternatif5.Visible = True
                lblKriteria4Alternatif3Alternatif5.Visible = True
                lblKriteria4Alternatif4Alternatif5.Visible = True
                lblKriteria4Alternatif1Alternatif5.Visible = True
                lblKriteria4Alternatif4.Visible = True

                trkKriteria4Alternatif1Alternatif5.Visible = True
                trkKriteria4Alternatif2Alternatif5.Visible = True
                trkKriteria4Alternatif3Alternatif5.Visible = True
                trkKriteria4Alternatif4Alternatif5.Visible = True
                trkKriteria4Alternatif1Alternatif4.Visible = True
                trkKriteria4Alternatif2Alternatif4.Visible = True
                lblKriteria4Alternatif2Alternatif4.Visible = True
                lblKriteria4Alternatif3Alternatif4.Visible = True
                trkKriteria4Alternatif3Alternatif4.Visible = True
                lblKriteria4Alternatif3.Visible = True

                'kriteria5

                lblKriteria5Alternatif4Alternatif5.Visible = True
                lblKriteria5Alternatif1Alternatif5.Visible = True
                lblKriteria5Alternatif2Alternatif5.Visible = True
                lblKriteria5Alternatif3Alternatif5.Visible = True
                lblKriteria5Alternatif4Alternatif5.Visible = True
                lblKriteria5Alternatif1Alternatif5.Visible = True
                lblKriteria5Alternatif4.Visible = True

                trkKriteria5Alternatif1Alternatif5.Visible = True
                trkKriteria5Alternatif2Alternatif5.Visible = True
                trkKriteria5Alternatif3Alternatif5.Visible = True
                trkKriteria5Alternatif4Alternatif5.Visible = True
                trkKriteria5Alternatif1Alternatif4.Visible = True
                trkKriteria5Alternatif2Alternatif4.Visible = True
                lblKriteria5Alternatif2Alternatif4.Visible = True
                lblKriteria5Alternatif3Alternatif4.Visible = True
                trkKriteria5Alternatif3Alternatif4.Visible = True
                lblKriteria5Alternatif3.Visible = True
                lblKriteria5Alternatif1Alternatif4.Visible = True
        End Select
        'cbokriteria1.Focus()
    End Sub
    Private Sub updnJumlahAlternatif_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updnJumlahAlternatif.ValueChanged

        prosesAhpModel()
    End Sub
    Private Sub cekKesamaan()
        If cboKriteria1.Text <> "" And cboKriteria2.Text <> "" And cboKriteria3.Text <> "" And cboKriteria4.Text <> "" And cboKriteria5.Text <> "" Then
            If updnJumlahKriteria.Value = 5 Then
                If cboKriteria1.Text = cboKriteria2.Text Or cboKriteria1.Text = cboKriteria3.Text Or cboKriteria1.Text = cboKriteria4.Text Or cboKriteria1.Text = cboKriteria5.Text Or _
                    cboKriteria2.Text = cboKriteria3.Text Or cboKriteria2.Text = cboKriteria4.Text Or cboKriteria2.Text = cboKriteria5.Text Or _
                    cboKriteria3.Text = cboKriteria4.Text Or cboKriteria3.Text = cboKriteria5.Text Or _
                     cboKriteria4.Text = cboKriteria5.Text Then
                    MessageBox.Show("Ada kesamaan kriteria, mohon perbaiki input Anda", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            If updnJumlahKriteria.Value = 4 Then
                If cboKriteria1.Text = cboKriteria2.Text Or cboKriteria1.Text = cboKriteria3.Text Or cboKriteria1.Text = cboKriteria4.Text Or _
                    cboKriteria2.Text = cboKriteria3.Text Or cboKriteria2.Text = cboKriteria4.Text Or _
                    cboKriteria3.Text = cboKriteria4.Text Then
                    MessageBox.Show("Ada kesamaan kriteria, mohon perbaiki input Anda", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            If updnJumlahKriteria.Value = 3 Then
                If cboKriteria1.Text = cboKriteria2.Text Or cboKriteria1.Text = cboKriteria3.Text Or _
                    cboKriteria2.Text = cboKriteria3.Text Then
                    MessageBox.Show("Ada kesamaan kriteria, mohon perbaiki input Anda", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

        End If


        If cboAlternatif1.Text <> "" And cboAlternatif2.Text <> "" And cboAlternatif3.Text <> "" And cboAlternatif4.Text <> "" And cboAlternatif5.Text <> "" Then
            If updnJumlahAlternatif.Value = 5 Then
                If cboAlternatif1.Text = cboAlternatif2.Text Or cboAlternatif1.Text = cboAlternatif3.Text Or cboAlternatif1.Text = cboAlternatif4.Text Or cboAlternatif1.Text = cboAlternatif5.Text Or _
                    cboAlternatif2.Text = cboAlternatif3.Text Or cboAlternatif2.Text = cboAlternatif4.Text Or cboAlternatif2.Text = cboAlternatif5.Text Or _
                    cboAlternatif3.Text = cboAlternatif4.Text Or cboAlternatif3.Text = cboAlternatif5.Text Or _
                     cboAlternatif4.Text = cboAlternatif5.Text Then
                    MessageBox.Show("Ada kesamaan alternatif, mohon perbaiki input Anda", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            If updnJumlahAlternatif.Value = 4 Then
                If cboAlternatif1.Text = cboAlternatif2.Text Or cboAlternatif1.Text = cboAlternatif3.Text Or cboAlternatif1.Text = cboAlternatif4.Text Or _
                    cboAlternatif2.Text = cboAlternatif3.Text Or cboAlternatif2.Text = cboAlternatif4.Text Or _
                    cboAlternatif3.Text = cboAlternatif4.Text Then
                    MessageBox.Show("Ada kesamaan alternatif, mohon perbaiki input Anda", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            If updnJumlahAlternatif.Value = 3 Then
                If cboAlternatif1.Text = cboAlternatif2.Text Or cboAlternatif1.Text = cboAlternatif3.Text Or _
                    cboAlternatif2.Text = cboAlternatif3.Text Then
                    MessageBox.Show("Ada kesamaan alternatif, mohon perbaiki input Anda", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If

    End Sub
    Public Sub prosesAhpModel()

        validateIt()

        cekKesamaan()

        trckKriteria1Kriteria4.Visible = False
        trckKriteria1Kriteria5.Visible = False

        trckKriteria2Kriteria4.Visible = False
        trckKriteria2Kriteria5.Visible = False

        trckKriteria3Kriteria4.Visible = False
        trckKriteria3Kriteria5.Visible = False

        trckKriteria4Kriteria5.Visible = False

        lblKriteria1Kriteria4.Visible = False
        lblKriteria1Kriteria5.Visible = False

        lblKriteria2Kriteria4.Visible = False
        lblKriteria2Kriteria5.Visible = False

        lblKriteria3.Visible = False
        lblKriteria3Kriteria4.Visible = False
        lblKriteria3Kriteria5.Visible = False

        lblKriteria4.Visible = False
        lblKriteria4Kriteria5.Visible = False


        tabCtlAlternatif.SizeMode = TabSizeMode.Normal
        tabCtlAlternatif.TabPages.Remove(tabKriteria5)
        tabCtlAlternatif.TabPages.Remove(tabKriteria4)
        Select Case updnJumlahKriteria.Value
            Case 4
                trckKriteria1Kriteria4.Visible = True
                trckKriteria2Kriteria4.Visible = True
                trckKriteria3Kriteria4.Visible = True

                lblKriteria3.Visible = True
                lblKriteria1Kriteria4.Visible = True
                lblKriteria2Kriteria4.Visible = True
                lblKriteria3Kriteria4.Visible = True

                tabCtlAlternatif.TabPages.Add(tabKriteria4)
            Case 5
                trckKriteria1Kriteria4.Visible = True
                trckKriteria2Kriteria4.Visible = True
                trckKriteria3Kriteria4.Visible = True

                trckKriteria1Kriteria5.Visible = True
                trckKriteria2Kriteria5.Visible = True
                trckKriteria3Kriteria5.Visible = True
                trckKriteria4Kriteria5.Visible = True

                lblKriteria1Kriteria4.Visible = True
                lblKriteria2Kriteria4.Visible = True
                lblKriteria3.Visible = True
                lblKriteria3Kriteria4.Visible = True

                lblKriteria1Kriteria5.Visible = True
                lblKriteria2Kriteria5.Visible = True
                lblKriteria3Kriteria5.Visible = True
                lblKriteria4.Visible = True
                lblKriteria4Kriteria5.Visible = True

                tabCtlAlternatif.TabPages.Add(tabKriteria4)
                tabCtlAlternatif.TabPages.Add(tabKriteria5)
        End Select

        'pair kriteria
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria2, 0, 1)
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria3, 0, 2)
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria4, 0, 3)
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria5, 0, 4)
        Module1.pair(MatrixKriteria, trckKriteria2Kriteria3, 1, 2)
        Module1.pair(MatrixKriteria, trckKriteria2Kriteria4, 1, 3)
        Module1.pair(MatrixKriteria, trckKriteria2Kriteria5, 1, 4)
        Module1.pair(MatrixKriteria, trckKriteria3Kriteria4, 2, 3)
        Module1.pair(MatrixKriteria, trckKriteria3Kriteria5, 2, 4)
        Module1.pair(MatrixKriteria, trckKriteria4Kriteria5, 2, 4)

        'pair alternatif pada kriteria1
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif2, 0, 1)
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif3, 0, 2)
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif4, 0, 3)
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif5, 0, 4)

        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif2Alternatif3, 1, 2)
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif2Alternatif4, 1, 3)
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif2Alternatif5, 1, 4)

        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif3Alternatif4, 2, 3)
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif3Alternatif5, 2, 4)

        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif4Alternatif5, 3, 4)

        'pair alternatif pada kriteria2
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif2, 0, 1)
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif3, 0, 2)
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif4, 0, 3)
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif5, 0, 4)

        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif2Alternatif3, 1, 2)
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif2Alternatif4, 1, 3)
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif2Alternatif5, 1, 4)

        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif3Alternatif4, 2, 3)
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif3Alternatif5, 2, 4)

        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif4Alternatif5, 3, 4)

        'pair alternatif pada kriteria3
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif2, 0, 1)
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif3, 0, 2)
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif4, 0, 3)
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif5, 0, 4)

        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif2Alternatif3, 1, 2)
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif2Alternatif4, 1, 3)
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif2Alternatif5, 1, 4)

        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif3Alternatif4, 2, 3)
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif3Alternatif5, 2, 4)

        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif4Alternatif5, 3, 4)

        'pair alternatif pada kriteria4
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif2, 0, 1)
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif3, 0, 2)
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif4, 0, 3)
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif5, 0, 4)

        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif2Alternatif3, 1, 2)
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif2Alternatif4, 1, 3)
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif2Alternatif5, 1, 4)

        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif3Alternatif4, 2, 3)
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif3Alternatif5, 2, 4)

        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif4Alternatif5, 3, 4)

        'pair alternatif pada kriteria5
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif2, 0, 1)
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif3, 0, 2)
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif4, 0, 3)
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif5, 0, 4)

        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif2Alternatif3, 1, 2)
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif2Alternatif4, 1, 3)
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif2Alternatif5, 1, 4)

        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif3Alternatif4, 2, 3)
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif3Alternatif5, 2, 4)

        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif4Alternatif5, 3, 4)


        'mulai kalkulasi untuk mencari  bobot

        Module1.totalKolom(MatrixKriteriaTotalKolom, MatrixKriteria, updnJumlahKriteria.Value - 1)
        Module1.totalKolom(MatrixKriteria1AlternatifTotalKolom, MatrixKriteria1Alternatif, updnJumlahAlternatif.Value - 1)
        Module1.totalKolom(MatrixKriteria2AlternatifTotalKolom, MatrixKriteria2Alternatif, updnJumlahAlternatif.Value - 1)
        Module1.totalKolom(MatrixKriteria3AlternatifTotalKolom, MatrixKriteria3Alternatif, updnJumlahAlternatif.Value - 1)

        Module1.totalKolom(MatrixKriteria4AlternatifTotalKolom, MatrixKriteria4Alternatif, updnJumlahAlternatif.Value - 1)
        Module1.totalKolom(MatrixKriteria5AlternatifTotalKolom, MatrixKriteria5Alternatif, updnJumlahAlternatif.Value - 1)

        Module1.printKolom(MatrixKriteria4AlternatifTotalKolom, 4, txtDump)

        Module1.hitungValue(MatrixKriteriaValue, MatrixKriteria, MatrixKriteriaTotalKolom, updnJumlahKriteria.Value - 1)
        Module1.hitungValue(MatrixKriteria1AlternatifValue, MatrixKriteria1Alternatif, MatrixKriteria1AlternatifTotalKolom, updnJumlahAlternatif.Value - 1)
        Module1.hitungValue(MatrixKriteria2AlternatifValue, MatrixKriteria2Alternatif, MatrixKriteria2AlternatifTotalKolom, updnJumlahAlternatif.Value - 1)
        Module1.hitungValue(MatrixKriteria3AlternatifValue, MatrixKriteria3Alternatif, MatrixKriteria3AlternatifTotalKolom, updnJumlahAlternatif.Value - 1)
        Module1.hitungValue(MatrixKriteria4AlternatifValue, MatrixKriteria4Alternatif, MatrixKriteria4AlternatifTotalKolom, updnJumlahAlternatif.Value - 1)
        Module1.hitungValue(MatrixKriteria5AlternatifValue, MatrixKriteria5Alternatif, MatrixKriteria5AlternatifTotalKolom, updnJumlahAlternatif.Value - 1)

        Module1.totalBaris(MatrixKriteriaTotalBaris, MatrixKriteriaValue, updnJumlahKriteria.Value - 1)
        Module1.totalBaris(MatrixKriteria1AlternatifTotalBaris, MatrixKriteria1AlternatifValue, updnJumlahAlternatif.Value - 1)
        Module1.totalBaris(MatrixKriteria2AlternatifTotalBaris, MatrixKriteria2AlternatifValue, updnJumlahAlternatif.Value - 1)
        Module1.totalBaris(MatrixKriteria3AlternatifTotalBaris, MatrixKriteria3AlternatifValue, updnJumlahAlternatif.Value - 1)
        Module1.totalBaris(MatrixKriteria4AlternatifTotalBaris, MatrixKriteria4AlternatifValue, updnJumlahAlternatif.Value - 1)
        Module1.totalBaris(MatrixKriteria5AlternatifTotalBaris, MatrixKriteria5AlternatifValue, updnJumlahAlternatif.Value - 1)


        Module1.printKolom(MatrixKriteria4AlternatifTotalBaris, 4, txtDump)

        Module1.bobot(MatrixKriteriaBobot, MatrixKriteriaTotalBaris, updnJumlahKriteria.Value - 1)
        Module1.bobot(MatrixKriteria1AlternatifBobot, MatrixKriteria1AlternatifTotalBaris, updnJumlahAlternatif.Value - 1)
        Module1.bobot(MatrixKriteria2AlternatifBobot, MatrixKriteria2AlternatifTotalBaris, updnJumlahAlternatif.Value - 1)
        Module1.bobot(MatrixKriteria3AlternatifBobot, MatrixKriteria3AlternatifTotalBaris, updnJumlahAlternatif.Value - 1)
        Module1.bobot(MatrixKriteria4AlternatifBobot, MatrixKriteria4AlternatifTotalBaris, updnJumlahAlternatif.Value - 1)
        Module1.bobot(MatrixKriteria5AlternatifBobot, MatrixKriteria5AlternatifTotalBaris, updnJumlahAlternatif.Value - 1)
        Module1.printKolom(MatrixKriteria4AlternatifBobot, 4, txtDump)




        ScoreAkhirAlternatif(0) = _
                                MatrixKriteria1AlternatifBobot(0) * MatrixKriteriaBobot(0) + _
                                MatrixKriteria2AlternatifBobot(0) * MatrixKriteriaBobot(1) + _
                                 MatrixKriteria3AlternatifBobot(0) * MatrixKriteriaBobot(2) + _
                                  MatrixKriteria4AlternatifBobot(0) * MatrixKriteriaBobot(3) + _
                                   MatrixKriteria5AlternatifBobot(0) * MatrixKriteriaBobot(4)
        ScoreAkhirAlternatif(1) = _
                                        MatrixKriteria1AlternatifBobot(1) * MatrixKriteriaBobot(0) + _
                                        MatrixKriteria2AlternatifBobot(1) * MatrixKriteriaBobot(1) + _
                                         MatrixKriteria3AlternatifBobot(1) * MatrixKriteriaBobot(2) + _
                                          MatrixKriteria4AlternatifBobot(1) * MatrixKriteriaBobot(3) + _
                                           MatrixKriteria5AlternatifBobot(1) * MatrixKriteriaBobot(4)
        ScoreAkhirAlternatif(2) = _
                                        MatrixKriteria1AlternatifBobot(2) * MatrixKriteriaBobot(0) + _
                                        MatrixKriteria2AlternatifBobot(2) * MatrixKriteriaBobot(1) + _
                                         MatrixKriteria3AlternatifBobot(2) * MatrixKriteriaBobot(2) + _
                                          MatrixKriteria4AlternatifBobot(2) * MatrixKriteriaBobot(3) + _
                                           MatrixKriteria5AlternatifBobot(2) * MatrixKriteriaBobot(4)
        ScoreAkhirAlternatif(3) = _
                                        MatrixKriteria1AlternatifBobot(3) * MatrixKriteriaBobot(0) + _
                                        MatrixKriteria2AlternatifBobot(3) * MatrixKriteriaBobot(1) + _
                                         MatrixKriteria3AlternatifBobot(3) * MatrixKriteriaBobot(2) + _
                                          MatrixKriteria4AlternatifBobot(3) * MatrixKriteriaBobot(3) + _
                                           MatrixKriteria5AlternatifBobot(3) * MatrixKriteriaBobot(4)
        ScoreAkhirAlternatif(4) = _
                                        MatrixKriteria1AlternatifBobot(4) * MatrixKriteriaBobot(0) + _
                                        MatrixKriteria2AlternatifBobot(4) * MatrixKriteriaBobot(1) + _
                                         MatrixKriteria3AlternatifBobot(4) * MatrixKriteriaBobot(2) + _
                                          MatrixKriteria4AlternatifBobot(4) * MatrixKriteriaBobot(3) + _
                                           MatrixKriteria5AlternatifBobot(4) * MatrixKriteriaBobot(4)


        Dim alternatifTerbaik As Single
        Dim iAlternatifTerbaik As Integer
        alternatifTerbaik = max(ScoreAkhirAlternatif, 4, iAlternatifTerbaik)
        Module1.printKolom(ScoreAkhirAlternatif, 4, txtDump)

        'DisplayMatrix.Show()
        'DisplayMatrix.ShowArray(MatrixKriteria4AlternatifValue, updnJumlahAlternatif.Value - 1)

        For i = 0 To updnJumlahKriteria.Value - 1
            For j = 0 To updnJumlahKriteria.Value - 1
                MatrixKriteriaForConsistency(i, j) = MatrixKriteria(i, j) * MatrixKriteriaBobot(j)
            Next
        Next

        totalBaris(MatrixKriteriaForConsistencyTotalBaris, MatrixKriteriaForConsistency, updnJumlahKriteria.Value - 1)


        For i = 0 To updnJumlahKriteria.Value - 1
            MatrixKriteriaForConsistencyTotalBarisLambda(i) = MatrixKriteriaForConsistencyTotalBaris(i) / MatrixKriteriaBobot(i)
        Next

        Dim lambdaMax As Single
        Dim iLambdaMax As Integer
        lambdaMax = max(MatrixKriteriaForConsistencyTotalBarisLambda, updnJumlahKriteria.Value - 1, iLambdaMax)
        Dim ci As Single
        ci = (lambdaMax - updnJumlahKriteria.Value) / (updnJumlahKriteria.Value - 1)
        Dim CR As Single
        If (updnJumlahKriteria.Value) >= 3 Then CR = ci / MatrixRI(updnJumlahKriteria.Value - 1)

        If (CR <= 0.1) Then
            lblCI.Text = "Perbandingan Kriteria Konsisten, karena nilai Konsistensi Indeks lebih kecil atau sama dengan 0.1 yaitu sebesar " & CR
        Else
            lblCI.Text = "Perbandingan Kriteria Tidak Konsisten, karena nilai Konsistensi Indeks lebih besar dari 0.1 yaitu sebesar " & CR
        End If

        Dim strAlternatifTerbaik As String
        strAlternatifTerbaik = ""
        Select Case iAlternatifTerbaik
            Case 0
                strAlternatifTerbaik = cboAlternatif1.Text
            Case 1
                strAlternatifTerbaik = cboAlternatif2.Text
            Case 2
                strAlternatifTerbaik = cboAlternatif3.Text
            Case 3
                strAlternatifTerbaik = cboAlternatif4.Text
            Case 4
                strAlternatifTerbaik = cboAlternatif5.Text
        End Select
        lblAlternatifTerbaik.Text = "Alternatif terbaik adalah " & strAlternatifTerbaik & " dengan skor akhir " & ScoreAkhirAlternatif(iAlternatifTerbaik)
        printKolom(ScoreAkhirAlternatif, updnJumlahAlternatif.Value - 1, txtDump)
        printKolom(MatrixKriteriaForConsistencyTotalBaris, updnJumlahKriteria.Value - 1, txtDump)
        printKolom(MatrixKriteriaForConsistencyTotalBarisLambda, updnJumlahKriteria.Value - 1, txtDump)

        displayGrafik()
    End Sub

    Private Sub displayGrafik()
        On Error GoTo err1
        With AxMSChart1
            .Row = 1
            .RowLabel = txtTitle.Text

            .ColumnCount = updnJumlahAlternatif.Value
            .Column = 1
            .ColumnLabel = cboAlternatif1.Text
            .Data = ScoreAkhirAlternatif(0) * 100

            .Column = 2
            .ColumnLabel = cboAlternatif2.Text
            .Data = ScoreAkhirAlternatif(1) * 100

            .Column = 3
            .ColumnLabel = cboAlternatif3.Text
            .Data = ScoreAkhirAlternatif(2) * 100

            .Column = 4
            .ColumnLabel = cboAlternatif4.Text
            .Data = ScoreAkhirAlternatif(3) * 100

            .Column = 5
            .ColumnLabel = cboAlternatif5.Text
            .Data = ScoreAkhirAlternatif(4) * 100

        End With
        Exit Sub
err1:
        'MessageBox.Show(Err.Description & Err.Erl)
    End Sub

    Private Sub FormUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        identity(MatrixKriteria, 4)
        identity(MatrixKriteria1Alternatif, 4)
        identity(MatrixKriteria2Alternatif, 4)
        identity(MatrixKriteria3Alternatif, 4)
        identity(MatrixKriteria4Alternatif, 4)
        identity(MatrixKriteria5Alternatif, 4)
        prosesAhpModel()
        'xFormInfoPreferensi.Show()
    End Sub

    Private Sub trckKriteria1Kriteria2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria1Kriteria2.Scroll
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria2, 0, 1)
        'xFormInfoPreferensi.info(trckKriteria1Kriteria2.Value)

        prosesAhpModel()
    End Sub

    Private Sub lblNilai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNilai.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria, updnJumlahKriteria.Value - 1)
    End Sub

    Private Sub trckKriteria1Kriteria3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria1Kriteria3.Scroll
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria3, 0, 2)
        'xFormInfoPreferensi.info(trckKriteria1Kriteria3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria1Kriteria4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria1Kriteria4.Scroll
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria4, 0, 3)
        'xFormInfoPreferensi.info(trckKriteria1Kriteria4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria1Kriteria5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria1Kriteria5.Scroll
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria5, 0, 4)
        'xFormInfoPreferensi.info(trckKriteria1Kriteria5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria2Kriteria3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria2Kriteria3.Scroll
        Module1.pair(MatrixKriteria, trckKriteria2Kriteria3, 1, 2)
        'xFormInfoPreferensi.info(trckKriteria2Kriteria3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria2Kriteria4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria2Kriteria4.Scroll
        Module1.pair(MatrixKriteria, trckKriteria2Kriteria4, 1, 3)
        'xFormInfoPreferensi.info(trckKriteria2Kriteria4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria2Kriteria5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria2Kriteria5.Scroll
        Module1.pair(MatrixKriteria, trckKriteria2Kriteria5, 1, 4)
        'xFormInfoPreferensi.info(trckKriteria2Kriteria5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria3Kriteria4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria3Kriteria4.Scroll
        Module1.pair(MatrixKriteria, trckKriteria3Kriteria4, 2, 3)
        'xFormInfoPreferensi.info(trckKriteria3Kriteria4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria3Kriteria5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria3Kriteria5.Scroll
        Module1.pair(MatrixKriteria, trckKriteria3Kriteria5, 2, 4)
        'xFormInfoPreferensi.info(trckKriteria3Kriteria5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trckKriteria4Kriteria5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria4Kriteria5.Scroll
        Module1.pair(MatrixKriteria, trckKriteria4Kriteria5, 3, 4) ' 2, 4)
        'xFormInfoPreferensi.info(trckKriteria4Kriteria5.Value)
        prosesAhpModel()
    End Sub


    Private Sub trkKriteria1Alternatif1Alternatif2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif1Alternatif2.Scroll

        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif2, 0, 1)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif1Alternatif2.Value)
        prosesAhpModel()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria1Alternatif, updnJumlahAlternatif.Value - 1)
    End Sub

    Private Sub trkKriteria1Alternatif1Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif1Alternatif3.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif3, 0, 2)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif1Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif1Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif1Alternatif4.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif4, 0, 3)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif1Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif1Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif1Alternatif5.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif1Alternatif5, 0, 4)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif1Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif2Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif2Alternatif3.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif2Alternatif3, 1, 2)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif2Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif2Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif2Alternatif4.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif2Alternatif4, 1, 3)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif2Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif2Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif2Alternatif5.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif2Alternatif5, 1, 4)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif2Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif3Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif3Alternatif4.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif3Alternatif4, 2, 3)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif3Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif3Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif3Alternatif5.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif3Alternatif5, 2, 4)
        'xFormInfoPreferensi.info(trkKriteria1Alternatif3Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria1Alternatif4Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria1Alternatif4Alternatif5.Scroll
        Module1.pair(MatrixKriteria1Alternatif, trkKriteria1Alternatif4Alternatif5, 3, 4)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif1Alternatif2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif1Alternatif2.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif2, 0, 1)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif1Alternatif2.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif1Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif1Alternatif3.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif3, 0, 2)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif1Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif1Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif1Alternatif4.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif4, 0, 3)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif1Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif1Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif1Alternatif5.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif1Alternatif5, 0, 4)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif1Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif2Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif2Alternatif3.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif2Alternatif3, 1, 2)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif2Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif2Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif2Alternatif4.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif2Alternatif4, 1, 3)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif2Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif2Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif2Alternatif5.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif2Alternatif5, 1, 4)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif2Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif3Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif3Alternatif4.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif3Alternatif4, 2, 3)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif3Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif3Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif3Alternatif5.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif3Alternatif5, 2, 3)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif3Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria2Alternatif4Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria2Alternatif4Alternatif5.Scroll
        Module1.pair(MatrixKriteria2Alternatif, trkKriteria2Alternatif4Alternatif5, 2, 4)
        'xFormInfoPreferensi.info(trkKriteria2Alternatif4Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria2Alternatif, updnJumlahAlternatif.Value - 1)
    End Sub

    Private Sub trkKriteria3Alternatif1Alternatif2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif1Alternatif2.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif2, 0, 1)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif1Alternatif2.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif1Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif1Alternatif3.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif3, 0, 2)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif1Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif1Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif1Alternatif4.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif4, 0, 3)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif1Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif1Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif1Alternatif5.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif1Alternatif5, 0, 4)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif1Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif2Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif2Alternatif3.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif2Alternatif3, 1, 2)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif2Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif2Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif2Alternatif4.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif2Alternatif4, 1, 3)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif2Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif2Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif2Alternatif5.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif2Alternatif5, 1, 4)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif2Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif3Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif3Alternatif4.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif3Alternatif4, 2, 3)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif3Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif3Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif3Alternatif5.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif3Alternatif5, 2, 4)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif3Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria3Alternatif4Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria3Alternatif4Alternatif5.Scroll
        Module1.pair(MatrixKriteria3Alternatif, trkKriteria3Alternatif4Alternatif5, 3, 4)
        'xFormInfoPreferensi.info(trkKriteria3Alternatif4Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria3Alternatif, updnJumlahAlternatif.Value - 1)
    End Sub

    Private Sub trkKriteria4Alternatif1Alternatif2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif1Alternatif2.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif2, 0, 1)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif1Alternatif2.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif1Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif1Alternatif3.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif3, 0, 2)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif1Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif1Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif1Alternatif4.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif4, 0, 3)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif1Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif1Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif1Alternatif5.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif1Alternatif5, 0, 4)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif1Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif2Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif2Alternatif3.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif2Alternatif3, 1, 2)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif2Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif2Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif2Alternatif4.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif2Alternatif4, 1, 3)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif2Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif2Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif2Alternatif5.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif2Alternatif5, 1, 4)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif2Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif3Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif3Alternatif4.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif3Alternatif4, 2, 3)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif3Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif3Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif3Alternatif5.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif3Alternatif5, 2, 4)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif3Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria4Alternatif4Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria4Alternatif4Alternatif5.Scroll
        Module1.pair(MatrixKriteria4Alternatif, trkKriteria4Alternatif4Alternatif5, 3, 4)
        'xFormInfoPreferensi.info(trkKriteria4Alternatif4Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif1Alternatif2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif1Alternatif2.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif2, 0, 1)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif1Alternatif2.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif1Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif1Alternatif3.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif3, 0, 2)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif1Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif1Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif1Alternatif4.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif4, 0, 3)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif1Alternatif4.Value)

        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif1Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif1Alternatif5.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif1Alternatif5, 0, 4)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif1Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif2Alternatif3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif2Alternatif3.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif2Alternatif3, 1, 2)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif2Alternatif3.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif2Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif2Alternatif4.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif2Alternatif4, 1, 3)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif2Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif2Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif2Alternatif5.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif2Alternatif5, 1, 4)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif2Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif3Alternatif4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif3Alternatif4.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif3Alternatif4, 2, 3)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif3Alternatif4.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif3Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif3Alternatif5.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif3Alternatif5, 2, 4)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif3Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub trkKriteria5Alternatif4Alternatif5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkKriteria5Alternatif4Alternatif5.Scroll
        Module1.pair(MatrixKriteria5Alternatif, trkKriteria5Alternatif4Alternatif5, 3, 4)
        'xFormInfoPreferensi.info(trkKriteria5Alternatif4Alternatif5.Value)
        prosesAhpModel()
    End Sub

    Private Sub Label43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label43.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria5Alternatif, updnJumlahAlternatif.Value - 1)
    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria4Alternatif, updnJumlahAlternatif.Value - 1)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        prosesAhpModel()
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        prosesAhpModel()
    End Sub

    Private Sub txtDump_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDump.TextChanged

    End Sub

    Private Sub cbokriteria1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKriteria1.TextChanged
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKriteria2.TextChanged
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKriteria3.TextChanged
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKriteria4.TextChanged
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKriteria5.TextChanged
        prosesAhpModel()
    End Sub

    Private Sub cboAlternatif1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cboAlternatif2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cboAlternatif3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cboAlternatif4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cboAlternatif5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria, updnJumlahKriteria.Value - 1)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblAlternatifTerbaik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAlternatifTerbaik.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria, updnJumlahKriteria.Value - 1)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria1Alternatif, updnJumlahAlternatif.Value - 1)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria2Alternatif, updnJumlahAlternatif.Value - 1)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria3Alternatif, updnJumlahAlternatif.Value - 1)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria4Alternatif, updnJumlahAlternatif.Value - 1)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria5Alternatif, updnJumlahAlternatif.Value - 1)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.Save()

        My.Settings.Reload()
        prosesAhpModel()

    End Sub

    Private Sub cboKriteria1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKriteria1.SelectedIndexChanged

    End Sub
End Class
