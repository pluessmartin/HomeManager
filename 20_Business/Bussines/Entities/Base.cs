using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Entities
{
    public abstract class Base 
    {
        //  [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Timestamp]
        [ConcurrencyCheck]
        public byte[] RowVersion { get; set; }

        public DateTimeOffset? Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset? Modified { get; set; }

        public string ModifiedBy { get; set; }

        public bool Deleted { get; set; }
    }
}
