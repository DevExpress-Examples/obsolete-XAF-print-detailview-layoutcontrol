using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.XtraPrinting;
using DevExpress.XtraLayout;

namespace WinExample.Module.Win {
    public partial class PrintDetailViewController : ViewController {
        public PrintDetailViewController() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewType = ViewType.DetailView;
        }
        private void printDetailViewAction_Execute(object sender, SimpleActionExecuteEventArgs e) {
            LayoutControl _layoutControl = View.Control as LayoutControl;
            if (_layoutControl != null) {
                PrintableComponentLink _printableComponentLink = new PrintableComponentLink(new PrintingSystem());
                _printableComponentLink.Landscape = true;
                _printableComponentLink.Component = View.Control as LayoutControl;
                _printableComponentLink.CreateDocument();
                _printableComponentLink.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                _printableComponentLink.ShowPreview();
            }
        }
    }
}
