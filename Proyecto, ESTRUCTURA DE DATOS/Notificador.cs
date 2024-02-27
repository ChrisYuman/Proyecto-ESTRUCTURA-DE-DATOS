using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public static class Notificador
    {
        // Delegado para manejar las notificaciones
        public delegate void NotificacionEventHandler(string mensaje);

        // Evento para notificar a los usuarios
        public static event NotificacionEventHandler Notificacion;

        // Método para informar niveles críticos de inventario
        public static void InformarNivelCritico(string nombreProducto, int cantidadDisponible)
        {
            // Lógica para construir el mensaje de notificación
            string mensaje = $"Nivel crítico de inventario para {nombreProducto}. Cantidad disponible: {cantidadDisponible}";

            // Disparar el evento de notificación
            Notificacion?.Invoke(mensaje);
        }
    }
}
