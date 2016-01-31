using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class Data
    {
        

        public static List<LogInn> GetUsers()
        {
            List<LogInn>user= null;
            using(ProiectBazeContext ctx = new ProiectBazeContext())
            {
                user = (from x in ctx.LogInns
                        select x).ToList();
            }
            return user;
        }

        public static List<Administrator> GetAdmin()
        {
            List<Administrator> admin = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                admin = (from x in ctx.Administrators
                        select x).ToList();
            }
            return admin;
        }

        public static List<Disciplina> GetDisciplina()
        {
            List<Disciplina> disciplina = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                disciplina = (from x in ctx.Disciplinas
                        select x).ToList();
            }
            return disciplina;
        }

        public static List<Grupe> GetGrupe()
        {
            List<Grupe> grupa = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
               grupa = (from x in ctx.Grupes
                        select x).ToList();
            }
            return grupa;
        }
        public static List<Note> GetNote()
        {
            List<Note> note = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                note = (from x in ctx.Notes
                        select x).ToList();
            }
            return note;
        }

        public static List<Prof_date> GetDateProf()
        {
            List<Prof_date> dateProf = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                dateProf = (from x in ctx.Prof_date
                        select x).ToList();
            }
            return dateProf;
        }

        public static List<Profesor> GetProfesor()
        {
            List<Profesor> profesor = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                profesor = (from x in ctx.Profesors
                        select x).ToList();
            }
            return profesor;
        }

        public static List<Student> GetStudent()
        {
            List<Student> student = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                student = (from x in ctx.Students
                        select x).ToList();
            }
            return student;
        }

    };

     

    
}
