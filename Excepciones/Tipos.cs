namespace MobilityScm.Verticial.Excepciones
{
    public enum ExceptionType
    {
        /// <summary>
        /// An uncategorized exception.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Data is invalid (string or number overflow, or datatype conversion, or (MySql) foreign key constraint)
        /// </summary>
        InvalidData,
        /// <summary>
        /// String is too long for column.
        /// </summary>
        StringTooLong,
        /// <summary>
        /// Number is invalid for column definition
        /// </summary>
        InvalidNumber,
        /// <summary>
        /// Null value not allowed in non-null column.
        /// </summary>
        Null,
        /// <summary>
        /// Duplicate value violates unique (or primary key) constraint
        /// </summary>
        UniqueConstraint,
        /// <summary>
        /// Value violates foreign key constraint
        /// </summary>
        ForeignKey,
        /// <summary>
        /// A locking error occurred
        /// </summary>
        LockFailed,
        /// <summary>
        /// Too many rows were found in sub-query.
        /// </summary>
        TooManyRows,
        /// <summary>
        /// No data was found in sub-query.
        /// </summary>
        NoDataFound,
        /// <summary>
        /// Cannot access the database.
        /// </summary>
        DatabaseNotAccessible,
        /// <summary>
        /// A custom (RAISERROR) error occurred.
        /// </summary>
        ServerNotFound,
        /// <summary>
        /// The server was not found or was not accessible.
        /// </summary>
        CustomException
    }
}