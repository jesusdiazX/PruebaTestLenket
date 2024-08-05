using Dapper;
using MiniProfiler.Integrations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiData.Repositorio
{
  internal  class DapperRepositorio
    {



        #region Private Fields

        private readonly string ConnectionString;
        private CustomDbProfiler profiler = CustomDbProfiler.Current;

        #endregion Private Fields

        #region Public Constructors

        public DapperRepositorio()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DBDEMO"].ToString();
        }

        public DapperRepositorio(string connectionString)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[connectionString].ToString();
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<object> Add(string command, object model)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.ExecuteScalarAsync(command, model);
                return data;
            }
        }

        public async Task<object> Add(string command, object model, CommandType commandType)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.ExecuteScalarAsync(command, model, commandType: commandType);
                return data;
            }
        }

        public async Task Delete(string command, object model)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                await connection.QueryAsync(command, model);
            }
        }

        public async Task Delete(string command, object model, CommandType commandType)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                await connection.QueryAsync(command, model, commandType: commandType);
            }
        }


        public async Task<TEntity> GetById<TEntity>(string command, object model)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<TEntity>(command, model);
                return data.FirstOrDefault();
            }
        }
        public async Task<TEntity> GetById<TEntity>(string command, object model, CommandType commandType, string conn)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(conn), profiler))
            {
                var data = await connection.QueryAsync<TEntity>(command, model, commandType: commandType);
                return data.FirstOrDefault();
            }
        }

        public async Task<TEntity> GetById<TEntity>(string command, object model, CommandType commandType)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<TEntity>(command, model, commandType: commandType);
                return data.FirstOrDefault();
            }
        }

        public async Task<object> GetById<TEntity>(string command)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<TEntity>(command);
                return data.FirstOrDefault();
            }
        }

        public async Task<object> GetById(string command, object model, CommandType commandType, string conn)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(conn), profiler))
            {
                var data = await connection.QueryAsync(command, model, commandType: commandType);
                return data.FirstOrDefault();
            }
        }

        public async Task<string> GetCommands()
        {
            var commands = profiler.GetCommands();
            return await Task.FromResult(commands);
        }

        public async Task<IEnumerable> GetList(string command)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync(command);
                return data;
            }
        }
        public async Task<IEnumerable> GetList(string command, string cnn)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(cnn), profiler))
            {
                var data = await connection.QueryAsync(command);
                return data;
            }
        }


        public async Task<List<T>> GetList<T>(string command) where T : new()
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<T>(command);
                return data.ToList();
            }
        }

        public async Task<IEnumerable> GetListParsed(string command)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<object>(command);
                return data;
            }
        }

        public async Task<IEnumerable> GetListFilter(string command, object model)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<object>(command, model);
                return data;
            }
        }

        public async Task<IEnumerable> GetItemsFilter(string command, object model, CommandType commandType)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<object>(command, model, commandType: commandType);
                return data;
            }
        }

        public async Task<IEnumerable<T>> GetItemsFilter<T>(string command, object model, CommandType commandType)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                var data = await connection.QueryAsync<T>(command, model, commandType: commandType);
                return data;
            }
        }

        public async Task Update(string command, object model)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                await connection.QueryAsync(command, model);
            }
        }

        public async Task<IEnumerable> GetItem(string command, string conn)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(conn), profiler))
            {
                var data = await connection.QueryAsync<object>(command);
                return data;
            }
        }

        public async Task<List<T>> GetItem<T>(string command, string conn) where T : new()
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(conn), profiler))
            {
                var data = await connection.QueryAsync<T>(command);
                return data.ToList();
            }
        }

        public async Task<List<T>> GetList<T>(string command, string conn) where T : new()
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(conn), profiler))
            {
                var data = await connection.QueryAsync<T>(command);
                return data.ToList();
            }
        }

        public async Task<T[]> GetList<T>(string command, object model, CommandType commandType, string conn) where T : new()
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(conn), profiler))
            {
                var data = await connection.QueryAsync<T>(command, model, commandType: commandType);
                return data.ToArray();
            }
        }

        public async Task ExecuteNonQuery(string command, object model, CommandType commandType)
        {
            using (var connection = ProfiledDbConnectionFactory.New(new SqlServerDbConnectionFactory(ConnectionString), profiler))
            {
                await connection.QueryAsync(command, model, commandType: commandType);
            }
        }

        #endregion Public Methods
    }
}
