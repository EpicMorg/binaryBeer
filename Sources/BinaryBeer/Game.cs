using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BinaryBeer {
    //internal class Game {
    //    private readonly string _username;
    //    private IList<Set> sets;
    //    private int currentSet = 0;
    //    private int currentRound = 0;
    //    private int setSize = 8;
    //    private Set[] _sets;

    //    public Game( string username ) {
    //        _username = username;
    //        _sets = Beer.GetBeers()
    //            .Select( ( a, index ) => new {a, index} )
    //            .GroupBy( a => a.index / setSize )
    //            .Select( a => BuildSet( a.Select( b => b.a ).ToArray() ) )
    //            .ToArray();
    //    }

    //    private static Set BuildSet( IEnumerable<Beer> init ) {
    //        var arr = init.ToArray();
    //        var ret = new Set
    //        {
    //            RoundCount = (int) Math.Log( arr.Length, 2 ),
    //        };
    //        var rounds = new List<IList<ComparePair>>
    //        {
    //            arr.Select( ( value, index ) => new {value, index} ).GroupBy( a => a.index / 2 ).Select( grp => {
    //                var q = grp.Select( a => a.value ).ToArray();
    //                return new ComparePair()
    //                {
    //                    Right = q[ 0 ],
    //                    Left = q[ 1 ]
    //                };
    //            } ).ToArray()
    //        };
    //        for ( int i = 1; i < ret.RoundCount; i++ ) {
    //            rounds.Add(
    //                Enumerable.Range( 0, (int) ( ret.RoundCount / Math.Pow( 2, i + 1 ) ) )
    //                    .Select( a => new ComparePair() )
    //                    .ToArray() );
    //        }
    //        return ret;
    //    }


    //    public Set GetSet() {
    //        if ( currentSet < _sets.Length ) {
    //            return _sets[ currentSet ];
    //        }
    //        throw new NotImplementedException();
    //    }

    //    public bool SetWinner( int roundId, int setId ) {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class Set {
    //    public Beer Winner { get; set; }
    //    public IList<IList<ComparePair>> Rounds { get; set; }
    //    public int RoundCount { get; set; }
    //}

    //public class ComparePair {
    //    public Beer Left { get; set; }
    //    public Beer Right { get; set; }
    //    public bool Result { get; set; }
    //}

    public class Beer {
        public virtual string Name { get; set; }
        public virtual Image Image => null;

        public static IList<Beer> GetBeers() => Enumerable.Range( 0, 32 ).Select( a => new Beer
        {
            Name = "Beer #" + a
        } ).ToArray();
    }
}