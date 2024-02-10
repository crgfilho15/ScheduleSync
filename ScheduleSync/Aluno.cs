using System;
using System.Collections.Generic;

namespace ScheduleSync
{
    public class Aluno : Pessoa
    {
        internal string Matricula;
        internal List<Disciplina> DisciplinasMatriculadas;

        public Aluno(string nome, string matricula, Universidade universidade) : base(nome)
        {
            Matricula = matricula;
            DisciplinasMatriculadas = [];
            universidade.AlunosMatriculados.Add(this);
        }

        public void MatricularEmDisciplina(Disciplina disciplina)
        {
            disciplina.AlunosMatriculados.Add(this);
        }
    }
}
