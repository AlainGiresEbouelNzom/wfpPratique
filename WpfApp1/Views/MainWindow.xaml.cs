using System.Windows;
using WpfApp1.Views.MyUserControls;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Business.MainWindowsBusiness();
        }



        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            UCEtudiant uCE = new UCEtudiant();
            grContent.Children.Add(uCE);

        }

        private void BtnEditerClick(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickABsences(object sender, RoutedEventArgs e)
        {
            UCAbsence uCAbs = new UCAbsence ();
            grContent.Children.Add(uCAbs);
        }
    }
}
