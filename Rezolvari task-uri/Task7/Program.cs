using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task7.Program;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesor profesor = new Profesor("Marius", "Stefan", "1274262643173", "Fizica");
            Curs curs = new Curs("Fizica cuantica", 2, profesor);

            Student[] studenti = new Student[]
            {
            new Student("Vlad", "Ion", "9836743110982"),
            new Student("Nichita", "Maria", "1928374650912"),
            new Student("Nicu", "Stan", "1935882350912")
            };
          
            studenti[0].AdaugaNota(10); // Vlad Ion
            studenti[1].AdaugaNota(8);  // Nichita Maria
            studenti[2].AdaugaNota(5);  // Nicu Stan

            foreach (var student in studenti)
            {
                if (curs.InscrieStudent(student))
                {
                    Console.WriteLine($"{student.Nume} {student.Prenume} a fost inscris la curs.");
                }
                else
                {
                    Console.WriteLine($"Nu mai sunt locuri disponibile pentru {student.Nume} {student.Prenume}.");
                }
            }

            curs.AfiseazaStudentiInscrisi();
        }
		
        public abstract class Persoana
        {
            public string Nume { get; set; }
            public string Prenume { get; set; }
            public string CNP { get; set; }

            public Persoana(string nume, string prenume, string cnp)
            {
                Nume = nume;
                Prenume = prenume;
                CNP = cnp;
            }
            public abstract void AfiseazaDetalii();
        }
		
        public class Student : Persoana
        {
            public List<int> Note { get; set; }

            public Student(string nume, string prenume, string cnp) : base(nume, prenume, cnp)
            {
                Note = new List<int>();
            }
            public void AdaugaNota(int nota)
            {
                Note.Add(nota);
            }
            public override void AfiseazaDetalii()
            {
                Console.WriteLine($"Student: {Nume} {Prenume}, CNP: {CNP}, Nota: {Note.FirstOrDefault()}");
            }
        }
		
        public class Profesor : Persoana
        {
            public string DenumireCurs { get; set; }

            public Profesor(string nume, string prenume, string cnp, string denumireCurs) : base(nume, prenume, cnp)
            {
                DenumireCurs = denumireCurs;
            }

            public override void AfiseazaDetalii()
            {
                Console.WriteLine($"Profesor: {Nume} {Prenume}, CNP: {CNP}, Preda: {DenumireCurs}");
            }
        }
		
        public class Curs
        {
            public string Denumire { get; set; }
            public int NumarLocuri { get; set; }
            public List<Student> StudentiInscrisi { get; set; }
            public Profesor ProfesorCurs { get; set; }

            public Curs(string denumire, int numarLocuri, Profesor profesor)
            {
                Denumire = denumire;
                NumarLocuri = numarLocuri;
                ProfesorCurs = profesor;
                StudentiInscrisi = new List<Student>();
            }
			
            public bool InscrieStudent(Student student)
            {
                if (StudentiInscrisi.Count < NumarLocuri)
                {
                    StudentiInscrisi.Add(student);
                    return true;
                }
                return false;
            }
			
            public void AfiseazaStudentiInscrisi()
            {
                Console.WriteLine($"Curs: {Denumire}, Profesor: {ProfesorCurs.Nume} {ProfesorCurs.Prenume}");
                Console.WriteLine("Studenti inscrisi:");
                foreach (var student in StudentiInscrisi)
                {
                    student.AfiseazaDetalii();
                }
            }
        }
    }
}
