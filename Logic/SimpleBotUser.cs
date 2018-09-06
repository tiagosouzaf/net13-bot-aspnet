using MongoDB.Bson;
using MongoDB.Driver;
using SimpleBot.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SimpleBot
{
    public class SimpleBotUser
    {
        public static string Reply(Message message)
        {



            var cliente = new MongoClient(ConfigurationManager.ConnectionStrings["conexaoMongoDB"].ConnectionString);
            var dt = cliente.GetDatabase("dbTrabalho");
            var col = dt.GetCollection<Client>("trabalho");
            int num = Convert.ToInt16(GetProfile(message.Text).Id) + 1;

            col.InsertOne(new Client()
            {
                id = num,
                visitas =
            });

            GetProfile(message.Text);
            return $"{message.User} disse '{message.Text}'";
        }

        public static UserProfile GetProfile(string id)
        {
            var filtro = Builders<BsonDocument>.Filter.Gt("id", id);

            return null;
        }

        public static void SetProfile(string id, UserProfile profile)
        {
        }
    }
}