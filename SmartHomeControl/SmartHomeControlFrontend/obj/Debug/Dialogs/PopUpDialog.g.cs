﻿#pragma checksum "..\..\..\Dialogs\PopUpDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7D177245553C6AD1D5B0E750099144AC075650A5ACD8C546A2CAC4B999608F4"
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
    /// PopUpDialog
    /// </summary>
    public partial class PopUpDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Dialogs\PopUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border windowBorder;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Dialogs\PopUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform windowScale;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Dialogs\PopUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_windowTitle;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Dialogs\PopUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_symbol;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Dialogs\PopUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_message;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Dialogs\PopUpDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_no;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Dialogs\PopUpDialog.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SmartHomeControlFrontend;component/dialogs/popupdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dialogs\PopUpDialog.xaml"
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
            
            #line 47 "..\..\..\Dialogs\PopUpDialog.xaml"
            this.txt_windowTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.txt_windowTitle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.img_symbol = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.txt_message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btn_no = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\Dialogs\PopUpDialog.xaml"
            this.btn_no.Click += new System.Windows.RoutedEventHandler(this.btn_no_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_yes = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Dialogs\PopUpDialog.xaml"
            this.btn_yes.Click += new System.Windows.RoutedEventHandler(this.btn_yes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
