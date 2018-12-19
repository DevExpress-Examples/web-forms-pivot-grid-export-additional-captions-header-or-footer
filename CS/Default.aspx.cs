using System;
using DevExpress.XtraPrinting;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraPrintingLinks;
using System.IO;
using System.Drawing;

namespace S130793 {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            PrintingSystem ps = new PrintingSystem();
            
            PrintableComponentLink link1 = new PrintableComponentLink();
            link1.Component = ASPxPivotGridExporter1;
            link1.PrintingSystem = ps;

            Link link2 = new Link();
            link2.CreateDetailArea += new CreateAreaEventHandler(link2_CreateDetailArea);
            link2.PrintingSystem = ps;

            CompositeLink compositeLink = new CompositeLink();
            compositeLink.Links.AddRange(new object[] { link2, link1 });
            compositeLink.PrintingSystem = ps;

            compositeLink.CreateDocument();
            compositeLink.PrintingSystem.ExportOptions.Pdf.DocumentOptions.Author = "Test";

            using (MemoryStream stream = new MemoryStream())
            {
                compositeLink.PrintingSystem.ExportToPdf(stream);
                Response.Clear();
                Response.Buffer = false;
                Response.AppendHeader("Content-Type", "application/pdf");
                Response.AppendHeader("Content-Transfer-Encoding", "binary");
                Response.AppendHeader("Content-Disposition", "attachment; filename=test.pdf");
                Response.BinaryWrite(stream.ToArray());
                Response.End();
            }
            ps.Dispose();
        }

        void link2_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            Link l = sender as Link;
            TextBrick tb = new TextBrick();
            tb.Text = "Custom Header";
            tb.StringFormat = new BrickStringFormat(StringAlignment.Center);
            tb.Rect = new RectangleF(0, 0, l.PrintingSystem.Graph.ClientPageSize.Width, 20);
            tb.Sides = BorderSide.None;
            e.Graph.DrawBrick(tb);

            tb = new TextBrick();
            tb.Text = "Custom SubHeader";
            tb.StringFormat = new BrickStringFormat(StringAlignment.Center);
            tb.Rect = new RectangleF(0, 20, l.PrintingSystem.Graph.ClientPageSize.Width, 20);
            tb.Sides = BorderSide.None;
            e.Graph.DrawBrick(tb);
        }
    }
}