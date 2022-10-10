namespace OCL.Users.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }


        public static List<User> GetUsers()
        {
            return new List<User>
            {
                new()
                {
                    Id = 0,
                    FirstName="Amir",
                    LastName="Firoozi",
                    UserName ="afiroozi6"
                },
                new()
                {
                    Id=1,
                    FirstName="Danial",
                    LastName="Firoozi",
                    UserName="dani.frz"
                }
            };
        }
    }
}
