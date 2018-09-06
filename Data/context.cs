using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace SimpleBot.Data
{
    public class context
    {

        private readonly MongoClient _context;
        public context()
        {
            _context = new MongoClient(ConfigurationManager.ConnectionStrings["conexaoMongoDB"].ConnectionString);



        }


        public void PostAsync(Message message)
        {
            _context.GetDatabase("13net");
            _context.ListDatabases();

        }

    }
}