using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TH2
{
    internal class PS
    {

        int ts,ms;

        //constructor
        public PS(){
            ts=0; ms=1;

        }

        //COng
        public PS Cong(PS p1, PS p2){
            PS kq = new PS();
            kq.ts = p1.ts & p2.ms + p2.ts * p1.ms;
            kq.ms = p1.ms*p2.ms;
            return kq; 

        }

        
        
    }
}