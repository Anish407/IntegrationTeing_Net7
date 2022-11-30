﻿namespace StudentManagement.Infra.Common.Exceptions
{
    public class DatabaseException : ExceptionBase
    {
        public DatabaseException(string message, string details)
            : base(message, details)
        {

        }
    }
}
