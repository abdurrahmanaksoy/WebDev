using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        //[HttpGet("getall")]
        //public IActionResult  GetList()
        //{
        //    return Ok(_bookService.GetAll());
        //}
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_bookService.GetAll());
        }
    }
}