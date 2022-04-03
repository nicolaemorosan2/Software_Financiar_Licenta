using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    partial class General
    {
        public void Calc_VAN()
        {
            for (this.i = 1; this.i <= this.nr_ani; this.i++)
            {
                this.VAN_temp = this.VAN_temp + this.CF[this.i] / (Math.Pow((1 + this.rata_randament), this.i));
            }
            this.VAN = this.VAN_temp - this.investitie_initiala;
            Console.WriteLine("VAN = " + Math.Round(this.VAN, 3) + " lei\n");
        }
        public void Calc_CashFlow()
        {
            Console.Write("Va rog acum sa imi spuneti cashflow - urile pe cei " + this.nr_ani + " ani: \n");
            for (this.i = 1; this.i <= this.nr_ani; this.i++)
            {
                Console.Write("CF[" + this.i + "] = ");
                this.CF[this.i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Calc_Costuri()
        {
            Console.Write("Va rog acum sa imi spuneti costurile pe cei " + this.nr_ani + " ani: \n");
            for (this.i = 1; this.i <= this.nr_ani; this.i++)
            {
                Console.Write("C[" + this.i + "] = ");
                this.C[this.i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Calc_ROI()
        {
            Console.WriteLine("Avem 2 variante de a calcula ROI: direct - pe toata perioada analizata - sau cu costurile si cashflow-urile pe an");
            Console.WriteLine("Alegeti dvs: 1. Direct   2. Defalcat");
            this.alegere = Convert.ToInt32(Console.ReadLine());

            if (this.alegere == 1)
            {
                this.initializare_suma_initiala();
                this.initializare_castig_total();
                this.ROI = (this.castig_total - this.investitie_initiala) / this.investitie_initiala * 100;
            }
            else if (this.alegere == 2)
            {
                this.initializare_nr_ani();
                this.Calc_Costuri();
                this.Calc_CashFlow();
                for (this.i = 1; this.i <= this.nr_ani; this.i++)
                {
                    this.suma_cashflowuri = this.suma_cashflowuri + this.CF[this.i];
                    this.suma_costuri = this.suma_costuri + this.C[this.i];
                }
                this.ROI = (this.suma_cashflowuri - this.suma_costuri) / this.suma_costuri * 100;
            }
            else
                Console.WriteLine("V-am prins! Alegeti doar 1 sau 2!");
            Console.WriteLine("Aveti un ROI (Return on Investment) de " + Math.Round(this.ROI, 2) + "%");
        }
        public void Calc_RIR()
        {
            while (this.r < 1 && this.VAN2 > 0)
            {
                this.VAN_temp_RIR = 0;
                for (this.i = 1; this.i <= this.nr_ani; this.i++)
                {
                    this.VAN_temp_RIR = this.VAN_temp_RIR + this.CF[this.i] / (Math.Pow((1 + this.r), this.i));
                }
                this.VAN2 = this.VAN_temp_RIR - this.investitie_initiala;
                this.r2 = this.r;
                this.r = this.r + 0.01;
            }

            while (this.r_prim > 0 && this.VAN1 < 0)
            {
                this.VAN_temp_RIR = 0;
                for (this.i = 1; this.i <= this.nr_ani; this.i++)
                {
                    this.VAN_temp_RIR = this.VAN_temp_RIR + this.CF[this.i] / (Math.Pow((1 + this.r_prim), this.i));
                }
                this.VAN1 = this.VAN_temp_RIR - this.investitie_initiala;
                this.r1 = this.r_prim;
                this.r_prim = this.r_prim - 0.01;
            }

            this.RIR = this.r1 + ((this.r2 - this.r1) * this.VAN1) / (this.VAN1 + Math.Abs(this.VAN2));
            Console.WriteLine("Pentru ca investitia dvs. in valoare de " + this.investitie_initiala + " de lei pe " + this.nr_ani + " ani sa fie rentabila, aveti nevoie de o rata (interna) de rentabilitate de " + Math.Round((this.RIR * 100), 2) + "%");
        }
    }
}
