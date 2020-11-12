using System;
using System.Dynamic;
using System.Text.Json;

namespace November11thJsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            var location = new Location
            {
                StreetAddress = "1234 ez street",
                City = "MakeBelieveApolois",
                State = "HU",
                Zip = 12345,
                PhoneNumber = "313-113-1114"

            };
            var hotel = new Hotel()
            {
                Name = "awesomesauce hotel",
                Location = location,
                Rating = 5,
                Pool = true,
                Gym = true,
                Bar = true,
                PetFriendly = true,
                Restaurant = false
            };

            //this is what the api sends over the network look at part controller in the api
            var jsonAsUtfBytes = JsonSerializer.SerializeToUtf8Bytes(hotel, options);

            //when we call the api and read the httpresponse.content we read it as a string
                //which converts from utf8bytes to string
            var jsonString = JsonSerializer.Serialize(hotel, options);

            //we then parse that string to our model so we can interact with it as an object once again
            var hotelReturned = JsonSerializer.Deserialize<Hotel>(jsonString, options);
            
        }
    }

    public class Hotel
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        public int Rating { get; set; }
        public bool Pool { get; set; }
        public bool Gym { get; set; }
        public bool Bar { get; set; }
        public bool PetFriendly { get; set; }
        public bool Restaurant { get; set; }
    }

    public class Location
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
    }
}
