using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lc, dia, ano, mes;
            string  cod, mesescrito;

            
            Console.WriteLine("1- Atibaia " + "/" + "2- Bragança Paulista" + "/" + "3- Mairiporã" + "/" + "4- Nazaré" + "/" + "5- Terra Preta" + "/" + "6- Extrema" + "/" + "7- vargem");
            Console.WriteLine("Informe o Codigo da Cidade");
            lc = double.Parse(Console.ReadLine());
            
            switch (lc)
            {
                case 1:
                    cod = "Atibaia";
                    break;
                case 2:
                    cod = "Bragança Paulista";
                    break;
                case 3:
                    cod = "Mairiporã";
                    break;
                case 4:
                    cod = "Nazaré";
                    break;
                case 5:
                    cod = "Terra Preta";
                    break;
                case 6:
                    cod = "Extrema";
                    break;
                case 7:
                    cod = "Vargem";
                    break;

                default:
                    cod = "Cidade invalida";
                    break;
            }
            Console.WriteLine("Informe o Dia");
            dia = double.Parse(Console.ReadLine());
          

            Console.WriteLine("Informe o Mes");
            mes = double.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    mesescrito = "Janeiro";
                    break;
                case 2:
                    mesescrito = "Fevereiro";
                    break;
                case 3:
                    mesescrito = "Março";
                    break;
                case 4:
                    mesescrito = "Abril";
                    break;
                case 5:
                    mesescrito = "Maio";
                    break;
                case 6:
                    mesescrito = "Junho";
                    break;
                case 7:
                    mesescrito = "Julho";
                    break;
                case 8:
                    mesescrito = "Agosto";
                    break;
                case 9:
                    mesescrito = "Setembro";
                    break;
                case 10:
                    mesescrito = "Outubro";
                    break;
                case 11:
                    mesescrito = "Novembro";
                    break;
                case 12:
                    mesescrito = "Dezembro";
                    break;
                default:
                    mesescrito = "Mes invalido";
                    break;
            }

            Console.WriteLine("Informe o Ano");
            ano = double.Parse(Console.ReadLine());

            Console.WriteLine(cod + ", " +  dia +  " de "  +  mesescrito  +  " de "  +  ano);


            Console.ReadKey();
        }
    }
}
