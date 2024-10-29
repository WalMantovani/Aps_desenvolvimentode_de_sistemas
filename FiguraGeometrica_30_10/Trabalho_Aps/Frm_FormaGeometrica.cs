using System.Drawing.Text;

namespace Trabalho_Aps
{
    public partial class Frm_FormaGeometrica : Form
    {
        public Frm_FormaGeometrica()
        {
            InitializeComponent();
        }

        private void ExibirTriangulo(bool visivel)
        {
           Cbx_Triangulo.Visible = Lbl_Triangulo.Visible = visivel;
        }
        private void ExibirLado(bool visivel)
        {
            Lbl_Lado.Visible = Txt_Lado.Visible = visivel;
        }

        private void ExibirBase(bool visivel)
        {
            Lbl_Base.Visible = Txt_Base.Visible = visivel;
        }

        private void ExibirAltura(bool visivel)
        {
            Lbl_Altura.Visible = Txt_Altura.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            Lbl_Raio.Visible = Txt_Raio.Visible = visivel;  
        }

        private void ExibirCatAdj(bool visivel)
        {
            Lbl_CatAdj.Visible = Txt_CatAdj.Visible = visivel;
        }

        private void ExibirCatOpt(bool visivel)
        {
            Lbl_CatOpt.Visible = Txt_CatOpt.Visible = visivel;
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            switch (Cbx_Forma.Text)
            {
                case "Quadrado":
                    ExibirLado(true);
                    ExibirAltura(false);
                    ExibirBase(false);
                    ExibirRaio(false);
                    ExibirCatAdj(false);
                    ExibirCatOpt(false);
                    ExibirTriangulo(false);

                    Quadrado q = new Quadrado
                    {
                        Lado = double.Parse(Txt_Lado.Text)
                    };

                    Lbl_ResultadoArea.Text = Convert.ToString(q.CalcularArea());
                    Lbl_ResultadoPerimetro.Text = Convert.ToString(q.CalcularPerimetro());
                    break;


                case "Retângulo":
                    ExibirLado(false);
                    ExibirAltura(true);
                    ExibirBase(true);
                    ExibirRaio(false);
                    ExibirCatAdj(false);
                    ExibirCatOpt(false);
                    ExibirTriangulo(false);

                    Retangulo r = new Retangulo();
                    {
                        r.Base = double.Parse(Txt_Base.Text);
                        r.Altura = double.Parse(Txt_Altura.Text);   
                    };

                    Lbl_ResultadoArea.Text = Convert.ToString(r.CalcularArea());
                    Lbl_ResultadoPerimetro.Text = Convert.ToString(r.CalcularPerimetro());


                    break;
                case "Circunferência":
                    ExibirRaio(true);
                    ExibirTriangulo(false);
                    ExibirLado(false);
                    ExibirAltura(false);
                    ExibirBase(false);
                    ExibirCatAdj(false);
                    ExibirCatOpt(false);

                    Circunferencia c = new Circunferencia();

                    c.Raio = double.Parse(Txt_Raio.Text);

                    Lbl_ResultadoArea.Text = Convert.ToString(c.CalcularArea());
                    Lbl_ResultadoPerimetro.Text = Convert.ToString(c.CalcularPerimetro());


                    break;
                case "Triângulo":
                    ExibirAltura(true);
                    ExibirBase(true);
                    ExibirCatAdj(true);
                    ExibirCatOpt(true);
                    ExibirLado(false);
                    ExibirRaio(false);
                    ExibirTriangulo(true);

                    Triangulo t = new Triangulo();
                    t.Base = double.Parse(Txt_Base.Text);
                    t.Altura = double.Parse(Txt_Altura.Text);
                    t.CatAdjascente = double.Parse(Txt_CatAdj.Text);
                    t.CatOposto = double.Parse(Txt_CatOpt.Text);

                    if (string.IsNullOrWhiteSpace(Txt_CatAdj.Text))
                    {
                        Lbl_ResultadoPerimetro.Text = "0";
                    }
                    else if (string.IsNullOrWhiteSpace(Txt_CatOpt.Text))
                    {
                        Lbl_ResultadoPerimetro.Text = "0";
                    }
                    else
                    {
                        Lbl_ResultadoPerimetro.Text = Convert.ToString(t.CalcularPerimetro());
                        Lbl_ResultadoArea.Text = Convert.ToString(t.CalcularArea());
                    }

                    if (Cbx_Triangulo.Text == "Reto")
                    {
                        Lbl_ResultHipot.Text = Convert.ToString(t.CalcularHipot());
                    }


                    break;
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Lbl_ResultadoArea.Text = "0";
            Lbl_ResultadoPerimetro.Text = "0";
            Txt_Altura.Text = "";
            Txt_Base.Text = "";
            Txt_CatAdj.Text = "";
            Txt_CatOpt.Text = "";
            Txt_Lado.Text = "";
            Txt_Raio.Text = "";
        }

        private void Cbx_Forma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Cbx_Forma.Text)
            {
                case "Quadrado":
                    ExibirLado(true);
                    ExibirAltura(false);
                    ExibirBase(false);
                    ExibirRaio(false);
                    ExibirCatAdj(false);
                    ExibirCatOpt(false);
                    ExibirTriangulo(false);
                    break;
                case "Retângulo":
                    ExibirLado(false);
                    ExibirAltura(true);
                    ExibirBase(true);
                    ExibirRaio(false);
                    ExibirCatAdj(false);
                    ExibirCatOpt(false);
                    ExibirTriangulo(false);
                    break;
                case "Circunferência":
                    ExibirRaio(true);
                    ExibirTriangulo(false);
                    ExibirLado(false);
                    ExibirAltura(false);
                    ExibirBase(false);
                    ExibirCatAdj(false);
                    ExibirCatOpt(false);
                    break;
                case "Triângulo":
                    ExibirAltura(true);
                    ExibirBase(true);
                    ExibirCatAdj(true);
                    ExibirCatOpt(true);
                    ExibirLado(false);
                    ExibirRaio(false);
                    ExibirTriangulo(true);
                    break;
            }
        }
    }
}
