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
            valor = valor * -1;
            visor.Text = valor.ToString();
        }

        private void porcento_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor / 100;
            visor.Text = valor.ToString();  
        }
	private void operation_Clicked(object sender, EventArgs e)
        {
            	memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
		Button disparador = (Button)sender;  
		para_aparecer_no_visor = disparador.Text;
            	operacao = disparador.Text;
            	visor.Text = para_aparecer_no_visor;
        }
        private void num_Clicked(object sender, EventArgs e)//obs:da pra fazer numa funcao só| fazer isso dps
        {
            remover_sinais_visor();
            Button disparador = (Button)sender;
	        para_aparecer_no_visor += disparador.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void engual_Clicked(object sender, EventArgs e)
        {
            try 
            {
                memoria_calc_pos_operacao = Convert.ToDouble(visor.Text);

                double resultado = 0;
                switch (operacao)
                {
                    case "+":
                        resultado = memoria_calc_pre_operacao+memoria_calc_pos_operacao;
                        break;
                    case "-":
                        resultado = memoria_calc_pre_operacao-memoria_calc_pos_operacao;
                        break;
                    case "/":
                        resultado = memoria_calc_pre_operacao/memoria_calc_pos_operacao;
                        break;
                    case "*":
                        resultado = memoria_calc_pre_operacao*memoria_calc_pos_operacao;
                        break;
                }
            
            }catch (Exception ex) 
            {
            visor.Text = ex.Message;
            }
        }

        private void ponto_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += ponto.Text;
            visor.Text = para_aparecer_no_visor;
        }

        }
    }

}
