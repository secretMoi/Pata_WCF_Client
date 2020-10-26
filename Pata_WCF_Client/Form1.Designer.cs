namespace Pata_WCF_Client
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonHelloWorld = new System.Windows.Forms.Button();
			this.textBoxGetData = new System.Windows.Forms.TextBox();
			this.labelGetData = new System.Windows.Forms.Label();
			this.buttonGetData = new System.Windows.Forms.Button();
			this.buttonIsbn13 = new System.Windows.Forms.Button();
			this.labelIsbn13 = new System.Windows.Forms.Label();
			this.textBoxIsbn13 = new System.Windows.Forms.TextBox();
			this.buttonGetDataUsingContract = new System.Windows.Forms.Button();
			this.labelGetDataUsingContract = new System.Windows.Forms.Label();
			this.textBoxGetDataUsingContract = new System.Windows.Forms.TextBox();
			this.checkBoxGetDataUsingContract = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonHelloWorld
			// 
			this.buttonHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHelloWorld.Location = new System.Drawing.Point(12, 12);
			this.buttonHelloWorld.Name = "buttonHelloWorld";
			this.buttonHelloWorld.Size = new System.Drawing.Size(274, 55);
			this.buttonHelloWorld.TabIndex = 0;
			this.buttonHelloWorld.Text = "Hello World";
			this.buttonHelloWorld.UseVisualStyleBackColor = true;
			this.buttonHelloWorld.Click += new System.EventHandler(this.buttonHelloWorld_Click);
			// 
			// textBoxGetData
			// 
			this.textBoxGetData.Location = new System.Drawing.Point(159, 103);
			this.textBoxGetData.Name = "textBoxGetData";
			this.textBoxGetData.Size = new System.Drawing.Size(127, 20);
			this.textBoxGetData.TabIndex = 1;
			// 
			// labelGetData
			// 
			this.labelGetData.AutoSize = true;
			this.labelGetData.Location = new System.Drawing.Point(9, 110);
			this.labelGetData.Name = "labelGetData";
			this.labelGetData.Size = new System.Drawing.Size(79, 13);
			this.labelGetData.TabIndex = 2;
			this.labelGetData.Text = "Votre nombre : ";
			// 
			// buttonGetData
			// 
			this.buttonGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGetData.Location = new System.Drawing.Point(12, 129);
			this.buttonGetData.Name = "buttonGetData";
			this.buttonGetData.Size = new System.Drawing.Size(274, 55);
			this.buttonGetData.TabIndex = 3;
			this.buttonGetData.Text = "GetData";
			this.buttonGetData.UseVisualStyleBackColor = true;
			this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
			// 
			// buttonIsbn13
			// 
			this.buttonIsbn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIsbn13.Location = new System.Drawing.Point(12, 248);
			this.buttonIsbn13.Name = "buttonIsbn13";
			this.buttonIsbn13.Size = new System.Drawing.Size(274, 55);
			this.buttonIsbn13.TabIndex = 6;
			this.buttonIsbn13.Text = "Vérifier ISBN-13";
			this.buttonIsbn13.UseVisualStyleBackColor = true;
			this.buttonIsbn13.Click += new System.EventHandler(this.buttonIsbn13_Click);
			// 
			// labelIsbn13
			// 
			this.labelIsbn13.AutoSize = true;
			this.labelIsbn13.Location = new System.Drawing.Point(9, 229);
			this.labelIsbn13.Name = "labelIsbn13";
			this.labelIsbn13.Size = new System.Drawing.Size(81, 13);
			this.labelIsbn13.TabIndex = 5;
			this.labelIsbn13.Text = "Votre ISBN13 : ";
			// 
			// textBoxIsbn13
			// 
			this.textBoxIsbn13.Location = new System.Drawing.Point(159, 222);
			this.textBoxIsbn13.Name = "textBoxIsbn13";
			this.textBoxIsbn13.Size = new System.Drawing.Size(127, 20);
			this.textBoxIsbn13.TabIndex = 4;
			// 
			// buttonGetDataUsingContract
			// 
			this.buttonGetDataUsingContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGetDataUsingContract.Location = new System.Drawing.Point(12, 383);
			this.buttonGetDataUsingContract.Name = "buttonGetDataUsingContract";
			this.buttonGetDataUsingContract.Size = new System.Drawing.Size(274, 55);
			this.buttonGetDataUsingContract.TabIndex = 9;
			this.buttonGetDataUsingContract.Text = "GetDataUsingContract";
			this.buttonGetDataUsingContract.UseVisualStyleBackColor = true;
			this.buttonGetDataUsingContract.Click += new System.EventHandler(this.buttonGetDataUsingContract_Click);
			// 
			// labelGetDataUsingContract
			// 
			this.labelGetDataUsingContract.AutoSize = true;
			this.labelGetDataUsingContract.Location = new System.Drawing.Point(9, 364);
			this.labelGetDataUsingContract.Name = "labelGetDataUsingContract";
			this.labelGetDataUsingContract.Size = new System.Drawing.Size(144, 13);
			this.labelGetDataUsingContract.TabIndex = 8;
			this.labelGetDataUsingContract.Text = "Votre chaine de caractères : ";
			// 
			// textBoxGetDataUsingContract
			// 
			this.textBoxGetDataUsingContract.Location = new System.Drawing.Point(159, 357);
			this.textBoxGetDataUsingContract.Name = "textBoxGetDataUsingContract";
			this.textBoxGetDataUsingContract.Size = new System.Drawing.Size(127, 20);
			this.textBoxGetDataUsingContract.TabIndex = 7;
			// 
			// checkBoxGetDataUsingContract
			// 
			this.checkBoxGetDataUsingContract.AutoSize = true;
			this.checkBoxGetDataUsingContract.Location = new System.Drawing.Point(208, 334);
			this.checkBoxGetDataUsingContract.Name = "checkBoxGetDataUsingContract";
			this.checkBoxGetDataUsingContract.Size = new System.Drawing.Size(78, 17);
			this.checkBoxGetDataUsingContract.TabIndex = 10;
			this.checkBoxGetDataUsingContract.Text = "Vrai / Faux";
			this.checkBoxGetDataUsingContract.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 450);
			this.Controls.Add(this.checkBoxGetDataUsingContract);
			this.Controls.Add(this.buttonGetDataUsingContract);
			this.Controls.Add(this.labelGetDataUsingContract);
			this.Controls.Add(this.textBoxGetDataUsingContract);
			this.Controls.Add(this.buttonIsbn13);
			this.Controls.Add(this.labelIsbn13);
			this.Controls.Add(this.textBoxIsbn13);
			this.Controls.Add(this.buttonGetData);
			this.Controls.Add(this.labelGetData);
			this.Controls.Add(this.textBoxGetData);
			this.Controls.Add(this.buttonHelloWorld);
			this.Name = "Form1";
			this.Text = "Accueil";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonHelloWorld;
		private System.Windows.Forms.TextBox textBoxGetData;
		private System.Windows.Forms.Label labelGetData;
		private System.Windows.Forms.Button buttonGetData;
		private System.Windows.Forms.Button buttonIsbn13;
		private System.Windows.Forms.Label labelIsbn13;
		private System.Windows.Forms.TextBox textBoxIsbn13;
		private System.Windows.Forms.Button buttonGetDataUsingContract;
		private System.Windows.Forms.Label labelGetDataUsingContract;
		private System.Windows.Forms.TextBox textBoxGetDataUsingContract;
		private System.Windows.Forms.CheckBox checkBoxGetDataUsingContract;
	}
}

