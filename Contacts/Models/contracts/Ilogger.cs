using System;

namespace Contacts.Models.contracts
{
    public interface ILogger
    {
        void Error(object msg);

        void Error(object msg, Exception ex);

        void Error(Exception ex);

        void Info(object msg);
    }
}
