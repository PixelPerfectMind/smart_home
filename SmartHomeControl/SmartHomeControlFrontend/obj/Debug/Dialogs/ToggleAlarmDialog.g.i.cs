﻿#pragma checksum "..\..\..\Dialogs\ToggleAlarmDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E9C9D332F96930E7C03F73F38B0F272E485473FF5DE1787E5D8B91FB13190A63"
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
    /// ToggleAlarmDialog
    /// </summary>
    public partial class ToggleAlarmDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border windowBorder;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform windowScale;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_windowTitle;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_no;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_yes;
        
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
            System.Uri resourceLocater = new System.Uri("/SmartHomeControlFrontend;component/dialogs/togglealarmdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
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
            
            #line 48 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
            this.txt_windowTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.txt_windowTitle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_no = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
            this.btn_no.Click += new System.Windows.RoutedEventHandler(this.btn_no_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_yes = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\Dialogs\ToggleAlarmDialog.xaml"
            this.btn_yes.Click += new System.Windows.RoutedEventHandler(this.btn_yes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
