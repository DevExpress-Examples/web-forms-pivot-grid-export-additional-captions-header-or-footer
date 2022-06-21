<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577104/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1188)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
# Pivot Grid for Web Forms - How to Add a Custom Header to an Exported PDF document
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1188/)**
<!-- run online end -->

This example illustrates how to add a header to a document exported to PDF.

![Pivot Grid for Web Forms - Custom Header for Export](images/pivot-grid-web-forms-export-custom-header.png)

The image below illustrates the resulting PDF file with custom headers:

![Pivot Grid for Web Forms - Custom Header for Export](images/pivot-grid-export-pdf-custom-headers.png)


Run the project and click the **Export** button. The [ASPxPivotGrid](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPivotGrid.ASPxPivotGrid) control exports its content to a PDF file, adding two lines of text to the document's header. The same technique enables you to add custom text to the document's footer. To change the header text, change the value of the corresponding [TextBrick](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.TextBrick).

## Files to Look At


- [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
- [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx](./VB/Default.aspx))

## Documentation

- [Pivot Grid Export](https://docs.devexpress.com/AspNet/114650/components/pivot-grid/export/export-overview)

## More Examples

- [Pivot Grid for Web Forms - How to add a custom header and footer to an exported Excel document](https://github.com/DevExpress-Examples/data-aware-export-how-to-add-custom-header-and-footer-to-an-exported-excel-document-t355654)
