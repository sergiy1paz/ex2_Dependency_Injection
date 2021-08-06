using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services
{
    public class ArticleProcessService : IArticleProcessService
    {
        private readonly IArticleContentService _contentService;
        private readonly ICheckArticleService _checkArticleService;
        private readonly IPublishArticleService _publishArticleService;

        public ArticleProcessService(IArticleContentService contentService,
            ICheckArticleService checkArticleService,
            IPublishArticleService publishArticleService)
        {
            _contentService = contentService;
            _checkArticleService = checkArticleService;
            _publishArticleService = publishArticleService;
        }

        public string Process()
        {
            _contentService.SetContent("Test content was created by Sergiy Pazyuk");

            string result;
            if (_checkArticleService.Check())
            {
                result = _publishArticleService.Publish();
            }
            else
            {
                result = "Article has not text";
            }

            return result;
        }
    }
}
