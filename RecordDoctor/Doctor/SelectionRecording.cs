using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RecordDoctor.Doctor
{
    public class SelectionRecording
    {
        public virtual DocPropertyValue Property { get; set; }
        public Guid PropertyId { get; set; }
        public string ValueName { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
