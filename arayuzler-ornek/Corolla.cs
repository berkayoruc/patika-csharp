namespace arayuzler_ornek
{
    public class Corolla : ICar
    {
        public Color GetColor()
        {
            return Color.Kırmızı;
        }

        public Owner GetOwner()
        {
            return Owner.Toyota;
        }

        public int WheelCount()
        {
            return 4;
        }

    }
}