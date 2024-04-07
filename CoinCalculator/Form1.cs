using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CoinCalculator {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			label25.Hide();
		}

		private void CalculateTotal() {
			decimal subtotalCincoventavos = Convert.ToDecimal(SubTotalCincoCentavos.Text);
			decimal subtotalDiezCentavos = Convert.ToDecimal(SubTotalDiezCentavos.Text);
			decimal subtotalVeinticincoCentavos = Convert.ToDecimal(SubTotalVeinticincoCentavos.Text);
			decimal subtotalCincuentaventavos = Convert.ToDecimal(SubTotalCincuentaCentavos.Text);
			decimal subtotalUnQuetzal = Convert.ToDecimal(SubTotalUnQuetzal.Text);
			decimal subtotalCincoQuetzales = Convert.ToDecimal(SubTotalCincoQuetzales.Text);
			decimal subtotalDiezQuetzales = Convert.ToDecimal(SubTotalDiezQuetzales.Text);
			decimal subtotalVeinteQuetzales = Convert.ToDecimal(SubTotalVeinteQuetzales.Text);
			decimal subtotalCincocuentaQuetzales = Convert.ToDecimal(SubTotalCincuentaQuetzales.Text);
			decimal subtotalCienQuetzales = Convert.ToDecimal(SubTotalCienQuetzales.Text);
			decimal subtotalDoscientosQuetzales = Convert.ToDecimal(SubTotalDoscientosQuetzales.Text);

			decimal total = (subtotalCincoventavos
				+ subtotalDiezCentavos
				+ subtotalVeinticincoCentavos
				+ subtotalCincuentaventavos
				+ subtotalUnQuetzal
				+ subtotalCincoQuetzales
				+ subtotalDiezQuetzales
				+ subtotalVeinteQuetzales
				+ subtotalCincocuentaQuetzales
				+ subtotalCienQuetzales
				+ subtotalDoscientosQuetzales);

			TotalTotal.Text = total.ToString();

		}

		private void Cantidad_CincoCentavos_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_CincoCentavos)) {
				int quantity = Convert.ToInt32(Cantidad_CincoCentavos.Text);
				SubTotalCincoCentavos.Text = Convert.ToString(String.Format("{0:F2}", quantity * 0.05));
				CalculateTotal();
			}
		}

		private void Cantidad_DiezCentavos_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_DiezCentavos)) {
				int quantity = Convert.ToInt32(Cantidad_DiezCentavos.Text);
				SubTotalDiezCentavos.Text = Convert.ToString(String.Format("{0:F2}", quantity * 0.1));
				CalculateTotal();
			}
		}

		private void Cantidad_VeintiCincoCentavos_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_VeintiCincoCentavos)) {
				int quantity = Convert.ToInt32(Cantidad_VeintiCincoCentavos.Text);
				SubTotalVeinticincoCentavos.Text = Convert.ToString(String.Format("{0:F2}", quantity * 0.25));
				CalculateTotal();
			}
		}

		private void Cantidad_CincuentaCentavos_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_CincuentaCentavos)) {
				int quantity = Convert.ToInt32(Cantidad_CincuentaCentavos.Text);
				SubTotalCincuentaCentavos.Text = Convert.ToString(String.Format("{0:F2}", quantity * 0.5));
				CalculateTotal();
			}
		}

		private void Cantidad_UnQuetzal_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_UnQuetzal)) {
				int quantity = Convert.ToInt32(Cantidad_UnQuetzal.Text);
				SubTotalUnQuetzal.Text = Convert.ToString(String.Format("{0:F2}", quantity));
				CalculateTotal();
			}
		}

		private void Cantidad_CincoQuetzales_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_CincoQuetzales)) {
				int quantity = Convert.ToInt32(Cantidad_CincoQuetzales.Text);
				SubTotalCincoQuetzales.Text = Convert.ToString(String.Format("{0:F2}", quantity * 5));
				CalculateTotal();
			}
		}

		private void Cantidad_DiezQuetzales_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_DiezQuetzales)) {
				int quantity = Convert.ToInt32(Cantidad_DiezQuetzales.Text);
				SubTotalDiezQuetzales.Text = Convert.ToString(String.Format("{0:F2}", quantity * 10));
				CalculateTotal();
			}
		}

		private void Cantidad_VeinteQuetzales_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_VeinteQuetzales)) {
				int quantity = Convert.ToInt32(Cantidad_VeinteQuetzales.Text);
				SubTotalVeinteQuetzales.Text = Convert.ToString(String.Format("{0:F2}", quantity * 20));
				CalculateTotal();
			}
		}

		private void Cantidad_CincuentaQuetzales_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_CincuentaQuetzales)) {
				int quantity = Convert.ToInt32(Cantidad_CincuentaQuetzales.Text);
				SubTotalCincuentaQuetzales.Text = Convert.ToString(String.Format("{0:F2}", quantity * 50));
				CalculateTotal();
			}
		}

		private void Cantidad_CienQuetzales_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_CienQuetzales)) {
				int quantity = Convert.ToInt32(Cantidad_CienQuetzales.Text);
				SubTotalCienQuetzales.Text = Convert.ToString(String.Format("{0:F2}", quantity * 100));
				CalculateTotal();
			}
		}

		private void Cantidad_DoscientosQuetzales_ValueChanged(object sender, EventArgs e) {
			if (HasNumber(Cantidad_DoscientosQuetzales)) {
				int quantity = Convert.ToInt32(Cantidad_DoscientosQuetzales.Text);
				SubTotalDoscientosQuetzales.Text = Convert.ToString(String.Format("{0:F2}", quantity * 200));
				CalculateTotal();
			}
		}

		private void Cantidad_CincoCentavos_Enter(object sender, EventArgs e) {
			
		}

		private void button1_Click(object sender, EventArgs e) {
			Cantidad_CincoCentavos.Text = "";
			Cantidad_DiezCentavos.Text = "";
			Cantidad_VeintiCincoCentavos.Text = "";
			Cantidad_CincuentaCentavos.Text = "";
			Cantidad_UnQuetzal.Text = "";
			Cantidad_CincoQuetzales.Text = "";
			Cantidad_DiezQuetzales.Text = "";
			Cantidad_VeinteQuetzales.Text = "";
			Cantidad_CincuentaQuetzales.Text = "";
			Cantidad_CienQuetzales.Text = "";
			Cantidad_DoscientosQuetzales.Text = "";
		}

		private void TotalTotal_Click(object sender, EventArgs e) {
			Clipboard.SetText(TotalTotal.Text);
			label25.Show();
			System.Threading.Timer temporizador = new System.Threading.Timer((state) => {
				label25.BeginInvoke((Action)(() => {
					label25.Hide();
				}));
			},
			null, 1500, Timeout.Infinite);
		}

		private bool HasNumber(TextBox textBox) {
			string pattern = "^[1-9]\\d*$";
			string lastWords = "Texto Copiado";
			if (Regex.IsMatch(textBox.Text, pattern)) {
				return true;
			} else {
				if (textBox.Text.Equals("")) {
					return false;
				}
				label25.Show();
				lastWords = label25.Text;
				label25.Text = "Pon Numeros";
				textBox.Text = "";
				System.Threading.Timer temporizador = new System.Threading.Timer((state) => {
					label25.BeginInvoke((Action)(() => {
						label25.Hide();
						label25.Text = lastWords;
					}));
				},
				null, 1500, Timeout.Infinite);
				return false;
			}
		}
	}
}