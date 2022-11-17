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

namespace Prova_Pratica_GIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void btnBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            //Quando viene premuto il pulsante "Inizia", viene creata una biblioteca sulla quale verranno poi creati i libri

            
        }

        private void btnLibro_Click(object sender, RoutedEventArgs e)
        {
            //Con questo pulsante viene creato un libro a cui vengono assegnate le caratteristiche correlate alla classe Libro
        }
    }
}
