// ✅ SEGURO: Usar codificación automática de Razor o helpers
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace SecureDemo.Controllers {
    public class HelloController : Controller {
        [HttpGet("/hello")]
        public ContentResult Hello(string name) {
            name ??= "invitado";
            return Content($"<h1>Hola {HttpUtility.HtmlEncode(name)}</h1>", "text/html");
        }
    }
}
