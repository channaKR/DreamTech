using DreamTech.Model;

namespace DreamTech.Interface
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(int id);

    }
}
