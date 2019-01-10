using System;
using System.Linq;

namespace StreamerNotifications.Extensions {

    public static class EnumExtensions {

        /// <summary>
        /// Get the custom attribute for/from the associated enum.
        /// </summary>
        /// <remarks>https://codereview.stackexchange.com/a/5354</remarks>
        public static CustomAttribute GetAttribute<CustomAttribute>(this Enum value) where CustomAttribute : Attribute {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            return type.GetField(name).GetCustomAttributes(false).OfType<CustomAttribute>().SingleOrDefault();
        }

    }

}
