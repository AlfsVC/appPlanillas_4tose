
using System;
using appPlanillas_4tose.bean;

namespace appPlanillas_4tose.dao
{
    internal class EmpleadoDAO
    {
        db.Db db= new db.Db("cnplanillas");
        public bool Login (Empleado empleado) 
        {
            db.Sentencia(string.Format("sp_EmpleadoLogin '{0}','{1}'", empleado.Dni, empleado.Passwordd));
            empleado.setEmpleado(db.getDataRow() );
            return empleado.id > 0;
        }

        
    }
}
