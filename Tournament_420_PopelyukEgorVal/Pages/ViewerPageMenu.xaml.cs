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
using Tournament_420_PopelyukEgorVal.DataBaseFolder;

namespace Tournament_420_PopelyukEgorVal.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewerPageMenu.xaml
    /// </summary>
    public partial class ViewerPageMenu : Page
    {
        public ViewerPageMenu(User userViewer)
        {
            InitializeComponent();
            userViewer = App.currentUser;
            NamesTB.Text = userViewer.Nickname.ToString();
        }

   

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AuthorizationPage());
        }

        private void Button_Click_Tournament_View(object sender, RoutedEventArgs e)
        {

        }
    }
}
