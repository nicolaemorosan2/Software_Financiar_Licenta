using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Amortizare_degresiva : Amortizare
    {
        int an, durata_artificiu_liniara, durata_artificiu_degresiva;
        double k, cota_amort_degresiva, suma_amortizare_degresiva, suma_ramasa_amortizat, suma_amortizare_constanta;
        public void initializare_durata_amort() //suprascriem functia 
        {
            Console.Write("Pe ce perioada vom amortiza degresiv suma? (in ani) ");
            this.durata_amort = Convert.ToInt32(Console.ReadLine());
            if (this.durata_amort < 2)
            {
                Console.WriteLine("Nu este bine! Durata de amortizare nu poate fi negativa! Va rog sa introduceti valori pozitive!");
                this.initializare_durata_amort();
            }
        }
        private void parcurgere_for()
        {
            this.durata_artificiu_degresiva = this.durata_amort / 2;

            for (this.an = 1; this.an <= this.durata_artificiu_degresiva; this.an++)
            {
                this.suma_amortizare_degresiva = this.suma_ramasa_amortizat * this.cota_amort_degresiva;
                //this.suma_ramasa_amortizat = this.suma_ramasa_amortizat - this.suma_amortizare_degresiva;
                this.suma_ramasa_amortizat = this.suma_ramasa_amortizat * (1 - this.cota_amort_degresiva);
                Console.WriteLine(this.an + " | " + Math.Round(this.suma_amortizare_degresiva, 2) + " | " + Math.Abs(Math.Round(this.suma_ramasa_amortizat, 2)) + "\n");
            }

            this.suma_amortizare_constanta = this.suma_ramasa_amortizat / this.durata_artificiu_liniara;

            for (this.an = this.durata_artificiu_degresiva + 1; this.an <= this.durata_amort; this.an++)
            {
                this.suma_ramasa_amortizat = this.suma_ramasa_amortizat - this.suma_amortizare_constanta;
                Console.WriteLine(this.an + " | " + Math.Round(this.suma_amortizare_constanta, 2) + " | " + Math.Abs(Math.Round(this.suma_ramasa_amortizat, 2)) + "\n");
            }
        }
        public void Calc_amort_degresiva()
        {
            if (2 <= this.durata_amort && this.durata_amort < 5)
            {
                this.k = 1.5;
            }
            else if (5 <= this.durata_amort && this.durata_amort <= 10)
            {
                this.k = 2;
            }
            else
            {
                this.k = 2.5;
            }

            this.cota_amort_degresiva = this.k / this.durata_amort;
            //this.cota_amort_degresiva = 0.25;
            this.suma_ramasa_amortizat = this.suma_amort;
            Console.WriteLine("An | Amortizare | Suma ramasa");

            if (this.durata_amort % 2 == 0)
            {
                this.durata_artificiu_liniara = this.durata_amort / 2;
                this.parcurgere_for();

            }
            else
            {
                this.durata_artificiu_liniara = durata_amort / 2 + 1;
                this.parcurgere_for();
            }

        }
    }
}
