// ⚠️ XSS: devolver HTML sin escape en un controlador MVC

using System.Web.Mvc;

public class XssController : Controller
{
    // Acción insegura que devuelve HTML sin escape
    public ActionResult InsecureGreeting(string name)
    {
        // ⚠️ Vulnerable a XSS si 'name' contiene código HTML/JS malicioso
        string html = "<h1>Hola " + name + "</h1>";
        return Content(html, "text/html");
    }
}
