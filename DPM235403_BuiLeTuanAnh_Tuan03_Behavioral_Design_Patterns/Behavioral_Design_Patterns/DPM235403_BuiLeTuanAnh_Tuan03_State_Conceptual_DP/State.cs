namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Conceptual_DP
{
    abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();
        public abstract void Handle2();
    }
}