﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incrementer_Date_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Incrementer_Date_Form))
        Me.Boutons_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValueEdit2 = New VelerSoftware.Plugins3.ValueEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ActionTextBox1 = New VelerSoftware.Plugins3.ActionTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Controls_Panel.Controls.Add(Me.Label4)
        Me.Controls_Panel.Controls.Add(Me.Label2)
        Me.Controls_Panel.Controls.Add(Me.ActionTextBox1)
        Me.Controls_Panel.Controls.Add(Me.ValueEdit2)
        Me.Controls_Panel.Controls.Add(Me.Label3)
        Me.Controls_Panel.Controls.Add(Me.Boutons_ComboBox)
        Me.Controls_Panel.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Controls_Panel, "Controls_Panel")
        '
        'Boutons_ComboBox
        '
        Me.Boutons_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.Boutons_ComboBox, "Boutons_ComboBox")
        Me.Boutons_ComboBox.FormattingEnabled = True
        Me.Boutons_ComboBox.Items.AddRange(New Object() {resources.GetString("Boutons_ComboBox.Items"), resources.GetString("Boutons_ComboBox.Items1"), resources.GetString("Boutons_ComboBox.Items2"), resources.GetString("Boutons_ComboBox.Items3"), resources.GetString("Boutons_ComboBox.Items4"), resources.GetString("Boutons_ComboBox.Items5"), resources.GetString("Boutons_ComboBox.Items6"), resources.GetString("Boutons_ComboBox.Items7"), resources.GetString("Boutons_ComboBox.Items8"), resources.GetString("Boutons_ComboBox.Items9")})
        Me.Boutons_ComboBox.Name = "Boutons_ComboBox"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ValueEdit2
        '
        Me.ValueEdit2.BackColor = System.Drawing.Color.Transparent
        Me.ValueEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValueEdit2.ColorButtonVisible = False
        Me.ValueEdit2.Editor = VelerSoftware.Plugins3.ValueEdit.ValueType.Variables
        resources.ApplyResources(Me.ValueEdit2, "ValueEdit2")
        Me.ValueEdit2.Name = "ValueEdit2"
        Me.ValueEdit2.NumberButtonVisible = False
        Me.ValueEdit2.OtherButtonVisible = True
        Me.ValueEdit2.ResourcesButtonVisible = False
        Me.ValueEdit2.TextButtonVisible = False
        Me.ValueEdit2.Tools = Nothing
        Me.ValueEdit2.TrueFalseButtonVisible = False
        Me.ValueEdit2.VariablesButtonVisible = True
        Me.ValueEdit2.VBNetButtonVisible = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'ActionTextBox1
        '
        resources.ApplyResources(Me.ActionTextBox1, "ActionTextBox1")
        Me.ActionTextBox1.IsReadOnly = False
        Me.ActionTextBox1.Multiline = False
        Me.ActionTextBox1.Name = "ActionTextBox1"
        Me.ActionTextBox1.Tools = Nothing
        Me.ActionTextBox1.WordWrap = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Name = "ComboBox1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Incrementer_Date_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Icon_Windows = Global.VelerSoftware.GeneralPlugin.My.Resources.Resources.Incrementer_Date
        Me.Name = "Incrementer_Date_Form"
        Me.Title = "Ajouter une date à un Calendrier"
        Me.Center_Panel.ResumeLayout(False)
        Me.Center_Panel.PerformLayout()
        Me.Controls_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Boutons_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ValueEdit2 As VelerSoftware.Plugins3.ValueEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ActionTextBox1 As VelerSoftware.Plugins3.ActionTextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
