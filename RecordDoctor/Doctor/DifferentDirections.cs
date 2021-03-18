using CsQuery;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecordDoctor.Doctor
{
    public class DifferentDirections
    {
        public Guid DocTypeId { get; set; }
        public virtual DocType DocType { get; set; }
        public string Name { get; set; }
        public Guid UserId {get;set;} 
        public virtual ICollection<DocPropertyValue> PropertyValues { get; set; }
        public virtual ICollection<JobPropertyValues> JobPropertyValues { get; set; }
        public string Discription { get; set; }
    }
}
