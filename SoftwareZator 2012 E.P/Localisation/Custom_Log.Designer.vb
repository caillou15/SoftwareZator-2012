﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.269
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace SoftwareZator.Custom_Log
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Custom_Log
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SoftwareZator.Custom_Log", GetType(Custom_Log).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La référence &apos;{0}&apos; n&apos;a pas pu être ajouté au projet &apos;{1}&apos; pour une raison inconnue..
        '''</summary>
        Friend Shared ReadOnly Property Ajout_Reference_Echec() As String
            Get
                Return ResourceManager.GetString("Ajout_Reference_Echec", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La référence &apos;{0}&apos; a été ajouté au projet &apos;{1}&apos; avec succès..
        '''</summary>
        Friend Shared ReadOnly Property Ajout_Reference_Succes() As String
            Get
                Return ResourceManager.GetString("Ajout_Reference_Succes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Les fichiers de type &apos;{0}&apos; ont été associé au logiciel..
        '''</summary>
        Friend Shared ReadOnly Property Association_Fichier() As String
            Get
                Return ResourceManager.GetString("Association_Fichier", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Aucun plugin n&apos;a été chargé ou trouvé..
        '''</summary>
        Friend Shared ReadOnly Property Aucun_Plugin_Chargé() As String
            Get
                Return ResourceManager.GetString("Aucun_Plugin_Chargé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement des plugins....
        '''</summary>
        Friend Shared ReadOnly Property Chargement_Plugins() As String
            Get
                Return ResourceManager.GetString("Chargement_Plugins", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement des plugins terminé..
        '''</summary>
        Friend Shared ReadOnly Property Chargement_Plugins_Terminé() As String
            Get
                Return ResourceManager.GetString("Chargement_Plugins_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement de la Boîte à outils pour l&apos;éditeur de fonctions....
        '''</summary>
        Friend Shared ReadOnly Property Chargement_Toolbox_Fonctions() As String
            Get
                Return ResourceManager.GetString("Chargement_Toolbox_Fonctions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La Boîte à outils pour l&apos;éditeur de fonctions a été chargé..
        '''</summary>
        Friend Shared ReadOnly Property Chargement_Toolbox_Fonctions1() As String
            Get
                Return ResourceManager.GetString("Chargement_Toolbox_Fonctions1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement de la Boîte à outils pour le concepteur de fenêtre....
        '''</summary>
        Friend Shared ReadOnly Property Chargement_Toolbox_Windows_Designer() As String
            Get
                Return ResourceManager.GetString("Chargement_Toolbox_Windows_Designer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La Boîte à outils pour le concepteur de fenêtre a été chargé..
        '''</summary>
        Friend Shared ReadOnly Property Chargement_Toolbox_Windows_Designer1() As String
            Get
                Return ResourceManager.GetString("Chargement_Toolbox_Windows_Designer1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrement du projet &apos;{0}&apos; en cours....
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Projet() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Projet", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;enregistrement du projet &apos;{0}&apos; a été annulé..
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Projet_Annulé() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Projet_Annulé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrement du projet &apos;{0}&apos; terminé..
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Projet_Terminé() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Projet_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrement de la solution &apos;{0}&apos; en cours....
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Solution() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Solution", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;enregistrement de la solution &apos;{0}&apos; a été annulé..
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Solution_Annulé() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Solution_Annulé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrement de la solution &apos;{0}&apos; terminé..
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Solution_Terminé() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Solution_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrement des statistiques du projet &apos;{0}&apos; en cours....
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Stat() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Stat", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;enregistrement des statistiques du projet &apos;{0}&apos; a été annulé..
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Stat_Annulé() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Stat_Annulé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrement des statistiques du projet &apos;{0}&apos; terminé..
        '''</summary>
        Friend Shared ReadOnly Property Enregistrement_Stat_Terminé() As String
            Get
                Return ResourceManager.GetString("Enregistrement_Stat_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Fermeture du document &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property Fermeture_Document() As String
            Get
                Return ResourceManager.GetString("Fermeture_Document", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Fermeture de la page de démarrage..
        '''</summary>
        Friend Shared ReadOnly Property Fermeture_Page_Demarrage() As String
            Get
                Return ResourceManager.GetString("Fermeture_Page_Demarrage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération de l&apos;action &apos;{0}&apos; trouvé dans la fonction &apos;{1}&apos; du fichier &apos;{2}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Action() As String
            Get
                Return ResourceManager.GetString("Generation_Action", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ajout du paramètre &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Ajout_Paramètre() As String
            Get
                Return ResourceManager.GetString("Generation_Ajout_Paramètre", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement du fichier &apos;{0}&apos; en mémoire....
        '''</summary>
        Friend Shared ReadOnly Property Generation_Chargement_Fichier() As String
            Get
                Return ResourceManager.GetString("Generation_Chargement_Fichier", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement du fichier &apos;{0}&apos; terminé..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Chargement_Fichier_Terminé() As String
            Get
                Return ResourceManager.GetString("Generation_Chargement_Fichier_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement de la séquence d&apos;actions numéro {0}.
        '''</summary>
        Friend Shared ReadOnly Property Generation_Chargement_Fonction() As String
            Get
                Return ResourceManager.GetString("Generation_Chargement_Fonction", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement de la séquence d&apos;actions terminé..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Chargement_Fonction_Terminer() As String
            Get
                Return ResourceManager.GetString("Generation_Chargement_Fonction_Terminer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération des codes du document &apos;{0}&apos; en cours....
        '''</summary>
        Friend Shared ReadOnly Property Generation_Code() As String
            Get
                Return ResourceManager.GetString("Generation_Code", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération des codes du document &apos;{0}&apos; terminé..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Code_Terminé() As String
            Get
                Return ResourceManager.GetString("Generation_Code_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Compilation du code....
        '''</summary>
        Friend Shared ReadOnly Property Generation_Compile() As String
            Get
                Return ResourceManager.GetString("Generation_Compile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à ===== La compilation du projet a échoué. =====.
        '''</summary>
        Friend Shared ReadOnly Property Generation_Compile_Echec() As String
            Get
                Return ResourceManager.GetString("Generation_Compile_Echec", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à ===== La compilation du projet s&apos;est terminé avec succès. =====.
        '''</summary>
        Friend Shared ReadOnly Property Generation_Compile_Succès() As String
            Get
                Return ResourceManager.GetString("Generation_Compile_Succès", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Compilateur configuré avec succès..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Config() As String
            Get
                Return ResourceManager.GetString("Generation_Config", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Création du dossier de génération à l&apos;emplacement &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Creation_Dossier() As String
            Get
                Return ResourceManager.GetString("Generation_Creation_Dossier", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Début de la génération du projet &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Debut() As String
            Get
                Return ResourceManager.GetString("Generation_Debut", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération des évènements d&apos;application en cours....
        '''</summary>
        Friend Shared ReadOnly Property Generation_Evenement_Application() As String
            Get
                Return ResourceManager.GetString("Generation_Evenement_Application", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération des évènements d&apos;application terminé..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Evenement_Application_Terminé() As String
            Get
                Return ResourceManager.GetString("Generation_Evenement_Application_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Initialisation du système CodeDom en cours....
        '''</summary>
        Friend Shared ReadOnly Property Generation_Initialisation_CodeDom() As String
            Get
                Return ResourceManager.GetString("Generation_Initialisation_CodeDom", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Initialisation du système CodeDom terminé..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Initialisation_CodeDom_Terminé() As String
            Get
                Return ResourceManager.GetString("Generation_Initialisation_CodeDom_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Choix de la génération : Debug.
        '''</summary>
        Friend Shared ReadOnly Property Generation_Mode_Debug() As String
            Get
                Return ResourceManager.GetString("Generation_Mode_Debug", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Choix de la génération : Release.
        '''</summary>
        Friend Shared ReadOnly Property Generation_Mode_Normal() As String
            Get
                Return ResourceManager.GetString("Generation_Mode_Normal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Obfuscation du projet : {0}.
        '''</summary>
        Friend Shared ReadOnly Property Generation_Obfuscation() As String
            Get
                Return ResourceManager.GetString("Generation_Obfuscation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération des ressources en cours....
        '''</summary>
        Friend Shared ReadOnly Property Generation_Resx() As String
            Get
                Return ResourceManager.GetString("Generation_Resx", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération du fichier de ressources &apos;{0}&apos; en cours....
        '''</summary>
        Friend Shared ReadOnly Property Generation_Resx_Fichier() As String
            Get
                Return ResourceManager.GetString("Generation_Resx_Fichier", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération du fichier de ressources &apos;{0}&apos; terminé..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Resx_Fichier_Terminer() As String
            Get
                Return ResourceManager.GetString("Generation_Resx_Fichier_Terminer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Génération des ressources terminé..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Resx_Terminé() As String
            Get
                Return ResourceManager.GetString("Generation_Resx_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Début de la génération de la solution &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Solution_Debut() As String
            Get
                Return ResourceManager.GetString("Generation_Solution_Debut", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Suppression des données temporaires inutiles..
        '''</summary>
        Friend Shared ReadOnly Property Generation_Suppression_Temp() As String
            Get
                Return ResourceManager.GetString("Generation_Suppression_Temp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La solution a été générée en {0}.
        '''</summary>
        Friend Shared ReadOnly Property Generation_Temp() As String
            Get
                Return ResourceManager.GetString("Generation_Temp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La fenêtre de démarrage ou l&apos;écran de démarrage ne peuvent pas être un Contrôle Utilisateur.
        '''</summary>
        Friend Shared ReadOnly Property Generation_UserControl() As String
            Get
                Return ResourceManager.GetString("Generation_UserControl", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Enregistrement du code source..
        '''</summary>
        Friend Shared ReadOnly Property Generation_VB() As String
            Get
                Return ResourceManager.GetString("Generation_VB", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Création d&apos;un nouveau document nommé &apos;{0}&apos; dans le projet &apos;{1}&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Nouveau_Document() As String
            Get
                Return ResourceManager.GetString("Nouveau_Document", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le document &apos;{0}&apos; a été créé avec succès..
        '''</summary>
        Friend Shared ReadOnly Property Nouveau_Document_Terminé() As String
            Get
                Return ResourceManager.GetString("Nouveau_Document_Terminé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à ===== L&apos;obfuscation de la solution a échoué. =====.
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Echec() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Echec", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;obfuscation a rencontrée une erreur : {0}.
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Err() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Err", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le fichier &apos;{0}&apos; est introuvable sur le disque dur..
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Fichier_Introuvable() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Fichier_Introuvable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Obfuscation en cours : {0}.
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Message() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Déplacement du fichier &apos;{0}&apos; vers le dossier de génération du projet principal de la solution....
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Move() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Move", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Obfuscation en cours....
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Started() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Started", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Initialisation de l&apos;obfuscation en cours....
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Starting() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Starting", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à ===== L&apos;obfuscation de la solution s&apos;est terminé avec succès. =====.
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Succès() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Succès", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;encryptage du code a été effectué en {0}.
        '''</summary>
        Friend Shared ReadOnly Property Obfuscation_Temp() As String
            Get
                Return ResourceManager.GetString("Obfuscation_Temp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du document &apos;{0}&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Document() As String
            Get
                Return ResourceManager.GetString("Ouverture_Document", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture de la page de démarrage....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Page_Demarrage() As String
            Get
                Return ResourceManager.GetString("Ouverture_Page_Demarrage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Bases de données&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_DataBase() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_DataBase", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Débogage&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Debogage() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Debogage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Erreurs de génération&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Erreurs() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Erreurs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Explorateur de solutions&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Explorateur() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Explorateur", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Aide rapide&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Help() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Help", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Propriétés&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Propriété() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Propriété", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Sortie&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Sortie() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Sortie", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Boîte à outils&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Toolbox() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Toolbox", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du panneau &apos;Reconnaissance vocale&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Panneau_Vocal() As String
            Get
                Return ResourceManager.GetString("Ouverture_Panneau_Vocal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture des paramètres du projet &apos;{0}&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Parametre() As String
            Get
                Return ResourceManager.GetString("Ouverture_Parametre", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture du projet &apos;{0}&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Projet() As String
            Get
                Return ResourceManager.GetString("Ouverture_Projet", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture de la solution &apos;{0}&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Solution() As String
            Get
                Return ResourceManager.GetString("Ouverture_Solution", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ouverture des statistiques du projet &apos;{0}&apos;....
        '''</summary>
        Friend Shared ReadOnly Property Ouverture_Stat() As String
            Get
                Return ResourceManager.GetString("Ouverture_Stat", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le plugin &apos;{0}, Version={1}&apos; a été chargé avec succès..
        '''</summary>
        Friend Shared ReadOnly Property Plugin_Chargé() As String
            Get
                Return ResourceManager.GetString("Plugin_Chargé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le projet &apos;{0}&apos; a été chargé..
        '''</summary>
        Friend Shared ReadOnly Property Projet_Chargé() As String
            Get
                Return ResourceManager.GetString("Projet_Chargé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le projet &apos;{0}&apos; a été chargé dans l&apos;Explorateur de solutions..
        '''</summary>
        Friend Shared ReadOnly Property Projet_Chargé_Explorateur() As String
            Get
                Return ResourceManager.GetString("Projet_Chargé_Explorateur", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le projet n&apos;a pas été chargé car il est incompatible avec ce logiciel..
        '''</summary>
        Friend Shared ReadOnly Property Projet_Incompatible() As String
            Get
                Return ResourceManager.GetString("Projet_Incompatible", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le projet &apos;{0}&apos; n&apos;a pas été chargé car le fichier &apos;{1}&apos; est introuvable..
        '''</summary>
        Friend Shared ReadOnly Property Projet_Introuvable() As String
            Get
                Return ResourceManager.GetString("Projet_Introuvable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La solution &apos;{0}&apos; a été chargé..
        '''</summary>
        Friend Shared ReadOnly Property Solution_Chargé() As String
            Get
                Return ResourceManager.GetString("Solution_Chargé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La solution &apos;{0}&apos; a été fermé..
        '''</summary>
        Friend Shared ReadOnly Property Solution_Fermé() As String
            Get
                Return ResourceManager.GetString("Solution_Fermé", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à La solution n&apos;a pu être chargé correctement car elle est incompatible avec ce logiciel..
        '''</summary>
        Friend Shared ReadOnly Property Solution_Incompatible() As String
            Get
                Return ResourceManager.GetString("Solution_Incompatible", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;authenticité du logiciel a été vérifié..
        '''</summary>
        Friend Shared ReadOnly Property Utilisateur_Banni() As String
            Get
                Return ResourceManager.GetString("Utilisateur_Banni", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Validation du projet &apos;{0}&apos; en cours....
        '''</summary>
        Friend Shared ReadOnly Property Validation_Projet() As String
            Get
                Return ResourceManager.GetString("Validation_Projet", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Validation du projet &apos;{0}&apos; terminé..
        '''</summary>
        Friend Shared ReadOnly Property Validation_Projet_Terminé() As String
            Get
                Return ResourceManager.GetString("Validation_Projet_Terminé", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
