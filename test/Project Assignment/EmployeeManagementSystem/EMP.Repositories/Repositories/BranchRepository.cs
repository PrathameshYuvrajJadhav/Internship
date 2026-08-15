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
    public class BranchRepository : IBranchRepository
    {
        private readonly ApplicationDbContext _context;

        public BranchRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Branch> GetAll()
        {
            return _context.Branches.ToList();
        }

        public Branch GetById(int id)
        {
            return _context.Branches.Find(id);
        }

        public void Add(Branch branch)
        {
            _context.Branches.Add(branch);
            _context.SaveChanges();
        }

        public void Update(Branch branch)
        {
            _context.Branches.Update(branch);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var branch = _context.Branches.Find(id);

            if (branch != null)
            {
                _context.Branches.Remove(branch);
                _context.SaveChanges();
            }

        }
    }
}
