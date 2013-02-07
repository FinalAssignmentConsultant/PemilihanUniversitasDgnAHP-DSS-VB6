Imports System.Data.OleDb

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

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormAdmin.ShowDialog()
    End Sub
    Private Sub btnAturAHP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPengaturan.ShowDialog()
    End Sub
    Private Sub updnJumlahKriteria_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        prosesAhpModel()
    End Sub
    Private Sub validateIt()


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


        Select Case chkAlternatif.CheckedItems.Count
            Case 3

            Case 4


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
    Private Sub updnJumlahAlternatif_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        prosesAhpModel()
    End Sub

    Public Sub prosesAhpModel()

        validateIt()


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

        Select Case chkKriteria.CheckedItems.Count
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
        Module1.pair(MatrixKriteria, trckKriteria4Kriteria5, 3, 4)

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
        'sholat jama;ah
        Module1.totalKolom(MatrixKriteriaTotalKolom, MatrixKriteria, chkKriteria.CheckedItems.Count - 1)
        Module1.totalKolom(MatrixKriteria1AlternatifTotalKolom, MatrixKriteria1Alternatif, chkAlternatif.CheckedItems.Count - 1)
        Module1.totalKolom(MatrixKriteria2AlternatifTotalKolom, MatrixKriteria2Alternatif, chkAlternatif.CheckedItems.Count - 1)
        Module1.totalKolom(MatrixKriteria3AlternatifTotalKolom, MatrixKriteria3Alternatif, chkAlternatif.CheckedItems.Count - 1)

        Module1.totalKolom(MatrixKriteria4AlternatifTotalKolom, MatrixKriteria4Alternatif, chkAlternatif.CheckedItems.Count - 1)
        Module1.totalKolom(MatrixKriteria5AlternatifTotalKolom, MatrixKriteria5Alternatif, chkAlternatif.CheckedItems.Count - 1)

        Module1.printKolom(MatrixKriteria4AlternatifTotalKolom, 4, txtDump)

        Module1.hitungValue(MatrixKriteriaValue, MatrixKriteria, MatrixKriteriaTotalKolom, chkKriteria.CheckedItems.Count - 1)
        Module1.hitungValue(MatrixKriteria1AlternatifValue, MatrixKriteria1Alternatif, MatrixKriteria1AlternatifTotalKolom, chkAlternatif.CheckedItems.Count - 1)
        Module1.hitungValue(MatrixKriteria2AlternatifValue, MatrixKriteria2Alternatif, MatrixKriteria2AlternatifTotalKolom, chkAlternatif.CheckedItems.Count - 1)
        Module1.hitungValue(MatrixKriteria3AlternatifValue, MatrixKriteria3Alternatif, MatrixKriteria3AlternatifTotalKolom, chkAlternatif.CheckedItems.Count - 1)
        Module1.hitungValue(MatrixKriteria4AlternatifValue, MatrixKriteria4Alternatif, MatrixKriteria4AlternatifTotalKolom, chkAlternatif.CheckedItems.Count - 1)
        Module1.hitungValue(MatrixKriteria5AlternatifValue, MatrixKriteria5Alternatif, MatrixKriteria5AlternatifTotalKolom, chkAlternatif.CheckedItems.Count - 1)

        Module1.totalBaris(MatrixKriteriaTotalBaris, MatrixKriteriaValue, chkKriteria.CheckedItems.Count - 1)
        Module1.totalBaris(MatrixKriteria1AlternatifTotalBaris, MatrixKriteria1AlternatifValue, chkAlternatif.CheckedItems.Count - 1)
        Module1.totalBaris(MatrixKriteria2AlternatifTotalBaris, MatrixKriteria2AlternatifValue, chkAlternatif.CheckedItems.Count - 1)
        Module1.totalBaris(MatrixKriteria3AlternatifTotalBaris, MatrixKriteria3AlternatifValue, chkAlternatif.CheckedItems.Count - 1)
        Module1.totalBaris(MatrixKriteria4AlternatifTotalBaris, MatrixKriteria4AlternatifValue, chkAlternatif.CheckedItems.Count - 1)
        Module1.totalBaris(MatrixKriteria5AlternatifTotalBaris, MatrixKriteria5AlternatifValue, chkAlternatif.CheckedItems.Count - 1)


        Module1.printKolom(MatrixKriteria4AlternatifTotalBaris, 4, txtDump)

        Module1.bobot(MatrixKriteriaBobot, MatrixKriteriaTotalBaris, chkKriteria.CheckedItems.Count - 1)
        Module1.bobot(MatrixKriteria1AlternatifBobot, MatrixKriteria1AlternatifTotalBaris, chkAlternatif.CheckedItems.Count - 1)
        Module1.bobot(MatrixKriteria2AlternatifBobot, MatrixKriteria2AlternatifTotalBaris, chkAlternatif.CheckedItems.Count - 1)
        Module1.bobot(MatrixKriteria3AlternatifBobot, MatrixKriteria3AlternatifTotalBaris, chkAlternatif.CheckedItems.Count - 1)
        Module1.bobot(MatrixKriteria4AlternatifBobot, MatrixKriteria4AlternatifTotalBaris, chkAlternatif.CheckedItems.Count - 1)
        Module1.bobot(MatrixKriteria5AlternatifBobot, MatrixKriteria5AlternatifTotalBaris, chkAlternatif.CheckedItems.Count - 1)
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
        'DisplayMatrix.ShowArray(MatrixKriteria4AlternatifValue, chkAlternatif.CheckedItems.Count - 1)

        For i = 0 To chkKriteria.CheckedItems.Count - 1
            For j = 0 To chkKriteria.CheckedItems.Count - 1
                MatrixKriteriaForConsistency(i, j) = MatrixKriteria(i, j) * MatrixKriteriaBobot(j)
            Next
        Next

        totalBaris(MatrixKriteriaForConsistencyTotalBaris, MatrixKriteriaForConsistency, chkKriteria.CheckedItems.Count - 1)


        For i = 0 To chkKriteria.CheckedItems.Count - 1
            MatrixKriteriaForConsistencyTotalBarisLambda(i) = MatrixKriteriaForConsistencyTotalBaris(i) / MatrixKriteriaBobot(i)
        Next

        Dim lambdaMax As Single
        Dim iLambdaMax As Integer
        lambdaMax = max(MatrixKriteriaForConsistencyTotalBarisLambda, chkKriteria.CheckedItems.Count - 1, iLambdaMax)
        Dim ci As Single
        ci = (lambdaMax - chkKriteria.CheckedItems.Count) / (chkKriteria.CheckedItems.Count - 1)
        Dim CR As Single
        If (chkKriteria.CheckedItems.Count) >= 3 Then CR = ci / MatrixRI(chkKriteria.CheckedItems.Count - 1)

        If (CR <= 0.1) Then
            lblCI.Text = "Perbandingan Kriteria Konsisten, karena nilai Konsistensi Indeks lebih kecil atau sama dengan 0.1 yaitu sebesar " & CR
        Else
            lblCI.Text = "Perbandingan Kriteria Tidak Konsisten, karena nilai Konsistensi Indeks lebih besar dari 0.1 yaitu sebesar " & CR
        End If

        Dim strAlternatifTerbaik As String
        strAlternatifTerbaik = ""
        Select Case iAlternatifTerbaik
            Case 0
                strAlternatifTerbaik = chkAlternatif.Items(0).ToString
            Case 1
                strAlternatifTerbaik = chkAlternatif.Items(1).ToString
            Case 2
                strAlternatifTerbaik = chkAlternatif.Items(2).ToString
            Case 3
                strAlternatifTerbaik = chkAlternatif.Items(3).ToString
            Case 4
                strAlternatifTerbaik = chkAlternatif.Items(4).ToString
            Case 5
                strAlternatifTerbaik = chkAlternatif.Items(5).ToString
            Case 6
                strAlternatifTerbaik = chkAlternatif.Items(6).ToString
        End Select
        lblAlternatifTerbaik.Text = "Alternatif terbaik adalah " & strAlternatifTerbaik & " dengan skor akhir " & ScoreAkhirAlternatif(iAlternatifTerbaik)
        printKolom(ScoreAkhirAlternatif, chkAlternatif.CheckedItems.Count - 1, txtDump)
        printKolom(MatrixKriteriaForConsistencyTotalBaris, chkKriteria.CheckedItems.Count - 1, txtDump)
        printKolom(MatrixKriteriaForConsistencyTotalBarisLambda, chkKriteria.CheckedItems.Count - 1, txtDump)

        displayGrafik()
    End Sub

    Private Sub displayGrafik()
        On Error GoTo err1
        With AxMSChart1
            .Row = 1
            .RowLabel = Text

            .ColumnCount = chkAlternatif.CheckedItems.Count
            .Column = 1
            .ColumnLabel = chkAlternatif.CheckedItems(0).ToString
            .Data = ScoreAkhirAlternatif(0) * 100

            .Column = 2
            .ColumnLabel = chkAlternatif.CheckedItems(1).ToString
            .Data = ScoreAkhirAlternatif(1) * 100

            .Column = 3
            .ColumnLabel = chkAlternatif.CheckedItems(2).ToString
            .Data = ScoreAkhirAlternatif(2) * 100

            If chkAlternatif.CheckedItems.Count = 4 Then
                .Column = 4
                .ColumnLabel = chkAlternatif.CheckedItems(3).ToString
                .Data = ScoreAkhirAlternatif(3) * 100
            End If

            If chkAlternatif.CheckedItems.Count = 5 Then
                .Column = 4
                .ColumnLabel = chkAlternatif.CheckedItems(3).ToString
                .Data = ScoreAkhirAlternatif(3) * 100

                .Column = 5
                .ColumnLabel = chkAlternatif.CheckedItems(4).ToString
                .Data = ScoreAkhirAlternatif(4) * 100
            End If

        End With
        Exit Sub
err1:
        'MessageBox.Show(Err.Description & Err.Erl)
    End Sub

    Private Sub FormUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Module1.persiapkanAdmin(False)
        Module1.con.Open()
        loadToCheckedListbox(chkKriteria, "select kriteria from kriteria order by kriteria")
        loadToCheckedListbox(chkAlternatif, "select universitas from universitas order by universitas")

        'tabPageKriteria1 = True
        chkKriteria.SetItemChecked(0, True)
        chkKriteria.SetItemChecked(1, True)
        chkKriteria.SetItemChecked(2, True)

        chkAlternatif.SetItemChecked(0, True)
        chkAlternatif.SetItemChecked(1, True)
        chkAlternatif.SetItemChecked(2, True)

        identity(MatrixKriteria, 4)
        identity(MatrixKriteria1Alternatif, 4)
        identity(MatrixKriteria2Alternatif, 4)
        identity(MatrixKriteria3Alternatif, 4)
        identity(MatrixKriteria4Alternatif, 4)
        identity(MatrixKriteria5Alternatif, 4)
        prosesAhpModel()
        'xFormInfoPreferensi.Show()
        
    End Sub
    Private Sub loadToCheckedListbox(ByRef chk As CheckedListBox, ByVal txt As String)
        Dim cmd As New OleDbCommand(txt, con)
        Dim rdr As OleDbDataReader


        cmd.CommandType = CommandType.Text
        rdr = cmd.ExecuteReader()

        chk.Items.Clear()
        While rdr.Read
            chk.Items.Add(rdr.GetString(0))
        End While
    End Sub
    Private Sub trckKriteria1Kriteria2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckKriteria1Kriteria2.Scroll
        Module1.pair(MatrixKriteria, trckKriteria1Kriteria2, 0, 1)
        'xFormInfoPreferensi.info(trckKriteria1Kriteria2.Value)

        prosesAhpModel()
    End Sub

    Private Sub lblNilai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria, chkKriteria.CheckedItems.Count - 1)
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
        DisplayMatrix.ShowArray(MatrixKriteria1Alternatif, chkAlternatif.CheckedItems.Count - 1)
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
        DisplayMatrix.ShowArray(MatrixKriteria2Alternatif, chkAlternatif.CheckedItems.Count - 1)
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
        DisplayMatrix.ShowArray(MatrixKriteria3Alternatif, chkAlternatif.CheckedItems.Count - 1)
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
        DisplayMatrix.ShowArray(MatrixKriteria5Alternatif, chkAlternatif.CheckedItems.Count - 1)
    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria4Alternatif, chkAlternatif.CheckedItems.Count - 1)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        prosesAhpModel()
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub txtDump_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDump.TextChanged

    End Sub

    Private Sub cbokriteria1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prosesAhpModel()
    End Sub

    Private Sub cbokriteria5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria, chkKriteria.CheckedItems.Count - 1)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblAlternatifTerbaik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAlternatifTerbaik.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria, chkKriteria.CheckedItems.Count - 1)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria1Alternatif, chkAlternatif.CheckedItems.Count - 1)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria2Alternatif, chkAlternatif.CheckedItems.Count - 1)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria3Alternatif, chkAlternatif.CheckedItems.Count - 1)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria4Alternatif, chkAlternatif.CheckedItems.Count - 1)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DisplayMatrix.Show()
        DisplayMatrix.ShowArray(MatrixKriteria5Alternatif, chkAlternatif.CheckedItems.Count - 1)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If chkKriteria.CheckedItems.Count > 5 Or chkKriteria.CheckedItems.Count < 3 Then
            MsgBox("Maaf, Anda minimal harus memilih 3 kriteria dan maksimal 5 kriteria")
            Exit Sub
        End If

        If chkAlternatif.CheckedItems.Count > 5 Or chkAlternatif.CheckedItems.Count < 3 Then
            MsgBox("Maaf, Anda minimal harus memilih 3 Universitas dan maksimal 5 Universitas")
            Exit Sub
        End If

        My.Settings.kriteria1 = chkKriteria.CheckedItems(0).ToString
        My.Settings.kriteria2 = chkKriteria.CheckedItems(1).ToString
        My.Settings.kriteria3 = chkKriteria.CheckedItems(2).ToString

        

        If chkKriteria.CheckedItems.Count = 4 Then My.Settings.kriteria4 = chkKriteria.CheckedItems(3).ToString
        If chkKriteria.CheckedItems.Count = 5 Then
            My.Settings.kriteria4 = chkKriteria.CheckedItems(3).ToString
            My.Settings.kriteria5 = chkKriteria.CheckedItems(4).ToString
        End If
        'My.Settings.kriteria5 = chkKriteria.CheckedItems(4).ToString

        My.Settings.alternatif1 = chkAlternatif.CheckedItems(0).ToString
        My.Settings.alternatif2 = chkAlternatif.CheckedItems(1).ToString
        My.Settings.alternatif3 = chkAlternatif.CheckedItems(2).ToString

        If chkAlternatif.CheckedItems.Count = 4 Then My.Settings.alternatif4 = chkAlternatif.CheckedItems(3).ToString
        If chkAlternatif.CheckedItems.Count = 5 Then
            My.Settings.alternatif4 = chkAlternatif.CheckedItems(3).ToString
            My.Settings.alternatif5 = chkAlternatif.CheckedItems(4).ToString
        End If



        'My.Settings.Save()
        'My.Settings.Reload()

        'pmberian nilai default
        'kriteria1
        pemberianNilaiDariDatabase(My.Settings.kriteria1, My.Settings.alternatif1, My.Settings.alternatif2, trkKriteria1Alternatif1Alternatif2)
        pemberianNilaiDariDatabase(My.Settings.kriteria1, My.Settings.alternatif1, My.Settings.alternatif3, trkKriteria1Alternatif1Alternatif3)
        pemberianNilaiDariDatabase(My.Settings.kriteria1, My.Settings.alternatif2, My.Settings.alternatif3, trkKriteria1Alternatif2Alternatif3)

        'kriteria2
        pemberianNilaiDariDatabase(My.Settings.kriteria2, My.Settings.alternatif1, My.Settings.alternatif2, trkKriteria2Alternatif1Alternatif2)
        pemberianNilaiDariDatabase(My.Settings.kriteria2, My.Settings.alternatif1, My.Settings.alternatif3, trkKriteria2Alternatif1Alternatif3)
        pemberianNilaiDariDatabase(My.Settings.kriteria2, My.Settings.alternatif2, My.Settings.alternatif3, trkKriteria2Alternatif2Alternatif3)

        'kriteria3
        pemberianNilaiDariDatabase(My.Settings.kriteria3, My.Settings.alternatif1, My.Settings.alternatif2, trkKriteria3Alternatif1Alternatif2)
        pemberianNilaiDariDatabase(My.Settings.kriteria3, My.Settings.alternatif1, My.Settings.alternatif3, trkKriteria3Alternatif1Alternatif3)
        pemberianNilaiDariDatabase(My.Settings.kriteria3, My.Settings.alternatif2, My.Settings.alternatif3, trkKriteria3Alternatif2Alternatif3)

        'My.Settings.Save()
        prosesAhpModel()

    End Sub
    Private Sub pemberianNilaiDariDatabase(ByVal kriteria As String, ByVal universitas1 As String, ByVal universitas2 As String, ByRef trk As TrackBar)
        Dim cmd As New OleDbCommand()
        Dim rdr As OleDbDataReader
        Dim rdr2 As OleDbDataReader


        cmd.CommandText = "SELECT UniversitasPadaKriteria.Nilai " & _
        " FROM Universitas INNER JOIN (Universitas AS Universitas_1 INNER JOIN (Kriteria INNER JOIN UniversitasPadaKriteria ON Kriteria.ID = UniversitasPadaKriteria.Kriteria) ON Universitas_1.ID = UniversitasPadaKriteria.UniversitasB) ON Universitas.ID = UniversitasPadaKriteria.UniversitasA " & _
        " WHERE (((Kriteria.Kriteria)='" & kriteria & "') AND ((Universitas_1.Universitas)='" & universitas1 & "') AND ((Universitas.Universitas)='" & universitas2 & "'))"
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        rdr = cmd.ExecuteReader()


        If rdr.Read() Then
            'trk.BackColor = Color. 
            trk.Value = rdr.GetValue(0) 'trk
        Else
            'MsgBox("ini tak ada " & cmd.CommandText)
            Dim cmd2 As New OleDbCommand
            cmd2.CommandText = "SELECT  UniversitasPadaKriteria.Nilai " & _
       " FROM Universitas INNER JOIN (Universitas AS Universitas_1 INNER JOIN (Kriteria INNER JOIN UniversitasPadaKriteria ON Kriteria.ID = UniversitasPadaKriteria.Kriteria) ON Universitas_1.ID = UniversitasPadaKriteria.UniversitasB) ON Universitas.ID = UniversitasPadaKriteria.UniversitasA " & _
       " WHERE (((Kriteria.Kriteria)='" & kriteria & "') AND ((Universitas_1.Universitas)='" & universitas2 & "') AND ((Universitas.Universitas)='" & universitas1 & "'))"
            cmd2.Connection = con
            cmd2.CommandType = CommandType.Text

            rdr2 = cmd2.ExecuteReader()
            If rdr2.Read() Then

                trk.Value = rdr2.GetValue(0) 'trk
                'MsgBox(trk.Value & " of " & trk.Name)'
                'trk.BackColor = Color.BurlyWood
            Else
                'trk.BackColor = Color.BurlyWood
                trk.Value = 9
            End If
        End If
    End Sub
    Private Sub cboKriteria1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub LoginToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoginAdmin.ShowDialog()
    End Sub

    Private Sub ButtonAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdmin.Click
        LoginAdmin.ShowDialog()
        NilaiUniversitasPadaKriteria.ShowDialog()
    End Sub

    Private Sub KriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KriteriaToolStripMenuItem.Click
        DialogKriteria.ShowDialog()
    End Sub

    Private Sub UniversitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UniversitasToolStripMenuItem.Click
        DialogUniversitas.ShowDialog()
    End Sub

    Private Sub PenilaianUniversitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenilaianUniversitasToolStripMenuItem.Click
        NilaiUniversitasPadaKriteria.ShowDialog()
    End Sub

    Private Sub AxMSChart1_ChartSelected(ByVal sender As System.Object, ByVal e As AxMSChart20Lib._DMSChartEvents_ChartSelectedEvent) Handles AxMSChart1.ChartSelected

    End Sub
End Class
