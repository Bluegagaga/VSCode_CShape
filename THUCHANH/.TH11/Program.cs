using System;
using System.Runtime.CompilerServices;

namespace TH1{
    internal class Program{


        static void B1(){
            //khai bao
            string hoten;
            DateTime ns;
            bool gt;

            //Nhap data
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();

            Console.Write("Nhap ngay sinh: ");
            ns = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Nhap gioi tinh: ");
            gt = Convert.ToBoolean(Console.ReadLine());

            //Xuat ra man hinh
            if(gt)
                Console.WriteLine($"\t\tThong tin cua ban\n {hoten}\t{ns.ToShortDateString()}\tNam");
            else
                Console.WriteLine($"\t\tThong tin cua ban\n {hoten}\t{ns.ToShortDateString()}\tNu");


        }

        static void B2(){
            string hoten;
            DateTime ns;

            //Nhap data
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();

            Console.Write("Nhap ngay sinh: ");
            ns = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"\t\tThong tin cua ban\n {hoten}\t{DateTime.Now.Year - ns.Year} tuoi");


        }

        static void B3(){
            //khai bao
            byte sgl;
            float lg, luong;

                Console.Write("Nhap so gio lam: ");
            while(!byte.TryParse(Console.ReadLine(), out sgl) || sgl > 24)
                Console.Write("Nhap lai so gio lam: ");

            Console.Write("Nhap luong moi gio lam: ");
            while(!float.TryParse(Console.ReadLine(), out lg) || lg <0 || lg >50)
                Console.Write("Nhap lai luong moi gio lam: ");

            if(sgl<=8)
                luong = sgl * lg;
            else
                luong = 8*lg + (sgl -8) * lg * 1.5f;

            //In ket qua
            Console.Write("Tien luong 1 ngay: {0}\n", luong);


        }

        static void B4(){
            //Khai bao
            int a,b;
            char c;
            float? kq=null;


            //Nhap bien
            Console.Write("Nhap so a: ");
            while(!int.TryParse(Console.ReadLine(), out a))
                Console.Write("Nhap lai so a");

            Console.Write("Nhap so b: ");
            while(!int.TryParse(Console.ReadLine(), out b))
                Console.Write("Nhap lai so b");

            Console.Write("Nhap phep tinh: ");
            while(!char.TryParse(Console.ReadLine(), out c) ||c!='+' &&c!='-'  &&c!='*'  &&c!='/'  )
                Console.Write("Nhap lai phep tinh thuoc {+,-,*,/}: ");

            //In ket qua
            // switch(c){
            //     case '+': Console.Write("{0}+{1}={2}",a,b,a+b); break;
            //     case '-': Console.Write("{0}-{1}={2}",a,b,a-b); break;
            //     case '*': Console.Write("{0}*{1}={2}",a,b,a*b); break;
            //     case '/': Console.Write("{0}/{1}={2}",a,b,a/b); break;
            // }

            switch(c){
                case '+': kq = a +b; break;
                case '-': kq = a-b; break;
                case '*': kq = a*b; break;
                case '/': if(b!=0) kq = (float)a/b;
                        else Console.WriteLine("Loi chia cho 0"); break;
            }

            Console.WriteLine("{0} {1} {2} = {3}",a,c,b,kq);


        }

        static void B5(){
            //Khai bao bien
            string nhap, pass = "123";
            byte count=0;
            Console.WriteLine("\t\t\tLog In");
            do{
            Console.Write("\tPassword: ");
            nhap = Console.ReadLine();
            
            
            if(nhap==pass) 
                Console.WriteLine("Congratulation!!");
            else
                Console.WriteLine("Incorrect Password!!");
            if(count==2) break;
            count+=1;
            }
            while(nhap!=pass);
        }

        static bool B6a(int x, int y){

            return x%y==0;
        }

        static void B6b(ref int a, ref int b){
            a += b;
            b = a-b;
            a -= b;

        }

        static void B6(){
            //Khai bao
            int a,b;
            
            //Nhap bien
            Console.Write("Nhap so a: ");
            while(!int.TryParse(Console.ReadLine(), out a))
                Console.Write("Nhap lai so a");

            Console.Write("Nhap so b: ");
            while(!int.TryParse(Console.ReadLine(), out b))
                Console.Write("Nhap lai so b");

            //Kiem tra boi
            Console.WriteLine("\t\t\tChuong trinh kiem tra boi so");
            if(B6a(a,b))
                Console.Write("\t{0} la boi so cua {1}!",a,b);

            else
                Console.Write("\t{0} khong la boi so cua {1}!",a,b);

            //Kiem tra chia het
            Console.WriteLine("\n\t\t\tChuong trinh hoan doi 2 so");
            B6b(ref a, ref b);
            Console.WriteLine($"\ta = {a}\n\tb = {b}");


        

        }


        static void B7(){
            //Khai bao
            int[] a;
            int n;

            //Nhap n
            Console.Write("Nhap so phan tu: ");
            while(!int.TryParse(Console.ReadLine(), out n)|| n<3||n>20 )
                Console.Write("Nhap lai so phan tu: ");
            a = new int[n];

            //Nhap mang
            for(int i=0;i<n;i++){
                Console.Write("a[{0}]= ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());


            }

            //Sap xep
            for (int i=0;i<n;i++){
                for(int j=i+1;j<n;j++){
                    if(a[i]>a[j])
                        B6b(ref a[i], ref a[j]);
                }

            }

            //In mang sau khi sap xep
            foreach(int x in a)
                Console.Write($"{x} ");

        }

        static void Main(){
           B7();

        }


    }



}