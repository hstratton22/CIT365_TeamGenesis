namespace MegaDesk_TeamGenesis
{
    /// <summary>
    /// desk class 
    /// get;set;
    /// and methods
    /// </summary>
    public class Desk
    {
        private const int MinWidth = 24;
        private const int MaxWidth = 96;
        private const int MinDepth = 12;
        private const int MaxDepth = 48;

        private int _width;
        private int _depth;
        public DesktopMaterial desktopMaterial { get; set; }
        public int GetMinWidth() { return MinWidth; }
        public int GetMaxWidth() { return MaxWidth; }
        public int GetMinDepth() { return MinDepth; }
        public int GetMaxDepth() { return MaxDepth; }
        public int Width
        {
            get { return _width; }
            set
            {
                if (ValidatedWidth(value))
                {
                    _width = value;
                }
            }
        }
        public int Depth
        {
            get { return _depth; }
            set
            {
                if (ValidatedDepth(value))
                { _depth = value; }
            }
        }
        public int Area
        {
            get { return _width * _depth; }
        }
        public bool ValidatedWidth(int widthInput) { if (widthInput >= MinWidth && widthInput <= MaxWidth) return true; else return false; }

        public bool ValidatedDepth(int depthInput) { if (depthInput >= MinDepth && depthInput <= MaxDepth) return true; else return false; }

        public int DrawerCount { get; set; }


        /// <summary>
        /// override of ToString() for testing references
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Width: {0}, Depth: {1}, Material: {2}", Width, Depth, desktopMaterial);
        }





    }/// <summary>
     /// surface options enum
     /// </summary>
    public enum DesktopMaterial
    {
        Laminate, Oak, Pine, Rosewood, Veneer
    }
}
