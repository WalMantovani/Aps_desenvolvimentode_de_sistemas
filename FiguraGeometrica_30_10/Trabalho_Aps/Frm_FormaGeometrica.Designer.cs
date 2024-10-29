namespace Trabalho_Aps
{
    partial class Frm_FormaGeometrica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cbx_Forma = new ComboBox();
            Cbx_Triangulo = new ComboBox();
            Btn_Calcular = new Button();
            Btn_Limpar = new Button();
            Lbl_Lado = new Label();
            Lbl_Base = new Label();
            Lbl_Altura = new Label();
            Lbl_Raio = new Label();
            Lbl_CatAdj = new Label();
            Lbl_CatOpt = new Label();
            Txt_Lado = new TextBox();
            Txt_Raio = new TextBox();
            Txt_Altura = new TextBox();
            Txt_Base = new TextBox();
            Txt_CatOpt = new TextBox();
            Txt_CatAdj = new TextBox();
            Lbl_Triangulo = new Label();
            Lbl_Forma = new Label();
            Lbl_Area = new Label();
            Lbl_Perimetro = new Label();
            Lbl_ResultadoArea = new Label();
            Lbl_ResultadoPerimetro = new Label();
            Lbl_Hipot = new Label();
            Lbl_ResultHipot = new Label();
            SuspendLayout();
            // 
            // Cbx_Forma
            // 
            Cbx_Forma.FormattingEnabled = true;
            Cbx_Forma.Items.AddRange(new object[] { "Quadrado", "Retângulo", "Triângulo", "Circunferência" });
            Cbx_Forma.Location = new Point(66, 12);
            Cbx_Forma.Name = "Cbx_Forma";
            Cbx_Forma.Size = new Size(129, 23);
            Cbx_Forma.TabIndex = 2;
            Cbx_Forma.Text = "Forma Geométrica";
            Cbx_Forma.SelectedIndexChanged += Cbx_Forma_SelectedIndexChanged;
            // 
            // Cbx_Triangulo
            // 
            Cbx_Triangulo.FormattingEnabled = true;
            Cbx_Triangulo.Items.AddRange(new object[] { "Isósceles", "Equilátero", "Reto" });
            Cbx_Triangulo.Location = new Point(280, 12);
            Cbx_Triangulo.Name = "Cbx_Triangulo";
            Cbx_Triangulo.Size = new Size(136, 23);
            Cbx_Triangulo.TabIndex = 3;
            // 
            // Btn_Calcular
            // 
            Btn_Calcular.Location = new Point(44, 318);
            Btn_Calcular.Name = "Btn_Calcular";
            Btn_Calcular.Size = new Size(97, 36);
            Btn_Calcular.TabIndex = 4;
            Btn_Calcular.Text = "Calcular";
            Btn_Calcular.UseVisualStyleBackColor = true;
            Btn_Calcular.Click += Btn_Calcular_Click;
            // 
            // Btn_Limpar
            // 
            Btn_Limpar.Location = new Point(244, 316);
            Btn_Limpar.Name = "Btn_Limpar";
            Btn_Limpar.Size = new Size(93, 38);
            Btn_Limpar.TabIndex = 5;
            Btn_Limpar.Text = "Limpa";
            Btn_Limpar.UseVisualStyleBackColor = true;
            Btn_Limpar.Click += Btn_Limpar_Click;
            // 
            // Lbl_Lado
            // 
            Lbl_Lado.AutoSize = true;
            Lbl_Lado.Location = new Point(12, 71);
            Lbl_Lado.Name = "Lbl_Lado";
            Lbl_Lado.Size = new Size(36, 15);
            Lbl_Lado.TabIndex = 6;
            Lbl_Lado.Text = "Lado:";
            // 
            // Lbl_Base
            // 
            Lbl_Base.AutoSize = true;
            Lbl_Base.Location = new Point(12, 100);
            Lbl_Base.Name = "Lbl_Base";
            Lbl_Base.Size = new Size(34, 15);
            Lbl_Base.TabIndex = 7;
            Lbl_Base.Text = "Base:";
            // 
            // Lbl_Altura
            // 
            Lbl_Altura.AutoSize = true;
            Lbl_Altura.Location = new Point(12, 131);
            Lbl_Altura.Name = "Lbl_Altura";
            Lbl_Altura.Size = new Size(42, 15);
            Lbl_Altura.TabIndex = 8;
            Lbl_Altura.Text = "Altura:";
            // 
            // Lbl_Raio
            // 
            Lbl_Raio.AutoSize = true;
            Lbl_Raio.Location = new Point(12, 162);
            Lbl_Raio.Name = "Lbl_Raio";
            Lbl_Raio.Size = new Size(33, 15);
            Lbl_Raio.TabIndex = 9;
            Lbl_Raio.Text = "Raio:";
            // 
            // Lbl_CatAdj
            // 
            Lbl_CatAdj.AutoSize = true;
            Lbl_CatAdj.Location = new Point(168, 80);
            Lbl_CatAdj.Name = "Lbl_CatAdj";
            Lbl_CatAdj.Size = new Size(106, 15);
            Lbl_CatAdj.TabIndex = 10;
            Lbl_CatAdj.Text = "Cateto Adjascente:";
            // 
            // Lbl_CatOpt
            // 
            Lbl_CatOpt.AutoSize = true;
            Lbl_CatOpt.Location = new Point(168, 109);
            Lbl_CatOpt.Name = "Lbl_CatOpt";
            Lbl_CatOpt.Size = new Size(87, 15);
            Lbl_CatOpt.TabIndex = 11;
            Lbl_CatOpt.Text = "Cateto Oposto:";
            // 
            // Txt_Lado
            // 
            Txt_Lado.Location = new Point(54, 68);
            Txt_Lado.Name = "Txt_Lado";
            Txt_Lado.Size = new Size(100, 23);
            Txt_Lado.TabIndex = 12;
            // 
            // Txt_Raio
            // 
            Txt_Raio.Location = new Point(51, 162);
            Txt_Raio.Name = "Txt_Raio";
            Txt_Raio.Size = new Size(100, 23);
            Txt_Raio.TabIndex = 13;
            // 
            // Txt_Altura
            // 
            Txt_Altura.Location = new Point(52, 131);
            Txt_Altura.Name = "Txt_Altura";
            Txt_Altura.Size = new Size(100, 23);
            Txt_Altura.TabIndex = 14;
            // 
            // Txt_Base
            // 
            Txt_Base.Location = new Point(54, 100);
            Txt_Base.Name = "Txt_Base";
            Txt_Base.Size = new Size(100, 23);
            Txt_Base.TabIndex = 15;
            // 
            // Txt_CatOpt
            // 
            Txt_CatOpt.Location = new Point(280, 106);
            Txt_CatOpt.Name = "Txt_CatOpt";
            Txt_CatOpt.Size = new Size(100, 23);
            Txt_CatOpt.TabIndex = 16;
            // 
            // Txt_CatAdj
            // 
            Txt_CatAdj.Location = new Point(280, 77);
            Txt_CatAdj.Name = "Txt_CatAdj";
            Txt_CatAdj.Size = new Size(100, 23);
            Txt_CatAdj.TabIndex = 17;
            // 
            // Lbl_Triangulo
            // 
            Lbl_Triangulo.AutoSize = true;
            Lbl_Triangulo.Location = new Point(215, 15);
            Lbl_Triangulo.Name = "Lbl_Triangulo";
            Lbl_Triangulo.Size = new Size(59, 15);
            Lbl_Triangulo.TabIndex = 18;
            Lbl_Triangulo.Text = "Triângulo:";
            // 
            // Lbl_Forma
            // 
            Lbl_Forma.AutoSize = true;
            Lbl_Forma.Location = new Point(16, 15);
            Lbl_Forma.Name = "Lbl_Forma";
            Lbl_Forma.Size = new Size(44, 15);
            Lbl_Forma.TabIndex = 19;
            Lbl_Forma.Text = "Forma:";
            // 
            // Lbl_Area
            // 
            Lbl_Area.AutoSize = true;
            Lbl_Area.Location = new Point(54, 224);
            Lbl_Area.Name = "Lbl_Area";
            Lbl_Area.Size = new Size(34, 15);
            Lbl_Area.TabIndex = 20;
            Lbl_Area.Text = "Área:";
            // 
            // Lbl_Perimetro
            // 
            Lbl_Perimetro.AutoSize = true;
            Lbl_Perimetro.Location = new Point(215, 224);
            Lbl_Perimetro.Name = "Lbl_Perimetro";
            Lbl_Perimetro.Size = new Size(62, 15);
            Lbl_Perimetro.TabIndex = 21;
            Lbl_Perimetro.Text = "Perimetro:";
            // 
            // Lbl_ResultadoArea
            // 
            Lbl_ResultadoArea.Location = new Point(94, 224);
            Lbl_ResultadoArea.Name = "Lbl_ResultadoArea";
            Lbl_ResultadoArea.Size = new Size(100, 23);
            Lbl_ResultadoArea.TabIndex = 22;
            Lbl_ResultadoArea.Text = "0";
            // 
            // Lbl_ResultadoPerimetro
            // 
            Lbl_ResultadoPerimetro.Location = new Point(283, 224);
            Lbl_ResultadoPerimetro.Name = "Lbl_ResultadoPerimetro";
            Lbl_ResultadoPerimetro.Size = new Size(38, 15);
            Lbl_ResultadoPerimetro.TabIndex = 23;
            Lbl_ResultadoPerimetro.Text = "0";
            // 
            // Lbl_Hipot
            // 
            Lbl_Hipot.AutoSize = true;
            Lbl_Hipot.Location = new Point(54, 264);
            Lbl_Hipot.Name = "Lbl_Hipot";
            Lbl_Hipot.Size = new Size(71, 15);
            Lbl_Hipot.TabIndex = 24;
            Lbl_Hipot.Text = "Hipotenusa:";
            // 
            // Lbl_ResultHipot
            // 
            Lbl_ResultHipot.AutoSize = true;
            Lbl_ResultHipot.Location = new Point(131, 264);
            Lbl_ResultHipot.Name = "Lbl_ResultHipot";
            Lbl_ResultHipot.Size = new Size(13, 15);
            Lbl_ResultHipot.TabIndex = 25;
            Lbl_ResultHipot.Text = "0";
            // 
            // Frm_FormaGeometrica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 392);
            Controls.Add(Lbl_ResultHipot);
            Controls.Add(Lbl_Hipot);
            Controls.Add(Lbl_ResultadoPerimetro);
            Controls.Add(Lbl_ResultadoArea);
            Controls.Add(Lbl_Perimetro);
            Controls.Add(Lbl_Area);
            Controls.Add(Lbl_Forma);
            Controls.Add(Lbl_Triangulo);
            Controls.Add(Txt_CatAdj);
            Controls.Add(Txt_CatOpt);
            Controls.Add(Txt_Base);
            Controls.Add(Txt_Altura);
            Controls.Add(Txt_Raio);
            Controls.Add(Txt_Lado);
            Controls.Add(Lbl_CatOpt);
            Controls.Add(Lbl_CatAdj);
            Controls.Add(Lbl_Raio);
            Controls.Add(Lbl_Altura);
            Controls.Add(Lbl_Base);
            Controls.Add(Lbl_Lado);
            Controls.Add(Btn_Limpar);
            Controls.Add(Btn_Calcular);
            Controls.Add(Cbx_Triangulo);
            Controls.Add(Cbx_Forma);
            Name = "Frm_FormaGeometrica";
            Text = "Forma Gemétrica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Cbx_Forma;
        private ComboBox Cbx_Triangulo;
        private Button Btn_Calcular;
        private Button Btn_Limpar;
        private Label Lbl_Lado;
        private Label Lbl_Base;
        private Label Lbl_Altura;
        private Label Lbl_Raio;
        private Label Lbl_CatAdj;
        private Label Lbl_CatOpt;
        private TextBox Txt_Lado;
        private TextBox Txt_Raio;
        private TextBox Txt_Altura;
        private TextBox Txt_Base;
        private TextBox Txt_CatOpt;
        private TextBox Txt_CatAdj;
        private Label Lbl_Triangulo;
        private Label Lbl_Forma;
        private Label Lbl_Area;
        private Label Lbl_Perimetro;
        private Label Lbl_ResultadoArea;
        private Label Lbl_ResultadoPerimetro;
        private Label Lbl_Hipot;
        private Label Lbl_ResultHipot;
    }
}
