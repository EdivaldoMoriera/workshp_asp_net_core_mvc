using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Service;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        //injeção dependecia para sellerService
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }//tipo de retorno de todas as açoes: 'IActionResult'
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//previne que a aplicaçao sofra ataques 'CSRF' quando alguem aprveita a cesao de autenticação para enfiar dados maliciosos
        public IActionResult Create(Seller seller)//recebe um objeto Selle que veio na requisição
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}