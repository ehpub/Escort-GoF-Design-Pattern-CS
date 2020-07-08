namespace 팩토리_메서드_패턴
{
    abstract class EHApp
    {
        protected IView MainView
        {
            get;
            set;
        }
        public virtual void InitInstance()
        {
            MainView = MakeView();
        }
        public virtual void Run()
        {
            MainView.Show();
        }
        public virtual void ExitInstance()
        {
            MainView = null;
        }
        protected abstract IView MakeView();
    }
}
