using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;

namespace TestDB
{

    public struct Kunde
    {
        public int ID;
        public string Vorname;
        public string Name;
        public int Geburtsdatum;
        public string Telefonnummer;
        public string Faxnummer;
        public string Emailadresse;
        public int PLZ;
        public string Ort;
        public string Land;
        public string Sprache;
        public string Straße;
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        /*   private void Window_Loaded_1(object sender, RoutedEventArgs e)
           {

                 TestDB.KundenDBAccessDataSet kundenDBAccessDataSet = ((TestDB.KundenDBAccessDataSet)(this.FindResource("kundenDBAccessDataSet")));
        // Lädt Daten in Tabelle "KundenDB". Sie können diesen Code nach Bedarf ändern.
        TestDB.KundenDBAccessDataSetTableAdapters.KundenDBTableAdapter kundenDBAccessDataSetKundenDBTableAdapter = new TestDB.KundenDBAccessDataSetTableAdapters.KundenDBTableAdapter();
        kundenDBAccessDataSetKundenDBTableAdapter.Fill(kundenDBAccessDataSet.KundenDB);
        System.Windows.Data.CollectionViewSource kundenDBViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("kundenDBViewSource")));
        kundenDBViewSource.View.MoveCurrentToFirst(); 
           }

       */


        private void B_Neu(object sender, RoutedEventArgs e)
        {

        }

        private void B_Speichern(object sender, RoutedEventArgs e)
        {

        }

        private void B_Loeschen(object sender, RoutedEventArgs e)
        {

        }

        private void B_Schliessen(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_Datenbank(object sender, SelectionChangedEventArgs e)
        {

        }

        private void KundenDBDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void B_Laden(object sender, RoutedEventArgs e)
        {
            var source = new BindingSource();
            List<Kunde> list = new List<Kunde> { new Kunde("fff", "b"), new Kunde("c", "d") };
            source.DataSource = list;
            grid.DataSource = source;

/*
            Console.WriteLine(textBoxPLZ);

            kundenDB[i].kundenNr = Convert.ToInt32(textBoxKundenNr.Text);
            kundenDB[i].vorname = textBoxVorName.Text;
            kundenDB[i].nachname = textBoxNachName.Text;
            kundenDB[i].plz = Convert.ToInt32(textBoxPLZ.Text);
            kundenDB[i].ort = textBoxOrt.Text;
            buttonSpeichern.Enabled = false;

*/

        }
    }
}
