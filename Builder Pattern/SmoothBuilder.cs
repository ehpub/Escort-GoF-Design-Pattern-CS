namespace 빌더_패턴
{
    class SmoothBuilder:PictureBuilder
    {
        const string sharp = "Sharp";
        const string smooth = "Smooth";
        string subject;
        public override void SetSubject(string subject)
        {
            this.subject = subject;
            Picture = new Picture(subject, subject);
        }
        public override void Change()
        {
            string image = subject.Replace(sharp, smooth);
            Picture = new Picture(subject, image);
        }
    }
}
