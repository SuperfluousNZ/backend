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
            Description = "Scientist Bruce Banner scours the planet for an antidote to the unbridled force of rage within him: the Hulk.",
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
            Description = "With the world now aware of his identity as Iron Man, Tony Stark must contend with both his declining health and a vengeful madman.",
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
            Description = "The powerful but arrogant god Thor is cast out of Asgard to live amongst humans in Midgard (Earth).",
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
            Description = "Steve Rogers, a rejected military soldier, transforms into Captain America after taking a dose of a 'Super-Soldier serum'.",
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
            Description = "Plagued with worry and insomnia since saving New York from destruction, Tony Stark is now more dependent on the suits that give him his Iron Man persona - so much so that every aspect of his life is affected, including his relationship with Pepper. After a malevolent enemy known as the Mandarin reduces his personal world to rubble, Tony must rely solely on instinct and ingenuity to avenge his losses and protect the people he loves.",
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