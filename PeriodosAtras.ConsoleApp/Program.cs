using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Data data = new Data();
            int resultado;
            DateTime dataHJ = new DateTime();
            DateTime dataInput = new DateTime();

            Console.WriteLine("A data de hoje é: ");
            dataHJ = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Para saber um intervalo de tempo, digite a data em questão: ");
            dataInput = Convert.ToDateTime(Console.ReadLine());

            resultado = (dataHJ - dataInput).Days;

            if (resultado < 30)
            {
                Console.WriteLine("A diferença é de: " + (dataHJ - dataInput).Days + " dias.");

                Console.ReadLine();
            }

            else if (resultado > 30)
            {
                Console.WriteLine("A diferença é de: " + (dataHJ - dataInput).Days + " dias.");

                Console.ReadLine();
            }
        }
    }

    /*public class Data
    {
        public string strDataInput;
        public DateTime dataInput;
        public TimeSpan delta;
        public int deltaDias;

        public void EscreverDelta()
        {

        }

        public DateTime Conversor(string strDataInput)
        {
            dataInput = Convert.ToDateTime(strDataInput);
            
            return dataInput;
        }

        public TimeSpan Calculadora()
        {
            delta = DateTime.Today - dataInput;

            return default;
        }
    }*/
}