namespace MachineLearning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.udRocketsPerGen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGeneration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.udMutationRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.udLifespan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMaxFitness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udRocketsPerGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLifespan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(547, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // udRocketsPerGen
            // 
            this.udRocketsPerGen.Location = new System.Drawing.Point(571, 316);
            this.udRocketsPerGen.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udRocketsPerGen.Name = "udRocketsPerGen";
            this.udRocketsPerGen.Size = new System.Drawing.Size(51, 20);
            this.udRocketsPerGen.TabIndex = 1;
            this.udRocketsPerGen.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rockets per generation";
            // 
            // lbGeneration
            // 
            this.lbGeneration.AutoSize = true;
            this.lbGeneration.Location = new System.Drawing.Point(587, 13);
            this.lbGeneration.Name = "lbGeneration";
            this.lbGeneration.Size = new System.Drawing.Size(13, 13);
            this.lbGeneration.TabIndex = 3;
            this.lbGeneration.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mutation rate";
            // 
            // udMutationRate
            // 
            this.udMutationRate.DecimalPlaces = 3;
            this.udMutationRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.udMutationRate.Location = new System.Drawing.Point(571, 342);
            this.udMutationRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udMutationRate.Name = "udMutationRate";
            this.udMutationRate.Size = new System.Drawing.Size(51, 20);
            this.udMutationRate.TabIndex = 5;
            this.udMutationRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lifespan";
            // 
            // udLifespan
            // 
            this.udLifespan.Location = new System.Drawing.Point(571, 368);
            this.udLifespan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLifespan.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udLifespan.Name = "udLifespan";
            this.udLifespan.Size = new System.Drawing.Size(51, 20);
            this.udLifespan.TabIndex = 7;
            this.udLifespan.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max Fitness:";
            // 
            // lbMaxFitness
            // 
            this.lbMaxFitness.AutoSize = true;
            this.lbMaxFitness.Location = new System.Drawing.Point(587, 36);
            this.lbMaxFitness.Name = "lbMaxFitness";
            this.lbMaxFitness.Size = new System.Drawing.Size(13, 13);
            this.lbMaxFitness.TabIndex = 10;
            this.lbMaxFitness.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 465);
            this.Controls.Add(this.lbMaxFitness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.udLifespan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.udMutationRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGeneration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udRocketsPerGen);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "MachineLearning";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udRocketsPerGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLifespan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown udRocketsPerGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGeneration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown udMutationRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udLifespan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaxFitness;
    }
}

