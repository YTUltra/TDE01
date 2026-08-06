namespace Bhaskara
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Calcular_Clicked(object sender, EventArgs e)
        {
            if (A.Text == null || B.Text == null || C.Text == null)
            {
                await DisplayAlertAsync("Erro", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            double a = double.Parse(A.Text);
            double b = double.Parse(B.Text);
            double c = double.Parse(C.Text);

            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
            {
                await DisplayAlertAsync("Resultado", "Não existem raízes reais.", "OK");
                return;
            }
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta == 0)
            {
                await DisplayAlertAsync("Resultado", x1.ToString(), "OK");
            }
            else
            {
                await DisplayAlertAsync("Resultado", $"x1 = {x1}, x2 = {x2}", "OK");
            }
        }
    }
}
