
using System.Collections.Generic;
using System.Data;
using appPlanillas_4tose.bean;

namespace appPlanillas_4tose.dao
{
    internal class CentroCostoDAO
    {
        db.Db db = new db.Db("cnplanillas");
        public DataTable getCentroCostos() 
        {
            db.Sentencia("sp_getCentroCostos");
            return db.getDataTable();
        }
        public bool Guardar(CentroCosto centroCosto) 
        {
            //db.Sentencia(string.Format("sp_GuardarCentroCosto {0},'{1}'", centroCosto.id, centroCosto.Detalle));
            db.Sentencia( "sp_GuardarCentroCosto" );
            db.Parametros(centroCosto.getColumnas() );
            return db.Ejecutar() > 0;
           
        }


    }
}
