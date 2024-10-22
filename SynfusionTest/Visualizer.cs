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
using System.Windows.Shapes;
using System.Reflection;

namespace Visualizer
{
    public partial class Visualizer : Form
    {
        public Visualizer()//pyk
        {
            InitializeComponent();
            //diagram1.DefaultContextMenuEnabled = false;
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
                ncCompartmentProfile = new NodeCollection();
                ncHullPlan = null;
                ncHullProfile = null;
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
                    }
                    foreach (string file in selectedFiles)
                    {
                        if (System.IO.Path.GetFileName(file) == "CompartmentDataFromSh2.txt")  // Process each file
                        {
                            fileCompartment = file;
                        }
                        if (System.IO.Path.GetFileName(file) == "HULLDataFromSh2.txt")  // Process each file
                        {
                            fileHull = file;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(fileCompartment))
                    LoadCompartmentData(fileCompartment);//"C:\\Users\\Asus\\OneDrive\\Documents\\CompartmentDataFromSh2.txt"
                else
                    return;
                if (!string.IsNullOrEmpty(fileHull))
                    LoadHullData(fileHull);//"C:\\Users\\Asus\\OneDrive\\Documents\\HULLDataFromSh2.txt"
                else
                    return;
                ChangePintpoint();
                diagram1.Model.AppendChild(ncHullProfile);
                ncHullPlan.Visible = false;  //Not working please fix later
                diagram1.Model.AppendChild(ncHullPlan);   //Not working please fix later
                diagram1.Model.AppendChildren(ncCompartmentPlan, out int pl);
                diagram1.Model.AppendChildren(ncCompartmentProfile, out int pr); 
                diagram1.Model.AppendChild(ncHullPlan);
                diagram1.Controller.SelectAll();
                diagram1.FlipVertical();
                AddWaterlayer();
                diagram1.Refresh();
            }
            catch (Exception ex)
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
                    var polygon = new Syncfusion.Windows.Forms.Diagram.Polygon(points.ToArray())
                    {
                        LineStyle = { LineColor = Color.Black, LineWidth = 0.1f },
                        FillStyle = { Color = Color.Green }
                    };
                    ncCompartmentProfile.Add(polygon); 
                }
                if (shapes == "Plan")
                {
                    var points = GetTransformedPoints(pgon.XCoordinates, pgon.YCoordinates, offsetX, offsetY);
                    var polygon = new Syncfusion.Windows.Forms.Diagram.Polygon(points.ToArray())
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
                this.Text = System.IO.Path.GetFileNameWithoutExtension(this.fileName);
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
          
            if (diagram1.Controller.SelectionList.Count > 0)
            { 
                var selectedNode = diagram1.Controller.SelectionList[0];
                 
                diagram1.Model.Nodes.Remove(selectedNode);
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
        private void Visualizer_Load(object sender, EventArgs e)
        {
            diagram1.FitDocument();
            diagram1.View.Grid.Visible =false; 
            // diagram1.View.Origin= new Point(0,0);
            AddToolTips();
            HideMenus();
            //diagram1.Dock = DockStyle.Fill;
            //diagram1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }

        private void HideMenus()
        {
            string[] menu = new string[] {
            "Pointer",
            "Pan",
            "Zoom",
            "Copy",
            "Paste",
            }
           ;
            var cm = diagram1.ContextMenuStrip;
            foreach (ToolStripItem n in cm.Items)
            {
                if (!menu.Contains(n.Text)) 
                    n.Visible = false; 
            }
             
        }
        public void ResizeDocumentToFitDiagram(Diagram diagram)
        {
            try
            {
              //  SizeF boundingSize = GetDiagramBoundingSize(diagram);
              //  diagram.Model.DocumentSize = new PageSize(boundingSize.Width, boundingSize.Height);
            } catch { }
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


            ncHullPlan.PinPoint = new PointF(ncHullPlan.PinPoint.X + maxNegX, (ncHullPlan.PinPoint.Y + maxNegY + 100));


            ncHullProfile.PinPoint= new PointF(ncHullProfile.PinPoint.X + maxNegX,   (ncHullProfile.PinPoint.Y + maxNegY + 100));

            //PointF[] p = new PointF[2];
            //p[0] = new PointF(0, (ncHullProfile.PinPoint.Y + maxNegY + 310));
            //var polyline = new Syncfusion.Windows.Forms.Diagram.PolylineNode(p);
            //polyline.LineStyle.LineColor = Color.Transparent;
          //  diagram1.Model.Nodes.Add(polyline);
            // diagram1.Refresh();
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
                        if (n != null && n is Syncfusion.Windows.Forms.Diagram.Polygon pg)
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
           // diagram1.FitDocument();
            ResizeDocumentToFitDiagram(diagram1);
            diagram1.FitDocument();
        }

        private void Visualizer_Resize(object sender, EventArgs e)
        {
            //diagram1.Width = this.ClientSize.Width - 20;  // Adjust based on desired padding
            //diagram1.Height = this.ClientSize.Height - 20; // Adjust based on desired padding

           // diagram1.FitDocument();
            ResizeDocumentToFitDiagram(diagram1);
            diagram1.FitDocument();
  //          diagram1.Dock = DockStyle.Fill;
//            diagram1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }

        private void AddWaterlayer()
        {
            int diagramWidth = (int)(diagram1.Model.DocumentSize.Width);
            int diagramHeight = (int)(diagram1.Model.DocumentSize.Height);
            Syncfusion.Windows.Forms.Diagram.Rectangle reflection = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, diagramWidth, diagramHeight);
            reflection.FillStyle.Type = Syncfusion.Windows.Forms.Diagram.FillStyleType.LinearGradient;
            reflection.FillStyle.Color = Color.DarkBlue;
            reflection.FillStyle.ForeColor = Color.Aqua;
            reflection.FillStyle.GradientAngle = 90;
            reflection.LineStyle.LineWidth = 0f;
            reflection.EditStyle.AllowMoveY = false;
            reflection.EditStyle.AllowMoveX = false;
            diagram1.Model.AppendChild(reflection);
            reflection.ZOrder = 0;
            //reflection.CanEditSegment();
            
            reflection.EditStyle.AllowSelect = false;
            reflection.EditStyle.AllowMoveY = reflection.EditStyle.AllowMoveX =false;
            // AddPanelToDiagram();
        }
        private void AddPanelToDiagram()
        {
            // Step 1: Create a Panel and configure its appearance.
            Panel customPanel = new Panel
            {
                Size = new Size(200, 150),   // Set the size of the panel.
                BackColor = Color.LightBlue, // Panel background color.
                BorderStyle = BorderStyle.FixedSingle  // Optional border.
            };
            int diagramWidth = (int)(diagram1.Model.DocumentSize.Width);
            int diagramHeight = (int)(diagram1.Model.DocumentSize.Height);
            //// Optional: Add child controls inside the panel (like buttons or labels).
            //Button button = new Button
            //{
            //    Text = "Click Me",
            //    Location = new Point(50, 50)  // Position within the panel.
            //};
            //customPanel.Controls.Add(button);  // Add button to the panel.

            // Step 2: Create a ControlNode to wrap the panel.
            RectangleF panelBounds = new RectangleF(0, 0, diagramWidth, diagramHeight);

            Syncfusion.Windows.Forms.Diagram.ControlNode panelNode =
                new Syncfusion.Windows.Forms.Diagram.ControlNode(customPanel, panelBounds);

            // Step 3: Add the ControlNode to the diagram's model.
            diagram1.Model.AppendChild(panelNode);
            panelNode.ZOrder = 0;
        }
        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            //if (lblOpenMenu.Text == "▶ Menu")
            //{
            //    lblOpenMenu.Text = "▼ Menu"; 
            //    lblLabel.Visible = lblFile.Visible = lblView.Visible = lblEdit.Visible = lblGeneral.Visible = true;
            //    fpGeneral.Visible = fpFile.Visible = fpView.Visible = fpEdit.Visible = fpLabel.Visible = true;

            //}
            //else
            //{
            //    lblOpenMenu.Text = "▶ Menu";
            //    lblLabel.Visible = lblFile.Visible = lblView.Visible = lblEdit.Visible = lblGeneral.Visible = false;
            //    fpGeneral.Visible = fpFile.Visible = fpView.Visible = fpEdit.Visible = fpLabel.Visible = false;
            //}
        }

        private void diagram1_MouseHover(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Arrow; ;
            //// Perform hit testing to detect the diagram element under the mouse.
            //var element = diagram1.Model.Get(e.Location) as INode;

            //if (element != null && element is Syncfusion.Windows.Forms.Diagram.Rectangle)
            //{
            //    // Change the cursor to an arrow when hovering over the rectangle.
            //    Cursor = Cursors.Arrow;
            //}
            //else
            //{
            //    // Revert to the default cursor if not over the rectangle.
            //    Cursor = Cursors.Default;
            //}
        }

        private void diagram1_MouseEnter(object sender, EventArgs e)
        {
            diagram1.Cursor= Cursors.Arrow;
            this.Cursor = Cursors.Arrow; ;
        }

        private void diagram1_MouseMove(object sender, MouseEventArgs e)
        {
            // Perform hit testing to detect the diagram element under the mouse.
            //var element = diagram1.Model.(e.Location)  ;

            //if (element != null && element is Syncfusion.Windows.Forms.Diagram.Rectangle)
            //{
            //    // Change the cursor to an arrow when hovering over the rectangle.
            //    Cursor = Cursors.Arrow;
            //}
            //else
            //{
            //    // Revert to the default cursor if not over the rectangle.
            //    Cursor = Cursors.Default;
            //}
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
    public class GradientPanel : Panel
    {
        public Color StartColor { get; set; } = Color.DarkBlue;
        public Color EndColor { get; set; } = Color.Aqua;
        public float GradientAngle { get; set; } = 90f;

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, StartColor, EndColor, GradientAngle))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}

