namespace Кузнецов_23ИС_ПР3.ADO.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string First_Name { get; set; }

        [StringLength(50)]
        public string Second_Name { get; set; }

        public string Pictures { get; set; }

        public int? RoleID { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
