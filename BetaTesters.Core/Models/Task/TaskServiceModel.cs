using BetaTesters.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static BetaTesters.Core.Constants.MessageConstants;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Core.Models.Task
{
    public class TaskServiceModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TaskNameMaxLength, 
            MinimumLength = TaskNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TaskDescriptionMaxLength,
            MinimumLength = TaskDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;

        public string? AssignDate { get; set; }

        public string? FinishDate { get; set; }

        [EnumDataType(typeof(TaskState))]
        public TaskState State { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Range(0.00, 999999.99)]
        public decimal Reward { get; set; }
    }
}
