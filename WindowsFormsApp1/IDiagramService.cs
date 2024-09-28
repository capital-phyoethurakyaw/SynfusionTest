using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{ 
        public interface  IDiagramService
        {
            string PromptSaveFile(string fileNameSave);
            void SaveFile(string fileName);
            //PrintDocument CreatePrintDocument();
            //bool PromptPrint(PrintDocument printDoc);
            void Print(PrintDocument printDoc);
            void RotateSelectedNodes(float angle);
            void FitDocument();
            void Copy();
            void Paste();
            void DeleteSelectedNodes();
            void ZoomIn();
            void ZoomOut();
            void Undo();
            void Redo();
        } 
}
