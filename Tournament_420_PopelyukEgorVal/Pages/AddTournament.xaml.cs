using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
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
using Tournament_420_PopelyukEgorVal;
using Tournament_420_PopelyukEgorVal.DataBaseFolder;

namespace Tournament_420_PopelyukEgorVal.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddTournament.xaml
    /// </summary>
    public partial class AddTournament : Page
    {
        public AddTournament(User userOrganizer)
        {
            InitializeComponent();
            var typee = App.db.Format.ToList();
            FormatCB.ItemsSource = typee.ToList();
            FormatCB.DisplayMemberPath = "Name";
        }
        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            Tournament tournament = new Tournament();

            tournament.NameTournament = NameTournamentTB.Text;
            tournament.Prize = PrizeTB.Text;
            tournament.Format = (Format)FormatCB.SelectedItem;
            tournament.Count_user = int.Parse(CountUser.Text);
            tournament.ID_user = App.currentUser.ID_user;
            App.db.SaveChanges();
            NavigationService.Navigate(new Pages.OrganizerPageMenu(App.currentUser));

        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.OrganizerPageMenu(App.currentUser));
        }
    }
}
