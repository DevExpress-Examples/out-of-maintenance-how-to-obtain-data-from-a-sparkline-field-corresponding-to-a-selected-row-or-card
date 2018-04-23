Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.ConnectionParameters
Imports System.Web
Imports DevExpress.DataAccess.Sql

Namespace Dashboard_ClientDataCards_Web
    Partial Public Class Dashboard1
        Inherits DevExpress.DashboardCommon.Dashboard

        Private pieDashboardItem1 As PieDashboardItem
        Private cardDashboardItem1 As CardDashboardItem
        Private dataSource1 As DashboardSqlDataSource

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim card1 As New DevExpress.DashboardCommon.Card()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim access97ConnectionParameters1 As New DevExpress.DataAccess.ConnectionParameters.Access97ConnectionParameters()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim dataConnection1 As New DevExpress.DataAccess.DataConnection()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.dataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' pieDashboardItem1
            ' 
            dimension1.DataMember = "OrderDate"
            Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
            measure1.DataMember = "Extended Price"
            dimension2.DataMember = "Country"
            Me.pieDashboardItem1.DataItemRepository.Clear()
            Me.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2")
            Me.pieDashboardItem1.DataMember = "Data Source 1"
            Me.pieDashboardItem1.DataSource = Me.dataSource1
            Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pieDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.pieDashboardItem1.Name = "Pies 1"
            Me.pieDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.pieDashboardItem1.ShowCaption = False
            Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
            ' 
            ' cardDashboardItem1
            ' 
            measure2.DataMember = "Extended Price"
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDev
            measure3.DataMember = "Extended Price"
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDevp
            card1.AddDataItem("ActualValue", measure2)
            card1.AddDataItem("TargetValue", measure3)
            Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
            Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
            dimension3.DataMember = "Sales Person"
            dimension4.DataMember = "OrderDate"
            dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.cardDashboardItem1.DataItemRepository.Clear()
            Me.cardDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.cardDashboardItem1.DataItemRepository.Add(measure3, "DataItem1")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3")
            Me.cardDashboardItem1.DataMember = "Data Source 1"
            Me.cardDashboardItem1.DataSource = Me.dataSource1
            Me.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.cardDashboardItem1.Name = "Cards 1"
            Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.cardDashboardItem1.ShowCaption = False
            Me.cardDashboardItem1.SparklineArgument = dimension4
            ' 
            ' dataSource1
            ' 
            Me.dataSource1.ComponentName = "dataSource1"
            Me.dataSource1.ConnectionName = "nwindConnection"
            access97ConnectionParameters1.FileName = "C:\Users\Public\Documents\DevExpress Demos 14.1\Components\Data\nwind.mdb"
            Me.dataSource1.ConnectionParameters = access97ConnectionParameters1
            Me.dataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client
            Me.dataSource1.Name = "Data Source 1"
            tableQuery1.Name = "Data Source 1"
            tableInfo1.Name = "SalesPerson"
            columnInfo1.Name = "OrderID"
            columnInfo2.Name = "Country"
            columnInfo3.Name = "FirstName"
            columnInfo4.Name = "LastName"
            columnInfo5.Name = "ProductName"
            columnInfo6.Name = "CategoryName"
            columnInfo7.Name = "OrderDate"
            columnInfo8.Name = "UnitPrice"
            columnInfo9.Name = "Quantity"
            columnInfo10.Name = "Discount"
            columnInfo11.Name = "Extended Price"
            columnInfo12.Name = "Sales Person"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            Me.dataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.dataSource1.ResultSchemaSerializable = resources.GetString("dataSource1.ResultSchemaSerializable")
            ' 
            ' Dashboard1
            ' 
            dataConnection1.Name = "nwindConnection"
            dataConnection1.ParametersSerializable = resources.GetString("dataConnection1.ParametersSerializable")
            dataConnection1.ProviderKey = "Access97"
            Me.DataConnections.Add(dataConnection1)
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pieDashboardItem1, Me.cardDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.pieDashboardItem1
            dashboardLayoutItem1.Weight = 25.068368277119415R
            dashboardLayoutItem2.DashboardItem = Me.cardDashboardItem1
            dashboardLayoutItem2.Weight = 74.931631722880581R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Private Sub Dashboard1_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionEventArgs) Handles MyBase.ConfigureDataConnection
            If e.ConnectionName = "nwindConnection" Then

                ' Gets connection parameters used to establish a connection to the database.
                Dim parameters As Access97ConnectionParameters = CType(e.ConnectionParameters, Access97ConnectionParameters)
                Dim databasePath As String = System.Web.Hosting.HostingEnvironment.MapPath("~\App_Data\nwind.mdb")

                ' Specifies the path to a database file.                    
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace
