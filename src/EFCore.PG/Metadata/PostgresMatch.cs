namespace Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

/// <summary>
///     Matching strategies for a multicolumn foreign key.
/// </summary>
/// <remarks>
///     <see href="https://www.postgresql.org/docs/current/sql-createtable.html#SQL-CREATETABLE-PARMS-REFERENCES"/>
/// </remarks>
public enum PostgresMatchType
{
    /// <summary>
    ///     The default matching strategy, allows any foreignkey column to be NULL.
    /// </summary>
    Simple = 0,
    /// <summary>
    ///     Currently not implemented in PostgreSQL.
    /// </summary>
    Partial = 1,
    /// <summary>
    ///     Requires the foreign key to either have all columns to be set or all columns to be NULL.
    /// </summary>
    Full = 2
}