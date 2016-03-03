﻿Public Class Ajouter_Valeur_Variable_Tableau_Form
    Inherits VelerSoftware.Plugins3.ActionForm

    Private Sub FonctionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            .CancelButtonText = RM.GetString("CancelButtonText")
            .Title = RM.GetString("DisplayName")
            .Help_File = RM.GetString("Help_File")

            .ParseCode_Button_Visible = True

            .ValueEdit1.Tools = .Tools
            .ActionTextBox1.Tools = .Tools

            .ActionTextBox1.Text = "0"

            .Boutons_ComboBox.SelectedIndex = 0
            .Boutons_ComboBox.Items.Clear()
            For Each a As VelerSoftware.SZVB.Projet.Variable In .Tools.GetCurrentProjectVariableList
                If a.Array Then
                    .Boutons_ComboBox.Items.Add(a.Name)
                End If
            Next

            If Not .Param1 = Nothing Then
                If Not .Boutons_ComboBox.FindString(.Param1) = -1 Then
                    .Boutons_ComboBox.Text = .Boutons_ComboBox.Items(.Boutons_ComboBox.FindString(.Param1))
                End If
            End If

            If Not .Param3 = Nothing Then
                .ValueEdit1.SetGeneratedCode(.Param3)
            End If

            If Not .Param2 = Nothing Then
                .ValueEdit1.SetStrictValue(.Param2, CInt(.Param4))
            End If

            If Not .Param5 = Nothing Then
                If CBool(.Param5) Then
                    Me.RadioButton1.Checked = True
                Else
                    Me.RadioButton2.Checked = True
                End If
                Me.ActionTextBox1.Text = .Param6
            End If
        End With
    End Sub

    Private Sub FonctionForm_OnOKButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnOKButtonClicked
        With Me
            If .Boutons_ComboBox.Text = "" Then
                MsgBox(RM.GetString("Formulaire_Incomplet"), MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            .Param1 = .Boutons_ComboBox.Text
            .Param2 = .ValueEdit1.GetStrictValue()
            .Param4 = CInt(.ValueEdit1.Editor)
            .Param3 = .ValueEdit1.GetGeneratedCode()
            .Param5 = Me.RadioButton1.Checked
            If Me.ActionTextBox1.Text = "" Then
                .Param6 = "0"
            Else
                .Param6 = Me.ActionTextBox1.Text
            End If


            .DialogResult = Windows.Forms.DialogResult.OK
            .Close()
        End With
    End Sub

    Private Sub FonctionForm_OnCancelButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnCancelButtonClicked
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FonctionForm_OnRefreshCodeButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.OnRefreshCodeButtonClick
        If Me.Boutons_ComboBox.Text = "" Then
            MsgBox(RM.GetString("Formulaire_Incomplet"), MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim sourceWriter As New IO.StringWriter()

        Dim VariableStatement As New CodeDom.CodeVariableReferenceExpression(Me.Boutons_ComboBox.Text)
        Dim MsgBoxStatement As New CodeDom.CodeSnippetExpression(Me.ValueEdit1.GetGeneratedCode())
        Dim OperationStatement As CodeDom.CodeMethodInvokeExpression
        If Me.RadioButton1.Checked Then
            OperationStatement = New CodeDom.CodeMethodInvokeExpression(VariableStatement, "Add", MsgBoxStatement)
        Else
            OperationStatement = New CodeDom.CodeMethodInvokeExpression(VariableStatement, "Insert", New CodeDom.CodeSnippetExpression(Me.Tools.TransformKeyVariables(Me.ActionTextBox1.Text, False, False)), MsgBoxStatement)
        End If
        CodeDom.Compiler.CodeDomProvider.CreateProvider("VB").GenerateCodeFromExpression(OperationStatement, sourceWriter, New CodeDom.Compiler.CodeGeneratorOptions())

        sourceWriter.Close()

        Me.CodeEditor_Text = sourceWriter.ToString
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Me.ActionTextBox1.Enabled = Me.RadioButton2.Checked
    End Sub

    Private Sub FonctionForm_OnParseCodeButtonClick(ByVal sender As CodeDom.CodeCompileUnit, ByVal e As System.EventArgs) Handles MyBase.OnParseCodeButtonClick
        If (Not sender Is Nothing) AndAlso (sender.Namespaces.Count > 0) Then
            Dim metho As CodeDom.CodeMethodInvokeExpression
            For Each sta As CodeDom.CodeStatement In DirectCast(sender.Namespaces(0).Types(0).Members(0), CodeDom.CodeMemberMethod).Statements

                If TypeOf sta Is CodeDom.CodeExpressionStatement AndAlso TypeOf DirectCast(sta, CodeDom.CodeExpressionStatement).Expression Is CodeDom.CodeMethodInvokeExpression Then
                    metho = DirectCast(DirectCast(sta, CodeDom.CodeExpressionStatement).Expression, CodeDom.CodeMethodInvokeExpression)
                    If metho.Method.MethodName = "Add" Then
                        Me.RadioButton1.Checked = True
                    ElseIf metho.Method.MethodName = "Insert" Then
                        Me.RadioButton2.Checked = True
                        If TypeOf metho.Parameters(0) Is CodeDom.CodePrimitiveExpression AndAlso Microsoft.VisualBasic.IsNumeric(DirectCast(metho.Parameters(0), CodeDom.CodePrimitiveExpression).Value) Then
                            Me.ActionTextBox1.Text = CInt(DirectCast(metho.Parameters(0), CodeDom.CodePrimitiveExpression).Value)
                        End If
                    End If
                    If TypeOf metho.Method.TargetObject Is CodeDom.CodeVariableReferenceExpression Then
                        Me.Boutons_ComboBox.Text = DirectCast(metho.Method.TargetObject, CodeDom.CodeVariableReferenceExpression).VariableName
                    End If

                End If

            Next
        End If
    End Sub

End Class