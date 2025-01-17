namespace BookManagement.DTO
{

    public class UserDTOIn
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
    }
    public class UserDTOOut
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        public UserDTOOut(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}
