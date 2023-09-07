
namespace appPlanillas_4tose.bean
{
    internal class CentroCosto
    {
        #region Proppiedades
        public int id { get; set; }
        public string Detalle { get;set; }
        
        #endregion
        #region Metodos
        public CentroCosto() { }
        public CentroCosto(int id,string detalle) 
        {
            this.id = id;
            this.Detalle = detalle;
        }
        public void setRegistros(int id, string detalle) 
        {
            this.id = id;
            this.Detalle=detalle;
        }
        public object[] getColumnas() 
        {
            return new object[] { id, Detalle };
        }
        #endregion
    }
}
