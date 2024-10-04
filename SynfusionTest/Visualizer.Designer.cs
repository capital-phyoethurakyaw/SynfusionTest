namespace SynfusionTest
{
    partial class Visualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Diagram.Binding binding1 = new Syncfusion.Windows.Forms.Diagram.Binding();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizer));
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.fpGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPointer = new FontAwesome.Sharp.IconButton();
            this.btnPan = new FontAwesome.Sharp.IconButton();
            this.btnRuler = new FontAwesome.Sharp.IconButton();
            this.btnZoom = new FontAwesome.Sharp.IconButton();
            this.btnZoomOut = new FontAwesome.Sharp.IconButton();
            this.btnLock = new FontAwesome.Sharp.IconButton();
            this.lblFile = new System.Windows.Forms.Label();
            this.fpFile = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.btnPreview = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSaveAs = new FontAwesome.Sharp.IconButton();
            this.btnFit = new FontAwesome.Sharp.IconButton();
            this.btnImport = new FontAwesome.Sharp.IconButton();
            this.lblEdit = new System.Windows.Forms.Label();
            this.fpEdit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRotate = new FontAwesome.Sharp.IconButton();
            this.btnCopy = new FontAwesome.Sharp.IconButton();
            this.btnPaste = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnRedo = new FontAwesome.Sharp.IconButton();
            this.btnUndo = new FontAwesome.Sharp.IconButton();
            this.btnFlip = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnUngroup = new FontAwesome.Sharp.IconButton();
            this.btnColor = new FontAwesome.Sharp.IconButton();
            this.lblView = new System.Windows.Forms.Label();
            this.fpView = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCom_Side = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkCom_Top = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkHull_Side = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkHull_Top = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.fpLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPolyline = new FontAwesome.Sharp.IconButton();
            this.btnOrthoLabel = new FontAwesome.Sharp.IconButton();
            this.btnDirectedLabel = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.fpGeneral.SuspendLayout();
            this.fpFile.SuspendLayout();
            this.fpEdit.SuspendLayout();
            this.fpView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCom_Side)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCom_Top)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkHull_Side)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHull_Top)).BeginInit();
            this.fpLabel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagram1
            // 
            binding1.DefaultConnector = null;
            binding1.DefaultNode = null;
            binding1.Diagram = this.diagram1;
            binding1.Id = null;
            binding1.Label = ((System.Collections.Generic.List<string>)(resources.GetObject("binding1.Label")));
            binding1.ParentId = null;
            this.diagram1.Binding = binding1;
            this.diagram1.Controller.Constraint = Syncfusion.Windows.Forms.Diagram.Constraints.PageEditable;
            this.diagram1.Controller.DefaultConnectorTool = Syncfusion.Windows.Forms.Diagram.ConnectorTool.OrgLineConnectorTool;
            this.diagram1.Controller.PasteOffset = new System.Drawing.SizeF(10F, 10F);
            this.diagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagram1.EnableTouchMode = false;
            this.diagram1.LayoutManager = null;
            this.diagram1.Location = new System.Drawing.Point(3, 3);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(481, 686);
            this.diagram1.SmartSizeBox = false;
            this.diagram1.TabIndex = 1;
            this.diagram1.Text = "diagram1";
            // 
            // 
            // 
            this.diagram1.View.ClientRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.diagram1.View.Controller = this.diagram1.Controller;
            this.diagram1.View.Grid.MinPixelSpacing = 4F;
            this.diagram1.View.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("resource.ScrollVirtualBounds")));
            this.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center;
            // 
            // model1
            // 
            this.model1.AlignmentType = Syncfusion.Windows.Forms.Diagram.AlignmentType.SelectedNode;
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 566.9291F;
            this.model1.DocumentSize.Width = 396.8504F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LogicalSize = new System.Drawing.SizeF(396.8504F, 566.9291F);
            this.model1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.SizeToContent = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Controls.Add(this.lblGeneral);
            this.flowLayoutPanel1.Controls.Add(this.fpGeneral);
            this.flowLayoutPanel1.Controls.Add(this.lblFile);
            this.flowLayoutPanel1.Controls.Add(this.fpFile);
            this.flowLayoutPanel1.Controls.Add(this.lblEdit);
            this.flowLayoutPanel1.Controls.Add(this.fpEdit);
            this.flowLayoutPanel1.Controls.Add(this.lblView);
            this.flowLayoutPanel1.Controls.Add(this.fpView);
            this.flowLayoutPanel1.Controls.Add(this.lblLabel);
            this.flowLayoutPanel1.Controls.Add(this.fpLabel);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(490, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 686);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblGeneral
            // 
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblGeneral.ForeColor = System.Drawing.Color.White;
            this.lblGeneral.Location = new System.Drawing.Point(3, 0);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(238, 23);
            this.lblGeneral.TabIndex = 2;
            this.lblGeneral.Text = "▶ General";
            this.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGeneral.Click += new System.EventHandler(this.lblGeneral_Click);
            this.lblGeneral.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblGeneral.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // fpGeneral
            // 
            this.fpGeneral.Controls.Add(this.btnPointer);
            this.fpGeneral.Controls.Add(this.btnPan);
            this.fpGeneral.Controls.Add(this.btnRuler);
            this.fpGeneral.Controls.Add(this.btnZoom);
            this.fpGeneral.Controls.Add(this.btnZoomOut);
            this.fpGeneral.Controls.Add(this.btnLock);
            this.fpGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpGeneral.Location = new System.Drawing.Point(3, 26);
            this.fpGeneral.Name = "fpGeneral";
            this.fpGeneral.Size = new System.Drawing.Size(306, 71);
            this.fpGeneral.TabIndex = 1;
            this.fpGeneral.Visible = false;
            // 
            // btnPointer
            // 
            this.btnPointer.BackColor = System.Drawing.Color.Black;
            this.btnPointer.FlatAppearance.BorderSize = 0;
            this.btnPointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointer.ForeColor = System.Drawing.Color.White;
            this.btnPointer.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnPointer.IconColor = System.Drawing.Color.White;
            this.btnPointer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPointer.IconSize = 20;
            this.btnPointer.Location = new System.Drawing.Point(3, 3);
            this.btnPointer.Name = "btnPointer";
            this.btnPointer.Size = new System.Drawing.Size(75, 23);
            this.btnPointer.TabIndex = 2;
            this.btnPointer.Text = "Pointer";
            this.btnPointer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPointer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPointer.UseVisualStyleBackColor = false;
            this.btnPointer.Click += new System.EventHandler(this.btnPointer_Click);
            this.btnPointer.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPointer.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPan
            // 
            this.btnPan.BackColor = System.Drawing.Color.Black;
            this.btnPan.FlatAppearance.BorderSize = 0;
            this.btnPan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPan.ForeColor = System.Drawing.Color.White;
            this.btnPan.IconChar = FontAwesome.Sharp.IconChar.Hand;
            this.btnPan.IconColor = System.Drawing.Color.White;
            this.btnPan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPan.IconSize = 20;
            this.btnPan.Location = new System.Drawing.Point(84, 3);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(75, 23);
            this.btnPan.TabIndex = 3;
            this.btnPan.Text = "Pan";
            this.btnPan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPan.UseVisualStyleBackColor = false;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            this.btnPan.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPan.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnRuler
            // 
            this.btnRuler.BackColor = System.Drawing.Color.Black;
            this.btnRuler.FlatAppearance.BorderSize = 0;
            this.btnRuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuler.ForeColor = System.Drawing.Color.White;
            this.btnRuler.IconChar = FontAwesome.Sharp.IconChar.Ruler;
            this.btnRuler.IconColor = System.Drawing.Color.White;
            this.btnRuler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRuler.IconSize = 20;
            this.btnRuler.Location = new System.Drawing.Point(165, 3);
            this.btnRuler.Name = "btnRuler";
            this.btnRuler.Size = new System.Drawing.Size(75, 23);
            this.btnRuler.TabIndex = 4;
            this.btnRuler.Text = "Ruler";
            this.btnRuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuler.UseVisualStyleBackColor = false;
            this.btnRuler.Click += new System.EventHandler(this.btnRuler_Click);
            this.btnRuler.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnRuler.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnZoom
            // 
            this.btnZoom.BackColor = System.Drawing.Color.Black;
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.ForeColor = System.Drawing.Color.White;
            this.btnZoom.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnZoom.IconColor = System.Drawing.Color.White;
            this.btnZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZoom.IconSize = 20;
            this.btnZoom.Location = new System.Drawing.Point(3, 32);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(75, 23);
            this.btnZoom.TabIndex = 7;
            this.btnZoom.Text = "ZoomIn";
            this.btnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZoom.UseVisualStyleBackColor = false;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            this.btnZoom.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnZoom.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.Black;
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.ForeColor = System.Drawing.Color.White;
            this.btnZoomOut.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnZoomOut.IconColor = System.Drawing.Color.White;
            this.btnZoomOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZoomOut.IconSize = 20;
            this.btnZoomOut.Location = new System.Drawing.Point(84, 32);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 9;
            this.btnZoomOut.Text = "Zoom";
            this.btnZoomOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            this.btnZoomOut.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnZoomOut.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Black;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnLock.IconColor = System.Drawing.Color.White;
            this.btnLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLock.IconSize = 20;
            this.btnLock.Location = new System.Drawing.Point(165, 32);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 8;
            this.btnLock.Text = "Lock";
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            this.btnLock.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnLock.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // lblFile
            // 
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(3, 100);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(238, 23);
            this.lblFile.TabIndex = 4;
            this.lblFile.Text = "▶ File";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFile.Click += new System.EventHandler(this.lblFile_Click);
            this.lblFile.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblFile.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // fpFile
            // 
            this.fpFile.Controls.Add(this.btnPrint);
            this.fpFile.Controls.Add(this.btnPreview);
            this.fpFile.Controls.Add(this.btnSave);
            this.fpFile.Controls.Add(this.btnSaveAs);
            this.fpFile.Controls.Add(this.btnFit);
            this.fpFile.Controls.Add(this.btnImport);
            this.fpFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpFile.Location = new System.Drawing.Point(3, 126);
            this.fpFile.Name = "fpFile";
            this.fpFile.Size = new System.Drawing.Size(306, 70);
            this.fpFile.TabIndex = 3;
            this.fpFile.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.White;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 20;
            this.btnPrint.Location = new System.Drawing.Point(3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Black;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.IconChar = FontAwesome.Sharp.IconChar.Prescription;
            this.btnPreview.IconColor = System.Drawing.Color.White;
            this.btnPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreview.IconSize = 20;
            this.btnPreview.Location = new System.Drawing.Point(84, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            this.btnPreview.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPreview.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 20;
            this.btnSave.Location = new System.Drawing.Point(165, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.Black;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveAs.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnSaveAs.IconColor = System.Drawing.Color.White;
            this.btnSaveAs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveAs.IconSize = 20;
            this.btnSaveAs.Location = new System.Drawing.Point(3, 32);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 11;
            this.btnSaveAs.Text = "SaveAs";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            this.btnSaveAs.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnSaveAs.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnFit
            // 
            this.btnFit.BackColor = System.Drawing.Color.Black;
            this.btnFit.FlatAppearance.BorderSize = 0;
            this.btnFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFit.ForeColor = System.Drawing.Color.White;
            this.btnFit.IconChar = FontAwesome.Sharp.IconChar.TachographDigital;
            this.btnFit.IconColor = System.Drawing.Color.White;
            this.btnFit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFit.IconSize = 20;
            this.btnFit.Location = new System.Drawing.Point(84, 32);
            this.btnFit.Name = "btnFit";
            this.btnFit.Size = new System.Drawing.Size(75, 23);
            this.btnFit.TabIndex = 13;
            this.btnFit.Text = "Fit";
            this.btnFit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFit.UseVisualStyleBackColor = false;
            this.btnFit.Click += new System.EventHandler(this.btnFit_Click);
            this.btnFit.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnFit.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Black;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.IconChar = FontAwesome.Sharp.IconChar.Instalod;
            this.btnImport.IconColor = System.Drawing.Color.White;
            this.btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImport.IconSize = 20;
            this.btnImport.Location = new System.Drawing.Point(165, 32);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            this.btnImport.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnImport.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // lblEdit
            // 
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(3, 199);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(238, 23);
            this.lblEdit.TabIndex = 6;
            this.lblEdit.Text = "▶ Edit";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            this.lblEdit.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblEdit.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // fpEdit
            // 
            this.fpEdit.Controls.Add(this.btnRotate);
            this.fpEdit.Controls.Add(this.btnCopy);
            this.fpEdit.Controls.Add(this.btnPaste);
            this.fpEdit.Controls.Add(this.btnDelete);
            this.fpEdit.Controls.Add(this.btnRedo);
            this.fpEdit.Controls.Add(this.btnUndo);
            this.fpEdit.Controls.Add(this.btnFlip);
            this.fpEdit.Controls.Add(this.btnReset);
            this.fpEdit.Controls.Add(this.btnUngroup);
            this.fpEdit.Controls.Add(this.btnColor);
            this.fpEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpEdit.Location = new System.Drawing.Point(3, 225);
            this.fpEdit.Name = "fpEdit";
            this.fpEdit.Size = new System.Drawing.Size(306, 121);
            this.fpEdit.TabIndex = 5;
            this.fpEdit.Visible = false;
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.Black;
            this.btnRotate.FlatAppearance.BorderSize = 0;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.ForeColor = System.Drawing.Color.White;
            this.btnRotate.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRotate.IconColor = System.Drawing.Color.White;
            this.btnRotate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRotate.IconSize = 20;
            this.btnRotate.Location = new System.Drawing.Point(3, 3);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(81, 23);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRotate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            this.btnRotate.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnRotate.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Black;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnCopy.IconColor = System.Drawing.Color.White;
            this.btnCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopy.IconSize = 20;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(90, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnCopy.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.Black;
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.btnPaste.IconColor = System.Drawing.Color.White;
            this.btnPaste.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaste.IconSize = 20;
            this.btnPaste.Location = new System.Drawing.Point(171, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Paste";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            this.btnPaste.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPaste.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 20;
            this.btnDelete.Location = new System.Drawing.Point(3, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Black;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnRedo.IconColor = System.Drawing.Color.White;
            this.btnRedo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRedo.IconSize = 20;
            this.btnRedo.Location = new System.Drawing.Point(84, 32);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 5;
            this.btnRedo.Text = "Redo";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            this.btnRedo.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnRedo.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Black;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnUndo.IconColor = System.Drawing.Color.White;
            this.btnUndo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUndo.IconSize = 20;
            this.btnUndo.Location = new System.Drawing.Point(165, 32);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            this.btnUndo.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnUndo.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnFlip
            // 
            this.btnFlip.BackColor = System.Drawing.Color.Black;
            this.btnFlip.FlatAppearance.BorderSize = 0;
            this.btnFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlip.ForeColor = System.Drawing.Color.White;
            this.btnFlip.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnFlip.IconColor = System.Drawing.Color.White;
            this.btnFlip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFlip.IconSize = 20;
            this.btnFlip.Location = new System.Drawing.Point(3, 61);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 23);
            this.btnFlip.TabIndex = 7;
            this.btnFlip.Text = "Flip";
            this.btnFlip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFlip.UseVisualStyleBackColor = false;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            this.btnFlip.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnFlip.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnReset.IconColor = System.Drawing.Color.White;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 20;
            this.btnReset.Location = new System.Drawing.Point(84, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnUngroup
            // 
            this.btnUngroup.BackColor = System.Drawing.Color.Black;
            this.btnUngroup.FlatAppearance.BorderSize = 0;
            this.btnUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUngroup.ForeColor = System.Drawing.Color.White;
            this.btnUngroup.IconChar = FontAwesome.Sharp.IconChar.GroupArrowsRotate;
            this.btnUngroup.IconColor = System.Drawing.Color.White;
            this.btnUngroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUngroup.IconSize = 20;
            this.btnUngroup.Location = new System.Drawing.Point(165, 61);
            this.btnUngroup.Name = "btnUngroup";
            this.btnUngroup.Size = new System.Drawing.Size(75, 23);
            this.btnUngroup.TabIndex = 9;
            this.btnUngroup.Text = "Ugp";
            this.btnUngroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUngroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUngroup.UseVisualStyleBackColor = false;
            this.btnUngroup.Click += new System.EventHandler(this.btnUngroup_Click);
            this.btnUngroup.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnUngroup.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.IconChar = FontAwesome.Sharp.IconChar.Fill;
            this.btnColor.IconColor = System.Drawing.Color.White;
            this.btnColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColor.IconSize = 20;
            this.btnColor.Location = new System.Drawing.Point(3, 90);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 10;
            this.btnColor.Text = "Fill";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // lblView
            // 
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblView.ForeColor = System.Drawing.Color.White;
            this.lblView.Location = new System.Drawing.Point(3, 349);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(238, 23);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "▶ View";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblView.Click += new System.EventHandler(this.lblView_Click);
            this.lblView.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblView.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // fpView
            // 
            this.fpView.Controls.Add(this.panel1);
            this.fpView.Controls.Add(this.panel2);
            this.fpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpView.Location = new System.Drawing.Point(3, 375);
            this.fpView.Name = "fpView";
            this.fpView.Size = new System.Drawing.Size(306, 81);
            this.fpView.TabIndex = 7;
            this.fpView.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkCom_Side);
            this.panel1.Controls.Add(this.chkCom_Top);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 35);
            this.panel1.TabIndex = 12;
            // 
            // chkCom_Side
            // 
            this.chkCom_Side.AccessibilityEnabled = true;
            this.chkCom_Side.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.chkCom_Side.Checked = true;
            this.chkCom_Side.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCom_Side.ForeColor = System.Drawing.Color.White;
            this.chkCom_Side.Location = new System.Drawing.Point(219, 7);
            this.chkCom_Side.Name = "chkCom_Side";
            this.chkCom_Side.Size = new System.Drawing.Size(70, 21);
            this.chkCom_Side.TabIndex = 11;
            this.chkCom_Side.Text = "Side";
            this.chkCom_Side.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // chkCom_Top
            // 
            this.chkCom_Top.AccessibilityEnabled = true;
            this.chkCom_Top.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.chkCom_Top.Checked = true;
            this.chkCom_Top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCom_Top.ForeColor = System.Drawing.Color.White;
            this.chkCom_Top.Location = new System.Drawing.Point(121, 7);
            this.chkCom_Top.Name = "chkCom_Top";
            this.chkCom_Top.Size = new System.Drawing.Size(70, 21);
            this.chkCom_Top.TabIndex = 10;
            this.chkCom_Top.Text = "Top";
            this.chkCom_Top.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Compartment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkHull_Side);
            this.panel2.Controls.Add(this.chkHull_Top);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 27);
            this.panel2.TabIndex = 13;
            // 
            // chkHull_Side
            // 
            this.chkHull_Side.AccessibilityEnabled = true;
            this.chkHull_Side.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.chkHull_Side.Checked = true;
            this.chkHull_Side.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHull_Side.ForeColor = System.Drawing.Color.White;
            this.chkHull_Side.Location = new System.Drawing.Point(219, -2);
            this.chkHull_Side.Name = "chkHull_Side";
            this.chkHull_Side.Size = new System.Drawing.Size(70, 21);
            this.chkHull_Side.TabIndex = 11;
            this.chkHull_Side.Text = "Side";
            this.chkHull_Side.CheckStateChanged += new System.EventHandler(this.chkHull_Side_CheckStateChanged);
            // 
            // chkHull_Top
            // 
            this.chkHull_Top.AccessibilityEnabled = true;
            this.chkHull_Top.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.chkHull_Top.Checked = true;
            this.chkHull_Top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHull_Top.ForeColor = System.Drawing.Color.White;
            this.chkHull_Top.Location = new System.Drawing.Point(121, -1);
            this.chkHull_Top.Name = "chkHull_Top";
            this.chkHull_Top.Size = new System.Drawing.Size(70, 21);
            this.chkHull_Top.TabIndex = 10;
            this.chkHull_Top.Text = "Top";
            this.chkHull_Top.CheckStateChanged += new System.EventHandler(this.chkHull_Top_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hull";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabel
            // 
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(3, 459);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(238, 23);
            this.lblLabel.TabIndex = 10;
            this.lblLabel.Text = "▶ Label";
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            this.lblLabel.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblLabel.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // fpLabel
            // 
            this.fpLabel.Controls.Add(this.btnPolyline);
            this.fpLabel.Controls.Add(this.btnOrthoLabel);
            this.fpLabel.Controls.Add(this.btnDirectedLabel);
            this.fpLabel.Location = new System.Drawing.Point(3, 485);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(306, 34);
            this.fpLabel.TabIndex = 9;
            this.fpLabel.Visible = false;
            // 
            // btnPolyline
            // 
            this.btnPolyline.BackColor = System.Drawing.Color.Black;
            this.btnPolyline.FlatAppearance.BorderSize = 0;
            this.btnPolyline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolyline.ForeColor = System.Drawing.Color.White;
            this.btnPolyline.IconChar = FontAwesome.Sharp.IconChar.Line;
            this.btnPolyline.IconColor = System.Drawing.Color.White;
            this.btnPolyline.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPolyline.IconSize = 20;
            this.btnPolyline.Location = new System.Drawing.Point(3, 3);
            this.btnPolyline.Name = "btnPolyline";
            this.btnPolyline.Size = new System.Drawing.Size(75, 23);
            this.btnPolyline.TabIndex = 0;
            this.btnPolyline.Text = "Poly";
            this.btnPolyline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolyline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPolyline.UseVisualStyleBackColor = false;
            this.btnPolyline.Click += new System.EventHandler(this.btnPolyline_Click);
            this.btnPolyline.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPolyline.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnOrthoLabel
            // 
            this.btnOrthoLabel.BackColor = System.Drawing.Color.Black;
            this.btnOrthoLabel.FlatAppearance.BorderSize = 0;
            this.btnOrthoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrthoLabel.ForeColor = System.Drawing.Color.White;
            this.btnOrthoLabel.IconChar = FontAwesome.Sharp.IconChar.ArrowDownZA;
            this.btnOrthoLabel.IconColor = System.Drawing.Color.White;
            this.btnOrthoLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrthoLabel.IconSize = 20;
            this.btnOrthoLabel.Location = new System.Drawing.Point(84, 3);
            this.btnOrthoLabel.Name = "btnOrthoLabel";
            this.btnOrthoLabel.Size = new System.Drawing.Size(75, 23);
            this.btnOrthoLabel.TabIndex = 1;
            this.btnOrthoLabel.Text = "Ortho";
            this.btnOrthoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrthoLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrthoLabel.UseVisualStyleBackColor = false;
            this.btnOrthoLabel.Click += new System.EventHandler(this.btnOrthoLabel_Click);
            this.btnOrthoLabel.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnOrthoLabel.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnDirectedLabel
            // 
            this.btnDirectedLabel.BackColor = System.Drawing.Color.Black;
            this.btnDirectedLabel.FlatAppearance.BorderSize = 0;
            this.btnDirectedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectedLabel.ForeColor = System.Drawing.Color.White;
            this.btnDirectedLabel.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnDirectedLabel.IconColor = System.Drawing.Color.White;
            this.btnDirectedLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDirectedLabel.IconSize = 20;
            this.btnDirectedLabel.Location = new System.Drawing.Point(165, 3);
            this.btnDirectedLabel.Name = "btnDirectedLabel";
            this.btnDirectedLabel.Size = new System.Drawing.Size(75, 23);
            this.btnDirectedLabel.TabIndex = 2;
            this.btnDirectedLabel.Text = "Directed";
            this.btnDirectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectedLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectedLabel.UseVisualStyleBackColor = false;
            this.btnDirectedLabel.Click += new System.EventHandler(this.btnDirectedLabel_Click);
            this.btnDirectedLabel.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnDirectedLabel.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 10);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.45055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.54945F));
            this.tableLayoutPanel1.Controls.Add(this.diagram1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 692);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Visualizer";
            this.Load += new System.EventHandler(this.Visualizer_Load);
            this.Resize += new System.EventHandler(this.Visualizer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.fpGeneral.ResumeLayout(false);
            this.fpFile.ResumeLayout(false);
            this.fpEdit.ResumeLayout(false);
            this.fpView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkCom_Side)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCom_Top)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkHull_Side)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHull_Top)).EndInit();
            this.fpLabel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel fpGeneral;
        private System.Windows.Forms.FlowLayoutPanel fpFile;
        private System.Windows.Forms.FlowLayoutPanel fpEdit;
        private System.Windows.Forms.FlowLayoutPanel fpView;
        private System.Windows.Forms.FlowLayoutPanel fpLabel;
        private FontAwesome.Sharp.IconButton btnPolyline;
        private FontAwesome.Sharp.IconButton btnOrthoLabel;
        private FontAwesome.Sharp.IconButton btnDirectedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkCom_Side;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkCom_Top;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkHull_Side;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkHull_Top;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnRotate;
        private FontAwesome.Sharp.IconButton btnCopy;
        private FontAwesome.Sharp.IconButton btnPaste;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnRedo;
        private FontAwesome.Sharp.IconButton btnUndo;
        private FontAwesome.Sharp.IconButton btnZoom;
        private FontAwesome.Sharp.IconButton btnPointer;
        private FontAwesome.Sharp.IconButton btnPan;
        private FontAwesome.Sharp.IconButton btnRuler;
        private FontAwesome.Sharp.IconButton btnPrint;
        private FontAwesome.Sharp.IconButton btnPreview;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSaveAs;
        private FontAwesome.Sharp.IconButton btnImport;
        private FontAwesome.Sharp.IconButton btnFlip;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnLock;
        private FontAwesome.Sharp.IconButton btnUngroup;
        private FontAwesome.Sharp.IconButton btnZoomOut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FontAwesome.Sharp.IconButton btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private FontAwesome.Sharp.IconButton btnFit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
    }
}