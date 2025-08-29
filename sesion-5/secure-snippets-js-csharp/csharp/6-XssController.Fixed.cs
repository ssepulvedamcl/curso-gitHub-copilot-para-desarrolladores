// ✅ Mitigación: Codificar salida o usar vistas que auto-escapan
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace SecureDemo.Controllers {
    public class HelloController : Controller {
        [HttpGet("/hello")]
        public ContentResult Hello(string name) {
            name ??= "invitado";
            var safe = WebUtility.HtmlEncode(name); // codifica caracteres especiales
            return Content($"<h1>Hola {safe}</h1>", "text/html");
        }
    }
}
