using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DomainModels.Tasks
{
    public class TasksReadDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public bool IsComplete { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateCompleted { get; set; }
    }
}
