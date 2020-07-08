using System;

namespace 추상_팩토리_패턴
{
    class HoLens : ITake
    {
        public void Take()
        {
            Console.WriteLine("자연스럽다.");
        }
        public void ManualFocus()
        {
            Console.WriteLine("사용자 명령에 따라 초점을 조절한다.");
        }
    }
}
