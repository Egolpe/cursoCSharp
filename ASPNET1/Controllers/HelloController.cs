using System;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET1.Controllers;


[ApiController]
[Route("api/[controller]")]
public class HelloController
{

    public HelloController()
    {
    }

    //GET https://localhost:7279/api/hello/saludo
    [HttpGet("saludo")]
    public string HelloWorld()
    {
        return "Hello World";
    }

    //GET https://localhost:7279/api/hello/despedida
    [HttpGet("despedida")]
    public string ByeWorld()
    {
        return "bye World";
    }
}

