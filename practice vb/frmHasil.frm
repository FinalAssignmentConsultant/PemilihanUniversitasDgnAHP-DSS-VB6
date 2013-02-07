VERSION 5.00
Object = "{65E121D4-0C60-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCHRT20.OCX"
Begin VB.Form frmHasil 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Result Akhir"
   ClientHeight    =   8235
   ClientLeft      =   45
   ClientTop       =   705
   ClientWidth     =   12915
   Icon            =   "frmHasil.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8235
   ScaleWidth      =   12915
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   9840
      TabIndex        =   6
      Top             =   6360
      Width           =   1815
   End
   Begin MSChart20Lib.MSChart MSChart1 
      Height          =   4335
      Left            =   1680
      OleObjectBlob   =   "frmHasil.frx":0442
      TabIndex        =   1
      Top             =   1440
      Width           =   7455
   End
   Begin VB.CommandButton cmdAbout 
      Caption         =   "&About"
      Height          =   495
      Left            =   7440
      TabIndex        =   5
      Top             =   7080
      Width           =   1215
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "&Exit"
      Height          =   495
      Left            =   10680
      TabIndex        =   4
      Top             =   7080
      Width           =   1215
   End
   Begin VB.CommandButton cmdPrint 
      Caption         =   "&Print"
      Height          =   495
      Left            =   9060
      TabIndex        =   3
      Top             =   7080
      Width           =   1215
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Setelah dikalkulasi dengan metode AHP, universitas yang menjadi solusi adalah "
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
      Left            =   240
      TabIndex        =   2
      Top             =   6360
      Width           =   8415
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Universitas Terpilih"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   480
      TabIndex        =   0
      Top             =   600
      Width           =   2685
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
      Begin VB.Menu mnuBantuan 
         Caption         =   "&Bantuan"
      End
   End
End
Attribute VB_Name = "frmHasil"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdAbout_Click()
    frmAbout.Show
End Sub

Private Sub Command1_Click()
    
End Sub

Private Sub Command2_Click()
    
End Sub

Private Sub Command3_Click()
   
End Sub

Private Sub cmdExit_Click()
    If MsgBox("Apakah Anda benar-benar mau keluar dari aplikasi ini?", vbYesNo) = vbYes Then
End
End If
End Sub

Private Sub cmdPrint_Click()
    frmHasil.PrintForm
End Sub

Private Sub mnuAdmin_Click()
    frmLogin.Show
End Sub

Private Sub MSChart1_OLEStartDrag(Data As MSChart20Lib.DataObject, AllowedEffects As Long)

End Sub
