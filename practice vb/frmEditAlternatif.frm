VERSION 5.00
Begin VB.Form frmEditAlternatif 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form Edit Alternatif"
   ClientHeight    =   7755
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   9855
   Icon            =   "frmEditAlternatif.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7755
   ScaleWidth      =   9855
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtEditAlternatifNew 
      Height          =   495
      Left            =   4545
      TabIndex        =   5
      Top             =   6000
      Width           =   3255
   End
   Begin VB.TextBox txtEditAlternatifOld 
      Height          =   495
      Left            =   4545
      TabIndex        =   4
      Top             =   5280
      Width           =   3255
   End
   Begin VB.Frame Frame1 
      Caption         =   "Preferensi Universitas"
      Height          =   4095
      Left            =   1860
      TabIndex        =   2
      Top             =   600
      Width           =   6135
      Begin VB.TextBox Text1 
         Height          =   3255
         Left            =   240
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   7
         TabStop         =   0   'False
         Top             =   480
         Width           =   5655
      End
   End
   Begin VB.CommandButton cmdCancelAlternatif 
      Caption         =   "&Cancel"
      Height          =   495
      Left            =   5295
      TabIndex        =   1
      Top             =   6960
      Width           =   1215
   End
   Begin VB.CommandButton cmdEditAlternatif 
      Caption         =   "&Update"
      Height          =   495
      Left            =   3345
      TabIndex        =   0
      Top             =   6960
      Width           =   1215
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Nama Universitas (New)"
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
      Left            =   1995
      TabIndex        =   6
      Top             =   6120
      Width           =   2520
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Nama Universitas (Old)"
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
      Left            =   2055
      TabIndex        =   3
      Top             =   5400
      Width           =   2430
   End
End
Attribute VB_Name = "frmEditAlternatif"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancelAlternatif_Click()
    frmAdmin.Show
    Unload Me
End Sub
