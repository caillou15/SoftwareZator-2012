﻿Public Class Enregistrer_Donnee_Serialisable_Designer

    Private Sub ActionChanged(ByVal sender As System.Object, ByVal propertyName As String, ByVal e As System.EventArgs)
        If propertyName = "Param1" Then Me.TextBox1.Text = DirectCast(Me.ModelItem.GetCurrentValue, Enregistrer_Donnee_Serialisable).Param1
    End Sub

    Private Sub ActivityDesigner_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        ' Initialisation de la langue et des ressources
        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Enregistrer_Donnee_Serialisable", GetType(Enregistrer_Donnee_Serialisable).Assembly)

        Me.Label2.Content = RM.GetString("Designer_Text")
        Me.TextBlock1.Text = RM.GetString("Designer_Collaspe")

        Me.TextBox1.Text = DirectCast(Me.ModelItem.GetCurrentValue, Enregistrer_Donnee_Serialisable).Param1

        AddHandler DirectCast(Me.ModelItem.GetCurrentValue, Enregistrer_Donnee_Serialisable).ActionChanged, AddressOf ActionChanged
    End Sub

End Class
