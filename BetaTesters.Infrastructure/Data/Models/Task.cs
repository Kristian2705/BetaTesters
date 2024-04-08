using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? AssignDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public TaskState? State { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
        public Approval Approval { get; set; }
        public Guid ProgramId { get; set; }
        [ForeignKey(nameof(ProgramId))]
        public BetaProgram Program { get; set; } = null!;
        public Guid ModeratorId { get; set; }
        [ForeignKey(nameof(ModeratorId))]
        public ApplicationUser Moderator { get; set; } = null!;
        public Guid? ContractorId { get; set; }
        [ForeignKey(nameof(ContractorId))]
        public ApplicationUser? Contractor { get; set; } = null!;
        public int Credits { get; set; }
        public bool IsDeleted { get; set; }
    }
}
