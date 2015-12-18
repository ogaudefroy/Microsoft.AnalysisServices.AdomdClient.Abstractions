namespace Microsoft.AnalysisServices.AdomdClient
{
    using System;
    using System.Data;
    using System.Xml;

    /// <summary>
    /// Encapsulates the AdomdCommand intrinsinc object that contains ADOMD-specific information about a command.
    /// </summary>
    public class AdomdCommandWrapper : IAdomdCommand
    {
        private readonly AdomdCommand _innerCommand;

        /// <summary>
        /// Initializes a new instance of the AdomdCommandWrapper class by using the specified command.
        /// </summary>
        /// <param name="command">The AdomdCommand to encapsulate.</param>
        public AdomdCommandWrapper(AdomdCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            _innerCommand = command;
        }

        /// <inheritdoc />
        public object Execute()
        {
            return _innerCommand.Execute();
        }

        /// <inheritdoc />
        public XmlReader ExecuteXmlReader()
        {
            return _innerCommand.ExecuteXmlReader();
        }

        /// <inheritdoc />
        public CellSet ExecuteCellSet()
        {
            return _innerCommand.ExecuteCellSet();
        }

        /// <inheritdoc />
        public void Cancel()
        {
            _innerCommand.Cancel();
        }

        /// <inheritdoc />
        public string CommandText
        {
            get { return _innerCommand.CommandText; }
            set { _innerCommand.CommandText = value; }
        }

        /// <inheritdoc />
        public int CommandTimeout
        {
            get { return _innerCommand.CommandTimeout; }
            set { _innerCommand.CommandTimeout = value; }
        }

        /// <inheritdoc />
        public CommandType CommandType
        {
            get { return _innerCommand.CommandType; }
            set { _innerCommand.CommandType = value; }
        }

        /// <inheritdoc />
        public IDbConnection Connection
        {
            get { return _innerCommand.Connection; }
            set { _innerCommand.Connection = (AdomdConnection)value; }
        }

        /// <inheritdoc />
        public IDbDataParameter CreateParameter()
        {
            return _innerCommand.CreateParameter();
        }

        /// <inheritdoc />
        public IAdomdDataAdapter CreateDataAdapter()
        {
            return new AdomdDataAdapterWrapper(new AdomdDataAdapter(_innerCommand));
        }

        /// <inheritdoc />
        public int ExecuteNonQuery()
        {
            return _innerCommand.ExecuteNonQuery();
        }

        /// <inheritdoc />
        public IDataReader ExecuteReader(CommandBehavior behavior)
        {
            return _innerCommand.ExecuteReader(behavior);
        }

        /// <inheritdoc />
        public IDataReader ExecuteReader()
        {
            return _innerCommand.ExecuteReader();
        }

        /// <inheritdoc />
        public object ExecuteScalar()
        {
            return _innerCommand.ExecuteScalar();
        }

        /// <inheritdoc />
        public IDataParameterCollection Parameters
        {
            get { return _innerCommand.Parameters; }
        }

        /// <inheritdoc />
        public void Prepare()
        {
            _innerCommand.Prepare();
        }

        /// <inheritdoc />
        public IDbTransaction Transaction
        {
            get { return ((IDbCommand)_innerCommand).Transaction; }
            set { ((IDbCommand)_innerCommand).Transaction = value; }
        }

        /// <inheritdoc />
        public UpdateRowSource UpdatedRowSource
        {
            get { return _innerCommand.UpdatedRowSource; }
            set { _innerCommand.UpdatedRowSource = value; }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _innerCommand.Dispose();
        }

        /// <summary>
        /// Explicit cast on AdomdCommand.
        /// </summary>
        /// <param name="wrapper">The command wrapper.</param>
        /// <returns>The inner command.</returns>
        public static explicit operator AdomdCommand(AdomdCommandWrapper wrapper)
        {
            return wrapper._innerCommand;
        }
    }
}
