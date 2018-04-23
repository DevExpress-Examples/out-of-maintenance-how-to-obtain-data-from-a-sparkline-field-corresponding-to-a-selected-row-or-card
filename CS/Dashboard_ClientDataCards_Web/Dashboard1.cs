using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using System.Web;

namespace Dashboard_ClientDataCards_Web {
    public partial class Dashboard1 : DevExpress.DashboardCommon.Dashboard {
        private PieDashboardItem pieDashboardItem1;
        private CardDashboardItem cardDashboardItem1;
        private DataSource dataSource1;
    
        public Dashboard1() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DataAccess.DataConnection dataConnection1 = new DevExpress.DataAccess.DataConnection();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            this.dataSource1 = new DevExpress.DashboardCommon.DataSource();
            this.cardDashboardItem1 = new DevExpress.DashboardCommon.CardDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pieDashboardItem1
            // 
            dimension1.DataMember = "OrderDate";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure1.DataMember = "Extended Price";
            dimension2.DataMember = "Country";
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1");
            this.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2");
            this.pieDashboardItem1.DataSource = this.dataSource1;
            this.pieDashboardItem1.IgnoreMasterFilters = false;
            this.pieDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.pieDashboardItem1.Name = "Pies 1";
            this.pieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pieDashboardItem1.ShowCaption = false;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // dataSource1
            // 
            this.dataSource1.ComponentName = "dataSource1";
            this.dataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            this.dataSource1.DataProviderSerializable = resources.GetString("dataSource1.DataProviderSerializable");
            this.dataSource1.Name = "Data Source 1";
            // 
            // cardDashboardItem1
            // 
            measure2.DataMember = "Extended Price";
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDev;
            measure3.DataMember = "Extended Price";
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDevp;
            card1.AddDataItem("ActualValue", measure2);
            card1.AddDataItem("TargetValue", measure3);
            this.cardDashboardItem1.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1});
            this.cardDashboardItem1.ComponentName = "cardDashboardItem1";
            dimension3.DataMember = "Sales Person";
            dimension4.DataMember = "OrderDate";
            dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.cardDashboardItem1.DataItemRepository.Clear();
            this.cardDashboardItem1.DataItemRepository.Add(measure2, "DataItem0");
            this.cardDashboardItem1.DataItemRepository.Add(measure3, "DataItem1");
            this.cardDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2");
            this.cardDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3");
            this.cardDashboardItem1.DataSource = this.dataSource1;
            this.cardDashboardItem1.IgnoreMasterFilters = false;
            this.cardDashboardItem1.Name = "Cards 1";
            this.cardDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.cardDashboardItem1.ShowCaption = false;
            this.cardDashboardItem1.SparklineArgument = dimension4;
            // 
            // Dashboard1
            // 
            dataConnection1.Name = "nwindConnection";
            dataConnection1.ParametersSerializable = resources.GetString("dataConnection1.ParametersSerializable");
            dataConnection1.ProviderKey = "Access97";
            this.DataConnections.Add(dataConnection1);
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pieDashboardItem1,
            this.cardDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem1.Weight = 25.068368277119415D;
            dashboardLayoutItem2.DashboardItem = this.cardDashboardItem1;
            dashboardLayoutItem2.Weight = 74.931631722880581D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            this.ConfigureDataConnection += new DevExpress.DataAccess.ConfigureDataConnectionEventHandler(this.Dashboard1_ConfigureDataConnection);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void Dashboard1_ConfigureDataConnection(object sender, ConfigureDataConnectionEventArgs e) {
            if (e.ConnectionName == "nwindConnection") {

                // Gets connection parameters used to establish a connection to the database.
                Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;
                string databasePath = System.Web.HttpContext.Current.Server.MapPath(@"~\App_Data\nwind.mdb");

                // Specifies the path to a database file.                    
                parameters.FileName = databasePath;
            }
        }
    }
}
