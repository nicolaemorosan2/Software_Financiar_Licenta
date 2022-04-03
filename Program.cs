using System;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    class Program
    {
        /*public class Dobanda
        {
            public double suma_init_dob, rata_randament, nr_ani, suma_finala_dob, dobanda;
            public void initializare()
            {
                Console.Write("Ce suma initiala ati investit? ");
                this.suma_init_dob = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ce rata a dobanzii anuala avem? ");
                this.rata_randament = Convert.ToSingle(Console.ReadLine());
                //this - apeleaza instanta curenta
            }
            //suma_init_dob_temp = suma_init_dob;
            //rata_randament_temp = rata_randament;
            //double Calc_dob_simpla();
            //double Calc_dob_compusa();
        }
        public class Dobanda_simpla : Dobanda
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
        public class Dobanda_compusa : Dobanda
        {
            public void Calc_dob_compusa()
            {
                //Console.Write("Ce suma initiala ati investit? ");
                //suma_init_dob = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pe ce perioada ati investit (in ani si > 1 an)? ");
                this.nr_ani = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Ce rata a dobanzii anuala avem? ");
                //rata_randament = Convert.ToSingle(Console.ReadLine());
                this.suma_finala_dob = Math.Round(this.suma_init_dob * Math.Pow((1 + this.rata_randament), this.nr_ani), 3);
                this.dobanda = Math.Round((this.suma_finala_dob - this.suma_init_dob), 3);
                Console.WriteLine("Suma finala va fi de " + this.suma_finala_dob + " lei, iar dobanda aferenta va fi de " + this.dobanda + " lei\n");
            }
        }*/

        /*public class General
        {
            int i, nr_ani; double[] CF = new double[100];
            double VAN_temp, rata_randament = 0, VAN, investitie_initiala = 0;

            public void initializare_suma_initiala()
            {
                Console.Write("Ce suma ati investit? ");
                this.investitie_initiala = Convert.ToInt32(Console.ReadLine());
            }
            public void initializare_rata_randament()
            {
                Console.Write("Ce rata de randament avem? ");
                this.rata_randament = Convert.ToSingle(Console.ReadLine());
            }
            public void Calc_CashFlow()
            {
                Console.Write("Pe ce perioada (ani) ati investit? ");
                this.nr_ani = Convert.ToInt32(Console.ReadLine());
                Console.Write("Va rog acum sa imi spuneti cashflow - urile pe cei " + this.nr_ani + " ani: \n");
                for (this.i = 1; this.i <= this.nr_ani; this.i++)
                {
                    Console.Write("CF[" + this.i + "] = ");
                    this.CF[this.i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            public void Calc_VAN()
            {
                for (this.i = 1; this.i <= this.nr_ani; this.i++)
                {
                    this.VAN_temp = this.VAN_temp + this.CF[this.i] / (Math.Pow((1 + this.rata_randament), this.i));
                }
                this.VAN = this.VAN_temp - this.investitie_initiala;
                Console.WriteLine("VAN = " + Math.Round(this.VAN, 3) + " lei\n");
            }
        }*/

        /*public class Val_act_neta : Cashflow
        {
            for (i=1;i<=nr_ani;i++)
                {
                  VAN_temp = VAN_temp + CF[i] / (Math.Pow((1 + rata_randament), i));
                }
                  VAN = VAN_temp - investitie_initiala;
                  Console.WriteLine("VAN = " + VAN + " lei\n");
        }*/
        static void Main(string[] args)
        {

            Meniu meniu = new Meniu();

            //Console.WriteLine("Buna ziua! Acesta este proiectul meu de practica in programare si am ales sa fac un software financiar in C#");
            meniu.titlu();
            do
            {
                meniu.arata_meniu();
                meniu.optiune = meniu.initializare_optiune();
                switch (meniu.optiune)
                {
                    case 1:
                        {
                            //VAN
                            General obj = new General();

                            /*Console.Write("Ce suma ati investit? ");
                            investitie_initiala = Convert.ToInt32(Console.ReadLine());                           
                            Console.Write("Ce rata de randament avem? ");
                            rata_randament = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Pe ce perioada (ani) ati investit? ");
                            nr_ani = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Acum va rog sa imi spuneti cashflow-urile pe cei " + nr_ani + " ani:");
                            for (i=1;i<=nr_ani;i++)
                            {
                                Console.Write("CF["+i+"] = ");
                                CF[i] = Convert.ToInt32(Console.ReadLine());
                            }*/

                            obj.initializare_suma_initiala();
                            obj.initializare_rata_randament();
                            obj.initializare_nr_ani();
                            obj.Calc_CashFlow();
                            obj.Calc_VAN();

                            /*for (i=1;i<=nr_ani;i++)
                            {
                                VAN_temp = VAN_temp + CF[i] / (Math.Pow((1 + rata_randament), i));
                            }
                            VAN = VAN_temp - investitie_initiala;
                            Console.WriteLine("VAN = " + VAN + " lei\n");*/
                        }
                        break;

                    case 2:
                        {
                            //Amortizare liniara lunara

                            /* 
                            Console.Write("Ce suma trebuie sa amortizam? ");
                            suma_amort_liniara = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Pe ce perioada vom amortiza liniar suma? (in luni) ");
                            durata_amort_liniara = Convert.ToInt32(Console.ReadLine());
                            val_amort_liniara_lunara = suma_amort_liniara / durata_amort_liniara;
                            Console.WriteLine("Amortizarea lunara este de " + val_amort_liniara_lunara + " lei\n");*/

                            Amortizare_liniara amortizare_liniara = new Amortizare_liniara();
                            amortizare_liniara.initializare_suma_de_amortizat();
                            amortizare_liniara.Calc_amort_liniara();
                        }
                        break;
                    case 3:
                        {
                            //Amortizare degresiva
                            Amortizare_degresiva amortizare_degresiva = new Amortizare_degresiva();
                            amortizare_degresiva.initializare_suma_de_amortizat();
                            amortizare_degresiva.initializare_durata_amort();
                            amortizare_degresiva.Calc_amort_degresiva();
                        }
                        break;
                    case 4:
                        {
                            //RIR

                            /*
                            r1 < RIR < r2
                            r1 e pt VAN1 si e > 0
                            r2 e pt VAN2 si e < 0
                            suma de progresie geometrica cu ratia 1/(1+RIR); - nu a mers asa - e foarte greu de calculat functie de gradul n
                            incerc cu varianta cu VAN - asta pare sa mearga mai bine
                            Concluzie: A mers excelent! (...dupa o cautatura profunda a algoritmului)
                            */

                            General obj_RIR = new General();
                            obj_RIR.initializare_suma_initiala();
                            obj_RIR.initializare_nr_ani();
                            obj_RIR.Calc_CashFlow();
                            obj_RIR.Calc_RIR();

                            /*Console.Write("Ce suma ati investit? ");
                            investitie_initiala_RIR = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Pe ce perioada ati investit? (in ani) ");
                            nr_ani = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Acum va rog sa imi spuneti cashflow-urile pe cei " + nr_ani + " ani:");
                            for (i = 1; i <= nr_ani; i++)
                            {
                                Console.Write("CF[" + i + "] = ");
                                CF[i] = Convert.ToInt32(Console.ReadLine());
                            }*/

                            /*for (r = 0.01; r < 10; r = r + 0.01)
                            {
                                do
                                {
                                    for (i = 1; i <= nr_ani; i++)
                                    {
                                        VAN_temp_RIR = VAN_temp_RIR + CF[i] / (Math.Pow((1 + r), i));
                                    }
                                    VAN1 = VAN_temp_RIR - investitie_initiala_RIR;
                                } while (VAN1 > 0);
                            }
                                 r1 = r;*/

                            /*do
                            {
                                for (r_prim = 0.01; r_prim < 10; r_prim = r_prim + 0.01)
                                {
                                    
                                    for (i = 1; i <= nr_ani; i++)
                                    {
                                        VAN_temp_RIR = VAN_temp_RIR + CF[i] / (Math.Pow((1 + r), i));
                                    }
                                    VAN2 = VAN_temp_RIR - investitie_initiala_RIR;
                                }
                            } while (VAN2 < 0);
                            r2 = r;*/

                            /*do
                          {
                              VAN_temp_RIR = 0;
                              for (i = 1; i <= nr_ani; i++)
                              {
                                  VAN_temp_RIR = VAN_temp_RIR + CF[i] / (Math.Pow((1 + r), i));
                              }
                              r = r + 0.01;
                              VAN2 = VAN_temp_RIR - investitie_initiala_RIR;
                          }
                          while (r > 0 && VAN2 < 0);
                          r2 = r - 0.01;*/

                            /*while (r < 1 && VAN2 > 0)
                            {
                              VAN_temp_RIR = 0;
                              for (i = 1; i <= nr_ani; i++)
                              {
                                 VAN_temp_RIR = VAN_temp_RIR + CF[i] / (Math.Pow((1 + r), i));
                              }                              
                              VAN2 = VAN_temp_RIR - investitie_initiala_RIR;
                              r2 = r;
                              r = r + 0.01;
                            }

                            while (r_prim > 0 && VAN1 < 0)
                            {
                                VAN_temp_RIR = 0;
                                for (i = 1; i <= nr_ani; i++)
                                {
                                    VAN_temp_RIR = VAN_temp_RIR + CF[i] / (Math.Pow((1 + r_prim), i));
                                }
                                VAN1 = VAN_temp_RIR - investitie_initiala_RIR;
                                r1 = r_prim;
                                r_prim = r_prim - 0.01;
                            }

                            RIR = r1 + ((r2 - r1) * VAN1) / (VAN1 + Math.Abs(VAN2));
                            Console.WriteLine("Pentru ca investitia dvs. in valoare de " + investitie_initiala_RIR + " de lei pe " + nr_ani + " ani sa fie rentabila, aveti nevoie de o rata (interna) de rentabilitate de " + Math.Round((RIR*100), 2) + "%");*/
                        }
                        break;
                    case 5:
                        {
                            //ROI
                            General ROI = new General();
                            //ROI.initializare_nr_ani();
                            ROI.Calc_ROI();
                        }
                        break;
                    case 6:
                        {
                            //Dob simpla
                            Dobanda_simpla obiect1 = new Dobanda_simpla();
                            obiect1.initializare();
                            obiect1.Calc_dob_simpla();
                        }
                        break;
                    case 7:
                        {
                            //Dob compusa
                            Dobanda_compusa obiect2 = new Dobanda_compusa();
                            obiect2.initializare();
                            obiect2.Calc_dob_compusa();
                        }
                        break;
                    case 8:
                        {   //recuperarea investitiei

                            //ce profit mediu are firma?
                            //cat detineti din ea - daca sunteti shareholder si ce procent aveti?
                            //
                            Recuperarea_investitiei rec = new Recuperarea_investitiei();
                            rec.Recuperarea_Investitiei();
                        }
                        break;
                    case 9:
                        {
                            //credit bancar
                            Credit_bancar credit = new Credit_bancar();
                            credit.initializare();
                        }
                        break;
                        /*case 10:
                            {
                                //as putea face ceva cu bursa pe viitor - sa calculez pretul unor actiuni sau ceva
                            }
                            break;*/
                }
            } while (meniu.optiune != 0);
            Console.WriteLine("O zi buna! La revedere!");
        }
    }
}
