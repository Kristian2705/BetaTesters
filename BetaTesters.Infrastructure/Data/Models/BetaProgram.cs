using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class BetaProgram
    {
        public BetaProgram()
        {
            Tasks = new HashSet<Task>();
            Moderators = new HashSet<ApplicationUser>();
            Contractors = new HashSet<ApplicationUser>();
            Applications = new HashSet<CandidateApplication>();
        }
        [Key]
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public ApplicationUser Owner { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public IEnumerable<Task> Tasks { get; set; }
        //Inverse property to be added
        public IEnumerable<ApplicationUser> Moderators { get; set; }
        public IEnumerable<ApplicationUser> Contractors { get; set; }
        public IEnumerable<CandidateApplication> Applications { get; set; }
    }
}
