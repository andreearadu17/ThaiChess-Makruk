using System;
using System.Collections.Generic;
using System.Text;

namespace Makruk
{
    class Move
    {
        public int row;
        public String column;
        piece piesa;
        int prioritate;
        public Move(int row, String column, piece piesa, int prioritate)
        {
            this.row = row;
            this.column = column;
            this.piesa = piesa;
            this.prioritate = prioritate;
        }

        public void setPiesa(piece piesa)
        {
            this.piesa = piesa;
        }
        public void setLinie(int row)
        {
            this.row = row;
        }
        public void setCol(String col)
        {
            this.column = col;
        }
        public void setPrio(int prio)
        {
            this.prioritate = prio;
        }

        public int getPrio()
        {
            return this.prioritate ;
        }

        public string getCol()
        {
            return this.column;
        }
        public int getLinie()
        {
            return this.row;
        }
        public piece getPiesa()
        {
            return this.piesa;
        }
    }
}
