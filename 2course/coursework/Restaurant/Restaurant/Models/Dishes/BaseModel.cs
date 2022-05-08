using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class BaseModel : IEquatable<BaseModel>
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }

        public BaseModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void ChangeName(string newName)
        {
            if(newName != "")
                Name = newName;
        }


        public bool Equals(BaseModel? other)
        {
            if (other == null)
                return false;

            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
