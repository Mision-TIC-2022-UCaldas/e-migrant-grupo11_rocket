using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;


namespace MyApp.Namespace
{
    public class DeleteEntidadModel : PageModel
    {
        private readonly IRepositorioEntidad _repo;
        public Entidad entidad { get; set;}

        public DeleteEntidadModel(IRepositorioEntidad repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteEntidad(id);
        }
    }
}

