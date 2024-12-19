using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_19_ParticipantsLib
{
	public class ParticipantsRepository
	{

		public int nextId = 1;
		private List<Participant> Participants = new List<Participant>();

		public ParticipantsRepository()
		{
			Participant p1 = new Participant { Name = "Anders", Age = 12, Country = "Denmark" };
			Participant p2 = new Participant { Name = "Henrik", Age = 12, Country = "Sweden" };
			Participant p3 = new Participant { Name = "John", Age = 12, Country = "Norway" };
			Participant p4 = new Participant { Name = "Mads", Age = 12, Country = "Finland" };
			Participant p5 = new Participant { Name = "Hans", Age = 12, Country = "Germany" };

			Add(p1);
			Add(p2);
			Add(p3);
			Add(p4);
			Add(p5);
		}


		public List<Participant> GetAll()
		{
			return new List<Participant>(Participants);
		}

		public Participant? GetById(int id)
		{
			return Participants.FirstOrDefault(x => x.Id == id);
		}

		public Participant Add(Participant participant)
		{
			participant.validate();

			participant.Id = nextId++;

			Participants.Add(participant);

			return participant;
		}


		public Participant? Delete(int id)
		{
			Participant? target = GetById(id);

			if (target == null)
			{
				return null;
			}

			Participants.Remove(target);	

			return target;
		}
	}
}
