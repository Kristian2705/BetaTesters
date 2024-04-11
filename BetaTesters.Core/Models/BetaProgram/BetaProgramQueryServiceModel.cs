namespace BetaTesters.Core.Models.BetaProgram
{
	public class BetaProgramQueryServiceModel
	{
		public int TotalBetaProgramsCount { get; set; }
		public IEnumerable<BetaProgramServiceModel> BetaPrograms { get; set; } = new List<BetaProgramServiceModel>();
	}
}
