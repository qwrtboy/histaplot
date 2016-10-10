namespace Plotter.Items.GraphicItems
{
    public interface IGraph
    {
        /// <summary>
        /// Нарисовать себя.
        /// </summary>
        void Plot(string targetFileName);
    }
}
