Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraLayout

Namespace WinExample.Module.Win
	Partial Public Class PrintDetailViewController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewType = ViewType.DetailView
		End Sub
		Private Sub printDetailViewAction_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles printDetailViewAction.Execute
			Dim _layoutControl As LayoutControl = TryCast(View.Control, LayoutControl)
			If _layoutControl IsNot Nothing Then
				Dim _printableComponentLink As New PrintableComponentLink(New PrintingSystem())
				_printableComponentLink.Landscape = True
				_printableComponentLink.Component = TryCast(View.Control, LayoutControl)
				_printableComponentLink.CreateDocument()
				_printableComponentLink.PrintingSystem.Document.AutoFitToPagesWidth = 1
				_printableComponentLink.ShowPreview()
			End If
		End Sub
	End Class
End Namespace
