
namespace 추상_팩토리_패턴
{
    class HoDayFactory : IMakeCamera
    {
        public Camera MakeCamera()
        {
            return new HoCamera();
        }

        public ITake MakeLens()
        {
            return new HoLens();
        }
    }
}
