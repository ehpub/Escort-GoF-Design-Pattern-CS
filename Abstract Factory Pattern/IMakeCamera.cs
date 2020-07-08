
namespace 추상_팩토리_패턴
{
    interface IMakeCamera
    {
        ITake MakeLens();
        Camera MakeCamera();
    }
}
