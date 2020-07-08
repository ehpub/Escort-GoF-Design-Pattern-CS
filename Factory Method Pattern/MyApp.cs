using System;

namespace 팩토리_메서드_패턴
{
    class MyApp:EHApp
    {
        protected override IView MakeView()
        {
            return new MyView();
        }
        public override void InitInstance()
        {
            Console.WriteLine("MyApp 초기화");
            base.InitInstance();
        }
        public override void ExitInstance()
        {
            base.ExitInstance();
            Console.WriteLine("MyApp 해제화");
        }
    }
}
