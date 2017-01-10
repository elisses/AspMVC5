using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
//Para que nossa aplicação possa se beneficiar do Entity
//Framework, é preciso que ele acesse a base de dados por meio de um
//contexto, que representará uma sessão de interação da aplicação
//com a base de dados, seja para consulta ou atualização.
namespace Projeto01.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_NEt_MVC_CS") { }
        
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        
    }
}