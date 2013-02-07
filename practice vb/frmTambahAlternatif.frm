VERSION 5.00
Begin VB.Form frmTambahAlternatif 
   Caption         =   "Form Tambah Alternatif"
   ClientHeight    =   7140
   ClientLeft      =   60
   ClientTop       =   420
   ClientWidth     =   9855
   Icon            =   "frmTambahAlternatif.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   7140
   ScaleMode       =   0  'User
   ScaleWidth      =   9885
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Caption         =   "Universitas"
      Height          =   4095
      Left            =   1860
      TabIndex        =   4
      Top             =   600
      Width           =   6135
   End
   Begin VB.CommandButton cmdCancelAlt 
      Caption         =   "&Cancel"
      Height          =   495
      Left            =   5280
      TabIndex        =   3
      Top             =   6240
      Width           =   1215
   End
   Begin VB.CommandButton cmdAddAlt 
      Caption         =   "&Add"
      Height          =   495
      Left            =   3360
      TabIndex        =   2
      Top             =   6240
      Width           =   1215
   End
   Begin VB.TextBox txtTambahAlternatif 
      Height          =   495
      Left            =   4260
      TabIndex        =   1
      Top             =   5280
      Width           =   3255
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Nama Universitas"
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
      Left            =   2340
      TabIndex        =   0
      Top             =   5400
      Width           =   1860
   End
End
Attribute VB_Name = "frmTambahAlternatif"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancelAlt_Click()
    frmAdmin.Show
    Unload Me
End Sub

