#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6009E63777DF31720E7BBAA4F7EEA2676F98D9753950C3F4816E3FD11898D3E6"
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
using TestDB;


namespace TestDB
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid kundenDBDataGrid;

#line default
#line hidden


#line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn iDColumn;

#line default
#line hidden


#line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn vornameColumn;

#line default
#line hidden


#line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nachnameColumn;

#line default
#line hidden


#line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn geburtsdatumColumn;

#line default
#line hidden


#line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn telefonnummerColumn;

#line default
#line hidden


#line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn faxnummerColumn;

#line default
#line hidden


#line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn _E_MailadresseColumn;

#line default
#line hidden


#line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn pLZColumn;

#line default
#line hidden


#line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn straßeColumn;

#line default
#line hidden


#line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ortColumn;

#line default
#line hidden


#line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn landColumn;

#line default
#line hidden


#line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn spracheColumn;

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
            System.Uri resourceLocater = new System.Uri("/TestDB;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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

#line 8 "..\..\MainWindow.xaml"
                    ((TestDB.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);

#line default
#line hidden
                    return;
                case 2:

#line 43 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Laden);

#line default
#line hidden
                    return;
                case 3:

#line 44 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Neu);

#line default
#line hidden
                    return;
                case 4:

#line 45 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Speichern);

#line default
#line hidden
                    return;
                case 5:

#line 46 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Loeschen);

#line default
#line hidden
                    return;
                case 6:

#line 47 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Schliessen);

#line default
#line hidden
                    return;
                case 7:
                    this.kundenDBDataGrid = ((System.Windows.Controls.DataGrid)(target));

#line 49 "..\..\MainWindow.xaml"
                    this.kundenDBDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.KundenDBDataGrid_SelectionChanged);

#line default
#line hidden
                    return;
                case 8:
                    this.iDColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 9:
                    this.vornameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 10:
                    this.nachnameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 11:
                    this.geburtsdatumColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
                    return;
                case 12:
                    this.telefonnummerColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 13:
                    this.faxnummerColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 14:
                    this._E_MailadresseColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 15:
                    this.pLZColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 16:
                    this.straßeColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 17:
                    this.ortColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 18:
                    this.landColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
                case 19:
                    this.spracheColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label LName;
        internal System.Windows.Controls.TextBlock TBName;
        internal System.Windows.Controls.Label LVorname;
        internal System.Windows.Controls.TextBlock TBVorname;
        internal System.Windows.Controls.Label LStraße;
        internal System.Windows.Controls.TextBlock TBStraße;
        internal System.Windows.Controls.Label LGeburtsdatum;
        internal System.Windows.Controls.TextBlock TBGeburtsdatum;
        internal System.Windows.Controls.Label LTelefonnummer;
        internal System.Windows.Controls.TextBlock TBTelefonnummer;
        internal System.Windows.Controls.Label LFaxnummer;
        internal System.Windows.Controls.TextBlock TBFaxnummer;
        internal System.Windows.Controls.Label LEmailadresse;
        internal System.Windows.Controls.TextBlock TBEmailadresse;
        internal System.Windows.Controls.Label LPLZ;
        internal System.Windows.Controls.TextBlock TBPLZ;
        internal System.Windows.Controls.Label LOrt;
        internal System.Windows.Controls.TextBlock TBOrt;
        internal System.Windows.Controls.Label LLand;
        internal System.Windows.Controls.TextBlock TBLand;
        internal System.Windows.Controls.Label LSprache;
        internal System.Windows.Controls.TextBlock TBSprache;
        internal System.Windows.Controls.Label LID;
        internal System.Windows.Controls.TextBlock TBID;
        internal System.Windows.Controls.Button Button_Laden;
        internal System.Windows.Controls.Button Button_Neu;
        internal System.Windows.Controls.Button Button_Speichern;
        internal System.Windows.Controls.Button Button_Loeschen;
        internal System.Windows.Controls.Button Button_Schließen;
    }
}
