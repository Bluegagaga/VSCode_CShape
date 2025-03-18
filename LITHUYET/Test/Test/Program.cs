﻿using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void VD1(){
             //Nhap so a,b
        int? a=null;
        int b;

        Console.Write("Nhap so nguyen a: ");
        try{
        a = Convert.ToInt32(Console.ReadLine());
}
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }

        Console.Write("Nhap so nguyen b: ");
        bool check = int.TryParse(Console.ReadLine(), out b);
        if(check){

        //In ket qua
        Console.Write($"{a} + {b} = {a + b}\n");
        
        }    
        else{
            Console.Write("sai kieu du lieu\n");

        }
        }
        
        static void VD2( ref int n){
            int tong=0;
            //int[] a = new int[n];
            Console.Write("Nhap so phan tu: ");
            try{
                n = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);

            }

            for(int i=0;i<n;i++){
                Console.Write($"Nhap so thu {i+1}: ");
                try{
                    tong += Convert.ToInt32(Console.ReadLine());

                }
                catch(Exception ex){
                    Console.WriteLine(ex.Message);

                }        
                //tong+=a[i];
                
            }
            Console.Write($"Tong cac phan tu la: {tong}\n");

        }

        //Ham nhap
        static void VD2fixed_NhapMang( ref int[] a, ref int n){
            Console.Write("Nhap so n: ");
            while(!int.TryParse(Console.ReadLine(), out n) || n<=2 || n>=20)
                Console.Write("Nhap lai n!!");

            a = new int[n];
            for(int i=0; i<n; i++){
                Console.Write("Nhap so a[{0}]: ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //Ham tinh tong
        static int VD2fixed_Tong(int[] a, int n){
            int s=0;
            foreach(int x in a)
                if(x>0)
                    s+=x;

            return s;


        }




        static void Main(){
            int n=0;
            int[] a = new int[n];
            //VD2( ref n);
            VD2fixed_NhapMang(ref a, ref n);
            Console.Write("Tong cac phan tu trong mang: {0}\n",VD2fixed_Tong(a,n));


    }

}
}