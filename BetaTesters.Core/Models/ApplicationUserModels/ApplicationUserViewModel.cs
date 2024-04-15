namespace BetaTesters.Core.Models.ApplicationUserModels
{
    public class ApplicationUserViewModel
    {
        public Guid Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int? CompletedTasksCount { get; set; }

        public int? InProgressTasksCount { get; set; }

        public int? CreatedTasksCount { get; set; }

        public decimal? MoneyToTransfer {  get; set; }

        public string? BetaProgramId {  get; set; }

        public string Role { get; set; } = string.Empty;
    }
}
