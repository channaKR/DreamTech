using DreamTech.Model;

namespace DreamTech.Interface
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
       

    }
}
