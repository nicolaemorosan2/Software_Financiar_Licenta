using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Recuperarea_investitiei : General
    {
        double profit_total = 0, profit_mediu, cota_parte, years_needed, months_needed, years_truncated;
        public void initializare_rata_randament()
        {
            Console.Write("Ce procent ati primit la schimb? (de ex: daca introduceti 5 de la tastatura, asta inseamna 5%) ");
            this.rata_randament = Convert.ToSingle(Console.ReadLine());
        }
        public void initializare_nr_ani()
        {
            Console.Write("Dorim sa facem o analiza financiara a ultimilor ani de activitate ai firmei. Asadar, la ultimii cati ani doriti sa ne uitam? ");
            this.nr_ani = Convert.ToInt32(Console.ReadLine());
        }
        public void Calc_CashFlow()
        {
            Console.Write("Va rog acum sa imi spuneti profiturile firmei pe acesti " + this.nr_ani + " ani: \n");
            for (this.i = 1; this.i <= this.nr_ani; this.i++)
            {
                Console.Write("Profit_an_" + this.i + " = ");
                this.CF[this.i] = Convert.ToInt32(Console.ReadLine());
                this.profit_total = this.profit_total + this.CF[this.i];
            }
            this.profit_mediu = this.profit_total / this.nr_ani;
        }
        private void Calc_rec(/*double suma_initiala, double procent_detinut, double profit*/)
        {
            /*this.investitie_initiala = suma_initiala;
            this.rata_randament = procent_detinut;
            this.profit_mediu = profit;*/

            this.cota_parte = this.profit_mediu * (this.rata_randament / 100);
            this.years_needed = this.investitie_initiala / this.cota_parte;
            this.years_truncated = Math.Truncate(this.years_needed);
            this.months_needed = Math.Truncate((this.years_needed - this.years_truncated) * 12);

            Console.WriteLine("La o stagnare a firmei (profituri aproximativ constante), va veti recupera investitia in " + this.years_truncated + " ani si " + this.months_needed + " luni.");
        }
        public void Recuperarea_Investitiei()
        {
            this.initializare_suma_initiala(); //ce suma am investit
            this.initializare_rata_randament(); //cat detinem (%) din firma
            this.initializare_nr_ani(); //analiza financiara a firmei pe ultimii x ani
            this.Calc_CashFlow(); //profiturile inregistrate pe acesti x ani
            this.Calc_rec(); //calcul final de
        }

    }
}
