VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmUniversitas2 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Perbandingan Alternatif Untuk Kriteria 2"
   ClientHeight    =   9345
   ClientLeft      =   45
   ClientTop       =   705
   ClientWidth     =   12930
   Icon            =   "frmAlternatif2.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   9345
   ScaleWidth      =   12930
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdNext 
      Caption         =   "&Next"
      Height          =   495
      Left            =   9120
      TabIndex        =   12
      Top             =   8640
      Width           =   1215
   End
   Begin VB.CommandButton cmdBack 
      Caption         =   "&Back"
      Height          =   495
      Left            =   10935
      TabIndex        =   9
      Top             =   8640
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Preferensi Universitas Untuk Kriteria 2"
      Height          =   2820
      Left            =   2168
      TabIndex        =   0
      Top             =   1095
      Width           =   8595
      Begin VB.TextBox TxtKriteria 
         Alignment       =   2  'Center
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Index           =   3
         Left            =   7200
         TabIndex        =   5
         Text            =   "Universitas 3"
         Top             =   2040
         Width           =   1095
      End
      Begin VB.TextBox TxtKriteria 
         Alignment       =   2  'Center
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Index           =   2
         Left            =   240
         TabIndex        =   4
         Text            =   "Universitas 2"
         Top             =   2040
         Width           =   1095
      End
      Begin VB.TextBox TxtKriteria 
         Alignment       =   2  'Center
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Index           =   1
         Left            =   7200
         TabIndex        =   3
         Text            =   "Universitas 3"
         Top             =   1320
         Width           =   1095
      End
      Begin VB.TextBox TxtKriteria 
         Alignment       =   2  'Center
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Index           =   0
         Left            =   7200
         TabIndex        =   2
         Text            =   "Universitas 2"
         Top             =   600
         Width           =   1095
      End
      Begin VB.TextBox TxtKriteria 
         Alignment       =   2  'Center
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Times New Roman"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Index           =   9
         Left            =   240
         TabIndex        =   1
         Text            =   "Universitas 1"
         Top             =   600
         Width           =   1095
      End
      Begin MSComctlLib.Slider Slider1 
         Height          =   675
         Left            =   1440
         TabIndex        =   6
         Top             =   600
         Width           =   5655
         _ExtentX        =   9975
         _ExtentY        =   1191
         _Version        =   393216
         MousePointer    =   1
         OLEDropMode     =   1
         Min             =   -70
         Max             =   90
         SelStart        =   10
         TickFrequency   =   10
         Value           =   10
      End
      Begin MSComctlLib.Slider Slider2 
         Height          =   675
         Left            =   1440
         TabIndex        =   7
         Top             =   1320
         Width           =   5655
         _ExtentX        =   9975
         _ExtentY        =   1191
         _Version        =   393216
         Min             =   -70
         Max             =   90
         SelStart        =   10
         TickFrequency   =   10
         Value           =   10
      End
      Begin MSComctlLib.Slider Slider3 
         Height          =   675
         Left            =   1440
         TabIndex        =   8
         Top             =   2040
         Width           =   5655
         _ExtentX        =   9975
         _ExtentY        =   1191
         _Version        =   393216
         Min             =   -70
         Max             =   90
         SelStart        =   10
         TickFrequency   =   10
         Value           =   10
      End
   End
   Begin RichTextLib.RichTextBox rtbTabel 
      Height          =   3495
      Left            =   2595
      TabIndex        =   13
      Top             =   4800
      Width           =   7740
      _ExtentX        =   13653
      _ExtentY        =   6165
      _Version        =   393217
      Enabled         =   -1  'True
      TextRTF         =   $"frmAlternatif2.frx":0442
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Tabel Skala Penilaian Perbandingan Pasangan"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   3660
      TabIndex        =   11
      Top             =   4200
      Width           =   5610
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Perbandingan Universitas Untuk Kriteria : Kriteria 2"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   3525
      TabIndex        =   10
      Top             =   480
      Width           =   6120
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
Attribute VB_Name = "frmUniversitas2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command1_Click()
    
End Sub

Private Sub Command2_Click()
    
End Sub

Private Sub cmdBack_Click()
    frmAlternatif1.Show
    Unload Me
End Sub

Private Sub cmdNext_Click()
    frmAlternatif3.Show
    Unload Me
End Sub

Private Sub Form_Load()
     rtbTabel.LoadFile App.Path & "\tabel.rtf"
End Sub

Private Sub mnuExit_Click()
    End
End Sub
