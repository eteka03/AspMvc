namespace prjQuestion1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class livres
    {
        [Key]
        public int Id_livres { get; set; }

        public string titre { get; set; }

        public string auteur { get; set; }

        public string ISBN { get; set; }

        public DateTime? datePub { get; set; }

        public double? prix { get; set; }
    }
}
