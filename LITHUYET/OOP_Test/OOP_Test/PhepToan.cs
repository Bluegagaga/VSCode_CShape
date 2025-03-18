using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 namespace OOP_Test{
    internal class PhepToan{
        //Bien
        float a,b;
        char c;

        public float A { get => a; set => a = value; }

        //Phuong thuc truy xuat
        //public float Lay_a(){return a;}


        //Phuong thuc khoi tao-Constructor
        public PhepToan(){
            a=1; b=2; c='+';

        }


        //Phuong thuc sao chep
        public PhepToan(PhepToan pt){
            a=pt.a; b=pt.b; c=pt.c;

        }


        //Phuong Thuc
        public void Nhap(){
            Console.Write("");

        };
        public float Tinh(){
            //...

        };
        public void InKQ(){
            //...

        };
    }

 }