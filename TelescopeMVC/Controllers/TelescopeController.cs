using Microsoft.AspNetCore.Mvc;
using TelescopeMVC.DataBase;
using TelescopeMVC.Models.TelescopeApp.Models;


namespace TelescopeMVC.Controllers
{
    public class TelescopeController : Controller
    {
        private readonly TelescopeContext _context;


        public TelescopeController(TelescopeContext context)
        {
            _context = context;
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
        public async Task<IActionResult> CreateTelescope(Telescope telescope)
        {
            if (ModelState.IsValid)
            {
                _context.Telescopes.Add(telescope);

                await _context.SaveChangesAsync();

                return RedirectToAction("CreateTelescope");
            }

            return View(telescope);
        }

        [HttpPost]
        public async Task<IActionResult> AddTelescopePictures(Telescope telescope, IFormFile Picture)
        {
            if (Picture != null && Picture.Length > 0)
            {
                byte[]? imageData = null;   

                using (var binaryRider = new BinaryReader(Picture.OpenReadStream()))
                {

                    imageData = binaryRider.ReadBytes((int)Picture.Length);
                }

                telescope.Picture = imageData;
            }



            _context.Add(telescope);

            await _context.SaveChangesAsync();

            


            return View(telescope);
           
        }


    }
}
