VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#2.0#0"; "MSCOMCTL.OCX"
Object = "{FE0065C0-1B7B-11CF-9D53-00AA003C9CB6}#2.0#0"; "MSCOMCT2.OCX"
Object = "{F27D9140-6791-11D2-A8C9-00805FCCB546}#1.0#0"; "PANELXCONTROL.OCX"
Begin VB.Form fComp 
   Appearance      =   0  'Flat
   BackColor       =   &H80000004&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Form1"
   ClientHeight    =   8340
   ClientLeft      =   150
   ClientTop       =   405
   ClientWidth     =   11910
   Icon            =   "fComp.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   ScaleHeight     =   8340
   ScaleWidth      =   11910
   StartUpPosition =   2  'CenterScreen
   Begin PanelXControl.PanelX Frame1 
      Height          =   7190
      Left            =   0
      OleObjectBlob   =   "fComp.frx":0442
      TabIndex        =   34
      Top             =   825
      Width           =   11935
      Begin VB.TextBox wa_desc 
         Height          =   375
         Left            =   960
         TabIndex        =   59
         Tag             =   "60"
         Text            =   "wa_desc"
         Top             =   360
         Visible         =   0   'False
         Width           =   2415
      End
      Begin TabDlg.SSTab SSTab1 
         Height          =   4770
         Left            =   540
         TabIndex        =   40
         Top             =   1200
         Width           =   10890
         _ExtentX        =   19209
         _ExtentY        =   8414
         _Version        =   393216
         Tab             =   2
         TabHeight       =   520
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         TabCaption(0)   =   "Profile"
         TabPicture(0)   =   "fComp.frx":04AB
         Tab(0).ControlEnabled=   0   'False
         Tab(0).Control(0)=   "Label1"
         Tab(0).Control(0).Enabled=   0   'False
         Tab(0).Control(1)=   "Label2"
         Tab(0).Control(1).Enabled=   0   'False
         Tab(0).Control(2)=   "Label3"
         Tab(0).Control(2).Enabled=   0   'False
         Tab(0).Control(3)=   "Label6"
         Tab(0).Control(3).Enabled=   0   'False
         Tab(0).Control(4)=   "Label7"
         Tab(0).Control(4).Enabled=   0   'False
         Tab(0).Control(5)=   "Label20"
         Tab(0).Control(5).Enabled=   0   'False
         Tab(0).Control(6)=   "vcomp_code"
         Tab(0).Control(6).Enabled=   0   'False
         Tab(0).Control(7)=   "vcomp_name"
         Tab(0).Control(7).Enabled=   0   'False
         Tab(0).Control(8)=   "vcomp_addr"
         Tab(0).Control(8).Enabled=   0   'False
         Tab(0).Control(9)=   "vcomp_tel"
         Tab(0).Control(9).Enabled=   0   'False
         Tab(0).Control(10)=   "vcomp_tin"
         Tab(0).Control(10).Enabled=   0   'False
         Tab(0).Control(11)=   "vcomp_vat"
         Tab(0).Control(11).Enabled=   0   'False
         Tab(0).ControlCount=   12
         TabCaption(1)   =   "Fiscal Period"
         TabPicture(1)   =   "fComp.frx":04C7
         Tab(1).ControlEnabled=   0   'False
         Tab(1).Control(0)=   "Label8"
         Tab(1).Control(0).Enabled=   0   'False
         Tab(1).Control(1)=   "Label9"
         Tab(1).Control(1).Enabled=   0   'False
         Tab(1).Control(2)=   "Label10"
         Tab(1).Control(2).Enabled=   0   'False
         Tab(1).Control(3)=   "Label11"
         Tab(1).Control(3).Enabled=   0   'False
         Tab(1).Control(4)=   "vfisc_year"
         Tab(1).Control(4).Enabled=   0   'False
         Tab(1).Control(5)=   "UpDown4"
         Tab(1).Control(5).Enabled=   0   'False
         Tab(1).Control(6)=   "vstfisc_year"
         Tab(1).Control(6).Enabled=   0   'False
         Tab(1).Control(7)=   "UpDown3"
         Tab(1).Control(7).Enabled=   0   'False
         Tab(1).Control(8)=   "vcur_fisc"
         Tab(1).Control(8).Enabled=   0   'False
         Tab(1).Control(9)=   "vnum_fisc"
         Tab(1).Control(9).Enabled=   0   'False
         Tab(1).Control(10)=   "UpDown1"
         Tab(1).Control(10).Enabled=   0   'False
         Tab(1).Control(11)=   "UpDown2"
         Tab(1).Control(11).Enabled=   0   'False
         Tab(1).ControlCount=   12
         TabCaption(2)   =   "Default Accounts"
         TabPicture(2)   =   "fComp.frx":04E3
         Tab(2).ControlEnabled=   -1  'True
         Tab(2).Control(0)=   "Label12"
         Tab(2).Control(0).Enabled=   0   'False
         Tab(2).Control(1)=   "Label13"
         Tab(2).Control(1).Enabled=   0   'False
         Tab(2).Control(2)=   "Label14"
         Tab(2).Control(2).Enabled=   0   'False
         Tab(2).Control(3)=   "Label15"
         Tab(2).Control(3).Enabled=   0   'False
         Tab(2).Control(4)=   "Label16"
         Tab(2).Control(4).Enabled=   0   'False
         Tab(2).Control(5)=   "Label17"
         Tab(2).Control(5).Enabled=   0   'False
         Tab(2).Control(6)=   "Label18"
         Tab(2).Control(6).Enabled=   0   'False
         Tab(2).Control(7)=   "Label19"
         Tab(2).Control(7).Enabled=   0   'False
         Tab(2).Control(8)=   "Label21"
         Tab(2).Control(8).Enabled=   0   'False
         Tab(2).Control(9)=   "vgl_depr_acct1"
         Tab(2).Control(9).Enabled=   0   'False
         Tab(2).Control(10)=   "vgl_cust_def"
         Tab(2).Control(10).Enabled=   0   'False
         Tab(2).Control(11)=   "vgl_sale_def"
         Tab(2).Control(11).Enabled=   0   'False
         Tab(2).Control(12)=   "vgl_supp_def"
         Tab(2).Control(12).Enabled=   0   'False
         Tab(2).Control(13)=   "vgl_otax"
         Tab(2).Control(13).Enabled=   0   'False
         Tab(2).Control(14)=   "vgl_otax_rat"
         Tab(2).Control(14).Enabled=   0   'False
         Tab(2).Control(15)=   "vdef_curr"
         Tab(2).Control(15).Enabled=   0   'False
         Tab(2).Control(16)=   "vgl_curr_earn"
         Tab(2).Control(16).Enabled=   0   'False
         Tab(2).Control(17)=   "gl_curr_earnBTN"
         Tab(2).Control(17).Enabled=   0   'False
         Tab(2).Control(18)=   "gl_depr_acct1BTN"
         Tab(2).Control(18).Enabled=   0   'False
         Tab(2).Control(19)=   "gl_cust_defBTN"
         Tab(2).Control(19).Enabled=   0   'False
         Tab(2).Control(20)=   "gl_sale_defBTN"
         Tab(2).Control(20).Enabled=   0   'False
         Tab(2).Control(21)=   "gl_supp_defBTN"
         Tab(2).Control(21).Enabled=   0   'False
         Tab(2).Control(22)=   "gl_otaxBTN"
         Tab(2).Control(22).Enabled=   0   'False
         Tab(2).Control(23)=   "def_currBTN"
         Tab(2).Control(23).Enabled=   0   'False
         Tab(2).Control(24)=   "vgl_depr_acct2"
         Tab(2).Control(24).Enabled=   0   'False
         Tab(2).Control(25)=   "gl_depr_acct2BTN"
         Tab(2).Control(25).Enabled=   0   'False
         Tab(2).ControlCount=   26
         Begin VB.CommandButton gl_depr_acct2BTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":04FF
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":0651
            Style           =   1  'Graphical
            TabIndex        =   19
            Top             =   1500
            Width           =   300
         End
         Begin VB.TextBox vgl_depr_acct2 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   40
            TabIndex        =   18
            Tag             =   "50"
            Text            =   "vgl_depr_acct2"
            Top             =   1470
            Width           =   6345
         End
         Begin ComCtl2.UpDown UpDown2 
            Height          =   315
            Left            =   -64725
            TabIndex        =   7
            Top             =   1225
            Width           =   240
            _ExtentX        =   423
            _ExtentY        =   556
            _Version        =   393216
            Value           =   1
            BuddyControl    =   "vnum_fisc"
            BuddyDispid     =   196626
            OrigLeft        =   10260
            OrigTop         =   1860
            OrigRight       =   10500
            OrigBottom      =   2160
            Max             =   120
            Min             =   1
            SyncBuddy       =   -1  'True
            BuddyProperty   =   0
            Enabled         =   -1  'True
         End
         Begin ComCtl2.UpDown UpDown1 
            Height          =   315
            Left            =   -64725
            TabIndex        =   9
            Top             =   1945
            Width           =   240
            _ExtentX        =   423
            _ExtentY        =   556
            _Version        =   393216
            Value           =   1
            BuddyControl    =   "vcur_fisc"
            BuddyDispid     =   196627
            OrigLeft        =   10275
            OrigTop         =   1140
            OrigRight       =   10515
            OrigBottom      =   1440
            Max             =   30
            Min             =   1
            SyncBuddy       =   -1  'True
            BuddyProperty   =   0
            Enabled         =   -1  'True
         End
         Begin VB.CommandButton def_currBTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":079B
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":08ED
            Style           =   1  'Graphical
            TabIndex        =   29
            Top             =   3780
            Width           =   300
         End
         Begin VB.TextBox vcomp_vat 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   -71805
            MaxLength       =   20
            TabIndex        =   5
            Tag             =   "29"
            Text            =   "vcomp_vat"
            Top             =   4155
            Width           =   7260
         End
         Begin VB.CommandButton gl_otaxBTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":0A37
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":0B89
            Style           =   1  'Graphical
            TabIndex        =   27
            Top             =   3360
            Width           =   300
         End
         Begin VB.CommandButton gl_supp_defBTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":0CD3
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":0E25
            Style           =   1  'Graphical
            TabIndex        =   25
            Top             =   2905
            Width           =   300
         End
         Begin VB.CommandButton gl_sale_defBTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":0F6F
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":10C1
            Style           =   1  'Graphical
            TabIndex        =   23
            Top             =   2455
            Width           =   300
         End
         Begin VB.CommandButton gl_cust_defBTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":120B
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":135D
            Style           =   1  'Graphical
            TabIndex        =   21
            Top             =   1975
            Width           =   300
         End
         Begin VB.CommandButton gl_depr_acct1BTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":14A7
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":15F9
            Style           =   1  'Graphical
            TabIndex        =   17
            Top             =   1045
            Width           =   300
         End
         Begin VB.CommandButton gl_curr_earnBTN 
            Height          =   310
            Left            =   10245
            MouseIcon       =   "fComp.frx":1743
            MousePointer    =   99  'Custom
            Picture         =   "fComp.frx":1895
            Style           =   1  'Graphical
            TabIndex        =   15
            Top             =   570
            Width           =   300
         End
         Begin VB.TextBox vgl_curr_earn 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   40
            TabIndex        =   14
            Tag             =   "50"
            Text            =   "vgl_curr_earn"
            Top             =   540
            Width           =   6345
         End
         Begin VB.TextBox vdef_curr 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   10
            TabIndex        =   28
            Tag             =   "50"
            Text            =   "vdef_curr"
            Top             =   3750
            Width           =   6345
         End
         Begin VB.TextBox vgl_otax_rat 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   19
            TabIndex        =   30
            Tag             =   "34"
            Text            =   "vgl_otax_rat"
            Top             =   4200
            Width           =   6345
         End
         Begin VB.TextBox vgl_otax 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   40
            TabIndex        =   26
            Tag             =   "50"
            Text            =   "vgl_otax"
            Top             =   3330
            Width           =   6345
         End
         Begin VB.TextBox vgl_supp_def 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   40
            TabIndex        =   24
            Tag             =   "50"
            Text            =   "vgl_supp_def"
            Top             =   2880
            Width           =   6345
         End
         Begin VB.TextBox vgl_sale_def 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   40
            TabIndex        =   22
            Tag             =   "50"
            Text            =   "vgl_sale_def"
            Top             =   2430
            Width           =   6345
         End
         Begin VB.TextBox vgl_cust_def 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   40
            TabIndex        =   20
            Tag             =   "50"
            Text            =   "vgl_cust_def"
            Top             =   1950
            Width           =   6345
         End
         Begin VB.TextBox vgl_depr_acct1 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   4230
            MaxLength       =   40
            TabIndex        =   16
            Tag             =   "50"
            Text            =   "vgl_depr_acct1"
            Top             =   1020
            Width           =   6345
         End
         Begin VB.TextBox vnum_fisc 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -71250
            TabIndex        =   6
            Tag             =   "31"
            Text            =   "vnum_fisc"
            Top             =   1200
            Width           =   6800
         End
         Begin VB.TextBox vcur_fisc 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -71250
            TabIndex        =   8
            Tag             =   "31"
            Text            =   "vcur_fisc"
            Top             =   1920
            Width           =   6800
         End
         Begin VB.TextBox vcomp_tin 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   -71805
            MaxLength       =   20
            TabIndex        =   4
            Tag             =   "29"
            Text            =   "vcomp_tin"
            Top             =   3465
            Width           =   7260
         End
         Begin VB.TextBox vcomp_tel 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   -71805
            MaxLength       =   70
            TabIndex        =   3
            Tag             =   "29"
            Text            =   "vcomp_tel"
            Top             =   2775
            Width           =   7260
         End
         Begin VB.TextBox vcomp_addr 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   -71805
            MaxLength       =   70
            TabIndex        =   2
            Tag             =   "29"
            Text            =   "vcomp_addr"
            Top             =   2070
            Width           =   7260
         End
         Begin VB.TextBox vcomp_name 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   -71805
            MaxLength       =   50
            TabIndex        =   1
            Tag             =   "10"
            Text            =   "vcomp_name"
            Top             =   1320
            Width           =   7260
         End
         Begin VB.TextBox vcomp_code 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   360
            Left            =   -71805
            MaxLength       =   2
            TabIndex        =   0
            Tag             =   "10"
            Text            =   "vcomp_code"
            Top             =   615
            Width           =   7260
         End
         Begin ComCtl2.UpDown UpDown3 
            Height          =   315
            Left            =   -64725
            TabIndex        =   11
            Top             =   2660
            Width           =   240
            _ExtentX        =   423
            _ExtentY        =   556
            _Version        =   393216
            Value           =   1960
            BuddyControl    =   "vstfisc_year"
            BuddyDispid     =   196633
            OrigLeft        =   10260
            OrigTop         =   1860
            OrigRight       =   10500
            OrigBottom      =   2160
            Max             =   1978
            Min             =   1960
            SyncBuddy       =   -1  'True
            BuddyProperty   =   0
            Enabled         =   -1  'True
         End
         Begin VB.TextBox vstfisc_year 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -71250
            MaxLength       =   4
            TabIndex        =   10
            Tag             =   "20"
            Text            =   "vstfisc_year"
            Top             =   2625
            Width           =   6800
         End
         Begin ComCtl2.UpDown UpDown4 
            Height          =   315
            Left            =   -64725
            TabIndex        =   13
            Top             =   3390
            Width           =   240
            _ExtentX        =   423
            _ExtentY        =   556
            _Version        =   393216
            Value           =   1960
            BuddyControl    =   "vfisc_year"
            BuddyDispid     =   196634
            OrigLeft        =   10260
            OrigTop         =   1860
            OrigRight       =   10500
            OrigBottom      =   2160
            Max             =   1978
            Min             =   1960
            SyncBuddy       =   -1  'True
            BuddyProperty   =   0
            Enabled         =   -1  'True
         End
         Begin VB.TextBox vfisc_year 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -71250
            MaxLength       =   4
            TabIndex        =   12
            Tag             =   "20"
            Text            =   "vfisc_year"
            Top             =   3360
            Width           =   6800
         End
         Begin VB.Label Label21 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Expense Depreciation Account"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   60
            Top             =   1470
            Width           =   3495
         End
         Begin VB.Label Label20 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "   V.A.T.  No."
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -74640
            TabIndex        =   58
            Top             =   4155
            Width           =   2595
         End
         Begin VB.Label Label19 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Default Currency"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   57
            Top             =   3750
            Width           =   3495
         End
         Begin VB.Label Label18 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Output Tax"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   56
            Top             =   4200
            Width           =   3495
         End
         Begin VB.Label Label17 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Default Output Tax Account"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   55
            Top             =   3330
            Width           =   3495
         End
         Begin VB.Label Label16 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Default Payables Account"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   54
            Top             =   2880
            Width           =   3495
         End
         Begin VB.Label Label15 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Default Sales Account"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   53
            Top             =   2430
            Width           =   3495
         End
         Begin VB.Label Label14 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Default AR Account"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   52
            Top             =   1950
            Width           =   3495
         End
         Begin VB.Label Label13 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Asset Depreciation Account"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   51
            Top             =   1020
            Width           =   3495
         End
         Begin VB.Label Label12 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Current Earnings Account"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   330
            Left            =   450
            TabIndex        =   50
            Top             =   540
            Width           =   3495
         End
         Begin VB.Label Label11 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Current Fiscal Year"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   -74295
            TabIndex        =   49
            Top             =   3375
            Width           =   2715
         End
         Begin VB.Label Label10 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     Starting Year"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   -74310
            TabIndex        =   48
            Top             =   2625
            Width           =   2715
         End
         Begin VB.Label Label9 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "     No. of Period"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   -74280
            TabIndex        =   47
            Top             =   1200
            Width           =   2715
         End
         Begin VB.Label Label8 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "    Current Fiscal Period"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Left            =   -74310
            TabIndex        =   46
            Top             =   1920
            Width           =   2715
         End
         Begin VB.Label Label7 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "   Tax Identification No."
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -74640
            TabIndex        =   45
            Top             =   3465
            Width           =   2595
         End
         Begin VB.Label Label6 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "   Telephone No."
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -74640
            TabIndex        =   44
            Top             =   2775
            Width           =   2595
         End
         Begin VB.Label Label3 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "   Company Address"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -74640
            TabIndex        =   43
            Top             =   2070
            Width           =   2595
         End
         Begin VB.Label Label2 
            BackColor       =   &H80000004&
            BorderStyle     =   1  'Fixed Single
            Caption         =   "   Company Name"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -74640
            TabIndex        =   42
            Top             =   1320
            Width           =   2595
         End
         Begin VB.Label Label1 
            BorderStyle     =   1  'Fixed Single
            Caption         =   "   Company Code"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   12
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   390
            Left            =   -74640
            TabIndex        =   41
            Top             =   615
            Width           =   2595
         End
      End
      Begin VB.TextBox vuserid 
         Height          =   315
         Left            =   9765
         TabIndex        =   35
         Tag             =   "20"
         Text            =   "vuserid"
         Top             =   165
         Visible         =   0   'False
         Width           =   840
      End
      Begin MSComDlg.CommonDialog CommonDialog1 
         Left            =   7950
         Top             =   90
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin ComctlLib.ImageList ImageList1 
         Left            =   8580
         Top             =   60
         _ExtentX        =   1005
         _ExtentY        =   1005
         BackColor       =   -2147483643
         ImageWidth      =   32
         ImageHeight     =   32
         MaskColor       =   12632256
         _Version        =   393216
         BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
            NumListImages   =   14
            BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":19DF
               Key             =   ""
            EndProperty
            BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":1CFB
               Key             =   ""
            EndProperty
            BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":2017
               Key             =   ""
            EndProperty
            BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":2333
               Key             =   ""
            EndProperty
            BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":264F
               Key             =   ""
            EndProperty
            BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":296B
               Key             =   ""
            EndProperty
            BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":2C87
               Key             =   ""
            EndProperty
            BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":2FA3
               Key             =   ""
            EndProperty
            BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":32BF
               Key             =   ""
            EndProperty
            BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":35DB
               Key             =   ""
            EndProperty
            BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":38F7
               Key             =   ""
            EndProperty
            BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":3C13
               Key             =   ""
            EndProperty
            BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":3F2F
               Key             =   ""
            EndProperty
            BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "fComp.frx":424B
               Key             =   ""
            EndProperty
         EndProperty
      End
      Begin VB.Label bUser 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "BJS  Bienvenido J. Secades"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   360
         Left            =   2700
         TabIndex        =   39
         Top             =   6210
         Width           =   8745
      End
      Begin VB.Label Tit 
         Alignment       =   2  'Center
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Company Table Maintenance"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   21.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   540
         Left            =   390
         TabIndex        =   38
         Top             =   405
         Width           =   11175
      End
      Begin VB.Label Label4 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         Caption         =   "User"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   360
         Left            =   555
         TabIndex        =   37
         Top             =   6210
         Width           =   2100
      End
      Begin VB.Label Label5 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         ForeColor       =   &H80000008&
         Height          =   5655
         Left            =   405
         TabIndex        =   36
         Top             =   1080
         Width           =   11175
      End
      Begin VB.Image Image1 
         Appearance      =   0  'Flat
         Height          =   7020
         Left            =   -45
         Picture         =   "fComp.frx":4567
         Stretch         =   -1  'True
         Top             =   120
         Width           =   11910
      End
   End
   Begin ComctlLib.ProgressBar ProgBar 
      Height          =   345
      Left            =   7545
      TabIndex        =   33
      Top             =   8010
      Visible         =   0   'False
      Width           =   4350
      _ExtentX        =   7673
      _ExtentY        =   609
      _Version        =   393216
      Appearance      =   1
   End
   Begin ComctlLib.StatusBar StatBar 
      Align           =   2  'Align Bottom
      Height          =   360
      Left            =   0
      TabIndex        =   32
      Top             =   7980
      Width           =   11910
      _ExtentX        =   21008
      _ExtentY        =   635
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   2
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   2
            Object.Width           =   13203
            MinWidth        =   13213
            Key             =   "statbar"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Object.Width           =   13124
            MinWidth        =   13124
            Key             =   "progbar"
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin ComctlLib.Toolbar Toolbar1 
      Align           =   1  'Align Top
      Height          =   810
      Left            =   0
      TabIndex        =   31
      Top             =   0
      Width           =   11910
      _ExtentX        =   21008
      _ExtentY        =   1429
      ButtonWidth     =   1376
      ButtonHeight    =   1376
      Style           =   1
      ImageList       =   "ImageList1"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   19
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "New"
            Key             =   "Knew"
            Object.ToolTipText     =   "Add New Record"
            ImageIndex      =   1
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Save"
            Key             =   "Ksave"
            Object.ToolTipText     =   "Save and Commit Transaction"
            ImageIndex      =   2
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "  Cancel  "
            Key             =   "Kcancel"
            Object.ToolTipText     =   "Cancel Transaction"
            ImageIndex      =   3
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "QBE"
            Key             =   "Kqbe"
            Object.ToolTipText     =   "Enter Query By Example"
            ImageIndex      =   4
         EndProperty
         BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Query"
            Key             =   "Kquery"
            Object.ToolTipText     =   "Do Query"
            ImageIndex      =   5
         EndProperty
         BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "End"
            Key             =   "Kend"
            Object.ToolTipText     =   "End Query"
            ImageIndex      =   6
         EndProperty
         BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Edit"
            Key             =   "Kedit"
            Object.ToolTipText     =   "Edit Record"
            ImageIndex      =   7
         EndProperty
         BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Delete"
            Key             =   "Kdelete"
            Object.ToolTipText     =   "Delete Record"
            ImageIndex      =   8
         EndProperty
         BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Print"
            Key             =   "Kprint"
            Object.ToolTipText     =   "Print Record Set"
            ImageIndex      =   9
         EndProperty
         BeginProperty Button13 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button14 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "First"
            Key             =   "Kfirst"
            Object.ToolTipText     =   "First Record"
            ImageIndex      =   10
         EndProperty
         BeginProperty Button15 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Prev."
            Key             =   "Kprev"
            Object.ToolTipText     =   "Previous Record"
            ImageIndex      =   11
         EndProperty
         BeginProperty Button16 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Next"
            Key             =   "Knext"
            Object.ToolTipText     =   "Next Record"
            ImageIndex      =   12
         EndProperty
         BeginProperty Button17 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Last"
            Key             =   "Klast"
            Object.ToolTipText     =   "Last Record"
            ImageIndex      =   13
         EndProperty
         BeginProperty Button18 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button19 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Pop-Up"
            Key             =   "Kpopup"
            Object.ToolTipText     =   "Look up"
            ImageIndex      =   14
         EndProperty
      EndProperty
      BorderStyle     =   1
      MousePointer    =   99
      MouseIcon       =   "fComp.frx":8BE4
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Index           =   5
      Begin VB.Menu smnuPref 
         Caption         =   "Pre&ferences"
      End
      Begin VB.Menu smnuPrnt 
         Caption         =   "Print Query"
         Shortcut        =   ^P
      End
      Begin VB.Menu sep 
         Caption         =   "--------------------"
         Enabled         =   0   'False
      End
      Begin VB.Menu smnuExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "&Edit"
      Begin VB.Menu smnuNew 
         Caption         =   "&New"
         Shortcut        =   {F2}
      End
      Begin VB.Menu smnuSave 
         Caption         =   "Sa&ve"
         Shortcut        =   {F5}
      End
      Begin VB.Menu smnuModify 
         Caption         =   "Mo&dify"
         Shortcut        =   {F4}
      End
      Begin VB.Menu smnuDel 
         Caption         =   "De&lete"
         Shortcut        =   {F8}
      End
      Begin VB.Menu sep2 
         Caption         =   "----------------------------"
         Enabled         =   0   'False
      End
      Begin VB.Menu smnuCancel 
         Caption         =   "Cancel"
      End
   End
   Begin VB.Menu mnuQuery 
      Caption         =   "&Query"
      Begin VB.Menu smnuQbe 
         Caption         =   "Enter QBE"
         Shortcut        =   {F3}
      End
      Begin VB.Menu smnuDo 
         Caption         =   "Do Query"
         Shortcut        =   {F6}
      End
      Begin VB.Menu smnuEnd 
         Caption         =   "End Query"
      End
   End
   Begin VB.Menu mnuRecord 
      Caption         =   "&Record"
      Begin VB.Menu smnuFirst 
         Caption         =   "First"
         Shortcut        =   ^{F11}
      End
      Begin VB.Menu smnuPrev 
         Caption         =   "Previous"
         Shortcut        =   {F11}
      End
      Begin VB.Menu smnuNext 
         Caption         =   "Next"
         Shortcut        =   {F12}
      End
      Begin VB.Menu smnuLast 
         Caption         =   "Last"
         Shortcut        =   ^{F12}
      End
      Begin VB.Menu sep4 
         Caption         =   "----------------------------"
         Enabled         =   0   'False
      End
      Begin VB.Menu smnuSearch 
         Caption         =   "Look Up"
      End
   End
   Begin VB.Menu smnuAb 
      Caption         =   "&About"
   End
End
Attribute VB_Name = "fComp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
  
Public Sub FillFields()
   OldCode = vcomp_code.Text
   OldDesc = vcomp_name.Text
   r = DT.FindValue("SELECT USER_NAM FROM " & gAlias & "USERTAB WHERE USER_ID = '" & vuserid.Text & "'")
   If Len(Trim$(r)) > 0 Then
      bUser.Caption = vuserid.Text & "  " & r
   Else
      bUser.Caption = "Not Available"
   End If
   
   'DispFormat fComp   'Display Numeric Pictures
   
End Sub

Public Sub OnOff()
       
   Select Case UCase$(Prg_Sw)
      Case "INIT"
         Toolbar1.Buttons("Knew").Enabled = True
         Toolbar1.Buttons("Kqbe").Enabled = True
         smnuNew.Enabled = True
         smnuQbe.Enabled = True
              
         InitFld (fComp)
                                               
         Toolbar1.Buttons("Ksave").Enabled = False
         Toolbar1.Buttons("Kcancel").Enabled = False
         Toolbar1.Buttons("Kquery").Enabled = False
         Toolbar1.Buttons("Kend").Enabled = False
         Toolbar1.Buttons("Kedit").Enabled = False
         Toolbar1.Buttons("Kdelete").Enabled = False
         Toolbar1.Buttons("Kprint").Enabled = False
         Toolbar1.Buttons("Kfirst").Enabled = False
         Toolbar1.Buttons("Kprev").Enabled = False
         Toolbar1.Buttons("Knext").Enabled = False
         Toolbar1.Buttons("Klast").Enabled = False
         Toolbar1.Buttons("Kpopup").Enabled = False
         smnuSave.Enabled = False
         smnuCancel.Enabled = False
         smnuDo.Enabled = False
         smnuEnd.Enabled = False
         smnuModify.Enabled = False
         smnuDel.Enabled = False
         smnuPrnt.Enabled = False
         smnuFirst.Enabled = False
         smnuPrev.Enabled = False
         smnuNext.Enabled = False
         smnuLast.Enabled = False
         smnuSearch.Enabled = False
               
         DisableFLd (fComp)
         Frame1.Enabled = False
                             
      Case "NEW"
         Toolbar1.Buttons("Ksave").Enabled = True
         Toolbar1.Buttons("Kcancel").Enabled = True
         smnuSave.Enabled = True
         smnuCancel.Enabled = True
             
         EnableFLd (fComp)
         Frame1.Enabled = True
                
         Toolbar1.Buttons("Knew").Enabled = False
         Toolbar1.Buttons("Kqbe").Enabled = False
         Toolbar1.Buttons("Kquery").Enabled = False
         Toolbar1.Buttons("Kend").Enabled = False
         Toolbar1.Buttons("Kedit").Enabled = False
         Toolbar1.Buttons("Kdelete").Enabled = False
         Toolbar1.Buttons("Kprint").Enabled = False
         Toolbar1.Buttons("Kfirst").Enabled = False
         Toolbar1.Buttons("Kprev").Enabled = False
         Toolbar1.Buttons("Knext").Enabled = False
         Toolbar1.Buttons("Klast").Enabled = False
         Toolbar1.Buttons("Kpopup").Enabled = False
         smnuNew.Enabled = False
         smnuQbe.Enabled = False
         smnuDo.Enabled = False
         smnuEnd.Enabled = False
         smnuModify.Enabled = False
         smnuDel.Enabled = False
         smnuPrnt.Enabled = False
         smnuFirst.Enabled = False
         smnuPrev.Enabled = False
         smnuNext.Enabled = False
         smnuLast.Enabled = False
         smnuSearch.Enabled = False
                
                
      Case "QBE"
         Toolbar1.Buttons("Kcancel").Enabled = True
         Toolbar1.Buttons("Kquery").Enabled = True
         smnuDo.Enabled = True
         smnuCancel.Enabled = True
              
         EnableFLd (fComp)
         Frame1.Enabled = True
               
         Toolbar1.Buttons("Knew").Enabled = False
         Toolbar1.Buttons("Ksave").Enabled = False
         Toolbar1.Buttons("Kqbe").Enabled = False
         Toolbar1.Buttons("Kend").Enabled = False
         Toolbar1.Buttons("Kedit").Enabled = False
         Toolbar1.Buttons("Kdelete").Enabled = False
         Toolbar1.Buttons("Kprint").Enabled = False
         Toolbar1.Buttons("Kfirst").Enabled = False
         Toolbar1.Buttons("Kprev").Enabled = False
         Toolbar1.Buttons("Knext").Enabled = False
         Toolbar1.Buttons("Klast").Enabled = False
         Toolbar1.Buttons("Kpopup").Enabled = False
         smnuSave.Enabled = False
         smnuNew.Enabled = False
         smnuQbe.Enabled = False
         smnuEnd.Enabled = False
         smnuModify.Enabled = False
         smnuDel.Enabled = False
         smnuPrnt.Enabled = False
         smnuFirst.Enabled = False
         smnuPrev.Enabled = False
         smnuNext.Enabled = False
         smnuLast.Enabled = False
         smnuSearch.Enabled = False
             
      Case "BROWSE"
         Toolbar1.Buttons("Kcancel").Enabled = True
         Toolbar1.Buttons("Kend").Enabled = True
         Toolbar1.Buttons("Kedit").Enabled = True
         Toolbar1.Buttons("Kdelete").Enabled = True
         Toolbar1.Buttons("Kprint").Enabled = True
         Toolbar1.Buttons("Kfirst").Enabled = True
         Toolbar1.Buttons("Kprev").Enabled = True
         Toolbar1.Buttons("Knext").Enabled = True
         Toolbar1.Buttons("Klast").Enabled = True
         Toolbar1.Buttons("Kpopup").Enabled = True
         smnuCancel.Enabled = True
         smnuEnd.Enabled = True
         smnuModify.Enabled = True
         smnuDel.Enabled = True
         smnuPrnt.Enabled = True
         smnuFirst.Enabled = True
         smnuPrev.Enabled = True
         smnuNext.Enabled = True
         smnuLast.Enabled = True
         smnuSearch.Enabled = True
               
         Toolbar1.Buttons("Knew").Enabled = False
         Toolbar1.Buttons("Ksave").Enabled = False
         Toolbar1.Buttons("Kqbe").Enabled = False
         Toolbar1.Buttons("Kquery").Enabled = False
         smnuNew.Enabled = False
         smnuSave.Enabled = False
         smnuQbe.Enabled = False
         smnuDo.Enabled = False
               
      Case "EDIT"
         Toolbar1.Buttons("Ksave").Enabled = True
         Toolbar1.Buttons("Kcancel").Enabled = True
         smnuSave.Enabled = True
         smnuCancel.Enabled = True
               
         Toolbar1.Buttons("Knew").Enabled = False
         Toolbar1.Buttons("Kqbe").Enabled = False
         Toolbar1.Buttons("Kquery").Enabled = False
         Toolbar1.Buttons("Kend").Enabled = False
         Toolbar1.Buttons("Kedit").Enabled = False
         Toolbar1.Buttons("Kdelete").Enabled = False
         Toolbar1.Buttons("Kprint").Enabled = False
         Toolbar1.Buttons("Kfirst").Enabled = False
         Toolbar1.Buttons("Kprev").Enabled = False
         Toolbar1.Buttons("Knext").Enabled = False
         Toolbar1.Buttons("Klast").Enabled = False
         Toolbar1.Buttons("Kpopup").Enabled = False
         smnuNew.Enabled = False
         smnuQbe.Enabled = False
         smnuDo.Enabled = False
         smnuEnd.Enabled = False
         smnuModify.Enabled = False
         smnuDel.Enabled = False
         smnuPrnt.Enabled = False
         smnuFirst.Enabled = False
         smnuPrev.Enabled = False
         smnuNext.Enabled = False
         smnuLast.Enabled = False
         smnuSearch.Enabled = False
                
   End Select
       
End Sub

Private Sub Command1_Click()
 
End Sub

Private Sub Command1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
ValidSw = False
End Sub

Private Sub appr_byBTN_Click()
  
End Sub

Private Sub appr_byBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)

End Sub

Private Sub appr_descBTN_Click()

End Sub

Private Sub appr_descBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)

End Sub

Private Sub check_byBTN_Click()
 
End Sub

Private Sub check_byBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
ValidSw = False
End Sub

Private Sub check_descBTN_Click()
   r = "Check Description Table Look-Up (By Code) "
   s = ""
   SelectNow r, "user_id", "user_nam", "wcheck_desc", "vcheck_by", "usertab", s, 2
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub check_descBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
ValidSw = False
End Sub

Private Sub comp_codeBTN_Click()
   r = "Company Code Table Look-Up (By Code) "
   s = ""
   SelectNow r, "comp_code", "comp_name", "vcomp_code", "wcomp_desc", "company", s, 1
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub comp_codeBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
   ValidSw = False
End Sub

Private Sub comp_descBTN_Click()
  
End Sub

Private Sub def_currBTN_Click()
    NoTab = True
    AcctDetails vcomp_code.Text, "vdef_curr", "wa_desc"
   If TabSw = True And Sw5 = True Then
      SendKeys "{tab}"
   End If
   DoEvents
   NoTab = False
   If UCase$(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub def_currBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub gl_curr_earnBTN_Click()
   NoTab = True
   AcctDetails vcomp_code.Text, "vgl_curr_earn", "wa_desc"
   If TabSw = True And Sw5 = True Then
      SendKeys "{tab}"
   End If
   DoEvents
   NoTab = False
   If UCase$(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub gl_curr_earnBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
   ValidSw = False
End Sub

Private Sub Form_Activate()

   If FirstPass = True Then
      Screen.MousePointer = 0
      Set MyFrm = fComp
   End If
   
   Frame1.Top = 825
   Frame1.Left = 0
   Frame1.Height = 7190
   Frame1.Width = 11935
   
   StatBar.Height = 360
   'StatBar.Left = 0
   StatBar.Top = 7995
   'StatBar.Width = 11910
   
   ProgBar.Top = 8010
   ProgBar.Left = 7545
   ProgBar.Height = 345
   ProgBar.Width = 4350
   
   Image1.Height = 7020
   Image1.Width = 11805
   Image1.Left = 60
   Image1.Top = 75
   
   If FirstPass = True Then
      FirstPass = False
   End If
   ProgBar.Top = StatBar.Top + 40
   
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
   If UCase$(Prg_Sw) = "BROWSE" Then
      If Shift = 0 Then
         If KeyCode = 39 Or KeyCode = 40 Then
            smnunext_Click
         End If
         If KeyCode = 37 Or KeyCode = 38 Then
            smnuprev_Click
         End If
         If KeyCode = 36 Then
            smnufirst_Click
         End If
         If KeyCode = 35 Then
            smnulast_Click
         End If
      End If
   End If
End Sub



Private Sub Form_Load()
   Prg_Sw = "INIT"
   OnOff
   r = DT.FindValue("SELECT USER_NAM FROM " & gAlias & "USERTAB WHERE USER_ID = '" & gUser_Id & "'")
   bUser.Caption = gUser_Id & "  " & r
   gCur_User = gUser_Id & "  " & r
   gComp_Des = DT.FindValue("SELECT COMP_NAME FROM " & gAlias & "COMPANY WHERE COMP_CODE = '" & gComp_Code & "'")
   OldCode = ""
   OldDesc = ""
   ValidSw = False
   Unload fIntro
   
   SSTab1.Tab = 0
   UpDown3.Max = Format(Now, "yyyy")
   UpDown4.Max = Format(Now, "yyyy")
  
End Sub






Private Sub sl_typeBTN_Click()
r = "Subsidiary Ledger Type Table Look-Up (By SL Code)"
   s = "comp_code = '" & gComp_Code & "'"
   SelectNow r, "sl_type", "sl_desc", "vsl_type", "wsl_desc", "gl_sl001", s, 1
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub sl_typeBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub gl_cust_defBTN_Click()
   NoTab = True
   AcctDetails vcomp_code.Text, "vgl_cust_def", "wa_desc"
   If TabSw = True And Sw5 = True Then
      SendKeys "{Tab}"
   End If
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub gl_cust_defBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub gl_otaxBTN_Click()
   NoTab = True
   AcctDetails vcomp_code.Text, "vgl_otax", "wa_desc"
   If TabSw = True And Sw5 = True Then
   SendKeys "{Tab}"
   End If
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub gl_otaxBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub gl_depr_acct1BTN_Click()
   NoTab = True
   AcctAny vcomp_code.Text, "vgl_depr_acct1", "wa_desc"
   If TabSw = True And Sw5 = True Then
   SendKeys "{Tab}"
   End If
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub gl_depr_acct1BTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub vgl_depr_acct2_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          gl_depr_acct2BTN.SetFocus
          gl_depr_acct2BTN_Click
      End If
   End If
End Sub

Private Sub vgl_depr_acct2_KeyPress(KeyAscii As Integer)
    KeyAscii = GenKeyPress(KeyAscii)           ' Use This for Text
   If KeyAscii = 13 Then
      TabSw = True
   End If
   If KeyAscii = 9 Then
      TabSw = False
   End If
End Sub

Private Sub vgl_depr_acct2_LostFocus()
   If ValidSw = True Then
      vgl_depr_acct2.Text = Text_Format(vgl_depr_acct2.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vgl_depr_acct2", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "'")
         If Validated = True Then
            r = ""
           
            If TabSw = True Then
               TabSw = False
               SendKeys "{Tab}"
               
               DoEvents
               
            End If
         End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vgl_depr_acct2.Text = Text_Format(vgl_depr_acct2.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub gl_depr_acct2BTN_Click()
   NoTab = True
   AcctAny vcomp_code.Text, "vgl_depr_acct2", "wa_desc"
   If TabSw = True And Sw5 = True Then
   SendKeys "{Tab}"
   End If
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub gl_depr_acct2BTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub gl_sale_defBTN_Click()
    NoTab = True
   AcctDetails vcomp_code.Text, "vgl_sale_def", "wa_desc"
   If TabSw = True And Sw5 = True Then
   SendKeys "{Tab}"
   End If
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub gl_sale_defBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub gl_supp_defBTN_Click()
     NoTab = True
   AcctDetails vcomp_code.Text, "vgl_supp_def", "wa_desc"
   If TabSw = True And Sw5 = True Then
   SendKeys "{Tab}"
   End If
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub gl_supp_defBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ValidSw = False
End Sub

Private Sub smnuAb_Click()
   StatBar.Panels.Item(1).Text = " Dynamic Technologies, About Window ..."
   frmAbout.Show vbModal, fComp
   fComp.Refresh
   StatBar.Panels.Item(1).Text = ""
End Sub

Private Sub smnuCancel_Click()
   StatBar.Panels.Item(1).Text = ""
   ValidSw = False
   Select Case UCase$(Prg_Sw)
       Case "NEW"
           Prg_Sw = "INIT"
           OnOff
           fComp.SetFocus
       Case "QBE"
           SetLen (fComp)
           Prg_Sw = "INIT"
           OnOff
           fComp.SetFocus
       Case "BROWSE"
           DT.CloseSQL "Qry1"
           smnuqbe_Click
       Case "EDIT"
           StatBar.Panels.Item(1).Text = " Cancel Updates in Progress, Please Wait ..."
           fComp.MousePointer = 11
           bK = QCur1.Bookmark
           DT.CloseSQL "Qry1"
           If gSrtQry = "Cod" Then
              DT.SetSql "Qry1", "select * from " & gAlias & "company where " & QbeStr & "  order by " & OrdByCode
           Else
              DT.SetSql "Qry1", "select * from " & gAlias & "company where " & QbeStr & "  order by " & OrdByDesc
           End If
           Set QCur1 = DT.Qry1
           BindFLd fComp, QCur1
           QCur1.Bookmark = bK
           fComp.MousePointer = 0
           StatBar.Panels.Item(1).Text = " Browse Record(s) ..."
           Prg_Sw = "BROWSE"
           OnOff
           EnableFLd (fComp)
           Frame1.Enabled = False
           fComp.SetFocus
   End Select
End Sub

Private Sub smnudel_Click()
Dim Msg1, Style1, Response As Variant
    If g_Del = False Then
       FindError "DENIED"
       'MsgBox "ACCESS DENIED, You are not authorized to execute this module !!!", , Title1
       Exit Sub
    End If
    StatBar.Panels.Item(1).Text = " Delete Current Record ..."
    Msg1 = "Are you sure you want to delete ?"   ' Define message.
    Style1 = vbYesNo + vbDefaultButton1 ' Define buttons.
    Response = RetError("DELETE_YN", Style1)
    If Response = vbYes Then    ' User chose Yes.
       bK = QCur1.Bookmark
       'DT.BeginWork
       s = "delete from " & gAlias & "company where comp_code = '" & OldCode & "'"
       SqlResult = DT.ExecSQL(s)
       'DT.CommitWork
       StatBar.Panels.Item(1).Text = " Delete in Progress, Please wait ..."
       fComp.MousePointer = 11
       DT.CloseSQL "Qry1"
       If gSrtQry = "Cod" Then
          DT.SetSql "Qry1", "select * from " & gAlias & "company where " & QbeStr & "  order by " & OrdByCode
       Else
          DT.SetSql "Qry1", "select * from " & gAlias & "company where " & QbeStr & "  order by " & OrdByDesc
       End If
       Set QCur1 = DT.Qry1
       BindFLd fComp, QCur1
       fComp.MousePointer = 0
       If QCur1.EOF Then
          If gDispDel = "Y" Then
             FindError "LAST_ROWSET_DEL"
             'MsgBox "Last Row of Recordset Successfully Deleted.", , Title1
          End If
          smnuend_Click
       Else
          If bK - 1 > 0 Then
             QCur1.Bookmark = bK - 1
             QCur1.MoveNext
             If QCur1.EOF Then
                QCur1.MoveLast
             End If
          End If
          If gDispDel = "Y" Then
             FindError "RECORD_DELETED"
             'MsgBox "Record Successfully Deleted.", , Title1
          End If
          FillFields
       End If
       StatBar.Panels.Item(1).Text = " Browse Record(s) ..."
    End If
End Sub

Private Sub smnudo_Click()
   StatBar.Panels.Item(1).Text = " Query In Progress, Please Wait ..."
   Frame1.Enabled = False       'DisableFLd (fComp)
   fComp.MousePointer = 11
   QbeStr = BldWhere(fComp, "")
   If gSrtQry = "Cod" Then
      DT.SetSql "Qry1", "select * from " & gAlias & "company where " & QbeStr & "  order by " & OrdByCode
   Else
      DT.SetSql "Qry1", "select * from " & gAlias & "company where " & QbeStr & "  order by " & OrdByDesc
   End If
   Set QCur1 = DT.Qry1
   BindFLd fComp, QCur1
   fComp.MousePointer = 0
   If QCur1.EOF Then
      StatBar.Panels.Item(1).Text = ""
      FindError "NOROWS"
      'MsgBox "No Row(s) Satisfy Query, Press [OK Button] to Retry.", , Title1
      DT.CloseSQL "Qry1"
      smnuqbe_Click
      Exit Sub
   Else
      StatBar.Panels.Item(1).Text = " Browse Record(s) ..."
      Prg_Sw = "BROWSE"
      OnOff
      SetLen (fComp)
      QCur1.MoveFirst
      FillFields
   End If
   fComp.SetFocus
   If gGrdQry = "Y" Then
      PopNow "Subsidiary Ledger Type Selection Criteria", "user_id", "", QCur1
   End If
End Sub

Private Sub smnuend_Click()
   Prg_Sw = "INIT"
   OnOff
   DT.CloseSQL "Qry1"
End Sub

Private Sub smnuexit_Click()
   Unload Me
End Sub

Private Sub smnuModify_Click()
   If g_Change = False Then
      FindError "DENIED"
      'MsgBox "ACCESS DENIED, You are not authorized to execute this module !!!", , Title1
      Exit Sub
   End If
   StatBar.Panels.Item(1).Text = " Edit Current Record ..."
   Prg_Sw = "EDIT"
   OnOff
   
   vuserid.Text = gUser_Id
   r = DT.FindValue("SELECT USER_NAM FROM " & gAlias & "USERTAB WHERE USER_ID = '" & vuserid.Text & "'")
   If Len(Trim$(r)) > 0 Then
      bUser.Caption = gUser_Id & "  " & r
   Else
      bUser.Caption = "Not Available"
   End If
   Frame1.Enabled = True      'EnableFLd (fComp)
   FirstFocus
   ValidSw = True
   TabSw = False
End Sub

Private Sub smnuNew_Click()
   If g_Add = False Then
      FindError "DENIED"
      'MsgBox "ACCESS DENIED, You are not authorized to execute this module !!!", , Title1
      Exit Sub
   End If
   Prg_Sw = "NEW"
   OnOff
   UnBindFLd (fComp)
   FirstFocus
   vuserid.Text = gUser_Id
   SSTab1.Tab = 0
   DoEvents
   ValidSw = True
   TabSw = False
   StatBar.Panels.Item(1).Text = " Insert New Record ..."
End Sub

Private Sub smnufirst_Click()
   QCur1.MoveFirst
   FillFields
End Sub

Private Sub smnuPref_Click()
   StatBar.Panels.Item(1).Text = " Select Desired Settings ..."
   fPrefs.Show vbModal, fComp
   fComp.Refresh
   StatBar.Panels.Item(1).Text = ""
End Sub

Private Sub smnuprev_Click()
   QCur1.MovePrevious
   If QCur1.BOF Then
      QCur1.MoveFirst
      FindError "FIRST_RECORD"
      'MsgBox "BEGINNING OF RECORD SET !!!", , Title1
   End If
   FillFields
End Sub

Private Sub smnunext_Click()
   QCur1.MoveNext
   If QCur1.EOF Then
      QCur1.MoveLast
      FindError "LAST_RECORD"
      'MsgBox "END OF RECORD SET !!!", , Title1
   End If
   FillFields
End Sub

Private Sub smnulast_Click()
   QCur1.MoveLast
   FillFields
End Sub

Private Sub smnuPrnt_Click()
   If g_Prt = False Then
      FindError "DENIED"
      'MsgBox "ACCESS DENIED, You are not authorized to execute this module !!!", , Title1
      Exit Sub
   End If
   StatBar.Panels.Item(1).Text = " Please Select Print Preferences ..."
   CompGen Title1 & " - Company Table Report Generator", 80
End Sub

Private Sub smnuqbe_Click()
   If g_Query = False Then
      FindError "DENIED"
      'MsgBox "ACCESS DENIED, You are not authorized to execute this module !!!", , Title1
      Exit Sub
   End If
   StatBar.Panels.Item(1).Text = " Please Enter Selection Criteria ..."
   Prg_Sw = "QBE"
   OnOff
   UnBindFLd (fComp)
   InitFld (fComp)
   UnsetLen (fComp)
   FirstFocus
   ValidSw = False
   TabSw = False
   
  
   
End Sub

Private Sub FirstFocus()
   'vcomp_code.Text = gcomp_code
   bUser.Caption = gCur_User
   vcomp_code.SetFocus
End Sub

Private Sub smnusave_Click()
   StatBar.Panels.Item(1).Text = " Saving Record, Please Wait ..."
   Select Case UCase$(Prg_Sw)
      Case "EDIT"
         s = UpdSQL(fComp, "company", "comp_code = '" & vcomp_code & "'")
         'DT.BeginWork
         SqlResult = DT.ExecSQL(s)
         'DT.CommitWork
         ValidSw = False
         If gDispSav = "Y" Then
            FindError "UPDATE_SUCCSS"
            'MsgBox "Record Successfully Updated.", , Title1
         End If
         Prg_Sw = "BROWSE"
         OnOff
         StatBar.Panels.Item(1).Text = ""
         Frame1.Enabled = False
         fComp.SetFocus
         DoEvents
         ValidSw = True
      Case "NEW"
         If jTrim(vgl_otax_rat.Text) = "" Then
            vgl_otax_rat.Text = "0"
         End If
         s = InsSQL(fComp, "company")
         'DT.BeginWork
         SqlResult = DT.ExecSQL(s)
         'DT.CommitWork
         ValidSw = False
         If gDispSav = "Y" Then
            FindError "UPDATE_SUCCSS"
            'MsgBox "Record Successfully Updated.", , Title1
         End If
         Prg_Sw = "INIT"
         OnOff
         DoEvents
         StatBar.Panels.Item(1).Text = ""
         DisableFLd (fComp)
         Frame1.Enabled = False
         ValidSw = True
   End Select
End Sub

Private Sub smnuSearch_Click()
   StatBar.Panels.Item(1).Text = " Browse Record(s) ..."
   PopNow "Company Table Selection Criteria", "comp_code", "comp_name", QCur1
End Sub

Private Sub ssMnuPrt_Click()
   Dim BeginPage, EndPage, NumCopies, i
               ' Set Cancel to True
    CommonDialog1.CancelError = True
On Error GoTo ErrHandler
               ' Display the Print dialog box
    CommonDialog1.ShowPrinter
               ' Get user-selected values from the dialog box
    BeginPage = CommonDialog1.FromPage
    EndPage = CommonDialog1.ToPage
    NumCopies = CommonDialog1.Copies
    For i = 1 To NumCopies
               ' Put code here to send data to the printer

    Next i
    Exit Sub
ErrHandler:
    ' User pressed the Cancel button
    Exit Sub
End Sub

Private Sub sys_descBTN_Click()
 
End Sub

Private Sub sys_descBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)

End Sub

Private Sub sys_nameBTN_Click()
 r = "System Name Table Look-Up (By Code) "
   s = "type = '01' "
   SelectNow r, "code", "explain", "vsys_name", "wsys_desc", "common", s, 1
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub sys_nameBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
  ValidSw = False
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As ComctlLib.Button)
        
   Select Case Button.Key
       Case "Knew"
           smnuNew_Click
       Case "Kqbe"
           smnuqbe_Click
       Case "Kcancel"
           smnuCancel_Click
       Case "Kquery"
           smnudo_Click
       Case "Kend"
           smnuend_Click
       Case "Kedit"
           smnuModify_Click
       Case "Ksave"
           smnusave_Click
       Case "Kdelete"
           smnudel_Click
       Case "Kfirst"
           smnufirst_Click
       Case "Kprev"
           smnuprev_Click
       Case "Knext"
           smnunext_Click
       Case "Klast"
           smnulast_Click
       Case "Kpopup"
           smnuSearch_Click
       Case "Kprint"
           smnuPrnt_Click
       
   End Select
End Sub

Public Sub Form1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
   If Button = 2 Then
       PopupMenu mnuFile
   End If
End Sub

Private Function GenKeyPress(KeyPress As Integer) As Integer
   If KeyPress = 39 Then
       Beep
       GenKeyPress = 0
       Exit Function
   ElseIf KeyPress = 13 Then
      SendKeys "{tab}"
   End If
   If KeyPress = 27 Then
      smnuCancel_Click
   End If
   GenKeyPress = Asc(UCase$(Chr$(KeyPress)))
End Function

Private Function NumKeyPress(KeyPress As Integer) As Integer
   If KeyPress = 13 Then
      SendKeys "{tab}"
   End If
   If KeyPress = 27 Then
      smnuCancel_Click
   End If
   NumKeyPress = NumKeys(KeyPress)
End Function

Private Sub user_descBTN_Click()
   r = "User Group Table Look-Up (By Description) "
   s = "comp_code = '" & vcomp_code.Text & "' and sys_name = '" & vsys_name.Text & "'"
   SelectNow r, "user_grp", "grp_desc", "wuser_desc", "vuser_grp", "usergrp", s, 2
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub user_descBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
ValidSw = False
End Sub

Private Sub user_grpBTN_Click()
 r = "User Group Code Table Look-Up (By Code) "
   s = "comp_code = '" & vcomp_code.Text & "' and sys_name = '" & vsys_name.Text & "'"
   SelectNow r, "user_grp", "grp_desc", "vuser_grp", "wuser_desc", "usergrp", s, 1
   DoEvents
   If UCase(Prg_Sw) <> "QBE" Then ValidSw = True
End Sub

Private Sub user_grpBTN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
ValidSw = False
End Sub

Private Sub vappr_by_KeyDown(KeyCode As Integer, Shift As Integer)
   If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          appr_byBTN.SetFocus
          appr_byBTN_Click
      End If
   End If
End Sub

Private Sub vappr_by_KeyPress(KeyAscii As Integer)
  KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vappr_by_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "usertab", "vappr_by", "wappr_desc", "", "user_nam", "user_id", "")
      If Validated = True And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   End If
End Sub

Private Sub vappr_days_GotFocus()
If Len(Trim(vappr_limit.Text)) > 0 Then
     'vappr_limit.Text = Trim(StrTran(vappr_limit, ",", ""))
      vappr_limit.SelStart = 0
      vappr_limit.SelLength = Len(vappr_limit.Text)
   End If
End Sub

Private Sub vappr_days_KeyPress(KeyAscii As Integer)
If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vappr_days_LostFocus()
 If ValidSw = True Then
      Validated = FldValid(fComp, "", "vappr_days", "", "", "", "", "")
   End If
End Sub

Private Sub vappr_limit_GotFocus()
   If Len(Trim(vappr_limit.Text)) > 0 Then
      vappr_limit.Text = Trim(StrTran(vappr_limit, ",", ""))
      vappr_limit.SelStart = 0
      vappr_limit.SelLength = Len(vappr_limit.Text)
   End If
End Sub

Private Sub vappr_limit_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub


Private Sub vappr_limit_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "", "vappr_limit", "", "", "", "", "")
   End If
End Sub


Private Sub vcheck_by_KeyDown(KeyCode As Integer, Shift As Integer)
   If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          check_byBTN.SetFocus
          check_byBTN_Click
      End If
   End If
End Sub

Private Sub vcheck_by_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcheck_by_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "usertab", "vcheck_by", "wcheck_desc", "", "user_nam", "user_id", "")
      If Validated = True And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   End If
End Sub

Private Sub vcheck_days_GotFocus()
  If Len(Trim(vappr_limit.Text)) > 0 Then
     'vappr_limit.Text = Trim(StrTran(vappr_limit, ",", ""))
      vappr_limit.SelStart = 0
      vappr_limit.SelLength = Len(vappr_limit.Text)
   End If
End Sub

Private Sub vcheck_days_KeyPress(KeyAscii As Integer)
 If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcheck_days_LostFocus()
  If ValidSw = True Then
      Validated = FldValid(fComp, "", "vcheck_days", "", "", "", "", "")
   End If
End Sub

Private Sub vcomp_addr_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcomp_addr_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "company", "vcomp_addr", "", OldCode, "", "", "")
   End If
End Sub

Private Sub vcomp_code_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcomp_code_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "company", "vcomp_code", "", OldCode, "", "", "")
      If Validated = False Then
         SSTab1.Tab = 0
      End If
   End If
End Sub

Private Sub vpassword_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)     ' Use This for Text
End Sub


Private Sub vpassword_LostFocus()
   
End Sub


Private Sub vsys_name_KeyDown(KeyCode As Integer, Shift As Integer)
If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          sys_nameBTN.SetFocus
          sys_nameBTN_Click
      End If
   End If
End Sub

Private Sub vsys_name_KeyPress(KeyAscii As Integer)
 KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vsys_name_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "common", "vsys_name", "wsys_desc", "", "explain", "code", "type = '01'")
      If Validated = True And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   End If
End Sub

Private Sub vuser_grp_KeyDown(KeyCode As Integer, Shift As Integer)
   If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          user_grpBTN.SetFocus
          user_grpBTN_Click
      End If
   End If
End Sub


Private Sub vuser_grp_KeyPress(KeyAscii As Integer)
 KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub


Private Sub vuser_grp_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "usergrp", "vuser_grp", "wuser_desc", "", "grp_desc", "user_grp", "comp_code = '" & vcomp_code.Text & "' and sys_name = '" & vsys_name.Text & "'")
      If Validated = True And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}{Tab}{Tab}"
      End If
   End If
End Sub


Private Sub vuser_id_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)     ' Use This for Text
End Sub


Private Sub vuser_id_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "usertab", "vuser_id", "", OldCode, "", "", "")
   End If
End Sub


Private Sub vuser_nam_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)     ' Use This for Text
End Sub


Private Sub vuser_nam_LostFocus()
 If ValidSw = True Then
      Validated = FldValid(fComp, "usertab", "vuser_nam", "", OldDesc, "", "", "")
   End If
End Sub


Private Sub wappr_desc_KeyDown(KeyCode As Integer, Shift As Integer)
 If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          appr_descBTN.SetFocus
          appr_descBTN_Click
      End If
   End If
End Sub

Private Sub wappr_desc_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub wappr_desc_LostFocus()
 
End Sub

Private Sub wcheck_desc_KeyDown(KeyCode As Integer, Shift As Integer)
   If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          check_descBTN.SetFocus
          check_descBTN_Click
      End If
   End If
End Sub

Private Sub wcheck_desc_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub wcheck_desc_LostFocus()
   
End Sub

Private Sub wcomp_desc_KeyDown(KeyCode As Integer, Shift As Integer)
 
End Sub

Private Sub wcomp_desc_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub wcomp_desc_LostFocus()
   If ValidSw = True Or (UCase$(Prg_Sw) = "QBE" And TabSw = True) Then
      Validated = FldValid(fComp, "company", "wcomp_desc", "vcomp_code", "", "comp_code", "comp_name", "")
      If Validated = True And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}"
      End If
   End If
End Sub

Private Sub wsys_desc_KeyDown(KeyCode As Integer, Shift As Integer)
If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          sys_descBTN.SetFocus
          sys_descBTN_Click
      End If
   End If
End Sub


Private Sub wsys_desc_KeyPress(KeyAscii As Integer)
 KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub


Private Sub wsys_desc_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "common", "wsys_desc", "vsys_name", "", "code", "explain", "type = '01'")
      If Validated = True And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}"
      End If
   End If
End Sub


Private Sub wuser_desc_KeyDown(KeyCode As Integer, Shift As Integer)
   If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          user_descBTN.SetFocus
          user_descBTN_Click
      End If
   End If
End Sub


Private Sub wuser_desc_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub


Private Sub wuser_desc_LostFocus()
   If ValidSw = True Or (UCase$(Prg_Sw) = "QBE" And TabSw = True) Then
      Validated = FldValid(fComp, "usergrp", "wuser_desc", "vuser_grp", "", "user_grp", "grp_desc", "comp_code = '" & vcomp_code.Text & "' and sys_name = '" & vsys_name.Text & "'")
      If Validated = True And TabSw = True Then
         TabSw = False
         SendKeys "{Tab}"
      End If
   End If
End Sub

Private Sub vcomp_name_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcomp_name_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "company", "vcomp_name", "", OldCode, "", "", "")
   End If
End Sub

Private Sub vcomp_tel_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcomp_tel_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "company", "vcomp_tel", "", OldCode, "", "", "")
   End If
End Sub

Private Sub vcomp_tin_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcomp_tin_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "company", "vcomp_tin", "", OldCode, "", "", "")
   End If
End Sub

Private Sub vcomp_vat_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)                   ' Use This for text
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcomp_vat_LostFocus()
   If ValidSw = True Then
      Validated = FldValid(fComp, "company", "vcomp_vat", "", OldCode, "", "", "")
      If Validated = True And TabSw = True Then
         TabSw = False
         DoEvents
         SSTab1.Tab = 1
         vnum_fisc.SetFocus
         'SendKeys "{Tab}"
         
      End If
   End If
   
End Sub

Private Sub vcur_fisc_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vcur_fisc_LostFocus()
   If ValidSw = True Then
        If Val(vcur_fisc) < UpDown1.Min Or Val(vcur_fisc) > UpDown1.Max Then
           FindError "INVALID_NUM"
           'MsgBox "You entered an invalid No.!!!", , Title1
           vcur_fisc.SetFocus
           vcur_fisc.SelStart = 0
           vcur_fisc.SelLength = Len(vcur_fisc.Text)
        Else
           Validated = FldValid(fComp, "company", "vcur_fisc", "", OldCode, "", "", "")
           If Validated = True And TabSw = True Then
           TabSw = False
           DoEvents
           SendKeys "(Tab),{Tab}"
         End If
      End If
   End If
End Sub

Private Sub vdef_curr_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          def_currBTN.SetFocus
          def_currBTN_Click
      End If
   End If
End Sub

Private Sub vdef_curr_KeyPress(KeyAscii As Integer)
    If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vdef_curr_LostFocus()
    If ValidSw = True Then
      vdef_curr.Text = Text_Format(vdef_curr.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vdef_curr", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "' and a_type = 0")
         If Validated = True Then
            r = ""
           
            If TabSw = True Then
               TabSw = False
               SendKeys "{Tab}"
               
               DoEvents
               
            End If
         End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vdef_curr.Text = Text_Format(vdef_curr.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub vfisc_year_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vfisc_year_LostFocus()
     If ValidSw = True Then
        If Val(vfisc_year) < 1960 Or Val(vfisc_year) > UpDown3.Max Or Val(vfisc_year) < Val(vstfisc_year) Then
           FindError "INVALID_YEAR"
           'MsgBox "You entered an invalid year!!!", , Title1
           vfisc_year.SetFocus
        Else
   
           Validated = FldValid(fComp, "company", "vfisc_year", "", OldCode, "", "", "")
           If Validated = True And TabSw = True Then
              TabSw = False
              If Prg_Sw = "NEW" Then
              SSTab1.Tab = 0
           Else
              SSTab1.Tab = 2
           End If
           SendKeys "{Tab}"
        End If
      End If
   End If
End Sub

Private Sub vgl_curr_earn_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          gl_curr_earnBTN.SetFocus
          gl_curr_earnBTN_Click
      End If
   End If
End Sub

Private Sub vgl_curr_earn_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)           ' Use This for Text
   If KeyAscii = 13 Then
      TabSw = True
   End If
   If KeyAscii = 9 Then
      TabSw = False
   End If
   
End Sub

Private Sub vgl_curr_earn_LostFocus()
   If ValidSw = True Then
      vgl_curr_earn.Text = Text_Format(vgl_curr_earn.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vgl_curr_earn", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "' and a_type = 0")
      If Validated = True Then
         r = ""
           
         If TabSw = True Then
            TabSw = False
            SendKeys "{Tab}"
               
            DoEvents
               
         End If
      End If
      
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vgl_curr_earn.Text = Text_Format(vgl_curr_earn.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub vgl_cust_def_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          gl_cust_defBTN.SetFocus
          gl_cust_defBTN_Click
      End If
   End If
End Sub

Private Sub vgl_cust_def_KeyPress(KeyAscii As Integer)
    KeyAscii = GenKeyPress(KeyAscii)           ' Use This for Text
   If KeyAscii = 13 Then
      TabSw = True
   End If
   If KeyAscii = 9 Then
      TabSw = False
   End If
End Sub

Private Sub vgl_cust_def_LostFocus()
     If ValidSw = True Then
      vgl_cust_def.Text = Text_Format(vgl_cust_def.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vgl_cust_def", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "' and a_type = 0")
         If Validated = True Then
            r = ""
           
            If TabSw = True Then
               TabSw = False
               SendKeys "{Tab}"
               
               DoEvents
               
            End If
         End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vgl_cust_def.Text = Text_Format(vgl_cust_def.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub vgl_otax_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          gl_otaxBTN.SetFocus
          gl_otaxBTN_Click
      End If
   End If
End Sub

Private Sub vgl_otax_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)           ' Use This for Text
   If KeyAscii = 13 Then
      TabSw = True
   End If
   If KeyAscii = 9 Then
      TabSw = False
   End If
End Sub

Private Sub vgl_otax_LostFocus()
    If ValidSw = True Then
      vgl_otax.Text = Text_Format(vgl_otax.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vgl_otax", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "' and a_type = 0")
         If Validated = True Then
            r = ""
           
            If TabSw = True Then
               TabSw = False
               SendKeys "{Tab}"
               
               DoEvents
               
            End If
         End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vgl_otax.Text = Text_Format(vgl_otax.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub vgl_otax_rat_GotFocus()
 If Len(Trim(vgl_otax_rat.Text)) > 0 Then
      vgl_otax_rat.Text = Trim(StrTran(vgl_otax_rat, ",", ""))
      vgl_otax_rat.SelStart = 0
      vgl_otax_rat.SelLength = Len(vgl_otax_rat.Text)
         
   End If
End Sub

Private Sub vgl_otax_rat_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vgl_otax_rat_LostFocus()
    If ValidSw = True Then
      Validated = FldValid(fComp, "", "vgl_otax_rat", "", "", "", "", "")
     
   End If
End Sub

Private Sub vgl_depr_acct1_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          gl_depr_acct1BTN.SetFocus
          gl_depr_acct1BTN_Click
      End If
   End If
End Sub

Private Sub vgl_depr_acct1_KeyPress(KeyAscii As Integer)
    KeyAscii = GenKeyPress(KeyAscii)           ' Use This for Text
   If KeyAscii = 13 Then
      TabSw = True
   End If
   If KeyAscii = 9 Then
      TabSw = False
   End If
End Sub

Private Sub vgl_depr_acct1_LostFocus()
   If ValidSw = True Then
      vgl_depr_acct1.Text = Text_Format(vgl_depr_acct1.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vgl_depr_acct1", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "'")
         If Validated = True Then
            r = ""
           
            If TabSw = True Then
               TabSw = False
               SendKeys "{Tab}"
               
               DoEvents
               
            End If
         End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vgl_depr_acct1.Text = Text_Format(vgl_depr_acct1.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub vgl_sale_def_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          gl_sale_defBTN.SetFocus
          gl_sale_defBTN_Click
      End If
   End If
End Sub

Private Sub vgl_sale_def_KeyPress(KeyAscii As Integer)
     KeyAscii = GenKeyPress(KeyAscii)           ' Use This for Text
   If KeyAscii = 13 Then
      TabSw = True
   End If
   If KeyAscii = 9 Then
      TabSw = False
   End If
End Sub

Private Sub vgl_sale_def_LostFocus()
     If ValidSw = True Then
      vgl_sale_def.Text = Text_Format(vgl_sale_def.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vgl_sale_def", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "' and a_type = 0")
         If Validated = True Then
            r = ""
           
            If TabSw = True Then
               TabSw = False
               SendKeys "{Tab}"
               
               DoEvents
               
            End If
         End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vgl_sale_def.Text = Text_Format(vgl_sale_def.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub vgl_supp_def_KeyDown(KeyCode As Integer, Shift As Integer)
    If Shift = 0 Then
      If KeyCode = 112 Then
          ValidSw = False
          gl_supp_defBTN.SetFocus
          gl_supp_defBTN_Click
      End If
   End If
End Sub

Private Sub vgl_supp_def_KeyPress(KeyAscii As Integer)
   KeyAscii = GenKeyPress(KeyAscii)           ' Use This for Text
   If KeyAscii = 13 Then
      TabSw = True
   End If
   If KeyAscii = 9 Then
      TabSw = False
   End If
End Sub

Private Sub vgl_supp_def_LostFocus()
    If ValidSw = True Then
      vgl_supp_def.Text = Text_Format(vgl_supp_def.Text, xgl_Code_Mask)
      Validated = FldValid(fComp, "gl_ca001", "vgl_supp_def", "wa_desc", "", "a_desc", "a_code", "comp_code = '" & gComp_Code & "' and a_type = 0")
         If Validated = True Then
            r = ""
           
            If TabSw = True Then
               TabSw = False
               SendKeys "{Tab}"
               
               DoEvents
               
            End If
         End If
   Else
      If UCase$(Prg_Sw) = "QBE" And TabSw = True Then
         vgl_supp_def.Text = Text_Format(vgl_supp_def.Text, xgl_Code_Mask)
         TabSw = False
         SendKeys "{Tab}"
         DoEvents
      End If
   End If
End Sub

Private Sub vnum_fisc_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vnum_fisc_LostFocus()
   If ValidSw = True Then
      If jVal(vnum_fisc.Text) < UpDown2.Min Or jVal(vnum_fisc.Text) > UpDown2.Max Then
           FindError "INVALID_NUM"
           'MsgBox "You entered an invalid No.!!!", , Title1
           vnum_fisc.SetFocus
      Else
         Validated = FldValid(fComp, "company", "vnum_fisc", "", "", "", "", "")
         If Validated = True Then
            DoEvents
            UpDown1.Max = jVal(vnum_fisc.Text)
            If TabSw = True Then
               TabSw = False
               SendKeys "(Tab){Tab}"
            End If
         End If
      End If
   End If
End Sub

Private Sub vstfisc_year_KeyPress(KeyAscii As Integer)
   If UCase$(Prg_Sw) = "QBE" Then        ' Use This for Numeric
      KeyAscii = GenKeyPress(KeyAscii)
   Else
      KeyAscii = NumKeyPress(KeyAscii)
   End If
   If KeyAscii = 13 Then
      TabSw = True
   End If
End Sub

Private Sub vstfisc_year_LostFocus()
   If ValidSw = True Then
      If Val(vstfisc_year) < 1960 Or Val(vstfisc_year) > UpDown3.Max Then
         FindError "INVALID_YEAR"
         'MsgBox "You entered an invalid year!!!", , Title1
         vstfisc_year.SetFocus
      Else
         Validated = FldValid(fComp, "company", "vstfisc_year", "", OldCode, "", "", "")
         If Validated = True And TabSw = True Then
            TabSw = False
            UpDown4.Min = vstfisc_year.Text
            SendKeys "{Tab}"
         End If
    End If
   End If
End Sub
