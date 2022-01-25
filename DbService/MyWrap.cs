using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DbService
{
    public class MyWrap : IMyWrap
    {
        private string _connectionString = "server=127.0.0.1;uid=admin;pwd=rootroot1225;database=skinsbet;";
        public async Task<DataTable> ExecProcedureAsync()
        {
            return await Task.Run(() =>
            {
                using (var mySqlConnection = new MySqlConnection(this._connectionString))
                {
                    return new DataTable();
                }
            });
        }

        public Task<DataTable> ExecSqlCommandAsync(string sql)
        {
            return Task.Run(() =>
            {
                using (var mySqlConnection = new MySqlConnection(this._connectionString))
                {
                    DataTable table = new DataTable();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = mySqlConnection;
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                    }
                    return table;
                }
            });
        }

        public Task<DataTable> ExecSqlBlobCommandAsync(string sql, byte[] data)
        {
            return Task.Run(() =>
            {
                using (var mySqlConnection = new MySqlConnection(this._connectionString))
                {
                    DataTable table = new DataTable();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = mySqlConnection;
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        MySqlParameter blob = new MySqlParameter("@Image", MySqlDbType.Blob, data.Length);
                        blob.Value = data;
                        cmd.Parameters.Add(blob);
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                    }
                    return table;
                }
            });
        }

        public void SetConnectionString(string cs)
        {
            this._connectionString = cs;
        }
    }
}