Module Module1

    Public Sub identity(ByRef array(,) As Single, ByVal length As Integer)
        Dim i As Integer
        Dim j As Integer

        For i = 0 To length
            For j = 0 To length
                If i = j Then array(i, j) = 1
            Next
        Next

    End Sub

    Public Function pair(ByRef Matrix(,) As Single, ByRef trckAthdB As Windows.Forms.TrackBar, ByVal i As Integer, ByVal j As Integer)
        Dim nilai As Integer
        Dim posisi As Integer
        If trckAthdB.Value <= 8 Then
            posisi = 0
            nilai = 10 - trckAthdB.Value
        ElseIf trckAthdB.Value = 9 Then
            posisi = 1
            nilai = 1
        ElseIf trckAthdB.Value >= 10 Then
            posisi = 2
            nilai = trckAthdB.Value - 8
        End If

        If posisi = 0 Then
            Matrix(i, j) = nilai
            Matrix(j, i) = 1 / nilai
        ElseIf posisi = 1 Then
            Matrix(i, j) = 1
            Matrix(j, i) = 1
        ElseIf posisi = 2 Then
            Matrix(j, i) = nilai
            Matrix(i, j) = 1 / nilai
        End If


        Return nilai
    End Function

    Public Sub printKolom(ByVal Matrix() As Single, ByVal length As Integer, ByRef txt As TextBox)
        Dim i As Integer
        txt.Text = ""
        txt.Text = "printKolom" & vbCrLf
        For i = 0 To length
            txt.Text = txt.Text & Matrix(i) & vbCrLf
        Next
    End Sub

    Public Sub totalKolom(ByRef MatrixHasil() As Single, ByVal MatrixAsal(,) As Single, ByVal length As Integer)
        Dim j As Integer
        Dim i As Integer
        Dim iTotalKolom As Single

        For j = 0 To length
            iTotalKolom = 0
            For i = 0 To length
                iTotalKolom = iTotalKolom + MatrixAsal(i, j)
            Next
            MatrixHasil(j) = iTotalKolom
        Next

    End Sub

    Public Sub hitungValue(ByRef MatrixValue(,) As Single, ByVal MatrixPreferensi(,) As Single, ByVal MatrixTotalKolom() As Single, ByVal length As Integer)
        For i = 0 To length
            For j = 0 To length
                MatrixValue(i, j) = MatrixPreferensi(i, j) / MatrixTotalKolom(j)
            Next
        Next
    End Sub

    Public Sub totalBaris(ByRef MatrixTotalBaris() As Single, ByVal MatrixValue(,) As Single, ByVal length As Integer)
        Dim iTotalBaris As Single
        For i = 0 To length
            iTotalBaris = 0
            For j = 0 To length
                iTotalBaris = iTotalBaris + MatrixValue(i, j)
            Next
            MatrixTotalBaris(i) = iTotalBaris
        Next
    End Sub

    Public Sub bobot(ByRef MatrixBobot As Single(), ByVal MatrixTotalBaris As Single(), ByVal length As Integer)
        For i = 0 To length
            MatrixBobot(i) = MatrixTotalBaris(i) / (length + 1)
        Next
    End Sub

    Public Function max(ByVal Matrix() As Single, ByVal length As Integer, ByRef iTerbesar As Integer)
        Dim i As Integer
        Dim hasil As Single
        hasil = Matrix(0)
        For i = 1 To length
            If Matrix(i) > hasil Then
                hasil = Matrix(i)
                iTerbesar = i
            End If

        Next
        Return hasil
    End Function
End Module

