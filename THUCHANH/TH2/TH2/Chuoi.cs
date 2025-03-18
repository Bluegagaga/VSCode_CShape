using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TH2
{
    internal class Chuoi
    {
        //khai bao bien
        string s;
        int x,y;

        //constructor ko tham so
        public Chuoi(){
            s = "Hello World";
            x=5;y=3;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

        }
        
        public void Show(){
            Console.Clear();
            Console.CursorLeft=x;
            Console.CursorTop=y;
            Console.Write(s);
            Console.CursorVisible=false; //hide cursor 

        }

        public void Move(){
            Show();
            while(true){

                ConsoleKeyInfo phim = Console.ReadKey(true);
                if (phim.Key == ConsoleKey.RightArrow) x--;
                else if (phim.Key == ConsoleKey.LeftArrow) x++;
                else if (phim.Key == ConsoleKey.DownArrow) y--;
                else if (phim.Key == ConsoleKey.UpArrow) y++;
                else if (phim.Key == ConsoleKey.Escape) break;


                //xu li duong bien
                // if(x==0)
                //     x= Console.WindowWidth -s.Length;
                
                // if(y==0)
                //     y= Console.WindowHeight -s.Length;

                // if(x==0)
                //     x= Console.WindowWidth -s.Length;

                // if(x==0)
                //     x= Console.WindowWidth -s.Length;

            }

        }



    }
}