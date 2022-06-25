using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1__semestre_Katia
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1-) Faça um programa que leia dois valores e mostre uma das três mensagens a seguir:
             
             * Números iguais, caso os números sejam iguais.
             * Primeiro é maior, caso o primeiro seja maior que o segundo.
             * Segundo maior, caso o segundo seja maior que o primeiro. 
             */

            Console.WriteLine("Digite o primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)

            {
                Console.WriteLine("Primeiro é maior /n");
            }
            else if (n1 == n2)
            {
                ;
                Console.WriteLine("numero igual /n");
            }
            if (n1 < n2)
            {
                Console.WriteLine("Segundo maior /n");
            }

            /*Faça um programa que leia uma data, no formato ddmmaaaa, mostrar se a data é válida ou não*/


            int ddmmaaaa;

            Console.WriteLine("digite a sua data de aniversário no formato ddmmaaaaa");
            ddmmaaaa = int.Parse(Console.ReadLine());

            if (ddmmaaaa >= 01010001 && ddmmaaaa <= 31129999)
            {
                Console.WriteLine("data válida ");
            }

            else
            {
                Console.WriteLine("data não valida");
            }

            /* Faça um programa que receba o código correspondente ao cargo de um funcionario e seu salario atual. O programa 
             deverá calcular o aumento e mostrar o cargo, o aumento e o novo salario. Os cargos e o percentual de aumento estão na 
            tabela a seguir:
            
            Código    cargo          percentual de aumento
            1        secretário              35%
            2        Caixa                   20%
            3        Gerente                 15%
             */

            double salario, codigo;
            string cargo1, cargo2, cargo3;

            cargo1 = "Secretário";
            cargo2 = "Caixa";
            cargo3 = "Gerente";


            {
                Console.WriteLine("Digite o código do cargo de 1 a 3");
                codigo = double.Parse(Console.ReadLine());
            }

            {
                Console.WriteLine("Digite seu salário atual");
                salario = double.Parse(Console.ReadLine());
            }
            if (codigo == 1)
            {
                Console.WriteLine("Seu cargo é : " + cargo1 + " Seu aumento é de : " + salario * 0.35 + " Seu novo Salário é de : " + (salario + salario * 0.35));
            }
            if (codigo == 2)
            {
                Console.WriteLine("Seu cargo é : " + cargo2 + " Seu aumento é de : " + salario * 0.20 + " Seu novo Salário é de : " + (salario + salario * 0.20));
            }
            if (codigo == 3)
            {
                Console.WriteLine("Seu cargo é : " + cargo3 + " Seu aumento é de : " + salario * 0.15 + " Seu novo Salário é de : " + (salario + salario * 0.15));
            }
            {
                Console.WriteLine("Sua consulta foi concluída, aperte enter para finalizar");
            }


        }
    }
}
