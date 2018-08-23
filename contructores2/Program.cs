using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructores2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "José Perez";
            alumno1.Materias.Add(new Materia("Historia", "H1245"));
            alumno1.Materias.Add(new Materia("Fisica", "F1245"));
            alumno1.Materias.Add(new Materia("Álgebra", "A1245"));
            alumnos.Add(alumno1);

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Paola Ruiz";
            alumno2.Materias.Add(new Materia("Religion", "R1245"));
            alumno2.Materias.Add(new Materia("Biología", "B1245"));
            alumno2.Materias.Add(new Materia("Geografía", "G1245"));
            alumnos.Add(alumno2);

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Erika Lopez";
            alumno3.Materias.Add(new Materia("Química", "Q1245"));
            alumno3.Materias.Add(new Materia("Ética", "E1245"));
            alumno3.Materias.Add(new Materia("Filosofía", "F1246"));
            alumnos.Add(alumno3);

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Manolo Vasquez";
            alumno4.Materias.Add(new Materia("Informática", "I1245"));
            alumno4.Materias.Add(new Materia("Sociales", "S1245"));
            alumno4.Materias.Add(new Materia("Español", "F1246"));
            alumnos.Add(alumno4);

            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine("Nombre: " + alumno.Nombre);
                foreach(Materia materia in alumno.Materias)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
