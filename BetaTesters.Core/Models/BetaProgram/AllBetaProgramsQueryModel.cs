namespace BetaTesters.Core.Models.BetaProgram
{
	public class AllBetaProgramsQueryModel
	{
		public const int BetaProgramsPerPage = 2;
		public int CurrentPage { get; init; } = 1;
		public int TotalBetaProgramsCount { get; set; }
		public IEnumerable<BetaProgramServiceModel> BetaPrograms { get; set; } = new List<BetaProgramServiceModel>();
	}
}
