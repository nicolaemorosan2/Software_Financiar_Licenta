using System;

public class Dobanda
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
}
