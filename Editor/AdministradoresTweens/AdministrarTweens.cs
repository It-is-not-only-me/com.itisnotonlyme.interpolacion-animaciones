using System.Threading.Tasks;

namespace ItIsNotOnlyMe.Tweening
{
    public abstract class AdministrarTweens
    {
        public abstract AdministrarTweens AgregarTween(ITween tween);

        public virtual async Task DoTween()
        {
        }

        public abstract void Clear();
    }
}
