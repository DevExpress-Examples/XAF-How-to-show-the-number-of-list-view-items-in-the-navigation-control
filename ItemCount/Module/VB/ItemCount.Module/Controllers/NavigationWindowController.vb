Imports System.Net
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.SystemModule

Public Class NavigationWindowController
    Inherits WindowController

    Private navigationController As ShowNavigationItemController

    Protected Overrides Sub OnFrameAssigned()
        UnsubscribeFromEvents()
        MyBase.OnFrameAssigned()
        navigationController = Frame.GetController(Of ShowNavigationItemController)()

        If navigationController IsNot Nothing Then
            AddHandler navigationController.NavigationItemCreated, AddressOf NavigationItemCreated
        End If
    End Sub

    Private Sub NavigationItemCreated(ByVal sender As Object, ByVal e As NavigationItemCreatedEventArgs)
        If e.ModelNavigationItem.Id = "Email_ListView" Then
            Dim objectSpace As IObjectSpace = Application.CreateObjectSpace(GetType(Email))
            Dim modelListView As IModelListView = CType(e.ModelNavigationItem.View, IModelListView)
            Dim objectsCount As Integer = objectSpace.GetObjectsCount(GetType(Email), Nothing)
            e.NavigationItem.Caption = "Inbox" & (If(objectsCount > 0, $" ({objectsCount})", String.Empty))
        Else
            e.NavigationItem.Caption = WebUtility.HtmlEncode(e.NavigationItem.Caption)
        End If
    End Sub

    Private Sub UnsubscribeFromEvents()
        If navigationController IsNot Nothing Then
            RemoveHandler navigationController.NavigationItemCreated, AddressOf NavigationItemCreated
            navigationController = Nothing
        End If
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        UnsubscribeFromEvents()
        MyBase.Dispose(disposing)
    End Sub
End Class

