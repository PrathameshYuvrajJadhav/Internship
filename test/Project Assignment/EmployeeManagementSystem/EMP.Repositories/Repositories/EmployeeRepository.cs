using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EMP.Entities;
using EMP.Repositories.Data;
using EMP.Repositories.Interfaces;

namespace EMP.Repositories.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            return _context.Employees
                .FirstOrDefault(e => e.EmployeeId == id);
        }

        public Employee? GetByEmail(string email)
        {
            return _context.Employees
                .FirstOrDefault(e => e.Email == email);
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);

            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = GetById(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);

                _context.SaveChanges();
            }
        }
    }
}