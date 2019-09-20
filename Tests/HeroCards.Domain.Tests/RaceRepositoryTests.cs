using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HeroCards.Domain.Tests
{
    [TestCategory("Race Repository")]
    [TestClass]
    public class RaceRepositoryTests
    {
        private RaceRepository raceRepository;

        public RaceRepositoryTests()
        {
            raceRepository = new RaceRepository();
        }

        [TestMethod]
        public void GetRaces_Returns_CorrectNumber()
        {
            Assert.AreEqual(5, raceRepository.GetRaces().Count());
        }

        [TestMethod]
        public void GetRacesWithSkill_Returns_CorrectNumber()
        {
            Assert.AreEqual(2, raceRepository.GetRacesWithSkill("Light-footed").Count());
        }
    }
}
