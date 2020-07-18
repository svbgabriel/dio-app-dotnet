﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoDIOMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }
    }
}
