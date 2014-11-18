using System;

namespace Kalkulator1.AdditionalClass
{
    internal class AttendanceOBWItem
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public long ListWyborcza { get; private set; }
        
        public AttendanceOBWItem(int id, string name, long lwyb)
        {
            Id = id;
            Name = name;
            ListWyborcza = lwyb;
        }
    }
}
