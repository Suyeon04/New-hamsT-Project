namespace newProject
{
    internal class Singleton
    {
        private static Singleton instance = null;
        public Singleton()
        {
        }

        public static Singleton getInstance()
        {
            if(Singleton.instance == null)
            {
                instance = new Singleton(); 
            }
            return instance;
        }
    }
}