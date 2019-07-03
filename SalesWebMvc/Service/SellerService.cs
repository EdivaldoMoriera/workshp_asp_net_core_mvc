﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
namespace SalesWebMvc.Service
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;
        public  SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }
        //retorna todos os vendedores do banco de dados
        public List<Seller> FindAll()
        {
           return  _context.Seller.ToList();
        }
    }
}
