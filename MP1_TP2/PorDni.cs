/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 26/4/2025
 * Hora: 15:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MP1_TP2
{
	/// <summary>
	/// Description of PorDni.
	/// </summary>
	public class PorDni : StrategyAlumno
	{
		public PorDni()
		{
		}
		
		public void comparar(Alumno alu, Alumno blu)
		{
			if(blu.getDni > alu.getDni){
				Console.WriteLine("Legajo de {0} es mayor que Legajo {1} ",blu.getNombre ,alu.getDni);
				return;
				}
			if(blu.getDni < alu.getDni){
				Console.WriteLine("Legajo de {0} es menor que Legajo {1} ",blu.getNombre ,alu.getDni);
				return;
				}
			Console.WriteLine("Los DNI son iguales !!");return;
		}
	}
}
