/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 26/4/2025
 * Hora: 00:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MP1_TP2
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo :StrategyAlumno
	{
		
		public PorLegajo()
		{
		}
		
		public void comparar(Alumno alu, Alumno blu)
		{
			if(blu.getLegajo > alu.getLegajo){
				Console.WriteLine("Legajo de {0} es mayor que Legajo {1} ",blu.getNombre ,alu.getNombre);
				return;
			}
			if(blu.getLegajo < alu.getLegajo){
			Console.WriteLine("Legajo de {0} es menor que Legajo {1} ",blu.getNombre ,alu.getNombre);
			return;
			}
			
			Console.WriteLine("Legajos duplicados");return;
		}
	}
	
}

