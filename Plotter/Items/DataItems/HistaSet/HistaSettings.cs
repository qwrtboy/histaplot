namespace Plotter.Items.DataItems.HistaSet
{
    /// <summary>
    /// Settings of histagram.
    /// </summary>
    internal class HistaSettings
    {
        /// <summary>
        /// Count of baskets.
        /// </summary>
        public int BasketCount { get; }

        /// <summary>
        /// Size of each basket.
        /// </summary>
        public float BasketDelta { get; }

        /// <summary>
        /// Position of front border of the first basket.
        /// </summary>
        public float DataStart { get; }

        public HistaSettings(int basketCount, float basketDelta, float dataStart)
        {
            BasketCount = basketCount;
            BasketDelta = basketDelta;
            DataStart = dataStart;
        }
    }
}
