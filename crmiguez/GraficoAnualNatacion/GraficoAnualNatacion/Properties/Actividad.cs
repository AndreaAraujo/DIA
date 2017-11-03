using System;
namespace GraficoAnualNatacion
{
	public class Actividad
	{
		public Actividad()
		{
		    this.DiaActividad = DateTime.Now;
			this.Tiempo = TimeSpan.MaxValue;
		}

		public Actividad(TimeSpan time, long dist, String notsAct, DateTime diaAct) {
			this.Tiempo = time;
			this.Distancia = dist;
			this.NotasActividad = notsAct;
			this.DiaActividad = diaAct;
		}

		public TimeSpan Tiempo {
			get {
				return this.tiempoActividad;
			}
			private set {
				this.tiempoActividad = value;
			}
		}

		public long Distancia {
			get {
				return this.distancia;
			}
			set {
				this.distancia = value;
			}
		}

		public String NotasActividad {
			get {
				return this.notasActividad;
			}
			set {
				this.notasActividad = value;
			}
		}

		public DateTime DiaActividad {
			get {
				return this.diaActividad;
			}
			set {
				this.diaActividad = value;
			}
		}

		private TimeSpan tiempoActividad;
		private long distancia;
		private String notasActividad;
		private DateTime diaActividad;
	}
}
