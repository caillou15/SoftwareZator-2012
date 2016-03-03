﻿Public Class Assistant_Etape_Precedente_Designer

    Private Sub ActionChanged(ByVal sender As System.Object, ByVal propertyName As String, ByVal e As System.EventArgs)
        If propertyName = "Param1" Then Me.ComboBox1.Text = DirectCast(Me.ModelItem.GetCurrentValue, Assistant_Etape_Precedente).Param1
    End Sub

    Private Sub ActivityDesigner_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        ' Initialisation de la langue et des ressources
        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.WizardPlugin.Assistant_Etape_Precedente", GetType(Assistant_Etape_Precedente).Assembly)

        Me.Label2.Content = RM.GetString("Designer_Text")
        Me.TextBlock1.Text = RM.GetString("Designer_Collaspe")

        Me.ComboBox1.Items.Clear()
        For Each aaa As VelerSoftware.Plugins3.Windows.Core.Object In DirectCast(Me.ModelItem.GetCurrentValue, Assistant_Etape_Precedente).Tools.GetCurrentProjectWindows(False)
            If aaa.ObjectType = GetType(System.CodeDom.CodeTypeDeclaration) AndAlso (DirectCast(aaa.Object, System.CodeDom.CodeTypeDeclaration).BaseTypes(0).BaseType = "VelerSoftware.WizardLib.AeroWizardForm" OrElse DirectCast(aaa.Object, System.CodeDom.CodeTypeDeclaration).BaseTypes(0).BaseType = "VelerSoftware.WizardLib.Wizard97Form") Then Me.ComboBox1.Items.Add(aaa.FullName)
        Next

        Me.ComboBox1.SelectedItem = DirectCast(Me.ModelItem.GetCurrentValue, Assistant_Etape_Precedente).Param1

        AddHandler DirectCast(Me.ModelItem.GetCurrentValue, Assistant_Etape_Precedente).ActionChanged, AddressOf ActionChanged
    End Sub

    Private Sub ComboBox1_DropDownOpened(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDownOpened
        Dim txt As String = Me.ComboBox1.Text

        Me.ComboBox1.Items.Clear()
        For Each aaa As VelerSoftware.Plugins3.Windows.Core.Object In DirectCast(Me.ModelItem.GetCurrentValue, Assistant_Etape_Precedente).Tools.GetCurrentProjectWindows(False)
            If aaa.ObjectType = GetType(System.CodeDom.CodeTypeDeclaration) AndAlso (DirectCast(aaa.Object, System.CodeDom.CodeTypeDeclaration).BaseTypes(0).BaseType = "VelerSoftware.WizardLib.AeroWizardForm" OrElse DirectCast(aaa.Object, System.CodeDom.CodeTypeDeclaration).BaseTypes(0).BaseType = "VelerSoftware.WizardLib.Wizard97Form") Then Me.ComboBox1.Items.Add(aaa.FullName)
        Next

        Me.ComboBox1.SelectedItem = txt
    End Sub
End Class
