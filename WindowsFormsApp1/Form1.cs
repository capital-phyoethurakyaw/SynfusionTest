using Syncfusion.Windows.Forms.Diagram.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly DiagramController _diagramController;
        private readonly DiagramService _diagramService; // Real service for actual diagram actions

        public Form1()
        {
            InitializeComponent();

            // Initialize the diagram service with the actual diagram object
            var diagram = diagram1;  // Assuming Diagram is part of your existing UI
            _diagramService = new DiagramService(diagram);

            // Inject the diagram service into the controller
            _diagramController = new DiagramController(_diagramService);

        }

        // Example of using the controller for Save operation
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming a promptOnSave flag and fileNameSave are handled elsewhere
            bool promptOnSave = true;
            string fileNameSave = "defaultfile.edd";

            _diagramController.SaveDiagram(promptOnSave, fileNameSave);
        }

        // Example for Print operation
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.PrintDiagram();
        }

        // Rotate nodes example
        private void RotateRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.RotateNodes(90f);  // Rotate 90 degrees to the right
        }

        // Zoom In operation
        private void ZoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.ZoomIn();
        }

        // Zoom Out operation
        private void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.ZoomOut();
        }

        // Copy operation
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.CopyNodes();
        }

        // Paste operation
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.PasteNodes();
        }

        // Delete operation
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.DeleteNodes();
        }

        // Undo operation
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.UndoAction();
        }

        // Redo operation
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.RedoAction();
        }

        // Fit to document
        private void FitToDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _diagramController.FitDiagramToDocument();
        }
    }
}
