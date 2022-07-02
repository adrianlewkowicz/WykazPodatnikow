using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using WebAPIRegister.Domain;

namespace WebAPIRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterWLController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly DataContext _dataContext;
        public RegisterWLController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult GetNIP ()
        {
            using(var x =new HttpClient())
            {
                var y = x.GetAsync("https://wl-api.mf.gov.pl/#nips?date").Result;
                var json = y.Content.ReadAsStringAsync().Result;
                return Ok(json);
            }
        }

        [HttpPost]
        public IActionResult AddSave([FromBody]Entity entity)
        {
            using (var x = new HttpClient())
            {
                var y = x.GetAsync("https://wl-api.mf.gov.pl/#nips?date").Result;
                var json = y.Content.ReadAsStringAsync().Result;
                var find = _dataContext.Entities.Add(entity);
                _dataContext.SaveChanges();
                return Ok(json);
            }
        }

        //[HttpPost]
        //public IActionResult SaveNIP([FromBody]Entity entity)
        //{
        //    HttpClient ctx = new HttpClient();
        //    var p = ctx.GetAsync("https://wl-api.mf.gov.pl/#nips?date").Result;
        //    var json = p.Content.ReadAsStringAsync().Result;
        //    using (var pac = new ExcelPackage(new FileInfo(json)))
        //    {
        //        var first = pac.Workbook.Worksheets["First Sheet"];
        //        Console.WriteLine("NIP");
        //        Console.WriteLine($"NIP: {first.Cells["NIP"].Text}");
        //    }
        //}
    }
}
