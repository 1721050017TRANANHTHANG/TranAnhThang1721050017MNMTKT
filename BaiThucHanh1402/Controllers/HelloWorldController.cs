using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class BaiThucHanh1402 : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int Age = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Age is: {Age}");
        }

    }
}