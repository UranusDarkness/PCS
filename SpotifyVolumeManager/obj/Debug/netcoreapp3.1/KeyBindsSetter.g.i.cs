﻿#pragma checksum "..\..\..\KeyBindsSetter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92AA9E7D5D503AAECD056FB912B0570053C23277"
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
    /// KeyBindsSetter
    /// </summary>
    public partial class KeyBindsSetter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SpotifyVolumeManager.KeyBindsSetter keybindsWindow;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label volumeUpLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label volumeDownLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox volumeUpTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox volumeDownTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\KeyBindsSetter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SpotifyVolumeManager;V1.0.0.0;component/keybindssetter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\KeyBindsSetter.xaml"
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
            this.keybindsWindow = ((SpotifyVolumeManager.KeyBindsSetter)(target));
            
            #line 12 "..\..\..\KeyBindsSetter.xaml"
            this.keybindsWindow.Loaded += new System.Windows.RoutedEventHandler(this.keybindsWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.volumeUpLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.volumeDownLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.volumeUpTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\KeyBindsSetter.xaml"
            this.volumeUpTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.volumeUpTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.volumeDownTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\KeyBindsSetter.xaml"
            this.volumeDownTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.volumeDownTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\KeyBindsSetter.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\KeyBindsSetter.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

