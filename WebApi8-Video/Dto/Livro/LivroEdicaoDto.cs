﻿using WebApi8_Video.Dto.Vinculo;
using WebApi8_Video.Models;

namespace WebApi8_Video.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
