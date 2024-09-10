using Microsoft.AspNetCore.Mvc;
using ValidationAttributes.WebApi.Models;

namespace ValidationAttributes.WebApi.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{		
		[HttpPost]
		public IActionResult Post([FromBody] Customer customer)
			=> Ok(customer);		
	}
}
