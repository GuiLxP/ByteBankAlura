﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igual dade de tipo de valor: " + (idade == idadeMaisUmaVez));

            
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            
            contaDaGabriela.saldo = 300;
            Console.WriteLine("Saldo da conta da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo da conta da Gabriela Costa: " + contaDaGabrielaCosta.saldo);




            Console.ReadLine();
        }
    }
}
