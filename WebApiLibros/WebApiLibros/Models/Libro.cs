﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLibros.Models
{
    [Table("Libro")]
    public class Libro
    { 
            public int Id { get; set; }

            [Required]
            [Column(TypeName = "varchar(50)")]
            public string Titulo { get; set; }

            [Column(TypeName = "varchar(200)")]
            public string Descripcion { get; set; }

            public int AutorId { get; set; }


            [ForeignKey("AutorId")]
            public Autor Autor { get; set; }
        }

    }

