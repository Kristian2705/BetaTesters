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

        public string? ContractorId { get; set; }

        public string? CreatorId { get; set; }

        [EnumDataType(typeof(TaskState))]
        public TaskState State { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Range(TaskRewardMinValue, TaskRewardMaxValue)]
        public decimal Reward { get; set; }
    }
}
