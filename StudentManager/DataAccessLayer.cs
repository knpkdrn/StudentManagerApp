using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class DataAccessLayer
    {

        // The class encapsulates common database operations such as executing queries, inserts, updates, and deletes

        private string ConnectionString { get; set; }

        public DataAccessLayer(string connectionString)
        {
            ConnectionString = connectionString;
        }

        
        public SqlParameter CreateParameter(string name, object value, DbType dbType)
        {
            return CreateParameter(name, 0, value, dbType, ParameterDirection.Input);
        }

        public SqlParameter CreateParameter(string name,int size, object value, DbType dbType)
        {
            return CreateParameter(name, size, value, dbType, ParameterDirection.Input);
        }

        // Create an SqlParameter with name, size, value, DbType, and direction.
        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Direction = direction,
                Value = value
            };
        }

        // Execute a query and return a DataTable.
        public DataTable GetDataTable(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using(var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;
                    if(parameters != null)
                    {
                        foreach(var parameter in parameters)
                            command.Parameters.Add(parameter);
                    }

                    DataSet dataSet = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        }

        // Execute a query and return a scalar value.
        public object GetScalarValue(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using(var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                            command.Parameters.Add(parameter);
                    }

                    return command.ExecuteScalar();
                }
            }
        }

        // Execute an INSERT command.
        public void Insert(string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using(var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                            command.Parameters.Add(parameter);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        // Execute an INSERT command and return the last inserted ID.
        public int Insert(string commandText, CommandType commandType, SqlParameter[] parameters, out int lastId)
        {
            lastId = 0;
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                            command.Parameters.Add(parameter);
                    }
                    object newId = command.ExecuteScalar();
                    lastId = Convert.ToInt32(newId);
                }
            }

            return lastId;
        }

        // Execute an INSERT command and return the last inserted ID as a long data type
        public long Insert(string commandText, CommandType commandType, SqlParameter[] parameters, out long lastId)
        {
            lastId = 0;
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                            command.Parameters.Add(parameter);
                    }
                    object newId = command.ExecuteScalar();
                    lastId = Convert.ToInt64(newId);
                }
            }

            return lastId;
        }

        // Execute an UPDATE command.
        public void Update(string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if(parameters != null)
                    {
                        foreach (var parameter in parameters)
                            command.Parameters.Add(parameter);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        // Execute a DELETE command.
        public void Delete(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using(var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                            command.Parameters.Add(parameter);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
