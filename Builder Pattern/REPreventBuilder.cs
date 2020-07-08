
namespace 빌더_패턴
{
    class REPreventBuilder:PictureBuilder
    {
        const string red_eye = "RedEye";
        const string normal_eye = "NomalEye";
        const int max_length = 20;
        string subject;
        public override void SetSubject(string subject)
        {
            if(subject.Length > max_length)
            {
                subject = subject.Substring(0, max_length);
            }
            this.subject = subject;
            Picture = new Picture(subject, subject);
        }
        public override void Change()
        {
            string image = subject.Replace(red_eye, normal_eye);
            Picture = new Picture(subject, image);
        }
    }
}
