namespace Microsoft.AnalysisServices.AdomdClient
{
    using System;
    using System.Data;

    /// <summary>
    /// Encapsulates the AdomdDataAdpter intrinsinc object that contains ADOMD-specific information.
    /// </summary>
    public class AdomdDataAdapterWrapper : IAdomdDataAdapter
    {
        private readonly AdomdDataAdapter _innerAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdomdDataAdapter"/> class.
        /// </summary>
        /// <param name="innerAdapter">The AdomdDataAdapter to encapsulate.</param>
        public AdomdDataAdapterWrapper(AdomdDataAdapter innerAdapter)
        {
            if (innerAdapter == null)
            {
                throw new ArgumentNullException("innerAdapter");
            }
            _innerAdapter = innerAdapter;
        }

        /// <inheritdoc />
        public IAdomdCommand SelectCommand
        {
            get
            {
                return new AdomdCommandWrapper(_innerAdapter.SelectCommand);
            }
            set
            {
                _innerAdapter.SelectCommand = (AdomdCommand)(AdomdCommandWrapper)value;
            }
        }

        /// <inheritdoc />
        public MissingMappingAction MissingMappingAction
        {
            get
            {
                return _innerAdapter.MissingMappingAction;
            }
            set
            {
                _innerAdapter.MissingMappingAction = value;
            }
        }

        /// <inheritdoc />
        public MissingSchemaAction MissingSchemaAction
        {
            get
            {
                return _innerAdapter.MissingSchemaAction;
            }
            set
            {
                _innerAdapter.MissingSchemaAction = value;
            }
        }

        /// <inheritdoc />
        public ITableMappingCollection TableMappings
        {
            get
            {
                return _innerAdapter.TableMappings;
            }
        }

        /// <inheritdoc />
        public DataTable FillSchema(DataTable dataTable, SchemaType schemaType)
        {
            return _innerAdapter.FillSchema(dataTable, schemaType);
        }

        /// <inheritdoc />
        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            return _innerAdapter.FillSchema(dataSet, schemaType);
        }

        /// <inheritdoc />
        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType, string srcTable)
        {
            return _innerAdapter.FillSchema(dataSet, schemaType, srcTable);
        }

        /// <inheritdoc />
        public int Fill(DataSet dataSet)
        {
            return _innerAdapter.Fill(dataSet);
        }

        /// <inheritdoc />
        public int Fill(DataSet dataSet, string srcTable)
        {
            return _innerAdapter.Fill(dataSet, srcTable);
        }

        /// <inheritdoc />
        public int Fill(DataSet dataSet, int startRecord, int maxRecords, string srcTable)
        {
            return _innerAdapter.Fill(dataSet, startRecord, maxRecords, srcTable);
        }

        /// <inheritdoc />
        public int Fill(DataTable dataTable)
        {
            return _innerAdapter.Fill(dataTable);
        }

        /// <inheritdoc />
        public int Fill(int startRecord, int maxRecords, params DataTable[] dataTables)
        {
            return _innerAdapter.Fill(startRecord, maxRecords, dataTables);
        }

        /// <inheritdoc />
        public IDataParameter[] GetFillParameters()
        {
            return _innerAdapter.GetFillParameters();
        }
    }
}
