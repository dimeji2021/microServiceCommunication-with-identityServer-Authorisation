using Mango.Services.ProductAPI.Models.Dtos;
using Mango.Services.ProductAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        protected RepsonseDto _repsonse;
        private readonly IProductRepository _productRepository;

        public ProductAPIController(IProductRepository productRepository)
        {
            _repsonse = new RepsonseDto();
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult<RepsonseDto>> Get()
        {
            try
            {
                var products = await _productRepository.GetProducts();
                _repsonse.Result = products;
            }
            catch (Exception ex)
            {

                _repsonse.IsSuccess = false;
                _repsonse.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _repsonse;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<RepsonseDto>> Get(int id)
        {
            try
            {
                var products = await _productRepository.GetProductById(id);
                _repsonse.Result = products;
            }
            catch (Exception ex)
            {

                _repsonse.IsSuccess = false;
                _repsonse.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _repsonse;
        }
        [HttpPost]
        public async Task<ActionResult<RepsonseDto>> Post(ProductDto product)
        {
            try
            {
                var model = await _productRepository.CreateUpdateProduct(product);
                _repsonse.Result = model;
            }
            catch (Exception ex)
            {

                _repsonse.IsSuccess = false;
                _repsonse.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _repsonse;
        }
        [HttpPut]
        public async Task<ActionResult<RepsonseDto>> Put(ProductDto product)
        {
            try
            {
                var model = await _productRepository.CreateUpdateProduct(product);
                _repsonse.Result = model;
            }
            catch (Exception ex)
            {

                _repsonse.IsSuccess = false;
                _repsonse.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _repsonse;
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<RepsonseDto>> Delete(int id)
        {
            try
            {
                var isSuccess = await _productRepository.DeleteProduct(id);
                _repsonse.Result = isSuccess;
            }
            catch (Exception ex)
            {

                _repsonse.IsSuccess = false;
                _repsonse.ErrorMessage = new List<string>()
                {
                    ex.ToString()
                };
            }
            return _repsonse;
        }
    }
}
