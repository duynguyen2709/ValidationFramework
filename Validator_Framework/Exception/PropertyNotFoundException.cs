using System;

namespace Validation_Framework.CustomException
{
    [Serializable]
    public class PropertyNotFoundException : Exception
    {
        public PropertyNotFoundException()
        { }

        public PropertyNotFoundException(string propName)
            : base(String.Format("Propery {0} Not Found", propName))
        { }
    }
}
