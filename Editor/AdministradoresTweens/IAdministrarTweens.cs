using System.Threading.Tasks;

namespace ItIsNotOnlyMe.Tweening
{
    public interface IAdministrarTweens
    {
        public IAdministrarTweens AgregarTween(ITween tween);

        public Task DoTween();
    }
}
