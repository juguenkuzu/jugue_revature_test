using System;
using System.Collections.Generic;
using System.Text;

namespace Mosali.Domaine.Entities
{
    public class ModelBase
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
