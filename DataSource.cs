using CabloBackEnd.Models;

namespace CabloBackEnd
{
    public class DataSource
    {
        public static List<User> Users { get; set; } = new List<User>
            {
               new Admin("user1", "admin1", "Maxi","0000", Role.Admin),
               new Client("user2", "client1", "9999", Role.Client,"Super C",null,null,"spc@email","819-905-6750", new Adress("1456 Bell street", "Beloeil", "C9X 7J8", "Canada"), TypeClient.Company),
               new Client("user3", "client2", "1234", Role.Client,"Metro",null,null,"met@email","438-100-2366", new Adress("555 8th street", "Laval", "H0C 3F2", "Canada"), TypeClient.Company ),
               new Client("user4", "client3", "1234", Role.Client,"Hotel Deluxe",null,null,"deluxe@email","541-100-2370", new Adress("111 rue toupin", "Shawi", "A5F 3J7", "Canada"), TypeClient.Company),
               new Client("user5", "client4", "4444", Role.Client,"BOB","JUDE","1990-01-01","judeb@email","819-200-6541", new Adress("103 rue fagot", "LACHINE", "F4D 8Y6", "Canada"), TypeClient.Individual),
            };

        public static IEnumerable<User> GetUsers()
        {
            return Users; 
        }
        public static List<Client> GetClients() {
            Client c1 = new Client("user2", "client1", "9999", Role.Client, "Super C", null, null, "spc@email", "819-905-6750", new Adress("1456 Bell street", "Beloeil", "C9X 7J8", "Canada"), TypeClient.Company);
            c1.AddDecoder(new Decoder("127.0.10.1", "1234"));
            c1.AddDecoder(new Decoder("127.0.10.2", "1234"));

            Client c2 = new Client("user3", "client2", "1234", Role.Client, "Metro", null, null, "met@email", "438-100-2366", new Adress("555 8th street", "Laval", "H0C 3F2", "Canada"), TypeClient.Company);
            c2.AddDecoder(new Decoder("127.0.10.3", "1234"));
            c2.AddDecoder(new Decoder("127.0.10.4", "1234"));

            Client c3 = new Client("user4", "client3", "1234", Role.Client, "Hotel Deluxe", null, null, "deluxe@email", "541-100-2370", new Adress("111 rue toupin", "Shawi", "A5F 3J7", "Canada"), TypeClient.Company);
            c3.AddDecoder(new Decoder("127.0.10.5", "1234"));
            c3.AddDecoder(new Decoder("127.0.10.6", "1234"));

            Client c4 = new Client("user5", "client4", "4444", Role.Client, "BOB", "JUDE", "1990-01-01", "judeb@email", "819-200-6541", new Adress("103 rue fagot", "LACHINE", "F4D 8Y6", "Canada"), TypeClient.Individual);
            c4.AddDecoder(new Decoder("127.0.10.7", "1234"));
            c4.AddDecoder(new Decoder("127.0.10.8", "1234"));

            return new List<Client>
            {
               c1,
               c2,
               c3,
               c4
            };
        }

        public static List<Decoder> GetDecodeurs()
        {

            return new List<Decoder>
            {
                new Decoder("127.0.10.1", "1234"),
                new Decoder("127.0.10.2", "1234"),
                new Decoder("127.0.10.3", "1234"),
                new Decoder("127.0.10.4", "1234"),
                new Decoder("127.0.10.5", "1234"),
                new Decoder("127.0.10.6", "1234"),
                new Decoder("127.0.10.7", "1234"),
                new Decoder("127.0.10.8", "1234")
            };
        }
    }
}
