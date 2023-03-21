using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BLL.IServices;
using DTO.BlogDto;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class BlogController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IBlogService _blogService;
        public BlogController(ICategoryService category, IBlogService blog)
        {
            _blogService = blog;
            _categoryService = category;
        }
        public IActionResult ViewJustToCheck()
        {
            return View();
        }
        public  IActionResult Categories()
        {
            List<Category> caregories =_categoryService.GetAll();
            return View(caregories);
        }
        [Authorize]
        public async Task<IActionResult> Details(int Id)
        {
            BlogCommentsDto dto=new BlogCommentsDto();
            dto.Blog = await _blogService.Get(Id);
            return View(dto);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var values = await _blogService.Get();
            return View(values);
        }
    }
}
