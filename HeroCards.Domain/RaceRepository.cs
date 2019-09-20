using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroCards.Domain
{
    public class RaceRepository
    {
        HeroRepository heroRepository;

        public RaceRepository()
        {
            heroRepository = new HeroRepository();
        }

        /// <summary>
        /// Returns all available Races
        /// </summary>
        /// <returns>A collection of Race enum values</returns>
        public IEnumerable<Race> GetRaces()
        {
            return Enum.GetValues(typeof(Race)).Cast<Race>();
        }

        /// <summary>
        /// Returns all Races in which a certain skill occurs
        /// </summary>
        /// <param name="skillName">The name of the skill to search, case insensitive</param>
        /// <returns>A collection of Race enum values</returns>
        public IEnumerable<Race> GetRacesWithSkill(string skillName)
        {
            return GetRaces()
                .Where(r => heroRepository.GetHeroes()
                            .Where(h => h.Skills.Select(s => s.Name?.ToLower()).Contains(skillName?.ToLower()))
                            .Select(h => h.Race).Contains(r))
                .Select(r => r);
        }
    }
}
