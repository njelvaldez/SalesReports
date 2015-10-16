Imports System.Data.SqlClient

Module modDeclarations
    Public Const Quote As String = "'"
    Public Const ExportPath As String = "C:\Export\"

    'Public Const ServerPath As String = "Initial Catalog=NewScores; " & _
    '                                    "Data Source    =MICdb;     " & _
    '                                    "user id        =sa;        " & _
    '                                    "password       =jynxz;     " & _
    '                                    "Pooling        =True;        " & _
    '                                    "Max Pool Size  =75;        " & _
    '                                    "Min Pool Size  =5;         " & _
    '                                    "Persist Security Info=False "
    'Public Const ServerPath2 As String = "Initial Catalog=ScoresDotNet; " & _
    '                                     "Data Source    =MICdb;       " & _
    '                                     "user id        =sa;          " & _
    '                                     "password       =jynxz;       " & _
    '                                     "Pooling        =True;        " & _
    '                                     "Max Pool Size  =75;        " & _
    '                                     "Min Pool Size  =5;         " & _
    '                                     "Persist Security Info=False  "

    Public Const ServerPath As String = "Initial Catalog=NewScores; " & _
                                        "Data Source    =172.22.4.86; " & _
                                        "user id        =sa;        " & _
                                        "password       =jynxz;     " & _
                                        "Pooling        =True;        " & _
                                        "Max Pool Size  =75;        " & _
                                        "Min Pool Size  =5;         " & _
                                        "Persist Security Info=False"
    Public Const ServerPath2 As String = "Initial Catalog=ScoresDotNet;" & _
                                         "Data Source    =172.22.4.86;   " & _
                                         "user id        =sa;          " & _
                                         "password       =jynxz;       " & _
                                         "Pooling        =True;        " & _
                                         "Max Pool Size  =75;        " & _
                                         "Min Pool Size  =5;         " & _
                                         "Persist Security Info=False  "

    'Public Const ServerPath As String = "Initial Catalog=NewScores; " & _
    '                                    "Data Source    =006DCBRION; " & _
    '                                    "user id        =sa;        " & _
    '                                    "password       =jynxz;     " & _
    '                                    "Pooling        =True;        " & _
    '                                    "Max Pool Size  =75;        " & _
    '                                    "Min Pool Size  =5;         " & _
    '                                    "Persist Security Info=False"
    'Public Const ServerPath2 As String = "Initial Catalog=ScoresDotNet;" & _
    '                                     "Data Source    =006DCBRION;   " & _
    '                                     "user id        =sa;          " & _
    '                                     "password       =jynxz;       " & _
    '                                     "Pooling        =True;        " & _
    '                                     "Max Pool Size  =75;        " & _
    '                                     "Min Pool Size  =5;         " & _
    '                                     "Persist Security Info=False  "
    
    Public Filds(100) As Object
    Public Fld0 As String, Fld1 As String, Fld2 As String, Fld3 As String, Fld4 As String
    Public Fld5 As String, Fld6 As String, Fld7 As String, Fld8 As String, Fld9 As String
    Public GrdCols As Integer
    Public Itm_EditMode As Boolean = False
    Public btnSw As Boolean = False
    Public MyFrmItm As Object
    Public z As String, gUserID As String, gUserName As String, gRole As String
    Public i As Integer
    Public TF As Boolean
    Public AppPath As String, CommDate As String
    Public gCurrUser As String
    'Public Const ServerPath As String = "Initial Catalog=NewScores;Data Source=vista;user id=sa;password=jynxz; Max Pool Size=75; Min Pool Size=5;Persist Security Info=False"
    'Public Const ServerPath2 As String = "Initial Catalog=ScoresDotNet;Data Source=vista;user id=sa;password=jynxz; Max Pool Size=75; Min Pool Size=5;Persist Security Info=False"

End Module
