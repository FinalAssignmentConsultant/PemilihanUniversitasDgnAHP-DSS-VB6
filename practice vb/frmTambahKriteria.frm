VERSION 5.00
Begin VB.Form frmTambahKriteria 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form Tambah Kriteria"
   ClientHeight    =   7170
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   9885
   Icon            =   "frmTambahKriteria.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7170
   ScaleWidth      =   9885
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Caption         =   "Kriteria"
      Height          =   4095
      Left            =   1875
      TabIndex        =   4
      Top             =   600
      Width           =   6135
   End
   Begin VB.CommandButton cmdCancelKrit 
      Caption         =   "&Cancel"
      Height          =   495
      Left            =   5295
      TabIndex        =   3
      Top             =   6240
      Width           =   1215
   End
   Begin VB.CommandButton cmdAddKrit 
      Caption         =   "&Add"
      Height          =   495
      Left            =   3375
      TabIndex        =   2
      Top             =   6240
      Width           =   1215
   End
   Begin VB.TextBox txTambahtKriteria 
      Height          =   495
      Left            =   4035
      TabIndex        =   1
      Top             =   5280
      Width           =   3255
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Nama Kriteria"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   2235
      TabIndex        =   0
      Top             =   5400
      Width           =   1425
   End
End
Attribute VB_Name = "frmTambahKriteria"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdAddKrit_Click()
    If MsgBox("Apakah Anda yakin mau meng-add kriteria?", vbYesNo) = vbYes Then txtKriteria
End Sub

Private Sub Text1_Change()

End Sub

Private Sub cmdCancelKrit_Click()
    frmAdmin.Show
    Unload Me
End Sub

