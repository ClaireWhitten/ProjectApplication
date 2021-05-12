using ProjectApplication.Classes;
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

namespace ProjectApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            ProjectApplicationContext ctx = new ProjectApplicationContext();
            /*ctx.Employees.Add(new Employee()
            {
                FirstName = "Claire",
                LastName = "Whitten",
                DOB = new DateTime(1993,03,04),
                Street = "Cherry Street",
                Number = 8,
                PostCode = 2000,
                PhoneNumber = 045622345,
                Email = "claire_whitten@gmail.com",
                Salary = 24000,
                StartDate = new DateTime(2020, 05, 14),
                Role = Role.Administrator
            });*/

            ctx.UserAccounts.Add(new UserAccount()
            {
                UserName = "Claire55",
                Password = "Password",
                CreatedOn = DateTime.Now
            });


            ctx.SaveChanges();





            InitializeComponent();
            MessageBox.Show("Ended");
        }
    }
}
