﻿Public Class Ajouter_Onglet_TabControl_Form
    Inherits VelerSoftware.Plugins3.ActionForm

    Private Sub FonctionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            .CancelButtonText = RM.GetString("CancelButtonText")
            .Title = RM.GetString("DisplayName")
            .Help_File = RM.GetString("Help_File")

            .ParseCode_Button_Visible = True

            .Titre_ActionTextBox.Tools = .Tools
            .ActionTextBox1.Tools = .Tools

            .Boutons_ComboBox.Items.Clear()
            For Each aaa As VelerSoftware.Plugins3.Windows.Core.Object In .Tools.GetCurrentProjectWindowsControls
                If aaa.ObjectType = GetType(CodeDom.CodeMemberField) AndAlso DirectCast(aaa.Object, CodeDom.CodeMemberField).Type.BaseType = "System.Windows.Forms.TabControl" Then
                    .Boutons_ComboBox.Items.Add(aaa.FullName)
                End If
            Next

            If Not .Param1 = Nothing Then
                If Not .Boutons_ComboBox.FindString(.Param1) = -1 Then
                    .Boutons_ComboBox.Text = .Boutons_ComboBox.Items(.Boutons_ComboBox.FindString(.Param1))
                End If
            End If

            If Not .Param2 = Nothing Then .Titre_ActionTextBox.Text = .Param2

            If Not .Param3 = Nothing Then .ActionTextBox1.Text = .Param3

        End With
    End Sub

    Private Sub FonctionForm_OnOKButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnOKButtonClicked
        With Me
            If .Boutons_ComboBox.Text = "" OrElse .ActionTextBox1.Text = "" Then
                MsgBox(RM.GetString("Formulaire_Incomplet"), MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            .Param1 = .Boutons_ComboBox.Text
            .Param2 = .Titre_ActionTextBox.Text
            .Param3 = .ActionTextBox1.Text

            .DialogResult = Windows.Forms.DialogResult.OK
            .Close()
        End With
    End Sub

    Private Sub FonctionForm_OnCancelButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnCancelButtonClicked
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FonctionForm_OnRefreshCodeButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnRefreshCodeButtonClick
        If Me.Boutons_ComboBox.Text = "" OrElse Me.ActionTextBox1.Text = "" Then
            MsgBox(RM.GetString("Formulaire_Incomplet"), MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim sourceWriter As New IO.StringWriter()

        Dim OperationStatement As CodeDom.CodeMethodInvokeExpression
        If Me.Boutons_ComboBox.Text.StartsWith("Me.") Then
            OperationStatement = New CodeDom.CodeMethodInvokeExpression(New CodeDom.CodeMethodReferenceExpression(New CodeDom.CodeFieldReferenceExpression(New CodeDom.CodeThisReferenceExpression(), Me.Boutons_ComboBox.Text.Substring(3) & ".TabPages"), "Add"), New CodeDom.CodeSnippetExpression(Me.Tools.TransformKeyVariables(Me.ActionTextBox1.Text, True)), New CodeDom.CodeSnippetExpression(Me.Tools.TransformKeyVariables(Me.Titre_ActionTextBox.Text, True)))
        Else
            OperationStatement = New CodeDom.CodeMethodInvokeExpression(New CodeDom.CodeMethodReferenceExpression(New CodeDom.CodeTypeReferenceExpression("Variables." & Me.Boutons_ComboBox.Text), "Navigate" & ".Add"), New CodeDom.CodeSnippetExpression(Me.Tools.TransformKeyVariables(Me.ActionTextBox1.Text, True)), New CodeDom.CodeSnippetExpression(Me.Tools.TransformKeyVariables(Me.Titre_ActionTextBox.Text, True)))
        End If
        CodeDom.Compiler.CodeDomProvider.CreateProvider("VB").GenerateCodeFromExpression(OperationStatement, sourceWriter, New CodeDom.Compiler.CodeGeneratorOptions())

        sourceWriter.Close()

        Me.CodeEditor_Text = sourceWriter.ToString
    End Sub

    Private Sub FonctionForm_OnParseCodeButtonClick(ByVal sender As CodeDom.CodeCompileUnit, ByVal e As System.EventArgs) Handles MyBase.OnParseCodeButtonClick
        If (Not sender Is Nothing) AndAlso (sender.Namespaces.Count > 0) Then
            Dim metho As CodeDom.CodeMethodInvokeExpression
            For Each sta As CodeDom.CodeStatement In DirectCast(sender.Namespaces(0).Types(0).Members(0), CodeDom.CodeMemberMethod).Statements

                If TypeOf sta Is CodeDom.CodeExpressionStatement AndAlso TypeOf DirectCast(sta, CodeDom.CodeExpressionStatement).Expression Is CodeDom.CodeMethodInvokeExpression Then
                    ' Dans le cas où se soit une simple méthode
                    metho = DirectCast(DirectCast(sta, CodeDom.CodeExpressionStatement).Expression, CodeDom.CodeMethodInvokeExpression)
                    If metho.Method.MethodName = "Add" AndAlso TypeOf metho.Method.TargetObject Is CodeDom.CodePropertyReferenceExpression Then
                        If TypeOf metho.Parameters(0) Is CodeDom.CodePrimitiveExpression Then
                            Me.ActionTextBox1.Text = DirectCast(metho.Parameters(0), CodeDom.CodePrimitiveExpression).Value
                        End If
                        If TypeOf metho.Parameters(1) Is CodeDom.CodePrimitiveExpression Then
                            Me.Titre_ActionTextBox.Text = DirectCast(metho.Parameters(1), CodeDom.CodePrimitiveExpression).Value
                        End If
                        If TypeOf metho.Method.TargetObject Is CodeDom.CodePropertyReferenceExpression AndAlso TypeOf DirectCast(metho.Method.TargetObject, CodeDom.CodePropertyReferenceExpression) Is CodeDom.CodePropertyReferenceExpression Then
                            If Not Me.Boutons_ComboBox.FindString("Me." & DirectCast(DirectCast(metho.Method.TargetObject, CodeDom.CodePropertyReferenceExpression).TargetObject, CodeDom.CodePropertyReferenceExpression).PropertyName) = -1 Then
                                Me.Boutons_ComboBox.Text = Me.Boutons_ComboBox.Items(Me.Boutons_ComboBox.FindString("Me." & DirectCast(DirectCast(metho.Method.TargetObject, CodeDom.CodePropertyReferenceExpression).TargetObject, CodeDom.CodePropertyReferenceExpression).PropertyName))
                            End If
                            If Not Me.Boutons_ComboBox.FindString("Variables." & DirectCast(DirectCast(metho.Method.TargetObject, CodeDom.CodePropertyReferenceExpression).TargetObject, CodeDom.CodePropertyReferenceExpression).PropertyName) = -1 Then
                                Me.Boutons_ComboBox.Text = Me.Boutons_ComboBox.Items(Me.Boutons_ComboBox.FindString("Variables." & DirectCast(DirectCast(metho.Method.TargetObject, CodeDom.CodePropertyReferenceExpression).TargetObject, CodeDom.CodePropertyReferenceExpression).PropertyName))
                            End If
                        End If
                    End If

                End If

            Next
        End If
    End Sub

End Class