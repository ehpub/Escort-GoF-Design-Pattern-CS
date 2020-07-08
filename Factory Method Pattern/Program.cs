//http://ehpub.co.kr
//팩토리 메서드 패턴

namespace 팩토리_메서드_패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            app.InitInstance();
            app.Run();
            app.ExitInstance();
        }
    }
}
