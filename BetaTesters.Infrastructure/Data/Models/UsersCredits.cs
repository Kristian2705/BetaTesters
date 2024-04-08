using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class UsersCredits
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ContractorId { get; set; }
        [ForeignKey(nameof(ContractorId))]
        public ApplicationUser Contractor { get; set; } = null!;
        public Guid TaskId { get; set; }
        [ForeignKey(nameof(TaskId))]
        public Task Task { get; set; } = null!;
        public int Credits { get; set; }
    }
}
