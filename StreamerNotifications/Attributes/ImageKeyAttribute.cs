using System;

namespace StreamerNotifications.Attributes {

    [AttributeUsage(AttributeTargets.Field)]
    public class ImageKeyAttribute : Attribute {

        public ImageKeyAttribute(string imageKey) => ImageKey = imageKey;

        public string ImageKey { get; }

    }

}
