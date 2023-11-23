using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
     [HttpGet(Name = "Hi")]
     public IEnumerable<string> GetHi()
     {
        return new string[] {"Hi"};
     }

     [HttpGet("number{id:int}")]
     public string number(int id)
     {
        return "This is "+id;
     }
     [HttpGet("Time")]
     public string time()
     {
        return "it  is "+ DateTime.Now.ToString("H:mm");
     }


}