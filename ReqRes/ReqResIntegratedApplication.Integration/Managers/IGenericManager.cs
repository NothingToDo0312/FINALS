using System.Threading.Tasks;

namespace ReqresIntegratedApplication.Integration.Managers
{
    public interface IGenericManager<T> where T : class
    {
        Task<T> Post();
        Task<T> Get();
        Task<T> GetById(int id);
        Task<T> Put(int id);
        Task<T> Patch(int id);
    }
}
