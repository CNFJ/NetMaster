using NetMaster.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMaster.Blog.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly List<Employee> _employees = new List<Employee>();
        public EmployeeService()
        {
            _employees.Add(new Employee
            {
                Id=1,
                DepartmentId=1,
                FirstName="deg",
                LastName="sda",
                Gender=Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 2,
                DepartmentId = 1,
                FirstName = "deg",
                LastName = "sda",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 3,
                DepartmentId = 2,
                FirstName = "deg",
                LastName = "sda",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 4,
                DepartmentId = 2,
                FirstName = "e5deg",
                LastName = "sda",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 5,
                DepartmentId = 3,
                FirstName = "dtyeg",
                LastName = "sda",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 6,
                DepartmentId = 3,
                FirstName = "dtyeg",
                LastName = "sda",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 7,
                DepartmentId = 4,
                FirstName = "dehug",
                LastName = "sda",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 8,
                DepartmentId = 4,
                FirstName = "deuhg",
                LastName = "sda",
                Gender = Gender.男
            });
        }

        public Task Add(Employee employee)
        {
            employee.Id = _employees.Max(x => x.Id)+1;
            _employees.Add(employee);
            return Task.CompletedTask;
        }

        public Task<Employee> Fired(int id)
        {
            return Task.Run(() =>
            {
                var employee = _employees.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {
                    employee.Fired = true;
                    return employee;
                }
                return null;
            }
            
               
            );
        }

        public Task<IEnumerable<Employee>> GetByDepartemyId(int departmentId)
        {
            return Task.Run(() => _employees.Where(x=>x.DepartmentId==departmentId).AsEnumerable());

        }
    }
}
