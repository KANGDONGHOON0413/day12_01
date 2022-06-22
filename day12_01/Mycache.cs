using System;
using System.Collections.Generic;

namespace day12_01
{
    class Mycache
    {
        //Dictionary: key -> Value
        private Dictionary<string, string> cache; // key타입: str, val 타입: str
        public Mycache()
        {
            cache = new Dictionary<string, string>();
            //default cache value;
            cache.Add("Debug", "false");
            cache.Add("Logging", "true");
        }

        public void Add(string key, string val) //add
        {
            if (!cache.ContainsKey(key)) cache[key] = val;
            else throw new ApplicationException("key already exists");
        }



        //속성=매개변수를 가질 수 없다
        //예시
        private DateTime cacheExpires;
        public DateTime CacheExpires
        {
            get { return cacheExpires; }
            set { cacheExpires = value; }
        }
        //end 예시


        //인덱서를 이용한 경우 밑에와 같은 결과를 갖는다.
        public string this[string key]
        {
            get
            {
                if (cache.ContainsKey(key)) return cache[key];
                return null;
            }
            set
            {
                if (cache.ContainsKey(key)) cache[key] = value;
                else throw new ApplicationException("key not found");
            }
        }
        

        public string getItem(string key)   //get
        {
            if (cache.ContainsKey(key)) return cache[key];
            return null;
        }

        public void setItem(string key, string val) //update
        {
            if (cache.ContainsKey(key)) cache[key]= val;
            else throw new ApplicationException("key not found");
        }
    }
}
