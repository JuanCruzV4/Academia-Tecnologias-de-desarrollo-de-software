using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        #region Variables
        private string _Descripcion;
        private int _HSSemanales;
        private int _HSTotales;
        private int _IDPlan;
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int HSSemanales
        {
            get { return _HSSemanales; }
            set { _HSSemanales = value; }
        }

        public int HSTotales
        {
            get { return _HSTotales; }
            set { _HSTotales = value; }
        }

        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan = value; }
        }
        #endregion
    }
}