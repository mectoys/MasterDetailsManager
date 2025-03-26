using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class FacturaBLL
    {
        private readonly FacturaRepository _facturaRepository = new FacturaRepository();

        public DataSet ObtenerFactura()
        {
            string query = "select Id,Cliente,Fecha from factura where state=1";
            return _facturaRepository.ExecuteQuery(query);
        }

        public List<FacturaDetalle> ObtenerDetalleFactura(int facturaId)
        {
            return _facturaRepository.ObtenerDetalleporFactura(facturaId);
        }

        public int CrearFactura(Factura factura)
        {
            if (factura == null || factura.Detalles == null || factura.Detalles.Count == 0)
                throw new ArgumentException("La factura o sus detalles no son válidos.");

            // Llamar al método transaccional desde el repositorio
            _facturaRepository.InsertarFacturaConDetalles(factura, factura.Detalles);

            // Retornar el ID de la factura creada
            return factura.Id; // Asume que `Id` se asigna dentro del método InsertarFacturaConDetalles
        }

        public void ActualizarFactura(Factura factura)
        {
            if (factura == null || factura.Detalles == null)
                throw new ArgumentException("La factura o sus detalles no son válidos.");

            // Obtener el detalle actual desde la base de datos
            var detallesExistentes = _facturaRepository.ObtenerDetalleporFactura(factura.Id);

            // Identificar detalles a agregar
            var nuevosDetalles = factura.Detalles.FindAll(d => d.Id == 0);

            // Identificar detalles a actualizar
            var detallesActualizados = factura.Detalles.FindAll(d => d.Id != 0);

            // Identificar detalles a eliminar
            var detallesAEliminar = detallesExistentes.FindAll(e => !factura.Detalles.Exists(d => d.Id == e.Id));

            // Transacción para manejar todos los cambios
            _facturaRepository.ActualizarFacturaConDetalles(factura, nuevosDetalles, detallesActualizados, detallesAEliminar);
        }
        public void AnularFactura(Factura factura)
        {
            _facturaRepository.AnularFactura(factura);

        }

    }
}
