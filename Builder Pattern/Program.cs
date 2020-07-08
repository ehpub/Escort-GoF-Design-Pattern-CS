//http://ehpub.co.kr
//소프트웨어 설계 C#
//5. 빌더 패턴(Builder Pattern) 구현 실습

using System;

namespace 빌더_패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera camera = new Camera();
            camera.PressAShutter("길 마당 RedEyeSharpBody 집 산", true);
            Console.WriteLine(camera.MyPicture.Image);
            camera.PressAShutter("길 마당 RedEyeSharpBody 집 산", false);
            Console.WriteLine(camera.MyPicture.Image);
        }
    }
}
