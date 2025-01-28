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
            TmdbId = 1726
        };

        Title title1 = new Title
        {
            Id = 1,
            Name = "The Incredible Hulk",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/gKzYx79y0AQTL4UAk1cBQJ3nvrm.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/gKzYx79y0AQTL4UAk1cBQJ3nvrm.jpg",
            ReleasedAtUtc = new DateTime(2008, 6, 12),
            Description = "Scientist Bruce Banner scours the planet for an antidote to the unbridled force of rage within him: the Hulk. But when the military masterminds who dream of exploiting his powers force him back to civilization, he finds himself coming face to face with a new, deadly foe.",
            TmdbId = 1724
        };

        Title title2 = new Title
        {
            Id = 2,
            Name = "Iron Man 2",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6WBeq4fCfn7AN0o21W9qNcRF2l9.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/6WBeq4fCfn7AN0o21W9qNcRF2l9.jpg",
            ReleasedAtUtc = new DateTime(2010, 5, 7),
            Description = "With the world now aware of his dual life as the armored superhero Iron Man, billionaire inventor Tony Stark faces pressure from the government, the press and the public to share his technology with the military. Unwilling to let go of his invention, Stark, with Pepper Potts and James 'Rhodey' Rhodes at his side, must forge new alliances – and confront powerful enemies.",
            TmdbId = 10138
        };

        Title title3 = new Title
        {
            Id = 3,
            Name = "Thor",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/prSfAi1xGrhLQNxVSUFh61xQ4Qy.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/prSfAi1xGrhLQNxVSUFh61xQ4Qy.jpg",
            ReleasedAtUtc = new DateTime(2011, 5, 6),
            Description = "Against his father Odin's will, The Mighty Thor - a powerful but arrogant warrior god - recklessly reignites an ancient war. Thor is cast down to Earth and forced to live among humans as punishment. Once here, Thor learns what it takes to be a true hero when the most dangerous villain of his world sends the darkest forces of Asgard to invade Earth.",
            TmdbId = 10195
        };

        Title title4 = new Title
        {
            Id = 4,
            Name = "Captain America: The First Avenger",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/vSNxAJTlD0r02V9sPYpOjqDZXUK.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/vSNxAJTlD0r02V9sPYpOjqDZXUK.jpg",
            ReleasedAtUtc = new DateTime(2011, 7, 22),
            Description = "During World War II, Steve Rogers is a sickly man from Brooklyn who's transformed into super-soldier Captain America to aid in the war effort. Rogers must stop the Red Skull – Adolf Hitler's ruthless head of weaponry, and the leader of an organization that intends to use a mysterious device of untold powers for world domination.",
            TmdbId = 1771
        };

        Title title5 = new Title
        {
            Id = 5,
            Name = "The Avengers",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
            LargePosterUrl = "https://image.tmdb.org/t/p/original/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
            ReleasedAtUtc = new DateTime(2012, 4, 25),
            Description = "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!",
            TmdbId = 24428
        };

        Title title6 = new Title
        {
            Id = 6,
            Name = "Iron Man 3",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qhPtAc1TKbMPqNvcdXSOn9Bn7hZ.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/qhPtAc1TKbMPqNvcdXSOn9Bn7hZ.jpg",
            ReleasedAtUtc = new DateTime(2013, 4, 18),
            Description = "When Tony Stark's world is torn apart by a formidable terrorist called the Mandarin, he starts an odyssey of rebuilding and retribution.",
            TmdbId = 68721
        };

        // Factoids

        Factoid factoid0 = new Factoid
        {
            Description = "Iron Man - MW"
        };

        Factoid factoid1 = new Factoid
        {
            Description = "Tony Stark is Iron Man - genius, billionaire, playboy, philanthropist."
        };

        Factoid factoid2 = new Factoid
        {
            Description = "Pepper Potts is Tony Stark’s personal assistant."
        };

        Factoid factoid3 = new Factoid
        {
            Description = "Happy Hogan is Tony Stark’s chauffeur."
        };

        Factoid factoid4 = new Factoid
        {
            Description = "Rhodey (Lieutenant Colonel James Rhodes) is Tony Stark’s closest friend, and a military officer."
        };

        Factoid factoid5 = new Factoid
        {
            Description = "Agent Coulson is an agent of SHIELD, an agency offering to help train Tony."
        };

        Factoid factoid6 = new Factoid
        {
            Description = "In the final shot of the film, Tony reveals to the world, 'I am Iron Man.'"
        };

        Factoid factoid7 = new Factoid
        {
            Description = "Nick Fury is a shadowy figure who introduced himself to Tony in the post-credits scene - '... you've become part of a bigger universe. You just don't know it yet.'"
        };

        Factoid factoid8 = new Factoid
        {
            Description = "Thor"
        };

        Factoid factoid9 = new Factoid
        {
            Description = "Director Nick Fury and Agent Coulson are agents of SHIELD, an agency forming the 'Avengers Initiative.'"
        };

        Factoid factoid10 = new Factoid
        {
            Description = "Bruce Banner is the Hulk, a brilliant scientist who turns into a raging beast when angry."
        };

        Factoid factoid11 = new Factoid
        {
            Description = "Bruce lives remotely to avoid being hunted by the US military."
        };

        Factoid factoid12 = new Factoid
        {
            Description = "Despite initial apprehension, Director Fury confides details of the Avengers Initiative to Tony."
        };

        Factoid factoid13 = new Factoid
        {
            Description = "Natasha Romanoff is the Black Widow, superspy, agent of SHIELD."
        };

        Factoid factoid14 = new Factoid
        {
            Description = "Thor Odinson is the god of thunder, prince and heir to the throne of Asgard."
        };

        Factoid factoid15 = new Factoid
        {
            Description = "Loki Laufeyson is the god of lies and a born trickster, Thor’s adopted brother."
        };

        Factoid factoid16 = new Factoid
        {
            Description = "After a foiled attempt to destroy the Nine Realms, Loki fell from the Bifrost in Asgard into the void of space."
        };

        Factoid factoid17 = new Factoid
        {
            Description = "Clint Barton is Hawkeye, an archer with perfect accuracy, agent of SHIELD."
        };

        Factoid factoid18 = new Factoid
        {
            Description = "Steve Rogers is Captain America, super-soldier from WWII."
        };

        Factoid factoid19 = new Factoid
        {
            Description = "Steve fought in WWII alongside scientist Howard Stark, future father of Tony Stark."
        };

        Factoid factoid20 = new Factoid
        {
            Description = "The Tesseract is an alien cube of cosmic power."
        };

        Factoid factoid21 = new Factoid
        {
            Description = "The Tesseract was recovered by Howard Stark."
        };

        Factoid factoid22 = new Factoid
        {
            Description = "Steve intentionally crashed HYDRA’s Valkyrie bomber airship into the icy waters of the Arctic where he remained frozen for almost seventy years until being discovered and recovered by SHIELD."
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

        if (!context.Factoids.Any())
        {
            var factoids = new List<Factoid>
            {
                factoid0,
                factoid1,
                factoid2,
                factoid3,
                factoid4,
                factoid5,
                factoid6,
                factoid7,
                factoid8,
                factoid9,
                factoid10,
                factoid11,
                factoid12,
                factoid13,
                factoid14,
                factoid15,
                factoid16,
                factoid17,
                factoid18,
                factoid19,
                factoid20,
                factoid21,
                factoid22
            };
            context.Factoids.AddRange(factoids);
        }

        context.SaveChanges();
    }
}