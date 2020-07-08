using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상_팩토리_패턴
{
    class EvDayFactory : IMakeCamera
    {
        public Camera MakeCamera()
        {
            return new EvCamera();
        }

        public ITake MakeLens()
        {
            return new EvLens();
        }
    }
}
