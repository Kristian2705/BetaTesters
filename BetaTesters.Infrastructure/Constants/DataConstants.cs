namespace BetaTesters.Infrastructure.Constants
{
    public class DataConstants
    {
        public const int CandidateApplicationMotivationMaxLength = 500;
        public const int CandidateApplicationMotivationMinLength = 30;

        public const int PhoneNumberLength = 10;

        public const int ApplicationUserFirstNameMaxLength = 20;
        public const int ApplicationUserFirstNameMinLength = 1;

        public const int ApplicationUserLastNameMaxLength = 30;
        public const int ApplicationUserLastNameMinLength = 1;

        public const int BetaProgramNameMaxLength = 30;
        public const int BetaProgramNameMinLength = 1;

        public const int BetaProgramDescriptionMaxLength = 100;
        public const int BetaProgramDescriptionMinLength = 20;

        public const int CategoryNameMaxLength = 20;
        public const int CategoryNameMinLength = 2;

        public const int TaskNameMaxLength = 20;
        public const int TaskNameMinLength = 2;

        public const int TaskDescriptionMaxLength = 100;
        public const int TaskDescriptionMinLength = 10;

        public const double TaskRewardMaxValue = 999.99;
        public const double TaskRewardMinValue = 1.00;

        public const double PaymentAmountMaxValue = 999999.99;
        public const double PaymentAmountMinValue = 1.00;

        public const string DateFormat = "dd/MM/yyyy HH:mm";
    } 
}
