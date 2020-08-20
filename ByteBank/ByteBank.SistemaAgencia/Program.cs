﻿using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2020, 9, 20);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                
                if (quantidadeMeses == 1)
                {
                    return "1 mês";
                }
                
                return quantidadeMeses + " meses";
            }
            else if (timeSpan.Days > 7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;
            }

            return timeSpan.Days + " dias";
        }
    }
}
