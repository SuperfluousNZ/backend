using DigraphyApi.Data;
using DigraphyApi.Models;

namespace DigraphyApi.Scripts;

public class Seed(AppDbContext context)
{
    public void SeedDataContext()
    {
        // Titles

        Title title0 = new Title
        {
            Id = 0,
            Name = "Iron Man",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/78lPtwv72eTNqFW9COBYI0dWDJa.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/78lPtwv72eTNqFW9COBYI0dWDJa.jpg",
            ReleasedAtUtc = new DateTime(2008, 4, 30),
            Description = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",
            TmdbId = 1726,
            ContainedFactoids = [],
            Collections = [],
            RequiredFactoids = [],
            RequiredFactoidsImportance = [],
            Orders = [],
            OrderIndicies = []
        };

        Title title1 = new Title
        {
            Id = 1,
            Name = "The Incredible Hulk",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/gKzYx79y0AQTL4UAk1cBQJ3nvrm.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/gKzYx79y0AQTL4UAk1cBQJ3nvrm.jpg",
            ReleasedAtUtc = new DateTime(2008, 6, 12),
            Description = "Scientist Bruce Banner scours the planet for an antidote to the unbridled force of rage within him: the Hulk. But when the military masterminds who dream of exploiting his powers force him back to civilization, he finds himself coming face to face with a new, deadly foe.",
            TmdbId = 1724,
            ContainedFactoids = [],
            Collections = [],
            RequiredFactoids = [],
            RequiredFactoidsImportance = [],
            Orders = [],
            OrderIndicies = []
        };

        Title title2 = new Title
        {
            Id = 2,
            Name = "Iron Man 2",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6WBeq4fCfn7AN0o21W9qNcRF2l9.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/6WBeq4fCfn7AN0o21W9qNcRF2l9.jpg",
            ReleasedAtUtc = new DateTime(2010, 5, 7),
            Description = "With the world now aware of his dual life as the armored superhero Iron Man, billionaire inventor Tony Stark faces pressure from the government, the press and the public to share his technology with the military. Unwilling to let go of his invention, Stark, with Pepper Potts and James 'Rhodey' Rhodes at his side, must forge new alliances – and confront powerful enemies.",
            TmdbId = 10138,
            ContainedFactoids = [],
            Collections = [],
            RequiredFactoids = [],
            RequiredFactoidsImportance = [],
            Orders = [],
            OrderIndicies = []
        };

        Title title3 = new Title
        {
            Id = 3,
            Name = "Thor",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/prSfAi1xGrhLQNxVSUFh61xQ4Qy.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/prSfAi1xGrhLQNxVSUFh61xQ4Qy.jpg",
            ReleasedAtUtc = new DateTime(2011, 5, 6),
            Description = "Against his father Odin's will, The Mighty Thor - a powerful but arrogant warrior god - recklessly reignites an ancient war. Thor is cast down to Earth and forced to live among humans as punishment. Once here, Thor learns what it takes to be a true hero when the most dangerous villain of his world sends the darkest forces of Asgard to invade Earth.",
            TmdbId = 10195,
            ContainedFactoids = [],
            Collections = [],
            RequiredFactoids = [],
            RequiredFactoidsImportance = [],
            Orders = [],
            OrderIndicies = []
        };

        Title title4 = new Title
        {
            Id = 4,
            Name = "Captain America: The First Avenger",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/vSNxAJTlD0r02V9sPYpOjqDZXUK.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/vSNxAJTlD0r02V9sPYpOjqDZXUK.jpg",
            ReleasedAtUtc = new DateTime(2011, 7, 22),
            Description = "During World War II, Steve Rogers is a sickly man from Brooklyn who's transformed into super-soldier Captain America to aid in the war effort. Rogers must stop the Red Skull – Adolf Hitler's ruthless head of weaponry, and the leader of an organization that intends to use a mysterious device of untold powers for world domination.",
            TmdbId = 1771,
            ContainedFactoids = [],
            Collections = [],
            RequiredFactoids = [],
            RequiredFactoidsImportance = [],
            Orders = [],
            OrderIndicies = []
        };

        Title title5 = new Title
        {
            Id = 5,
            Name = "The Avengers",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
            LargePosterUrl = "https://image.tmdb.org/t/p/original/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
            ReleasedAtUtc = new DateTime(2012, 4, 25),
            Description = "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!",
            TmdbId = 24428,
            ContainedFactoids = [],
            Collections = [],
            RequiredFactoids = [],
            RequiredFactoidsImportance = [],
            Orders = [],
            OrderIndicies = []
        };

        Title title6 = new Title
        {
            Id = 6,
            Name = "Iron Man 3",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qhPtAc1TKbMPqNvcdXSOn9Bn7hZ.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/qhPtAc1TKbMPqNvcdXSOn9Bn7hZ.jpg",
            ReleasedAtUtc = new DateTime(2013, 4, 18),
            Description = "When Tony Stark's world is torn apart by a formidable terrorist called the Mandarin, he starts an odyssey of rebuilding and retribution.",
            TmdbId = 68721,
            ContainedFactoids = [],
            Collections = [],
            RequiredFactoids = [],
            RequiredFactoidsImportance = [],
            Orders = [],
            OrderIndicies = []
        };

        if (!context.Titles.Any())
        {
            var titles = new List<Title>
            {
                title0,
                title1,
                title2,
                title3,
                title4,
                title5,
                title6
            };
            context.Titles.AddRange(titles);
        }

        context.SaveChanges();
    }
}