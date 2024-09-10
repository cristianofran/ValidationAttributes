using System.ComponentModel.DataAnnotations;
using ValidationAttributes.WebApi.DataAnntations;

namespace ValidationAttributes.WebApi.Models
{
	public class Customer
	{
		public string Name { get; set; }
		
		[Required]
		public string Email { get; set; }

		[DateOfBirthValidation]
		public DateTime DateOfBirth { get; set; }

		[CityValidation]
		public string City { get; set; }
	}
}
