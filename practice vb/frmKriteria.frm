VERSION 5.00
Begin VB.Form frmPreferensi 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Pemilihan Kriteria"
   ClientHeight    =   8265
   ClientLeft      =   45
   ClientTop       =   705
   ClientWidth     =   12975
   Icon            =   "frmKriteria.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8265
   ScaleMode       =   0  'User
   ScaleWidth      =   12811.89
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdBack 
      Caption         =   "&Back"
      Height          =   500
      Left            =   7080
      TabIndex        =   19
      Top             =   7320
      Width           =   1519
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "&Next"
      Height          =   500
      Left            =   4440
      TabIndex        =   18
      Top             =   7320
      Width           =   1519
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H80000016&
      Caption         =   "Preferensi Alternatif"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4215
      Left            =   7080
      TabIndex        =   10
      Top             =   1560
      Width           =   5535
      Begin VB.CheckBox Check14 
         BackColor       =   &H80000016&
         Caption         =   "Alternatif 1"
         Height          =   495
         Left            =   240
         TabIndex        =   17
         Top             =   480
         Width           =   1215
      End
      Begin VB.CheckBox Check13 
         BackColor       =   &H80000016&
         Caption         =   "Alternatif 2"
         Height          =   495
         Left            =   240
         TabIndex        =   16
         Top             =   960
         Width           =   1215
      End
      Begin VB.CheckBox Check12 
         BackColor       =   &H80000016&
         Caption         =   "Alternatif 3"
         Height          =   495
         Left            =   240
         TabIndex        =   15
         Top             =   1440
         Width           =   1215
      End
      Begin VB.CheckBox Check11 
         BackColor       =   &H80000016&
         Caption         =   "Alternatif 4"
         Height          =   495
         Left            =   240
         TabIndex        =   14
         Top             =   1920
         Width           =   1215
      End
      Begin VB.CheckBox Check10 
         BackColor       =   &H80000016&
         Caption         =   "Alternatif 5"
         Height          =   495
         Left            =   240
         TabIndex        =   13
         Top             =   2400
         Width           =   1215
      End
      Begin VB.CheckBox Check9 
         BackColor       =   &H80000016&
         Caption         =   "Alternatif 6"
         Height          =   495
         Left            =   240
         TabIndex        =   12
         Top             =   2880
         Width           =   1215
      End
      Begin VB.CheckBox Check8 
         BackColor       =   &H80000016&
         Caption         =   "Alternatif 7"
         Height          =   495
         Left            =   240
         TabIndex        =   11
         Top             =   3360
         Width           =   1215
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H80000016&
      Caption         =   "Preferensi Kriteria"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4215
      Left            =   360
      TabIndex        =   1
      Top             =   1560
      Width           =   5535
      Begin VB.CheckBox Check7 
         BackColor       =   &H80000016&
         Caption         =   "Kriteria 7"
         Height          =   495
         Left            =   240
         TabIndex        =   8
         Top             =   3360
         Width           =   1215
      End
      Begin VB.CheckBox Check6 
         BackColor       =   &H80000016&
         Caption         =   "Kriteria 6"
         Height          =   495
         Left            =   240
         TabIndex        =   7
         Top             =   2880
         Width           =   1215
      End
      Begin VB.CheckBox Check5 
         BackColor       =   &H80000016&
         Caption         =   "Kriteria 5"
         Height          =   495
         Left            =   240
         TabIndex        =   6
         Top             =   2400
         Width           =   1215
      End
      Begin VB.CheckBox Check4 
         BackColor       =   &H80000016&
         Caption         =   "Kriteria 4"
         Height          =   495
         Left            =   240
         TabIndex        =   5
         Top             =   1920
         Width           =   1215
      End
      Begin VB.CheckBox Check3 
         BackColor       =   &H80000016&
         Caption         =   "Kriteria 3"
         Height          =   495
         Left            =   240
         TabIndex        =   4
         Top             =   1440
         Width           =   1215
      End
      Begin VB.CheckBox Check2 
         BackColor       =   &H80000016&
         Caption         =   "Kriteria 2"
         Height          =   495
         Left            =   240
         TabIndex        =   3
         Top             =   960
         Width           =   1215
      End
      Begin VB.CheckBox Check1 
         BackColor       =   &H80000016&
         Caption         =   "Kriteria 1"
         Height          =   495
         Left            =   240
         TabIndex        =   2
         Top             =   480
         Width           =   1215
      End
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Pilih Alternatif Yang Anda Inginkan"
      BeginProperty Font 
         Name            =   "Garamond"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   7080
      TabIndex        =   9
      Top             =   795
      Width           =   4410
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Pilih Kriteria Yang Anda Inginkan"
      BeginProperty Font 
         Name            =   "Garamond"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   360
      TabIndex        =   0
      Top             =   795
      Width           =   4185
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuExit 
         Caption         =   "&Exit"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      Begin VB.Menu mnuBantuan 
         Caption         =   "&Bantuan"
      End
   End
End
Attribute VB_Name = "frmPreferensi"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdBack_Click()
    frmUtama.Show
    Unload Me
End Sub

Private Sub cmdNext_Click()
    frmHitungKriteria.Show
    Unload Me
End Sub

Private Sub mnuExit_Click()
    End
End Sub
