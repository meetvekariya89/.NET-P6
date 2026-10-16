using Product_Catelog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Product_Catelog.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> P_ALL = GetProductData();

            return View("Products", P_ALL);
        }

        // GET: Products/Details/101
        public ActionResult Details(int id)
        {
            List<Product> P_ALL = GetProductData();

            Product p1 = P_ALL.FirstOrDefault(x => x.ProductId == id);

            if (p1 == null)
            {
                return HttpNotFound();
            }

            return View("View",p1);
        }

        private List<Product> GetProductData()
        {
            List<Product> pTemp = new List<Product>();

            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();

            p1.ProductId = 101;
            p1.ProductName = "Samsung Fold 8";
            p1.ProductPrice = 245000;
            p1.ProductCategory = "Mobile";
            p1.ImageUrl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQE_QilAZ_jIPKMH9-CW9fQ8mHhkYHYq7V5mH7jQt66yZ5AYkZDo8G-736naI4dp5dee6Ye1uRnXgUMKIWYvP2O-d_ei0IeV2qyQWoVksB6X7Y71MthC7cuFw";

            p2.ProductId = 102;
            p2.ProductName = "MacBook Neo";
            p2.ProductPrice = 89650;
            p2.ProductCategory = "Laptop";
            p2.ImageUrl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQJjyovW3CIPOuGs2tUmrf2sLzOCatMjUIKWcir2IiYz-OLP1b_qRFJUVNwmHl8ARupUh3LLzDxZ0RWjBYw89tzUsy_iNPn5JmVdsZFZ-rhauvRSRLvdQT--g";

            p3.ProductId = 103;
            p3.ProductName = "Rolex";
            p3.ProductPrice = 100000;
            p3.ProductCategory = "Watch";
            p3.ImageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSrH-RORwAr8GLSLn3wkFo0TjPcFuDG4H5bGAJaGrZml_fN8AZhFuHtKsCpJuM3siehDh_i130buSPR6EK2MWI17qq3GuFjWHEaBQU4zRBKH8ZeFtmB-h9H";

            pTemp.Add(p1);
            pTemp.Add(p2);
            pTemp.Add(p3);

            return pTemp;
        }
    }
}