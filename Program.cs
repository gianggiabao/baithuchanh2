using System;

namespace BTH2
{
    class ps
    {
        private int ts, ms;
        public ps()
        {
            ts = 0;
            ms = 1;

        }
        public ps(int ts,int ms)
        {
            this.ts = ts;
            this.ms = ms;

        }
        public void Nhap()
        {
            Console.WriteLine("nhap tu so");
            ts = int.Parse(Console.ReadLine());
            Console.WriteLine("NHap mau so");
            ms = int.Parse(Console.ReadLine());


        }
        public void Hien()
        {
            if (ms == 1)
                Console.WriteLine("{0}", ts);
            else
                Console.WriteLine("{0}/{1}", ts, ms);
        }
        public ps tong(ps t2)
        {
            ps t = new ps();
            t.ts = this.ts * t2.ms + t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public static ps operator +(ps t1, ps t2)
        {
            ps t = new ps();
            t.ts = t1.ts * t2.ms + t2.ts * t1.ms;
            t.ms = t1.ms * t2.ms;
            return t;

        }
        public ps Hieu( ps t4)
        {
            ps tt = new ps();
            tt.ts = this.ts * t4.ms - t4.ts * this.ms;
            tt.ms = this.ms * t4.ms;
            return tt;
        }
        public static ps operator -(ps t3, ps t4)
        {
            ps tt = new ps();
            tt.ts = t3.ts * t4.ms - t4.ts * t3.ms;
            tt.ms = t3.ms * t4.ms;
            return tt;
        }
         public static  bool operator >(ps t1, ps t2)
        {
            return t1.ts * t2.ms > t2.ts * t1.ms;
        }
        public static  bool operator <(ps t1, ps t2)
        {
            return t1.ts * t2.ms < t2.ts * t1.ms;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ps t1 = new ps(7,6);
            ps t2 = new ps(5,4);
            Console.WriteLine("tong hai phan so :");
            ps t = t1 + t2;
            ps t3 = new ps(7, 6);
            ps t4 = new ps(5, 4);
            Console.WriteLine("Hieu hai phan so :");
            ps tt = t3 - t4;
            t.Hien();
            tt.Hien();
            if (t1 > t2)
                Console.WriteLine("t1>t2");
            else
                Console.WriteLine("t1<t2");
            Console.ReadKey();
        }
    }
}
