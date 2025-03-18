using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TH2
{
    internal class Time
    {
        //khai bao
        int hour, minute, second;

        //khoi tao ko tham so
        public Time(){
            //code
            hour=0;minute=0;second=0;

        }

        //khoi tao co tham so
        public Time(int h, int m, int s){
            hour=h;minute=m;second=s;

        }

        //encapsulation
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }

        public int GetHour(){
            return hour;

        }

        public void SetHour(int i){
            hour = i;

        }

        public void Show(){
            //show time as h:m:s 
            Console.WriteLine("{0}:{1}:{2}",hour,minute,second);

        }


    }
}