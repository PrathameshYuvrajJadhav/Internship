using EMP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Repositories.Interfaces
{
        public interface IDepartmentRepository
        {
            List<Department> GetAll();

            Department GetById(int id);

            void Add(Department department);

            void Update(Department department);

            void Delete(int id);
        }
    
}
