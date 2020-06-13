using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicios_EntityFrameworCore.Entidades
{
    class Studen
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Studen()
        {
            StudentId = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}
