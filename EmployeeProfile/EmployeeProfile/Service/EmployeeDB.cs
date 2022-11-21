using EmployeeProfile.Enum;
using EmployeeProfile.Helper;
using EmployeeProfile.Interface;
using EmployeeProfile.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace EmployeeProfile.Service
{
    public class EmployeeDB : IEmployeeDB
    {
        static SQLiteAsyncConnection Database;

        public EmployeeDB()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            Task.Run(async () => await Database.CreateTableAsync<Employee>());
            Task.Run(async () => await this.SaveEmployeeData(new Employee()
            {
                FirstName = "Rudhra",
                lastName = "Sekaran",
                DateOfJoining = DateTime.Now,
                Address = "4545 PENNWOOD LAS VEGAS USA",
                Department = 0,
                Email = "rudhrasekaran@gmail.com",
                Image = "https://www.gravatar.com/avatar/2c7d99fe281ecd3bcd65ab915bac6dd5?s=500",
                PhoneNumber = "9788927005"
            }));                     
            
        }

        public  async Task<List<Employee>> GetEmployeeData()
        {
            return await Database.Table<Employee>().ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await Database.Table<Employee>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveEmployeeData(Employee employee)
        {

            if (employee.Id != 0)
            {
                return await Database.UpdateAsync(employee);
            }
            else
            {
                return await Database.InsertAsync(employee);
            }
        }

        public Task<int> DeleteEmployeeData(int id)
        {
            return Database.DeleteAsync(id);
        }
    }
    }


   
