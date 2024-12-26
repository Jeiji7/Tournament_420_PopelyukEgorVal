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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        private List<User> user = new List<User>();
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        

        private void Button_Click_Enter(object sender, RoutedEventArgs e)
        {
            string _login = NickTB.Text.Trim();
            string _password = PasswordPS.Password.Trim();
            user = new List<User>(App.db.User.ToList());
            App.currentUser = user.FirstOrDefault(x => x.Nickname == _login && x.Password == _password); // мы передаём текущего пользователя в глобальную переменную, и теперь можно вызвать его везед используя  App.employee
            if (App.currentUser != null)
            {
                MessageBox.Show($"Добро пожаловать {App.currentUser.Nickname} !!!");
                if (App.currentUser.ID_role == 1)
                {
                    OrganizerPageMenu editPage = new OrganizerPageMenu(App.currentUser);
                    NavigationService.Navigate(editPage);
                }
                else if (App.currentUser.ID_role == 2)
                {
                    ViewerPageMenu editPage = new ViewerPageMenu(App.currentUser);
                    NavigationService.Navigate(editPage);
                }
                else if (App.currentUser.ID_role == 3)
                {
                    PlayerPageMenu editPage = new PlayerPageMenu(App.currentUser);
                    NavigationService.Navigate(editPage);
                }

            }
            else
                MessageBox.Show("Неверный Логин или пароль!!!");
        }

    }
}
