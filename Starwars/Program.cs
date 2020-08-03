using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Starwars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = LoadData();

            #region Assignment 1
            ////Assignment 1 Query
            //var assignnment1 = from planet in planets
            //                   where planet.Name.ToLower().StartsWith("m")
            //                   select planet;
            ////Assignment 1 Lamdba
            //var assignnment1L = planets.Where(p => p.Name.ToLower().StartsWith("m"));
            //foreach ( var assignment in assignnment1L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion

            #region Assignment 2
            ////Assignment 2 Query
            //var assignment2 = from planet in planets
            //                  where planet.Name.ToLower().Contains("y")
            //                  select planet;
            //var assignment2L = planets.Where(p => p.Name.Contains("y"));
            //foreach (var assignment in assignment2L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 3
            //int _min = 9;
            //int _max = 15;
            //var assignment3 = from planet in planets
            //                  where planet.Name.Length < _max && planet.Name.Length > _min
            //                  select planet;
            //var assignment3L = planets.Where(p => p.Name.Length < _max && p.Name.Length > _min);
            //foreach (var assignment in assignment3L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 4
            //var assignment4 = from planet in planets
            //                  where planet.Name.ToLower()[1] == 'a' && planet.Name.EndsWith("e")
            //                  select planet;
            //var assignment4L = planets.Where(p => p.Name.ToLower()[1] == 'a' && p.Name.EndsWith("e"));
            //foreach (var assignment in assignment4L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 5
            //var assignment5 = from planet in planets
            //                  orderby planet.RotationPeriod ascending
            //                  where planet.RotationPeriod > 40
            //                  select planet;
            //var assignment5L = planets.OrderBy(o => o.RotationPeriod).Where(p => p.RotationPeriod > 40);
            //foreach (var assignment in assignment5)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 6
            //var assignment6 = from planet in planets
            //                  orderby planet.Name ascending
            //                  where planet.RotationPeriod > 10 && planet.RotationPeriod < 20
            //                  select planet;
            //var assignment6L = planets.OrderBy(o => o.Name).Where(p => p.RotationPeriod > 10)
            //                                               .Where(a => a.RotationPeriod < 20);
            //foreach (var assignment in assignment6L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 7
            //var assignment7 = from planet in planets
            //                  orderby planet.Name ascending
            //                  orderby planet.RotationPeriod ascending
            //                  where planet.RotationPeriod > 30
            //                  select planet;
            //var assignment7L = planets.OrderBy(o => o.Name).ThenBy(r => r.RotationPeriod)
            //                          .Where(p => p.RotationPeriod > 30);

            //foreach (var assignment in assignment7L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 8
            ////Mangler r;kkef'lge og lamdba
            //var assignment8 = from planet in planets
            //                  orderby planet.Name ascending
            //                  orderby planet.SurfaceWater 
            //                  orderby planet.RotationPeriod
            //                  where (planet.Name.ToLower().Contains("ba"))
            //                  where (planet.RotationPeriod < 30 || planet.SurfaceWater > 50 )
            //                  select planet;
            //var assignment8L = planets.OrderBy(o => o.Name).ThenBy(r => r.SurfaceWater).ThenBy(p => p.RotationPeriod)
            //                          .Where(p => p.Name.ToLower().Contains("ba"))
            //                          .Where( p => p.RotationPeriod < 30 || p.SurfaceWater > 50);

            //foreach (var assignment in assignment8L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 9
            //var assignment9 = from planet in planets
            //                  orderby planet.SurfaceWater descending
            //                  where (planet.SurfaceWater > 0)
            //                  select planet;
            //var assignment9L = planets.OrderByDescending(o => o.SurfaceWater)
            //                          .Where(p => p.SurfaceWater > 0);


            //foreach (var assignment in assignment9L)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 10

            //var assignment10 = from planet in planets

            //                   orderby (4 * Math.PI * Math.Pow(planet.Diameter, 2) / planet.Population) ascending

            //                   select planet;
            //foreach (var assignment in assignment10)
            //{
            //    Console.WriteLine(assignment.Name);
            //}
            #endregion
            #region Assignment 11

            //        IEnumerable<Planet> periodPlanets =
            //from planet in planets
            //where planet.RotationPeriod > 0 
            //select planet;

            //        var onlyZeroPlanets = planets.Except(periodPlanets);
            //        var assignment11 = from planet in onlyZeroPlanets
            //                           select planet;
            //        foreach (var assignment in assignment11)
            //        {
            //            Console.WriteLine(assignment.Name);
            //        }

            #endregion
            #region Assignment 12
            //            IEnumerable<Planet> aPlanets =
            // from planet in planets
            // where planet.Name.ToLower().StartsWith("a") || planet.Name.ToLower().EndsWith("s")
            // select planet;



            //            IEnumerable<Planet> nullPlanets =
            //from planet in planets
            //where planet.Terrain == null
            //select planet;

            //            var noneNULLPlanetes12 = planets.Except(nullPlanets);
            //            var assignment12 = from planet in noneNULLPlanetes12
            //                               where planet.Terrain.Contains("rainforest")
            //                               select planet;

            //            foreach (var assignment in aPlanets)
            //            {
            //                Console.WriteLine(assignment.Name);
            //            }
            //            foreach (var assignment in assignment12)
            //            {
            //                Console.WriteLine(assignment.Name);
            //            }
            #endregion
            #region Assignment 13
            //           IEnumerable<Planet> nullPlanets2 =
            //from planet in planets
            //where planet.Terrain == null
            //select planet;
            //           var noneNULLPlanets13 = planets.Except(nullPlanets2);
            //           var assignment13L = noneNULLPlanets13.Where(p => p.Terrain.Contains("deserts"));
            //           foreach (var assignment in assignment13L)
            //           {
            //               Console.WriteLine(assignment.Name);
            //           }

            #endregion
            #region Assignment 14
                    IEnumerable<Planet> nullPlanets3 =
         from planet in planets
         where planet.Terrain == null
         select planet;

            var noneNULLPlanets14 = planets.Except(nullPlanets3);
            var assignment14L = noneNULLPlanets14.OrderBy(p => p.RotationPeriod).ThenBy(p => p.Name)
                .Where(p => p.Terrain.Contains("swamp"));

            foreach (var assignment in assignment14L)
            {
                Console.WriteLine(assignment.Name);
            }


            #endregion
            Console.ReadKey();
        }
 

        

        static List<Planet> LoadData()
        {
            List<Planet> planets = new List<Planet>()
            {
                new Planet { Name="Corellia", Terrain= new List<string>{ "plains", "urban", "hills", "forests" },RotationPeriod=25,SurfaceWater=70, Diameter=11000, Population=3000000000},
                new Planet { Name="Rodia", Terrain= new List<string>{ "jungles", "oceans", "urban", "swamps" },RotationPeriod=29,SurfaceWater=60, Diameter=7549, Population=1300000000},
                new Planet { Name="Nal Hutta", Terrain= new List<string>{ "urban", "oceans", "bogs", "swamps" },RotationPeriod=87, Diameter=12150, Population=7000000000},
                new Planet { Name="Dantooine",Terrain= new List<string>{ "savannas", "oceans", "mountains", "grasslands" },RotationPeriod=25, Diameter=9830,Population=1000},
                new Planet { Name="Bestine IV",Terrain= new List<string>{ "rocky islands", "oceans" },RotationPeriod=26,SurfaceWater=98, Diameter=6400,Population=62000000},
                new Planet { Name="Ord Mantell",Terrain= new List<string>{ "plains", "seas","mesas" },RotationPeriod=26,SurfaceWater=10, Diameter=14050, Population=4000000000},
                new Planet { Name="Trandosha",Terrain= new List<string>{ "mountains", "seas","grasslands" ,"deserts"},RotationPeriod=25, Diameter=0, Population=42000000},
                new Planet { Name="Socorro", Terrain= new List<string>{ "mountains", "deserts"},RotationPeriod=20, Population=300000000},
                new Planet { Name="Mon Cala",Terrain= new List<string>{ "oceans", "reefs","islands"},RotationPeriod=21,SurfaceWater=100,Diameter=11030,Population=27000000000},
                new Planet { Name="Chandrila", Terrain= new List<string>{ "plains", "forests"},RotationPeriod=20,SurfaceWater=40,Diameter=13500,Population=1200000000},
                new Planet { Name="Sullust", Terrain= new List<string>{ "mountains", "volcanoes","rocky deserts"},RotationPeriod=20,SurfaceWater=5, Diameter=12780, Population=18500000000},
                new Planet { Name="Toydaria", Terrain= new List<string>{ "swamps", "lakes"},RotationPeriod=21, Diameter=7900, Population=11000000},
                new Planet { Name="Malastare",Terrain= new List<string>{ "swamps", "deserts","jungles","mountains"},RotationPeriod=26, Diameter=18880, Population=2000000000},
                new Planet { Name="Dathomir",Terrain= new List<string>{ "forests", "deserts","savannas"},RotationPeriod=24, Diameter=10480, Population=5200},
                new Planet { Name="Ryloth",Terrain= new List<string>{ "mountains", "valleys","deserts","tundra"},RotationPeriod=30,SurfaceWater=5,Diameter=10600, Population=1500000000 },
                new Planet { Name="Aleen Minor"},
                new Planet { Name="Vulpter",Terrain= new List<string>{ "urban", "barren"} ,RotationPeriod=22, Diameter=14900, Population=421000000},
                new Planet { Name="Troiken",Terrain= new List<string>{ "desert", "tundra","rainforests","mountains"} },
                new Planet { Name="Tund",Terrain= new List<string>{ "barren", "ash"} ,RotationPeriod=48, Diameter=12190},
                new Planet { Name="Haruun Kal",Terrain= new List<string>{ "toxic cloudsea", "plateaus","volcanoes"},RotationPeriod=25,Diameter=10120,Population=705300},
                new Planet { Name="Cerea",Terrain= new List<string>{ "verdant"},RotationPeriod=27,SurfaceWater=20,Population=450000000},
                new Planet { Name="Glee Anselm",Terrain= new List<string>{ "islands","lakes","swamps", "seas"},RotationPeriod=33,SurfaceWater=80, Diameter=15600,Population=500000000},
                new Planet { Name="Iridonia",Terrain= new List<string>{ "rocky canyons","acid pools"},RotationPeriod=29},
                new Planet { Name="Tholoth"},
                new Planet { Name="Iktotch",Terrain= new List<string>{ "rocky"},RotationPeriod=22},
                new Planet { Name="Quermia",},
                new Planet { Name="Dorin",RotationPeriod=22, Diameter=13400},
                new Planet { Name="Champala",Terrain= new List<string>{ "oceans","rainforests","plateaus"},RotationPeriod=27, Population=3500000000},
                new Planet { Name="Mirial",Terrain= new List<string>{ "deserts"}},
                new Planet { Name="Serenno",Terrain= new List<string>{ "rivers","rainforests","mountains"}},
                new Planet { Name="Concord Dawn",Terrain= new List<string>{ "jungles","forests","deserts"}},
                new Planet { Name="Zolan" },
                new Planet { Name="Ojom",Terrain= new List<string>{ "oceans","glaciers"},SurfaceWater=100, Population=500000000},
                new Planet { Name="Skako", Terrain = new List<string>{ "urban","vines"},RotationPeriod=27, Population=500000000000},
                new Planet { Name="Muunilinst",Terrain= new List<string>{ "plains","forests","hills","mountains"} ,RotationPeriod=28,SurfaceWater=25, Diameter=13800, Population=5000000000},
                new Planet { Name="Shili",Terrain= new List<string>{ "cities","savannahs","seas","plains"}},
                new Planet { Name="Kalee",Terrain= new List<string>{ "rainforests","cliffs","seas","canyons"},RotationPeriod=23, Diameter=13850, Population=4000000000},
                new Planet { Name="Umbara"},
                new Planet { Name="Tatooine",Terrain= new List<string>{ "deserts"},RotationPeriod=23,SurfaceWater=1, Diameter=10465, Population=200000 },
                new Planet { Name="Jakku",Terrain= new List<string>{ "deserts"}},
                new Planet { Name="Alderaan",Terrain= new List<string>{ "grasslands","mountains"},RotationPeriod=24,SurfaceWater=40, Diameter=12500, Population= 2000000000},
                new Planet { Name="Yavin IV", Terrain= new List<string>{ "rainforests","jungle"},RotationPeriod=24,SurfaceWater=8,Diameter=10200,Population=     1000},
                new Planet { Name="Hoth", Terrain= new List<string>{ "tundra","ice caves","mountain ranges"},RotationPeriod=23,SurfaceWater=100},
                new Planet { Name="Dagobah",Terrain= new List<string>{ "swamp","jungles"},RotationPeriod=23,SurfaceWater=8},
                new Planet { Name="Bespin",Terrain= new List<string>{ "gas giant"},RotationPeriod=12, Diameter=118000,Population=  6000000},
                new Planet { Name="Endor",Terrain= new List<string>{ "forests","mountains","lakes"},RotationPeriod=18,SurfaceWater=8, Diameter=4900, Population= 30000000},
                new Planet { Name="Naboo",Terrain= new List<string>{ "grassy hills","swamps","forests","mountains"},RotationPeriod=26,SurfaceWater=12, Diameter=12120, Population=  4500000000},
                new Planet { Name="Coruscant",Terrain= new List<string>{ "cityscape","mountains"},RotationPeriod=24,Diameter=12240,Population=1000000000000},
                new Planet { Name="Kamino",Terrain= new List<string>{ "ocean"},RotationPeriod=27,SurfaceWater=100,Diameter=19720, Population=1000000000},
                new Planet { Name="Geonosis",Terrain= new List<string>{ "rock","desert","mountain","barren"},RotationPeriod=30,SurfaceWater=5,Diameter=11370, Population=100000000000},
                new Planet { Name="Utapau",Terrain= new List<string>{ "scrublands","savanna","canyons","sinkholes"},RotationPeriod=27,SurfaceWater=0.9f,Diameter=12900,Population=  95000000},
                new Planet { Name="Mustafar",Terrain= new List<string>{ "volcanoes","lava rivers","mountains","caves"},RotationPeriod=36,  Diameter=4200, Population=20000},
                new Planet { Name="Kashyyyk",Terrain= new List<string>{ "jungle","forests","lakes","rivers"},RotationPeriod=26 ,SurfaceWater=60,Diameter=12765, Population=45000000},
                new Planet { Name="Polis Massa",Terrain= new List<string>{ "airless","asteroid"},RotationPeriod=24, Diameter=0, Population=1000000},
                new Planet { Name="Mygeeto",Terrain= new List<string>{ "glaciers","mountains","ice canyons"},RotationPeriod=12, Diameter=10088, Population=  19000000},
                new Planet { Name="Felucia",Terrain= new List<string>{ "fungus","forests"},RotationPeriod=34, Diameter=9100,Population=8500000},
                new Planet { Name="Cato Neimoidia",Terrain= new List<string>{ "mountains","fields","forests","rock arches"},RotationPeriod=25, Population=10000000},
                new Planet { Name="Saleucami",Terrain= new List<string>{ "caves", "deserts","mountains","volcanoes"},RotationPeriod=26, Population=1400000000, Diameter=14920},
                new Planet { Name="Stewjon",Terrain= new List<string>{ "grass"}},
                new Planet { Name="Eriadu",Terrain= new List<string>{ "cityscape"},RotationPeriod=24, Diameter=13490  , Population= 22000000000},
             };
          return planets;
        }
    }
}
