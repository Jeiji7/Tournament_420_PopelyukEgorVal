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
    /// Логика взаимодействия для PlayerPageMenu.xaml
    /// </summary>
    public partial class PlayerPageMenu : Page
    {
        public PlayerPageMenu(User playerUser)
        {
            InitializeComponent();
            playerUser = App.currentUser;
            NamesTB.Text = playerUser.Nickname.ToString();
        }

     
        private void Button_Click_Tournament(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_InfoPlayer(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AuthorizationPage());
        }
    }
}
