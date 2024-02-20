using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScheduleSync.Models
{
    public class Disciplina
    {
        internal string Nome;
        internal int Periodo;
        internal List<Horario> HorarioDisciplina;
        internal List<Professor> ProfessorResponsavel;
        internal List<Aluno> AlunosMatriculados;

        public Disciplina(string nome, int periodo, Universidade universidade)
        {
            Nome = nome;
            Periodo = periodo;
            HorarioDisciplina = [];
            ProfessorResponsavel = [];
            AlunosMatriculados = [];
            universidade.DisciplinasOfertadas.Add(this);
        }

        //public void AtribuirProfessor(Professor professor)
        //{
        //    ProfessorResponsavel.Add(professor);
        //    professor.DisciplinasLecionadas.Add(this);
        //}

        public void CadastrarHorario(Horario horario)
        {
            string strHorario = horario.ToString();
            HorarioDisciplina.Add(horario);
            //if (ValidarHorario(strHorario))
            //{
            //    HorarioDisciplina.Add(horario);
            //} else
            //{
            //    throw new ArgumentException("Formato de horário inválido. O horário deve seguir o formato padrão.");
            //}
        }

        //private bool ValidarHorario(string horario)
        //{
        //    // Expressão regular para validar o formato do horário (3 ou 4 números)
        //    //string pattern = @"^[2-6][MTN][1-6]\d?$";
        //    string pattern = @"^[2-6][MTN][1-6]([1-6])?$";
        //    return Regex.IsMatch(horario, pattern);
        //}
    }
}
