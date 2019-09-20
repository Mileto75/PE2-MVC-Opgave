using System.Collections.Generic;
using System.Linq;

namespace HeroCards.Domain
{
    public class HeroRepository
    {
        SkillRepository skillRepository;
        protected Hero[] _heroes;

        public HeroRepository()
        {
            skillRepository = new SkillRepository();
            InitHeroes();
        }

        /// <summary>
        /// Gets all available Heroes
        /// </summary>
        /// <returns>A collection of Hero objects</returns>
        public IEnumerable<Hero> GetHeroes()
        {
            return _heroes;
        }

        /// <summary>
        /// Gets all Heroes that have a particular Skill
        /// </summary>
        /// <param name="skillName">The Skill name to look for, case insensitive</param>
        /// <returns>A collection of Hero objects</returns>
        public IEnumerable<Hero> GetHeroesWithSkill(string skillName)
        {
            return GetHeroes()
                .Where(h => h.Skills.Select(s => s.Name?.ToLower()).Contains(skillName?.ToLower()));
        }

        /// <summary>
        /// Gets all Heroes with Health greater than or equal to a given treshold
        /// </summary>
        /// <param name="minimumHealth">The minimum Health to look for</param>
        /// <returns>A collection of Hero objects</returns>
        public IEnumerable<Hero> GetHeroesWithHealth(int minimumHealth)
        {
            return GetHeroes()
                .Where(h => h.Health >= minimumHealth);
        }

        /// <summary>
        /// Gets all Heroes with Stamina greater than or equal to a given treshold
        /// </summary>
        /// <param name="minimumStamina">The minimum Stamina to look for</param>
        /// <returns>A collection of Hero objects</returns>
        public IEnumerable<Hero> GetHeroesWithStamina(int minimumStamina)
        {
            return GetHeroes()
                .Where(h => h.Stamina >= minimumStamina);
        }

        /// <summary>
        /// Gets all Heroes with Magic greater than or equal to a given treshold
        /// </summary>
        /// <param name="minimumMagic">The minimum Magic to look for</param>
        /// <returns>A collection of Hero objects</returns>
        public IEnumerable<Hero> GetHeroesWithMagic(int minimumMagic)
        {
            return GetHeroes()
                .Where(h => h.Magic >= minimumMagic);
        }

        protected void InitHeroes()
        {
            var allSkills = skillRepository.GetSkills();

            _heroes = new[]
            {
                new Hero{
                    Name = "Frodo",
                    Image = "frodo.jpg",
                    Health = 60,
                    Stamina = 120,
                    Magic = 30,
                    Race = Race.Halfling,
                    Skills = allSkills.Where(s =>
                        s.Name == "Invisibility" ||
                        s.Name == "Light-footed" ||
                        s.Name == "Sneaking")
                },
                new Hero{
                    Name = "Gandalf",
                    Image = "gandalf.jpg",
                    Health = 90,
                    Stamina = 80,
                    Magic = 200,
                    Race = Race.Wizard,
                    Skills = allSkills.Where(s =>
                        s.Name == "Flame of Anor" ||
                        s.Name == "Swordfighting" ||
                        s.Name == "Telepathy" ||
                        s.Name == "Animal Speech")
                },
                new Hero{
                    Name = "Aragorn",
                    Image = "aragorn.jpg",
                    Health = 100,
                    Stamina = 80,
                    Magic = 0,
                    Race = Race.Human,
                    Skills = allSkills.Where(s =>
                        s.Name == "Swordfighting" ||
                        s.Name == "Healing" ||
                        s.Name == "Animal Speech")
                },
                new Hero{
                    Name = "Legolas",
                    Image = "legolas.jpg",
                    Health = 90,
                    Stamina = 100,
                    Magic = 50,
                    Race = Race.Elf,
                    Skills = allSkills.Where(s =>
                        s.Name == "Archery" ||
                        s.Name == "Light-footed" ||
                        s.Name == "Dash")
                },
                new Hero{
                    Name = "Gimli",
                    Image = "gimli.jpg",
                    Health = 120,
                    Stamina = 70,
                    Magic = 0,
                    Race = Race.Dwarf,
                    Skills = allSkills.Where(s =>
                        s.Name == "Axefighting" ||
                        s.Name == "Mining" ||
                        s.Name == "Heavy Swing")
                },
                new Hero{
                    Name = "Boromir",
                    Image = "boromir.jpg",
                    Health = 100,
                    Stamina = 80,
                    Magic = 0,
                    Race = Race.Human,
                    Skills = allSkills.Where(s =>
                        s.Name == "Swordfighting" ||
                        s.Name == "Heavy Swing" ||
                        s.Name == "Epic Death")
                },
                new Hero{
                    Name = "Galadriel",
                    Image = "galadriel.jpg",
                    Health = 120,
                    Stamina = 60,
                    Magic = 150,
                    Race = Race.Elf,
                    Skills = allSkills.Where(s =>
                        s.Name == "Telekinesis" ||
                        s.Name == "Animal Speech" ||
                        s.Name == "Telepathy")
                },
                new Hero{
                    Name = "Radagast",
                    Image = "radagast.jpg",
                    Health = 90,
                    Stamina = 70,
                    Magic = 180,
                    Race = Race.Wizard,
                    Skills = allSkills.Where(s =>
                        s.Name == "Telekinesis" ||
                        s.Name == "Healing" ||
                        s.Name == "Animal Speech")
                },
            };
        }

    }
}
