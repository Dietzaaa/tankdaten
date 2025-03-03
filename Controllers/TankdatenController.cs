using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Tankdaten.Controllers;
using Tankdaten.Data;

namespace Tankdaten.Controllers;

public class TankdatenController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }

    private readonly TankdatenContext _context;

    public TankdatenController(TankdatenContext context)
    {
        _context = context;
    }
}
    