using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Web;

namespace BlogNet.Controllers 
{ 
    public class ProductsController : Controller 
    { 
        // 
        // GET: /HelloWorld/ 
 
        public string Index() 
        { 
            return "This is my <b>default</b> action..."; 
        } 
 
        // 
        // GET: /HelloWorld/Welcome/ 
 
        public string Welcome(string name, int numTimes = 1) {
	     return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
	}
    } 
}
