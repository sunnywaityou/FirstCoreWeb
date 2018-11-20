using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace FirstCoreMvc.Controllers
{
    public class HelloWorldController:Controller
    {
        /// <summary>
        /// GET: /HelloWorld/
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// GET: /HelloWorld/Welcome
        /// </summary>
        /// <returns></returns>
        public string Welcome()
        {
            return "this is the welcome action method...";
        }
    }
}