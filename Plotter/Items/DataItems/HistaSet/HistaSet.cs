namespace Plotter.Items.DataItems.HistaSet
{
    /// <summary>
    /// TODO make abstract.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class HistaSet<TKey>
    {
        private readonly TKey _start;
        private readonly TKey _maximum;
        private readonly int _basketCount;

        private HistaSet(TKey start, TKey maximum, int basketCount)
        {
            _start = start;
            _maximum = maximum;
            _basketCount = basketCount;
        }

        internal static HistaSet<TKey> Init(TKey start, TKey maximum, int basketCount)
        {
            return new HistaSet<TKey>(start, maximum, basketCount);
        }

        internal virtual void Build() {}
    }
}
