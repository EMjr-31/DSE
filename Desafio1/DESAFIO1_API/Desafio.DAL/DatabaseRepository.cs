using Dapper;
using Desafio.DAL.Interfaces;
using System;
using Desafio.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Linq;

namespace Desafio.DAL
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private readonly string connectionString;

        public DatabaseRepository(IOptions<AppSettings> appSettings)
        {
            connectionString = appSettings.Value.ConnectionString;
        }

        public async Task<bool> Delete(string query, DynamicParameters parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var result = await connection.QuerySingleOrDefaultAsync<bool>(query, parameters);
                    connection.Close();
                    return default;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Errore en la consulta de Eliminar:" + ex.Message);
            }
        }

        public async Task<List<T>> GetDataByQueryAsync<T>(string query, DynamicParameters parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<T>(query, parameters);
                    connection.Close();
                    return result.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Errore en GetDataByQuery:" + ex.Message);
            }

        }

        public async Task<int> InsertAsync<T>(string query, DynamicParameters parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int result = await connection.QuerySingleOrDefaultAsync<int>(query, parameters);
                    connection.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la consulta de insertar: {ex.Message}", ex);
            }

        }

        public async Task<T> Update<T>(string query, DynamicParameters parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<T>(query, parameters);
                    connection.Close();
                    if (result != null && result.Any())
                    {
                        return result.FirstOrDefault();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Errore en la consulta de actualizar:" + ex.Message);
            }
            return default;

        }
    }
}
