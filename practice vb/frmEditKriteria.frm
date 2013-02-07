VERSION 5.00
Begin VB.Form frmEditKriteria 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form Edit Kriteria"
   ClientHeight    =   7755
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   9855
   Icon            =   "frmEditKriteria.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7755
   ScaleWidth      =   9855
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtEditKriteriaNew 
      Height          =   495
      Left            =   4470
      TabIndex        =   5
      Top             =   6000
      Width           =   3255
   End
   Begin VB.Frame Frame1 
      Caption         =   "Preferensi Kriteria"
      Height          =   4095
      Left            =   1860
      TabIndex        =   3
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
   Begin VB.CommandButton cmdCancelKrit 
      Caption         =   "&Cancel"
      Height          =   495
      Left            =   5310
      TabIndex        =   2
      Top             =   6960
      Width           =   1215
   End
   Begin VB.CommandButton cmdEditKrit 
      Caption         =   "&Save"
      Height          =   495
      Left            =   3360
      TabIndex        =   1
      Top             =   6960
      Width           =   1215
   End
   Begin VB.TextBox txtEditKriteriaOld 
      Height          =   495
      Left            =   4470
      TabIndex        =   0
      Top             =   5280
      Width           =   3255
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "Nama Kriteria (New)"
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
      Left            =   2130
      TabIndex        =   6
      Top             =   6120
      Width           =   2085
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Nama Kriteria (Old)"
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
      Left            =   2175
      TabIndex        =   4
      Top             =   5400
      Width           =   1995
   End
End
Attribute VB_Name = "frmEditKriteria"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancelKrit_Click()
    frmAdmin.Show
    Unload Me
End Sub

