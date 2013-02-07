Attribute VB_Name = "Module1"
Option Explicit
Option Base 0
Public Con As New ADODB.Connection
Public Enum TipeFieldSeleksiEnum
    tipeString
    tipeInt
End Enum



Sub AddName(Preferensi$, ReturnStrings$)
    Prompt$ = "Tambah " & Preferensi$ & " ?"
    Nm$ = InputBox(Prompt$, "Input Box")
    WrapCharacter$ = Chr(13) + Chr(10)
    ReturnString$ = Nm$ & WrapCharacter$
End Sub
Public Sub TestDatabase()
    Dim testFile As String
    Dim rs As ADODB.Recordset
    Dim idTestFile As Integer
    testFile = "Pengujian Formula AHP"
    
    'membuat file kalkulasi
    Con.Execute "delete from file where namafile='" & testFile & "'"
    Con.Execute "insert into file(namafile) values('" & testFile & "')"
    Set rs = Con.Execute("select idfile from file where namafile='" & testFile & "'")
    idTestFile = rs("idfile")
    
    'memilih kriteria
    Con.Execute "insert into file_kriteria(idfile, idkriteria) values(" & idTestFile & ",1)" 'akreditasi
    Con.Execute "insert into file_kriteria(idfile, idkriteria) values(" & idTestFile & ",2)" 'jumlah dosen
    Con.Execute "insert into file_kriteria(idfile, idkriteria) values(" & idTestFile & ",3)" 'kualitas
    Con.Execute "insert into file_kriteria(idfile, idkriteria) values(" & idTestFile & ",4)" 'biaya
    
    'buat matrix kriteria
    BuatMatrixKriteria (idTestFile) 'nilai awal, yaitu semua 0 kecuali yg diagonal, yaitu 1
    
    'pilih unversitas u/ file ini
    Con.Execute "insert into file_universitas(idfile,iduniversitas) values(" & idTestFile & ",1)" 'itb
    Con.Execute "insert into file_universitas(idfile,iduniversitas) values(" & idTestFile & ",2)" 'ugm
    Con.Execute "insert into file_universitas(idfile,iduniversitas) values(" & idTestFile & ",3)" 'ui
    Con.Execute "insert into file_universitas(idfile,iduniversitas) values(" & idTestFile & ",4)" 'its
    
    'buat matrix kriteria universitas
    BuatMatrixKriteriaUniversitas (idTestFile)
    
    'buat matrix u/ menyimpan bobot kriteria pada masing2 universitas
    BuatMatrixBobotKriteriaUniversitas (testFile)
    
    'AKAN MELAKUKAN PENGHITUNGAN
    '1. Memberi nilai preferensi kriteria & memasukkan pasangannya ( 5 pasangannya 1/5).
    BeriNilaiPreferensi testFile, "Jumlah Dosen", "Akreditasi", 5
    BeriNilaiPreferensi testFile, "Jumlah Dosen", "Kualitas Pendidikan", 2
    BeriNilaiPreferensi testFile, "Jumlah Dosen", "Biaya", 4
    BeriNilaiPreferensi testFile, "Kualitas Pendidikan", "Akreditasi", 4
    BeriNilaiPreferensi testFile, "Kualitas Pendidikan", "Biaya", 8
    BeriNilaiPreferensi testFile, "Biaya", "Akreditasi", 2
    
    
    
    '2. Menghitung nilai_kalkulasi kriteria
    HitungNilaiKalkulasiKriteriaMatrix (testFile)
    '3. Menghitung bobot kriteria
    HitungRataRataKriteria (testFile) '================== sampai sini benar ==================
    
    '4. Memberi nilai preferenfsi masing2 universitas pada tiap2 kriteria dan memasukkan pasangannya
    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Akreditasi", "UI", "ITB", 4
    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Akreditasi", "UI", "UGM", 8
    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Akreditasi", "UGM", "ITB", 2
    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Akreditasi", "UGM", "ITS", 2
    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Akreditasi", "ITS", "ITB", 5
    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Akreditasi", "ITS", "UI", 4
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Jumlah Dosen", "ITB", "ITS", 4
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Jumlah Dosen", "UI", "ITB", 5
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Jumlah Dosen", "UGM", "ITB", 2
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Jumlah Dosen", "UGM", "UI", 8
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Jumlah Dosen", "UGM", "ITS", 2
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Jumlah Dosen", "ITS", "UI", 4
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Kualitas Pendidikan", "ITB", "UI", 4
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Kualitas Pendidikan", "ITB", "ITS", 5
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Kualitas Pendidikan", "UI", "UGM", 8
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Kualitas Pendidikan", "UGM", "ITB", 2
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Kualitas Pendidikan", "ITS", "UI", 2
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Kualitas Pendidikan", "ITS", "UGM", 4
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Biaya", "ITB", "UGM", 4
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Biaya", "ITB", "ITS", 8
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Biaya", "UI", "ITB", 5
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Biaya", "UI", "ITS", 2
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Biaya", "UGM", "UI", 5
'    BeriNilaiPreferensiKriteriaPadaUniversitas testFile, "Biaya", "ITS", "UGM", 5
    
    
    '5. Menghitunga nilai kalkulasi kriteria universitas : masih yg copas dari bobot kriteria :NEXT
    HitungNilaiKalkulasiKriteriaUniversitasMatrix (testFile)
    '6. Menghitung bobot kriteria universitas : NEXT
    HitungRataRataKriteriaUniversitas (testFile) 'ini masih terbalik, pending dulu
    '7. Terakhir : hitung hasil akhir
    
    '8. Konsistensi Index : pengecekan /validasi

End Sub
Public Sub BuatMatrixBobotKriteriaUniversitas(namaFile As String)
    'NEXT
End Sub
Public Sub HitungRataRataKriteriaUniversitas(namaFile As String)
    Dim rsTotalPembagi As ADODB.Recordset, rsKriteriaPadaFile As ADODB.Recordset, rsCount As ADODB.Recordset
    Dim query As String
    Dim daftarKriteria() As String
    Dim banyakKriteria As Integer
    Dim i As Integer, j As Integer
    
    query = "SELECT kriteria.nama FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria"
    Set rsKriteriaPadaFile = Con.Execute(query)
    query = "SELECT count(*) FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria"
    Set rsCount = Con.Execute(query)
    banyakKriteria = rsCount(0)
    ReDim daftarKriteria(banyakKriteria - 1)
    
    
    i = 0
    While Not rsKriteriaPadaFile.EOF
        daftarKriteria(i) = rsKriteriaPadaFile("nama")
        i = i + 1
        rsKriteriaPadaFile.MoveNext
    Wend
    
    Dim hasil_nilai_kalkulasi As Double
    Dim rata_rata_nilai_kalkulasi As Double
    Dim jumlah_nilai_kalkulasi As Double
    Dim idfile As Integer, idKriteria As Integer
    idfile = getId("idfile", "file", "namafile='" & namaFile & "'")
    For i = 0 To banyakKriteria - 1
        query = "select sum(`file_kriteria_matrix`.`nilai_kalkulasi`) AS `Total` from (((`file_kriteria_matrix` join `kriteria`) join `file_kriteria`) join `file`) where ((`kriteria`.`nama` = _latin1'" & daftarKriteria(i) & "') and (`file`.`namafile` = _latin1'" & namaFile & "') and (`file_kriteria`.`idkriteria` = `kriteria`.`idkriteria`) and (`file_kriteria`.`idfile` = `file`.`idfile`) and (`file_kriteria_matrix`.`idfile_kriteria2` = `file_kriteria`.`idfile_kriteria`))"
        Set rsTotalPembagi = Con.Execute(query)
        
        rata_rata_nilai_kalkulasi = rsTotalPembagi(0) / banyakKriteria
        idKriteria = getId("idkriteria", "kriteria", "nama='" & daftarKriteria(i) & "'")
        UpdateNilaiTabel "file_kriteria", "bobot=" & rata_rata_nilai_kalkulasi, "idfile=" & idfile & " and idkriteria=" & idKriteria
        Debug.Print daftarKriteria(i) & ":" & rsTotalPembagi(0)
        
    Next
    
End Sub

Public Sub HitungNilaiKalkulasiKriteriaUniversitasMatrix(namaFile As String)
    Dim rsTotalPembagi As ADODB.Recordset, rsUniversitasPadaFile As ADODB.Recordset, rsKriteriaPadaFile As ADODB.Recordset, rsCount As ADODB.Recordset
    Dim query As String
    Dim daftarKriteria() As String
    Dim daftarUniversitas() As String
    Dim banyakKriteria As Integer
    Dim banyakUniversitas As Integer
    Dim i As Integer, j As Integer, k As Integer
    
    'daftar kriteria
    query = "SELECT kriteria.nama FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria"
    Set rsKriteriaPadaFile = Con.Execute(query)
    query = "SELECT count(*) FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria"
    Set rsCount = Con.Execute(query)
    banyakKriteria = rsCount(0)
    ReDim daftarKriteria(banyakKriteria - 1)
    
    i = 0
    While Not rsKriteriaPadaFile.EOF
        daftarKriteria(i) = rsKriteriaPadaFile("nama")
        i = i + 1
        rsKriteriaPadaFile.MoveNext
    Wend
    
    'daftar universitas
    query = "SELECT universitas.nama FROM file,file_universitas,universitas where file.namafile='" & namaFile & "' and file.idfile = file_universitas.idfile and universitas.iduniversitas=file_universitas.iduniversitas"
    Set rsUniversitasPadaFile = Con.Execute(query)
    query = "SELECT count(*) FROM file,file_universitas,universitas where file.namafile='" & namaFile & "' and file.idfile = file_universitas.idfile and universitas.iduniversitas=file_universitas.iduniversitas"
    Set rsCount = Con.Execute(query)
    banyakUniversitas = rsCount(0)
    ReDim daftarUniversitas(banyakUniversitas - 1)
    
    i = 0
    While Not rsUniversitasPadaFile.EOF
        daftarUniversitas(i) = rsUniversitasPadaFile("nama")
        i = i + 1
        rsUniversitasPadaFile.MoveNext
    Wend
    
    
    
    Dim hasil_nilai_kalkulasi As Double
    Dim rata_rata_nilai_kalkulasi As Double
    Dim jumlah_nilai_kalkulasi As Double
    Dim idfile As Integer, idKriteria As Integer
    idfile = getId("idfile", "file", "namafile='" & namaFile & "'")
    
    For k = 0 To banyakKriteria - 1
        For i = 0 To banyakUniversitas - 1
            query = "select sum(`file_kriteria_universitas_matrix`.`preferensi`) AS `sum(preferensi)` from (((`file_kriteria_universitas_matrix` join `universitas`) join `file_universitas`) join `file`) where ((`universitas`.`nama` = _latin1'" & daftarUniversitas(i) & "') and (`file`.`namafile` = _latin1'" & namaFile & "') and (`file_universitas`.`iduniversitas` = `universitas`.`iduniversitas`) and (`file_universitas`.`idfile` = `file`.`idfile`) and (`file_kriteria_universitas_matrix`.`idfile_universitas1` = `file_universitas`.`idfile_universitas`))"
            Set rsTotalPembagi = Con.Execute(query)
            Debug.Print rsTotalPembagi(0)
            If rsTotalPembagi(0) = 12 Then MsgBox ("bisa?")
            For j = 0 To banyakUniversitas - 1
                BeriNilaiPreferensiKriteriaPadaUniversitas namaFile, daftarKriteria(k), daftarUniversitas(i), daftarUniversitas(j), , rsTotalPembagi(0), hasil_nilai_kalkulasi
            Next
        Next
    Next
End Sub

Private Sub BeriNilaiPreferensiKriteriaPadaUniversitas(namaFile As String, namaKriteria As String, namaUniversitas1 As String, namaUniversitas2 As String, Optional nilaiPreferensi As Integer, Optional nilai_kalkulasi As Double, Optional ByRef hasil_nilai_kalkulasi)
    Dim idfile As Integer
    Dim idUniversitas2 As Integer
    Dim idUniversitas1 As Integer
    
    Dim idFileUniversitas2 As Integer
    Dim idFileUniversitas1 As Integer
    Dim query As String
    Dim rs As ADODB.Recordset
    
    'If namaKriteria1 = namaKriteria2 Then
      '  MsgBox "Nilainya pasti 1. Tidak bisa diubah"
      '  Exit Sub
    'End If
    
    idfile = getId("idfile", "file", "namafile='" & namaFile & "'")
    idUniversitas1 = getId("iduniversitas", "universitas", "nama='" & namaUniversitas1 & "'")
    idUniversitas2 = getId("iduniversitas", "universitas", "nama='" & namaUniversitas2 & "'")
    Debug.Print "univ:" & namaUniversitas1 & ":" & idUniversitas1
    Debug.Print "univ:" & namaUniversitas2 & ":" & idUniversitas2
    
    idFileUniversitas1 = getId("idfile_universitas", "file_universitas", "iduniversitas=" & idUniversitas1 & " and idfile=" & idfile)
    idFileUniversitas2 = getId("idfile_universitas", "file_universitas", "iduniversitas=" & idUniversitas2 & " and idfile=" & idfile)
    Debug.Print "file univ:" & namaUniversitas1 & ":" & idFileUniversitas1
    Debug.Print "file univ:" & namaUniversitas2 & ":" & idFileUniversitas2
    
    'harus mengupdate 2 nilai, yaitu prefernsi pasangannya. Yaitu, jika a<->b = c, maka b<->=1/c
    If nilaiPreferensi <> 0 Then
        UpdateNilaiTabel "file_kriteria_universitas_matrix", "preferensi=" & nilaiPreferensi, "idfile_universitas1=" & idFileUniversitas1 & " and idfile_universitas2=" & idFileUniversitas2
        UpdateNilaiTabel "file_kriteria_universitas_matrix", "preferensi=" & (1 / nilaiPreferensi), "idfile_universitas1=" & idFileUniversitas2 & " and idfile_universitas2=" & idFileUniversitas1
    End If
    
    
    If nilai_kalkulasi <> 0 Then
        query = "SELECT file_kriteria_universitas_matrix.preferensi FROM file_kriteria_universitas_matrix,file where file.namafile='" & namaFile & "' and idfile_universitas1=" & idFileUniversitas1 & " and idfile_universitas2=" & idFileUniversitas2
       Set rs = Con.Execute(query)
       hasil_nilai_kalkulasi = rs(0) / nilai_kalkulasi
       UpdateNilaiTabel "file_kriteria_universitas_matrix", "nilai_kalkulasi=" & hasil_nilai_kalkulasi, "idfile_universitas1=" & idFileUniversitas1 & " and idfile_universitas2=" & idFileUniversitas2
        Debug.Print "kalkulasi " & hasil_nilai_kalkulasi
    End If
    
    
    
    
End Sub
Public Sub HitungRataRataKriteria(namaFile As String)
    Dim rsTotalPembagi As ADODB.Recordset, rsKriteriaPadaFile As ADODB.Recordset, rsCount As ADODB.Recordset
    Dim query As String
    Dim daftarKriteria() As String
    Dim banyakKriteria As Integer
    Dim i As Integer, j As Integer
    
    query = "SELECT kriteria.nama FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria"
    Set rsKriteriaPadaFile = Con.Execute(query)
    query = "SELECT count(*) FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria"
    Set rsCount = Con.Execute(query)
    banyakKriteria = rsCount(0)
    ReDim daftarKriteria(banyakKriteria - 1)
    
    
    i = 0
    While Not rsKriteriaPadaFile.EOF
        daftarKriteria(i) = rsKriteriaPadaFile("nama")
        i = i + 1
        rsKriteriaPadaFile.MoveNext
    Wend
    
    Dim hasil_nilai_kalkulasi As Double
    Dim rata_rata_nilai_kalkulasi As Double
    Dim jumlah_nilai_kalkulasi As Double
    Dim idfile As Integer, idKriteria As Integer
    idfile = getId("idfile", "file", "namafile='" & namaFile & "'")
    For i = 0 To banyakKriteria - 1
        query = "select sum(`file_kriteria_matrix`.`nilai_kalkulasi`) AS `Total` from (((`file_kriteria_matrix` join `kriteria`) join `file_kriteria`) join `file`) where ((`kriteria`.`nama` = _latin1'" & daftarKriteria(i) & "') and (`file`.`namafile` = _latin1'" & namaFile & "') and (`file_kriteria`.`idkriteria` = `kriteria`.`idkriteria`) and (`file_kriteria`.`idfile` = `file`.`idfile`) and (`file_kriteria_matrix`.`idfile_kriteria2` = `file_kriteria`.`idfile_kriteria`))"
        Set rsTotalPembagi = Con.Execute(query)
        
        rata_rata_nilai_kalkulasi = rsTotalPembagi(0) / banyakKriteria
        idKriteria = getId("idkriteria", "kriteria", "nama='" & daftarKriteria(i) & "'")
        UpdateNilaiTabel "file_kriteria", "bobot=" & rata_rata_nilai_kalkulasi, "idfile=" & idfile & " and idkriteria=" & idKriteria
        Debug.Print daftarKriteria(i) & ":" & rsTotalPembagi(0)
        
    Next
    
End Sub

Public Sub HitungNilaiKalkulasiKriteriaMatrix(namaFile As String)
    Dim rsTotalPembagi As ADODB.Recordset, rsKriteriaPadaFile As ADODB.Recordset, rsCount As ADODB.Recordset
    Dim query As String
    Dim daftarKriteria() As String
    Dim banyakKriteria As Integer
    Dim i As Integer, j As Integer
    
    query = "SELECT kriteria.nama FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria order by kriteria.idkriteria"
    Set rsKriteriaPadaFile = Con.Execute(query)
    query = "SELECT count(*) FROM file,file_kriteria,kriteria where file.namafile='" & namaFile & "' and file.idfile = file_kriteria.idfile and kriteria.idkriteria=file_kriteria.idkriteria"
    Set rsCount = Con.Execute(query)
    banyakKriteria = rsCount(0)
    ReDim daftarKriteria(banyakKriteria - 1)
    
    
    i = 0
    While Not rsKriteriaPadaFile.EOF
        daftarKriteria(i) = rsKriteriaPadaFile("nama")
        i = i + 1
        rsKriteriaPadaFile.MoveNext
    Wend
    
    Dim hasil_nilai_kalkulasi As Double
    Dim rata_rata_nilai_kalkulasi As Double
    Dim jumlah_nilai_kalkulasi As Double
    Dim idfile As Integer, idKriteria As Integer
    idfile = getId("idfile", "file", "namafile='" & namaFile & "'")
    For i = 0 To banyakKriteria - 1
        query = "select sum(`file_kriteria_matrix`.`preferensi`) AS `sum(preferensi)` from (((`file_kriteria_matrix` join `kriteria`) join `file_kriteria`) join `file`) where ((`kriteria`.`nama` = '" & daftarKriteria(i) & "') and (`file`.`namafile` = '" & namaFile & "') and (`file_kriteria`.`idkriteria` = `kriteria`.`idkriteria`) and (`file_kriteria`.`idfile` = `file`.`idfile`) and (`file_kriteria_matrix`.`idfile_kriteria1` = `file_kriteria`.`idfile_kriteria`))"
 
        Set rsTotalPembagi = Con.Execute(query)
        
        jumlah_nilai_kalkulasi = 0
        For j = 0 To banyakKriteria - 1
            BeriNilaiPreferensi namaFile, daftarKriteria(i), daftarKriteria(j), , rsTotalPembagi(0), hasil_nilai_kalkulasi
            'jumlah_nilai_kalkulasi = jumlah_nilai_kalkulasi + hasil_nilai_kalkulasi
            
        Next
        'Debug.Print "JUMLAH " & jumlah_nilai_kalkulasi
        'rata_rata_nilai_kalkulasi = jumlah_nilai_kalkulasi / banyakKriteria
        
        'Debug.Print "bobot = " & rata_rata_nilai_kalkulasi
        'idKriteria = getId("idkriteria", "kriteria", "nama='" & daftarKriteria(i) & "'")
        'UpdateNilaiTabel "file_kriteria", "bobot=" & rata_rata_nilai_kalkulasi, "idfile=" & idfile & " and idkriteria=" & idKriteria
        'Debug.Print daftarKriteria(i) & ":" & rsTotalPembagi(0)
        
    Next
    
End Sub
Public Function getId(NamaFieldId As String, tableName As String, kondisiSeleksi As String)
    Dim rs As ADODB.Recordset
    
    Set rs = Con.Execute("select " & NamaFieldId & " from " & tableName & " where " & kondisiSeleksi)
    If Not rs.EOF Then
        getId = rs(NamaFieldId)
    Else
        MsgBox "Maaf, identitas " & NamaFieldId & " dengan kondisi " & kondisiSeleksi & " tidak ada di dalam database"
        getId = -1
    End If
End Function
Public Function UpdateNilaiTabel(namaTabel As String, daftarNilai As String, kondisiUpdate As String)
    Dim query As String
    query = "update " & namaTabel & " set " & daftarNilai & " where " & kondisiUpdate
    'Debug.Print query
    Con.Execute query
End Function
Private Sub BeriNilaiPreferensi(namaFile As String, namaKriteria1 As String, namaKriteria2 As String, Optional nilaiPreferensi As Integer, Optional nilai_kalkulasi As Double, Optional ByRef hasil_nilai_kalkulasi)
    Dim idfile As Integer
    Dim idKriteria2 As Integer
    Dim idKriteria1 As Integer
    
    Dim idFileKriteria2 As Integer
    Dim idFileKriteria1 As Integer
    Dim query As String
    Dim rs As ADODB.Recordset
    
    'If namaKriteria1 = namaKriteria2 Then
      '  MsgBox "Nilainya pasti 1. Tidak bisa diubah"
      '  Exit Sub
    'End If
    
    idfile = getId("idfile", "file", "namafile='" & namaFile & "'")
    idKriteria1 = getId("idkriteria", "kriteria", "nama='" & namaKriteria1 & "'")
    idKriteria2 = getId("idkriteria", "kriteria", "nama='" & namaKriteria2 & "'")
    
    idFileKriteria1 = getId("idfile_kriteria", "file_kriteria", "idkriteria=" & idKriteria1 & " and idfile=" & idfile)
    idFileKriteria2 = getId("idfile_kriteria", "file_kriteria", "idkriteria=" & idKriteria2 & " and idfile=" & idfile)
    
    'harus mengupdate 2 nilai, yaitu prefernsi pasangannya. Yaitu, jika a<->b = c, maka b<->=1/c
    If nilaiPreferensi <> 0 Then
        UpdateNilaiTabel "file_kriteria_matrix", "preferensi=" & nilaiPreferensi, "idfile_kriteria1=" & idFileKriteria1 & " and idfile_kriteria2=" & idFileKriteria2
        UpdateNilaiTabel "file_kriteria_matrix", "preferensi=" & (1 / nilaiPreferensi), "idfile_kriteria1=" & idFileKriteria2 & " and idfile_kriteria2=" & idFileKriteria1
    End If
    
    
    If nilai_kalkulasi <> 0 Then
        query = "SELECT file_kriteria_matrix.preferensi FROM file_kriteria_matrix,file where file.namafile='" & namaFile & "' and idfile_kriteria1=" & idFileKriteria1 & " and idfile_kriteria2=" & idFileKriteria2
       Set rs = Con.Execute(query)
       hasil_nilai_kalkulasi = rs(0) / nilai_kalkulasi
       UpdateNilaiTabel "file_kriteria_matrix", "nilai_kalkulasi=" & hasil_nilai_kalkulasi, "idfile_kriteria1=" & idFileKriteria1 & " and idfile_kriteria2=" & idFileKriteria2
        Debug.Print "kalkulasi " & hasil_nilai_kalkulasi
    End If
    
    
    
    
End Sub

Public Sub BuatMatrixKriteriaUniversitas(idTestFile As Integer)
    Dim daftarKriteria() As Integer
    Dim DaftarKriteriaUniversitas() As Integer
    Dim jumlahKriteria As Integer
    Dim jumlahKriteriaUniversitas As Integer
    jumlahKriteria = BuatDaftarData("select idfile_kriteria from file_kriteria where idfile=" & idTestFile, "select count(*) as jumlah from file_kriteria where idfile=" & idTestFile, daftarKriteria)
    jumlahKriteriaUniversitas = BuatDaftarData("select idfile_universitas from file_universitas where idfile=" & idTestFile, "select count(*) as jumlah from file_universitas where idfile=" & idTestFile, DaftarKriteriaUniversitas)

    
    Dim iKriteria As Integer, iUniversitas1 As Integer, iUniversitas2 As Integer
    Dim Preferensi As Integer
    Dim query As String
    For iKriteria = 0 To jumlahKriteria - 1
        For iUniversitas1 = 0 To jumlahKriteriaUniversitas - 1
            If iUniversitas1 = iUniversitas2 Then Preferensi = 1 Else Preferensi = 0
            For iUniversitas2 = 0 To jumlahKriteriaUniversitas - 1
                query = "insert into file_kriteria_universitas_matrix(idfile_kriteria, idfile_universitas1,idfile_universitas2,preferensi) values(" & daftarKriteria(iKriteria) & "," & DaftarKriteriaUniversitas(iUniversitas1) & "," & DaftarKriteriaUniversitas(iUniversitas2) & "," & Preferensi & ")"
                'MsgBox query
                Con.Execute query
            Next
        Next
    Next
    
End Sub
Public Function BuatDaftarData(query As String, queryJumlah As String, ByRef DaftarHasil() As Integer)
    Dim rs As ADODB.Recordset
    Dim rsCount As ADODB.Recordset
    Dim i As Integer
    
    Set rs = Con.Execute(query)
    Set rsCount = Con.Execute(queryJumlah)
    Dim jumlahData As Integer
    jumlahData = rsCount(0)
    ReDim DaftarHasil(jumlahData)
    i = 0
    While Not rs.EOF
        DaftarHasil(i) = rs(0)
        i = i + 1
        rs.MoveNext
    Wend
    BuatDaftarData = jumlahData
End Function
'mempersiapkan matrix kriteria
Public Sub BuatMatrixKriteria(idTestFile As Integer)
    Dim daftarKriteria() As Integer
    Dim jumlahKriteria As Integer
    jumlahKriteria = BuatDaftarData("select idfile_kriteria from file_kriteria where idfile=" & idTestFile, "select count(*) as jumlah from file_kriteria where idfile=" & idTestFile, daftarKriteria)
    Dim x As Integer
    Dim y As Integer
    Dim Preferensi As Integer
    Dim queryMatrix As String
    For x = 0 To jumlahKriteria - 1
        For y = 0 To jumlahKriteria - 1
            If x = y Then Preferensi = 1 Else Preferensi = 0
            queryMatrix = "insert into file_kriteria_matrix(idfile_kriteria1, idfile_kriteria2, preferensi)values(" & daftarKriteria(x) & "," & daftarKriteria(y) & "," & Preferensi & ")"
            Con.Execute queryMatrix
        Next y
    Next x
End Sub
Public Sub main()
    Con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\Aswan\My Documents\ahp.mdb;Persist Security Info=False" '"Provider=MSDASQL.1;Persist Security Info=False;Data Source=ahp"
    Con.Open
    'frmDepan.Show
    TestDatabase
End Sub
