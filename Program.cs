using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Descobrir os numeros

            decimal numero_um;
            decimal numero_dois;

            Console.WriteLine("Fale um numero?");
            numero_um = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Fale outro numero?");
            numero_dois = decimal.Parse(Console.ReadLine());

            //Escolher uma Operacao

            string operacao;
             
            Console.WriteLine("Fale uma operação matematica");
            operacao = Console.ReadLine();

            //Mostra o Resultado

            decimal soma = numero_um + numero_dois;
            decimal sub = numero_um - numero_dois;
            decimal mutl = numero_um * numero_dois;
            decimal div = numero_um / numero_dois;

            if (operacao == "+")
                Console.WriteLine("A soma dos valores é" + soma);
            if (operacao == "-")
                Console.WriteLine("A subtração dos valores é" + sub);
            if (operacao == "*")
                Console.WriteLine("A multiplicação dos valores é" + mutl);
            if (operacao == "/")
                Console.WriteLine("A divisão dos valores é" + div);

        }
    }
}
