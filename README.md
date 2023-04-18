<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/372624392/22.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1002750)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# XAF - How to show the number of List View items in the Navigation Control

## Scenario

In this example, we demonstrate how to show the number of List View items in the Navigation Control. You can add or delete items in List Views. The record count in navigation item captions will be automatically updated. 

### ASP.NET Core Blazor

![image](https://user-images.githubusercontent.com/14300209/232799493-cb38bae6-b88f-4e28-b094-74c115ce5524.png)



## Implementation Steps

1. Create a View Controller. In the overridden **OnActivated** method, handle the [IObjectSpace.Committed](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace.Committed) event. In this event handler, call the [ShowNavigationItemController.RecreateNavigationItems](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.RecreateNavigationItems) method to re-create the Navigation System items after saving changes made in the current Grid List editor.
2. Create a Window Controller. Handle the [ShowNavigationItemController.NavigationItemCreated](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.NavigationItemCreated) event in the overridden **OnFrameAssigned** method. In this event handler, specify the item caption via the e.NavigationItem.Caption property.

<!-- default file list --> 
*Files to look at*:
* [RefreshNavigationController.cs](./CS/EFCore/ItemCountEF/ItemCountEF.Module/Controllers/RefreshNavigationController.cs) 
* [NavigationObjectCountController.cs](./CS/EFCore/ItemCountEF/ItemCountEF.Module/Controllers/NavigationObjectCountController.cs) 
<!-- default file list end -->

## See Also

- [Access Controller’s Events and Properties](https://docs.devexpress.com/eXpressAppFramework/112676/concepts/controllers-and-actions/customize-controllers-and-actions#access-controllers-events-and-properties)
- [XAF - How to show the number of nested List View items in tab captions](https://github.com/DevExpress-Examples/XAF-How-to-show-the-number-of-nested-list-views-items-in-tab-captions)
