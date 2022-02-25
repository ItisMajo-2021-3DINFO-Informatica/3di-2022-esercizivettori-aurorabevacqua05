﻿using System;

namespace BevacquaPasswordGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Generator");


            int[] numeri = new int[10];
            numeri[0] = 1;
            numeri[1] = 2;
            numeri[2] = 3;
            numeri[3] = 4;
            numeri[4] = 5;
            numeri[5] = 6;
            numeri[6] = 7;
            numeri[7] = 8;
            numeri[8] = 9;
            numeri[9] = 0;

            char[] alfabeto = new char[26];
            alfabeto[0] = 'a';
            alfabeto[1] = 'b';
            alfabeto[2] = 'c';
            alfabeto[3] = 'd';
            alfabeto[4] = 'e';
            alfabeto[5] = 'f';
            alfabeto[6] = 'g';
            alfabeto[7] = 'h';
            alfabeto[8] = 'i';
            alfabeto[9] = 'j';
            alfabeto[10] = 'k';
            alfabeto[11] = 'l';
            alfabeto[12] = 'm';
            alfabeto[13] = 'n';
            alfabeto[14] = 'o';
            alfabeto[15] = 'p';
            alfabeto[16] = 'q';
            alfabeto[17] = 'r';
            alfabeto[18] = 's';
            alfabeto[19] = 't';
            alfabeto[20] = 'u';
            alfabeto[21] = 'v';
            alfabeto[22] = 'w';
            alfabeto[23] = 'x';
            alfabeto[24] = 'y';
            alfabeto[25] = 'z';


            string[] parole = new string[20];
            parole[0] = 'ciao';
            parole[1] = 'sus';
            parole[2] = 'hihi';
            parole[3] = '';
            parole[4] = '';
            parole[5] = '';
            parole[6] = '';
            parole[7] = '';
            parole[8] = '';
            parole[9] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[10] = '';
            parole[0] = '';
            parole[0] = '';
            parole[0] = '';
            parole[0] = '';
            parole[0] = '';
            parole[0] = '';
            parole[0] = '';
            parole[0] = '';


            char[] simboli = new char[10];
            simboli[0] = '!';
            simboli[1] = '.';
            simboli[2] = ';';
            simboli[3] = '$';
            simboli[4] = '?';
            simboli[5] = '@';
            simboli[6] = '#';
            simboli[7] = '+';
            simboli[8] = '-';
            simboli[9] = '*';


            Console.Write("Indica la lunghezza della tua password: ");
            int lunghezza = Convert.ToInt32(Console.ReadLine());

            string nuovaPassword = "";

            Random generatore = new Random();
            for (int i = 0; i < lunghezza; i++)
            {
                int sceltamazzo = generatore.Next(1, 4);

                if (sceltamazzo == 1)
                {
                    int indicealfabeto = generatore.Next(0, 25);
                    nuovaPassword = nuovaPassword + alfabeto[indicealfabeto];
                }
                else if (sceltamazzo == 2)
                {
                    int indicenumeri = generatore.Next(0, 10);
                    nuovaPassword = nuovaPassword + numeri[indicenumeri];
                }
                else if(sceltamazzo==3)
                {
                    int indicesimboli = generatore.Next(0, 10);
                    nuovaPassword = nuovaPassword + simboli[indicesimboli];
                }


            }
            Console.Write("La tua password è: ");
            Console.Write(nuovaPassword);

        }
    }
}
