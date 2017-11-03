using System;
using System.Collections.Generic;

namespace GraficoAnualNatacion
{
	public class InformeAnual
	{
		public InformeAnual()
		{
			this.Entrenamientos = new List<DiarioEntrenamiento>();
		}

		public InformeAnual(List<DiarioEntrenamiento> entrenos)
		{
			this.Entrenamientos = entrenos;
		}

		public List<DiarioEntrenamiento> Entrenamientos {
			get {
				return this.entrenamientos;
			}
			set {
				this.entrenamientos = value;
			}
		}


		public DiarioEntrenamiento Get(int i)
		{
			return this.entrenamientos[i];
		}



		public int Count
		{
			get
			{
				return this.entrenamientos.Count;
			}
		}

		private List<DiarioEntrenamiento> entrenamientos;
	}
}
