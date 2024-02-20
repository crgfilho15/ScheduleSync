using ScheduleSync.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleSync.Services
{
    internal class ServiceProfessor
    {
        public List<Disciplina> DisciplinasLecionadas = new();

        public ServiceProfessor()
        {
        }

        public void AssumirDisciplina(Professor p, Disciplina disciplina)
        {
            disciplina.ProfessorResponsavel.Add(p);
            DisciplinasLecionadas.Add(disciplina);
        }
    }
}
