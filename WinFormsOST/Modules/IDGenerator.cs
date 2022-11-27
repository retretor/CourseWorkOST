namespace OST_Labs
{ 
    public class IdGenerator
    {
        private long _id;

        public long Id
        {
            get { return _id == long.MaxValue ? 0 : ++_id; }
        }

        public IdGenerator Clear()
        {
            _id = 0;
            return this;
        }
    }
}