using System;
namespace GraficoAnualNatacion
{
	public class Medidas
	{
		public Medidas(double pes, double circle, String notsMeds)
		{
			this.Peso = pes;
			this.Circunferencia = circle;
			this.NotasMedidas = notsMeds;
		}

		public double Peso {
			get {
				return this.peso;
			}
			set {
				this.peso = value;
			}
		}

		public double Circunferencia {
			get {
				return this.circunferencia;
			}
			set {
				this.circunferencia = value;
			}
		}

		public String NotasMedidas {
			get {
				return this.notasMedidas;
			}
			set {
				this.notasMedidas = value;
			}
		}

		private double peso;
		private double circunferencia;
		private String notasMedidas;
	}
}
