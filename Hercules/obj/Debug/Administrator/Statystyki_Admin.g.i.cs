﻿#pragma checksum "..\..\..\Administrator\Statystyki_Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924753539351D309AD8DFBA9651CF802087FB778"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Hercules;
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


namespace Hercules {
    
    
    /// <summary>
    /// Statystyki_Admin
    /// </summary>
    public partial class Statystyki_Admin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Hercules.Statystyki_Admin StatystykiAdminPage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TrenerCB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MiesiacCB;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RokMiesiacTB;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RokRokTB;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PobierzMiesiacBTN;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PobierzRokBTN;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZarobkiMiesiacTB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Administrator\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZarobkiRokTB;
        
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
            System.Uri resourceLocater = new System.Uri("/Hercules;component/administrator/statystyki_admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Administrator\Statystyki_Admin.xaml"
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
            this.StatystykiAdminPage = ((Hercules.Statystyki_Admin)(target));
            return;
            case 2:
            this.TrenerCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\Administrator\Statystyki_Admin.xaml"
            this.TrenerCB.Loaded += new System.Windows.RoutedEventHandler(this.ComboBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MiesiacCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\Administrator\Statystyki_Admin.xaml"
            this.MiesiacCB.Loaded += new System.Windows.RoutedEventHandler(this.MiesiacCB_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RokMiesiacTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RokRokTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PobierzMiesiacBTN = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.PobierzRokBTN = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.ZarobkiMiesiacTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ZarobkiRokTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 41 "..\..\..\Administrator\Statystyki_Admin.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

