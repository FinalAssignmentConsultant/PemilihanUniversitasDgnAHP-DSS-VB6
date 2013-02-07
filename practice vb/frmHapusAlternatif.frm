VERSION 5.00
Begin VB.Form frmHapusAlternatif 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form Hapus Alternatif"
   ClientHeight    =   7140
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   9855
   Icon            =   "frmHapusAlternatif.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7140
   ScaleWidth      =   9855
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Caption         =   "Universitas"
      Height          =   4935
      Left            =   1860
      TabIndex        =   2
      Top             =   480
      Width           =   6135
      Begin VB.TextBox Text1 
         Height          =   3495
         Left            =   240
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   3
         TabStop         =   0   'False
         Top             =   360
         Width           =   5655
      End
   End
   Begin VB.CommandButton cmdCancelKrit 
      Caption         =   "&Cancel"
      Height          =   495
      Left            =   5280
      TabIndex        =   1
      Top             =   6120
      Width           =   1215
   End
   Begin VB.CommandButton cmdDelKrit 
      Caption         =   "&Delete"
      Height          =   495
      Left            =   3360
      TabIndex        =   0
      Top             =   6120
      Width           =   1215
   End
End
Attribute VB_Name = "frmHapusAlternatif"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancelAlt_Click()
    frmAdmin.Show
    Unload Me
End Sub
