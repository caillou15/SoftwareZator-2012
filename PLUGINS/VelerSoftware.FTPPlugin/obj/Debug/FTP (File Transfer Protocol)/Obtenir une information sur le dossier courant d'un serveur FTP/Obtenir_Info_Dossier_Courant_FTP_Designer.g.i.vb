﻿#ExternalChecksum("..\..\..\..\FTP (File Transfer Protocol)\Obtenir une information sur le dossier courant d'un serveur FTP\Obtenir_Info_Dossier_Courant_FTP_Designer.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","5C8906C72483977B1290C13CE4527DD6")
'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.17929
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Activities.Presentation
Imports System.Activities.Presentation.View
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Forms.Integration
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''Obtenir_Info_Dossier_Courant_FTP_Designer
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Obtenir_Info_Dossier_Courant_FTP_Designer
    Inherits System.Activities.Presentation.ActivityDesigner
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\FTP (File Transfer Protocol)\Obtenir une information sur le dossier courant d'un serveur FTP\Obtenir_Info_Dossier_Courant_FTP_Designer.xaml",52)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TextBlock1 As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\FTP (File Transfer Protocol)\Obtenir une information sur le dossier courant d'un serveur FTP\Obtenir_Info_Dossier_Courant_FTP_Designer.xaml",63)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Label2 As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\FTP (File Transfer Protocol)\Obtenir une information sur le dossier courant d'un serveur FTP\Obtenir_Info_Dossier_Courant_FTP_Designer.xaml",64)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ComboBox1 As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/VelerSoftware.FTPPlugin;component/ftp%20(file%20transfer%20protocol)/obtenir%20u"& _ 
                "ne%20information%20sur%20le%20dossier%20courant%20d'un%20serveur%20ftp/obtenir_i"& _ 
                "nfo_dossier_courant_ftp_designer.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\FTP (File Transfer Protocol)\Obtenir une information sur le dossier courant d'un serveur FTP\Obtenir_Info_Dossier_Courant_FTP_Designer.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.TextBlock1 = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 2) Then
            Me.Label2 = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 3) Then
            Me.ComboBox1 = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
