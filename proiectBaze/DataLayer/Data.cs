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
        
        //LOGIN
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

        public static void InsertLogIn(string nume, string parola, int permis)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                LogInn login = new LogInn()
                {
                    username = nume,
                    parola = parola,
                    permis = permis
                };

                ctx.LogInns.Add(login);
                ctx.SaveChanges();

            }
        }

        public static void DeleteLogIn(int id)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                List<LogInn> users = GetUsers();

                var x = (from b in ctx.LogInns where b.id == id select b).FirstOrDefault();
                if (x != null && x.id <= users.Count)
                {

                    ctx.LogInns.Remove(x);
                    ctx.SaveChanges();
                }
            }
        }

        //ADMINISTRATOR
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

        public static void InsertAdmin(string nume , string prenume)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                Administrator admin = new Administrator()
                {
                    //id_grupa = id,
                    Nume = nume,
                    Prenume = prenume
                };

                ctx.Administrators.Add(admin);
                ctx.SaveChanges();

            }
        }

        public static void DeleteAdmin(int id)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                

                var x = (from b in ctx.Administrators where b.id_admin == id select b).FirstOrDefault();
                if (x != null)
                {

                    ctx.Administrators.Remove(x);
                    ctx.SaveChanges();
                }
            }
        }


        //Disciplina
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
        public static void InsertDisciplina(string denumire , int nrCredite)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                Disciplina discipl = new Disciplina()
                {
                    Denumire = denumire,
                    Nr_credite = nrCredite
                };
            }
        }

        public static void DeleteDisciplina(int id)
        { 
             using (ProiectBazeContext ctx = new ProiectBazeContext())
             {
             var x = (from b in ctx.Disciplinas where b.id_disc == id select b).FirstOrDefault();
                if (x != null )
                {

                    ctx.Disciplinas.Remove(x);
                    ctx.SaveChanges();
                }
             }
        }

        //Grupa
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
        public static void InsertGrupe(string numegrupa, int an, int nr, string indrumator)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                Grupe grupa = new Grupe()
                {
                    //id_grupa = id,
                    nume_grupa = numegrupa,
                    an = an,
                    indrumator = indrumator,
                    nr_std = nr
                };

                ctx.Grupes.Add(grupa);
                ctx.SaveChanges();

            }
        }
        public static void DeleteGrupa(int id)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                List<Grupe> grupa = GetGrupe();

                var x = (from b in ctx.Grupes where b.id_grupa == id select b).FirstOrDefault();
                if (x != null)
                {

                    ctx.Grupes.Remove(x);
                    ctx.SaveChanges();
                }
            }
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


        //PROFESORI
        public static List<Profesor> GetProfesori()
        {
            List<Profesor> profesor = null;
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                profesor = (from x in ctx.Profesors
                        select x).ToList();
            }
            return profesor;
        }

        public static void InsertProfesor(string nume,string prenume,string telefon,string departamen,string statut,string email, string tip,string user,string pass)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                Profesor profesor = new Profesor()
                {
                    Nume = nume,
                    Prenume = prenume,
                    Telefon = telefon,
                    Departament = departamen,
                    Statut = statut,
                    email = email,
                    Tip = tip

                };
                ctx.Profesors.Add(profesor);
                ctx.SaveChanges();
                InsertLogIn(user, pass, 1);
               
            }
        }
        public static void DeleteProfesor(int id)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                var delProf = (from x in ctx.Profesors where x.id_prof == id select x).FirstOrDefault();
                ctx.Profesors.Remove(x);
                ctx.SaveChanges();
            }
        }
        //Studenti
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

        public static void InserStudent(string nume, string prenume,string initiala,string cnp,string adresa,string telefon,string tip,float taxa,string numegrupa,int credite,string email)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                Student student = new Student()
                {
                    //id_stud =id,
                    Nume = nume,
                    Prenume = prenume,
                    Initiala_Parinte = initiala,
                    CNP = cnp,
                    Adresa = adresa,
                    Telefon = telefon,
                    Tip = tip,
                    Taxa = taxa,
                    nume_grupa = numegrupa,
                    Credite = credite,
                    email = email
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();

            }
        }
        public static void DeleteStudenti(int id)
        {
            using (ProiectBazeContext ctx = new ProiectBazeContext())
            {
                List<Student> student = GetStudent();

                var x = (from b in ctx.Students where b.id_stud == id select b).FirstOrDefault();
                if (x != null )
                {

                    ctx.Students.Remove(x);
                    ctx.SaveChanges();
                }
            }
        }




        //public static void aifsarenoteStudent(string name)
        //{
        //    using (ProiectBazeContext ctx = new ProiectBazeContext())
        //    {
        //        var noteStudent = from b in ctx.Students where b.Nume == name 
        //    }
        //}

    };



     

    
}
