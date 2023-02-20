using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEP
{
    internal class Ticket
    {
        private string ticketnumber;
        private int count;

        public Ticket()
        {
            this.ticketnumber = "A";
            this.count = 0;
        }

        public string NextTicket()
        {         
            count++;
            return ticketnumber + count;
        }
    }

    

}
