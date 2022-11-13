using System.Threading.Tasks;

namespace ItIsNotOnlyMe.Tweening
{
    public interface IAdministrarTweens
    {
        public void AgregarTween(ITween tween);

        public Task DoTween();
    }
}
