using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Plateau
    {
        private Dictionary<Case, Piece> map = new Dictionary<Case, Piece>();

        public Dictionary<Case, Piece> getMap()
        {
            return map;
        }

        public void Set(Case key, Piece value)
        {
            if (map.ContainsKey(key))
            {
                map[key] = value;
            }
            else
            {
                map.Add(key, value);
            }
        }

        public Piece Get(Case key)
        {
            Piece result = null;

            if (map.ContainsKey(key))
            {
                result = map[key];
            }

            return result;
        }

        public Plateau()
        {
            map = new Dictionary<Case, Piece>();
            map.Add(new Case("A1"), (Piece)new Tour("blanc"));
            map.Add(new Case("B1"), (Piece)new Cavalier("blanc"));
            map.Add(new Case("C1"), (Piece)new Fou("blanc"));
            map.Add(new Case("D1"), (Piece)new Reine("blanc"));
            map.Add(new Case("E1"), (Piece)new Roi("blanc"));
            map.Add(new Case("F1"), (Piece)new Fou("blanc"));
            map.Add(new Case("G1"), (Piece)new Cavalier("blanc"));
            map.Add(new Case("A2"), (Piece)new Pion("blanc"));
            map.Add(new Case("B2"), (Piece)new Pion("blanc"));
            map.Add(new Case("C2"), (Piece)new Pion("blanc"));
            map.Add(new Case("D2"), (Piece)new Pion("blanc"));
            map.Add(new Case("E2"), (Piece)new Pion("blanc"));
            map.Add(new Case("F2"), (Piece)new Pion("blanc"));
            map.Add(new Case("G2"), (Piece)new Pion("blanc"));
            map.Add(new Case("H2"), (Piece)new Pion("blanc"));
            for (int i = 3; i < 9; i++)
            {
                for (char j = 'A'; j < 'H'; j++)
                {
                    map.Add(new Case(j+(i.ToString())), null);
                }
            }
            map.Add(new Case("A7"), (Piece)new Pion("noir"));
            map.Add(new Case("B7"), (Piece)new Pion("noir"));
            map.Add(new Case("C7"), (Piece)new Pion("noir"));
            map.Add(new Case("D7"), (Piece)new Pion("noir"));
            map.Add(new Case("E7"), (Piece)new Pion("noir"));
            map.Add(new Case("F7"), (Piece)new Pion("noir"));
            map.Add(new Case("G7"), (Piece)new Pion("noir"));
            map.Add(new Case("H7"), (Piece)new Pion("noir"));
            map.Add(new Case("A7"), (Piece)new Tour("noir"));
            map.Add(new Case("B7"), (Piece)new Cavalier("noir"));
            map.Add(new Case("C7"), (Piece)new Fou("noir"));
            map.Add(new Case("D7"), (Piece)new Roi("noir"));
            map.Add(new Case("E7"), (Piece)new Reine("noir"));
            map.Add(new Case("F7"), (Piece)new Fou("noir"));
            map.Add(new Case("G7"), (Piece)new Cavalier("noir"));
            map.Add(new Case("H7"), (Piece)new Tour("noir"));
        }

        public Boolean checkDeplacement(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Type t = piece_loc.GetType();
            if (t.Equals(typeof(Roi)))
            {

            } else if (t.Equals(typeof(Reine)))
            {

            }
            else if (t.Equals(typeof(Fou)))
            {

            }
            else if (t.Equals(typeof(Tour)))
            {

            }
            else if (t.Equals(typeof(Cavalier)))
            {

            } else
            {

            }

        }


        public Boolean checkDeplacement_pion(Case loc, Case dest)
        {
            Piece piece_loc = Get(loc);
            Piece piece_dest = Get(dest);
            Boolean blanc = (piece_loc.Color.get().isEquals("blanc")) ? true : false;
            int i = (blanc) ? 1 : -1;
            int[] coor_loc = getCoordonnees(loc);
            int[] coor_dest = getCoordonnees(dest);
            if (piece_dest == null)
            {
                if (coor_dest[1] == coor_loc[1] + i && coor_dest[0] == coor_loc[0])
                {
                    return true;
                }
            } else {
                if (coor_dest[1] == coor_loc[1] + i && (coor_dest[0] == coor_loc[0]+i || coor_dest[0] == coor_loc[0] - i))
                {
                    return true;
                }
            }
            return false;
        }



        public int[] getCoordonnees(Case loc) {
            String name = loc.getName();
            int x = name.ElementAt(0) - 65;
            int y = name.ElementAt(1);
            int[] result = { x, y };
            return (result);
        }
    }
}
