using System;
using System.Collections.Generic;

namespace Plotter.Items.DataItems.HistaSet
{
    internal class HistagramData
    {
        private IEnumerable<float> _elements;

        private HistagramData(IEnumerable<float> elements)
        {
            _elements = elements;
        }

        /// <summary>
        /// Init histagram by data-seq.
        /// </summary>
        public static HistagramData Init(IEnumerable<float> elements) => new HistagramData(elements);

        /// <summary>
        /// Processing data-seq: calc basket contents.
        /// </summary>
        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
