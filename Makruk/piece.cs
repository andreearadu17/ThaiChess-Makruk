using System;
using System.Collections.Generic;
using System.Text;

namespace Makruk
{
    class piece
    {
        String name;
        int coloana;
        int linie;
        public piece(String name,int x,int y)
        {
            this.name = name;
            coloana = x;
            linie = y;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public void setColoana(int point_x)
        {
            this.coloana = point_x;
        }
        public void setLinie(int point_y)
        {
            this.linie = point_y;
        }
        public int getColoana()
        {
            return this.coloana;
        }
        public string getNume()
        {
            return this.name;
        }
        public int getLinie()
        {
            return this.linie;
        }
    }
}
