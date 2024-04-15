using BetaTesters.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static BetaTesters.Core.Constants.MessageConstants;
using static BetaTesters.Infrastructure.Constants.DataConstants;

namespace BetaTesters.Core.Models.Task
{
    public class TaskFormModel
    {
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

        [Required(ErrorMessage = RequiredMessage)]
        [Range(0.00, 999999.99)]
        public decimal Reward { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string? CreatorId { get; set; }

        public string ProgramId {  get; set; } = string.Empty;

        public TaskState TaskState { get; set; }

        public Approval Approval { get; set; }

        public IEnumerable<TaskCategoryServiceModel> Categories { get; set; } = 
            new List<TaskCategoryServiceModel>();
    }
}
