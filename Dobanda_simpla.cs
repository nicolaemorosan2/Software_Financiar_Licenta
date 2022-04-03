using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Dobanda_simpla : Dobanda
    {
        public void Calc_dob_simpla()
        {
            //Console.Write("Ce suma initiala ati investit? ");
            //suma_init_dob = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pe ce perioada ati investit (in luni si < 1 an)? ");
            this.nr_ani = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ce rata a dobanzii anuala avem? ");
            //rata_randament = Convert.ToSingle(Console.ReadLine());
            this.suma_finala_dob = Math.Round(this.suma_init_dob * (1 + this.rata_randament * this.nr_ani / 12), 3);
            this.dobanda = Math.Round((this.suma_finala_dob - this.suma_init_dob), 3);
            Console.WriteLine("Suma finala va fi de " + this.suma_finala_dob + " lei, iar dobanda aferenta va fi de " + this.dobanda + " lei\n");
        }
    }
}
