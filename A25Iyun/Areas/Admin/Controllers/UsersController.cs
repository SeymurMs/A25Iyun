using A25Iyun.DAL;
using A25Iyun.Models;
using A25Iyun.Utilize;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A25Iyun.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        public readonly AppDbContext _context;
        public readonly IWebHostEnvironment _env;
        public UsersController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public ActionResult Index()
        {
            List<Users> users = _context.Users.ToList();
            return View(users);
        }


        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Users user)
        {
            if (!ModelState.IsValid) return View();
            if (!user.Image.CheckSize(500))
            {
                ModelState.AddModelError("Size", "Size 500 Eroor");

            }
            if (!user.Image.CheckType("Image/"))
            {
                ModelState.AddModelError("CheckType", "Size Image/ Eroor");

            }
            if (user.Image != null)
            {
                user.ImageUrl = user.Image.SaveImage(Path.Combine(_env.WebRootPath, "assets", "userImg"));

            }
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            Users user = _context.Users.Find(id);
            if (user == null)
            {
                return BadRequest();
            }
            return View(user);
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Users user)
        {
            if (id != user.Id)
            {
                return View();
            }
            Users DbUser = _context.Users.Find(id);
            if (user.Image != null)
            {
                Filemanage.DeleteImg(Path.Combine(_env.WebRootPath, "assets", "userImg", DbUser.ImageUrl));
                DbUser.ImageUrl = user.Image.SaveImage(Path.Combine(_env.WebRootPath, "assets", "userImg"));

            }
            DbUser.Name = user.Name;
            DbUser.Description = user.Description;
            DbUser.Raiting = user.Raiting;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            Users user = _context.Users.Find(id);
            if (user == null)
            {
                return BadRequest();
            }
            if (user.ImageUrl != null)
            {
            Filemanage.DeleteImg(Path.Combine(_env.WebRootPath, "assets", "userImg", user.ImageUrl));
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
