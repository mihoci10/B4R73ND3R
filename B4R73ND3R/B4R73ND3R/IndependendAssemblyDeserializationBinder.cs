using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Reflection;

namespace Extendix.ItemReceiver
{
    /// <summary>
    /// Allows the <see cref="System.Runtime.Serialization.Formatters.Binary.BinaryFormatter"/> to deserialize received objects from a class whose interface is not necessarily defined in the original assembly it was created from before sending.
    /// </summary>
    class IndependendAssemblyDeserializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            //load the type always from the current executing assembly
            Type deserializationType = Type.GetType(String.Format("{0}, {1}", typeName, Assembly.GetExecutingAssembly().FullName));
            
            return deserializationType;
        }
    }
}
