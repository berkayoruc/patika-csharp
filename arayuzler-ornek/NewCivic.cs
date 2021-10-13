namespace arayuzler_ornek
{
    public class NewCivic : Car
    {
        public override Owner GetOwner()
        {
            return Owner.Honda;
        }
        public override Color GetRenk()
        {
            return Color.Siyah;
        }
    }
}