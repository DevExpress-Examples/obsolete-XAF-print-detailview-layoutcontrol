Imports Microsoft.VisualBasic
Imports System
Namespace WinExample.Module.Win
	Partial Public Class PrintDetailViewController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.printDetailViewAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' printDetailViewAction
			' 
			Me.printDetailViewAction.Caption = "Print"
			Me.printDetailViewAction.Category = "View"
			Me.printDetailViewAction.Id = "PrintDetailViewAction"
'			Me.printDetailViewAction.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.printDetailViewAction_Execute);

		End Sub

		#End Region

		Private WithEvents printDetailViewAction As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace
