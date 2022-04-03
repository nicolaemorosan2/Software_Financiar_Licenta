using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Meniu
    {
        public int optiune;
        public void titlu()
        {
            Console.WriteLine("Buna ziua! Acesta este proiectul meu de licenta si am ales sa fac un software financiar in C#\n");
        }

        public void arata_meniu()
        {
            Console.WriteLine("- Ce doriti sa calculati/aflati? -\n--- Daca apasati pe 0 vom iesi din program ---\n");
            Console.WriteLine("1. Valoarea actualizata neta(VAN)\n2. Amortizarea liniara lunara\n" +
                "3. Amortizarea degresiva\n4. RIR (Rata interna de rentabilitate)\n5. ROI (Return on Investment)\n6. Dobanda simpla\n7. Dobanda compusa\n" +
                "8. Recuperarea investitiei\n9. Credit bancar\n");
            Console.WriteLine("Optiunea aleasa este: \n");
        }

        public int initializare_optiune()
        {
            this.optiune = Convert.ToInt32(Console.ReadLine());
            return this.optiune;
        }
    }
}
