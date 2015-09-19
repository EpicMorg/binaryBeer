using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BinaryBeer
{
    class StatMan
    {
        private static string _s = "data.xml";

        public static Item[] Get() {
            if ( !File.Exists( _s ) ) return new Item[] { };
            using ( var read = File.OpenRead( _s ) ) return (Item[]) new XmlSerializer( typeof( Item[] ) ).Deserialize( read );
        }

        public static void Add( Item i ) {
            var items = Get().ToList();
            items.Add( i );
            var fileStream = File.OpenWrite( _s );
            new XmlSerializer( typeof(Item[]) ).Serialize( fileStream, items.ToArray() );
        }
    }

    public class Item {
        public string BeerName { get; set; }
        public string Player { get; set; }
    }
}
