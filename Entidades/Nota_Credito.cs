using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Entidades
{
    public class Nota_Credito
    {
        private int id_nota_credito;
        private int codigo_nc;
        private DateTime fecha_emision;
        private float monto_total_nc;
        private float saldo_restante;
        private float monto_aplicado;
        
        public int Id_Nota_Credito
        {
            get { return id_nota_credito; }
            set { id_nota_credito = value; }
        }

        public int Codigo_Nc
        {
            get { return codigo_nc; }
            set { codigo_nc = value; }
        }

        public DateTime Fecha_Emision
        {
            get { return fecha_emision; }
            set { fecha_emision = value; }
        }

        public float Monto_Total_Nc
        {
            get { return monto_total_nc; }
            set { monto_total_nc = value; }
        }

        public float Saldo_Restante
        {
            get { return saldo_restante; }
            set { saldo_restante = value; }
        }

        public float Monto_Aplicado
        {
            get { return monto_aplicado; }
            set { monto_aplicado = value; }
        }
    }
}
