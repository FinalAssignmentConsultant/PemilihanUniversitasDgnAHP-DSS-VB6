VERSION 5.00
Begin VB.Form frmUtama 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Aplikasi Sistem Pendukung Keputusan Dengan Metode AHP"
   ClientHeight    =   8265
   ClientLeft      =   45
   ClientTop       =   705
   ClientWidth     =   12975
   Icon            =   "frmUtama.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8265
   ScaleWidth      =   12975
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Caption         =   "Frame1"
      Height          =   4000
      Index           =   0
      Left            =   600
      TabIndex        =   7
      Top             =   2700
      Width           =   4935
   End
   Begin VB.Frame Frame1 
      Caption         =   "Frame1"
      Height          =   4000
      Index           =   1
      Left            =   7080
      TabIndex        =   6
      Top             =   2700
      Width           =   4935
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "&Exit"
      Height          =   500
      Index           =   1
      Left            =   7128
      TabIndex        =   3
      Top             =   7300
      Width           =   1599
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "&Next"
      Height          =   500
      Index           =   0
      Left            =   4248
      TabIndex        =   2
      Top             =   7300
      Width           =   1599
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "INFO UNIVERSITAS"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   360
      Left            =   7080
      TabIndex        =   5
      Top             =   2280
      Width           =   2115
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "PILIHAN UNIVERSITAS"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   240
      Left            =   600
      TabIndex        =   4
      Top             =   2280
      Width           =   2460
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "dengan METODE Analytical Hierarchy Process (AHP)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   255
      Index           =   1
      Left            =   2160
      TabIndex        =   1
      Top             =   1200
      Width           =   6450
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      BackStyle       =   0  'Transparent
      Caption         =   "APLIKASI SISTEM PENDUKUNG KEPUTUSAN PEMILIHAN UNIVERSITAS"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   255
      Index           =   0
      Left            =   1440
      TabIndex        =   0
      Top             =   720
      Width           =   8265
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuAdmin 
         Caption         =   "&Admin"
      End
      Begin VB.Menu mnuExit 
         Caption         =   "&Exit"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      Begin VB.Menu mnuBantu 
         Caption         =   "&Bantuan"
      End
   End
End
Attribute VB_Name = "frmUtama"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Agent1_ActivateInput(ByVal CharacterID As String)

End Sub

Private Sub Command1_Click(Index As Integer)

End Sub

Private Sub Timer1_Timer()

End Sub

Private Sub PathControl1_onstop()

End Sub

Private Sub cmdAhp_Click(Index As Integer)
    
End Sub

Private Sub cmdExit_Click(Index As Integer)
    If MsgBox("Apakah Anda benar-benar mau keluar dari aplikasi?", vbYesNo) = vbYes Then
    End
End If
End Sub

Private Sub cmdNext_Click(Index As Integer)
    frmPreferensi.Show
    Unload Me
End Sub

Private Sub MMControl1_Done(NotifyCode As Integer)

End Sub

Private Sub mnuAdmin_Click()
    frmLogin.Show
    Unload Me
End Sub

Private Sub mnuExit_Click()
    If MsgBox("Apakah Anda benar-benar mau keluar dari aplikasi?", vbYesNo) = vbYes Then
    End
End If
End Sub
