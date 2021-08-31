using Demo.Domain.Common;
using System.Collections.Generic;

namespace Demo.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int CityId { get; set; }
        public int UserId { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public City City { get; set; }
        public User Users { get; set; }

    }
}
