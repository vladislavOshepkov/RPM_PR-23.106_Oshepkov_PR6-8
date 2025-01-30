using RPM_PR_23._106_Oshepkov_PR3_v2;
using RPM_PR_23._106_Oshepkov_PR3_v2.Model;
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

namespace aaa.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin(Users user, string role)
        {
            InitializeComponent();

            Shoe_factoryEntities db = Helper.GetContext();
            var employeeList = db.Employees.ToList();
            EmployeeList.ItemsSource = employeeList;
            DataContext = this;
        }

        private void EmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EmployeeList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
