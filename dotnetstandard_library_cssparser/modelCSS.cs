using System;
using System.Collections.Generic;
using System.Text;

namespace cssParser
{
    public class modelCSS
    {

        public String? fileName;
        public List<PropertyName>? propertyName;

    }

    public class PropertyName
    {
        public String? Property;
        public List<String>? PropertyText;

        public PropertyName(String? property, List<String>? propertyText)
        {
            Property = property;
            PropertyText = propertyText;
        }
    }
}
