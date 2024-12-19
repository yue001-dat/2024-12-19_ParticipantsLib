using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_19_ParticipantsLib
{
	public class Participant
	{

		public int Id { get; set; }
		public string? Name { get; set; }
		public int Age { get; set; }
		public string? Country { get; set; }	


		public void validateName()
		{
			if (Name != null && Name.Length < 2)
			{
				throw new ArgumentOutOfRangeException("Name is too short. Must be atleast 2 characters.");	
			}
		}

		public void validateAge()
		{
			if (Age < 12)
			{
				throw new ArgumentOutOfRangeException("Age is too low. Must be atleast 12 years old.");
			}
		}	

		public void validateCountry()
		{
			if (Country != null && Country.Length < 3)
			{
				throw new ArgumentOutOfRangeException("Country is too short. Must be atleast 3 characters.");
			}
		}	

		public void validate()
		{
			validateName();
			validateAge();
			validateCountry();
		}

		public override string ToString()
		{
			return $"Id: {Id}, Name: {Name}, Age: {Age}, Country: {Country}";
		}

	}
}
