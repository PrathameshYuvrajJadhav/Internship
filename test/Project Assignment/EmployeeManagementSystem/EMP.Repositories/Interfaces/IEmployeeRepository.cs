using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMP.Entities;

namespace EMP.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();

        Employee? GetById(int id);

        Employee? GetByEmail(string email);

        void Add(Employee employee);

        void Update(Employee employee);

        void Delete(int id);
    }
}
