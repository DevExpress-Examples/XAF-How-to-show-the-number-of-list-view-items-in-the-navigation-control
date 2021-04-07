using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using ItemCount.Module.BusinessObjects;

namespace ItemCount.Module.Controllers {
    public class NavigationViewController : ViewController {
        protected override void OnActivated() {
            base.OnActivated();
            View.ObjectSpace.Committed += ObjectSpace_Committed;
        }
        private void ObjectSpace_Committed(object sender, System.EventArgs e) {
            ShowNavigationItemController controller = Application.MainWindow.GetController<ShowNavigationItemController>();
            if(controller != null) {
                controller.RecreateNavigationItems();
            }
        }
        protected override void OnDeactivated() {
            View.ObjectSpace.Committed -= ObjectSpace_Committed;
            base.OnDeactivated();
        }
    }
}
