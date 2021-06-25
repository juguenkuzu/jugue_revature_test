using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mosali.Application.Interface;
using Survey.Application.ViewModels;

namespace Mosali.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeAppService  _employeeAppService ;

        public EmployeesController(IEmployeeAppService employeeAppService)
        {
            _employeeAppService = employeeAppService;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var employeesList = _employeeAppService.ObtenirTout();
            return View(employeesList);
        }
  /*
        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeViewModel = await _context.EmployeeViewModel
                .Include(e => e.Role)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeViewModel == null)
            {
                return NotFound();
            }

            return View(employeeViewModel);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Set<RoleViewModel>(), "RoleId", "RoleId");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,RoleId,SupervisorId,FirstName,LastName,OtherDetails")] EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Set<RoleViewModel>(), "RoleId", "RoleId", employeeViewModel.RoleId);
            return View(employeeViewModel);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeViewModel = await _context.EmployeeViewModel.FindAsync(id);
            if (employeeViewModel == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Set<RoleViewModel>(), "RoleId", "RoleId", employeeViewModel.RoleId);
            return View(employeeViewModel);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,RoleId,SupervisorId,FirstName,LastName,OtherDetails")] EmployeeViewModel employeeViewModel)
        {
            if (id != employeeViewModel.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeViewModelExists(employeeViewModel.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Set<RoleViewModel>(), "RoleId", "RoleId", employeeViewModel.RoleId);
            return View(employeeViewModel);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeViewModel = await _context.EmployeeViewModel
                .Include(e => e.Role)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeViewModel == null)
            {
                return NotFound();
            }

            return View(employeeViewModel);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeViewModel = await _context.EmployeeViewModel.FindAsync(id);
            _context.EmployeeViewModel.Remove(employeeViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeViewModelExists(int id)
        {
            return _context.EmployeeViewModel.Any(e => e.EmployeeId == id);
        }
  */
    }

}
