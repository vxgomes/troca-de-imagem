namespace troca_de_imagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DogPicBox = new System.Windows.Forms.PictureBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonApagar2 = new System.Windows.Forms.Button();
            this.buttonMostrar2 = new System.Windows.Forms.Button();
            this.CatDogPicBox = new System.Windows.Forms.PictureBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatDogPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DogPicBox
            // 
            this.DogPicBox.Image = ((System.Drawing.Image)(resources.GetObject("DogPicBox.Image")));
            this.DogPicBox.Location = new System.Drawing.Point(12, 36);
            this.DogPicBox.Name = "DogPicBox";
            this.DogPicBox.Size = new System.Drawing.Size(500, 330);
            this.DogPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogPicBox.TabIndex = 0;
            this.DogPicBox.TabStop = false;
            this.DogPicBox.Visible = false;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonMostrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.Location = new System.Drawing.Point(12, 398);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(500, 30);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Clique para mostrar a imagem";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonApagar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonApagar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(12, 434);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(500, 32);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Clique para apagar a imagem";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonApagar2
            // 
            this.buttonApagar2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonApagar2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonApagar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonApagar2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar2.Location = new System.Drawing.Point(600, 434);
            this.buttonApagar2.Name = "buttonApagar2";
            this.buttonApagar2.Size = new System.Drawing.Size(500, 32);
            this.buttonApagar2.TabIndex = 5;
            this.buttonApagar2.Text = "Clique para apagar a imagem";
            this.buttonApagar2.UseVisualStyleBackColor = false;
            this.buttonApagar2.Click += new System.EventHandler(this.buttonApagar2_Click);
            // 
            // buttonMostrar2
            // 
            this.buttonMostrar2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMostrar2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMostrar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonMostrar2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar2.Location = new System.Drawing.Point(600, 398);
            this.buttonMostrar2.Name = "buttonMostrar2";
            this.buttonMostrar2.Size = new System.Drawing.Size(500, 30);
            this.buttonMostrar2.TabIndex = 4;
            this.buttonMostrar2.Text = "Clique para mostrar a imagem";
            this.buttonMostrar2.UseVisualStyleBackColor = false;
            this.buttonMostrar2.Click += new System.EventHandler(this.buttonMostrar2_Click);
            // 
            // CatDogPicBox
            // 
            this.CatDogPicBox.Image = ((System.Drawing.Image)(resources.GetObject("CatDogPicBox.Image")));
            this.CatDogPicBox.Location = new System.Drawing.Point(600, 36);
            this.CatDogPicBox.Name = "CatDogPicBox";
            this.CatDogPicBox.Size = new System.Drawing.Size(500, 330);
            this.CatDogPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CatDogPicBox.TabIndex = 3;
            this.CatDogPicBox.TabStop = false;
            this.CatDogPicBox.Visible = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonFechar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(307, 558);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(500, 32);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.Text = "Fechar tudo";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.BackColor = System.Drawing.Color.Blue;
            this.buttonAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonAbrir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrir.Location = new System.Drawing.Point(307, 520);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(500, 32);
            this.buttonAbrir.TabIndex = 7;
            this.buttonAbrir.Text = "Abrir tudo";
            this.buttonAbrir.UseVisualStyleBackColor = false;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 773);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonApagar2);
            this.Controls.Add(this.buttonMostrar2);
            this.Controls.Add(this.CatDogPicBox);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.DogPicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatDogPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogPicBox;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonApagar2;
        private System.Windows.Forms.Button buttonMostrar2;
        private System.Windows.Forms.PictureBox CatDogPicBox;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAbrir;
    }
}

