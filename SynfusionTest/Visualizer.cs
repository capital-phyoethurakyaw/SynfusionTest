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
using System.Windows.Documents;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
//using System.Windows.Media;

namespace Visualizer
{
    public partial class Visualizer : Form
    {
        public Visualizer()//pyk
        {
            InitializeComponent();
            pnlMenus.Visible = false;
            tableLayoutPanel1.RowStyles[0].Height = 0;
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

            if (sender is Label lblmenu && lblmenu.Name == "lblMenuSetting")
            {
                //if (pnlMenus.Text == "◀")
                //    pnlMenus.Text = "▼";
                //else
                //    pnlMenus.Text = "◀";
               // ShowMenuWithAnimation();
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
            //if (sender is Label lblmenu && lblmenu.Name == "lblMenuSetting")
            //{
            //    ShowMenuWithAnimation();
            //}
            //if (sender is Label lblmenu && lblmenu.Name == "lblMenuSetting")
            //{
            //    if (pnlMenus.Text == "◀")
            //        pnlMenus.Text = "▼";
            //    else
            //        pnlMenus.Text = "◀";
            //    //ShowMenuWithAnimation();
            //}
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            { 
                #region Input

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
                if (string.IsNullOrEmpty(fileCompartment) || string.IsNullOrEmpty(fileHull))
                {
                    MessageBoxAdv.Show("Import both compartment and hull data files at once!", "Warning");
                    return;
                }
                InitialFitDocument(diagram1);
                InitialFitDocument(diagram2);
                GetInputData(fileCompartment, fileHull);
                #endregion

                ChangePinpointProfile(); 
                BuildProfile(diagram1);


                ChangePinpointPlan();
                BuildPlan(diagram2);
                 
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(ex.Message, "Error");
                return;
            }
        }
        private void BuildPlan(Diagram diagram)
        { 
            diagram.Model.AppendChildren(ncCompartmentPlan, out int pl);
           // diagram.Model.AppendChild(ncHullPlan);
            diagram.Controller.SelectAll();
            diagram.FlipVertical();
            AddWaterlayer(diagram);
            MoveMiddle(diagram);
        }
        private void BuildProfile(Diagram diagram)
        {
            diagram.Model.AppendChild(ncHullProfile); 
            diagram.Model.AppendChildren(ncCompartmentProfile, out int pr); 
            diagram.Controller.SelectAll();
            diagram.FlipVertical();
            AddWaterlayer(diagram);
            MoveMiddle(diagram);
        }

        private void GetInputData(string fileCompartment,string fileHull)
        { 
            ncCompartmentPlan = new NodeCollection();
            ncCompartmentProfile = new NodeCollection();
            ncHullPlan = null;
            ncHullProfile = null;
            LoadCompartmentData(fileCompartment);//"C:\\Users\\Asus\\OneDrive\\Documents\\CompartmentDataFromSh2.txt"

            LoadHullData(fileHull);//"C:\\Users\\Asus\\OneDrive\\Documents\\HULLDataFromSh2.txt"
        }
        private void InitialFitDocument(Diagram diagram)
        {
            diagram.FitDocument();
            diagram.Model.BoundaryConstraintsEnabled = true;
            diagram.Model.BoundaryConstraintsEnabled = false;
            diagram.Model.EndUpdate();
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

        private void btnPointer_Click(object sender, EventArgs e) => _activeDiagram.Controller.ActivateTool("SelectTool");

        private void btnPan_Click(object sender, EventArgs e) => _activeDiagram.Controller.ActivateTool("PanTool");

        private void btnRuler_Click(object sender, EventArgs e) => diagram1.ShowRulers = !diagram1.ShowRulers;

        private void btnZoom_Click(object sender, EventArgs e) => _activeDiagram.View.ZoomIn();
        //Second half started
        private void btnZoomOut_Click(object sender, EventArgs e) => _activeDiagram.View.ZoomOut();

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
            _activeDiagram.Controller.Copy();
            btnPaste.Enabled = true;

            CopySelectedNodeToClipboard(_activeDiagram);

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
            _activeDiagram.Controller.Paste();
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
        private Diagram _activeDiagram;  // To store the currently active diagram
        private void SetActiveDiagram(Diagram diagram)
        {
            _activeDiagram = diagram;
        }
        private void ZoomActiveDiagram(float zoomFactor)
        {
            if (_activeDiagram != null)  // Ensure an active diagram is set
            {
                _activeDiagram.Refresh();  // Refresh the diagram view
            }
        }
        private Button bd;
        private void Visualizer_Load(object sender, EventArgs e)
        {
            AddToolTips();
            MakeSettingForDiagram(diagram1);
            MakeSettingForDiagram(diagram2);
            diagram1.GotFocus += Diagram1_GotFocus;
            diagram2.GotFocus += Diagram2_GotFocus;
            //PanelHeight = 355-  lblMenuSetting.Width; 

            floatButton = new IconButton
            {
                Text = "+ ",
                Width = 40,
                Height = btnZoom.Height+5,
                BackColor = System.Drawing.Color.LightBlue,
                FlatStyle = FlatStyle.Flat,
               // IconChar= IconChar.Toolbox,
               // ImageAlign= ContentAlignment.MiddleCenter,
                TextImageRelation= TextImageRelation.Overlay,
                
            };
            //floatButton.BackColor= Color.Transparent;
            //floatButton.BackColor= Color.Transparent;
            floatButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            floatButton.Visible = false;
            this.Controls.Add(floatButton);
            floatButton.BringToFront();
            floatButton.Click += FloatButton_Click;
            SetFloatButtonLocation();

            //menu.Opening += Menu_Opening;
            //menu.Closing += Menu_Closing;
        }
        private bool isContextMenuOpen = false;  // Set the flag to true when opening

        private void Menu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            isContextMenuOpen = false;
        }

        private void Menu_Opening(object sender, CancelEventArgs e)
        {
            isContextMenuOpen= true;
        }

        private void FloatButton_Click(object sender, EventArgs e)
        {
            SetLocationPanel(true);
            //ResizeDiagram(_activeDiagram);
            //this.Refresh();
            //this.Update();
            //this.UpdateStyles();
            //pnlMenus.BringToFront();

            //ContextMenuStrip menu = new ContextMenuStrip();
            //menu.Items.Add("Option 1");
            //menu.Items.Add("Option 2");
            //menu.Items.Add("Option 3" ); 
            //Point buttonScreenPos = floatButton.PointToScreen(new Point(0, floatButton.Height)); 
            //menu.Show(buttonScreenPos);

            //ContextMenuStrip menu = new ContextMenuStrip();

            //// Create a Button to be embedded in the menu
            //Button embeddedButton = new Button();
            //embeddedButton.Text = "Click Me!";
            //embeddedButton.AutoSize = true;
            //embeddedButton.Click += EmbeddedButton_Click;  // Assign click event

            //// Host the button in a ToolStripControlHost
            //ToolStripControlHost host = new ToolStripControlHost(embeddedButton);

            //// Add the hosted button to the ContextMenuStrip
            //menu.Items.Add(host);

            //// Display the ContextMenuStrip next to the button that was clicked
            //Point buttonPosition = floatButton.PointToScreen(new Point(0, floatButton.Height));
            //menu.Show(buttonPosition);

            //FlowLayoutPanel panel = new FlowLayoutPanel();
            //panel.FlowDirection = FlowDirection.LeftToRight;
            //panel.AutoSize = true;
            //panel.BackColor = Color.White;

            //// Add buttons or labels as items to the FlowLayoutPanel
            //panel.Controls.Add(new Button() { Text = "Option 1", AutoSize = true });
            //panel.Controls.Add(new Button() { Text = "Option 2", AutoSize = true });
            //panel.Controls.Add(new Button() { Text = "Option 3", AutoSize = true });

            //// Create a ToolStripControlHost to host the FlowLayoutPanel
            //ToolStripControlHost host = new ToolStripControlHost(panel);

            //// Create a ContextMenuStrip and add the hosted panel
            //ContextMenuStrip menu = new ContextMenuStrip();
            //menu.Items.Add(host);

            //// Get the button's screen position
            //Point buttonScreenPos = floatButton.PointToScreen(new Point(0, floatButton.Height));

            //// Show the menu at the calculated position
            //menu.Show(buttonScreenPos);
        }
        private void EmbeddedButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button inside ContextMenu clicked!");
        }
        private void SetLocationPanel(bool IsTrigger =false)
        {
            if (floatButton == null) return;
            if (!IsTrigger && !isContextMenuOpen)
            {
                return;
            }
            //var buttonLocation = floatButton.PointToScreen(Point.Empty);

            //int panelX = buttonLocation.X - pnlMenus.Width-20;
            //int panelY = buttonLocation.Y + 10;
            //pnlMenus.Visible = !pnlMenus.Visible;
            ////pnlMenus.BringToFront();
            //  this.Update();
            ////pnlMenus.Refresh();
            //pnlMenus.Location = this.PointToClient(new Point(panelX, panelY));
            //if (pnlMenus.Location.X == 3 && pnlMenus.Location.Y == 3)
            //{
            //      pnlMenus.Location= this.PointToClient(new Point(panelX, panelY));

            //}
            //else
            //{

            //}


            ////pnlMenus.BringToFront();   // ***DONT DELETE THIS COMMMAND REFRESH PANEL 
            ///

            //var buttonLocation = floatButton.PointToScreen(Point.Empty);

            //int panelX = buttonLocation.X - pnlMenus.Width -3;
            //int panelY = buttonLocation.Y - 3;
            //pnlMenus.Visible = !pnlMenus.Visible; 
            //this.Update(); pnlMenus.BringToFront();

            //pnlMenus.Dock = DockStyle.None;
            //pnlMenus.Location = this.PointToClient(new Point(panelX, panelY));
            //if (pnlMenus.Location.X == 3 && pnlMenus.Location.Y == 3)
            //{
            //    //pnlMenus.Top += 100;
            //  //  pnlMenus.Location = this.PointToScreen(new Point(panelX, panelY));

            //}
            //else
            //{

            //} 

            //pnlMenus.Width = btnImport.Width * 6;
          
            ToolStripControlHost host = new ToolStripControlHost(pnlMenus)
            {
                AutoSize = false,
                Size = pnlMenus.Size, 
            }; 
            pnlMenus.Margin = new Padding(0);
            pnlMenus.Padding= new Padding(0);   
            host.Margin = new Padding(0);  
            host.Padding = new Padding(0);
            ContextMenuStrip menu = new ContextMenuStrip()
            {
            };
            menu.ShowImageMargin = false;
            menu.ShowCheckMargin = false; 
            menu.Padding = new Padding(0);
            menu.Margin = new Padding(0);
            menu.Renderer = new CustomStripRenderer(); 
            menu.Items.Add(host); 
           
            menu.Size = pnlMenus.Size;
            menu.BackColor = Color.LightBlue; 
            menu.AutoSize = false;
            int panelX = floatButton.PointToScreen(Point.Empty).X - menu.Width;
            int panelY = floatButton.PointToScreen(Point.Empty).Y; 
          
            menu.Show(new Point(panelX, panelY));

        }
     
        private void SetFloatButtonLocation()
        {
            if (_activeDiagram == null) return;
            int buttonX = _activeDiagram.Width - floatButton.Width;  // 10 px padding from right
            int buttonY = _activeDiagram.ClientRectangle.Top;  // 10 px padding from top

            floatButton.Location = _activeDiagram.PointToScreen(new Point(buttonX, buttonY));
            floatButton.Location = this.PointToClient(floatButton.Location);
             
        }
         private IconButton floatButton;
         
        private void Diagram2_GotFocus(object sender, EventArgs e)
        {
            _activeDiagram = diagram2;
            _activeDiagram.Refresh();
            _activeDiagram.UpdateStyles();
        }

        private void Diagram1_GotFocus(object sender, EventArgs e)
        {
            _activeDiagram = diagram1;
            _activeDiagram.Refresh();
            _activeDiagram.UpdateStyles();
        }
        public void CopySelectedNodeToClipboard(Diagram diagram)
        { 
            if (diagram.Controller.SelectionList.Count > 0)
            { 
                RectangleF bounds = diagram.Controller.GetBoundingRect(diagram.Controller.SelectionList, MeasureUnits.Pixel);
                Bitmap bitmap = new Bitmap((int)bounds.Width, (int)bounds.Height);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White);  
                     
                    g.TranslateTransform(-bounds.X, -bounds.Y);
                     
                    foreach (Node node in diagram.Controller.SelectionList.OfType<Node>())  node.Draw(g);  
                } 
                Clipboard.SetImage(bitmap); 
            } 
        }
        private void MakeSettingForDiagram(Diagram diagram)
        {
            diagram.FitDocument();
            diagram.View.Grid.Visible = false;
            string[] menu = new string[] {
            "Pointer",
            "Pan",
            "Zoom",
            "Copy",
            "Paste",
            }
   ;
            var cm = diagram.ContextMenuStrip;
            foreach (ToolStripItem n in cm.Items)
            {
                if (!menu.Contains(n.Text))
                    n.Visible = false;
            }
            diagram.View.Model.DocumentSize = new PageSize(280, 140);

            //diagram.EndUpdate();
            //diagram.Update();
            //diagram.Refresh();
            diagram.FitDocument();
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
        private void ChangePinpointProfile()
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
            //diagram1.LayoutManager = null; 
            foreach (Node n in ncCompartmentProfile)
            {
                n.EditStyle.AllowMoveX = true;
                n.EditStyle.AllowMoveY = true;
                n.PinPoint = new PointF(n.PinPoint.X + maxNegX, (n.PinPoint.Y   ));
            }
            ncHullProfile.PinPoint = new PointF(ncHullProfile.PinPoint.X + maxNegX, (ncHullProfile.PinPoint.Y  ));
             
        }
        private void ChangePinpointPlan()
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
             
            //diagram1.LayoutManager = null;
            foreach (Node n in ncCompartmentPlan)
            {
                n.EditStyle.AllowMoveX = true;
                n.EditStyle.AllowMoveY = true;
                n.PinPoint = new PointF(n.PinPoint.X + maxNegX, (n.PinPoint.Y + maxNegY));
            }

            ncHullPlan.PinPoint = new PointF(ncHullPlan.PinPoint.X + maxNegX, (ncHullPlan.PinPoint.Y + maxNegY));
             
        }
        private void ChangePintpointOld()
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
             
            //diagram1.Model.DocumentSize = new PageSize(maxNegY, maxNegX);// System.Drawing.SizeF(landscapeWidth, landscapeHeight); 
            //diagram1.Document.View.FitDocument();
            //diagram1.Update();

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
        private void ResizeDiagram(Diagram diagram)
        {  
            diagram.FitDocument();
            diagram.Update();
            diagram.Refresh();
            diagram.EndUpdate();
            diagram.UpdateStyles(); 
        }
        private void Visualizer_Resize(object sender, EventArgs e)
        {
            ResizeDiagram(diagram1);
            ResizeDiagram(diagram2);
        }

        private void AddWaterlayer(Diagram diagram)
        {
            int diagramWidth = (int)(diagram.Model.DocumentSize.Width);
            int diagramHeight = (int)(diagram.Model.DocumentSize.Height);
            Syncfusion.Windows.Forms.Diagram.Rectangle reflection = new Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, diagramWidth, diagramHeight);
            reflection.FillStyle.Type = Syncfusion.Windows.Forms.Diagram.FillStyleType.LinearGradient;
            reflection.FillStyle.Color = Color.DarkBlue;
            reflection.FillStyle.ForeColor = Color.Aqua;
            reflection.FillStyle.GradientAngle = 90;
            reflection.LineStyle.LineWidth = 0f;
            reflection.EditStyle.AllowMoveY = false;
            reflection.EditStyle.AllowMoveX = false;
            diagram.Model.AppendChild(reflection);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
         //   MoveMiddle();
        }
        private void MoveMiddle(Diagram diagram)
        {
            RectangleF bounds = diagram.Model.GetBoundingRect();
            diagram.View.Model.DocumentSize = new PageSize(280, 140); //new PageSize(new PageSize(bounds.Width,bounds.Height)); 
                                                                       //diagram1.Model.EndUpdate();
            diagram.FitDocument();
            diagram.Model.SizeToContent = true;
            diagram.Model.BoundaryConstraintsEnabled = true;
            diagram.Model.BoundaryConstraintsEnabled = false;
            diagram.Update();
            diagram.Refresh();
            diagram.Controller.SelectAll();
            MoveSelectedItems(diagram, 15, 60);
            //diagram1.View.ZoomToSelection( new RectangleF(new PointF(0f,0f), new  SizeF(180f, 120f)));
            // diagram1.View.ScrollVirtualBounds= bounds;
        }
        public void MoveSelectedItems(Diagram diagram, float offsetX, float offsetY)
        {
            // Step 1: Get the selected elements from the diagram
            NodeCollection selectedItems = diagram.Controller.SelectionList;

            // Step 2: Loop through each selected element and move it
            foreach (Node node in selectedItems)
            {
                // Get the current location of the node
                PointF currentPosition = node.PinPoint;

                // Calculate the new position by adding the offset
                PointF newPosition = new PointF(
                    currentPosition.X + offsetX,
                    currentPosition.Y + offsetY
                );

                // Set the new position of the node
                node.PinPoint = newPosition;
            }
          
            // Step 3: Refresh the diagram to reflect the new positions
            diagram.Refresh();
        }
        private Button triggerButton;

        private void SetupTriggerButton()
        {
            triggerButton = new Button
            {
                Text = "Menu",
                Width = 100,
                Height = 40,
                Location = new Point(10, 10)
            };

            //// Add hover or click event to trigger the menu
            //triggerButton.MouseEnter += (s, e) => ShowMenuWithAnimation();
            //triggerButton.Click += (s, e) => ShowMenuWithAnimation();

            this.Controls.Add(triggerButton);
        }
        private int PanelHeight { get; set; } 
        private async void ShowMenuWithAnimation()
        {
            //if (fplMenus.Width == lblMenuSetting.Width)
            //{
            //    //pnlMenus.Visible = true;
            //    for (int i = 0; i <= PanelHeight; i++)
            //    {
            //        fplMenus.Width = i;
            //        await Task.Delay(5); // Smooth animation
            //    }
            //    // fplMenus.Text = "◀";
            //}
            //else
            //{
            //    for (int i = PanelHeight; i >= 0; i--)
            //    {
            //        fplMenus.Width = i;
            //        await Task.Delay(5); // Smooth animation
            //    }
            //    //pnlMenus.Visible = false;
            //    // fplMenus.Text = "▼";
            //}
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //if (pnlMenus.Text == "◀")
            //    pnlMenus.Text = "▼";
            //else
            //    pnlMenus.Text = "◀";
            pnlMenus.Visible= !pnlMenus.Visible;
            //ShowMenuWithAnimation();
        }

        private void diagram1_SizeChanged(object sender, EventArgs e)
        {
            SetFloatButtonLocation();
            SetLocationPanel();
        }

        private void diagram2_SizeChanged(object sender, EventArgs e)
        {
            SetFloatButtonLocation();
            SetLocationPanel();
        } 
        private void diagram1_MouseDown(object sender, MouseEventArgs e)
        {
            floatButton.Visible = true; 
            SetFloatButtonLocation();
           // SetLocationPanel();
        } 
        private void diagram2_MouseDown(object sender, MouseEventArgs e)
        {
             floatButton.Visible = true;
            SetFloatButtonLocation();
            //SetLocationPanel();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Visualizer_SizeChanged(object sender, EventArgs e)
        {
            //diagram1.Update();
            //diagram1.Invalidate();
            //diagram1.UpdateStyles();
            //diagram2.Update();
            //diagram2.Invalidate();
            //diagram2.UpdateStyles();
            //pnlMenus.Update();
            //pnlMenus.Refresh();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

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
    public class CustomStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextFormat = TextFormatFlags.Left;  // Align text to the left without padding
            base.OnRenderItemText(e);
        }
    }
}

