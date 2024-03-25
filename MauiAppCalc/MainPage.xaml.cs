namespace MauiAppCalc
{
    public partial class MainPage : ContentPage
    {
        string? operacao = null;

        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao = 0;

        string para_aparecer_no_visor = "";
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" ||
                para_aparecer_no_visor == "-" ||
                para_aparecer_no_visor == "*" ||
                para_aparecer_no_visor == "/")
            {
                para_aparecer_no_visor = ""; 
            }
        }

        private void zerar_Clicked(object sender, EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_calc_pre_operacao = 0;
            memoria_calc_pos_operacao = 0;
            operacao = null;
        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
        }

        private void porcento_Clicked(object sender, EventArgs e)
        {

        }

        private void dividir_Clicked(object sender, EventArgs e)
        {

        }

        private void num7_Clicked(object sender, EventArgs e)
        {

        }

        private void num8_Clicked(object sender, EventArgs e)
        {

        }

        private void num9_Clicked(object sender, EventArgs e)
        {

        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void subtrair_Clicked(object sender, EventArgs e)
        {

        }

        private void num4_Clicked(object sender, EventArgs e)
        {

        }

        private void num5_Clicked(object sender, EventArgs e)
        {

        }

        private void num6_Clicked(object sender, EventArgs e)
        {

        }

        private void somar_Clicked(object sender, EventArgs e)
        {

        }

        private void num3_Clicked(object sender, EventArgs e)
        {

        }

        private void num2_Clicked(object sender, EventArgs e)
        {

        }

        private void num1_Clicked(object sender, EventArgs e)
        {

        }

        private void engual_Clicked(object sender, EventArgs e)
        {

        }

        private void ponto_Clicked(object sender, EventArgs e)
        {

        }

        private void num0_Clicked(object sender, EventArgs e)
        {

        }
    }

}
