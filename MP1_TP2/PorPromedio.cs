/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 26/4/2025
 * Hora: 17:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MP1_TP2
{
	/// <summary>
	/// Description of PorPromedio.
	/// </summary>
	public class PorPromedio : StrategyAlumno
	{
		public PorPromedio()
			
		{
		}
		
		public void comparar(Alumno alu, Alumno blu)
		{
			if(blu.getPromedio == alu.getPromedio){
				Console.WriteLine("Los promedios son iguales ");
				return;
			}
			
			if(blu.getPromedio < alu.getPromedio){
				Console.WriteLine("Promedio de {0} es mayor que {1} ",alu.getNombre ,blu.getNombre);
				return;
			}
			if(blu.getPromedio > alu.getPromedio){
				Console.WriteLine("Promedio de {0} es menor que {1} ",alu.getNombre,blu.getNombre);
				return;
			}
		}
	}
}
