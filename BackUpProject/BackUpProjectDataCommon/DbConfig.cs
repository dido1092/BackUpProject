using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUpProject.BackUpProjectDataCommon
{
    public class DbConfig
    {
        public static string userName = Environment.UserName;

        //public static string ConnectionString =

        //$@"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\{userName}\source\repos\BackUpProject\DB\BackUpProject.mdf;Database=BackUpProject;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";
        public static string ConnectionString = $@"Server=(LocalDB)\MSSQLLocalDB;Database=BackUpProject;Trusted_Connection=True;Encrypt=False;";
        //@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=False;"
    }
}
