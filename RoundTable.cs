using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1003_Knight
{
    class RoundTable<T> : IEnumerable<T> where T : IComparable<T>, INameable
    {
        private List<T> entities = new List<T>();

        public void Add(T newEntities)
        {            
            entities.Add(newEntities);
        }
        public void RemoveAt(int indexOfEntityToRemove)
        {
            entities.RemoveAt(indexOfEntityToRemove % entities.Count());
        }
        public void Clear()
        {
            entities.Clear();

        }
        public void InsertAt(int indexOfEntityToAdd, T entitie)
        {
            entities.Insert(indexOfEntityToAdd % entities.Count(), entitie);
        }
        public void Sort()
        {
            entities.Sort();
        }
        public List<T> GetRounded(int howMuchEntityToReturn)
        {
            List<T> entitiesWithGetRounded = new List<T>();
            for (int i = 0; i < howMuchEntityToReturn; i++)
            {
                    entitiesWithGetRounded.Add(entities[i % entities.Count]);
                Console.WriteLine(entitiesWithGetRounded[i]);
            }
            return entitiesWithGetRounded;
        }
        public T this[int x]
        {
            get
            {
                if (entities.Count == 0)
                    return default(T);
                return entities[x % entities.Count()];
            }
        }
        public T this[string s]
        {
            get
            {
                if (entities.Count == 0)
                    return default(T);
                foreach (T entity in entities)
                {
                    if (entity.Name == s)
                        return entity;
                }
                return default(T);
            }
        }
        public override string ToString()
        {
            string result = $"In My Round Table Have {entities.Count} entities!\n";
            foreach (T entitie in entities)
            {
                result += entitie + "\n";
            }
            return result;
        }



        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

    }
}
