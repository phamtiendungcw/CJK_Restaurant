using System;
using System.Collections.Generic;
using CJK.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CJK.Web.Models;
using Newtonsoft.Json;

namespace CJK.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> list = new();
            var response = await _productService.GetAllProductsAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}
