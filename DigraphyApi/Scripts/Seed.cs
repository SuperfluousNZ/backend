using DigraphyApi.Data;
using DigraphyApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DigraphyApi.Scripts;

public class Seed(AppDbContext context)
{
    public void SeedDataContext()
    {
        // Collections

        Collection collection0 = new Collection
        {
            Id = 0,
            Name = "Marvel Cinematic Universe",
            IsVerified = true
        };

        // Orders

        Order order0 = new Order
        {
            Id = 0,
            Name = "Release Order",
            Description = "",
            IsVerified = true,
            CreatedAtUtc = new DateTime(2025, 2, 23, 0, 0, 0, DateTimeKind.Utc),
            EditedAtUtc = new DateTime(2025, 2, 23, 0, 0, 0, DateTimeKind.Utc),
            Collection = collection0
        };

        Order order1 = new Order
        {
            Id = 1,
            Name = "Chronological",
            Description = "",
            IsVerified = true,
            CreatedAtUtc = new DateTime(2025, 2, 24, 0, 0, 0, DateTimeKind.Utc),
            EditedAtUtc = new DateTime(2025, 2, 24, 0, 0, 0, DateTimeKind.Utc),
            Collection = collection0
        };

        // Titles

        Title title0 = new Title
        {
            Id = 0,
            Name = "Iron Man",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/78lPtwv72eTNqFW9COBYI0dWDJa.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/78lPtwv72eTNqFW9COBYI0dWDJa.jpg",
            ReleasedAtUtc = new DateTime(2008, 4, 30, 0, 0, 0, DateTimeKind.Utc),
            Description = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",
            TmdbId = 1726
        };

        Title title1 = new Title
        {
            Id = 1,
            Name = "The Incredible Hulk",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/gKzYx79y0AQTL4UAk1cBQJ3nvrm.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/gKzYx79y0AQTL4UAk1cBQJ3nvrm.jpg",
            ReleasedAtUtc = new DateTime(2008, 6, 12, 0, 0, 0, DateTimeKind.Utc),
            Description = "Scientist Bruce Banner scours the planet for an antidote to the unbridled force of rage within him: the Hulk. But when the military masterminds who dream of exploiting his powers force him back to civilization, he finds himself coming face to face with a new, deadly foe.",
            TmdbId = 1724
        };

        Title title2 = new Title
        {
            Id = 2,
            Name = "Iron Man 2",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6WBeq4fCfn7AN0o21W9qNcRF2l9.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/6WBeq4fCfn7AN0o21W9qNcRF2l9.jpg",
            ReleasedAtUtc = new DateTime(2010, 5, 7, 0, 0, 0, DateTimeKind.Utc),
            Description = "With the world now aware of his dual life as the armored superhero Iron Man, billionaire inventor Tony Stark faces pressure from the government, the press and the public to share his technology with the military. Unwilling to let go of his invention, Stark, with Pepper Potts and James 'Rhodey' Rhodes at his side, must forge new alliances – and confront powerful enemies.",
            TmdbId = 10138
        };

        Title title3 = new Title
        {
            Id = 3,
            Name = "Thor",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/prSfAi1xGrhLQNxVSUFh61xQ4Qy.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/prSfAi1xGrhLQNxVSUFh61xQ4Qy.jpg",
            ReleasedAtUtc = new DateTime(2011, 5, 6, 0, 0, 0, DateTimeKind.Utc),
            Description = "Against his father Odin's will, The Mighty Thor - a powerful but arrogant warrior god - recklessly reignites an ancient war. Thor is cast down to Earth and forced to live among humans as punishment. Once here, Thor learns what it takes to be a true hero when the most dangerous villain of his world sends the darkest forces of Asgard to invade Earth.",
            TmdbId = 10195
        };

        Title title4 = new Title
        {
            Id = 4,
            Name = "Captain America: The First Avenger",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/vSNxAJTlD0r02V9sPYpOjqDZXUK.jpg",
            LargePosterUrl = "https://www.themoviedb.org/t/p/original/vSNxAJTlD0r02V9sPYpOjqDZXUK.jpg",
            ReleasedAtUtc = new DateTime(2011, 7, 22, 0, 0, 0, DateTimeKind.Utc),
            Description = "During World War II, Steve Rogers is a sickly man from Brooklyn who's transformed into super-soldier Captain America to aid in the war effort. Rogers must stop the Red Skull – Adolf Hitler's ruthless head of weaponry, and the leader of an organization that intends to use a mysterious device of untold powers for world domination.",
            TmdbId = 1771
        };

        Title title5 = new Title
        {
            Id = 5,
            Name = "The Avengers",
            SmallPosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
            LargePosterUrl = "https://image.tmdb.org/t/p/original/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg",
            ReleasedAtUtc = new DateTime(2012, 4, 25, 0, 0, 0, DateTimeKind.Utc),
            Description = "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!",
            TmdbId = 24428
        };

        // Factoids

        Factoid factoid0 = new Factoid
        {
            Id = 0,
            Description = "Tony Stark is Iron Man - genius, billionaire, playboy, philanthropist."
        };

        Factoid factoid1 = new Factoid
        {
            Id = 1,
            Description = "Pepper Potts is Tony Stark’s personal assistant."
        };

        Factoid factoid2 = new Factoid
        {
            Id = 2,
            Description = "Happy Hogan is Tony Stark’s chauffeur."
        };

        Factoid factoid3 = new Factoid
        {
            Id = 3,
            Description = "Rhodey (Lieutenant Colonel James Rhodes) is Tony Stark’s closest friend, and a military officer."
        };

        Factoid factoid4 = new Factoid
        {
            Id = 4,
            Description = "Agent Coulson is an agent of SHIELD, an agency offering to help train Tony."
        };

        Factoid factoid5 = new Factoid
        {
            Id = 5,
            Description = "In the final shot of the film, Tony reveals to the world, 'I am Iron Man.'"
        };

        Factoid factoid6 = new Factoid
        {
            Id = 6,
            Description = "Nick Fury is a shadowy figure who introduced himself to Tony in the post-credits scene - '... you've become part of a bigger universe. You just don't know it yet.'"
        };

        Factoid factoid7 = new Factoid
        {
            Id = 7,
            Description = "Director Nick Fury and Agent Coulson are agents of SHIELD, an agency forming the 'Avengers Initiative.'"
        };

        Factoid factoid8 = new Factoid
        {
            Id = 8,
            Description = "Bruce Banner is the Hulk, a brilliant scientist who turns into a raging beast when angry."
        };

        Factoid factoid9 = new Factoid
        {
            Id = 9,
            Description = "Bruce lives remotely to avoid being hunted by the US military."
        };

        Factoid factoid10 = new Factoid
        {
            Id = 10,
            Description = "Despite initial apprehension, Director Fury confides details of the Avengers Initiative to Tony."
        };

        Factoid factoid11 = new Factoid
        {
            Id = 11,
            Description = "Natasha Romanoff is the Black Widow, superspy, agent of SHIELD."
        };

        Factoid factoid12 = new Factoid
        {
            Id = 12,
            Description = "Thor Odinson is the god of thunder, prince and heir to the throne of Asgard."
        };

        Factoid factoid13 = new Factoid
        {
            Id = 13,
            Description = "Loki Laufeyson is the god of lies and a born trickster, Thor’s adopted brother."
        };

        Factoid factoid14 = new Factoid
        {
            Id = 14,
            Description = "After a foiled attempt to destroy the Nine Realms, Loki fell from the Bifrost in Asgard into the void of space."
        };

        Factoid factoid15 = new Factoid
        {
            Id = 15,
            Description = "Clint Barton is Hawkeye, an archer with perfect accuracy, agent of SHIELD."
        };

        Factoid factoid16 = new Factoid
        {
            Id = 16,
            Description = "Steve Rogers is Captain America, super-soldier from WWII."
        };

        Factoid factoid17 = new Factoid
        {
            Id = 17,
            Description = "Steve fought in WWII alongside scientist Howard Stark, future father of Tony Stark."
        };

        Factoid factoid18 = new Factoid
        {
            Id = 18,
            Description = "The Tesseract is an alien cube of cosmic power."
        };

        Factoid factoid19 = new Factoid
        {
            Id = 19,
            Description = "The Tesseract was recovered by Howard Stark."
        };

        Factoid factoid20 = new Factoid
        {
            Id = 20,
            Description = "Steve intentionally crashed HYDRA’s Valkyrie bomber airship into the icy waters of the Arctic where he remained frozen for almost seventy years until being discovered and recovered by SHIELD."
        };

        // Collection Titles

        // MCU
        var colTitles0 = new List<Title>
        {
            title0,
            title1,
            title2,
            title3,
            title4,
            title5
        };
        collection0.Titles.AddRange(colTitles0);

        // Order Titles

        // release order
        var ordTitles0 = new OrderTitle
        {
            TitleId = 0,
            OrderId = 0,
            Index = 0
        };
        var ordTitles1 = new OrderTitle
        {
            TitleId = 1,
            OrderId = 0,
            Index = 1
        };
        var ordTitles2 = new OrderTitle
        {
            TitleId = 2,
            OrderId = 0,
            Index = 2
        };
        var ordTitles3 = new OrderTitle
        {
            TitleId = 3,
            OrderId = 0,
            Index = 3
        };
        var ordTitles4 = new OrderTitle
        {
            TitleId = 4,
            OrderId = 0,
            Index = 4
        };
        var ordTitles5 = new OrderTitle
        {
            TitleId = 5,
            OrderId = 0,
            Index = 5
        };

        // chronological order
        var ordTitles6 = new OrderTitle
        {
            TitleId = 4,
            OrderId = 1,
            Index = 0
        };
        var ordTitles7 = new OrderTitle
        {
            TitleId = 0,
            OrderId = 1,
            Index = 1
        };
        var ordTitles8 = new OrderTitle
        {
            TitleId = 2,
            OrderId = 1,
            Index = 2
        };
        var ordTitles9 = new OrderTitle
        {
            TitleId = 1,
            OrderId = 1,
            Index = 3
        };
        var ordTitles10 = new OrderTitle
        {
            TitleId = 3,
            OrderId = 1,
            Index = 4
        };
        var ordTitles11 = new OrderTitle
        {
            TitleId = 5,
            OrderId = 1,
            Index = 5
        };

        // contained factoids relation

        var conFactoids0 = new List<Factoid> // Iron Man
        {
            factoid0,
            factoid1,
            factoid2,
            factoid3,
            factoid4,
            factoid5,
            factoid6
        };
        title0.ContainedFactoids.AddRange(conFactoids0);

        var conFactoids1 = new List<Factoid> // Hulk
        {
            factoid8,
            factoid9
        };
        title1.ContainedFactoids.AddRange(conFactoids1);

        var conFactoids2 = new List<Factoid> // Iron Man 2
        {
            factoid0,
            factoid7,
            factoid10,
            factoid11
        };
        title2.ContainedFactoids.AddRange(conFactoids2);

        var conFactoids3 = new List<Factoid> // Thor
        {
            factoid12,
            factoid13,
            factoid14,
            factoid15
        };
        title3.ContainedFactoids.AddRange(conFactoids3);

        var conFactoids4 = new List<Factoid> // Captain America
        {
            factoid16,
            factoid17,
            factoid18,
            factoid19,
            factoid20
        };
        title4.ContainedFactoids.AddRange(conFactoids4);

        // required factoids relation

        // Iron Man 2
        var reqFactoids0 = new FactoidsImportance
        {
            FactoidId = 0,
            TitleId = 2,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids1 = new FactoidsImportance
        {
            FactoidId = 1,
            TitleId = 2,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids2 = new FactoidsImportance
        {
            FactoidId = 2,
            TitleId = 2,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids3 = new FactoidsImportance
        {
            FactoidId = 3,
            TitleId = 2,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids4 = new FactoidsImportance
        {
            FactoidId = 4,
            TitleId = 2,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids5 = new FactoidsImportance
        {
            FactoidId = 5,
            TitleId = 2,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids6 = new FactoidsImportance
        {
            FactoidId = 6,
            TitleId = 2,
            Importance = FactoidImportance.MUST
        };

        // Thor
        var reqFactoids7 = new FactoidsImportance
        {
            FactoidId = 7,
            TitleId = 3,
            Importance = FactoidImportance.MUST
        };

        // Avengers
        var reqFactoids8 = new FactoidsImportance
        {
            FactoidId = 0,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids9 = new FactoidsImportance
        {
            FactoidId = 7,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids10 = new FactoidsImportance
        {
            FactoidId = 8,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids11 = new FactoidsImportance
        {
            FactoidId = 9,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids12 = new FactoidsImportance
        {
            FactoidId = 10,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids13 = new FactoidsImportance
        {
            FactoidId = 11,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids14 = new FactoidsImportance
        {
            FactoidId = 12,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids15 = new FactoidsImportance
        {
            FactoidId = 13,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids16 = new FactoidsImportance
        {
            FactoidId = 14,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids17 = new FactoidsImportance
        {
            FactoidId = 15,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids18 = new FactoidsImportance
        {
            FactoidId = 16,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids19 = new FactoidsImportance
        {
            FactoidId = 17,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids20 = new FactoidsImportance
        {
            FactoidId = 18,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids21 = new FactoidsImportance
        {
            FactoidId = 19,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };
        var reqFactoids22 = new FactoidsImportance
        {
            FactoidId = 20,
            TitleId = 5,
            Importance = FactoidImportance.MUST
        };

        if (!context.Collections.Any())
        {
            var collections = new List<Collection>
            {
                collection0
            };
            context.Collections.RemoveRange(context.Collections);
            context.Collections.AddRange(collections);
            context.SaveChanges();
        }

        if (!context.Orders.Any())
        {
            var orders = new List<Order>
            {
                order0,
                order1
            };
            context.Orders.RemoveRange(context.Orders);
            context.Orders.AddRange(orders);
            context.SaveChanges();
        }

        if (!context.Titles.Any())
        {
            var titles = new List<Title>
            {
                title0,
                title1,
                title2,
                title3,
                title4,
                title5
            };
            context.Titles.RemoveRange(context.Titles);
            context.Titles.AddRange(titles);
            context.SaveChanges();
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
                factoid20
            };
            context.Factoids.RemoveRange(context.Factoids);
            context.Factoids.AddRange(factoids);
            context.SaveChanges();
        }

        if (!context.FactoidsImportances.Any())
        {
            var factoidsImportances = new List<FactoidsImportance>
            {
                reqFactoids0,
                reqFactoids1,
                reqFactoids2,
                reqFactoids3,
                reqFactoids4,
                reqFactoids5,
                reqFactoids6,
                reqFactoids7,
                reqFactoids8,
                reqFactoids9,
                reqFactoids10,
                reqFactoids11,
                reqFactoids12,
                reqFactoids13,
                reqFactoids14,
                reqFactoids15,
                reqFactoids16,
                reqFactoids17,
                reqFactoids18,
                reqFactoids19,
                reqFactoids20,
                reqFactoids21,
                reqFactoids22
            };
            context.FactoidsImportances.RemoveRange(context.FactoidsImportances);
            context.FactoidsImportances.AddRange(factoidsImportances);
            context.SaveChanges();
        }

        if (!context.OrderTitles.Any())
        {
            var orderTitles = new List<OrderTitle>
            {
                ordTitles0,
                ordTitles1,
                ordTitles2,
                ordTitles3,
                ordTitles4,
                ordTitles5,
                ordTitles6,
                ordTitles7,
                ordTitles8,
                ordTitles9,
                ordTitles10,
                ordTitles11
            };
            context.OrderTitles.RemoveRange(context.OrderTitles);
            context.OrderTitles.AddRange(orderTitles);
            context.SaveChanges();
        }

        context.SaveChanges();
    }
}
