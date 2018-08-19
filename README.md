# ReportViewer-control-to-replace-iFrame-on-MVC-Project
Report Viewer Control [ReportViewerForMVC dll] library to replace with iFrame on MVC Project
</br></br>
<b>Project Objective:</b></br>
Main objective of this project to show different SSRS Report in Same View. This project is solved the below issue </br>
https://github.com/armanio123/ReportViewerForMvc/issues/20</br>
https://github.com/armanio123/ReportViewerForMvc/issues/35
</br></br>
<b>How do I create this project:</b></br>
1. Create ASP .Net MVC Template solution
2. Create folder - "Report and add .aspx file in the created folder > - **"ReportViewer.aspx"**
3. Add reference: Microsoft.ReportViewer.Webforms.dll and add below line in aspx page
```<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>```

4. Add ReportViewer Tag 
<rsweb:ReportViewer>
5. Add Controller, View and Model from the attached project
6. Add following items in web.config file
```    <add key="ReportServerUser" value="" />
    <add key="ReportServerPassword" value="" />
    <add key="ReportServerDomain" value="" />
    <add key="ReportServerUrl" value="" />
    <add key="ReportFolder" value="" />
    <add key="ReportViewerURL" value="Reports/ReportViewer.aspx" />
```

