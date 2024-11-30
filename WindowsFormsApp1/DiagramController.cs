using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DiagramController
    {
        private readonly IDiagramService _diagramService;

        public DiagramController(IDiagramService diagramService)
        {
            _diagramService = diagramService;
        }

        public void SaveDiagram(bool promptOnSave, string fileNameSave)
        {
            if (promptOnSave)
            {
                fileNameSave = _diagramService.PromptSaveFile(fileNameSave);
            }

            if (!string.IsNullOrEmpty(fileNameSave))
            {
                _diagramService.SaveFile(fileNameSave);
            }
        }

        public void PrintDiagram()
        {
            //var printDoc = _diagramService.CreatePrintDocument();
            //if (_diagramService.PromptPrint(printDoc))
            //{
            //    _diagramService.Print(printDoc);
            //}
        }

        public void RotateNodes(float angle)
        {
            _diagramService.RotateSelectedNodes(angle);
        }

        public void FitDiagramToDocument()
        {
            _diagramService.FitDocument();
        }

        public void CopyNodes()
        {
            _diagramService.Copy();
        }

        public void PasteNodes()
        {
            _diagramService.Paste();
        }

        public void DeleteNodes()
        {
            _diagramService.DeleteSelectedNodes();
        }

        public void ZoomIn()
        {
            _diagramService.ZoomIn();
        }

        public void ZoomOut()
        {
            _diagramService.ZoomOut();
        }

        public void UndoAction()
        {
            _diagramService.Undo();
        }

        public void RedoAction()
        {
            _diagramService.Redo();
        }
    }

}
