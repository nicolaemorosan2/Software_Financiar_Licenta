using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Credit_bancar : Dobanda
    {
        int clasa_muncitor, vechime, salariu, alte_credite, i;
        double factor_clasa_muncitor, factor_alte_credite, factor_activitate, factor_salariu, factor_decisiv, u/*(factor de fructificare)*/;
        double rata;

        private void functie_alte_credite()
        {
            if (this.alte_credite == 1)
                this.factor_alte_credite = 2;
            else if (this.alte_credite == 2)
                this.factor_alte_credite = 1;
            else
            {
                Console.WriteLine("Nu exista aceasta optiune! Va rog sa selectati una valida!");
                this.initializare();
            }
        }
        private void functie_clasa_muncitor()
        {
            switch (this.clasa_muncitor)
            {
                case 1:
                    this.factor_clasa_muncitor = 1.5;
                    break;
                case 2:
                    this.factor_clasa_muncitor = 2.5;
                    break;
                case 3:
                    this.factor_clasa_muncitor = 2.5;
                    break;
                case 4:
                    this.factor_clasa_muncitor = 2;
                    break;
                case 5:
                    this.factor_clasa_muncitor = 1;
                    break;
            }
        }
        private void functie_vechime()
        {
            if (0 <= this.vechime && this.vechime < 5)
                this.factor_activitate = 1;

            else if (5 <= this.vechime && this.vechime < 10)
                this.factor_activitate = 1.5;

            else if (10 <= this.vechime && this.vechime < 15)
                this.factor_activitate = 2;

            else
                this.factor_activitate = 2.5;
        }
        private void functie_salariu()
        {
            if (this.salariu < 400)
                this.factor_salariu = 0;
            else if (400 <= this.salariu && this.salariu < 600)
                this.factor_salariu = 1;
            else if (600 <= this.salariu && this.salariu < 800)
                this.factor_salariu = 1.5;
            else if (800 <= this.salariu && this.salariu < 1000)
                this.factor_salariu = 2;
            else
                this.factor_salariu = 2.5;
        }
        private void Calc_factor_decisiv()
        {
            this.factor_decisiv = this.factor_activitate * this.factor_alte_credite * this.factor_clasa_muncitor * this.factor_salariu;
            //factorul decisiv e cuprins intre 1 si 31.25;
            //daca e sub 10, nu dam credit; intre 10 si 15 dam pana in 60k $, 
            //intre 15 si 20 85k $; 20-25 120k $; 25-30 max 200k $, iar 30-31.25 pana in 500k $
        }
        private void Calc_rate() //functia de calcul in sine
        {
            this.u = 1 + (this.rata_randament / 100);
            this.suma_finala_dob = this.suma_init_dob;

            for (this.i = 1; this.i <= this.nr_ani; this.i++)
            {
                this.suma_finala_dob = this.suma_finala_dob * this.u;
            }

            this.rata = (this.suma_finala_dob / this.nr_ani) / 12;

            Console.WriteLine("Pentru a lua un credit de " + this.suma_init_dob + " euro, veti plati, timp de " + this.nr_ani +
      " ani, o rata lunara constanta de " + Math.Round(this.rata, 2) + " de euro, echivalentul a " + Math.Round(this.rata * 4.94, 2) + " de lei\n");
        }
        private void functie_decisiva()
        {
            if (10 <= this.factor_decisiv && this.factor_decisiv < 15 && this.suma_init_dob <= 60000)
            {
                Console.WriteLine("Felicitari! Ati obtinut creditul! \n");
                this.Calc_rate();
            }
            else if (15 <= this.factor_decisiv && this.factor_decisiv < 20 && this.suma_init_dob <= 85000)
            {
                Console.WriteLine("Felicitari! Ati obtinut creditul! \n");
                this.Calc_rate();
            }
            else if (20 <= this.factor_decisiv && this.factor_decisiv < 25 && this.suma_init_dob <= 120000)
            {
                Console.WriteLine("Felicitari! Ati obtinut creditul! \n");
                this.Calc_rate();
            }
            else if (25 <= this.factor_decisiv && this.factor_decisiv < 30 && this.suma_init_dob <= 200000)
            {
                Console.WriteLine("Felicitari! Ati obtinut creditul! \n");
                this.Calc_rate();
            }
            else if (30 <= this.factor_decisiv && this.suma_init_dob <= 480000)
            {
                Console.WriteLine("Felicitari! Ati obtinut creditul! \n");
                this.Calc_rate();
            }
            else
            {
                Console.WriteLine("Din pacate, nu ati fost declarat eligibil pentru a lua acest credit! Ne pare rau!\n");
            }
        }
        private void verificare()
        {
            this.functie_alte_credite();
            this.functie_clasa_muncitor();
            this.functie_vechime();
            this.functie_salariu(); //cele 4 metode imi dau cei 4 factori
            this.Calc_factor_decisiv(); //metoda aceasta imi da factorul decisiv
            this.functie_decisiva(); //aici calculam tot
        }

        public void initializare()
        {
            Console.WriteLine("Sunteti 1. angajat, 2. antreprenor, 3. investitor, 4.intraprenor, 5. altele?");
            this.clasa_muncitor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ati mai luat credite (bancare) pana acum? 1.Da  2.Nu");
            this.alte_credite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cati ani activati in campul muncii?");
            this.vechime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ce salariu lunar aveti? (in euro)");
            this.salariu = Convert.ToInt32(Console.ReadLine());

            //this.verificare();

            Console.Write("Ce credit doriti sa obtineti? (in euro) ");
            this.suma_init_dob = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pe ce perioada sa fie creditul? (in ani) ");
            this.nr_ani = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ce rata a dobanzii anuala avem? (ex: daca introduceti 6 inseamna 6%) ");
            this.rata_randament = Convert.ToSingle(Console.ReadLine());

            this.verificare();
        }
    }
}
