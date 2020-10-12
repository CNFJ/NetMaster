﻿using NetMaster.Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMaster.Blog.Services
{
    public class DeparmentService : IDeparmentService
    {
        private readonly List<Department> _departments = new List<Department>();
        public DeparmentService()
        {
            _departments.Add(new Department
            {
                Id = 1,
                Name = "HR",
                EmployeeCount = 16,
                Location = "成都"
            });
            _departments.Add(new Department
            {
                Id = 2,
                Name = "R&D",
                EmployeeCount = 16,
                Location = "成都"
            });
            _departments.Add(new Department
            {
                Id = 3,
                Name = "HR",
                EmployeeCount = 16,
                Location = "成都"
            });
            _departments.Add(new Department
            {
                Id = 4,
                Name = "R&D",
                EmployeeCount = 16,
                Location = "成都"
            });
            _departments.Add(new Department
            {
                Id = 1,
                Name = "HR",
                EmployeeCount = 16,
                Location = "成都"
            });
            _departments.Add(new Department
            {
                Id = 2,
                Name = "R&D",
                EmployeeCount = 16,
                Location = "成都"
            });
            _departments.Add(new Department
            {
                Id = 3,
                Name = "HR",
                EmployeeCount = 16,
                Location = "成都"
            });
            _departments.Add(new Department
            {
                Id = 4,
                Name = "R&D",
                EmployeeCount = 16,
                Location = "成都"
            });
        }
        public Task Add(Department department)
        {
            department.Id = _departments.Max(x => x.Id) + 1;
            _departments.Add(department);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Department>> GetAll()
        {
            return Task.Run(() => _departments.AsEnumerable());
        }

        public Task<Department> GetById(int id)
        {
            return Task.Run(() => _departments.FirstOrDefault(x => x.Id == id));
        }

        public Task<CompanySummary> GetCompanySummary()
        {
            return Task.Run(() =>
            {
                return new CompanySummary
                {
                    EmployeeCount = _departments.Sum(x => x.EmployeeCount),
                    AverageDepartmentEmpolyeeCount = (int)_departments.Average(x => x.EmployeeCount)
                };
            });
        }
    }
}
