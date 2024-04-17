using BetaTesters.Infrastructure.Data.Enums;

namespace BetaTesters.Core.Models.Transaction
{
	public class TransactionViewModel
	{
		public decimal Money { get; set; }

		public string SessionId { get; set; } = string.Empty;

		public TransactionType Type {  get; set; }
	}
}
