using System;

namespace Kalkulator1.AdditionalClass
{
    internal class AttendanceItem
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public AttendanceItem(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
