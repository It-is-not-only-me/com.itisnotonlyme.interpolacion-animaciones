using System.Collections;

namespace ItIsNotOnlyMe.Tweening
{
    public interface IReloj
    {
        public IEnumerable Tiempo();

        public float NormalizarTiempo(float tiempo);
    }
}
