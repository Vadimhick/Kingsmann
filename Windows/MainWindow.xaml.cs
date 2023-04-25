using Kingsman.Windows;
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

namespace Kingsman
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetListService();
        }
        private void GetListService()
        {
            LvService.ItemsSource = ClassHelper.EF.context.Service.ToList();
        }
        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();


            GetListService();
        }
        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }

            var service = button.DataContext as DB.Service; // получаем выбранную запись


            EditService editService = new EditService(service);
            editService.ShowDialog();

            GetListService();
        }
        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.ShowDialog();
        }
        private void BtnEmploye_Click(object sender, RoutedEventArgs e)
        {
            Empoye empoye = new Empoye();
            empoye.ShowDialog();
        }
    }
}
