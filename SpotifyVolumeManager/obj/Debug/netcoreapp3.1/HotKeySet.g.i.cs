﻿#pragma checksum "..\..\..\HotKeySet.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E6AD2071CB01F27AB389550E20B55F483F11B68"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using AdonisUI;
using AdonisUI.Controls;
using AdonisUI.Extensions;
using SpotifyVolumeManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SpotifyVolumeManager {
    
    
    /// <summary>
    /// HotKeySet
    /// </summary>
    public partial class HotKeySet : AdonisUI.Controls.AdonisWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\HotKeySet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button infoButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\HotKeySet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem hotKeysListBoxItem;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\HotKeySet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem updatesListBoxItem;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\HotKeySet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem settingsListBoxItem;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\HotKeySet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem infoListBoxItem;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SpotifyVolumeManager;V1.0.0.0;component/hotkeyset.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HotKeySet.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.infoButton = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.hotKeysListBoxItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 77 "..\..\..\HotKeySet.xaml"
            this.hotKeysListBoxItem.Selected += new System.Windows.RoutedEventHandler(this.hotKeysListBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.updatesListBoxItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 78 "..\..\..\HotKeySet.xaml"
            this.updatesListBoxItem.Selected += new System.Windows.RoutedEventHandler(this.updatesListBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.settingsListBoxItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 79 "..\..\..\HotKeySet.xaml"
            this.settingsListBoxItem.Selected += new System.Windows.RoutedEventHandler(this.settingsListBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.infoListBoxItem = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 80 "..\..\..\HotKeySet.xaml"
            this.infoListBoxItem.Selected += new System.Windows.RoutedEventHandler(this.infoListBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

