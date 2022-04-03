using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    partial class General
    {
        public void initializare_nr_ani()
        {
            Console.Write("Pe ce perioada (ani) ati investit? ");
            this.nr_ani = Convert.ToInt32(Console.ReadLine());
        }
        public void initializare_suma_initiala()
        {
            Console.Write("Ce suma ati investit? ");
            this.investitie_initiala = Convert.ToInt32(Console.ReadLine());
        }
        public void initializare_castig_total()
        {
            Console.Write("Ce castig ati inregistrat? ");
            this.castig_total = Convert.ToInt32(Console.ReadLine());
        }
        public void initializare_rata_randament()
        {
            Console.Write("Ce rata de randament avem? ");
            this.rata_randament = Convert.ToSingle(Console.ReadLine());
        }
    }
}
