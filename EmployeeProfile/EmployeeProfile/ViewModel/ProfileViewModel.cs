using EmployeeProfile.Interface;
using EmployeeProfile.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProfile.ViewModel
{
    public class ProfileViewModel : BaseViewModel
    {
        private readonly IEmployeeDB _employeeDB;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _image;
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        private string _dateOfJoining;
        public string DateOfJoining
        {
            get { return _dateOfJoining; }
            set
            {
                _dateOfJoining = value;
                OnPropertyChanged(nameof(DateOfJoining));
            }
        }

        private string _department;
        public string Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged(nameof(Department));
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public ProfileViewModel() : this(CommonServiceLocator.ServiceLocator.Current.GetInstance<IEmployeeDB>())
        {
        }

        public ProfileViewModel(IEmployeeDB EmployeeDB)
        {
            _employeeDB = EmployeeDB;
            Load();

        } 

        public async void Load() 
        {
            List<Employee> employeeList = await _employeeDB.GetEmployeeData();
            Employee currentEmployee = employeeList.FirstOrDefault();  
            if(currentEmployee != null)
            {
                Image = currentEmployee.Image;
                Name = currentEmployee.FirstName+" "+currentEmployee.lastName;
                Email = currentEmployee.Email;
                Address = currentEmployee.Address;
                DateOfJoining = currentEmployee.DateOfJoining.Date.ToString("dd/MM/yyyy");
                Department = currentEmployee.Department.ToString();
                PhoneNumber = currentEmployee.PhoneNumber;
            }            
        }

     
    }
}

