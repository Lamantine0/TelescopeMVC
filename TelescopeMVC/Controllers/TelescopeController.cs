using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelescopeMVC.DataBase;
using TelescopeMVC.Models;

namespace TelescopeMVC.Controllers
{
    public class TelescopeController : Controller
    {
        private readonly TelescopeContext _context;


        public TelescopeController(TelescopeContext context)
        {
            _context = context;
        }

        public IActionResult CreateTelescope()
        {
            return View();
        }


        public IActionResult Index()
        {
           return RedirectToAction("Home");
        }

        public IActionResult Test()
        {
            return View();
        }

        public async Task<IActionResult> Table() 
        {  
            var telescopes = await _context.Telescopes.ToListAsync();

            

            return View(telescopes);
        }   

        [HttpGet]
        public async Task<IActionResult> GetAllTelescope()
        {
            foreach (var item in _context.Telescopes)
            {
                if(ModelState.IsValid)
                {
                    await _context.SaveChangesAsync();
                }

            }

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTelescope(Telescope telescope, IFormFile picture)
        {
            if (ModelState.IsValid)
            {
                if (picture != null && picture.Length > 0)
                {
                    byte[]? imageData = null;

                    using (var binaryRider = new BinaryReader(picture.OpenReadStream()))
                    {

                        imageData = binaryRider.ReadBytes((int)picture.Length);
                    }

                    telescope.Picture = imageData;
                }

                _context.Telescopes.Add(telescope);

                await _context.SaveChangesAsync();

                return RedirectToAction("CreateTelescope");


            }

            return View(telescope);
        }

      


    }
}
