using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DataSourceDecorator : DataSource
    {

        private DataSource _wrappee;

        public DataSourceDecorator(DataSource wrappee)
        {
            this._wrappee = wrappee;
        }

        public string readData()
        {
            return _wrappee.readData();
        }

        public void writeData(string data)
        {
            _wrappee.writeData(data);
        }
    }
}
