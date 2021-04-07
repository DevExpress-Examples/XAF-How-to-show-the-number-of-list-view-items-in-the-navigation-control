using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.SystemModule;
using ItemCount.Module.BusinessObjects;

namespace ItemCount.Module.Controllers {
    public class NavigationWindowController : WindowController {
        private ShowNavigationItemController navigationController;
        protected override void OnFrameAssigned() {
            UnsubscribeFromEvents();
            base.OnFrameAssigned();
            navigationController = Frame.GetController<ShowNavigationItemController>();
            if(navigationController != null) {
                navigationController.NavigationItemCreated += NavigationItemCreated;
            }
        }
        void NavigationItemCreated(object sender, NavigationItemCreatedEventArgs e) {
            if(e.ModelNavigationItem.Id == "Email_ListView") {
                IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Email));
                IModelListView modelListView = (IModelListView)e.ModelNavigationItem.View;
                int objectsCount = objectSpace.GetObjectsCount(typeof(Email), null);
                e.NavigationItem.Caption = "Inbox" + (objectsCount > 0 ? $" ({objectsCount})" : string.Empty);
            }
            else {
                e.NavigationItem.Caption = WebUtility.HtmlEncode(e.NavigationItem.Caption);
            }
        }
        private void UnsubscribeFromEvents() {
            if(navigationController != null) {
                navigationController.NavigationItemCreated -= NavigationItemCreated;
                navigationController = null;
            }
        }
        protected override void Dispose(bool disposing) {
            UnsubscribeFromEvents();
            base.Dispose(disposing);
        }
    }
}
