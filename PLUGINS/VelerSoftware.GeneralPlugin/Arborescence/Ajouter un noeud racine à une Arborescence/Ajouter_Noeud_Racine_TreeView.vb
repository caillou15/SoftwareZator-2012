﻿<System.ComponentModel.Designer(GetType(VelerSoftware.GeneralPlugin.Ajouter_Noeud_Racine_TreeView_Designer))> _
Public Class Ajouter_Noeud_Racine_TreeView
    Inherits VelerSoftware.Plugins3.Action

    Public Sub New()
        ' Initialisation de la langue et des ressources
        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ajouter_Noeud_Racine_TreeView", GetType(Ajouter_Noeud_Racine_TreeView).Assembly)

        With Me
            .DisplayName = RM.GetString("DisplayName")
            .Description = RM.GetString("Description")
            .Category = RM.GetString("Category")
            .ToolBoxImage = My.Resources.ajouter_noeud_treeview
            .CompatibleClass = False
            .CompatibleFonctions = True
            .FileHelp = RM.GetString("Help_File")

            .Voice_Recognition_Dictionary.Add(RM.GetString("Dictionary1"))
            .Voice_Recognition_Dictionary.Add(RM.GetString("Dictionary2"))
            .Voice_Recognition_Expressions_Dictionary.Add(RM.GetString("DictionaryExpression1"))
        End With
    End Sub

    Public Overrides Function Main() As Boolean
        ' Initialisation de la langue et des ressources
        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ajouter_Noeud_Racine_TreeView", GetType(Ajouter_Noeud_Racine_TreeView).Assembly)
        Using frm As New Ajouter_Noeud_Racine_TreeView_Form
            frm.Tools = Me.Tools
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.UseCustomVBCode = frm.CodeEditor_Used
                Me.CustomVBCode = New CodeDom.CodeSnippetStatement(frm.CodeEditor_Text)
                Me.Param1 = frm.Param1
                Me.Param2 = frm.Param2
                Me.Param3 = frm.Param3
                Me.Param4 = frm.Param4
                Me.Param5 = frm.Param5
                Me.Param6 = frm.Param6
                Me.Param7 = frm.Param7
                Me.Param8 = frm.Param8

                Return True
            Else
                Return False
            End If
            frm.Dispose()
        End Using
    End Function

    Public Overrides Function Modify() As Boolean
        ' Initialisation de la langue et des ressources
        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ajouter_Noeud_Racine_TreeView", GetType(Ajouter_Noeud_Racine_TreeView).Assembly)
        Using frm As New Ajouter_Noeud_Racine_TreeView_Form
            frm.Tools = Me.Tools
            frm.Param1 = Me.Param1
            frm.Param2 = Me.Param2
            frm.Param3 = Me.Param3
            frm.Param4 = Me.Param4
            frm.Param5 = Me.Param5
            frm.Param6 = Me.Param6
            frm.Param7 = Me.Param7
            frm.Param8 = Me.Param8
            frm.CodeEditor_Shown = Me.UseCustomVBCode
            frm.CodeEditor_Used = Me.UseCustomVBCode

            Dim sourceWriter As New IO.StringWriter()
            If Not Me.CustomVBCode Is Nothing Then CodeDom.Compiler.CodeDomProvider.CreateProvider("VB").GenerateCodeFromStatement(Me.CustomVBCode, sourceWriter, New CodeDom.Compiler.CodeGeneratorOptions())
            sourceWriter.Close()
            frm.CodeEditor_Text = sourceWriter.ToString

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.UseCustomVBCode = frm.CodeEditor_Used
                Me.CustomVBCode = New CodeDom.CodeSnippetStatement(frm.CodeEditor_Text)
                Me.Param1 = frm.Param1
                Me.Param2 = frm.Param2
                Me.Param3 = frm.Param3
                Me.Param4 = frm.Param4
                Me.Param5 = frm.Param5
                Me.Param6 = frm.Param6
                Me.Param7 = frm.Param7
                Me.Param8 = frm.Param8
                Return True
            Else
                Return False
            End If
            frm.Dispose()
        End Using
    End Function

    Public Overrides Function GetVBCode(ByVal FromFunction As Boolean) As System.CodeDom.CodeObject
        If Me.UseCustomVBCode Then
            Return Me.CustomVBCode
        Else
            If FromFunction Then
                If Not Me.Param1 = Nothing Then
                    If CBool(Me.Param2) Then
                        If Me.Param1.StartsWith("Me.") Then
                            Return New CodeDom.CodeSnippetExpression(Me.Param1 & ".Nodes.Add(" & Me.Tools.TransformKeyVariables(Me.Param4, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param5, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ")")
                        Else
                            Return New CodeDom.CodeSnippetExpression("Variables." & Me.Param1 & ".Nodes.Add(" & Me.Tools.TransformKeyVariables(Me.Param4, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param5, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ")")
                        End If
                    Else
                        If Me.Param1.StartsWith("Me.") Then
                            Return New CodeDom.CodeSnippetExpression(Me.Param1 & ".Nodes.Insert(" & Me.Tools.TransformKeyVariables(Me.Param3, False, False) & ", " & Me.Tools.TransformKeyVariables(Me.Param4, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param5, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ")")
                        Else
                            Return New CodeDom.CodeSnippetExpression("Variables." & Me.Param1 & ".Nodes.Insert(" & Me.Tools.TransformKeyVariables(Me.Param3, False, False) & ", " & Me.Tools.TransformKeyVariables(Me.Param4, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param5, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ")")
                        End If
                    End If
                Else
                    Return New CodeDom.CodeSnippetExpression("Variables." & Me.Param1 & ".Nodes.Add(" & Me.Tools.TransformKeyVariables(Me.Param4, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param5, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, True) & ", " & Me.Tools.TransformKeyVariables(Me.Param7, False, False) & ")")
                End If
            Else
                Return Nothing
            End If
        End If
    End Function

    Public Overrides Function ResolveError(ByVal ErrorToResole As SZVB.Projet.Erreur, ByVal e As System.EventArgs) As Boolean
        Dim result As Boolean

        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ajouter_Noeud_Racine_TreeView", GetType(Ajouter_Noeud_Racine_TreeView).Assembly)

        If ErrorToResole.Type = SZVB.Projet.Erreur.ErrorType.Building Then

            If ErrorToResole.ErrorNumber = "BC30456" Then ' Le Timer n'existe plus ou a été renommé
                ErrorToResole.ErrorExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Explain_BC30456"), Me.Param1)
                ErrorToResole.ErrorSolutionExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Solution_Explain_BC30456"))

                Return False

            Else
                Return False

            End If

        End If

        Return result
    End Function

End Class
