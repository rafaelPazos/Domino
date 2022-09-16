namespace InterfazGrafica
{
    partial class Form1
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
            this.crearFicha = new System.Windows.Forms.Button();
            this.numFichas = new System.Windows.Forms.ComboBox();
            this.RepartirFichas = new System.Windows.Forms.Button();
            this.Empezar = new System.Windows.Forms.Button();
            this.Board = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ListView();
            this.winner = new System.Windows.Forms.Label();
            this.sinDobles = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.random = new System.Windows.Forms.Button();
            this.botagorda = new System.Windows.Forms.Button();
            this.alternado = new System.Windows.Forms.Button();
            this.reglas = new System.Windows.Forms.Label();
            this.reglatradicional = new System.Windows.Forms.Button();
            this.reglaalternativa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.turnostradicional = new System.Windows.Forms.Button();
            this.turnosalternativo = new System.Windows.Forms.Button();
            this.finalizcion = new System.Windows.Forms.Label();
            this.finalizaciontradicional = new System.Windows.Forms.Button();
            this.finalizacionalternativa = new System.Windows.Forms.Button();
            this.ganadortradicional = new System.Windows.Forms.Button();
            this.ganadoralternativo = new System.Windows.Forms.Button();
            this.decisionganador = new System.Windows.Forms.Label();
            this.puntuación = new System.Windows.Forms.Label();
            this.puntuacióntradicional = new System.Windows.Forms.Button();
            this.puntuaciónalternativa = new System.Windows.Forms.Button();
            this.ladojugado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crearFicha
            // 
            this.crearFicha.Location = new System.Drawing.Point(202, 12);
            this.crearFicha.Name = "crearFicha";
            this.crearFicha.Size = new System.Drawing.Size(94, 29);
            this.crearFicha.TabIndex = 0;
            this.crearFicha.Text = "crearFichas";
            this.crearFicha.UseVisualStyleBackColor = true;
            this.crearFicha.Click += new System.EventHandler(this.button1_Click);
            // 
            // numFichas
            // 
            this.numFichas.FormattingEnabled = true;
            this.numFichas.Location = new System.Drawing.Point(23, 12);
            this.numFichas.Name = "numFichas";
            this.numFichas.Size = new System.Drawing.Size(94, 28);
            this.numFichas.TabIndex = 1;
            this.numFichas.Text = "num";
            // 
            // RepartirFichas
            // 
            this.RepartirFichas.Location = new System.Drawing.Point(23, 230);
            this.RepartirFichas.Name = "RepartirFichas";
            this.RepartirFichas.Size = new System.Drawing.Size(153, 29);
            this.RepartirFichas.TabIndex = 4;
            this.RepartirFichas.Text = "Repartir Con Dobles";
            this.RepartirFichas.UseVisualStyleBackColor = true;
            this.RepartirFichas.Click += new System.EventHandler(this.RepartirFichas_Click);
            // 
            // Empezar
            // 
            this.Empezar.Location = new System.Drawing.Point(522, 531);
            this.Empezar.Name = "Empezar";
            this.Empezar.Size = new System.Drawing.Size(94, 29);
            this.Empezar.TabIndex = 5;
            this.Empezar.Text = "Empezar Juego";
            this.Empezar.UseVisualStyleBackColor = true;
            this.Empezar.Click += new System.EventHandler(this.Empezar_Click);
            // 
            // Board
            // 
            this.Board.AutoSize = true;
            this.Board.Location = new System.Drawing.Point(522, 31);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(49, 20);
            this.Board.TabIndex = 6;
            this.Board.Text = "Board";
            this.Board.Click += new System.EventHandler(this.Board_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(522, 74);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(403, 435);
            this.progress.TabIndex = 7;
            this.progress.UseCompatibleStateImageBehavior = false;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Location = new System.Drawing.Point(958, 239);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(56, 20);
            this.winner.TabIndex = 8;
            this.winner.Text = "Winner";
            this.winner.Visible = false;
            // 
            // sinDobles
            // 
            this.sinDobles.Location = new System.Drawing.Point(202, 230);
            this.sinDobles.Name = "sinDobles";
            this.sinDobles.Size = new System.Drawing.Size(153, 29);
            this.sinDobles.TabIndex = 9;
            this.sinDobles.Text = "Repartir sin dobles";
            this.sinDobles.UseVisualStyleBackColor = true;
            this.sinDobles.Click += new System.EventHandler(this.sinDobles_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(101, 60);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(159, 20);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "Creación de Jugadores";
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(23, 95);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(94, 29);
            this.random.TabIndex = 11;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // botagorda
            // 
            this.botagorda.Location = new System.Drawing.Point(135, 95);
            this.botagorda.Name = "botagorda";
            this.botagorda.Size = new System.Drawing.Size(94, 29);
            this.botagorda.TabIndex = 12;
            this.botagorda.Text = "Bota Gorda";
            this.botagorda.UseVisualStyleBackColor = true;
            this.botagorda.Click += new System.EventHandler(this.botagorda_Click);
            // 
            // alternado
            // 
            this.alternado.Location = new System.Drawing.Point(245, 95);
            this.alternado.Name = "alternado";
            this.alternado.Size = new System.Drawing.Size(94, 29);
            this.alternado.TabIndex = 13;
            this.alternado.Text = "Alternado";
            this.alternado.UseVisualStyleBackColor = true;
            this.alternado.Click += new System.EventHandler(this.alternado_Click);
            // 
            // reglas
            // 
            this.reglas.AutoSize = true;
            this.reglas.Location = new System.Drawing.Point(113, 138);
            this.reglas.Name = "reglas";
            this.reglas.Size = new System.Drawing.Size(137, 20);
            this.reglas.TabIndex = 14;
            this.reglas.Text = "Regla a seleccionar";
            // 
            // reglatradicional
            // 
            this.reglatradicional.Location = new System.Drawing.Point(23, 172);
            this.reglatradicional.Name = "reglatradicional";
            this.reglatradicional.Size = new System.Drawing.Size(94, 29);
            this.reglatradicional.TabIndex = 15;
            this.reglatradicional.Text = "Tradicional";
            this.reglatradicional.UseVisualStyleBackColor = true;
            this.reglatradicional.Click += new System.EventHandler(this.reglatradicional_Click);
            // 
            // reglaalternativa
            // 
            this.reglaalternativa.Location = new System.Drawing.Point(245, 172);
            this.reglaalternativa.Name = "reglaalternativa";
            this.reglaalternativa.Size = new System.Drawing.Size(94, 29);
            this.reglaalternativa.TabIndex = 16;
            this.reglaalternativa.Text = "Alternativa";
            this.reglaalternativa.UseVisualStyleBackColor = true;
            this.reglaalternativa.Click += new System.EventHandler(this.reglaalternativa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Orden de Turnos";
            // 
            // turnostradicional
            // 
            this.turnostradicional.Location = new System.Drawing.Point(23, 290);
            this.turnostradicional.Name = "turnostradicional";
            this.turnostradicional.Size = new System.Drawing.Size(94, 29);
            this.turnostradicional.TabIndex = 18;
            this.turnostradicional.Text = "Tradicional";
            this.turnostradicional.UseVisualStyleBackColor = true;
            this.turnostradicional.Click += new System.EventHandler(this.turnostradicional_Click);
            // 
            // turnosalternativo
            // 
            this.turnosalternativo.Location = new System.Drawing.Point(245, 290);
            this.turnosalternativo.Name = "turnosalternativo";
            this.turnosalternativo.Size = new System.Drawing.Size(94, 29);
            this.turnosalternativo.TabIndex = 19;
            this.turnosalternativo.Text = "Alternativa";
            this.turnosalternativo.UseVisualStyleBackColor = true;
            this.turnosalternativo.Click += new System.EventHandler(this.turnosalternativo_Click);
            // 
            // finalizcion
            // 
            this.finalizcion.AutoSize = true;
            this.finalizcion.Location = new System.Drawing.Point(101, 332);
            this.finalizcion.Name = "finalizcion";
            this.finalizcion.Size = new System.Drawing.Size(179, 20);
            this.finalizcion.TabIndex = 20;
            this.finalizcion.Text = "Condición de Finalización";
            // 
            // finalizaciontradicional
            // 
            this.finalizaciontradicional.Location = new System.Drawing.Point(23, 364);
            this.finalizaciontradicional.Name = "finalizaciontradicional";
            this.finalizaciontradicional.Size = new System.Drawing.Size(94, 29);
            this.finalizaciontradicional.TabIndex = 21;
            this.finalizaciontradicional.Text = "Tradicional";
            this.finalizaciontradicional.UseVisualStyleBackColor = true;
            this.finalizaciontradicional.Click += new System.EventHandler(this.finalizaciontradicional_Click);
            // 
            // finalizacionalternativa
            // 
            this.finalizacionalternativa.Location = new System.Drawing.Point(245, 364);
            this.finalizacionalternativa.Name = "finalizacionalternativa";
            this.finalizacionalternativa.Size = new System.Drawing.Size(94, 29);
            this.finalizacionalternativa.TabIndex = 22;
            this.finalizacionalternativa.Text = "Alternativa";
            this.finalizacionalternativa.UseVisualStyleBackColor = true;
            this.finalizacionalternativa.Click += new System.EventHandler(this.finalizacionalternativa_Click);
            // 
            // ganadortradicional
            // 
            this.ganadortradicional.Location = new System.Drawing.Point(23, 445);
            this.ganadortradicional.Name = "ganadortradicional";
            this.ganadortradicional.Size = new System.Drawing.Size(94, 29);
            this.ganadortradicional.TabIndex = 23;
            this.ganadortradicional.Text = "Tradicional";
            this.ganadortradicional.UseVisualStyleBackColor = true;
            this.ganadortradicional.Click += new System.EventHandler(this.ganadortradicional_Click);
            // 
            // ganadoralternativo
            // 
            this.ganadoralternativo.Location = new System.Drawing.Point(245, 445);
            this.ganadoralternativo.Name = "ganadoralternativo";
            this.ganadoralternativo.Size = new System.Drawing.Size(94, 29);
            this.ganadoralternativo.TabIndex = 24;
            this.ganadoralternativo.Text = "Alternativo";
            this.ganadoralternativo.UseVisualStyleBackColor = true;
            this.ganadoralternativo.Click += new System.EventHandler(this.ganadoralternativo_Click);
            // 
            // decisionganador
            // 
            this.decisionganador.AutoSize = true;
            this.decisionganador.Location = new System.Drawing.Point(113, 412);
            this.decisionganador.Name = "decisionganador";
            this.decisionganador.Size = new System.Drawing.Size(140, 20);
            this.decisionganador.TabIndex = 25;
            this.decisionganador.Text = "Criterio de Ganador";
            // 
            // puntuación
            // 
            this.puntuación.AutoSize = true;
            this.puntuación.Location = new System.Drawing.Point(135, 489);
            this.puntuación.Name = "puntuación";
            this.puntuación.Size = new System.Drawing.Size(82, 20);
            this.puntuación.TabIndex = 26;
            this.puntuación.Text = "Puntuación";
            // 
            // puntuacióntradicional
            // 
            this.puntuacióntradicional.Location = new System.Drawing.Point(23, 528);
            this.puntuacióntradicional.Name = "puntuacióntradicional";
            this.puntuacióntradicional.Size = new System.Drawing.Size(169, 29);
            this.puntuacióntradicional.TabIndex = 27;
            this.puntuacióntradicional.Text = "Puntuación Tradicional";
            this.puntuacióntradicional.UseVisualStyleBackColor = true;
            this.puntuacióntradicional.Click += new System.EventHandler(this.puntuacióntradicional_Click);
            // 
            // puntuaciónalternativa
            // 
            this.puntuaciónalternativa.Location = new System.Drawing.Point(245, 528);
            this.puntuaciónalternativa.Name = "puntuaciónalternativa";
            this.puntuaciónalternativa.Size = new System.Drawing.Size(167, 29);
            this.puntuaciónalternativa.TabIndex = 28;
            this.puntuaciónalternativa.Text = "Puntuación Alternativa";
            this.puntuaciónalternativa.UseVisualStyleBackColor = true;
            this.puntuaciónalternativa.Click += new System.EventHandler(this.puntuaciónalternativa_Click);
            // 
            // ladojugado
            // 
            this.ladojugado.AutoSize = true;
            this.ladojugado.Location = new System.Drawing.Point(1, 594);
            this.ladojugado.Name = "ladojugado";
            this.ladojugado.Size = new System.Drawing.Size(94, 20);
            this.ladojugado.TabIndex = 29;
            this.ladojugado.Text = "Lado Jugado";
            this.ladojugado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.ladojugado);
            this.Controls.Add(this.puntuaciónalternativa);
            this.Controls.Add(this.puntuacióntradicional);
            this.Controls.Add(this.puntuación);
            this.Controls.Add(this.decisionganador);
            this.Controls.Add(this.ganadoralternativo);
            this.Controls.Add(this.ganadortradicional);
            this.Controls.Add(this.finalizacionalternativa);
            this.Controls.Add(this.finalizaciontradicional);
            this.Controls.Add(this.finalizcion);
            this.Controls.Add(this.turnosalternativo);
            this.Controls.Add(this.turnostradicional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reglaalternativa);
            this.Controls.Add(this.reglatradicional);
            this.Controls.Add(this.reglas);
            this.Controls.Add(this.alternado);
            this.Controls.Add(this.botagorda);
            this.Controls.Add(this.random);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.sinDobles);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.Empezar);
            this.Controls.Add(this.RepartirFichas);
            this.Controls.Add(this.numFichas);
            this.Controls.Add(this.crearFicha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button crearFicha;
        private ComboBox numFichas;
        private Button RepartirFichas;
        private Button Empezar;
        private Label Board;
        private ListView progress;
        private Label winner;
        private Button sinDobles;
        private Label Titulo;
        private Button random;
        private Button botagorda;
        private Button alternado;
        private Label reglas;
        private Button reglatradicional;
        private Button reglaalternativa;
        private Label label1;
        private Button turnostradicional;
        private Button turnosalternativo;
        private Label finalizcion;
        private Button finalizaciontradicional;
        private Button finalizacionalternativa;
        private Button ganadortradicional;
        private Button ganadoralternativo;
        private Label decisionganador;
        private Label puntuación;
        private Button puntuacióntradicional;
        private Button puntuaciónalternativa;
        private Label ladojugado;
    }
}