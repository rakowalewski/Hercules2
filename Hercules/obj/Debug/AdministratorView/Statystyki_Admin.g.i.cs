#pragma checksum "..\..\..\AdministratorView\Statystyki_Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "362F7AF96F57ED2153F235D0A95E56DD0C0EC903"
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


namespace Hercules
{


    /// <summary>
    /// Statystyki_Admin
    /// </summary>
    public partial class Statystyki_Admin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 19 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TrenerCB;

#line default
#line hidden


#line 21 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RokRokTB;

#line default
#line hidden


#line 22 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PobierzMiesiacBTN;

#line default
#line hidden


#line 23 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PobierzRokBTN;

#line default
#line hidden


#line 26 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZarobkiMiesiacTB;

#line default
#line hidden


#line 27 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZarobkiRokTB;

#line default
#line hidden


#line 32 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker poczatkowaDP;

#line default
#line hidden


#line 33 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker koncowaDP;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hercules;component/administratorview/statystyki_admin.xaml", System.UriKind.Relative);

#line 1 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.StatystykiAdminPage = ((Hercules.Statystyki_Admin)(target));
                    return;
                case 2:
                    this.TrenerCB = ((System.Windows.Controls.ComboBox)(target));

#line 19 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
                    this.TrenerCB.Loaded += new System.Windows.RoutedEventHandler(this.ComboBox_Loaded);

#line default
#line hidden
                    return;
                case 3:
                    this.RokRokTB = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.PobierzMiesiacBTN = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
                    this.PobierzMiesiacBTN.Click += new System.Windows.RoutedEventHandler(this.PobierzMiesiacBTN_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.PobierzRokBTN = ((System.Windows.Controls.Button)(target));
                    return;
                case 6:
                    this.ZarobkiMiesiacTB = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.ZarobkiRokTB = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.poczatkowaDP = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 9:
                    this.koncowaDP = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 10:

#line 41 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
                    ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);

#line default
#line hidden
                    return;
                case 11:

#line 44 "..\..\..\AdministratorView\Statystyki_Admin.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Page StatystykiAdminPage;
    }
}

