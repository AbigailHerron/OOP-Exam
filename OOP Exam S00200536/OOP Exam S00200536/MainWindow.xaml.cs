/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/OOP-Exam
 
 Description: The code for the Interactive Window
 Variables:
 Methods:
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace OOP_Exam_S00200536
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*VARIABLES -------------------------------------------------------------------------------------------------------*/
        ObservableCollection<Account> accounts = new ObservableCollection<Account>();
        ObservableCollection<Account> filteredAccounts = new ObservableCollection<Account>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxAccounts.ItemsSource = accounts;
        }
    }
}
