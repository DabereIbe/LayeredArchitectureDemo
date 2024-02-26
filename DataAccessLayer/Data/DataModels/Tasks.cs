using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.DataModels
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public bool IsComplete { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateCompleted { get; set; }
    }
}
