using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicios_EntityFrameworCore.Entidades
{
    class Materia
    {
        [Key]
        public int MateriaId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public Materia()
        {
            MateriaId = 0;
            name = string.Empty;
            lastName = string.Empty;
        }
    }
}
