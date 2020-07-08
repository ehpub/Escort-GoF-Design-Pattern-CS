using System;

namespace 추상_팩토리_패턴
{
    class EvLens : ITake
    {
        public void Take()
        {
            Console.WriteLine("부드럽게 찍힌다.");
        }
        public void AutoFocus()
        {
            Console.WriteLine("자동 초점 조절하다.");
        }
    }
}
