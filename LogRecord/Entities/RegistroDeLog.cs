using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogRecord.Entities
{
    internal class RegistroDeLog
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is RegistroDeLog))
                {
                return false;
            }

            RegistroDeLog other = obj as RegistroDeLog;

            return Username.Equals(other.Username);
        }
    }
}
