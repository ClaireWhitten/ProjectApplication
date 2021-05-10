using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Classes
{
    class Employee
    {
        public int EmployeeId { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string Street {get; set; }

        public int Number { get; set; }

        public int PostCode { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }

        public DateTime StartDate { get; set; }

        public int RoleId { get; set; }



        public Role Role { get; set; }
        public User User { get; set; }




    }
}
