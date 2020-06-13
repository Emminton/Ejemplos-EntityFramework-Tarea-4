using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ejercicios_EntityFrameworCore.Entidades
{
    class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        //Aplicando relaciones 
        public int studentId { get; set; }
        [ForeignKey("studentId")]
        public virtual Studen Student { get; set; }

        public Course()
        {
            CourseId = 0;
            CourseName = string.Empty;
            studentId = 0;
        }
    }
}
