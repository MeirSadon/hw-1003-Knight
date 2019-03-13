using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1003_Knight
{
    class RoundTable<T> : IEnumerable<T>
    {
        private List<T> entities = new List<T>();

        public void Add(T newEntities)
        {            
            entities.Add(newEntities);
        }
        public void RemoveAt(int indexOfEntitiesToRemove)
        {
            if (indexOfEntitiesToRemove >= entities.Count())
                indexOfEntitiesToRemove = indexOfEntitiesToRemove % entities.Count();
            entities.RemoveAt(indexOfEntitiesToRemove);
        }
        public void Clear()
        {
            entities.Clear();

        }
        public void InsertAt(int indexOfEntitesToAdd, T entitie)
        {
            if (indexOfEntitesToAdd >= entities.Count)
                indexOfEntitesToAdd = indexOfEntitesToAdd % entities.Count;
            entities.Insert(indexOfEntitesToAdd, entitie);
        }
        public void Sort()
        {
            entities.Sort();
        }
        public List<T> GetRounded(int howMuchEntitiesToReturn)
        {
            List<T> entitiesWithGetRounded = new List<T>();
            for (int i = 0; i < howMuchEntitiesToReturn; i++)
            {
                if (i >= entities.Count)
                    entitiesWithGetRounded.Add(entities[i % entities.Count]);
                else
                    entitiesWithGetRounded.Add(entities[i]);
                Console.WriteLine(entitiesWithGetRounded[i]);
            }
            return entitiesWithGetRounded;
        }
        public T this[int x]
        {
            get
            {
                if (x >= entities.Count)
                {
                    x = x % entities.Count;
                    return entities[x];
                }
                return entities[x];
            }
        }
        //public T this[string s]
        //{
        //    get
        //    {
        //        for (int i = 0; i < entities.Count; i++)
        //        {
        //            if(s == entities[i].ToString())
        //                return entities[i];
        //        }
        //        return entities[0];
        //    }
        //}
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
