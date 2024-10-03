namespace SynfusionTest
{
    partial class Form2
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
            this.tileLayout1 = new Syncfusion.Windows.Forms.Tools.TileLayout();
            this.borderLayout1 = new Syncfusion.Windows.Forms.Tools.BorderLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1.MainLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileLayout1
            // 
            this.tileLayout1.AllowNewGroup = false;
            this.tileLayout1.AutoScroll = true;
            this.tileLayout1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tileLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLayout1.ExitButtonImage = null;
            this.tileLayout1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLayout1.Items = 0;
            this.tileLayout1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.tileLayout1.MainLayout.ContainerControl = this.tileLayout1;
            this.tileLayout1.MainLayout.HGap = 75;
            this.tileLayout1.MainLayout.HorzNearMargin = 100;
            this.tileLayout1.MainLayout.TopMargin = 100;
            this.tileLayout1.MainLayout.VGap = 75;
            this.tileLayout1.Name = "tileLayout1";
            this.tileLayout1.NewGroupButtonImage = null;
            this.tileLayout1.NewGroupIndicatorColor = System.Drawing.Color.Black;
            this.tileLayout1.SetParentFormFlat = false;
            this.tileLayout1.ShowGroupTitle = false;
            this.tileLayout1.ShowItemPreview = false;
            this.tileLayout1.ShowPreviewButtonImage = null;
            this.tileLayout1.Size = new System.Drawing.Size(800, 450);
            this.tileLayout1.TabIndex = 0;
            this.tileLayout1.TextAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.tileLayout1.TitleFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLayout1.Transparency = 10;
            // 
            // borderLayout1
            // 
            this.borderLayout1.ContainerControl = this;
            this.borderLayout1.HGap = 0;
            this.borderLayout1.VGap = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tileLayout1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1.MainLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLayout1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TileLayout tileLayout1;
        private Syncfusion.Windows.Forms.Tools.BorderLayout borderLayout1;
    }
}