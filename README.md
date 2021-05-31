# XAF - How to show the number of List View items in the Navigation Control

## Scenario
In this example, we demonstrate how to show the number of List View items in the Navigation Control. You can add or delete items in List Views. The record count in navigation item captions will be automatically updated. 

### WinForms

<img src="./media/example-win.png" width="600">

### ASP.NET Web Forms

<img src="./media/example-web.png" width="600">

## Implementation steps

1. Create a View Controller. In the overridden **OnActivated** method, handle the [IObjectSpace.Committed](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace.Committed) event. In this event handler, call the [ShowNavigationItemController.RecreateNavigationItems](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.RecreateNavigationItems) method to re-create the Navigation System items after saving changes made in the current Grid List editor.
2. Create a Window Controller. Handle the [ShowNavigationItemController.NavigationItemCreated](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.NavigationItemCreated) event in the overridden **OnFrameAssigned** method. In this event handler, specify the item caption via the EventArg's e.NavigationItem.Caption property.

<!-- default file list --> 
*Files to look at*:
* [RefreshNavigationController.cs](./ItemCount/Module/CS/ItemCount.Module/Controllers/RefreshNavigationController.cs) 
* [NavigationObjectCountController.cs](./ItemCount/Module/CS/ItemCount.Module/Controllers/NavigationObjectCountController.cs) 
<!-- default file list end -->

**Note**. Although this example demonstrates a platform-agnostic way of updating navigation item captions, the current version of the Navigation System in XAF Blazor does not support restoring the control state. We will enhance the Navigation System functionality in future versions.

***See also***
[XAF - How to show the number of nested List View items in tab captions](https://github.com/DevExpress-Examples/XAF-How-to-show-the-number-of-nested-list-views-items-in-tab-captions)
