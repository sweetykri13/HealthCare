using HealthCareDAL;
using HealthCareDAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace HealthCareWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HealthCareController : Controller
    {
         HealthRepository repo=new HealthRepository();

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            List<Product> prods = new List<Product>();
            try
            {
                prods = repo.GetAllProducts();
            }
            catch (Exception)
            {
                prods = null;
            }
            return prods;
        }
        [HttpGet]
        public ActionResult<List<QuaterInfo>> GetQuaterInfos()
        {
            List<QuaterInfo> quats = new List<QuaterInfo>();
            try
            {
                quats = repo.GetAllQuaterInfo();
            }
            catch (Exception)
            {

                quats = null;
            }
            return Json(quats);
        }
    }
}
