﻿#pragma checksum "..\..\..\TrenerView\trener.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9AD7DDDF6BEFB77FEAAA65746F50A1D473904C67"
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
    /// trener
    /// </summary>
    public partial class trener : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\TrenerView\trener.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKlient;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\TrenerView\trener.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTrening;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\TrenerView\trener.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHarmonogram;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\TrenerView\trener.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStatystyki;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\TrenerView\trener.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUstawienia;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\TrenerView\trener.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame TrenerFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Hercules;component/trenerview/trener.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TrenerView\trener.xaml"
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
            this.btnKlient = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\TrenerView\trener.xaml"
            this.btnKlient.Click += new System.Windows.RoutedEventHandler(this.BtnKlient_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnTrening = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\TrenerView\trener.xaml"
            this.btnTrening.Click += new System.Windows.RoutedEventHandler(this.BtnTrening_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnHarmonogram = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\TrenerView\trener.xaml"
            this.btnHarmonogram.Click += new System.Windows.RoutedEventHandler(this.btnHarmonogram_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnStatystyki = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\TrenerView\trener.xaml"
            this.btnStatystyki.Click += new System.Windows.RoutedEventHandler(this.btnStatystyki_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUstawienia = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\TrenerView\trener.xaml"
            this.btnUstawienia.Click += new System.Windows.RoutedEventHandler(this.btnUstawienia_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TrenerFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

