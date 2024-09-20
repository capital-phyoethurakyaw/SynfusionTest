﻿namespace SynfusionTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.diagram1 = new Syncfusion.Windows.Forms.Diagram.Controls.Diagram(this.components);
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fpView = new System.Windows.Forms.FlowLayoutPanel();
            this.fpEdit = new System.Windows.Forms.FlowLayoutPanel();
            this.fpFile = new System.Windows.Forms.FlowLayoutPanel();
            this.fpGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.fpLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPolyline = new FontAwesome.Sharp.IconButton();
            this.btnOrthoLabel = new FontAwesome.Sharp.IconButton();
            this.btnDirectedLabel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRotate = new FontAwesome.Sharp.IconButton();
            this.btnCopy = new FontAwesome.Sharp.IconButton();
            this.btnPaste = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnRedo = new FontAwesome.Sharp.IconButton();
            this.btnUndo = new FontAwesome.Sharp.IconButton();
            this.btnZoom = new FontAwesome.Sharp.IconButton();
            this.btnPointer = new FontAwesome.Sharp.IconButton();
            this.btnPan = new FontAwesome.Sharp.IconButton();
            this.btnRuler = new FontAwesome.Sharp.IconButton();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.btnPreview = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSaveAs = new FontAwesome.Sharp.IconButton();
            this.btnImport = new FontAwesome.Sharp.IconButton();
            this.btnFlip = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnLock = new FontAwesome.Sharp.IconButton();
            this.btnUngroup = new FontAwesome.Sharp.IconButton();
            this.btnZoomFit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.fpView.SuspendLayout();
            this.fpEdit.SuspendLayout();
            this.fpFile.SuspendLayout();
            this.fpGeneral.SuspendLayout();
            this.fpLabel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.diagram1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1214, 731);
            this.splitContainer1.SplitterDistance = 778;
            this.splitContainer1.TabIndex = 0;
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
            this.diagram1.Location = new System.Drawing.Point(0, 0);
            this.diagram1.Model = this.model1;
            this.diagram1.Name = "diagram1";
            this.diagram1.ScrollVirtualBounds = ((System.Drawing.RectangleF)(resources.GetObject("diagram1.ScrollVirtualBounds")));
            this.diagram1.Size = new System.Drawing.Size(778, 731);
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
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 827F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
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
            // lblFile
            // 
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(3, 133);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(238, 23);
            this.lblFile.TabIndex = 4;
            this.lblFile.Text = "▶ File";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFile.Click += new System.EventHandler(this.lblFile_Click);
            this.lblFile.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblFile.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // lblEdit
            // 
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(3, 266);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(238, 23);
            this.lblEdit.TabIndex = 6;
            this.lblEdit.Text = "▶ Edit";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            this.lblEdit.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblEdit.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // lblView
            // 
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblView.ForeColor = System.Drawing.Color.White;
            this.lblView.Location = new System.Drawing.Point(3, 399);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(238, 23);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "▶ View";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblView.Click += new System.EventHandler(this.lblView_Click);
            this.lblView.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblView.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // lblLabel
            // 
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblLabel.ForeColor = System.Drawing.Color.White;
            this.lblLabel.Location = new System.Drawing.Point(3, 555);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(238, 23);
            this.lblLabel.TabIndex = 10;
            this.lblLabel.Text = "▶ Label";
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            this.lblLabel.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.lblLabel.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 731);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fpView
            // 
            this.fpView.Controls.Add(this.panel1);
            this.fpView.Controls.Add(this.label2);
            this.fpView.Controls.Add(this.panel2);
            this.fpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpView.Location = new System.Drawing.Point(3, 425);
            this.fpView.Name = "fpView";
            this.fpView.Size = new System.Drawing.Size(306, 127);
            this.fpView.TabIndex = 7;
            this.fpView.Visible = false;
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
            this.fpEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpEdit.Location = new System.Drawing.Point(3, 292);
            this.fpEdit.Name = "fpEdit";
            this.fpEdit.Size = new System.Drawing.Size(306, 104);
            this.fpEdit.TabIndex = 5;
            this.fpEdit.Visible = false;
            // 
            // fpFile
            // 
            this.fpFile.Controls.Add(this.btnPrint);
            this.fpFile.Controls.Add(this.btnPreview);
            this.fpFile.Controls.Add(this.btnSave);
            this.fpFile.Controls.Add(this.btnSaveAs);
            this.fpFile.Controls.Add(this.btnImport);
            this.fpFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpFile.Location = new System.Drawing.Point(3, 159);
            this.fpFile.Name = "fpFile";
            this.fpFile.Size = new System.Drawing.Size(306, 104);
            this.fpFile.TabIndex = 3;
            this.fpFile.Visible = false;
            // 
            // fpGeneral
            // 
            this.fpGeneral.Controls.Add(this.btnPointer);
            this.fpGeneral.Controls.Add(this.btnPan);
            this.fpGeneral.Controls.Add(this.btnRuler);
            this.fpGeneral.Controls.Add(this.btnZoom);
            this.fpGeneral.Controls.Add(this.btnZoomFit);
            this.fpGeneral.Controls.Add(this.btnLock);
            this.fpGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpGeneral.Location = new System.Drawing.Point(3, 26);
            this.fpGeneral.Name = "fpGeneral";
            this.fpGeneral.Size = new System.Drawing.Size(306, 104);
            this.fpGeneral.TabIndex = 1;
            this.fpGeneral.Visible = false;
            // 
            // fpLabel
            // 
            this.fpLabel.Controls.Add(this.btnPolyline);
            this.fpLabel.Controls.Add(this.btnOrthoLabel);
            this.fpLabel.Controls.Add(this.btnDirectedLabel);
            this.fpLabel.Location = new System.Drawing.Point(3, 581);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(306, 67);
            this.fpLabel.TabIndex = 9;
            this.fpLabel.Visible = false;
            // 
            // btnPolyline
            // 
            this.btnPolyline.BackColor = System.Drawing.Color.Black;
            this.btnPolyline.FlatAppearance.BorderSize = 0;
            this.btnPolyline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolyline.ForeColor = System.Drawing.Color.White;
            this.btnPolyline.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPolyline.IconColor = System.Drawing.Color.Black;
            this.btnPolyline.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPolyline.Location = new System.Drawing.Point(3, 3);
            this.btnPolyline.Name = "btnPolyline";
            this.btnPolyline.Size = new System.Drawing.Size(75, 23);
            this.btnPolyline.TabIndex = 0;
            this.btnPolyline.Text = "PolyLabel";
            this.btnPolyline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolyline.UseVisualStyleBackColor = false;
            this.btnPolyline.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPolyline.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnOrthoLabel
            // 
            this.btnOrthoLabel.BackColor = System.Drawing.Color.Black;
            this.btnOrthoLabel.FlatAppearance.BorderSize = 0;
            this.btnOrthoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrthoLabel.ForeColor = System.Drawing.Color.White;
            this.btnOrthoLabel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOrthoLabel.IconColor = System.Drawing.Color.Black;
            this.btnOrthoLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrthoLabel.Location = new System.Drawing.Point(84, 3);
            this.btnOrthoLabel.Name = "btnOrthoLabel";
            this.btnOrthoLabel.Size = new System.Drawing.Size(75, 23);
            this.btnOrthoLabel.TabIndex = 1;
            this.btnOrthoLabel.Text = "OrthoLabel";
            this.btnOrthoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrthoLabel.UseVisualStyleBackColor = false;
            this.btnOrthoLabel.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnOrthoLabel.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnDirectedLabel
            // 
            this.btnDirectedLabel.BackColor = System.Drawing.Color.Black;
            this.btnDirectedLabel.FlatAppearance.BorderSize = 0;
            this.btnDirectedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectedLabel.ForeColor = System.Drawing.Color.White;
            this.btnDirectedLabel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDirectedLabel.IconColor = System.Drawing.Color.Black;
            this.btnDirectedLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDirectedLabel.Location = new System.Drawing.Point(165, 3);
            this.btnDirectedLabel.Name = "btnDirectedLabel";
            this.btnDirectedLabel.Size = new System.Drawing.Size(75, 23);
            this.btnDirectedLabel.TabIndex = 2;
            this.btnDirectedLabel.Text = "DirectedLabel";
            this.btnDirectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectedLabel.UseVisualStyleBackColor = false;
            this.btnDirectedLabel.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnDirectedLabel.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Compartment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 20);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxAdv2);
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 46);
            this.panel1.TabIndex = 12;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.AccessibilityEnabled = true;
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdv1.Location = new System.Drawing.Point(121, 12);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(70, 21);
            this.checkBoxAdv1.TabIndex = 10;
            this.checkBoxAdv1.Text = "Top";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.AccessibilityEnabled = true;
            this.checkBoxAdv2.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.checkBoxAdv2.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdv2.Location = new System.Drawing.Point(219, 12);
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(70, 21);
            this.checkBoxAdv2.TabIndex = 11;
            this.checkBoxAdv2.Text = "Side";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxAdv3);
            this.panel2.Controls.Add(this.checkBoxAdv4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 46);
            this.panel2.TabIndex = 13;
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.AccessibilityEnabled = true;
            this.checkBoxAdv3.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.checkBoxAdv3.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdv3.Location = new System.Drawing.Point(219, 12);
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(70, 21);
            this.checkBoxAdv3.TabIndex = 11;
            this.checkBoxAdv3.Text = "Side";
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.AccessibilityEnabled = true;
            this.checkBoxAdv4.BeforeTouchSize = new System.Drawing.Size(70, 21);
            this.checkBoxAdv4.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdv4.Location = new System.Drawing.Point(121, 12);
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(70, 21);
            this.checkBoxAdv4.TabIndex = 10;
            this.checkBoxAdv4.Text = "Top";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "HULL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.Black;
            this.btnRotate.FlatAppearance.BorderSize = 0;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.ForeColor = System.Drawing.Color.White;
            this.btnRotate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRotate.IconColor = System.Drawing.Color.Black;
            this.btnRotate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRotate.Location = new System.Drawing.Point(3, 3);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnRotate.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Black;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCopy.IconColor = System.Drawing.Color.Black;
            this.btnCopy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopy.Location = new System.Drawing.Point(84, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnCopy.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.Black;
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPaste.IconColor = System.Drawing.Color.Black;
            this.btnPaste.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaste.Location = new System.Drawing.Point(165, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Paste";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPaste.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(3, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.Black;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRedo.IconColor = System.Drawing.Color.Black;
            this.btnRedo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRedo.Location = new System.Drawing.Point(84, 32);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 5;
            this.btnRedo.Text = "Redo";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnRedo.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Black;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUndo.IconColor = System.Drawing.Color.Black;
            this.btnUndo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUndo.Location = new System.Drawing.Point(165, 32);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnUndo.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnZoom
            // 
            this.btnZoom.BackColor = System.Drawing.Color.Black;
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.ForeColor = System.Drawing.Color.White;
            this.btnZoom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnZoom.IconColor = System.Drawing.Color.Black;
            this.btnZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZoom.Location = new System.Drawing.Point(3, 32);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(75, 23);
            this.btnZoom.TabIndex = 7;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoom.UseVisualStyleBackColor = false;
            this.btnZoom.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnZoom.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPointer
            // 
            this.btnPointer.BackColor = System.Drawing.Color.Black;
            this.btnPointer.FlatAppearance.BorderSize = 0;
            this.btnPointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointer.ForeColor = System.Drawing.Color.White;
            this.btnPointer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPointer.IconColor = System.Drawing.Color.Black;
            this.btnPointer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPointer.Location = new System.Drawing.Point(3, 3);
            this.btnPointer.Name = "btnPointer";
            this.btnPointer.Size = new System.Drawing.Size(75, 23);
            this.btnPointer.TabIndex = 2;
            this.btnPointer.Text = "Pointer";
            this.btnPointer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPointer.UseVisualStyleBackColor = false;
            this.btnPointer.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPointer.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPan
            // 
            this.btnPan.BackColor = System.Drawing.Color.Black;
            this.btnPan.FlatAppearance.BorderSize = 0;
            this.btnPan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPan.ForeColor = System.Drawing.Color.White;
            this.btnPan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPan.IconColor = System.Drawing.Color.Black;
            this.btnPan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPan.Location = new System.Drawing.Point(84, 3);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(75, 23);
            this.btnPan.TabIndex = 3;
            this.btnPan.Text = "Pan";
            this.btnPan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPan.UseVisualStyleBackColor = false;
            this.btnPan.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPan.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnRuler
            // 
            this.btnRuler.BackColor = System.Drawing.Color.Black;
            this.btnRuler.FlatAppearance.BorderSize = 0;
            this.btnRuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuler.ForeColor = System.Drawing.Color.White;
            this.btnRuler.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRuler.IconColor = System.Drawing.Color.Black;
            this.btnRuler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRuler.Location = new System.Drawing.Point(165, 3);
            this.btnRuler.Name = "btnRuler";
            this.btnRuler.Size = new System.Drawing.Size(75, 23);
            this.btnRuler.TabIndex = 4;
            this.btnRuler.Text = "Ruler";
            this.btnRuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuler.UseVisualStyleBackColor = false;
            this.btnRuler.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnRuler.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrint.IconColor = System.Drawing.Color.Black;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.Location = new System.Drawing.Point(3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Black;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPreview.IconColor = System.Drawing.Color.Black;
            this.btnPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreview.Location = new System.Drawing.Point(84, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnPreview.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(165, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.Black;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.ForeColor = System.Drawing.Color.White;
            this.btnSaveAs.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSaveAs.IconColor = System.Drawing.Color.Black;
            this.btnSaveAs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveAs.Location = new System.Drawing.Point(3, 32);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 11;
            this.btnSaveAs.Text = "SaveAs";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnSaveAs.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Black;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImport.IconColor = System.Drawing.Color.Black;
            this.btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImport.Location = new System.Drawing.Point(84, 32);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnImport.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnFlip
            // 
            this.btnFlip.BackColor = System.Drawing.Color.Black;
            this.btnFlip.FlatAppearance.BorderSize = 0;
            this.btnFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlip.ForeColor = System.Drawing.Color.White;
            this.btnFlip.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFlip.IconColor = System.Drawing.Color.Black;
            this.btnFlip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFlip.Location = new System.Drawing.Point(3, 61);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 23);
            this.btnFlip.TabIndex = 7;
            this.btnFlip.Text = "Flip";
            this.btnFlip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlip.UseVisualStyleBackColor = false;
            this.btnFlip.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnFlip.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReset.IconColor = System.Drawing.Color.Black;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(84, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Black;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLock.IconColor = System.Drawing.Color.Black;
            this.btnLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLock.Location = new System.Drawing.Point(165, 32);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 8;
            this.btnLock.Text = "Lock";
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnLock.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnUngroup
            // 
            this.btnUngroup.BackColor = System.Drawing.Color.Black;
            this.btnUngroup.FlatAppearance.BorderSize = 0;
            this.btnUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUngroup.ForeColor = System.Drawing.Color.White;
            this.btnUngroup.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUngroup.IconColor = System.Drawing.Color.Black;
            this.btnUngroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUngroup.Location = new System.Drawing.Point(165, 61);
            this.btnUngroup.Name = "btnUngroup";
            this.btnUngroup.Size = new System.Drawing.Size(75, 23);
            this.btnUngroup.TabIndex = 9;
            this.btnUngroup.Text = "Ungroup";
            this.btnUngroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUngroup.UseVisualStyleBackColor = false;
            this.btnUngroup.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnUngroup.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // btnZoomFit
            // 
            this.btnZoomFit.BackColor = System.Drawing.Color.Black;
            this.btnZoomFit.FlatAppearance.BorderSize = 0;
            this.btnZoomFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomFit.ForeColor = System.Drawing.Color.White;
            this.btnZoomFit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnZoomFit.IconColor = System.Drawing.Color.Black;
            this.btnZoomFit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZoomFit.Location = new System.Drawing.Point(84, 32);
            this.btnZoomFit.Name = "btnZoomFit";
            this.btnZoomFit.Size = new System.Drawing.Size(75, 23);
            this.btnZoomFit.TabIndex = 9;
            this.btnZoomFit.Text = "ZoomFit";
            this.btnZoomFit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomFit.UseVisualStyleBackColor = false;
            this.btnZoomFit.MouseEnter += new System.EventHandler(this.btnDirectedLabel_MouseEnter);
            this.btnZoomFit.MouseLeave += new System.EventHandler(this.btnDirectedLabel_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 731);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.fpView.ResumeLayout(false);
            this.fpEdit.ResumeLayout(false);
            this.fpFile.ResumeLayout(false);
            this.fpGeneral.ResumeLayout(false);
            this.fpLabel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Diagram.Controls.Diagram diagram1;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
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
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv4;
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
        private FontAwesome.Sharp.IconButton btnZoomFit;
    }
}