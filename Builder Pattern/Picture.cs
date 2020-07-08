using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 빌더_패턴
{
    class Picture
    {
        public static readonly Picture EmptyPicture;
        public string Subject
        {
            get;
            private set;
        }
        public string Image
        {
            get;
            private set;
        }
        static Picture()
        {
            EmptyPicture = new Picture(string.Empty, string.Empty);
        }
        public Picture(string subject, string image)
        {
            Subject = subject;
            Image = image;
        }
    }
}
