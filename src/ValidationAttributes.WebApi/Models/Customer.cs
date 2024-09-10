using ValidationAttributes.WebApi.DataAnntations;

namespace ValidationAttributes.WebApi.Models
{
	public class Customer
	{
		public string Name { get; set; }
		
		public string Email { get; set; }

		[CustomerDateOfBirthValidation]
		public DateTime DateOfBirth { get; set; }
	}
}
