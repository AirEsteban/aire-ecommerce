using System;
using System.Collections.Generic;

#nullable disable

namespace Back_end.Models
{
    public partial class Publication
    {
        public Publication()
        {
            PublicationsPhotos = new HashSet<PublicationsPhoto>();
        }

        public int PublicationId { get; set; }
        public string Publisher { get; set; }
        public string PubDescription { get; set; }
        public decimal? Price { get; set; }
        public bool? PubDeleted { get; set; }

        public virtual User PublisherNavigation { get; set; }
        public virtual ICollection<PublicationsPhoto> PublicationsPhotos { get; set; }
    }
}
