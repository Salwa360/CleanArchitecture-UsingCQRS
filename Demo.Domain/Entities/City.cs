using Demo.Domain.Common;
using System.Collections.Generic;

namespace Demo.Domain.Entities
{
    public class City: BaseEntity
    {
        public City()
        {
            Addresses = new List<Address>();
        }
        public string CityName { get; set; }
        public int GovernmentId { get; set; }
        public List<Address> Addresses { get; set; }
        public Government Government { get; set; }
    }
}
