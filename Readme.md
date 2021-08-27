<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580312/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T148767)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ClientData.js](./CS/Dashboard_ClientDataCards_Web/Scripts/ClientData.js) (VB: [ClientData.js](./VB/Dashboard_ClientDataCards_Web/Scripts/ClientData.js))
* [WebForm1.aspx](./CS/Dashboard_ClientDataCards_Web/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_ClientDataCards_Web/WebForm1.aspx))
<!-- default file list end -->
# How to obtain data from a Sparkline field corresponding to a selected row or card
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t148767/)**
<!-- run online end -->


<p><strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br> </p>
<p>The following example demonstrates how to obtain client data corresponding to a particular visual element using <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a>'s <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17375">client-side</a> API.</p>
<p>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_ItemClicktopic">ASPxClientDashboardViewer.ItemClick</a> event is handled to obtain client data and invoke the dxPopup widget with the child dxChart.</p>
<p>In the event handler, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardItemClickEventArgs_GetDatatopic">ASPxClientDashboardItemClickEventArgs.GetData</a> method is called to obtain dashboard item's client data. The <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardItemClickEventArgs_GetAxisPointtopic">ASPxClientDashboardItemClickEventArgs.GetAxisPoint</a> method returns the axis point corresponding to the clicked card while the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardItemData_GetSlicetopic">ASPxClientDashboardItemData.GetSlice</a> method returns the slice of client data by this axis point.<br>To obtain axis points belonging to the "Sparkline" data axis, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardItemDataAxis_GetPointstopic">ASPxClientDashboardItemDataAxis.GetPoints</a> method is used. Corresponding actual/target values are obtained using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardItemData_GetDeltaValuetopic">ASPxClientDashboardItemData.GetDeltaValue</a> method.<br><br>The dxChart is used to display the detailed chart showing a variation of actual/target values over time.</p>
<strong>See Also:</strong> <br><a href="https://www.devexpress.com/Support/Center/p/T170990">T170990: How to retrieve last level data from Client Dashboard Item and display it using different ASP.NET controls</a><br><a href="https://www.devexpress.com/Support/Center/p/T182186">T182186: How to get visible data from a certain dashboard item on the client side and process it on the server side</a><br><br><br>

<br/>


