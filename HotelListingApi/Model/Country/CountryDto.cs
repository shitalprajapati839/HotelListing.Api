using HotelListingApi.Model.Hotel;

namespace HotelListingApi.Model.Country
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }


        public List<HotelDto> Hotels { get; set; }
    }
    

    
}