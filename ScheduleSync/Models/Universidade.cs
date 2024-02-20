using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleSync.Models
{
    public class Universidade
    {
        internal string NomeUniversidade;
        internal List<Aluno> AlunosMatriculados;
        internal List<Disciplina> DisciplinasOfertadas;
        internal List<Professor> ProfessoresAtivos;

        public Universidade(string nomeUniversidade)
        {
            NomeUniversidade = nomeUniversidade;
            AlunosMatriculados = [];
            DisciplinasOfertadas = [];
            ProfessoresAtivos = [];
        }

        public void ListarAlunosMatriculados()
        {
            Console.WriteLine("\n*** Alunos Matriculados ***");
            foreach (var aluno in AlunosMatriculados)
            {
                Console.WriteLine($"{aluno.Nome} {aluno.Matricula}");
            }
        }

        public void ListarDisciplinasOfertadas()
        {
            Console.WriteLine("\n*** Disciplinas Ofertadas ***");
            foreach (var disciplina in DisciplinasOfertadas)
            {
                string horarios = string.Join("/", disciplina.HorarioDisciplina);
                string professores = string.Join("/", disciplina.ProfessorResponsavel.Select(professor => professor.Nome));
                horarios = string.IsNullOrEmpty(horarios) ? "a definir" : horarios;
                professores = string.IsNullOrEmpty(professores) ? "a definir" : professores;
                Console.WriteLine($"{disciplina.Nome} - {disciplina.Periodo}º Período - Horário(s) {horarios} - Professor(es) {professores}");
                //Console.WriteLine($"{disciplina.Nome} - {horarios}");
            }
        }

        public void ListarProfessoresAtivos()
        {
            Console.WriteLine("\n*** Professores Ativos ***");
            foreach (var professor in ProfessoresAtivos)
            {
                Console.WriteLine(professor.Nome);
            }
        }

        public void ListarTurmas()
        {
            Console.WriteLine("\n*** Turmas ***");
            foreach (var disciplina in DisciplinasOfertadas)
            {
                Console.WriteLine($"\n** {disciplina.Nome} **");
                Console.WriteLine("Professor(es): ");
                foreach (var professor in disciplina.ProfessorResponsavel)
                {
                    Console.WriteLine($"- {professor.Nome}");
                }
                Console.WriteLine("Aluno(s): ");
                foreach (var aluno in disciplina.AlunosMatriculados)
                {
                    Console.WriteLine($"- {aluno.Nome}");
                }
            }
        }

        public void TrocarHorario(Disciplina disciplina, Horario horarioPretendido) // TO DO
        {
            List<Professor> professores = disciplina.ProfessorResponsavel;
            List<Aluno> alunos = disciplina.AlunosMatriculados;
            List<Horario> horarioAtualDisciplina = disciplina.HorarioDisciplina;
            int periodo = disciplina.Periodo;

            foreach (var disc in DisciplinasOfertadas)
            {
                if (disc.Periodo == periodo)
                {
                    foreach (var horario in disc.HorarioDisciplina)
                    {
                        if (horario.DiaDaSemana == horarioPretendido.DiaDaSemana
                            && horario.Turno == horarioPretendido.Turno
                            && horario.NumeroHorario == horarioPretendido.NumeroHorario)
                        {
                            Console.WriteLine($"Não é possível realizar a troca de horário. Motivo: Choque de horário com disciplina do mesmo período ({disc.Nome})");
                        }
                    }
                }
            }
        }
    }
}
