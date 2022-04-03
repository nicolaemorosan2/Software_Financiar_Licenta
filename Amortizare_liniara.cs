using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Amortizare_liniara : Amortizare
    {
        //aici n-am mai pus functia initializare_durata_amort, deoarece vom considera, la crearea unui obiect, amortizarea liniara ca metoda
        //default 
        public void Calc_amort_liniara()
        {
            this.val_amort_liniara_lunara = this.suma_amort / this.durata_amort;
            Console.WriteLine("Amortizarea lunara este de " + this.val_amort_liniara_lunara + " lei/euro/etc.\n");
        }
    }
}
