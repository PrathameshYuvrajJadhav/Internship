using EMP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Repositories.Interfaces
{
    public interface IBranchRepository
    {
        List<Branch> GetAll();

        Branch GetById(int id);

        void Add(Branch branch);

        void Update(Branch branch);

        void Delete(int id);
    }
}
