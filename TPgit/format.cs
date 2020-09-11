using System;
using System.Collections.Generic;
using System.Text;

namespace TPgit
{
    class format
    {
        #region attribut privés
        private string _typeOfFormat;
        private double _height;
        private double _width;
        private double _length;
        #endregion

        #region Accesseurs
        public string TypeOfFormat { get => _typeOfFormat; set => _typeOfFormat = value; }
        public double Height { get => _height; set => _height = value; }
        public double Width { get => _width; set => _width = value; }
        public double Length { get => _length; set => _length = value; } 
        #endregion

        public format(string typeOfFormat, double height, double width, double length)
        {
            _typeOfFormat="";
            _height = 0;
            _width = 0;
            _length = 0;
        }

        public double calculVolume()
        {
            double volumeFinal = 0;

            if (TypeOfFormat == "Sphere")
            {
                volumeFinal = 4 * Math.PI * Math.Pow(_width/2 , 3) / 3;
            }
            else
            {
                volumeFinal = _height * _length * _width;
            }
            return volumeFinal;
        }
    }
}
