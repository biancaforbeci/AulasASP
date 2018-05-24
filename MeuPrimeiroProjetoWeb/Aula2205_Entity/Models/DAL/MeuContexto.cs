using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula2205_Entity.Models.DAL
{
    public class MeuContexto :DbContext
    {
        public MeuContexto(): base("strConn")
        {
            //  DropCreateDatabaseAlways
            // DropCreateDatabaseIfModelChanges Se houver mudança na modelo ele apaga e cria de novo.
            // Migrations (para por sistema em produção)
            Database.SetInitializer<MeuContexto>(new DropCreateDatabaseIfModelChanges<MeuContexto>());
        }

        public DbSet<T> NomeTabela { }



    }
}