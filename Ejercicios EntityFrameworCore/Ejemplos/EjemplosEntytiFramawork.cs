using Ejercicios_EntityFrameworCore.DALL;
using Ejercicios_EntityFrameworCore.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_EntityFrameworCore.Ejemplos
{
    class EjemplosEntytiFramawork
    {
        public static void GuardarStudentDB()
        {
            //Ejemplo de guardar en DB
            Contexto context = new Contexto();
            try
            {
                var auxStudent = new Studen()
                {
                    StudentId = 0,
                    FirstName = "Emminton Manuel",
                    LastName = "Ueña Santana"

                };
                context.Students.Add(auxStudent);
                bool save = context.SaveChanges() > 0;

                if (save)
                    Console.WriteLine("The Student was sucessfully saved!!");
                else
                    Console.WriteLine("We cant save the student..");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

        }

        public static void GuardarCourseDB()
        {
            //Ejemplo de guardar en DB
            Contexto context = new Contexto();
            try
            {
                var auxCourse = new Course()
                {
                    CourseId = 0,
                    studentId = 1,
                    CourseName = "Math"

                };
                context.Courses.Add(auxCourse);
                bool save = context.SaveChanges() > 0;

                if (save)
                    Console.WriteLine("The Course was sucessfully saved!!");
                else
                    Console.WriteLine("We cant save the course..");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }

        }


        public static void SimpleQueryDB()
        {
            //Ejemplo del Query
            const string NAME = "Michael";
            Contexto context = new Contexto();
            try
            {
                var list = context.Students.Where(s => s.FirstName == NAME).ToList();
                if (list != null)
                    Console.WriteLine(list.Find(s => s.FirstName == NAME).FirstName);
                else
                    Console.WriteLine("We cant find the student!!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }
        }
    

        public static void QuerryUsingSql()
        {
            //Ejemplo de querying usando FromSqlRaw
            Contexto context = new Contexto();
            List<Studen> studentList = new List<Studen>();
            try
            {

                studentList = context.Students.FromSqlRaw("Select *from dbo.Students").ToList();
                if (studentList != null)
                    Console.WriteLine(studentList.Find(s => s.FirstName == "Bill").FirstName);
                else
                    Console.WriteLine("We cant find the student!!");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

        }   

        public static void DeletingData()
        {
            //En este ejemplo modificamos el nombre del primer estudiante
            Contexto context = new Contexto();

            try
            {
                var std = context.Students.First<Studen>();
                context.Students.Remove(std);
                bool deleted = context.SaveChanges() > 0;

                if (deleted)
                    Console.WriteLine("Student deleted..");
                else
                    Console.WriteLine("We cant delete the student..");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }
        }

        public static void UpdatingOnDisconnectedScenario()
        {
            Contexto context = new Contexto();
            try
            {
                var modifiedStudent1 = new Studen()
                {
                    StudentId = 1,
                    FirstName = "Bill",
                    LastName = "Madison"
                };

                var modifiedStudent2 = new Studen()
                {
                    StudentId = 2,
                    FirstName = "Steve",
                    LastName = "Perez"
                };

                List<Studen> modifiedStudents = new List<Studen>()
                {
                    modifiedStudent1,
                    modifiedStudent2,
                };

                context.UpdateRange(modifiedStudents);
                bool modified = context.SaveChanges() > 0;
                if (modified)
                    Console.WriteLine("Modified");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

        }

        public static void QuerryParametrizado()
        {
            //Ejemplo de querying con paramettro
            Contexto context = new Contexto();
            List<Studen> studentList = new List<Studen>();
            string name = "Michael";
            try
            {
                studentList = context.Students.FromSqlRaw($"Select * from dbo.Students where FirstName = '{name}'").ToList();


                if (studentList != null)
                    Console.WriteLine(studentList.Find(s => s.FirstName == name).FirstName);
                else
                    Console.WriteLine("We cant find the student!!");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

        }
    }
}
