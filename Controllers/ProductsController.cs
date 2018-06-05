using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

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
 
        public string Welcome() 
        { 
            return "This is the Welcome action method..."; 
        } 
    } 
}
