using System;
using System.Collections.Generic;

namespace GraficoAnualNatacion
{
	public class DiarioEntrenamiento
	{
		public DiarioEntrenamiento(String nombreEntr)
		{
			this.DiaEntreno = DateTime.Now;
            this.NombreEntrenamiento = nombreEntr;
			this.Actividades = new List<Actividad>();
			this.Medidas = new List<Medidas>();
		}

		public DiarioEntrenamiento(DateTime diaEntrenar, String nombreEntr, 
		                           List<Actividad> listact, List<Medidas> listmeds) {
            this.DiaEntreno = diaEntrenar;
            this.NombreEntrenamiento = nombreEntr;
			this.Actividades = listact;
			this.Medidas = listmeds;
		}

		public DateTime DiaEntreno {
			get {
				return this.diaEntrenar;
			}
			private set {
				this.diaEntrenar = value;
			}
		}

		public String NombreEntrenamiento {
			get {
				return this.nombreEntrenamiento;
			}
			set {
				this.nombreEntrenamiento = value;
			}
		}

		public List<Actividad> Actividades {
			get {
				return this.listaActividades;
			}
			set {
				this.listaActividades = value;
			}
		}

		public List<Medidas> Medidas
		{
			get
			{
				return this.listaMedidas;
			}
			set
			{
				this.listaMedidas = value;
			}
		}

		public Actividad GetActividad(int i)
		{
			return this.listaActividades[i];]
		}

		public Medidas GetMedidas(int i)
		{
			return this.listaMedidas[i];]
		}

		public void AnadirActividad(Actividad activ) {
			this.listaActividades.Add(activ);
		}

		public void AnadirMedidas(Medidas meds) {
            this.listaMedidas.Add(meds);
		}


		private DateTime diaEntrenar;
		private String nombreEntrenamiento;
		private List<Actividad> listaActividades;
		private List<Medidas> listaMedidas;
	}
}
