using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EncryptedMetadataAttribute : Attribute
    {
        public DbType DataType { get; }
        public int Size { get; }
        public EncryptedMetadataAttribute(DbType type, int size) { DataType = type; Size = size; }
    }

}
