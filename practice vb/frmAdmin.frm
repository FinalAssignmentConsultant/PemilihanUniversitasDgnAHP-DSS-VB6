VERSION 5.00
Begin VB.Form frmAdmin 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Welcome Admin"
   ClientHeight    =   8370
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   13800
   Icon            =   "frmAdmin.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8370
   ScaleWidth      =   13800
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtAlternatif 
      Height          =   4815
      Left            =   7440
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   9
      TabStop         =   0   'False
      Top             =   2280
      Width           =   5175
   End
   Begin VB.TextBox txtKriteria 
      Height          =   4815
      Left            =   960
      Locked          =   -1  'True
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   8
      TabStop         =   0   'False
      Top             =   2280
      Width           =   5175
   End
   Begin VB.CommandButton cmdUbahPassword 
      Caption         =   "&Ubah Password"
      Height          =   495
      Left            =   9720
      TabIndex        =   7
      Top             =   7440
      Width           =   1215
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "&Exit"
      Height          =   495
      Left            =   11280
      TabIndex        =   6
      Top             =   7440
      Width           =   1215
   End
   Begin VB.CommandButton cmdDelAlt 
      Caption         =   "&Delete"
      Height          =   495
      Left            =   10560
      TabIndex        =   5
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton cmdEditAlt 
      Caption         =   "&Update"
      Height          =   495
      Left            =   9240
      TabIndex        =   4
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton cmdAddAlt 
      Caption         =   "&Add"
      Height          =   495
      Left            =   7920
      TabIndex        =   3
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton cmdDelKrit 
      Caption         =   "&Delete"
      Height          =   495
      Left            =   3960
      TabIndex        =   2
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton cmdEditKrit 
      Caption         =   "&Update"
      Height          =   495
      Left            =   2640
      TabIndex        =   1
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton cmdAddKrit 
      Caption         =   "&Add"
      Height          =   495
      Left            =   1320
      TabIndex        =   0
      Top             =   600
      Width           =   1215
   End
   Begin VB.Label lblAlternatif 
      AutoSize        =   -1  'True
      Caption         =   "Universitas"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   7440
      TabIndex        =   11
      Top             =   1920
      Width           =   960
   End
   Begin VB.Label lblKriteria 
      AutoSize        =   -1  'True
      Caption         =   "Kriteria"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   960
      TabIndex        =   10
      Top             =   1920
      Width           =   615
   End
End
Attribute VB_Name = "frmAdmin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdAddAlt_Click()
    AddName "Alternatif", AlternatifPosition$
    txtAlternatif.Text = txtAlternatif.Text & AlternatifPosition$
End Sub

Private Sub cmdAddKrit_Click()
   AddName "Kriteria", KriteriaPosition$
   txtKriteria.Text = txtKriteria.Text & KriteriaPosition$
End Sub

Private Sub cmdDelAlt_Click()
    frmHapusAlternatif.Show
    Unload Me
End Sub

Private Sub cmdDelKrit_Click()
    frmHapusKriteria.Show
    Unload Me
End Sub

Private Sub cmdEditAlt_Click()
    frmEditAlternatif.Show
    Unload Me
End Sub

Private Sub cmdEditKrit_Click()
    frmEditKriteria.Show
    Unload Me
End Sub

Private Sub cmdExit_Click()
    If MsgBox("Apakah Admin benar-benar mau keluar?", vbYesNo) = vbYes Then
    frmDepan.Show
    Unload Me
    End If
End Sub

Private Sub cmdUbahPassword_Click()
    frmUbahPassword.Show
End Sub
