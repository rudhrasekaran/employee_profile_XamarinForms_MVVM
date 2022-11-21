using EmployeeProfile.Enum;
using SQLite;
using System;

namespace EmployeeProfile.Model
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public  Department Department { get; set; }
        public DateTime DateOfJoining   { get; set; }
        public string PhoneNumber { get; set; }
    }
    
}
