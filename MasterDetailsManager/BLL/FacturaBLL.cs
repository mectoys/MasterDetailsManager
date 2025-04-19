using DAL;         // Importa la capa de acceso a datos
using Models;      // Importa los modelos de datos
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    /// <summary>
    /// Capa de lógica de negocio para manejar operaciones relacionadas a la factura.
    /// Esta clase sirve como intermediario entre la capa UI y la capa DAL (Data Access Layer).
    /// </summary>
    public class FacturaBLL
    {
        // Instancia del repositorio que se encarga de la interacción con la base de datos
        private readonly FacturaRepository _facturaRepository = new FacturaRepository();

        /// <summary>
        /// Retorna un conjunto de facturas activas desde la base de datos.
        /// Este método es útil para llenar una grilla con los encabezados de facturas.
        /// </summary>
        public DataSet ObtenerFactura()
        {
            string query = "select Id,Cliente,Fecha from factura where state=1";
            return _facturaRepository.ExecuteQuery(query);
        }

        /// <summary>
        /// Obtiene el detalle de una factura específica por su ID.
        /// Ideal para cargar los productos o ítems relacionados a la factura seleccionada.
        /// </summary>
        public List<FacturaDetalle> ObtenerDetalleFactura(int facturaId)
        {
            return _facturaRepository.ObtenerDetalleporFactura(facturaId);
        }

        /// <summary>
        /// Crea una nueva factura junto con sus detalles.
        /// Valida que se esté enviando una factura con al menos un ítem antes de procesar.
        /// </summary>
        public int CrearFactura(Factura factura)
        {
            if (factura == null || factura.Detalles == null || factura.Detalles.Count == 0)
                throw new ArgumentException("La factura o sus detalles no son válidos.");

            // Llamada al método transaccional que inserta la factura y sus detalles
            return factura.Id = _facturaRepository.InsertarFacturaConDetalles(factura, factura.Detalles);
        }

        /// <summary>
        /// Actualiza una factura existente junto con los cambios en sus detalles.
        /// Se identifican los ítems nuevos, actualizados y eliminados para aplicar una transacción completa.
        /// </summary>
        public void ActualizarFactura(Factura factura)
        {
            if (factura == null || factura.Detalles == null)
                throw new ArgumentException("La factura o sus detalles no son válidos.");

            // Se obtiene el detalle actual de la base de datos
            var detallesExistentes = _facturaRepository.ObtenerDetalleporFactura(factura.Id);

            // Detectar nuevos ítems (que no tienen ID asignado)
            var nuevosDetalles = factura.Detalles.FindAll(d => d.Id == 0);

            // Detectar ítems actualizados (ya tienen ID)
            var detallesActualizados = factura.Detalles.FindAll(d => d.Id != 0);

            // Detectar ítems eliminados (ya no están en la nueva lista)
            var detallesAEliminar = detallesExistentes.FindAll(e => !factura.Detalles.Exists(d => d.Id == e.Id));

            // Ejecuta una transacción para actualizar todos los cambios de manera atómica
            _facturaRepository.ActualizarFacturaConDetalles(factura, nuevosDetalles, detallesActualizados, detallesAEliminar);
        }

        /// <summary>
        /// Anula una factura existente. Generalmente se actualiza el estado a "anulado".
        /// </summary>
        public void AnularFactura(Factura factura)
        {
            _facturaRepository.AnularFactura(factura);
        }
    }
}
