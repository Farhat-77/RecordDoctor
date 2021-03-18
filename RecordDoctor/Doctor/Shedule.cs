using System;
using System.Collections.Generic;
using System.Text;

namespace RecordDoctor.Doctor
{
    public class Shedule
    {
        private string[] _data;

        public DateTime? CreationDate { get; set; }
        public string InternalValues { get; set; }
        public string[] Values
        {
            get => InternalValues(';');
            set
            {
                _data = Values;
                InternalValues = string.(";", _data);
            }
        }

        private string[] InternalValues(char v)
        {
            throw new NotImplementedException();
        }
    }
}
