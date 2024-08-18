using System;

namespace TSP
{

   public  class SupplyPoint
    {

        
        private int xpos;

        
        private int ypos;

        
        public SupplyPoint(int x, int y)
        {
            xpos = x;
            ypos = y;
        }

        
        public int getx()
        {
            return xpos;
        }

        
        public int gety()
        {
            return ypos;
        }

        
        public int proximity(SupplyPoint cother)
        {
            return proximity(cother.getx(), cother.gety());
        }

        
        public int proximity(int x, int y)
        {
            int xdiff = xpos - x;
            int ydiff = ypos - y;
            return (int)Math.Sqrt(xdiff * xdiff + ydiff * ydiff);
        }
    }
}