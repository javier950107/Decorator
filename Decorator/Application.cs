using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            DataSourceDecorator decorator = new CompressionDecorator(
                    new EncryptionDecorator(
                        new FileDataSource("hello decorator!")));
            
            Console.WriteLine("Decorator Full => " + decorator.readData());

            decorator.writeData("hello decorator2");

            Console.WriteLine("Decorator Full => "+decorator.readData());

            Console.WriteLine("**** Only encrypt ****");
            DataSourceDecorator alone = new CompressionDecorator(new FileDataSource("Only compress"));
            Console.WriteLine("Encrypt => " + alone.readData());

            Console.WriteLine("**** Plain ****");

            DataSource plain = new FileDataSource("plain datasource");
            Console.WriteLine("Plain => " + plain.readData());
        }
    }
}
