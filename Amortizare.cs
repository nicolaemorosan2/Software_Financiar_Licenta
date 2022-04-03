using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Amortizare
    {
        public int durata_amort, suma_amort, val_amort_liniara_lunara;
        public void initializare_durata_amort()
        {
            Console.Write("Pe ce perioada vom amortiza liniar suma? (in luni) ");
            this.durata_amort = Convert.ToInt32(Console.ReadLine());
        }
        public void initializare_suma_de_amortizat()
        {
            Console.Write("Ce suma trebuie sa amortizam? ");
            this.suma_amort = Convert.ToInt32(Console.ReadLine());
        }
    }
}
