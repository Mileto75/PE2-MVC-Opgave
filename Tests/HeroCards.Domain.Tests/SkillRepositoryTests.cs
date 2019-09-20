using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HeroCards.Domain.Tests
{
    [TestCategory("Skill Repository")]
    [TestClass]
    public class SkillRepositoryTests
    {
        private SkillRepository skillRepository;

        public SkillRepositoryTests()
        {
            skillRepository = new SkillRepository();
        }

        [TestMethod]
        public void GetSkills_Returns_CorrectNumber()
        {
            Assert.AreEqual(16, skillRepository.GetSkills().Count());
        }

        [TestMethod]
        public void GetSkillByName_Returns_ValidObject()
        {
            Assert.IsTrue(skillRepository.GetSkillByName("Light-footed") != null);
            Assert.IsTrue(skillRepository.GetSkillByName("") == null);
        }
    }
}
