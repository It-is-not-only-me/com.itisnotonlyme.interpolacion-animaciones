using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItIsNotOnlyMe.Tweening
{
    public class TweenConcurrentes : AdministrarTweens
    {
        private List<ITween> _tweens;

        public TweenConcurrentes(List<ITween> tweens = null)
        {
            _tweens = tweens == null ? new List<ITween>() : tweens;
        }

        public override AdministrarTweens AgregarTween(ITween tween)
        {
            _tweens.Add(tween);
            return this;
        }

        public override async Task DoTween()
        {
            int cantidadTweens = _tweens.Count;

            Task[] tareas = new Task[cantidadTweens];
            for (int i = 0; i < cantidadTweens; i++)
                tareas[i] = _tweens[i].DoTween();

             await Task.WhenAll(tareas);
        }

        public override void Clear() => _tweens.Clear();
    }
}
