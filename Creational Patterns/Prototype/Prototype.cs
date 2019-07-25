using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Samples.CreationalPatterns.Prototype
{
    [Serializable()]
    public abstract class Prototype<T>
    {
        //Shallow Copy
        public T Clone() {
            return (T)this.MemberwiseClone();
        }

        public T DeepCopy() {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }
    }
}
