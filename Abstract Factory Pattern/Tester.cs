using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상_팩토리_패턴
{
    class Tester
    {
        IMakeCamera[] factories = new IMakeCamera[2];
        public Tester()
        {
            factories[0] = new EvDayFactory();
            factories[1] = new HoDayFactory();
        }
        public void Test()
        {
            TestDirect();
            TestUsingFactory();
        }

        private void TestUsingFactory()
        {
            Camera camera = null;
            ITake lens = null;
            Console.WriteLine("추상 팩토리 패턴 적용====");
            foreach(IMakeCamera imake in factories)
            {
                camera = imake.MakeCamera();
                lens = imake.MakeLens();
                TestCase(camera, lens);
            }
        }

        private void TestDirect()
        {
            Console.WriteLine("직접 사용====");
            Camera camera = new EvCamera();
            ITake lens = new HoLens();
            TestCase(camera, lens);
        }

        private void TestCase(Camera camera, ITake lens)
        {
            if(camera.PutInLens(lens)==false)
            {
                Console.WriteLine("장착 실패");
                return;
            }
            if(camera.TakePicture() == false)
            {
                Console.WriteLine("사진이 찍히지 않았습니다.");
                return;
            }
            Console.WriteLine("테스트 성공!!!");
        }
    }
}
