using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Client.Model.Enums
{
    public class States
    {

        public class OneState
        {
            public static readonly byte Unobtained = 0;
        }

        public class TwoState : OneState
        {
            public static readonly byte Obtained = 1;
        }

        public class ThreeState : TwoState
        {
            public static readonly byte FirstUpgrade = 2;
        }
        public class FourState : ThreeState
        {
            public static readonly byte SecondUpgrade = 3;
        }
        public class FiveState : FourState
        {
            public static readonly byte ThirdUpgrade = 4;
        }

        public class Sticks : FourState { }
        public class Nuts : FourState { }
        public class Bombs : FourState { }
        public class Bow : FourState { }
        public class FireArrows : TwoState { }
        public class DinsFire : TwoState { }
        public class Slingshot : FourState { };
        public class Ocarina : ThreeState { };
        public class Hookshot : ThreeState { };
        public class IceArrows : TwoState { };
        public class FaroresWind : TwoState { };
        public class Boomerang : TwoState { };
        public class Lens : TwoState { };
        public class Hammer : TwoState { };
        public class LightArrows : TwoState { };
        public class NayrusLove : TwoState { };
        public class Bottle : FiveState { };
        public class Letter : TwoState { };
        public class Strength : FourState { };
        public class Scale : ThreeState { };

        public class KokiriSword : TwoState { };
        public class MasterSword : TwoState { };
        public class BiggoronSword : TwoState { };
        public class DekuShield : TwoState { };
        public class HylianShield : TwoState { };
        public class MirrorShield : TwoState { };
        public class KokiriTunic : OneState { };
        public class GoronTunic : TwoState { };
        public class ZoraTunic : TwoState { };
        public class KokiriBoots : OneState { };
        public class IronBoots : TwoState { };
        public class HoverBoots : TwoState { };

        public class SongZelda : TwoState { };
        public class SongEpona : TwoState { };
        public class SongSaria : TwoState { };
        public class SongSun : TwoState { };
        public class SongTime : TwoState { };
        public class SongStorms : TwoState { };
        public class SongScarecrow : TwoState { };
        public class SongMinuet : TwoState { };
        public class SongBolero : TwoState { };
        public class SongSerenade : TwoState { };
        public class SongRequiem : TwoState { };
        public class SongNocturne : TwoState { };
        public class SongPrelude : TwoState { };

        public class KokiriEmerald : TwoState { };
        public class GoronRuby : TwoState { };
        public class ZoraSapphire : TwoState { };
        public class ForestMedallion : TwoState { };
        public class FireMedallion : TwoState { };
        public class WaterMedallion : TwoState { };
        public class SpiritMedallion : TwoState { };
        public class ShadowMedallion : TwoState { };
        public class LightMedallion : TwoState { };

        public class Agony : TwoState { };
        public class MembershipCard : TwoState { };
        public class SkulltulaTokens : TwoState { };
        public class DoubleDefense : TwoState { };
        public class Magic : ThreeState { };
        public class Wallet : FourState { };
        
        //Skulltulas, HPieces, Hearts, Beans, Adult/Child Trade Sequences, FOOLs and TriPieces are cool and different
        public class Skulltulas
        {
            public static readonly byte max = 100;
        }
        public class HeartPieces
        {
            public static readonly byte max = 36;
        }
        public class HeartContainers
        {
            public static readonly byte max = 8;
        }
        public class Beans
        {
            public static readonly byte max = 10;
        }
        public class ChildTradeSequence
        {
            public static readonly byte max = 8;
        }
        public class AdultTradeSequence
        {
            public static readonly byte max = 11;
        }
        public class Fools
        {
            public static readonly byte max = byte.MaxValue;
        }
        public class TriforcePieces
        {
            public static readonly byte max = byte.MaxValue;
        }
    }
}
