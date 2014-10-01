using System;
using System.Collections.Generic;
using System.Text;

namespace HP.Entidades
{
    public class Compra
    {
        private int id_compra;
        private Entidades.Proveedor prov;
        private int id_estado_compra;
        private string desc_estado_compra;
        private DateTime fecha_pedido;
        private Nullable<DateTime> fecha_entregado;
        private Nullable<DateTime> fecha_cancelado;
        private Nullable<float> monto_compra;
        private Nullable<long> nro_cheque;
        private Nullable<DateTime> fecha_venc_cheque;
        private Nullable<float> monto_cheque;
        private string banco;
        private Entidades.Lineas_Pedido lineas_pedido;
        private Entidades.Notas_Credito notas_credito;

        public int Id_Compra
        {
            get { return id_compra; }
            set { id_compra = value; }
        }

        public Entidades.Proveedor Prov
        {
            get { return prov; }
            set { prov = value; }
        }

        public int Id_Estado_Compra
        {
            get { return id_estado_compra; }
            set { id_estado_compra = value; }
        }

        public string Desc_Estado_Compra
        {
            get { return desc_estado_compra; }
            set { desc_estado_compra = value; }
        }

        public DateTime Fecha_Pedido
        {
            get { return fecha_pedido; }
            set { fecha_pedido = value; }
        }

        public Nullable<DateTime> Fecha_Entregado
        {
            get { return fecha_entregado; }
            set { fecha_entregado = value; }
        }

        public Nullable<DateTime> Fecha_Cancelado
        {
            get { return fecha_cancelado; }
            set { fecha_cancelado = value; }
        }

        public Nullable<float> Monto_Compra
        {
            get { return monto_compra; }
            set { monto_compra = value; }
        }

        public Nullable<long> Nro_Cheque
        {
            get { return nro_cheque; }
            set { nro_cheque = value; }
        }

        public Nullable<DateTime> Fecha_Venc_Cheque
        {
            get { return fecha_venc_cheque; }
            set { fecha_venc_cheque = value; }
        }

        public Nullable<float> Monto_Cheque
        {
            get { return monto_cheque; }
            set { monto_cheque = value; }
        }

        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        public Entidades.Lineas_Pedido Lineas_pedido
        {
            get { return lineas_pedido; }
            set { lineas_pedido = value; }
        }

        public Entidades.Notas_Credito Notas_Credito
        {
            get { return notas_credito; }
            set { notas_credito = value; }
        }
    }
}
