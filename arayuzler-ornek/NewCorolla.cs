namespace arayuzler_ornek
{
    public class NewCorolla : Car
    {
        public override Owner GetOwner()
        {
            return Owner.Toyota;
        }
        public override Color GetRenk()
        {
            return Color.Sarı;
        }
    }
}