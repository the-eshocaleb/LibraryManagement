using BookManagement.DTO;
using LibraryManagement.Areas.Identity.Data;

namespace LibraryManagement.services
{
    public class UserService
    {
        private readonly AuthContext _authContext;

        public UserService(AuthContext authContext)
        {
            _authContext = authContext;
        }


        public string createUser(UserDTOIn userdto)
        {
            User user = new User();
            user.Firstname = userdto.firstname;
            user.Lastname = userdto.lastname;
            user.Age = userdto.age;

            _authContext.Users.Add(user);
            _authContext.SaveChanges();
            return user.Firstname;
        }

        public IEnumerable<UserDTOOut> getUsers()

        {
            List<UserDTOOut> usersdto = new List<UserDTOOut>();
            IEnumerable<User> users = _authContext.Users;

            foreach (var user in users)
            {
                UserDTOOut userdto = new UserDTOOut(user.Firstname, user.Lastname);
                usersdto.Add(userdto);
            }
            return usersdto;
        }
    }
}
