using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryApp.Entities
{
    public abstract class BaseEntity 
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime? CreatedAt { get; set; }
        public int? CreatedUserId { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedUserId { get; set; }
    }
}
