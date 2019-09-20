using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HeroCards.Domain.Tests
{

    [TestCategory("Hero Repository")]
    [TestClass]
    public class HeroRepositoryTests
    {
        private HeroRepository heroRepository;

        public HeroRepositoryTests()
        {
            heroRepository = new HeroRepository();
        }

        [TestMethod]
        public void GetHeroes_Returns_CorrectNumber()
        {
            Assert.AreEqual(8, heroRepository.GetHeroes().Count());
        }

        [TestMethod]
        public void GetHeroesWithSkill_Returns_CorrectNumber()
        {
            Assert.AreEqual(2, heroRepository.GetHeroesWithSkill("Telekinesis").Count());
        }
        
        [TestMethod]
        public void GetHeroesWithHealth_Returns_CorrectNumber()
        {
            Assert.AreEqual(4, heroRepository.GetHeroesWithHealth(100).Count());
        }

        [TestMethod]
        public void GetHeroesWithStamina_Returns_CorrectNumber()
        {
            Assert.AreEqual(3, heroRepository.GetHeroesWithMagic(100).Count());
        }

        [TestMethod]
        public void GetHeroesWithMagic_Returns_CorrectNumber()
        {
            Assert.AreEqual(2, heroRepository.GetHeroesWithStamina(100).Count());
        }
    }
}
