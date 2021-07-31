namespace Task4
{
    public class Point
    {
        string str;
        public string Str
        {
            get
            {
                if (str != null)
                    return str;
                else
                    return "N/A";
            }

        }

        private int x;
        public int X { get { return x; } }

        private int y;
        public int Y { get { return y; } }

        public Point(string str, int x,int y)
        {
            this.str = str;
            this.x = x;
            this.y = y;
        }


    }
}