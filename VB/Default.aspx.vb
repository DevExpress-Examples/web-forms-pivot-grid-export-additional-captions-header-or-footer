Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraPrintingLinks
Imports System.IO
Imports System.Drawing

Namespace S130793
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim ps As New PrintingSystem()

            Dim link1 As New PrintableComponentLink()
            link1.Component = ASPxPivotGridExporter1
            link1.PrintingSystem = ps

            Dim link2 As New Link()
            AddHandler link2.CreateDetailArea, AddressOf link2_CreateDetailArea
            link2.PrintingSystem = ps

            Dim compositeLink As New CompositeLink()
            compositeLink.Links.AddRange(New Object() { link2, link1 })
            compositeLink.PrintingSystem = ps

            compositeLink.CreateDocument()
            compositeLink.PrintingSystem.ExportOptions.Pdf.DocumentOptions.Author = "Test"

            Using stream As New MemoryStream()
                compositeLink.PrintingSystem.ExportToPdf(stream)
                Response.Clear()
                Response.Buffer = False
                Response.AppendHeader("Content-Type", "application/pdf")
                Response.AppendHeader("Content-Transfer-Encoding", "binary")
                Response.AppendHeader("Content-Disposition", "attachment; filename=test.pdf")
                Response.BinaryWrite(stream.ToArray())
                Response.End()
            End Using
            ps.Dispose()
        End Sub

        Private Sub link2_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            Dim l As Link = TryCast(sender, Link)
            Dim tb As New TextBrick()
            tb.Text = "text caption"
            tb.StringFormat = New BrickStringFormat(StringAlignment.Center)
            tb.Rect = New RectangleF(0, 0, l.PrintingSystem.Graph.ClientPageSize.Width, 20)
            tb.Sides = BorderSide.None
            e.Graph.DrawBrick(tb)

            tb = New TextBrick()
            tb.Text = "text sub caption"
            tb.StringFormat = New BrickStringFormat(StringAlignment.Center)
            tb.Rect = New RectangleF(0, 20, l.PrintingSystem.Graph.ClientPageSize.Width, 20)
            tb.Sides = BorderSide.None
            e.Graph.DrawBrick(tb)
        End Sub
    End Class
End Namespace