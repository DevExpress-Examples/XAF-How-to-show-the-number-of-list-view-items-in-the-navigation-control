using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using dxTestSolution.Module.BusinessObjects;

namespace ItemCount.Module.Controllers {
    public class RefreshNavigationController : ViewController {
        public RefreshNavigationController() {
            TargetViewNesting = Nesting.Root;
            TargetObjectType = typeof(Email);
        }
        protected override void OnActivated() {
            base.OnActivated();
            View.ObjectSpace.Committed += ObjectSpace_Committed;
        }
        private void ObjectSpace_Committed(object sender, System.EventArgs e) {
            ShowNavigationItemController controller = Application.MainWindow.GetController<ShowNavigationItemController>();
            if(controller != null) {
                controller.ShowNavigationItemAction.BeginUpdate();
                controller.RecreateNavigationItems();
                controller.ShowNavigationItemAction.EndUpdate();
            }
        }
        protected override void OnDeactivated() {
            View.ObjectSpace.Committed -= ObjectSpace_Committed;
            base.OnDeactivated();
        }
    }
}
