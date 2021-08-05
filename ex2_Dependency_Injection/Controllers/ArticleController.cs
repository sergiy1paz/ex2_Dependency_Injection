using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace ex2_Dependency_Injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleProcessService _service;
        public ArticleController(IArticleProcessService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult PublishArticle()
        {
            return Ok(_service.Process());
        }
    }
}
