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
Public Class dsQpiTerritory
    Inherits DataSet
    
    Private tableQpiTerritory_Show As QpiTerritory_ShowDataTable
    
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
            If (Not (ds.Tables("QpiTerritory_Show")) Is Nothing) Then
                Me.Tables.Add(New QpiTerritory_ShowDataTable(ds.Tables("QpiTerritory_Show")))
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
    Public ReadOnly Property QpiTerritory_Show As QpiTerritory_ShowDataTable
        Get
            Return Me.tableQpiTerritory_Show
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsQpiTerritory = CType(MyBase.Clone,dsQpiTerritory)
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
        If (Not (ds.Tables("QpiTerritory_Show")) Is Nothing) Then
            Me.Tables.Add(New QpiTerritory_ShowDataTable(ds.Tables("QpiTerritory_Show")))
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
        Me.tableQpiTerritory_Show = CType(Me.Tables("QpiTerritory_Show"),QpiTerritory_ShowDataTable)
        If (Not (Me.tableQpiTerritory_Show) Is Nothing) Then
            Me.tableQpiTerritory_Show.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsQpiTerritory"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsQpiTerritory.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableQpiTerritory_Show = New QpiTerritory_ShowDataTable
        Me.Tables.Add(Me.tableQpiTerritory_Show)
    End Sub
    
    Private Function ShouldSerializeQpiTerritory_Show() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub QpiTerritory_ShowRowChangeEventHandler(ByVal sender As Object, ByVal e As QpiTerritory_ShowRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class QpiTerritory_ShowDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnRowid As DataColumn
        
        Private columnCode As DataColumn
        
        Private columnDescription As DataColumn
        
        Private columnCreateDate As DataColumn
        
        Private columnUpdateDate As DataColumn
        
        Friend Sub New()
            MyBase.New("QpiTerritory_Show")
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
        
        Friend ReadOnly Property RowidColumn As DataColumn
            Get
                Return Me.columnRowid
            End Get
        End Property
        
        Friend ReadOnly Property CodeColumn As DataColumn
            Get
                Return Me.columnCode
            End Get
        End Property
        
        Friend ReadOnly Property DescriptionColumn As DataColumn
            Get
                Return Me.columnDescription
            End Get
        End Property
        
        Friend ReadOnly Property CreateDateColumn As DataColumn
            Get
                Return Me.columnCreateDate
            End Get
        End Property
        
        Friend ReadOnly Property UpdateDateColumn As DataColumn
            Get
                Return Me.columnUpdateDate
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As QpiTerritory_ShowRow
            Get
                Return CType(Me.Rows(index),QpiTerritory_ShowRow)
            End Get
        End Property
        
        Public Event QpiTerritory_ShowRowChanged As QpiTerritory_ShowRowChangeEventHandler
        
        Public Event QpiTerritory_ShowRowChanging As QpiTerritory_ShowRowChangeEventHandler
        
        Public Event QpiTerritory_ShowRowDeleted As QpiTerritory_ShowRowChangeEventHandler
        
        Public Event QpiTerritory_ShowRowDeleting As QpiTerritory_ShowRowChangeEventHandler
        
        Public Overloads Sub AddQpiTerritory_ShowRow(ByVal row As QpiTerritory_ShowRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddQpiTerritory_ShowRow(ByVal Rowid As Integer, ByVal Code As String, ByVal Description As String, ByVal CreateDate As Date, ByVal UpdateDate As Date) As QpiTerritory_ShowRow
            Dim rowQpiTerritory_ShowRow As QpiTerritory_ShowRow = CType(Me.NewRow,QpiTerritory_ShowRow)
            rowQpiTerritory_ShowRow.ItemArray = New Object() {Rowid, Code, Description, CreateDate, UpdateDate}
            Me.Rows.Add(rowQpiTerritory_ShowRow)
            Return rowQpiTerritory_ShowRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As QpiTerritory_ShowDataTable = CType(MyBase.Clone,QpiTerritory_ShowDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New QpiTerritory_ShowDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnRowid = Me.Columns("Rowid")
            Me.columnCode = Me.Columns("Code")
            Me.columnDescription = Me.Columns("Description")
            Me.columnCreateDate = Me.Columns("CreateDate")
            Me.columnUpdateDate = Me.Columns("UpdateDate")
        End Sub
        
        Private Sub InitClass()
            Me.columnRowid = New DataColumn("Rowid", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRowid)
            Me.columnCode = New DataColumn("Code", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCode)
            Me.columnDescription = New DataColumn("Description", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescription)
            Me.columnCreateDate = New DataColumn("CreateDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCreateDate)
            Me.columnUpdateDate = New DataColumn("UpdateDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUpdateDate)
            Me.columnUpdateDate.AllowDBNull = false
        End Sub
        
        Public Function NewQpiTerritory_ShowRow() As QpiTerritory_ShowRow
            Return CType(Me.NewRow,QpiTerritory_ShowRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New QpiTerritory_ShowRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(QpiTerritory_ShowRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.QpiTerritory_ShowRowChangedEvent) Is Nothing) Then
                RaiseEvent QpiTerritory_ShowRowChanged(Me, New QpiTerritory_ShowRowChangeEvent(CType(e.Row,QpiTerritory_ShowRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.QpiTerritory_ShowRowChangingEvent) Is Nothing) Then
                RaiseEvent QpiTerritory_ShowRowChanging(Me, New QpiTerritory_ShowRowChangeEvent(CType(e.Row,QpiTerritory_ShowRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.QpiTerritory_ShowRowDeletedEvent) Is Nothing) Then
                RaiseEvent QpiTerritory_ShowRowDeleted(Me, New QpiTerritory_ShowRowChangeEvent(CType(e.Row,QpiTerritory_ShowRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.QpiTerritory_ShowRowDeletingEvent) Is Nothing) Then
                RaiseEvent QpiTerritory_ShowRowDeleting(Me, New QpiTerritory_ShowRowChangeEvent(CType(e.Row,QpiTerritory_ShowRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveQpiTerritory_ShowRow(ByVal row As QpiTerritory_ShowRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class QpiTerritory_ShowRow
        Inherits DataRow
        
        Private tableQpiTerritory_Show As QpiTerritory_ShowDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableQpiTerritory_Show = CType(Me.Table,QpiTerritory_ShowDataTable)
        End Sub
        
        Public Property Rowid As Integer
            Get
                Try 
                    Return CType(Me(Me.tableQpiTerritory_Show.RowidColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpiTerritory_Show.RowidColumn) = value
            End Set
        End Property
        
        Public Property Code As String
            Get
                Try 
                    Return CType(Me(Me.tableQpiTerritory_Show.CodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpiTerritory_Show.CodeColumn) = value
            End Set
        End Property
        
        Public Property Description As String
            Get
                Try 
                    Return CType(Me(Me.tableQpiTerritory_Show.DescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpiTerritory_Show.DescriptionColumn) = value
            End Set
        End Property
        
        Public Property CreateDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableQpiTerritory_Show.CreateDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableQpiTerritory_Show.CreateDateColumn) = value
            End Set
        End Property
        
        Public Property UpdateDate As Date
            Get
                Return CType(Me(Me.tableQpiTerritory_Show.UpdateDateColumn),Date)
            End Get
            Set
                Me(Me.tableQpiTerritory_Show.UpdateDateColumn) = value
            End Set
        End Property
        
        Public Function IsRowidNull() As Boolean
            Return Me.IsNull(Me.tableQpiTerritory_Show.RowidColumn)
        End Function
        
        Public Sub SetRowidNull()
            Me(Me.tableQpiTerritory_Show.RowidColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCodeNull() As Boolean
            Return Me.IsNull(Me.tableQpiTerritory_Show.CodeColumn)
        End Function
        
        Public Sub SetCodeNull()
            Me(Me.tableQpiTerritory_Show.CodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableQpiTerritory_Show.DescriptionColumn)
        End Function
        
        Public Sub SetDescriptionNull()
            Me(Me.tableQpiTerritory_Show.DescriptionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCreateDateNull() As Boolean
            Return Me.IsNull(Me.tableQpiTerritory_Show.CreateDateColumn)
        End Function
        
        Public Sub SetCreateDateNull()
            Me(Me.tableQpiTerritory_Show.CreateDateColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class QpiTerritory_ShowRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As QpiTerritory_ShowRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As QpiTerritory_ShowRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As QpiTerritory_ShowRow
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
