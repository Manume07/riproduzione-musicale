using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace riproduzione_musicale
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

        private void btnAggiungiBrano_Click(object sender, RoutedEventArgs e)
        {

            string titolo = txtTitolo.Text;
            string autore = txtAutore.Text;
            string durata = txtDurata.Text;
            bool valore = false;


            if ((string.IsNullOrEmpty(titolo) || string.IsNullOrEmpty(autore) || string.IsNullOrEmpty(durata))){
                MessageBox.Show("ERRORE inserire tutti i brani");
                txtTitolo.Clear();
                txtAutore.Clear();
              
            }
            else
            {
                brano brano = new brano(titolo, autore, float.Parse(durata));
                lstBrani.Items.Add(brano);
            }

        }

    }
}