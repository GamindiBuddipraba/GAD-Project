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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace CoopFoodCity
{
    /// <summary>
    /// Interaction logic for AllEmployees.xaml
    /// </summary>
    public partial class AllEmployees : Window
    {
        public AllEmployees()
        {
            InitializeComponent();
        }

        Database obj = new Database();
        HeadMenu newobj = new HeadMenu();
        private void btn_view_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string view = "select empid As Employee_Id,ename AS Name,dob As DOB,gender AS Gender,nic As NIC,add_line1 As Address_Line1,add_line2 As Address_Line2,add_line3 AS Address_Line3,etp AS Telophone_No,jobroll As Job_Roll,dept AS Department,doa As Date_of_Accent,email AS Email from Employee";
                datagrideview.ItemsSource = obj.datasearch(view).DefaultView;
            }
            catch (SqlException sqlerror)
            {
                MessageBox.Show(sqlerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
            }
            
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void insertemp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.insertemp();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void updateemp1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.updemp();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void searchemp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.searchemp();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void removeemp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.removeemp();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void viewallemp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.removeemp();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void insertsal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.insertsalary();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void issuesal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.issuesal();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void allattendance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.allatendance();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void attendancerepgraph_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.statistic();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void salarygraph_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.statisticsal();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void dailyattendance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.empreportdaily();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void salaryrep_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.salaryreportdetails();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void monthlyattendance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                newobj.attendacereportmothly();
            }
            catch (Exception systemerror)
            {
                MessageBox.Show(systemerror.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
