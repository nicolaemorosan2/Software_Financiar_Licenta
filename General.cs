using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect_practica_Nicolae_Moroșan_Soft_Financiar
{
    partial class General
    {
        public int i, nr_ani = 0, alegere = 0 /*investitie_initiala_RIR = 0*/;
        public double[] CF = new double[100];
        public double[] C = new double[100];
        public double VAN_temp, rata_randament = 0, VAN, investitie_initiala = 0, suma_cashflowuri = 0, ROI = 0, castig_total = 0, suma_costuri = 0;
        public double r = 0.01, r_prim = 0.5, r1 = 0, r2 = 0, VAN1 = -1, VAN2 = 1;
        public double /*rata_randament,*/ VAN_temp_RIR = 0, RIR;
    }
}
