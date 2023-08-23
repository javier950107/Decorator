using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class FileDataSource : DataSource
    {
        private string _name;

        public FileDataSource(string name)
        {
            this._name = name;
        }


        public string readData()
        {
            return this._name;
        }

        public void writeData(string data)
        {
            this._name = data;
            Console.WriteLine("Write data => " + this._name);
        }
    }
}
