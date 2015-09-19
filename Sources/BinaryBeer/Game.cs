using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using static BinaryBeer.Properties.Resources;

namespace BinaryBeer {

    public class Beer {
        public Beer( string s,  Image image ) {
            Name = s;
            Image = image;
        }

        public string Name { get; set; }

        public virtual Image Image { get; set; }
        static Random r = new Random();

        public static IList<Beer> GetBeers() {
            return new Beer[] {
                new Beer(nameof(amstel), amstel),
                new Beer(nameof(amstel_premium), amstel_premium),
                new Beer(nameof(baltika_3), baltika_3),
                new Beer(nameof(baltika_praha), baltika_praha),
                new Beer(nameof(baltika_razliv), baltika_razliv),
                new Beer(nameof(baltika_vienna), baltika_vienna),
                new Beer(nameof(blanc), blanc),
                new Beer(nameof(boiler_maker), boiler_maker),
                new Beer(nameof(bud), bud),
                new Beer(nameof(california), california),
                new Beer(nameof(carlsberg), carlsberg),
                new Beer(nameof(edelweiss), edelweiss),
                new Beer(nameof(gosser), gosser),
                new Beer(nameof(heineken), heineken),
                new Beer(nameof(hoegaarden), hoegaarden),
                new Beer(nameof(holsten), holsten),
                new Beer(nameof(koff), koff),
                new Beer(nameof(kozel), kozel),
                new Beer(nameof(krusovice), krusovice),
                new Beer(nameof(lowenbrau), lowenbrau),
                new Beer(nameof(mythos), mythos),
                new Beer(nameof(neon_beer), neon_beer),
                new Beer(nameof(nevskoe_alive), nevskoe_alive),
                new Beer(nameof(nevskoe_classical), nevskoe_classical),
                new Beer(nameof(nevskoe_light), nevskoe_light),
                new Beer(nameof(ohota), ohota),
                new Beer(nameof(premiere), premiere),
                new Beer(nameof(staropramen), staropramen),
                new Beer(nameof(tryohgornoe), tryohgornoe),
                new Beer(nameof(tuborg), tuborg),
                new Beer(nameof(vienna_light), vienna_light),
                new Beer(nameof(zatecky_gus), zatecky_gus),
            }.Select( value=>new {value, sort=r.Next()} ).ToArray().OrderBy( a=>a.sort ).Select( a=>a.value ).ToArray();
        }
    }
}