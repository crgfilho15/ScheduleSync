using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleSync.Models
{
    public class Professor : Pessoa
    {
        internal List<Disciplina> DisciplinasLecionadas;

        public Professor(string nome, Universidade universidade) : base(nome)
        {
            DisciplinasLecionadas = [];
            universidade.ProfessoresAtivos.Add(this);
        }

        public void ListarDisciplinasLecionadas()
        {
            foreach (var disciplina in DisciplinasLecionadas)
            {
                string professores = string.Join("/", disciplina.ProfessorResponsavel.Select(professor => professor.Nome));
                Console.WriteLine($"{disciplina.Nome} - {professores}");
            }
        }

        public void AssumirDisciplina(Disciplina disciplina)
        {
            disciplina.ProfessorResponsavel.Add(this);
            DisciplinasLecionadas.Add(disciplina);
        }
    }
}
