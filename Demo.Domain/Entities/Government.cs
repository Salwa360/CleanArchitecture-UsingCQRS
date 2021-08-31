using Demo.Domain.Common;
using System.Collections.Generic;

namespace Demo.Domain.Entities
{
    public class Government: BaseEntity
    {
        public Government()
        {
            Cities = new List<City>();
        }
        public string GovName { get; set; }
        public List<City> Cities { get; set; }
    }
}
