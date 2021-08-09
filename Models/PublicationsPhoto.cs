using System;
using System.Collections.Generic;

#nullable disable

namespace Back_end.Models
{
    public partial class PublicationsPhoto
    {
        public int PhotoId { get; set; }
        public int? PublicationId { get; set; }
        public bool? PhotoDeleted { get; set; }

        public virtual Publication Publication { get; set; }
    }
}
