using System;
using Plotter.Items.DataItems.HistaSet;

namespace Plotter.Items.GraphicItems
{
    internal class Histogram : IGraph
    {
        private readonly HistagramData _data;

        public Histogram(HistagramData data)
        {
            _data = data;
        }

        public void Plot()
        {
            throw new NotImplementedException();
        }
    }
}
