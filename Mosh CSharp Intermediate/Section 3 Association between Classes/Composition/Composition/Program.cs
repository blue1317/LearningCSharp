using System;

namespace Composition
{
    public class Test
    {
        public int number { get; set; }

        public void age()
        {
            Console.WriteLine("Your age is a number");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
