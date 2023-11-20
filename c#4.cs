using System;
namespace project1
{
    class test
    {
        public static void Main()
        {
            int temp = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            bmm( x,  y);
            kmm( x,  y);
        }//end Main
        static void bmm (int x, int y)
        {
            for( int i =1; i<=x; i++)
            {
                if (i /x == 0)
                {
                   int temp = i;
                }
            }
            for(int j=1;j<=y; j++)
            {
                if(j/y == 0)
                {
                  int  num = j;
                }
            }
            int temp;
            int num;
            if(temp = num && temp < i)
            {
                Console.WriteLine(temp);
            }
            else
            {
                for(int i = 1; i <= x; i++)
                {
                    for(int j =1; j<=y; j++)
                    {
                        Console.WriteLine(temp);
                    }
                }
            }

        }//end bmm
        static void kmm(int x,int y)
        {
            Z = (x * y / temp);
            Console.WriteLine(Z);
        }
    }
}