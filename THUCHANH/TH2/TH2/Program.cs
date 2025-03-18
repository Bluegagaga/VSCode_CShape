using System;

namespace TH2 {
    class Program{
        //B1
        static void B1(){
            //tao object
            Time t1 = new Time();

            Console.Write("Nhap gio: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            int s = int.Parse(Console.ReadLine());
            Time t2 = new Time(h,m,s);

            //Xuat info 2 object
            t1.Show();
            t2.Show();

            //thiet lap hour mou cho object
            t1.SetHour(15);


            //tinh so giay
            int sg = (t1.GetHour() - t2.GetHour())*3600 + (t1.Minute - t2.Minute)+60 +t1.Second - t2.Second  ;
            Console.WriteLine($"Khoang cach 2 object la {sg} giay!!");

        }


        //B2
        static void B2(){
            //tao 3 objects
            HCN h1=new HCN();
            HCN h2=new HCN(3,5);
            HCN h3=new HCN(h2);

            //in info
            Console.WriteLine("Hinh chu nhat 1");
            h1.Show();
            Console.WriteLine("Hinh chu nhat 2");
            h2.Show();
            Console.WriteLine("Hinh chu nhat 3");
            h3.Show();


            //cap nhat lai doi tuong h1
            Console.WriteLine("Cap nhat lai doi tuong h1");
            h1.setHCN();

            //Tong dien tich 3 HCN
            Console.WriteLine($"Tong dien tich 3 HCN: { h1.DT() + h2.DT() + h3.DT()}");


        }

        //B3
        static void B3(){
            //code
            Chuoi s1 =new Chuoi();
            s1.Move();


        }


        static void Main(){
            //B1();
            //B2();
            B3();

        }


    }




}