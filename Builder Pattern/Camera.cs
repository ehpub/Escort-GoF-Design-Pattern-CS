using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 빌더_패턴
{
    class Camera
    {
        PictureBuilder[] builders = new PictureBuilder[2];
        public Picture MyPicture
        {
            get;
            private set;
        }
        public Camera()
        {
            builders[0] = new REPreventBuilder();
            builders[1] = new SmoothBuilder();
            MyPicture = Picture.EmptyPicture;
        }

        public void PressAShutter(string origin, bool night)
        {
            PictureBuilder pb = null;
            if(night)
            {
                pb = builders[0];
            }
            else
            {
                pb = builders[1];
            }
            pb.SetSubject(origin);
            pb.Change();
            MyPicture = pb.Picture;
        }
    }
}
