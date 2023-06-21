using HealthCareDAL.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;

namespace HealthCareDAL
{
    public class HealthRepository
    {
        public HealthCareDBContext context { get; set; }
        public HealthRepository() { 
        context=new HealthCareDBContext();
        }
        public List<Product> GetAllProducts()
        {
            List<Product> product = new List<Product>();
            try
            {
                product = (from prodc in context.Products select prodc).ToList();
            }
            catch (Exception e)
            {
                product = null;
                Console.WriteLine(e.Message);
               
            }
            return product;
        }
        public List<QuaterInfo> GetAllQuaterInfo()
        {
            List<QuaterInfo> quat = new List<QuaterInfo>();
            try
            {
                 quat = (from quatInfo in context.QuaterInfos select quatInfo).ToList();
            }
            catch (Exception e)
            {
                quat = null;
                Console.WriteLine(e.Message);

            }
            return quat;
        }
    }
}