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
using System.Windows.Shapes;
using MySQL.Clases;
using SQLite;

namespace MySQL
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        List<Deportistas> deportistas;
        public Principal()
        {
            InitializeComponent();
            deportistas = new List<Deportistas>();
            LeerBaseDatos();
        }
        void LeerBaseDatos()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Deportistas>();
                deportistas = (conn.Table<Deportistas>().ToList()).OrderBy(c => c.Nombre).ToList();
            }
            if (deportistas != null)
            {
                lvContactos.ItemsSource = deportistas;
            }
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            MySQL.MainWindow form = new MySQL.MainWindow();
            form.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySQL.EliminarDatos form = new MySQL.EliminarDatos();
            form.ShowDialog();
        }
    }
}
