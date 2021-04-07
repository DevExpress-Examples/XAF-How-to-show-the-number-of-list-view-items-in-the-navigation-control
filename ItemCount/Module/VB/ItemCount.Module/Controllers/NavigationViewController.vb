Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule

Public Class NavigationViewController
    Inherits ViewController

    Protected Overrides Sub OnActivated()
        MyBase.OnActivated()
        AddHandler View.ObjectSpace.Committed, AddressOf ObjectSpace_Committed
    End Sub

    Private Sub ObjectSpace_Committed(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim controller As ShowNavigationItemController = Application.MainWindow.GetController(Of ShowNavigationItemController)()

        If controller IsNot Nothing Then
            controller.RecreateNavigationItems()
        End If
    End Sub

    Protected Overrides Sub OnDeactivated()
        RemoveHandler View.ObjectSpace.Committed, AddressOf ObjectSpace_Committed
        MyBase.OnDeactivated()
    End Sub
End Class
