﻿Public Class Executer_Fonction_Variable_Form
    Inherits VelerSoftware.Plugins3.ActionForm

    Private PropList As New Generic.List(Of System.Reflection.MethodInfo)

    Private Sub FonctionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            .CancelButtonText = RM.GetString("CancelButtonText")
            .Title = RM.GetString("DisplayName")
            .Help_File = RM.GetString("Help_File")

            .ParseCode_Button_Visible = False

            .ActionTextBox1.IsReadOnly = False

            .ComboBox1.Enabled = False
            .Boutons_ComboBox.Enabled = False

            .Var1_ComboBox.Items.Clear()
            .ComboBox1.Items.Clear()
            .ComboBox1.Items.Add("")
            For Each a As VelerSoftware.SZVB.Projet.Variable In .Tools.GetCurrentProjectVariableList
                If Not a.Array Then
                    .Var1_ComboBox.Items.Add(a.Name)
                    .ComboBox1.Items.Add(a.Name)
                End If
            Next

            If Not .Param1 = Nothing Then
                If Not .Var1_ComboBox.FindString(.Param1) = -1 Then
                    .Var1_ComboBox.Text = .Var1_ComboBox.Items(.Var1_ComboBox.FindString(.Param1))
                End If
            End If

            If Not .Param2 = Nothing Then
                .ActionTextBox1.Text = .Param2
            End If

            If Not .Param3 = Nothing Then
                If Not .Boutons_ComboBox.FindString(.Param3) = -1 Then
                    .Boutons_ComboBox.Text = .Boutons_ComboBox.Items(.Boutons_ComboBox.FindString(.Param3))
                End If
            End If

            If Not .Param4 = Nothing Then
                Dim ind As Integer = 0
                For Each prop As VelerSoftware.SZVB.PropertyGrids.CustomProperty In Me.PropertyGrids1.Item
                    prop.Value = CStr(.Param4.Split(",")(ind).Trim(" "))
                    ind += 1
                Next
            End If

            If Not .Param5 = Nothing Then
                If Not .ComboBox1.FindString(.Param5) = -1 Then
                    .ComboBox1.Text = .ComboBox1.Items(.ComboBox1.FindString(.Param5))
                End If
            End If

        End With
    End Sub

    Private Sub FonctionForm_OnOKButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnOKButtonClicked
        With Me
            If .Boutons_ComboBox.Text = Nothing OrElse .ActionTextBox1.Text = Nothing OrElse .Var1_ComboBox.Text = Nothing Then
                MsgBox(RM.GetString("Formulaire_Incomplet"), MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            .Param1 = .Var1_ComboBox.Text
            .Param2 = .ActionTextBox1.Text
            .Param3 = .Boutons_ComboBox.Text
            .Param4 = Nothing
            For Each prop As VelerSoftware.SZVB.PropertyGrids.CustomProperty In Me.PropertyGrids1.Item
                .Param4 &= prop.Value & ","
            Next
            If Not .Param4 = Nothing Then .Param4 = .Param4.Trim(",")
            If .ComboBox1.Enabled Then
                .Param5 = .ComboBox1.Text
            Else
                .Param5 = Nothing
            End If

            .DialogResult = Windows.Forms.DialogResult.OK
            .Close()
        End With
    End Sub

    Private Sub FonctionForm_OnCancelButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnCancelButtonClicked
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Boutons_ComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Boutons_ComboBox.SelectedIndexChanged
        Me.ComboBox1.Enabled = False
        If Me.Boutons_ComboBox.Text.Contains("(type :") Then
            Me.ComboBox1.Enabled = True
        End If

        Me.PropertyGrids1.SelectedObjects = Nothing
        Me.PropertyGrids1.Item.Clear()
        Me.PropertyGrids1.ItemSet.Clear()
        Me.PropertyGrids1.ShowCustomProperties = True
        Me.PropertyGrids1.Refresh()

        Dim metho As System.Reflection.MethodInfo = Nothing
        For Each a As System.Reflection.MethodInfo In PropList
            If Me.Boutons_ComboBox.Text.StartsWith(a.Name & " ") AndAlso Me.Boutons_ComboBox.Text.Split(")")(0).Split(" ")(Me.Boutons_ComboBox.Text.Split(")")(0).Split(" ").Count - 1) = a.GetParameters.Count Then
                metho = a
                Exit For
            End If
        Next
        If Not metho = Nothing Then
            For Each a As System.Reflection.ParameterInfo In metho.GetParameters()
                Me.PropertyGrids1.Item.Add(a.Name, "Nothing", False, "", "", True)
            Next
        End If
        Me.PropertyGrids1.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tip As Type = Me.Tools.SelectType
        If Not tip Is Nothing Then
            Me.ActionTextBox1.Text = tip.FullName
        End If
    End Sub

    Private Sub ActionTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionTextBox1.TextChanged
        If Not Me.ActionTextBox1.Text = Nothing Then Me.Boutons_ComboBox.Enabled = True

        Me.Boutons_ComboBox.Items.Clear()
        PropList = Tools.GetMethodList(Me.ActionTextBox1.Text)
        For Each a As System.Reflection.MethodInfo In PropList
            If a.ReturnType.FullName = "System.Void" Then
                Me.Boutons_ComboBox.Items.Add(a.Name & " (parameters count : " & a.GetParameters.Length & ")")
            Else
                Me.Boutons_ComboBox.Items.Add(a.Name & " (type : " & a.ReturnType.FullName & "; parameters count : " & a.GetParameters.Length & ")")
            End If
        Next
    End Sub

    Private Sub FonctionForm_OnRefreshCodeButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnRefreshCodeButtonClick
        If Me.Boutons_ComboBox.Text = Nothing OrElse Me.ActionTextBox1.Text = Nothing OrElse Me.Var1_ComboBox.Text = Nothing Then
            MsgBox(RM.GetString("Formulaire_Incomplet"), MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim sourceWriter As New IO.StringWriter()

        If Me.ComboBox1.Enabled AndAlso (Not Me.ComboBox1.Text = Nothing) Then
            Dim param As String = ""
            For Each prop As VelerSoftware.SZVB.PropertyGrids.CustomProperty In Me.PropertyGrids1.Item
                param &= prop.Value & ","
            Next
            If Not param = Nothing Then param = param.Trim(",")

            Dim MsgBoxStatement As New CodeDom.CodeMethodInvokeExpression(New CodeDom.CodeVariableReferenceExpression(Me.Var1_ComboBox.Text), Me.Boutons_ComboBox.Text.Split(" ")(0), New CodeDom.CodeSnippetExpression(param))
            CodeDom.Compiler.CodeDomProvider.CreateProvider("VB").GenerateCodeFromStatement(New CodeDom.CodeAssignStatement(New CodeDom.CodeVariableReferenceExpression(Me.ComboBox1.Text), MsgBoxStatement), sourceWriter, New CodeDom.Compiler.CodeGeneratorOptions())
        Else
            Dim param As String = ""
            For Each prop As VelerSoftware.SZVB.PropertyGrids.CustomProperty In Me.PropertyGrids1.Item
                param &= prop.Value & ","
            Next
            If Not param = Nothing Then param = param.Trim(",")
            Dim MsgBoxStatement As New CodeDom.CodeMethodInvokeExpression(New CodeDom.CodeVariableReferenceExpression(Me.Var1_ComboBox.Text), Me.Boutons_ComboBox.Text.Split(" ")(0), New CodeDom.CodeSnippetExpression(param))
            CodeDom.Compiler.CodeDomProvider.CreateProvider("VB").GenerateCodeFromExpression(MsgBoxStatement, sourceWriter, New CodeDom.Compiler.CodeGeneratorOptions())
        End If

        sourceWriter.Close()

        Me.CodeEditor_Text = sourceWriter.ToString
    End Sub

End Class