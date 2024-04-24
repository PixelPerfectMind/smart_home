﻿#pragma checksum "..\..\..\Dialogs\Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8132CA29260462885A56AFBC61AA35B7DD6511745E52D3C3F6276852495FF09D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace SmartHomeControlFrontend.Dialogs {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border windowBorder;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform windowScale;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_windowTitle;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ell_closeWindow;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ell_minimizeWindow;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_brokerAddress;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_brokerPort;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_subscribeTopic;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Dialogs\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SmartHomeControlFrontend;component/dialogs/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\Settings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.windowBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.windowScale = ((System.Windows.Media.ScaleTransform)(target));
            return;
            case 3:
            this.txt_windowTitle = ((System.Windows.Controls.TextBlock)(target));
            
            #line 48 "..\..\..\Dialogs\Settings.xaml"
            this.txt_windowTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.txt_windowTitle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ell_closeWindow = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 57 "..\..\..\Dialogs\Settings.xaml"
            this.ell_closeWindow.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ell_closeWindow_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ell_minimizeWindow = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 77 "..\..\..\Dialogs\Settings.xaml"
            this.ell_minimizeWindow.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ell_minimizeWindow_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_brokerAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_brokerPort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txt_subscribeTopic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btn_save = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\Dialogs\Settings.xaml"
            this.btn_save.Click += new System.Windows.RoutedEventHandler(this.btn_save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

