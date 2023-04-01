using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class CoursesViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public CoursesViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Course> courses = await _db.Courses.ToListAsync();
            return View(courses);
        }
    }
}
