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
using ProjectApplication.Classes;

namespace ProjectApplication
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public UserAccount User { get; set; } 
        public MainMenu(UserAccount user)
        {
            User = user;
            InitializeComponent();
            if(User.Role == Role.Administrator)
            {
                //create the buttons 
            }
        }
    }
}
