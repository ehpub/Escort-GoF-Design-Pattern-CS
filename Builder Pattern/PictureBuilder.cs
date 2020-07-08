namespace 빌더_패턴
{
    abstract class PictureBuilder
    {
        public Picture Picture
        {
            get;
            protected set;
        }
        public abstract void SetSubject(string subject);
        public abstract void Change();
    }
}
