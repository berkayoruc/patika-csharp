namespace arayuzler_ornek
{
    public class Focus : ICar
    {
        public Color GetColor()
        {
            return Color.Siyah;
        }

        public Owner GetOwner()
        {
            return Owner.Ford;
        }

        public int WheelCount()
        {
            return 4;
        }

    }
}