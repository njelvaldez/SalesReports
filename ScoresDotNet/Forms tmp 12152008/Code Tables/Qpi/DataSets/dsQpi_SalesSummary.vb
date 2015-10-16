﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsQpi_SalesSummary
    Inherits DataSet
    
    Private tableQpi_SalesSummary As Qpi_SalesSummaryDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Qpi_SalesSummary")) Is Nothing) Then
                Me.Tables.Add(New Qpi_SalesSummaryDataTable(ds.Tables("Qpi_SalesSummary")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Qpi_SalesSummary As Qpi_SalesSummaryDataTable
        Get
            Return Me.tableQpi_SalesSummary
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsQpi_SalesSummary = CType(MyBase.Clone,dsQpi_SalesSummary)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Qpi_SalesSummary")) Is Nothing) Then
            Me.Tables.Add(New Qpi_SalesSummaryDataTable(ds.Tables("Qpi_SalesSummary")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableQpi_SalesSummary = CType(Me.Tables("Qpi_SalesSummary"),Qpi_SalesSummaryDataTable)
        If (Not (Me.tableQpi_SalesSummary) Is Nothing) Then
            Me.tableQpi_SalesSummary.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsQpi_SalesSummary"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsQpi_SalesSummary.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableQpi_SalesSummary = New Qpi_SalesSummaryDataTable
        Me.Tables.Add(Me.tableQpi_SalesSummary)
    End Sub
    
    Private Function ShouldSerializeQpi_SalesSummary() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Qpi_SalesSummaryRowChangeEventHandler(ByVal sender As Object, ByVal e As Qpi_SalesSummaryRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Qpi_SalesSummaryDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnitemcode As DataColumn
        
        Private columnitemdesc As DataColumn
        
        Private columnqtysold As DataColumn
        
        Private columnqtyfree As DataColumn
        
        Private columnAmount_Sold As DataColumn
        
        Private columnSaleType As DataColumn
        
        Private columncommissiondate As DataColumn
        
        Friend Sub New()
            MyBase.New("Qpi_SalesSummary")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property itemcodeColumn As DataColumn
            Get
                Return Me.columnitemcode
            End Get
        End Property
        
        Friend ReadOnly Property itemdescColumn As DataColumn
            Get
                Return Me.columnitemdesc
            End Get
        End Property
        
        Friend ReadOnly Property qtysoldColumn As DataColumn
            Get
                Return Me.columnqtysold
            End Get
        End Property
        
        Friend ReadOnly Property qtyfreeColumn As DataColumn
            Get
                Return Me.columnqtyfree
            End Get
        End Property
        
        Friend ReadOnly Property Amount_SoldColumn As DataColumn
            Get
                Return Me.columnAmount_Sold
            End Get
        End Property
        
        Friend ReadOnly Property SaleTypeColumn As DataColumn
            Get
                Return Me.columnSaleType
            End Get
        End Property
        
        Friend ReadOnly Property commissiondateColumn As DataColumn
            Get
                Return Me.columncommissiondate
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Qpi_SalesSummaryRow
            Get
                Return CType(Me.Rows(index),Qpi_SalesSummaryRow)
            End Get
        End Property
        
        Public Event Qpi_SalesSummaryRowChanged As Qpi_SalesSummaryRowChangeEventHandler
        
        Public Event Qpi_SalesSummaryRowChanging As Qpi_SalesSummaryRowChangeEventHandler
        
        Public Event Qpi_SalesSummaryRowDeleted As Qpi_SalesSummaryRowChangeEventHandler
        
        Public Event Qpi_SalesSummaryRowDeleting As Qpi_SalesSummaryRowChangeEventHandler
        
        Public Overloads Sub AddQpi_SalesSummaryRow(ByVal row As Qpi_SalesSummaryRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddQpi_SalesSummaryRow(ByVal itemcode As String, ByVal itemdesc As String, ByVal qtysold As Long, ByVal qtyfree As Long, ByVal Amount_Sold As Decimal, ByVal SaleType As String, ByVal commissiondate As Date) As Qpi_SalesSummaryRow
            Dim rowQpi_SalesSummaryRow As Qpi_SalesSummaryRow = CType(Me.NewRow,Qpi_SalesSummaryRow)
            rowQpi_SalesSummaryRow.ItemArray = New Object() {itemcode, itemdesc, qtysold, qtyfree, Amount_Sold, SaleType, commissiondate}
            Me.Rows.Add(rowQpi_SalesSummaryRow)
            Return rowQpi_SalesSummaryRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Qpi_SalesSummaryDataTable = CType(MyBase.Clone,Qpi_SalesSummaryDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Qpi_SalesSummaryDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnitemcode = Me.Columns("itemcode")
            Me.columnitemdesc = Me.Columns("itemdesc")
            Me.columnqtysold = Me.Columns("qtysold")
            Me.columnqtyfree = Me.Columns("qtyfree")
            Me.columnAmount_Sold = Me.Columns("Amount Sold")
            Me.columnSaleType = Me.Columns("SaleType")
            Me.columncommissiondate = Me.Columns("commissiondate")
        End Sub
        
        Private Sub InitClass()
            Me.columnitemcode = New DataColumn("itemcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnitemcode)
            Me.columnitemdesc = New DataColumn("itemdesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnitemdesc)
            Me.columnqtysold = New DataColumn("qtysold", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnqtysold)
            Me.columnqtyfree = New DataColumn("qtyfree", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnqtyfree)
            Me.columnAmount_Sold = New DataColumn("Amount Sold", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAmount_Sold)
            Me.columnSaleType = New DataColumn("SaleType", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSaleType)
            Me.columncommissiondate = New DataColumn("commissiondate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncommissiondate)
            Me.columnqtyfree.AllowDBNull = false
        End Sub
        
        Public Function NewQpi_SalesSummaryRow() As Qpi_SalesSummaryRow
            Return CType(Me.NewRow,Qpi_SalesSummaryRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Qpi_SalesSummaryRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Qpi_SalesSummaryRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Qpi_SalesSummaryRowChangedEvent) Is Nothing) Then
                RaiseEvent Qpi_SalesSummaryRowChanged(Me, New Qpi_SalesSummaryRowChangeEvent(CType(e.Row,Qpi_SalesSummaryRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Qpi_SalesSummaryRowChangingEvent) Is Nothing) Then
                RaiseEvent Qpi_SalesSummaryRowChanging(Me, New Qpi_SalesSummaryRowChangeEvent(CType(e.Row,Qpi_SalesSummaryRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Qpi_SalesSummaryRowDeletedEvent) Is Nothing) Then
                RaiseEvent Qpi_SalesSummaryRowDeleted(Me, New Qpi_SalesSummaryRowChangeEvent(CType(e.Row,Qpi_SalesSummaryRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Qpi_SalesSummaryRowDeletingEvent) Is Nothing) Then
                RaiseEvent Qpi_SalesSummaryRowDeleting(Me, New Qpi_SalesSummaryRowChangeEvent(CType(e.Row,Qpi_SalesSummaryRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveQpi_SalesSummaryRow(ByVal row As Qpi_SalesSummaryRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Qpi_SalesSummaryRow
        Inherits DataRow
        
        Private tableQpi_SalesSummary As Qpi_SalesSummaryDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableQpi_SalesSummary = CType(Me.Table,Qpi_SalesSummaryDataTable)
        End Sub
        
        Public Property itemcode As String
            Get
                Try 
                    Return CType(Me(Me.tableQpi_SalesSummary.itemcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpi_SalesSummary.itemcodeColumn) = value
            End Set
        End Property
        
        Public Property itemdesc As String
            Get
                Try 
                    Return CType(Me(Me.tableQpi_SalesSummary.itemdescColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpi_SalesSummary.itemdescColumn) = value
            End Set
        End Property
        
        Public Property qtysold As Long
            Get
                Try 
                    Return CType(Me(Me.tableQpi_SalesSummary.qtysoldColumn),Long)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpi_SalesSummary.qtysoldColumn) = value
            End Set
        End Property
        
        Public Property qtyfree As Long
            Get
                Return CType(Me(Me.tableQpi_SalesSummary.qtyfreeColumn),Long)
            End Get
            Set
                Me(Me.tableQpi_SalesSummary.qtyfreeColumn) = value
            End Set
        End Property
        
        Public Property Amount_Sold As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableQpi_SalesSummary.Amount_SoldColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpi_SalesSummary.Amount_SoldColumn) = value
            End Set
        End Property
        
        Public Property SaleType As String
            Get
                Try 
                    Return CType(Me(Me.tableQpi_SalesSummary.SaleTypeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpi_SalesSummary.SaleTypeColumn) = value
            End Set
        End Property
        
        Public Property commissiondate As Date
            Get
                Try 
                    Return CType(Me(Me.tableQpi_SalesSummary.commissiondateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpi_SalesSummary.commissiondateColumn) = value
            End Set
        End Property
        
        Public Function IsitemcodeNull() As Boolean
            Return Me.IsNull(Me.tableQpi_SalesSummary.itemcodeColumn)
        End Function
        
        Public Sub SetitemcodeNull()
            Me(Me.tableQpi_SalesSummary.itemcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsitemdescNull() As Boolean
            Return Me.IsNull(Me.tableQpi_SalesSummary.itemdescColumn)
        End Function
        
        Public Sub SetitemdescNull()
            Me(Me.tableQpi_SalesSummary.itemdescColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsqtysoldNull() As Boolean
            Return Me.IsNull(Me.tableQpi_SalesSummary.qtysoldColumn)
        End Function
        
        Public Sub SetqtysoldNull()
            Me(Me.tableQpi_SalesSummary.qtysoldColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAmount_SoldNull() As Boolean
            Return Me.IsNull(Me.tableQpi_SalesSummary.Amount_SoldColumn)
        End Function
        
        Public Sub SetAmount_SoldNull()
            Me(Me.tableQpi_SalesSummary.Amount_SoldColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSaleTypeNull() As Boolean
            Return Me.IsNull(Me.tableQpi_SalesSummary.SaleTypeColumn)
        End Function
        
        Public Sub SetSaleTypeNull()
            Me(Me.tableQpi_SalesSummary.SaleTypeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IscommissiondateNull() As Boolean
            Return Me.IsNull(Me.tableQpi_SalesSummary.commissiondateColumn)
        End Function
        
        Public Sub SetcommissiondateNull()
            Me(Me.tableQpi_SalesSummary.commissiondateColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Qpi_SalesSummaryRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Qpi_SalesSummaryRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Qpi_SalesSummaryRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Qpi_SalesSummaryRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class