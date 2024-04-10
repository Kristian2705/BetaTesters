using Microsoft.AspNetCore.Identity;
using BetaTesters.Infrastructure.Data.Enums;
using static BetaTesters.Infrastructure.Constants.RoleConstants;
using BetaTesters.Infrastructure.Constants;

namespace BetaTesters.Infrastructure.Data.Models.SeedDatabase
{
    internal class SeedData
    {
        public SeedData()
        {
            SeedPrograms();
            SeedUsers();
            SeedClaims();
            SeedRoles();
            SeedUserRoles();
            SeedCategories();
            SeedTasks();
        }

        public ApplicationUser DefaultUser { get; set; } = null!;

        public ApplicationUser Moderator { get; set; } = null!;

        public ApplicationUser Owner { get; set; } = null!;

        public Category NewFeatureCategory { get; set; } = null!;

        public Category BugFixCategory { get; set; } = null!;

        public Category CheckStateCategory { get; set; } = null!;

        public BetaProgram FacebookProgram { get; set; } = null!;

        public Task FirstTask { get; set; } = null!;

        public Task SecondTask { get; set; } = null!;

        public Task ThirdTask { get; set; } = null!;

        public List<IdentityRole<Guid>> Roles { get; set; } = new List<IdentityRole<Guid>>();

        public List<IdentityUserRole<Guid>> UsersRoles { get; set; } = new List<IdentityUserRole<Guid>>();

        public List<IdentityUserClaim<Guid>> UsersClaims { get; set; } = new List<IdentityUserClaim<Guid>>();

        private void SeedClaims()
        {
            var defaultUserClaim = new IdentityUserClaim<Guid>
            {
                Id = 2,
                UserId = Guid.Parse("f903f113-d659-4848-87c5-97f49082ba46"),
                ClaimType = CustomClaims.UserFullNameClaim,
                ClaimValue = $"{DefaultUser.FirstName} {DefaultUser.LastName}"
            };

            var moderatorClaim = new IdentityUserClaim<Guid>
            {
                Id = 3,
                UserId = Guid.Parse("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                ClaimType = CustomClaims.UserFullNameClaim,
                ClaimValue = $"{Moderator.FirstName} {Moderator.LastName}"
            };

            var ownerClaim = new IdentityUserClaim<Guid>
            {
                Id = 4,
                UserId = Guid.Parse("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                ClaimType = CustomClaims.UserFullNameClaim,
                ClaimValue = $"{Owner.FirstName} {Owner.LastName}"
            };

            UsersClaims.Add(defaultUserClaim);
            UsersClaims.Add(moderatorClaim);
            UsersClaims.Add(ownerClaim);
        }

        private void SeedRoles()
        {
            IdentityRole<Guid> defaultUserRole = new IdentityRole<Guid>()
            {
                Id = Guid.Parse("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                Name = DefaultUserRole,
                NormalizedName = DefaultUserRole.ToUpper()
            };

            IdentityRole<Guid> moderatorRole = new IdentityRole<Guid>()
            {
                Id = Guid.Parse("b280f152-005b-49b2-a82a-7a1a142f898a"),
                Name = ModeratorRole,
                NormalizedName = ModeratorRole.ToUpper()
            };

            IdentityRole<Guid> ownerRole = new IdentityRole<Guid>()
            {
                Id = Guid.Parse("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                Name = OwnerRole,
                NormalizedName = OwnerRole.ToUpper()
            };

            Roles.Add(defaultUserRole);
            Roles.Add(moderatorRole);
            Roles.Add(ownerRole);
        }

        private void SeedUserRoles()
        {
            var defaultUserRoleToUser = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse("1c69a1cd-0a41-4e4d-a00a-a08d18c2cea9"),
                UserId = Guid.Parse("f903f113-d659-4848-87c5-97f49082ba46")
            };

            var moderatorRoleToUser = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse("b280f152-005b-49b2-a82a-7a1a142f898a"),
                UserId = Guid.Parse("38885cfb-4b65-4503-9958-6389ac64eb1a")
            };

            var ownerRoleToUser = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse("cd3cbaa6-1e80-45a4-a2ef-6de3fee4ed59"),
                UserId = Guid.Parse("dac439da-96ea-4ca5-aa3b-f059bd94c92c")
            };

            UsersRoles.Add(defaultUserRoleToUser);
            UsersRoles.Add(moderatorRoleToUser);
            UsersRoles.Add(ownerRoleToUser);
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            DefaultUser = new ApplicationUser()
            {
                Id = Guid.Parse("f903f113-d659-4848-87c5-97f49082ba46"),
                UserName = "useroff@mail.com",
                NormalizedUserName = "useroff@mail.com".ToUpper(),
                Email = "useroff@mail.com",
                NormalizedEmail = "useroff@mail.com".ToUpper(),
                FirstName = "User",
                LastName = "Userov",
                PhoneNumber = "0881234567",
                Age = 18
            };

            DefaultUser.PasswordHash = hasher
                .HashPassword(DefaultUser, "user1");

            DefaultUser.SecurityStamp = Guid.NewGuid().ToString();

            Moderator = new ApplicationUser()
            {
                Id = Guid.Parse("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                UserName = "modoff@mail.com",
                NormalizedUserName = "modoff@mail.com".ToUpper(),
                Email = "modoff@mail.com",
                NormalizedEmail = "modoff@mail.com".ToUpper(),
                FirstName = "Moderator",
                LastName = "Modov",
                PhoneNumber = "0891234561",
                Age = 22,
                BetaProgramId = Guid.Parse("f47b6e5c-46b8-4961-a809-787515b7d37e")
            };

            Moderator.PasswordHash = hasher
                .HashPassword(Moderator, "moderator1");

            Moderator.SecurityStamp = Guid.NewGuid().ToString();

            Owner = new ApplicationUser()
            {
                Id = Guid.Parse("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                UserName = "owneroff@mail.com",
                NormalizedUserName = "owneroff@mail.com".ToUpper(),
                Email = "owneroff@mail.com",
                NormalizedEmail = "owneroff@mail.com".ToUpper(),
                FirstName = "Owner",
                LastName = "Ownerov",
                PhoneNumber = "0891231456",
                Age = 31,
                BetaProgramId = Guid.Parse("f47b6e5c-46b8-4961-a809-787515b7d37e")
            };

            Owner.PasswordHash = hasher
                .HashPassword(Owner, "owner1");

            Owner.SecurityStamp = Guid.NewGuid().ToString();
        }

        private void SeedCategories()
        {
            NewFeatureCategory = new Category()
            {
                Id = 1,
                CategoryName = "New Feature"
            };

            BugFixCategory = new Category()
            {
                Id = 2,
                CategoryName = "Bug Fix"
            };

            CheckStateCategory = new Category()
            {
                Id = 3,
                CategoryName = "Check State"
            };
        }

        private void SeedPrograms()
        {
            FacebookProgram = new BetaProgram()
            {
                Id = Guid.Parse("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                Name = "Facebook Beta Program",
                Description = "This is the official beta testing program for Facebook",
                ImageUrl = "https://store-images.s-microsoft.com/image/apps.37935.9007199266245907.b029bd80-381a-4869-854f-bac6f359c5c9.91f8693c-c75b-4050-a796-63e1314d18c9?h=464"
            };
        }

        private void SeedTasks()
        {
            FirstTask = new Task()
            {
                Id = Guid.NewGuid(),
                Name = "Posts issue fix",
                Description = "Users can't properly create a new post is now fixed",
                State = TaskState.Available,
                CategoryId = BugFixCategory.Id,
                Approval = Approval.Accepted,
                ProgramId = Guid.Parse("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                CreatorId = Guid.Parse("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                Reward = 20,
            };

            SecondTask = new Task()
            {
                Id = Guid.NewGuid(),
                Name = "Added chat groups",
                Description = "Added a new feature where users can chat with friends",
                State = TaskState.Available,
                CategoryId = NewFeatureCategory.Id,
                Approval = Approval.Accepted,
                ProgramId = Guid.Parse("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                CreatorId = Guid.Parse("dac439da-96ea-4ca5-aa3b-f059bd94c92c"),
                Reward = 30
            };

            ThirdTask = new Task()
            {
                Id = Guid.NewGuid(),
                Name = "Check profile update",
                Description = "Check if the update profile feature works properly",
                State = TaskState.Available,
                CategoryId = CheckStateCategory.Id,
                Approval = Approval.Accepted,
                ProgramId = Guid.Parse("f47b6e5c-46b8-4961-a809-787515b7d37e"),
                CreatorId = Guid.Parse("38885cfb-4b65-4503-9958-6389ac64eb1a"),
                Reward = 15
            };
        }
    }
}
