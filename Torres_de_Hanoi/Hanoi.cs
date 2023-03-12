using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty()) {

                Disco disc_mover = a.pop();
                b.push(disc_mover);
            }
            else
            {
                if ((a.Top < b.Top) && !a.isEmpty())
                {
                    Disco disc_mover = a.pop();
                    b.push(disc_mover);
                }
                else
                {
                    Disco disc_mover = b.pop();
                    a.push(disc_mover);
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m=0;
            if (n % 2 != 0){ 
                

                while (true)
                {
                    if (m == 0) {
                        Console.WriteLine("");
                        Console.WriteLine("Situación inicial");
                        //----------------------------------------------------------
                        //region PANTALLA
                        Console.Write("Torre INI:");
                        if (ini.isEmpty() == true)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            for (int i = 0; i < ini.Elementos.Count; i++)
                            {
                                Console.Write(ini.Elementos[i].Valor.ToString() + " ");
                            }
                            Console.WriteLine("");
                        }
                        Console.Write("Torre AUX:");
                        if (aux.isEmpty() == true)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            for (int j = 0; j < aux.Elementos.Count; j++)
                            {
                                Console.Write(aux.Elementos[j].Valor.ToString() + " ");
                            }
                            Console.WriteLine("");
                        }
                        Console.Write("Torre FIN: ");
                        if (fin.isEmpty() == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else
                        {
                            for (int k = 0; k < fin.Elementos.Count; k++)
                            {
                                Console.Write(fin.Elementos[k].Valor.ToString() + " ");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        if (fin.Size == n)
                        {
                            return m;
                        }
                        //endregion
                        //---------------------------------------------
                        }

                    
                    mover_disco(ini, fin);
                    m++;

                    //----------------------------------------------------------
                    //region PANTALLA
                    Console.WriteLine("Situación tras el movimiento " + m);
                    Console.Write("Torre INI:");
                    if (ini.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int i = 0; i < ini.Elementos.Count; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre AUX:");
                    if (aux.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < aux.Elementos.Count; j++)
                        {
                            Console.Write(aux.Elementos[j].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre FIN: ");
                    if (fin.isEmpty() == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int k = 0; k < fin.Elementos.Count; k++)
                        {
                            Console.Write(fin.Elementos[k].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    //endregion
                    //---------------------------------------------

                    mover_disco(ini, aux);
                    m++;

                    //----------------------------------------------------------
                    //region PANTALLA
                    Console.WriteLine("Situación tras el movimiento " + m);
                    Console.Write("Torre INI:");
                    if (ini.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int i = 0; i < ini.Elementos.Count; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre AUX:");
                    if (aux.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < aux.Elementos.Count; j++)
                        {
                            Console.Write(aux.Elementos[j].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre FIN: ");
                    if (fin.isEmpty() == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int k = 0; k < fin.Elementos.Count; k++)
                        {
                            Console.Write(fin.Elementos[k].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    //endregion
                    //---------------------------------------------

                    mover_disco(aux, fin);
                    m++;

                    //----------------------------------------------------------
                    //region PANTALLA
                    Console.WriteLine("Situación tras el movimiento " + m);
                    Console.Write("Torre INI:");
                    if (ini.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int i = 0; i < ini.Elementos.Count; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre AUX:");
                    if (aux.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < aux.Elementos.Count; j++)
                        {
                            Console.Write(aux.Elementos[j].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre FIN: ");
                    if (fin.isEmpty() == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int k = 0; k < fin.Elementos.Count; k++)
                        {
                            Console.Write(fin.Elementos[k].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    //endregion
                    //---------------------------------------------


                }
            } else if (n % 2 == 0)
            {
                while (true)
                {
                    mover_disco(ini, aux);
                    m++;
                    //----------------------------------------------------------
                    //region PANTALLA
                    Console.WriteLine("Situación tras el movimiento " + m);
                    Console.Write("Torre INI:");
                    if (ini.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int i = 0; i < ini.Elementos.Count; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre AUX:");
                    if (aux.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < aux.Elementos.Count; j++)
                        {
                            Console.Write(aux.Elementos[j].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre FIN: ");
                    if (fin.isEmpty() == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int k = 0; k < fin.Elementos.Count; k++)
                        {
                            Console.Write(fin.Elementos[k].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    //endregion
                    //---------------------------------------------

                    mover_disco(ini, fin);
                    m++;
                    //----------------------------------------------------------
                    //region PANTALLA
                    Console.WriteLine("Situación tras el movimiento " + m);
                    Console.Write("Torre INI:");
                    if (ini.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int i = 0; i < ini.Elementos.Count; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre AUX:");
                    if (aux.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < aux.Elementos.Count; j++)
                        {
                            Console.Write(aux.Elementos[j].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre FIN: ");
                    if (fin.isEmpty() == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int k = 0; k < fin.Elementos.Count; k++)
                        {
                            Console.Write(fin.Elementos[k].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    //endregion
                    //---------------------------------------------

                    mover_disco(aux, fin);
                    m++;
                    //----------------------------------------------------------
                    //region PANTALLA
                    Console.WriteLine("Situación tras el movimiento " + m);
                    Console.Write("Torre INI:");
                    if (ini.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int i = 0; i < ini.Elementos.Count; i++)
                        {
                            Console.Write(ini.Elementos[i].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre AUX:");
                    if (aux.isEmpty() == true)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int j = 0; j < aux.Elementos.Count; j++)
                        {
                            Console.Write(aux.Elementos[j].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Torre FIN: ");
                    if (fin.isEmpty() == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        for (int k = 0; k < fin.Elementos.Count; k++)
                        {
                            Console.Write(fin.Elementos[k].Valor.ToString() + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    //endregion
                    //---------------------------------------------

                }
            }
            return m;
        }

    }
}
