using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상_팩토리_패턴
{
    class EvCamera:Camera
    {
        public override bool PutInLens(ITake itake)
        {
            EvLens evlens = itake as EvLens;
            if(evlens == null)
            {
                return false;
            }
            Lens = itake;
            return true;
        }
        public override bool TakePicture()
        {
            EvLens evlens = Lens as EvLens;
            if(evlens == null)
            {
                return false;
            }
            evlens.AutoFocus();
            return base.TakePicture();
        }
    }
}
