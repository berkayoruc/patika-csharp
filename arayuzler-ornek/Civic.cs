namespace arayuzler_ornek
{
    public class Civic : ICar
    {
        public Color GetColor()
        {
            return Color.Beyaz;
        }

        public Owner GetOwner()
        {
            return Owner.Honda;
        }

        public int WheelCount()
        {
            return 4;
        }

    }
}