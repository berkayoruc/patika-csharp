namespace arayuzler_ornek
{
    public abstract class Car
    {
        public int WheelCount()
        {
            return 4;
        }
        public virtual Color GetRenk()
        {
            return Color.Beyaz;
        }
        public abstract Owner GetOwner();
    }
}