using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.Entities;
using TaskManagement.enums;
using TaskManagement.Interfaces.Services;
using TaskManagement.Models.Task.Command;
using TblTask = TaskManagement.Entities.TblTask;

namespace TaskManagement.Controllers
{
    public class TasksController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ITaskService _taskService;

        public TasksController(AppDbContext context, ITaskService taskService)
        {
            _context = context;
            _taskService = taskService;
        }

        // GET: Tasks
        public async Task<IActionResult> Index(TaskPagingRequest request)
        {
            if (_context.Tasks == null || !_context.Tasks.Any())
            {
                return _context.Tasks != null ?
                                  View(await _context.Tasks.ToListAsync()) :
                                  Problem("Entity set 'ApplicationDbContext.Tasks'  is null.");
            }
            var res = await _taskService.GetAllPaging(request);
            return View(res);
        }

        // GET: Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var task = await _taskService.GetById(id.Value);

            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            var users = _context.Users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.UserName
            }).ToList();

            var labels = _context.Labels.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.Name
            }).ToList();

            var priorities = Enum.GetValues(typeof(TaskPriority))
            .Cast<TaskPriority>()
            .Select(e => new SelectListItem
            {
                Value = ((int)e).ToString(), // Giá trị của enum
                Text = e.ToString() // Tên của enum
            }).ToList();

            var model = new TaskCommandDto
            {
                Priorities = priorities,
                Users = users,
                Labels = labels
            };

            return View(model);
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskCommandDto request)
        {
            if (ModelState.IsValid)
            {
                var res = await _taskService.Assign(request);
                if (res)
                    return RedirectToAction(nameof(Index));

                return View(request);

            }
            return View(request);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,StartDate,EndDate,Priority,EstimatedTime,Description,Status,CreatedBy,CreatedAt,LastModifiedBy,LastModifiedAt,DepartmentId,ParentId")] TblTask task)
        {
            if (id != task.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(task);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskExists(task.Id))
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
            return View(task);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tasks == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tasks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Tasks'  is null.");
            }
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskExists(int id)
        {
          return (_context.Tasks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
