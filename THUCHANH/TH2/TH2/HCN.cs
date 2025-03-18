using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TH2
{
    internal class HCN
    {
        //khai bao bien
        float cd, cr;

        //constructor ko tham so
        public HCN(){
            cd=0; cr=0;

        }

        //constructor co tham so
        public HCN(float d, float r){
            cd=d;cr=r;

        }

        //constructor sao chep
        public HCN(HCN h){
            cd=h.cd;cr=h.cr;

        }

        //update cd,cr
        public void setHCN(){
            Console.Write("Nhap chieu dai: ");
            cd=float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            cr=float.Parse(Console.ReadLine());

        }

        //tinh chu vi 
        public float CV(){
            return (cd + cr)*2;
        }

        //tinh dien tich
        public float DT(){
            return cd*cr;

        }

        //Xuat info HCN
        public void Show(){
            Console.WriteLine($"Chieu dai: {cd}\nChieu rong: {cr}\nChu vi: {CV()}\nDien tich: {DT()}\n");

        }

        
    }
}