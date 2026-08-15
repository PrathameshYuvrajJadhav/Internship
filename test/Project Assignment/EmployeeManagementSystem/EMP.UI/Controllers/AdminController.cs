using EMP.Entities;
using EMP.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EMP.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public AdminController(
            IBranchRepository branchRepository,
            IDepartmentRepository departmentRepository)
        {
            _branchRepository = branchRepository;
            _departmentRepository = departmentRepository;
        }

        public override void OnActionExecuting(
            ActionExecutingContext context)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                context.Result = RedirectToAction("Login", "Account");
                return;
            }

            base.OnActionExecuting(context);
        }

        // =========================
        // BRANCH
        // =========================

        public IActionResult Branches()
        {
            var branches = _branchRepository.GetAll();

            return View(branches);
        }

        [HttpGet]
        public IActionResult CreateBranch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBranch(Branch branch)
        {
            if (ModelState.IsValid)
            {
                _branchRepository.Add(branch);

                return RedirectToAction(nameof(Branches));
            }

            return View(branch);
        }

        [HttpGet]
        public IActionResult EditBranch(int id)
        {
            var branch = _branchRepository.GetById(id);

            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        [HttpPost]
        public IActionResult EditBranch(Branch branch)
        {
            if (ModelState.IsValid)
            {
                _branchRepository.Update(branch);

                return RedirectToAction(nameof(Branches));
            }

            return View(branch);
        }

        [HttpGet]
        public IActionResult DeleteBranch(int id)
        {
            var branch = _branchRepository.GetById(id);

            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        [HttpPost]
        [ActionName("DeleteBranch")]
        public IActionResult DeleteBranchConfirmed(int id)
        {
            _branchRepository.Delete(id);

            return RedirectToAction(nameof(Branches));
        }

        // =========================
        // DEPARTMENT
        // =========================

        public IActionResult Departments()
        {
            var departments = _departmentRepository.GetAll();

            return View(departments);
        }

        [HttpGet]
        public IActionResult CreateDepartment()
        {
            ViewBag.Branches = _branchRepository.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentRepository.Add(department);

                return RedirectToAction(nameof(Departments));
            }

            ViewBag.Branches = _branchRepository.GetAll();

            return View(department);
        }

        [HttpGet]
        public IActionResult EditDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);

            if (department == null)
            {
                return NotFound();
            }

            ViewBag.Branches = _branchRepository.GetAll();

            return View(department);
        }

        [HttpPost]
        public IActionResult EditDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentRepository.Update(department);

                return RedirectToAction(nameof(Departments));
            }

            ViewBag.Branches = _branchRepository.GetAll();

            return View(department);
        }

        [HttpGet]
        public IActionResult DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);

            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        [HttpPost]
        [ActionName("DeleteDepartment")]
        public IActionResult DeleteDepartmentConfirmed(int id)
        {
            _departmentRepository.Delete(id);

            return RedirectToAction(nameof(Departments));
        }
    }
}