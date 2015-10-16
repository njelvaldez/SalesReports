Attribute VB_Name = "MainComp"
Option Explicit

Sub COMPANY()

   ProgCode = "COMPANY"
    
   ReadIni
   
   OrdByCode = "comp_code"
   OrdByDesc = "comp_name"
   
   If CheckAccess(gUser_Grp) = False Then
      Screen.MousePointer = 0
      fMenu.Refresh
      Exit Sub
   End If
   
   s = "select * from " & gAlias & "gl_defaults where 1=1"
   DT.SetSql "Qry1", s
   Set QCur1 = DT.Qry1
   
   xgl_Code_Mask = QCur1.Fields("gl_code_mask").Value
   
   DT.CloseSQL "Qry1"
   
   fComp.vgl_curr_earn.MaxLength = Len(Trim(xgl_Code_Mask))
   fComp.vgl_depr_acct1.MaxLength = Len(Trim(xgl_Code_Mask))
   fComp.vgl_depr_acct2.MaxLength = Len(Trim(xgl_Code_Mask))
   fComp.vgl_cust_def.MaxLength = Len(Trim(xgl_Code_Mask))
   fComp.vgl_sale_def.MaxLength = Len(Trim(xgl_Code_Mask))
   fComp.vgl_supp_def.MaxLength = Len(Trim(xgl_Code_Mask))
   fComp.vgl_otax.MaxLength = Len(Trim(xgl_Code_Mask))
   fComp.vdef_curr.MaxLength = Len(Trim(xgl_Code_Mask))
   
   ToolHeight = fComp.Toolbar1.Height
   FirstPass = True
   fComp.Caption = Title2 & "  -  Company Table Maintenance"
   Set MyFrm = fComp
   fComp.Show vbModal, fMenu
   
End Sub
