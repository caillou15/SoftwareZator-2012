﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supprimer_Cle_Registrer_Form
    Inherits VelerSoftware.Plugins3.ActionForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supprimer_Cle_Registrer_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Argument_ActionTextBox1 = New VelerSoftware.Plugins3.ActionTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Center_Panel.SuspendLayout()
        Me.Controls_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Center_Panel
        '
        resources.ApplyResources(Me.Center_Panel, "Center_Panel")
        '
        'Controls_Panel
        '
        Me.Controls_Panel.Controls.Add(Me.ComboBox1)
        Me.Controls_Panel.Controls.Add(Me.Argument_ActionTextBox1)
        Me.Controls_Panel.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Controls_Panel, "Controls_Panel")
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Argument_ActionTextBox1
        '
        Me.Argument_ActionTextBox1.IsReadOnly = False
        resources.ApplyResources(Me.Argument_ActionTextBox1, "Argument_ActionTextBox1")
        Me.Argument_ActionTextBox1.Multiline = False
        Me.Argument_ActionTextBox1.Name = "Argument_ActionTextBox1"
        Me.Argument_ActionTextBox1.SpellCheck = False
        Me.Argument_ActionTextBox1.Tools = Nothing
        Me.Argument_ActionTextBox1.WordWrap = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4")})
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'Supprimer_Cle_Registrer_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Icon_Windows = Global.VelerSoftware.GeneralPlugin.My.Resources.Resources.supprimer_valeur_registre
        Me.Name = "Supprimer_Cle_Registrer_Form"
        Me.Title = "Obtenir la version de Windows"
        Me.Center_Panel.ResumeLayout(False)
        Me.Controls_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Argument_ActionTextBox1 As VelerSoftware.Plugins3.ActionTextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
