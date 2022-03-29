﻿using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Web.Models
{
    public class LoginViewModel
    {
        [Display(Name="Usuário:")]
        public string Usuario { get; set; }

        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
    }
}