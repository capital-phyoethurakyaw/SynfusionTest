using Moq;
using NUnit.Framework;
using System.Drawing.Printing;
using WindowsFormsApp1;
[TestFixture]
public class DiagramControllerTests
{
    private Mock<IDiagramService> _mockDiagramService;
    private DiagramController _diagramController;

    [SetUp]
    public void Setup()
    {
        _mockDiagramService = new Mock<IDiagramService>();
        _diagramController = new DiagramController(_mockDiagramService.Object);
    }

    [Test]
    public void SaveDiagram_Should_CallSaveFile_When_PromptOnSaveIsFalse()
    {
        // Arrange
        string fileName = "testfile.edd";

        // Act
        _diagramController.SaveDiagram(false, fileName);

        // Assert
        _mockDiagramService.Verify(ds => ds.SaveFile(fileName), Times.Once);
    }

    //[Test]
    //public void PrintDiagram_Should_CallPrint_When_PrintDialogReturnsTrue()
    //{
    //    // Arrange
    //    var printDoc = new PrintDocument();
    //    _mockDiagramService.Setup(ds => ds.CreatePrintDocument()).Returns(printDoc);
    //    _mockDiagramService.Setup(ds => ds.PromptPrint(printDoc)).Returns(true);

    //    // Act
    //    _diagramController.PrintDiagram();

    //    // Assert
    //    _mockDiagramService.Verify(ds => ds.Print(printDoc), Times.Once);
    //}

    [Test]
    public void RotateNodes_Should_CallRotateMethod_WithSpecifiedAngle()
    {
        // Arrange
        float angle = 90f;

        // Act
        _diagramController.RotateNodes(angle);

        // Assert
        _mockDiagramService.Verify(ds => ds.RotateSelectedNodes(angle), Times.Once);
    }

    [Test]
    public void FitDiagramToDocument_Should_CallFitDocument()
    {
        // Act
        _diagramController.FitDiagramToDocument();

        // Assert
        _mockDiagramService.Verify(ds => ds.FitDocument(), Times.Once);
    }

    [Test]
    public void CopyNodes_Should_CallCopy()
    {
        // Act
        _diagramController.CopyNodes();

        // Assert
        _mockDiagramService.Verify(ds => ds.Copy(), Times.Once);
    }

    [Test]
    public void PasteNodes_Should_CallPaste()
    {
        // Act
        _diagramController.PasteNodes();

        // Assert
        _mockDiagramService.Verify(ds => ds.Paste(), Times.Once);
    }

    [Test]
    public void DeleteNodes_Should_CallDeleteSelectedNodes()
    {
        // Act
        _diagramController.DeleteNodes();

        // Assert
        _mockDiagramService.Verify(ds => ds.DeleteSelectedNodes(), Times.Once);
    }

    [Test]
    public void ZoomIn_Should_CallZoomIn()
    {
        // Act
        _diagramController.ZoomIn();

        // Assert
        _mockDiagramService.Verify(ds => ds.ZoomIn(), Times.Once);
    }

    [Test]
    public void ZoomOut_Should_CallZoomOut()
    {
        // Act
        _diagramController.ZoomOut();

        // Assert
        _mockDiagramService.Verify(ds => ds.ZoomOut(), Times.Once);
    }

    [Test]
    public void
    UndoAction_Should_CallUndo()
    {
        // Act
        _diagramController.UndoAction();

        // Assert
        _mockDiagramService.Verify(ds => ds.Undo(), Times.Once);
    }

    [Test]
    public void RedoAction_Should_CallRedo()
    {
        // Act
        _diagramController.RedoAction();

        // Assert
        _mockDiagramService.Verify(ds => ds.Redo(), Times.Once);
    }
}
