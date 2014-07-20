namespace JoursFeries
{
  partial class FormMain
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
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.labelJourFerie = new System.Windows.Forms.Label();
      this.comboBoxCountryList = new System.Windows.Forms.ComboBox();
      this.labelCountry = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(53, 140);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 0;
      this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // labelJourFerie
      // 
      this.labelJourFerie.AutoSize = true;
      this.labelJourFerie.Location = new System.Drawing.Point(50, 106);
      this.labelJourFerie.Name = "labelJourFerie";
      this.labelJourFerie.Size = new System.Drawing.Size(61, 13);
      this.labelJourFerie.TabIndex = 1;
      this.labelJourFerie.Text = "Est-il férie ?";
      // 
      // comboBoxCountryList
      // 
      this.comboBoxCountryList.FormattingEnabled = true;
      this.comboBoxCountryList.Location = new System.Drawing.Point(329, 138);
      this.comboBoxCountryList.Name = "comboBoxCountryList";
      this.comboBoxCountryList.Size = new System.Drawing.Size(121, 21);
      this.comboBoxCountryList.TabIndex = 2;
      // 
      // labelCountry
      // 
      this.labelCountry.AutoSize = true;
      this.labelCountry.Location = new System.Drawing.Point(273, 141);
      this.labelCountry.Name = "labelCountry";
      this.labelCountry.Size = new System.Drawing.Size(46, 13);
      this.labelCountry.TabIndex = 3;
      this.labelCountry.Text = "Country:";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(752, 474);
      this.Controls.Add(this.labelCountry);
      this.Controls.Add(this.comboBoxCountryList);
      this.Controls.Add(this.labelJourFerie);
      this.Controls.Add(this.dateTimePicker1);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Getting to know if a date is a bank holiday";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label labelJourFerie;
    private System.Windows.Forms.ComboBox comboBoxCountryList;
    private System.Windows.Forms.Label labelCountry;
  }
}

