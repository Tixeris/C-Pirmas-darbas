using System;

internal class Rectangle
    {
        
        private int x;
        private int y;
        private int ilgis;
        private int plotis;
        private double Istr;


        public Rectangle(int c, int d, int x, int y)
        {
            ilgis = c;
            plotis = d;
            this.x = x;
            this.y = y;
        }
    
        public int GetPlotas()
        {
            return ilgis * plotis;
        }

        public int GetPerimeter()
        {
            return ilgis * 2 + plotis * 2;
        }

        public double GetLine()
        {
            Istr = Math.Sqrt(Math.Pow(ilgis, 2) + Math.Pow(plotis, 2));
            Istr = Math.Round(Istr);
            return Istr;
        }


        public double GetCoordinates()
        {
            double middlex;
            middlex = plotis / 2;
            return middlex;
        }

        public double GetCoordinates1()
        {
            double middley;
            middley = ilgis / 2;
            return middley;
        }
}