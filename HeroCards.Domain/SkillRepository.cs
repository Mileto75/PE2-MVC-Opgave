using System.Collections.Generic;
using System.Linq;

namespace HeroCards.Domain
{
    public class SkillRepository
    {
        /// <summary>
        /// Returns all available Skills
        /// </summary>
        /// <returns>A collection of Skill objects</returns>
        public IEnumerable<Skill> GetSkills()
        {
            return _skills;
        }

        /// <summary>
        /// Returns a single Skill object by the name
        /// </summary>
        /// <param name="skillName">The name of the Skill to search, case insensitive</param>
        /// <returns>The first Skill matching given <para>skillName</para></returns>
        public Skill GetSkillByName(string skillName)
        {
            return GetSkills().FirstOrDefault(s => s.Name?.ToLower() == skillName?.ToLower());
        }


        protected static Skill[] _skills = new[]
        {
            new Skill
            {
                Name = "Flame of Anor",
                Image = "flameofanor.svg",
                MagicCost = 40,
                StaminaCost = 0
            },
            new Skill
            {
                Name = "Telekinesis",
                Image = "telekinesis.svg",
                MagicCost = 20,
                StaminaCost = 0
            },
            new Skill
            {
                Name = "Swordfighting",
                Image = "swordfighting.svg",
                MagicCost = 0,
                StaminaCost = 20
            },
            new Skill
            {
                Name = "Axefighting",
                Image = "axefighting.svg",
                MagicCost = 0,
                StaminaCost = 20
            },
            new Skill
            {
                Name = "Invisibility",
                Image = "invisibility.svg",
                MagicCost = 40,
                StaminaCost = 40
            },
            new Skill
            {
                Name = "Archery",
                Image = "archery.svg",
                MagicCost = 0,
                StaminaCost = 20
            },
            new Skill
            {
                Name = "Telepathy",
                Image = "telepathy.svg",
                MagicCost = 15,
                StaminaCost = 0
            },
            new Skill
            {
                Name = "Healing",
                Image = "healing.svg",
                MagicCost = 5,
                StaminaCost = 10
            },
            new Skill
            {
                Name = "Animal Speech",
                Image = "animalspeech.svg",
                MagicCost = 20,
                StaminaCost = 0
            },
            new Skill
            {
                Name = "Light-footed",
                Image = "lightfooted.svg",
                MagicCost = 30,
                StaminaCost = 0
            },
            new Skill
            {
                Name = "Sneaking",
                Image = "sneaking.svg",
                MagicCost = 0,
                StaminaCost = 10
            },
            new Skill
            {
                Name = "Mining",
                Image = "mining.svg",
                MagicCost = 0,
                StaminaCost = 50
            },
            new Skill
            {
                Name = "Dash",
                Image = "dash.svg",
                MagicCost = 0,
                StaminaCost = 30
            },
            new Skill
            {
                Name = "Heavy Swing",
                Image = "heavyswing.svg",
                MagicCost = 0,
                StaminaCost = 40
            },
            new Skill
            {
                Name = "Epic Death",
                Image = "epicdeath.svg",
                MagicCost = 0,
                StaminaCost = 100
            },
            new Skill
            {
                Name = "Second Sense",
                Image = "secondsense.svg",
                MagicCost = 80,
                StaminaCost = 0
            },
        };

    }
}
