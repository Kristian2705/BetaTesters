using BetaTesters.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Infrastructure.Data.Models
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TaskNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(TaskDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        public DateTime? AssignDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public TaskState State { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public Approval Approval { get; set; }

        [Required]
        public Guid ProgramId { get; set; }

        [ForeignKey(nameof(ProgramId))]
        public BetaProgram Program { get; set; } = null!;

        [Required]
        public Guid CreatorId { get; set; }

        [ForeignKey(nameof(CreatorId))]
        public ApplicationUser Creator { get; set; } = null!;

        public Guid? ContractorId { get; set; }

        [ForeignKey(nameof(ContractorId))]
        public ApplicationUser? Contractor { get; set; } = null!;

        [Required]
        [Column("decimal(18,2)")]
        public decimal Reward { get; set; }

        public bool IsDeleted { get; set; }
    }
}
