using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2024_12_19_ParticipantsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_19_ParticipantsLib.Tests
{
	[TestClass()]
	public class ParticipantRepositoryDbTests
	{
		private ParticipantRepositoryDb _participantRepositoryDb = new ParticipantRepositoryDb();

		Participant p1 = new Participant { Name = "Anders", Age = 37, Country = "Denmark" };	
		Participant p2 = new Participant { Name = "Morten", Age = 42, Country = "Denmark" };	
		Participant p3 = new Participant { Name = "Nilma", Age = 25, Country = "Libanon" };	
		Participant p4 = new Participant { Name = "Yusuf", Age = 32, Country = "Yusuf" };	

		[TestInitialize]
		public void InitOnce()
		{
			//Clear Db After each use
			_participantRepositoryDb.TruncateDb();
		}

		[TestMethod()]
		public void GetAllTest()
		{
			_participantRepositoryDb.Add(p1);
			_participantRepositoryDb.Add(p2);

			Assert.IsTrue(_participantRepositoryDb.GetAll().Count() > 0, "No Rows Returned. Failed to Add.");
		}

		[TestMethod()]
		public void GetByIdTest()
		{
			Participant result = _participantRepositoryDb.Add(p1);	

			Assert.AreEqual(p1.Name, _participantRepositoryDb.GetById(result.Id).Name, "Failed to Get Participant by Id");
		}
	}
}