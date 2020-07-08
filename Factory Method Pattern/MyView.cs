using System;

namespace 팩토리_메서드_패턴
{
    class MyView : IView
    {
        public MyView()
        {
            Console.WriteLine("MyView 개체 생성");
        }
        public void Show()
        {
            Console.WriteLine("메인 뷰 활성화");
        }
    }
}
