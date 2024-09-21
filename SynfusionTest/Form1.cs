using FontAwesome.Sharp;
using Syncfusion.Windows.Forms.Diagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
//using XMLCOMPARTMENT;
using XMLHULL;

using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using Label = System.Windows.Forms.Label;
using Syncfusion.Windows.Forms;
using Microsoft.Win32;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Design;

namespace SynfusionTest
{
    public partial class Form1 : Form
    {
        public Form1()//pyk
        {
            InitializeComponent();
            //Develop Branch
            //PTK Feature 
            //Sawkay updates
            //Sawlay 2nd updates
        }

        private void lblFile_Click(object sender, EventArgs e)
        {
            if (lblFile.Text == "▶ File")
            {
                lblFile.Text = "▼ File";
                fpFile.Visible = true;
            }
            else
            {
                lblFile.Text = "▶ File";
                fpFile.Visible = false;
            }
        }

        private void lblGeneral_Click(object sender, EventArgs e)
        {
            if (lblGeneral.Text == "▶ General")
            {
                lblGeneral.Text = "▼ General";
                fpGeneral.Visible = true;
            }
            else
            {
                lblGeneral.Text = "▶ General";
                fpGeneral.Visible = false;
            }

        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            if (lblEdit.Text == "▶ Edit")
            {
                lblEdit.Text = "▼ Edit";
                fpEdit.Visible = true;
            }
            else
            {
                lblEdit.Text = "▶ Edit";
                fpEdit.Visible = false;
            }
        }

        private void lblView_Click(object sender, EventArgs e)
        {
            if (lblView.Text == "▶ View")
            {
                lblView.Text = "▼ View";
                fpView.Visible = true;
            }
            else
            {
                lblView.Text = "▶ View";
                fpView.Visible = false;
            }
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {
            if (lblLabel.Text == "▶ Label")
            {
                lblLabel.Text = "▼ Label";
                fpLabel.Visible = true;
            }
            else
            {
                lblLabel.Text = "▶ Label";
                fpLabel.Visible = false;
            }
        }

        private void btnDirectedLabel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor = SystemColors.GrayText;
            }
            if (sender is IconButton ib)
            {
                ib.BackColor = SystemColors.GrayText;
            }
        }

        private void btnDirectedLabel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label l)
            {
                l.BackColor = Color.Black;
            }
            if (sender is IconButton ib)
            {
                ib.BackColor = Color.Black;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCompartmentData("C:\\Users\\Asus\\OneDrive\\Documents\\CompartmentDataFromSh2.txt");
                LoadHullData("C:\\Users\\Asus\\OneDrive\\Documents\\HULLDataFromSh2.txt");
            }
            catch
            {
                MessageBoxAdv.Show("The system found an error while importing, may be due to screen location issue.", "Error");
                return;
            }
            MessageBoxAdv.Show("The files have been imported","Information");
        }
        private void LoadCompartmentData(string filePath)
        {
            try
            {
                string xml = File.ReadAllText(filePath);
                var serializer = new XmlSerializer(typeof(Compartments));

                using (StringReader reader = new StringReader(xml))
                {
                    var compartments = ((Compartments)serializer.Deserialize(reader))?.CompartmentList;

                    foreach (var compartment in compartments)
                    {
                        if (compartment == null) continue;

                        AddPolygonFromOutline(compartment.Profile.Outline.Pgon, 200, 100);
                        AddPolygonFromOutline(compartment.Plan.Outline.Pgon, 200, 200);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading compartment data: " + ex.Message);
            }
        }

        private void LoadHullData(string filePath)
        {
            try
            {
                string xml = File.ReadAllText(filePath);
                var serializer = new XmlSerializer(typeof(Hull));

                using (StringReader reader = new StringReader(xml))
                {
                    var hull = (Hull)serializer.Deserialize(reader);
                    if (hull == null) return;

                    AddPolylineFromOutline(hull.Profile.Outline.Pgon, 200, 300);
                    AddPolylineFromOutline(hull.Plan.Outline.Pgon, 200, 300);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading hull data: " + ex.Message);
            }
        }

        private void AddPolygonFromOutline(Pgon pgon, float offsetX, float offsetY)
        {
            if (pgon?.XCoordinates.Contains(",") == true)
            {
                var points = GetTransformedPoints(pgon.XCoordinates, pgon.YCoordinates, offsetX, offsetY);
                var polygon = new Polygon(points.ToArray())
                {
                    LineStyle = { LineColor = Color.Black, LineWidth = 0.1f },
                    FillStyle = { Color = Color.Red }
                };
                diagram1.Model.AppendChild(polygon);
                diagram1.Refresh();
            }
        }

        private void AddPolylineFromOutline(Pgon pgon, float offsetX, float offsetY)
        {
            if (pgon?.XCoordinates.Contains(",") == true)
            {
                var points = GetTransformedPoints(pgon.XCoordinates, pgon.YCoordinates, offsetX, offsetY);
                var polyline = new PolyLineConnector(points.ToArray())
                {
                    LineStyle = { LineColor = Color.Black, LineWidth = 0.1f }
                };
                diagram1.Model.AppendChild(polyline);
                diagram1.Refresh();
            }
        }

        private List<PointF> GetTransformedPoints(string sx, string sy, float offsetX, float offsetY)
        {
            var points = new List<PointF>();
            var lx = sx.Split(',');
            var ly = sy.Split(',');

            float diagramWidth = diagram1.Bounds.Width;
            float diagramHeight = diagram1.Bounds.Height;

            for (int i = 0; i < lx.Length; i++)
            {
                var xpoint = lx[i].Trim().ToFloat() + offsetX;
                var ypoint = ly[i].Trim().ToFloat() + offsetY;
                var transformedPoint = TransformPoint(new PointF(xpoint, ypoint), diagramWidth, diagramHeight);
                points.Add(transformedPoint);
            }
            return points;
        }
        protected PointF TransformPoint(PointF originalPoint, float width, float height)
        {
            float newX = width - originalPoint.X;
            float newY = height - originalPoint.Y;
            return new PointF(newX, newY);
        }

        private void btnPointer_Click(object sender, EventArgs e) =>  diagram1.Controller.ActivateTool("SelectTool"); 

        private void btnPan_Click(object sender, EventArgs e)=>diagram1.Controller.ActivateTool("PanTool");

        private void btnRuler_Click(object sender, EventArgs e)=> diagram1.ShowRulers = !diagram1.ShowRulers;

        private void btnZoom_Click(object sender, EventArgs e) => diagram1.View.ZoomIn();

        private void btnZoomOut_Click(object sender, EventArgs e)=> diagram1.View.ZoomOut();

        private void btnLock_Click(object sender, EventArgs e)
        {
            diagram1.Enabled= !diagram1.Enabled;
            var msg = "";
            if (!diagram1.Enabled)
                msg = "The diagram have been disable.";
            else
                msg = "The diagram have been enable";

            MessageBoxAdv.Show(msg,"Information");
        }

        private void btnPrint_Click(object sender, EventArgs e)=>Print();
        public void Print()
        {
            if (this.diagram1 != null)
            {
                PrintDocument printDoc = this.diagram1.CreatePrintDocument();
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDoc;

                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog(this) == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printDlg.PrinterSettings;
                    printDoc.Print();
                }
            }
        }
        private void PrintPreview()
        {
            if (diagram1 != null)
            {
                var printPreviewDlg = new PrintPreviewDialog { Document = diagram1.CreatePrintDocument() };
                printPreviewDlg.ShowDialog(this);
            }
        }
        private string fileNameSave = null;
        private bool promptOnSave = true;
        private void SaveDiagram()
        {
            if (promptOnSave)
            {
                saveFileDialog1.FileName = fileNameSave;
                saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml";
                if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    fileNameSave = saveFileDialog1.FileName;
                    SaveFileBasedOnExtension(fileNameSave);
                    promptOnSave = false;
                }
            }
            else if (!string.IsNullOrEmpty(fileNameSave))
            {
                SaveFileBasedOnExtension(fileNameSave);
            }
        }
        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
                this.Text = Path.GetFileNameWithoutExtension(this.fileName);
            }
        }
        protected string fileName = "ptkTestPrinting";
        private void SaveAsDiagram()
        {
            this.saveFileDialog1.FileName = this.fileNameSave;
            saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.FileName = this.saveFileDialog1.FileName;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        diagram1.SaveBinary(this.fileNameSave);
                        break;
                    case 2:
#if !NETCORE
                        diagram1.SaveSoap(this.fileNameSave);
#endif
                        break;
                }
            }
        }
        private void SaveFileBasedOnExtension(string fileName)
        {
            if (fileName.EndsWith(".edd"))
                diagram1.SaveBinary(fileName);
#if !NETCORE
            else if (fileName.EndsWith(".xml"))
                diagram1.SaveSoap(fileName);
#endif
        }
        private void btnPreview_Click(object sender, EventArgs e) => PrintPreview();

        private void btnSave_Click(object sender, EventArgs e) => SaveDiagram();

        private void btnSaveAs_Click(object sender, EventArgs e) => SaveAsDiagram();

        private void btnRotate_Click(object sender, EventArgs e) => RotateSelectedNodes(90f);

        private void btnCopy_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Copy();
            btnPaste.Enabled = true;
        }
        private void RotateSelectedNodes(float angle)
        {
            GroupOption(true);
            foreach (var connector in diagram1.Controller.SelectionList)
            {
                if (connector is Node node)
                {
                    node.RotationAngle += angle;
                }
            }
        }
        private void GroupOption(bool isGroup)
        {
            diagram1.Model.BeginUpdate();
            if (isGroup)
                diagram1.Controller.Group();
            else
                diagram1.Controller.UnGroup();
            diagram1.Model.EndUpdate();
        }
        private void ResetZoomAndActivateSelectTool()
        {
            diagram1.View.ZoomToActual();
            diagram1.View.Origin = new PointF(0, 0);
            diagram1.Controller.ActivateTool("SelectTool");
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            diagram1.Controller.Paste();
            btnPaste.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var s = diagram1.Controller.SelectionList;
            if (s != null && s.Count >0)
            {
               diagram1.Controller.Model.RemoveRange(s);
            }
            diagram1.Refresh();
        }

        private void btnRedo_Click(object sender, EventArgs e) => diagram1.Model.HistoryManager.Redo();

        private void btnUndo_Click(object sender, EventArgs e) => diagram1.Model.HistoryManager.Undo();

        private void btnFlip_Click(object sender, EventArgs e)=> AddMirrorImage(diagram1);
        private void AddMirrorImage(Diagram diagramControl)
        {

            GroupOption(true);
            foreach (var connector in diagram1.Controller.SelectionList)
            {
                if (connector is Node line)
                {
                    line.FlipX = !line.FlipX;
                }
            } 
        }
        private void btnReset_Click(object sender, EventArgs e) => ResetZoomAndActivateSelectTool();

        private void btnUngroup_Click(object sender, EventArgs e)
        {
            GroupOption(false);
        }

        private void btnPolyline_Click(object sender, EventArgs e)
        {

        }
    }
    public static class StringExtensions
    {
        public static float ToFloat(this string input)
        {
            if (float.TryParse(input, out float result))
                return result;
            throw new FormatException($"'{input}' is not a valid float.");
        }
    }
}

