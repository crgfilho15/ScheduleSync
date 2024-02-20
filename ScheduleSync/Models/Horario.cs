using System;
using System.Collections.Generic;

namespace ScheduleSync.Models
{
    public class Horario
    {
        internal int DiaDaSemana;
        internal string Turno;
        internal int NumeroHorario;

        public Horario(int diaDaSemana, string turno, int numeroHorario)
        {
            if (diaDaSemana < 2 || diaDaSemana > 6)
            {
                throw new ArgumentException("O dia da semana deve ser um valor inteiro entre 2 e 6.");
            }
            if (!turno.Equals("M", StringComparison.InvariantCultureIgnoreCase)
                && !turno.Equals("T", StringComparison.InvariantCultureIgnoreCase)
                && !turno.Equals("N", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new ArgumentException("O turno deve ser uma letra: M, T ou N.");
            }
            if (numeroHorario < 1 || numeroHorario > 56)
            {
                throw new ArgumentException("O número do horário deve ser composto por 2 valores inteiros entre 1 e 6");
            }

            DiaDaSemana = diaDaSemana;
            Turno = turno.ToUpper();
            NumeroHorario = numeroHorario;
        }

        public override string ToString()
        {
            return DiaDaSemana + Turno + NumeroHorario;
        }
    }
}