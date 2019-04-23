using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcAppDemo.Models;
using Microsoft.Extensions.Options;

namespace MvcAppDemo.Controllers
{
    public class ContentController : Controller
    { 
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            /*var contents1=new List<Content>();
            for(int i=0;i<11;i++){
                contents1.Add(new Content{Id=i,title=$"{i}的标题",content=$"{i}的内容",status=1,add_time=DateTime.Now.AddDays(-i)});
            }
            return View(new ContentViewModel{Contents=contents1}); */
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}
