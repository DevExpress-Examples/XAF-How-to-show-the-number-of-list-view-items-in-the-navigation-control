<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/372624392/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1002750)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# XAF - How to show the number of List View items in the Navigation Control

This example displays the number of List View items in the Navigation Control. When a user adds or deletes List View items, navigation item captions update the record count automatically.

### ASP.NET Core Blazor

![ Navigation Control](https://user-images.githubusercontent.com/14300209/232799493-cb38bae6-b88f-4e28-b094-74c115ce5524.png)

## Implementation Details

Follow the steps below to customize navigation item captions:

1. Create a Window Controller ([NavigationObjectCountController.cs](./CS/EFCore/ItemCountEF/ItemCountEF.Module/Controllers/NavigationObjectCountController.cs)). 
    * In the [FrameAssigned](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller.FrameAssigned) event handler, subscribe to the [NavigationItemCreated](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.NavigationItemCreated) event. 
    * Use the [NavigationItem](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.NavigationItemCreatedEventArgs.NavigationItem).[Caption](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Actions.ChoiceActionItem.Caption) event argument property to specify the custom caption (add the number of items).
1. Create a View Controller ([RefreshNavigationController.cs](./CS/EFCore/ItemCountEF/ItemCountEF.Module/Controllers/RefreshNavigationController.cs)).
    * In the [Activated](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Controller.Activated) event handler, subscribe to the [IObjectSpace.Committed](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.IObjectSpace.Committed) event.
    * Call the [RecreateNavigationItems](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.ShowNavigationItemController.RecreateNavigationItems) method to recreate navigation items whenever underlying data changes.

## Files to Review

* [NavigationObjectCountController.cs](./CS/EFCore/ItemCountEF/ItemCountEF.Module/Controllers/NavigationObjectCountController.cs) 
* [RefreshNavigationController.cs](./CS/EFCore/ItemCountEF/ItemCountEF.Module/Controllers/RefreshNavigationController.cs) 

## Documentation

* [Access Controller's Events and Properties](https://docs.devexpress.com/eXpressAppFramework/112676/ui-construction/controllers-and-actions/customize-controllers-and-actions#access-controllers-events-and-properties)

## More Examples

* [XAF - How to show the number of nested List View items in tab captions](https://github.com/DevExpress-Examples/XAF-How-to-show-the-number-of-nested-list-views-items-in-tab-captions)

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF-How-to-show-the-number-of-list-view-items-in-the-navigation-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XAF-How-to-show-the-number-of-list-view-items-in-the-navigation-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
