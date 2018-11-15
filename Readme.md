<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/TestGroupSummaryAfterDetail/Form1.cs) (VB: [Form1.vb](./VB/TestGroupSummaryAfterDetail/Form1.vb))
* [XtraReport1.cs](./CS/TestGroupSummaryAfterDetail/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/TestGroupSummaryAfterDetail/XtraReport1.vb))
<!-- default file list end -->
# How to list all groups and their summaries at the end of the report


This example illustrates how to place group summary information after all report detail records.<br><br>Place two separate <strong>DetailReportBands</strong> to your report and bind them to the same data source. The main report's data source shouldn't be set. The first DetailReportBand will display plain data without any grouping. In the second DetailReportBand, group data by any field and place required summary fields there.

<br/>


