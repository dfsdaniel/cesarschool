using System;
using SQLite;

namespace ExemploBD
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("id"), PrimaryKey(), AutoIncrement()]
        public int Id
        {
            get;
            set;
        }

        [Column("nome")]
        public string Nome 
        {
            get;
            set;
        }

        [Column("cidade")]
        public string Cidade
        {
            get;
            set;
        }
    }
}
