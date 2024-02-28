using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public static class Notificador
    {
        public delegate void NotificacionEventHandler(string mensaje);

        // Evento para notificar a los usuarios
        public static event NotificacionEventHandler Notificacion;

        // Método para informar niveles críticos de inventario
        public static void InformarNivelCritico(string nombreProducto, int cantidadDisponible)
        {
            // Lógica para construir el mensaje de notificación
            string mensaje = $"Nivel crítico de inventario para {nombreProducto}. Cantidad disponible: {cantidadDisponible}";

            // Disparar el evento de notificación
            OnNotificacion(mensaje);
        }

        // Método para activar el evento Notificacion
        private static void OnNotificacion(string mensaje)
        {
            // Verificar que haya suscriptores al evento antes de invocarlo
            Notificacion?.Invoke(mensaje);
        }
    }
}
