using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상_팩토리_패턴
{
    class HoCamera:Camera
    {
        public override bool PutInLens(ITake itake)
        {
            HoLens holens = itake as HoLens;
            if(holens == null)
            {
                return false;
            }
            Lens = itake;
            return true;
        }
        public override bool TakePicture()
        {
            HoLens holens = Lens as HoLens;
            if(holens == null)
            {
                return false;
            }
            holens.ManualFocus();
            return base.TakePicture();
        }
    }
}
