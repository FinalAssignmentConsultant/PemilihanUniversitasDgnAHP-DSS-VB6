VERSION 5.00
Begin VB.Form frmHapusKriteria 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form Hapus Kriteria"
   ClientHeight    =   7170
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   9885
   Icon            =   "frmDeleteKriteria.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7170
   ScaleWidth      =   9885
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdDelKrit 
      Caption         =   "&Delete"
      Height          =   495
      Left            =   3375
      TabIndex        =   2
      Top             =   6120
      Width           =   1215
   End
   Begin VB.CommandButton cmdCancelKrit 
      Caption         =   "&Cancel"
      Height          =   495
      Left            =   5295
      TabIndex        =   1
      Top             =   6120
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Kriteria"
      Height          =   4935
      Left            =   1875
      TabIndex        =   0
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
End
Attribute VB_Name = "frmHapusKriteria"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancelKrit_Click()
    frmAdmin.Show
    Unload Me
End Sub
