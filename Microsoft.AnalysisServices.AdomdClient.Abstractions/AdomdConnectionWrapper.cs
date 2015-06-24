namespace Microsoft.AnalysisServices.AdomdClient
{
    using System;
    using System.Data;

    /// <summary>
    /// Encapsulates the AdomdConnection intrinsinc object that contains ADOMD-specific information about a connection.
    /// </summary>
    public class AdomdConnectionWrapper : IAdomdConnection
    {
        private readonly AdomdConnection _innerConnection;

        /// <summary>
        /// Initializes a new instance of the AdomdConnectionWrapper class by using the specified command.
        /// </summary>
        /// <param name="connection">The AdomdConnection to encapsulate.</param>
        public AdomdConnectionWrapper(AdomdConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }
            _innerConnection = connection;
        }

        /// <inheritdoc />
        public IAdomdCommand CreateCommand()
        {
            return new AdomdCommandWrapper(_innerConnection.CreateCommand());
        }

        /// <inheritdoc />
        public CubeCollection Cubes
        {
            get { return _innerConnection.Cubes; }
        }

        /// <inheritdoc />
        public MiningModelCollection MiningModels
        {
            get { return _innerConnection.MiningModels; }
        }

        /// <inheritdoc />
        public MiningStructureCollection MiningStructures
        {
            get { return _innerConnection.MiningStructures; }
        }

        /// <inheritdoc />
        public MiningServiceCollection MiningServices
        {
            get { return _innerConnection.MiningServices; }
        }

        /// <inheritdoc />
        public string ProviderVersion
        {
            get { return _innerConnection.ProviderVersion; }
        }

        /// <inheritdoc />
        public string ClientVersion
        {
            get { return _innerConnection.ClientVersion; }
        }

        /// <inheritdoc />
        public string ServerVersion
        {
            get { return _innerConnection.ServerVersion; }
        }

        /// <inheritdoc />
        public string SessionID
        {
            get { return _innerConnection.SessionID; }
        }

        /// <inheritdoc />
        public bool ShowHiddenObjects
        {
            get { return _innerConnection.ShowHiddenObjects; }
        }

        /// <inheritdoc />
        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return _innerConnection.BeginTransaction(il);
        }

        /// <inheritdoc />
        public IDbTransaction BeginTransaction()
        {
            return _innerConnection.BeginTransaction();
        }

        /// <inheritdoc />
        public void ChangeDatabase(string databaseName)
        {
            _innerConnection.ChangeDatabase(databaseName);
        }

        /// <inheritdoc />
        public void Close()
        {
            _innerConnection.Close();
        }

        /// <inheritdoc />
        public string ConnectionString
        {
            get { return _innerConnection.ConnectionString; }
            set { _innerConnection.ConnectionString = value; }
        }

        /// <inheritdoc />
        public int ConnectionTimeout
        {
            get { return _innerConnection.ConnectionTimeout; }
        }

        /// <inheritdoc />
        IDbCommand IDbConnection.CreateCommand()
        {
            return _innerConnection.CreateCommand();
        }

        /// <inheritdoc />
        public string Database
        {
            get { return _innerConnection.Database; }
        }

        /// <inheritdoc />
        public void Open()
        {
            _innerConnection.Open();
        }

        /// <inheritdoc />
        public ConnectionState State
        {
            get { return _innerConnection.State; }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _innerConnection.Dispose();
        }

        /// <inheritdoc />
        public void Close(bool endSession)
        {
            _innerConnection.Close(endSession);
        }

        /// <inheritdoc />
        public DataSet GetSchemaDataSet(Guid schema, object[] restrictions)
        {
            return _innerConnection.GetSchemaDataSet(schema, restrictions);
        }

        /// <inheritdoc />
        public DataSet GetSchemaDataSet(string schemaName, AdomdRestrictionCollection restrictions)
        {
            return _innerConnection.GetSchemaDataSet(schemaName, restrictions);
        }

        /// <inheritdoc />
        public DataSet GetSchemaDataSet(Guid schema, object[] restrictions, bool throwOnInlineErrors)
        {
            return _innerConnection.GetSchemaDataSet(schema, restrictions, throwOnInlineErrors);
        }

        /// <inheritdoc />
        public DataSet GetSchemaDataSet(string schema, AdomdRestrictionCollection restrictions, bool throwOnInlineErrors)
        {
            return _innerConnection.GetSchemaDataSet(schema, restrictions, throwOnInlineErrors);
        }

        /// <inheritdoc />
        public DataSet GetSchemaDataSet(string schemaName, string schemaNamespace, AdomdRestrictionCollection restrictions)
        {
            return _innerConnection.GetSchemaDataSet(schemaName, schemaNamespace, restrictions);
        }

        /// <inheritdoc />
        public DataSet GetSchemaDataSet(string schemaName, string schemaNamespace, AdomdRestrictionCollection restrictions, bool throwOnInlineErrors)
        {
            return _innerConnection.GetSchemaDataSet(schemaName, schemaNamespace, restrictions, throwOnInlineErrors);
        }

        /// <inheritdoc />
        public void RefreshMetadata()
        {
            _innerConnection.RefreshMetadata();
        }
    }
}
