using System;

namespace SSHTunnelManager.Domain
{
    public class PuttyProfileProperty
    {
        public PuttyProfileProperty(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
        }

        public string Name { get; private set; }
        public object Value { get; set; }
        public PropertyType Type { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", Name, Value);
        }
    }
}