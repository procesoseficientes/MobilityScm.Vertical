using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace MobilityScm.Verticial.Excepciones
{
    public static class ExceptionClassifier
    {
        public static ExceptionType Classify(this Exception exception)
        {
            var dbException = exception as DbException;
            if (dbException != null) return Classify(dbException);
            if (exception is System.Data.SqlTypes.SqlTypeException)
                return ExceptionType.InvalidData;
            return ExceptionType.Unknown;
        }

        private static string HumaReadMessage(string message)
        {
            return " ( " + message.Replace("'", "").Replace(Environment.NewLine, "") + ")";
            
        }


        public static string HumanReadMessage(this DbException exception)
        {
            switch (exception.Classify())
            {
                case ExceptionType.CustomException:
                    return HumaReadMessage(exception.Message);
                case ExceptionType.DatabaseNotAccessible:
                    return "La base de datos no es accesible";
                case ExceptionType.ForeignKey:
                    return "No se encontró un elemento relacionado o éste elemento está siendo utilizado" + HumaReadMessage(exception.Message);
                case ExceptionType.InvalidData:
                    return "La data ingresada no es valida";
                case ExceptionType.LockFailed:
                    return "Hay un registro bloqueado en la DB por ello no se pudo realizar la operacion";
                case ExceptionType.NoDataFound:
                    return "No se encontro el elemento " + HumaReadMessage(exception.Message);
                case ExceptionType.Null:
                    return HumaReadMessage(exception.Message);
                case ExceptionType.StringTooLong:
                    return "Una de las cadenas que trata de ingresar es demasiado larga";
                case ExceptionType.TooManyRows:
                    return HumaReadMessage(exception.Message);
                case ExceptionType.UniqueConstraint:
                    return "Ya existe un registro con el mismo identificador único " + HumaReadMessage(exception.Message);
                case ExceptionType.Unknown:
                    return HumaReadMessage(exception.Message);
                case ExceptionType.ServerNotFound:
                    return "El servidor no se encuentra o no es accesible";
            }

            return HumaReadMessage(exception.Message);
        }



        public static ExceptionType Classify(this DbException exception)
        {
            if (exception == null) return ExceptionType.Unknown;

            var sqlException = exception as SqlException;
            if (sqlException != null)
            {
                return LookupSqlException(sqlException);
            }

            //reflection works across
            //System.Data.OracleClient, Oracle.DataAccess.Client (ODP)
            //also DDTek.Oracle, Devart.Data.Oracle
            if (exception.GetType().Name.Equals("OracleException", StringComparison.OrdinalIgnoreCase))
            {
                var oracleCode = FindCode(exception);
                return LookupOracleException(oracleCode);
            }

            if (exception.GetType().Name.Equals("MySqlException", StringComparison.OrdinalIgnoreCase))
            {
                return LookupMySqlException(exception);
            }

            return ExceptionType.Unknown;
        }


        private static ExceptionType LookupSqlException(this SqlException sqlException)
        {
            switch (sqlException.Number)
            {

                case 5: //The server was not found or was not accessible.
                    return ExceptionType.ServerNotFound;
                case -1: //The server was not found or was not accessible.
                case 4060: //cannot open database requested by the login
                case 18456: //login failed for user
                    return ExceptionType.DatabaseNotAccessible;

                case 241: //Conversion failed when converting date and/or time from character string.
                    return ExceptionType.InvalidData;
                case 512:
                    return ExceptionType.TooManyRows;
                case 515:
                    return ExceptionType.Null;
                case 1205:
                    return ExceptionType.LockFailed;
                case 2627:
                case 2601:
                    return ExceptionType.UniqueConstraint;
                case 547:
                    return ExceptionType.ForeignKey;
                case 8152: //String or binary data would be truncated.
                    return ExceptionType.StringTooLong;
                case 8115: //Arithmetic overflow error converting numeric to data type numeric.
                    return ExceptionType.InvalidNumber;
                case 50000:
                    //all RAISERRORs with severity 10-20 will come here
                    return ExceptionType.CustomException;
                case 53:
                    return ExceptionType.DatabaseNotAccessible;
                default:
                    return ExceptionType.Unknown;
            }
        }

        private static ExceptionType LookupOracleException(int oracleCode)
        {
            switch (oracleCode)
            {
                case 1:
                    return ExceptionType.UniqueConstraint;
                case 54: //Resource busy and acquire with NOWAIT specified
                case 60: //deadlock detected while waiting for resource
                    return ExceptionType.LockFailed;
                case 1400:
                    return ExceptionType.Null;
                case 1403:
                    return ExceptionType.NoDataFound;
                case 1422:
                    return ExceptionType.TooManyRows;
                case 1438:
                    return ExceptionType.InvalidNumber;
                case 1861: //Literal does not match format string (TO_DATE)
                    return ExceptionType.InvalidData;
                case 2291:
                case 2292:
                    return ExceptionType.ForeignKey;

                case 1017: //invalid username/password; logon denied
                case 12203: //TNS: unable to connect to destination
                case 12224: //TNS: no listener
                case 12505: //TNS:listener does not currently know of SID given in connect descriptor
                case 12541: //TNS: no listener
                case 12545: //Connect failed because target host or object does not exist
                case 17002:
                    return ExceptionType.DatabaseNotAccessible;

                case 12899:
                    return ExceptionType.StringTooLong;
            }
            return ExceptionType.Unknown;
        }


        private static ExceptionType LookupMySqlException(DbException exception)
        {
            //http://dev.mysql.com/doc/refman/5.0/en/error-messages-server.html
            var code = FindCode(exception);
            switch (code)
            {
                case 1022: //Can't write; duplicate key in table
                case 1062: //Duplicate entry for key
                case 1169: //Can't write, because of unique constraint
                    return ExceptionType.UniqueConstraint;

                case 1044: //Access denied for user
                case 1045: //Access denied for user
                case 1046: //No database selected
                case 1049: //Unknown database
                    return ExceptionType.DatabaseNotAccessible;

                case 1048: //Column cannot be null
                case 1364: //Field doesn't have a default value
                    return ExceptionType.Null;

                case 1264: //Out of range value for column
                    return ExceptionType.InvalidNumber;

                case 1406: //Data too long for column
                    //could be InvalidNumberException - it's not distinguished
                    return ExceptionType.InvalidData;

                case 1217: //Cannot delete or update a parent row: a foreign key constraint fails
                case 1451: //Cannot delete or update a parent row: a foreign key constraint fails
                case 1452: //Cannot add or update a child row: a foreign key constraint fails
                    return ExceptionType.ForeignKey;

                case 1099: //Table was locked with a READ lock and can't be updated
                case 1205: //Lock wait timeout exceeded; try restarting transaction
                case 1213: //Deadlock found when trying to get lock; try restarting transaction
                    return ExceptionType.LockFailed;
                default:
                    return ExceptionType.Unknown;
            }
        }


        private static int FindCode(DbException ex)
        {
            var t = ex.GetType();
            var p = t.GetProperty("Code");
            if (p == null) p = t.GetProperty("Number");
            if (p == null) return 0;
            return (int)p.GetValue(ex, null);
        }


    }
}