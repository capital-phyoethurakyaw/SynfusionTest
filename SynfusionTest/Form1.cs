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
using Syncfusion.Windows.Forms.Tools.Navigation;
using Syncfusion.Windows.Forms.Grid;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace SynfusionTest
{
    public partial class Form1 : Form
    {
        public Form1()//pyk
        {
            InitializeComponent();
            diagram1.DefaultContextMenuEnabled = false;
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
                ncCompartmentPlan = new NodeCollection();
                ncCompartmentProfile=new NodeCollection();
                ncHullPlan=null;
                ncHullProfile=null;
                diagram1.FitDocument();
                diagram1.Model.BoundaryConstraintsEnabled = true;
                diagram1.Model.BoundaryConstraintsEnabled = false;
                diagram1.Model.EndUpdate();

                OpenFileDialog openFileDialog = new OpenFileDialog();
                 
                openFileDialog.Multiselect = true;
                 
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                 
                openFileDialog.InitialDirectory = @"C:\";
                string fileCompartment = "";
                string fileHull = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    string[] selectedFiles = openFileDialog.FileNames;
                    if (selectedFiles.Count() != 2)
                    {
                        MessageBoxAdv.Show("Import both compartment and hull data files at once!", "Warning");
                        return;
                    }                    foreach (string file in selectedFiles)
                    {
                        if (Path.GetFileName(file)=="CompartmentDataFromSh2.txt")  // Process each file
                        {
                            fileCompartment = file;
                        }
                        if (Path.GetFileName(file) == "HULLDataFromSh2.txt")  // Process each file
                        {
                            fileHull = file;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(fileCompartment))
                    LoadCompartmentData(fileCompartment);//"C:\\Users\\Asus\\OneDrive\\Documents\\CompartmentDataFromSh2.txt"
                if (!string.IsNullOrEmpty(fileHull)) 
                    LoadHullData(fileHull);//"C:\\Users\\Asus\\OneDrive\\Documents\\HULLDataFromSh2.txt"
                ChangePintpoint();
                diagram1.Model.AppendChild(ncHullProfile);
                diagram1.Model.AppendChild(ncHullPlan);
                diagram1.Model.AppendChildren(ncCompartmentPlan, out int pl);
                diagram1.Model.AppendChildren(ncCompartmentProfile, out int pr);
                diagram1.Refresh();

            }
            catch(Exception ex)
            {
                MessageBoxAdv.Show(ex.Message, "Error");
                return;
            }
            // MessageBoxAdv.Show("The files have been imported", "Information");
        }
        private void LoadCompartmentData(string filePath)
        {
            try
            {
                string xml = File.ReadAllText(filePath);
                var serializer = new XmlSerializer(typeof(Compartments));
                ncCompartmentPlan = new NodeCollection();
                using (StringReader reader = new StringReader(xml))
                {
                    var compartments = ((Compartments)serializer.Deserialize(reader))?.CompartmentList;

                    foreach (var compartment in compartments)
                    {
                        if (compartment == null)
                        {
                            continue;
                        }
                        AddPolygonFromOutline(compartment.Profile.Outline.Pgon, 0, 0, "Profile");
                        AddPolygonFromOutline(compartment.Plan.Outline.Pgon, 0, 0, "Plan");
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

                    AddPolylineFromOutline(hull.Profile.Outline.Pgon, 0, 0, "Profile");
                    AddPolylineFromOutline(hull.Plan.Outline.Pgon, 0, 0, "Plan");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading hull data: " + ex.Message);
            }
        }

        private void AddPolygonFromOutline(Pgon pgon, float offsetX, float offsetY, string shapes)
        {
            if (pgon?.XCoordinates.Contains(",") == true)
            {
                if (shapes == "Profile")
                {
                    var points = GetTransformedPoints(pgon.XCoordinates, pgon.YCoordinates, offsetX, offsetY);
                    var polygon = new Polygon(points.ToArray())
                    {
                        LineStyle = { LineColor = Color.Black, LineWidth = 0.1f },
                        FillStyle = { Color = Color.Green }
                    };
                    ncCompartmentProfile.Add(polygon); 
                }
                if (shapes == "Plan")
                {
                    var points = GetTransformedPoints(pgon.XCoordinates, pgon.YCoordinates, offsetX, offsetY);
                    var polygon = new Polygon(points.ToArray())
                    {
                        LineStyle = { LineColor = Color.Black, LineWidth = 0.1f },
                        FillStyle = { Color = Color.Red }
                    };
                    ncCompartmentPlan.Add(polygon);

                }  
            }
        }

        private void AddPolylineFromOutline(Pgon pgon, float offsetX, float offsetY, string shape)
        {
            if (pgon?.XCoordinates.Contains(",") == true)
            {
                var points = GetTransformedPoints(pgon.XCoordinates, pgon.YCoordinates, offsetX, offsetY);
                if (shape == "Profile")
                {
                    ncHullProfile = new PolyLineConnector(points.ToArray())
                    {
                        LineStyle = { LineColor = Color.Black, LineWidth = 0.1f }
                    };
                    //diagram1.Model.AppendChild(ncHullProfile);

                }
                if (shape == "Plan")
                {
                    ncHullPlan = new PolyLineConnector(points.ToArray())
                    {
                        LineStyle = { LineColor = Color.Black, LineWidth = 0.1f }
                    };
                   // diagram1.Model.AppendChild(ncHullPlan);
                }
                //diagram1.Refresh();
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
            //{
            //    var xpoint = lx[i].Trim().ToFloat() + offsetX;
            //    var ypoint = ly[i].Trim().ToFloat() + offsetY;
            //    var transformedPoint = TransformPoint(new PointF(xpoint, ypoint), diagramWidth, diagramHeight); //ptk changed temly

            //    points.Add(transformedPoint);
               points.Add(new PointF(lx[i].Trim().ToFloat(), ly[i].Trim().ToFloat()));
            }
            return points;
        }
        protected PointF TransformPoint(PointF originalPoint, float width, float height)
        {
            float newX = width - originalPoint.X;
            float newY = height - originalPoint.Y;
            return new PointF(newX, newY);
        }

        private void btnPointer_Click(object sender, EventArgs e) => diagram1.Controller.ActivateTool("SelectTool");

        private void btnPan_Click(object sender, EventArgs e) => diagram1.Controller.ActivateTool("PanTool");

        private void btnRuler_Click(object sender, EventArgs e) => diagram1.ShowRulers = !diagram1.ShowRulers;

        private void btnZoom_Click(object sender, EventArgs e) => diagram1.View.ZoomIn();
        //Second half started
        private void btnZoomOut_Click(object sender, EventArgs e) => diagram1.View.ZoomOut();

        private void btnLock_Click(object sender, EventArgs e)
        {
            diagram1.Enabled = !diagram1.Enabled;
            var msg = "";
            if (!diagram1.Enabled)
            {
                btnLock.Text = "Unlock";
                msg = "The diagram have been disableb.";
            }

            else
            {
                btnLock.Text = "Lock";
                msg = "The diagram have been enable";
            }

            MessageBoxAdv.Show(msg, "Information");
        }

        private void btnPrint_Click(object sender, EventArgs e) => Print();
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
            if (s != null && s.Count > 0)
            {
                if (diagram1.Controller != null && diagram1.Controller.Model != null)
                {
                    foreach (Node n in s)
                    {
                        diagram1.Model.RemoveChild(n);
                    }
                  //  diagram1.Controller.Model.RemoveRange(s);
                }
            }
            diagram1.Refresh();
        }

        private void btnRedo_Click(object sender, EventArgs e) => diagram1.Model.HistoryManager.Redo();

        private void btnUndo_Click(object sender, EventArgs e) => diagram1.Model.HistoryManager.Undo();

        private void btnFlip_Click(object sender, EventArgs e) => AddMirrorImage(diagram1);
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

        private void btnPolyline_Click(object sender, EventArgs e) => SetActiveTool("PolylineLinkTool");
        private void SetActiveTool(string toolName)
        {
            this.diagram1.Controller.ActivateTool(toolName);
        }
        private void btnOrthoLabel_Click(object sender, EventArgs e) => SetActiveTool("OrthogonalLinkTool");//  OrgLineConnectorTool

        private void btnDirectedLabel_Click(object sender, EventArgs e) => SetActiveTool("DirectedLineLinkTool");
        private PolyLineConnector ncHullProfile = null;
        private PolyLineConnector ncHullPlan = null;
        private NodeCollection ncCompartmentProfile = new NodeCollection();
        private NodeCollection ncCompartmentPlan = new NodeCollection();

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (Node n in ncCompartmentPlan)
            {
                n.Visible = chkCom_Top.Checked;
            }
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (Node n in ncCompartmentProfile)
            {
                n.Visible = chkCom_Side.Checked;
            }
        }

        private void chkHull_Top_CheckStateChanged(object sender, EventArgs e)
        {
            if (ncHullPlan != null)
                ncHullPlan.Visible = chkHull_Top.Checked;
        }

        private void chkHull_Side_CheckStateChanged(object sender, EventArgs e)
        {
            if (ncHullProfile != null)
                ncHullProfile.Visible = chkHull_Side.Checked;
        }

        private void btnDocFit_Click(object sender, EventArgs e)
        { 
            diagram1.FitDocument();
        }
        private void AddToolTips()
        {
            FindButtonsRecursive(flowLayoutPanel1);
            
        }
        private void FindButtonsRecursive(Control parent)
        { 
            foreach (Control control in parent.Controls)
            { 
                if (control is FontAwesome.Sharp.IconButton fb)
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.AutomaticDelay = 5000;
                    toolTip.InitialDelay = 1000;
                    toolTip.ReshowDelay = 500;
                    toolTip.ShowAlways = true;
                    toolTip.SetToolTip(fb, fb.Text.Replace("btn", ""));
                }
                if (control is Syncfusion.Windows.Forms.Tools.CheckBoxAdv chk)
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.AutomaticDelay = 5000;
                    toolTip.InitialDelay = 1000;
                    toolTip.ReshowDelay = 500;
                    toolTip.ShowAlways = true;
                    toolTip.SetToolTip(chk, chk.Text.Replace("chk", ""));
                }
                if (control.HasChildren)
                {
                    FindButtonsRecursive(control);  
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            diagram1.FitDocument();
            AddToolTips();
        }
        public void ResizeDocumentToFitDiagram(Diagram diagram)
        {
            SizeF boundingSize = GetDiagramBoundingSize(diagram);     
            diagram.Model.DocumentSize = new PageSize(boundingSize.Width, boundingSize.Height);
        }
        public Size GetDiagramBoundingSize(Diagram diagram)
        {
            // Initialize minimum and maximum extents
            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            // Iterate through all nodes (shapes) in the diagram
            foreach (Node node in diagram.Model.Nodes)
            {
                // Get the bounding rectangle of the node
                RectangleF bounds = node.BoundingRectangle;

                // Update min and max extents
                minX = Math.Min(minX, bounds.Left);
                minY = Math.Min(minY, bounds.Top);
                maxX = Math.Max(maxX, bounds.Right);
                maxY = Math.Max(maxY, bounds.Bottom);
            }

            //Iterate through all connectors(lines) in the diagram
            foreach (Node c in diagram.Model.Nodes)
            {
                if (c is LineConnector connector)
                {
                    // Get the bounding rectangle of the connector
                    RectangleF bounds = connector.BoundingRectangle;

                    // Update min and max extents
                    minX = Math.Min(minX, bounds.Left);
                    minY = Math.Min(minY, bounds.Top);
                    maxX = Math.Max(maxX, bounds.Right);
                    maxY = Math.Max(maxY, bounds.Bottom);
                }
            }

            // Calculate the overall width and height
            float totalWidth = maxX - minX;
            float totalHeight = maxY - minY;
            float padding = 50; // Add 50 pixels padding
            totalWidth += padding;
            totalHeight += padding;
            var sizeF = new SizeF(totalWidth, totalHeight);
            return new Size((int)Math.Round(sizeF.Width), (int)Math.Round(sizeF.Height));

        }
        private void ChangePintpoint()
        {
            float maxNegX = 0.0f;
            float maxNegY = 0.0f;
            foreach (Node n in ncCompartmentPlan)
            {
                if (Math.Abs(maxNegX) < Math.Abs(n.BoundingRectangle.Location.X))
                {
                    maxNegX = Math.Abs(n.BoundingRectangle.Location.X);
                }
                if (Math.Abs(maxNegY) < Math.Abs(n.BoundingRectangle.Location.Y))
                {
                    maxNegY = Math.Abs(n.BoundingRectangle.Location.Y);
                }
            } 
            diagram1.LayoutManager = null;
            foreach (Node n in ncCompartmentPlan)
            {
                n.EditStyle.AllowMoveX = true;
                n.EditStyle.AllowMoveY = true;
                n.PinPoint = new PointF(n.PinPoint.X + maxNegX,  (n.PinPoint.Y + maxNegY));
            }
            foreach (Node n in ncCompartmentProfile)
            {
                n.EditStyle.AllowMoveX = true;
                n.EditStyle.AllowMoveY = true;
                n.PinPoint = new PointF(n.PinPoint.X + maxNegX,   (n.PinPoint.Y + maxNegY + 100));
            }
            ncHullPlan.PinPoint= new PointF(ncHullPlan.PinPoint.X + maxNegX, ( ncHullPlan.PinPoint.Y + maxNegY +200));
            ncHullProfile.PinPoint= new PointF(ncHullProfile.PinPoint.X + maxNegX,   (ncHullProfile.PinPoint.Y + maxNegY + 300));
            diagram1.Refresh();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var d = btnPrint.IconChar;
            var dl = colorDialog1.ShowDialog();
            if (dl == DialogResult.OK)
            { 
                var selectNodes = diagram1.Controller.SelectionList;
                if (selectNodes != null && selectNodes.Count > 0)
                {
                    foreach (Node n in selectNodes)
                    {
                        if (n != null && n is Polygon pg)
                        {
                            pg.FillStyle.Color = colorDialog1.Color;
                        }
                        if (n != null && n is PolylineNode pl)
                        {
                            pl.LineStyle.LineColor = colorDialog1.Color;
                        }
                    }
                }
            }
        } 
        private void btnFit_Click(object sender, EventArgs e)
        { 
            ResizeDocumentToFitDiagram(diagram1);
            diagram1.FitDocument();
        }
    }
    public static class StringExtensions
    {
        public static float ToFloat(this string input)
        {
            if (float.TryParse(input, out float result))
            {
                return result;
            }
            else
            {
                return 0f;
            }
            throw new FormatException($"'{input}' is not a valid float.");
        }
    }
}

