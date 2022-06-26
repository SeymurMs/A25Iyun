using A25Iyun.DAL;
using A25Iyun.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace A25Iyun.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Users> Users = _context.Users.ToList();
            return View(Users);
        }
    }
}
