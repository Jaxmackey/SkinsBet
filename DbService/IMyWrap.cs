using System.Data;
using System.Threading.Tasks;

namespace DbService
{
    public interface IMyWrap
    {
        void SetConnectionString(string cs);
        Task<DataTable> ExecSqlCommandAsync(string sql);
        Task<DataTable> ExecProcedureAsync();
    }
}