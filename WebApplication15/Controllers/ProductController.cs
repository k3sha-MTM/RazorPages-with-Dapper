using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication15.Models;
using Dapper;
namespace WebApplication15.Controllers
{
    public class ProductController : Controller
    {
         public List<Product> products;
        // GET: ProductController
        public ActionResult Index()
        {
            return View(products);
        }
        public ActionResult Dapper()
        {
            return View(products);
        }
        public ProductController()
        {
            products = new List<Product>();

            using (IDbConnection db = SingletonDB.GetDBConnection())
            {
                products = db.Query<Product>("SELECT * FROM [PRODUCT]").ToList();
               
            }
           
        }



    }
}
