using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1003_Knight
{
    class Magician : IComparable<Magician>, INameable
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public Magician(string name, string birthTown, string title)
        {
            Name = name;
            BirthTown = birthTown;
            Title = title;
        }

        public string this[string s]
        {
            get
            {
                if (s == "Name")
                    return Name;
                if (s == "BirthTown")
                    return BirthTown;
                if (s == "Title")
                    return Title;
                return "Unknown";
            }
            set { s = value; }
        }

        public override string ToString()
        {
            return $"Mgician Name: {Name}. Birth Town: {BirthTown}. Title: {Title}.";
        }

        public int CompareTo(Magician other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
