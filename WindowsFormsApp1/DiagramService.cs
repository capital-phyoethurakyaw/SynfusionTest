using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Diagram;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DiagramService : IDiagramService
    {
        private readonly Diagram _diagram;

        public DiagramService(Diagram diagram)
        {
            _diagram = diagram;
        }

        public string PromptSaveFile(string fileNameSave)
        {
            // Logic for prompting the user to save file (UI-related)
            return "fileName.edd";
        }

        public void SaveFile(string fileName)
        {
            _diagram.SaveBinary(fileName);  // Example method for saving the file
        }

        public PrintDocument CreatePrintDocument()
        {
            return _diagram.CreatePrintDocument();
        }

        public bool PromptPrint(PrintDocument printDoc)
        {
            // Show print dialog and return true if user confirmed
            return true;
        }

        public void Print(PrintDocument printDoc)
        {
            printDoc.Print();
        }

        public void RotateSelectedNodes(float angle)
        {
            foreach (var connector in _diagram.Controller.SelectionList)
            {
                if (connector is Node node)
                {
                    node.RotationAngle += angle;
                }
            }
        }

        public void FitDocument()
        {
            _diagram.FitDocument();
        }

        public void Copy()
        {
            _diagram.Controller.Copy();
        }

        public void Paste()
        {
            _diagram.Controller.Paste();
        }

        public void DeleteSelectedNodes()
        {
            var selectedNodes = _diagram.Controller.SelectionList;
            foreach (Node node in selectedNodes)
            {
                _diagram.Model.RemoveChild(node);
            }
        }

        public void ZoomIn()
        {
            _diagram.View.ZoomIn();
        }

        public void ZoomOut()
        {
            _diagram.View.ZoomOut();
        }

        public void Undo()
        {
            _diagram.Model.HistoryManager.Undo();
        }

        public void Redo()
        {
            _diagram.Model.HistoryManager.Redo();
        }
    }

}
