VERSION 5.00
Begin VB.Form frmUbahPassword 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form Ubah Password"
   ClientHeight    =   3210
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   5160
   Icon            =   "frmUbahPassword.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3210
   ScaleWidth      =   5160
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox Text2 
      Height          =   345
      Left            =   2258
      TabIndex        =   7
      Top             =   1440
      Width           =   2325
   End
   Begin VB.TextBox Text1 
      Height          =   345
      Left            =   2258
      TabIndex        =   6
      Top             =   960
      Width           =   2325
   End
   Begin VB.TextBox txtUserName 
      Height          =   345
      Left            =   2258
      TabIndex        =   5
      Top             =   480
      Width           =   2325
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Height          =   495
      Left            =   2993
      TabIndex        =   1
      Top             =   2400
      Width           =   1215
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   495
      Left            =   953
      TabIndex        =   0
      Top             =   2400
      Width           =   1215
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "Re-type Password"
      Height          =   195
      Left            =   578
      TabIndex        =   4
      Top             =   1560
      Width           =   1530
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Password Baru"
      Height          =   195
      Left            =   578
      TabIndex        =   3
      Top             =   1080
      Width           =   1545
   End
   Begin VB.Label Label1 
      Caption         =   "Password Lama"
      Height          =   195
      Left            =   578
      TabIndex        =   2
      Top             =   600
      Width           =   1485
   End
End
Attribute VB_Name = "frmUbahPassword"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
    Unload Me
End Sub
