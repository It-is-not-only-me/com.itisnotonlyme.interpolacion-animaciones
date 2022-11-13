using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItIsNotOnlyMe.Tweening
{
    public class TweenConcurrentes : IAdministrarTweens
    {
        private List<ITween> _tweens;

        public TweenConcurrentes(List<ITween> tweens = null)
        {
            _tweens = tweens == null ? new List<ITween>() : tweens;
        }

        public IAdministrarTweens AgregarTween(ITween tween)
        {
            _tweens.Add(tween);
            return this;
        }

        public Task DoTween()
        {
            int cantidadTweens = _tweens.Count;

            Task[] tareas = new Task[cantidadTweens];
            for (int i = 0; i < cantidadTweens; i++)
                tareas[i] = _tweens[i].DoTween();

            return Task.WhenAll(tareas);
        }
    }
}
