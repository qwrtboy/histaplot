using System;
using System.Collections.Generic;

namespace Plotter.Items.DataItems.HistaSet
{
    internal class Histagram
    {
        private IEnumerable<float> _elements;

        private Histagram(IEnumerable<float> elements)
        {
            _elements = elements;
        }

        /// <summary>
        /// Init histagram by data-seq.
        /// </summary>
        public static Histagram Init(IEnumerable<float> elements) => new Histagram(elements);

        /// <summary>
        /// Processing data-seq: calc basket contents.
        /// </summary>
        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
