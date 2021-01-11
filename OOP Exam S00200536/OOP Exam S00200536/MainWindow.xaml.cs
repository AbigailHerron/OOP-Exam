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
            // setting item source for list box
            lbxAccounts.ItemsSource = accounts;

            // creating dummy objects from each account
            CurrentAccount c1 = new CurrentAccount();
            CurrentAccount c2 = new CurrentAccount("12345678", "Steve", "Jobs", "07/04/1984", 15526000m);
            SavingsAccount s1 = new SavingsAccount();
            SavingsAccount s2 = new SavingsAccount("00033302", "Terry", "Cruise", "05/01/1992", 300000m);

            accounts.Add(c1);
            accounts.Add(c2);
            accounts.Add(s1);
            accounts.Add(s2);




            chbxCA.IsChecked = true;
            chbxSA.IsChecked = true;
        }
    }
}
