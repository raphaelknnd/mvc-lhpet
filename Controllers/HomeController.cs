using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        Cliente cliente1 = new Cliente(1, "Raphael", "888.999.000-12", "raphael@hotmail.com", "Zeus");
        Cliente cliente2 = new Cliente(2, "Alana", "123.456.789-00", "alana@hotmail.com", "Mada");
        Cliente cliente3 = new Cliente(3, "Clara", "001.234.876-45", "clara@hotmail.com", "Fox");
        Cliente cliente4 = new Cliente(4, "Pedro", "989.098.234-87", "pedro@hotmail.com", "Presunto");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedor1 = new Fornecedor(1, "Ze pet", "12345", "zepet@zepet.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "Patas", "54312", "patas@patas.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "Bolhas pet", "097625", "bolhaspet@bolhaspet.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "Milho pet", "126765", "milhopet@milhopet.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {   
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
