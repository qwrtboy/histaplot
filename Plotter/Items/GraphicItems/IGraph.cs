namespace Plotter.GraphicItems
{
    public interface IGraph
    {
        /// <summary>
        /// Нарисовать себя.
        /// </summary>
        void Plot(string targetFileName);
    }
}
