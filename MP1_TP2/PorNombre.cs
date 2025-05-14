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
	/// Description of PorNombre.
	/// </summary>
	public class PorNombre : StrategyAlumno
	{
		public PorNombre()
		{
		}
		
		public void comparar(Alumno alu, Alumno blu)
		{
			if(alu.getNombre == blu.getNombre){
				
				Console.WriteLine("Los Nombres son IGUALES");
			}else{
				Console.WriteLine("Los Nombres Son DIFERENTES");
			}
		}
	}
}
