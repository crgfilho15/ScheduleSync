using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ScheduleSync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem-Vindo(a) ao ScheduleSync!");

            var cefet = new Universidade("CEFET-MG");
            Aluno carlos = new Aluno("Carlos", "20183009667", cefet);
            Aluno mariana = new Aluno("Mariana", "20193009667", cefet);
            Professor marcus = new Professor("Marcus", cefet);
            Professor gabriela = new Professor("Gabriela", cefet);
            Disciplina prog1 = new Disciplina("Programação 1", 1, cefet);
            Disciplina calculo1 = new Disciplina("Cálculo 1", 1, cefet);
            Disciplina prog2 = new Disciplina("Programação 2", 2, cefet);
            Disciplina estrutura = new Disciplina("Estrutura de Dados", 3, cefet);

            marcus.AssumirDisciplina(prog1);
            gabriela.AssumirDisciplina(prog2);
            //prog1.AtribuirProfessor(marcus);
            //prog2.AtribuirProfessor(gabriela);
            carlos.MatricularEmDisciplina(estrutura);

            Horario segundaM12 = null;
            Horario segundaM34 = null;
            Horario quartaN1 = null;
            Horario quintaT56 = null;

            try
            {
                segundaM12 = new Horario(2, "M", 12);
                prog1.CadastrarHorario(segundaM12);
                
                segundaM34 = new Horario(2, "M", 34);
                calculo1.CadastrarHorario(segundaM34);
            
                quartaN1 = new Horario(4, "N", 1);
                prog2.CadastrarHorario(quartaN1);
            
                quintaT56 = new Horario(5, "t", 56);
                Console.WriteLine(quintaT56);
                estrutura.CadastrarHorario(quintaT56);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            cefet.TrocarHorario(calculo1, segundaM12);
            cefet.ListarAlunosMatriculados();
            cefet.ListarDisciplinasOfertadas();
            cefet.ListarProfessoresAtivos();
            cefet.ListarTurmas();
        }
    }
}
