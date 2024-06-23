using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Core.Types.Types
{
    public class Folders
    {
        public class Calender
        {
            public const string Default = "Default";

            public const string Weekly = "Weekly";
            public const string Monthly = "Monthly";
            public const string Annual = "Annual";
        }
        public class Registro
        {
            public const string Default = "Default";

            public const string Active = "Active";
            public const string Inactive = "Inactive";
            public const string Deleted = "Deleted";
        }

        public class Mail
        {
            public const string Default = "Default";

            public const string Inbox = "Inbox";
            public const string Outbox = "Outbox";
            public const string Draft = "Draft";
        }
    }
}
