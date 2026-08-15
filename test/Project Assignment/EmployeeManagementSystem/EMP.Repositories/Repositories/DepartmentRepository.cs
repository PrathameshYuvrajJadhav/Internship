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
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments.Find(id);
        }

        public void Add(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void Update(Department department)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = _context.Departments.Find(id);

            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }
    }
}
