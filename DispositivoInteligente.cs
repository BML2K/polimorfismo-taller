using System;
using System.Collections.Generic;

namespace polimorfismo_taller
{
    // Clase Base Abstracta
    public abstract class DispositivoInteligente
    {
        protected string IdDispositivo;
        protected string Ubicacion;
        protected bool Encendido;

        public DispositivoInteligente(string idDispositivo, string ubicacion)
        {
            IdDispositivo = idDispositivo;
            Ubicacion = ubicacion;
            Encendido = false;
        }

        public void CambiarEstado(bool estado)
        {
            Encendido = estado;
        }

        // Método virtual para polimorfismo en el consumo
        public virtual double CalcularConsumoEnergia()
        {
            if (Encendido)
            {
                return 10.0;
            }
            else
            {
                return 0.0;
            }
        }

        // Método virtual para polimorfismo en la visualización del estado
        public virtual void MostrarEstado()
        {
            string estadoTexto;
            if (Encendido)
            {
                estadoTexto = "Encendido";
            }
            else
            {
                estadoTexto = "Apagado";
            }
            Console.WriteLine("ID: " + IdDispositivo + " | Ubicación: " + Ubicacion + " | Estado: " + estadoTexto);
        }
    }
