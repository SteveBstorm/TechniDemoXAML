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

namespace DemoXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Personne> Liste{ get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Liste = new List<Personne>();
            Liste.Add(new Personne { Id = 1, Nom = "Pendragon", Prenom = "Arthur" });
            Liste.Add(new Personne { Id = 2, Nom = "Le Gaulois", Prenom = "Provencal" });
            Liste.Add(new Personne { Id = 3, Nom = "L'enchanteur", Prenom = "Merlin" });

            this.DataContext = Liste;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
