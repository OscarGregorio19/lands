namespace lands.Infrastructure
{
    using ViewModels;

    public class IntanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public IntanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
