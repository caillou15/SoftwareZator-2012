﻿<System.ComponentModel.Designer(GetType(VelerSoftware.GeneralPlugin.Ouvrir_Fichier_Serialiser_Designer))> _
Public Class Ouvrir_Fichier_Serialiser
    Inherits VelerSoftware.Plugins3.Action

    Public Sub New()
        ' Initialisation de la langue et des ressources
        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ouvrir_Fichier_Serialiser", GetType(Ouvrir_Fichier_Serialiser).Assembly)

        With Me
            .DisplayName = RM.GetString("DisplayName")
            .Description = RM.GetString("Description")
            .Category = RM.GetString("Category")
            .ToolBoxImage = My.Resources.ouvrir_fichier_serialiser
            .CompatibleClass = False
            .CompatibleFonctions = True
            .FileHelp = RM.GetString("Help_File")

            .Voice_Recognition_Dictionary.Add(RM.GetString("Dictionary1"))
            .Voice_Recognition_Dictionary.Add(RM.GetString("Dictionary2"))
            .Voice_Recognition_Dictionary.Add(RM.GetString("Dictionary3"))

            .ClassCode = "VelerSoftware.GeneralPlugin.Serialisation.vb"
        End With
    End Sub

    Public Overrides Function Main() As Boolean
        ' Initialisation de la langue et des ressources
        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ouvrir_Fichier_Serialiser", GetType(Ouvrir_Fichier_Serialiser).Assembly)
        Using frm As New Ouvrir_Fichier_Serialiser_Form
            frm.Tools = Me.Tools
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.UseCustomVBCode = frm.CodeEditor_Used
                Me.CustomVBCode = New CodeDom.CodeSnippetStatement(frm.CodeEditor_Text)
                Me.Param1 = frm.Param1
                Me.Param2 = frm.Param2

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
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ouvrir_Fichier_Serialiser", GetType(Ouvrir_Fichier_Serialiser).Assembly)
        Using frm As New Ouvrir_Fichier_Serialiser_Form
            frm.Param1 = Me.Param1
            frm.Param2 = Me.Param2
            frm.CodeEditor_Shown = Me.UseCustomVBCode
            frm.CodeEditor_Used = Me.UseCustomVBCode
            frm.Tools = Me.Tools

            Dim sourceWriter As New IO.StringWriter()
            If Not Me.CustomVBCode Is Nothing Then CodeDom.Compiler.CodeDomProvider.CreateProvider("VB").GenerateCodeFromStatement(Me.CustomVBCode, sourceWriter, New CodeDom.Compiler.CodeGeneratorOptions())
            sourceWriter.Close()
            frm.CodeEditor_Text = sourceWriter.ToString

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.UseCustomVBCode = frm.CodeEditor_Used
                Me.CustomVBCode = New CodeDom.CodeSnippetStatement(frm.CodeEditor_Text)
                Me.Param1 = frm.Param1
                Me.Param2 = frm.Param2
                
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
                Dim Fonction As New CodeDom.CodeMethodInvokeExpression(New CodeDom.CodeTypeReferenceExpression("VelerSoftware_GeneralPlugin"), "Deserialize", New CodeDom.CodeSnippetExpression(Me.Tools.TransformKeyVariables(Me.Param1, True)))
                Return New CodeDom.CodeAssignStatement(New CodeDom.CodeVariableReferenceExpression(Me.Param2), Fonction)
            Else
                Return Nothing
            End If
        End If
    End Function


    Public Overrides Function ResolveError(ByVal ErrorToResole As SZVB.Projet.Erreur, ByVal e As System.EventArgs) As Boolean
        Dim result As Boolean
        Dim i_progress, i2_progress As Integer
        i_progress = 0
        i2_progress = 0

        System.Threading.Thread.CurrentThread.CurrentUICulture = VelerSoftware.Plugins3.CurrentCulture
        RM = New System.Resources.ResourceManager("VelerSoftware.GeneralPlugin.Ouvrir_Fichier_Serialiser", GetType(Ouvrir_Fichier_Serialiser).Assembly)

        If ErrorToResole.Type = SZVB.Projet.Erreur.ErrorType.Building Then

            If ErrorToResole.ErrorNumber = "BC30452" Then ' Une variable tableau a été utilisé dans le titre ou message

                ErrorToResole.ErrorExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Explain_BC30452"))
                ErrorToResole.ErrorSolutionExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Solution_Explain_BC30452"))
                Return False

            ElseIf ErrorToResole.ErrorNumber = "BC32017" Then ' La variable recevant le résultat n'existe plus
                ErrorToResole.ErrorExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Explain_BC32017"))
                ErrorToResole.ErrorSolutionExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Solution_Explain_BC32017"))

                Return False

            ElseIf ErrorToResole.ErrorNumber = "BC30311" Then ' La variable recevant le résultat est devenu une variable tableau 
                ErrorToResole.ErrorExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Explain_BC30311"), Me.Param2)
                ErrorToResole.ErrorSolutionExplain = String.Format(System.Globalization.CultureInfo.InvariantCulture, RM.GetString("Error_Solution_Explain_BC30311"))

                Return False

            Else
                Return False

            End If

        End If

        Return result
    End Function

End Class
