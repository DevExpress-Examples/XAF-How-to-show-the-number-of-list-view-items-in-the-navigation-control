<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/372624392/21.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1002750)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# XAF - How to show the number of List View items in the Navigation Control

In this example, we demonstrate how to show the number of List View items in the Navigation Control. You can add or delete items in List Views. The record count in navigation item captions will be automatically updated. 

**ASP.NET Core Blazor**

<img src="./media/example-blazor.png" width="600">

**WinForms**

<img src="./media/example-win.png" width="600">


**ASP.NET Web Forms**

<img src="./media/example-web.png" width="600">


## Implementation Steps

1. Create a View Controller. In the overridden `OnActivated` method, handle the [IObjectSpace.Committed](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace.Committed) event. In this event handler, call the [ShowNavigationItemController.RecreateNavigationItems](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.RecreateNavigationItems) method to re-create the Navigation System items after saving changes made in the current Grid List editor.
2. Create a Window Controller. Handle the [ShowNavigationItemController.NavigationItemCreated](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.NavigationItemCreated) event in the overridden `OnFrameAssigned` method. In this event handler, specify the item caption via the `e.NavigationItem.Caption` property.

<!-- default file list --> 
## Files to Review

* [RefreshNavigationController.cs](./ItemCount/Module/CS/ItemCount.Module/Controllers/RefreshNavigationController.cs) 
* [NavigationObjectCountController.cs](./ItemCount/Module/CS/ItemCount.Module/Controllers/NavigationObjectCountController.cs) 
<!-- default file list end -->

## Documentation

- [Access Controller’s Events and Properties](https://docs.devexpress.com/eXpressAppFramework/112676/concepts/controllers-and-actions/customize-controllers-and-actions#access-controllers-events-and-properties)

## More Examples

- [XAF - How to show the number of nested List View items in tab captions](https://github.com/DevExpress-Examples/XAF-How-to-show-the-number-of-nested-list-views-items-in-tab-captions)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF-How-to-show-the-number-of-list-view-items-in-the-navigation-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF-How-to-show-the-number-of-list-view-items-in-the-navigation-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
