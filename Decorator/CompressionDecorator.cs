using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource wrappee) : base(wrappee)
        {
        }

        public void writeData(string data)
        {
            base.writeData(data);
        }

        public string readData()
        {
            return base.readData();
        }
    }
}
