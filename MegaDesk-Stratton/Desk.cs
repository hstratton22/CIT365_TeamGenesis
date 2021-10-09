using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stratton
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
        //private int _drawerCount;
        //private int _area;
        private DesktopMaterial _desktopMaterial;// = DesktopMaterial.Pine;

        public int GetMinWidth() { return MinWidth; }
        public int GetMaxWidth() { return MaxWidth; }
        public int GetMinDepth() { return MinDepth; }
        public int GetMaxDepth() { return MaxDepth; }
        public int Width {
            get { return _width; }
            set {
                if (ValidatedWidth(value))
                {
                    _width = value;
                }
            }
        }
        public int Depth { get { return _depth; }
            set
            {
                if (ValidatedDepth(value))
                { _depth = value; }
            } }
        public int Area
        {
            get { return _width * _depth;//_area; }
            //set
            //{
            //    _area = _width * _depth;

            }
        }
        public bool ValidatedWidth(int widthInput) { if (widthInput >= MinWidth && widthInput <= MaxWidth) return true; else return false; }

        public bool ValidatedDepth(int depthInput) { if (depthInput >= MinDepth && depthInput <= MaxDepth) return true; else return false; }
        
        public int DrawerCount { get; set; }


        //public DesktopMaterial DesktopMaterial
        //{
        //    get
        //    {
        //        return _desktopMaterial;
        //    }
        //    set
        //    {

        //        switch (value)
        //        {
        //            case 0: _desktopMaterial = DesktopMaterial.Laminate; break;

        //            case 1: _desktopMaterial = DesktopMaterial.Oak; break;
        //            case 2: _desktopMaterial = DesktopMaterial.Pine; break;
        //            case 3: _desktopMaterial = DesktopMaterial.Rosewood; break;
        //            case 4: _desktopMaterial = DesktopMaterial.Veneer; break;
        //            default: _desktopMaterial = DesktopMaterial.Pine; break;
        //        }

        //    }
        //}
        public DesktopMaterial GetDesktopMaterial() { return _desktopMaterial; }
        public void SetDesktopMaterial(DesktopMaterial sm)
        {
            _desktopMaterial = sm;

        }
        /// <summary>
        /// gets string from combobox selection and sets the value to the enum
        /// </summary>
        /// <param name="sm"></param>
        public void SetDesktopMaterial(string sm)
        {
            switch (sm)
            {
                case "Laminate": _desktopMaterial = DesktopMaterial.Laminate; break;
                case "Oak": _desktopMaterial = DesktopMaterial.Oak; break;
                case "Pine": _desktopMaterial = DesktopMaterial.Pine; break;
                case "Rosewood": _desktopMaterial = DesktopMaterial.Rosewood; break;
                case "Veneer": _desktopMaterial = DesktopMaterial.Veneer; break;
                default: _desktopMaterial = DesktopMaterial.Pine; break;
            }
        }
        /// <summary>
        /// override of ToString() for testing references
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString(); // + "width: " + width + "\n" + " depth: "+ depth;
        }




    
    }/// <summary>
    /// surface options enum
    /// </summary>
    public enum DesktopMaterial
    {
        Laminate, Oak, Pine, Rosewood, Veneer
    }
}
