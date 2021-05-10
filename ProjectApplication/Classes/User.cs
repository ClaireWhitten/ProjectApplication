using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Classes
{
    class User
    {
        public int UserId { get; set; }

        public int EmployeeId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime CreatedOn { get; set; }

        public int RoleId { get; set; }



        public Employee Employee { get; set; }
        public Role Role { get; set; }



    }
}
