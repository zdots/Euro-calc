namespace EuroCalculator
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
            this.EurozoneOnly = new System.Windows.Forms.CheckBox();
            this.AllCountries = new System.Windows.Forms.CheckBox();
            this.CountriesList = new System.Windows.Forms.CheckedListBox();
            this.MemberStatesVote = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.AusVote = new System.Windows.Forms.TrackBar();
            this.BelVote = new System.Windows.Forms.TrackBar();
            this.CroVote = new System.Windows.Forms.TrackBar();
            this.BulVote = new System.Windows.Forms.TrackBar();
            this.EstVote = new System.Windows.Forms.TrackBar();
            this.DenVote = new System.Windows.Forms.TrackBar();
            this.CzeVote = new System.Windows.Forms.TrackBar();
            this.CypVote = new System.Windows.Forms.TrackBar();
            this.LatVote = new System.Windows.Forms.TrackBar();
            this.ItaVote = new System.Windows.Forms.TrackBar();
            this.IreVote = new System.Windows.Forms.TrackBar();
            this.HunVote = new System.Windows.Forms.TrackBar();
            this.GreVote = new System.Windows.Forms.TrackBar();
            this.GerVote = new System.Windows.Forms.TrackBar();
            this.FraVote = new System.Windows.Forms.TrackBar();
            this.FinVote = new System.Windows.Forms.TrackBar();
            this.SweVote = new System.Windows.Forms.TrackBar();
            this.SpaVote = new System.Windows.Forms.TrackBar();
            this.SlnVote = new System.Windows.Forms.TrackBar();
            this.SlkVote = new System.Windows.Forms.TrackBar();
            this.RomVote = new System.Windows.Forms.TrackBar();
            this.PorVote = new System.Windows.Forms.TrackBar();
            this.PolVote = new System.Windows.Forms.TrackBar();
            this.NetVote = new System.Windows.Forms.TrackBar();
            this.MalVote = new System.Windows.Forms.TrackBar();
            this.LuxVote = new System.Windows.Forms.TrackBar();
            this.LitVote = new System.Windows.Forms.TrackBar();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ParticipatingStates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AusVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CroVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DenVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CzeVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CypVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItaVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IreVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HunVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GerVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FraVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlnVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlkVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuxVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LitVote)).BeginInit();
            this.SuspendLayout();
            // 
            // EurozoneOnly
            // 
            this.EurozoneOnly.AutoSize = true;
            this.EurozoneOnly.Location = new System.Drawing.Point(156, 6);
            this.EurozoneOnly.Name = "EurozoneOnly";
            this.EurozoneOnly.Size = new System.Drawing.Size(201, 17);
            this.EurozoneOnly.TabIndex = 2;
            this.EurozoneOnly.Text = "Only Eurozone countries participating";
            this.EurozoneOnly.UseVisualStyleBackColor = true;
            // 
            // AllCountries
            // 
            this.AllCountries.AutoSize = true;
            this.AllCountries.Location = new System.Drawing.Point(7, 6);
            this.AllCountries.Name = "AllCountries";
            this.AllCountries.Size = new System.Drawing.Size(143, 17);
            this.AllCountries.TabIndex = 3;
            this.AllCountries.Text = "All countries participating";
            this.AllCountries.UseVisualStyleBackColor = true;
            this.AllCountries.CheckedChanged += new System.EventHandler(this.AllCountries_CheckedChanged);
            // 
            // CountriesList
            // 
            this.CountriesList.CheckOnClick = true;
            this.CountriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CountriesList.FormattingEnabled = true;
            this.CountriesList.Items.AddRange(new object[] {
            "Austria",
            "Belgium",
            "Bulgaria",
            "Croatia",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Estonia",
            "Finland",
            "France",
            "Germany",
            "Greece",
            "Hungary",
            "Ireland",
            "Italy",
            "Latvia",
            "Lithuania",
            "Luxembourg",
            "Malta",
            "Netherlands",
            "Poland",
            "Portugal",
            "Romania",
            "Slovakia",
            "Slovenia",
            "Spain",
            "Sweden"});
            this.CountriesList.Location = new System.Drawing.Point(7, 45);
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.Size = new System.Drawing.Size(143, 517);
            this.CountriesList.TabIndex = 4;
            this.CountriesList.TabStop = false;
            this.CountriesList.SelectedIndexChanged += new System.EventHandler(this.CountriesList_SelectedIndexChanged);
            // 
            // MemberStatesVote
            // 
            this.MemberStatesVote.Location = new System.Drawing.Point(670, 166);
            this.MemberStatesVote.MarqueeAnimationSpeed = 0;
            this.MemberStatesVote.Maximum = 27;
            this.MemberStatesVote.Name = "MemberStatesVote";
            this.MemberStatesVote.Size = new System.Drawing.Size(100, 23);
            this.MemberStatesVote.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MemberStatesVote.TabIndex = 5;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(670, 198);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // AusVote
            // 
            this.AusVote.AutoSize = false;
            this.AusVote.LargeChange = 1;
            this.AusVote.Location = new System.Drawing.Point(154, 46);
            this.AusVote.Maximum = 2;
            this.AusVote.Name = "AusVote";
            this.AusVote.Size = new System.Drawing.Size(201, 19);
            this.AusVote.TabIndex = 7;
            this.AusVote.Value = 2;
            // 
            // BelVote
            // 
            this.BelVote.AutoSize = false;
            this.BelVote.LargeChange = 1;
            this.BelVote.Location = new System.Drawing.Point(154, 65);
            this.BelVote.Maximum = 2;
            this.BelVote.Name = "BelVote";
            this.BelVote.Size = new System.Drawing.Size(201, 19);
            this.BelVote.TabIndex = 8;
            this.BelVote.Value = 2;
            // 
            // CroVote
            // 
            this.CroVote.AutoSize = false;
            this.CroVote.LargeChange = 1;
            this.CroVote.Location = new System.Drawing.Point(154, 103);
            this.CroVote.Maximum = 2;
            this.CroVote.Name = "CroVote";
            this.CroVote.Size = new System.Drawing.Size(201, 19);
            this.CroVote.TabIndex = 10;
            this.CroVote.Value = 2;
            // 
            // BulVote
            // 
            this.BulVote.AutoSize = false;
            this.BulVote.LargeChange = 1;
            this.BulVote.Location = new System.Drawing.Point(154, 84);
            this.BulVote.Maximum = 2;
            this.BulVote.Name = "BulVote";
            this.BulVote.Size = new System.Drawing.Size(201, 19);
            this.BulVote.TabIndex = 9;
            this.BulVote.Value = 2;
            // 
            // EstVote
            // 
            this.EstVote.AutoSize = false;
            this.EstVote.LargeChange = 1;
            this.EstVote.Location = new System.Drawing.Point(154, 179);
            this.EstVote.Maximum = 2;
            this.EstVote.Name = "EstVote";
            this.EstVote.Size = new System.Drawing.Size(201, 19);
            this.EstVote.TabIndex = 14;
            this.EstVote.Value = 2;
            // 
            // DenVote
            // 
            this.DenVote.AutoSize = false;
            this.DenVote.LargeChange = 1;
            this.DenVote.Location = new System.Drawing.Point(154, 160);
            this.DenVote.Maximum = 2;
            this.DenVote.Name = "DenVote";
            this.DenVote.Size = new System.Drawing.Size(201, 19);
            this.DenVote.TabIndex = 13;
            this.DenVote.Value = 2;
            // 
            // CzeVote
            // 
            this.CzeVote.AutoSize = false;
            this.CzeVote.LargeChange = 1;
            this.CzeVote.Location = new System.Drawing.Point(154, 141);
            this.CzeVote.Maximum = 2;
            this.CzeVote.Name = "CzeVote";
            this.CzeVote.Size = new System.Drawing.Size(201, 19);
            this.CzeVote.TabIndex = 12;
            this.CzeVote.Value = 2;
            // 
            // CypVote
            // 
            this.CypVote.AutoSize = false;
            this.CypVote.LargeChange = 1;
            this.CypVote.Location = new System.Drawing.Point(154, 122);
            this.CypVote.Maximum = 2;
            this.CypVote.Name = "CypVote";
            this.CypVote.Size = new System.Drawing.Size(201, 19);
            this.CypVote.TabIndex = 11;
            this.CypVote.Value = 2;
            // 
            // LatVote
            // 
            this.LatVote.AutoSize = false;
            this.LatVote.LargeChange = 1;
            this.LatVote.Location = new System.Drawing.Point(154, 331);
            this.LatVote.Maximum = 2;
            this.LatVote.Name = "LatVote";
            this.LatVote.Size = new System.Drawing.Size(201, 19);
            this.LatVote.TabIndex = 22;
            this.LatVote.Value = 2;
            // 
            // ItaVote
            // 
            this.ItaVote.AutoSize = false;
            this.ItaVote.LargeChange = 1;
            this.ItaVote.Location = new System.Drawing.Point(154, 312);
            this.ItaVote.Maximum = 2;
            this.ItaVote.Name = "ItaVote";
            this.ItaVote.Size = new System.Drawing.Size(201, 19);
            this.ItaVote.TabIndex = 21;
            this.ItaVote.Value = 2;
            // 
            // IreVote
            // 
            this.IreVote.AutoSize = false;
            this.IreVote.LargeChange = 1;
            this.IreVote.Location = new System.Drawing.Point(154, 293);
            this.IreVote.Maximum = 2;
            this.IreVote.Name = "IreVote";
            this.IreVote.Size = new System.Drawing.Size(201, 19);
            this.IreVote.TabIndex = 20;
            this.IreVote.Value = 2;
            // 
            // HunVote
            // 
            this.HunVote.AutoSize = false;
            this.HunVote.LargeChange = 1;
            this.HunVote.Location = new System.Drawing.Point(154, 274);
            this.HunVote.Maximum = 2;
            this.HunVote.Name = "HunVote";
            this.HunVote.Size = new System.Drawing.Size(201, 19);
            this.HunVote.TabIndex = 19;
            this.HunVote.Value = 2;
            // 
            // GreVote
            // 
            this.GreVote.AutoSize = false;
            this.GreVote.LargeChange = 1;
            this.GreVote.Location = new System.Drawing.Point(154, 255);
            this.GreVote.Maximum = 2;
            this.GreVote.Name = "GreVote";
            this.GreVote.Size = new System.Drawing.Size(201, 19);
            this.GreVote.TabIndex = 18;
            this.GreVote.Value = 2;
            // 
            // GerVote
            // 
            this.GerVote.AutoSize = false;
            this.GerVote.LargeChange = 1;
            this.GerVote.Location = new System.Drawing.Point(154, 236);
            this.GerVote.Maximum = 2;
            this.GerVote.Name = "GerVote";
            this.GerVote.Size = new System.Drawing.Size(201, 19);
            this.GerVote.TabIndex = 17;
            this.GerVote.Value = 2;
            // 
            // FraVote
            // 
            this.FraVote.AutoSize = false;
            this.FraVote.LargeChange = 1;
            this.FraVote.Location = new System.Drawing.Point(154, 217);
            this.FraVote.Maximum = 2;
            this.FraVote.Name = "FraVote";
            this.FraVote.Size = new System.Drawing.Size(201, 19);
            this.FraVote.TabIndex = 16;
            this.FraVote.Value = 2;
            // 
            // FinVote
            // 
            this.FinVote.AutoSize = false;
            this.FinVote.LargeChange = 1;
            this.FinVote.Location = new System.Drawing.Point(154, 198);
            this.FinVote.Maximum = 2;
            this.FinVote.Name = "FinVote";
            this.FinVote.Size = new System.Drawing.Size(201, 19);
            this.FinVote.TabIndex = 15;
            this.FinVote.Value = 2;
            // 
            // SweVote
            // 
            this.SweVote.AutoSize = false;
            this.SweVote.LargeChange = 1;
            this.SweVote.Location = new System.Drawing.Point(154, 540);
            this.SweVote.Maximum = 2;
            this.SweVote.Name = "SweVote";
            this.SweVote.Size = new System.Drawing.Size(201, 19);
            this.SweVote.TabIndex = 33;
            this.SweVote.Value = 2;
            // 
            // SpaVote
            // 
            this.SpaVote.AutoSize = false;
            this.SpaVote.LargeChange = 1;
            this.SpaVote.Location = new System.Drawing.Point(154, 521);
            this.SpaVote.Maximum = 2;
            this.SpaVote.Name = "SpaVote";
            this.SpaVote.Size = new System.Drawing.Size(201, 19);
            this.SpaVote.TabIndex = 32;
            this.SpaVote.Value = 2;
            // 
            // SlnVote
            // 
            this.SlnVote.AutoSize = false;
            this.SlnVote.LargeChange = 1;
            this.SlnVote.Location = new System.Drawing.Point(154, 502);
            this.SlnVote.Maximum = 2;
            this.SlnVote.Name = "SlnVote";
            this.SlnVote.Size = new System.Drawing.Size(201, 19);
            this.SlnVote.TabIndex = 31;
            this.SlnVote.Value = 2;
            // 
            // SlkVote
            // 
            this.SlkVote.AutoSize = false;
            this.SlkVote.LargeChange = 1;
            this.SlkVote.Location = new System.Drawing.Point(154, 483);
            this.SlkVote.Maximum = 2;
            this.SlkVote.Name = "SlkVote";
            this.SlkVote.Size = new System.Drawing.Size(201, 19);
            this.SlkVote.TabIndex = 30;
            this.SlkVote.Value = 2;
            // 
            // RomVote
            // 
            this.RomVote.AutoSize = false;
            this.RomVote.LargeChange = 1;
            this.RomVote.Location = new System.Drawing.Point(154, 464);
            this.RomVote.Maximum = 2;
            this.RomVote.Name = "RomVote";
            this.RomVote.Size = new System.Drawing.Size(201, 19);
            this.RomVote.TabIndex = 29;
            this.RomVote.Value = 2;
            // 
            // PorVote
            // 
            this.PorVote.AutoSize = false;
            this.PorVote.LargeChange = 1;
            this.PorVote.Location = new System.Drawing.Point(154, 445);
            this.PorVote.Maximum = 2;
            this.PorVote.Name = "PorVote";
            this.PorVote.Size = new System.Drawing.Size(201, 19);
            this.PorVote.TabIndex = 28;
            this.PorVote.Value = 2;
            // 
            // PolVote
            // 
            this.PolVote.AutoSize = false;
            this.PolVote.LargeChange = 1;
            this.PolVote.Location = new System.Drawing.Point(154, 426);
            this.PolVote.Maximum = 2;
            this.PolVote.Name = "PolVote";
            this.PolVote.Size = new System.Drawing.Size(201, 19);
            this.PolVote.TabIndex = 27;
            this.PolVote.Value = 2;
            // 
            // NetVote
            // 
            this.NetVote.AutoSize = false;
            this.NetVote.LargeChange = 1;
            this.NetVote.Location = new System.Drawing.Point(154, 407);
            this.NetVote.Maximum = 2;
            this.NetVote.Name = "NetVote";
            this.NetVote.Size = new System.Drawing.Size(201, 19);
            this.NetVote.TabIndex = 26;
            this.NetVote.Value = 2;
            // 
            // MalVote
            // 
            this.MalVote.AutoSize = false;
            this.MalVote.LargeChange = 1;
            this.MalVote.Location = new System.Drawing.Point(154, 388);
            this.MalVote.Maximum = 2;
            this.MalVote.Name = "MalVote";
            this.MalVote.Size = new System.Drawing.Size(201, 19);
            this.MalVote.TabIndex = 25;
            this.MalVote.Value = 2;
            // 
            // LuxVote
            // 
            this.LuxVote.AutoSize = false;
            this.LuxVote.LargeChange = 1;
            this.LuxVote.Location = new System.Drawing.Point(154, 369);
            this.LuxVote.Maximum = 2;
            this.LuxVote.Name = "LuxVote";
            this.LuxVote.Size = new System.Drawing.Size(201, 19);
            this.LuxVote.TabIndex = 24;
            this.LuxVote.Value = 2;
            // 
            // LitVote
            // 
            this.LitVote.AutoSize = false;
            this.LitVote.LargeChange = 1;
            this.LitVote.Location = new System.Drawing.Point(154, 350);
            this.LitVote.Maximum = 2;
            this.LitVote.Name = "LitVote";
            this.LitVote.Size = new System.Drawing.Size(201, 19);
            this.LitVote.TabIndex = 23;
            this.LitVote.Value = 2;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(670, 103);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 34;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ParticipatingStates
            // 
            this.ParticipatingStates.AutoSize = true;
            this.ParticipatingStates.Location = new System.Drawing.Point(667, 129);
            this.ParticipatingStates.Name = "ParticipatingStates";
            this.ParticipatingStates.Size = new System.Drawing.Size(35, 13);
            this.ParticipatingStates.TabIndex = 35;
            this.ParticipatingStates.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Participating States:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Abstain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Yes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParticipatingStates);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SweVote);
            this.Controls.Add(this.SpaVote);
            this.Controls.Add(this.SlnVote);
            this.Controls.Add(this.SlkVote);
            this.Controls.Add(this.RomVote);
            this.Controls.Add(this.PorVote);
            this.Controls.Add(this.PolVote);
            this.Controls.Add(this.NetVote);
            this.Controls.Add(this.MalVote);
            this.Controls.Add(this.LuxVote);
            this.Controls.Add(this.LitVote);
            this.Controls.Add(this.LatVote);
            this.Controls.Add(this.ItaVote);
            this.Controls.Add(this.IreVote);
            this.Controls.Add(this.HunVote);
            this.Controls.Add(this.GreVote);
            this.Controls.Add(this.GerVote);
            this.Controls.Add(this.FraVote);
            this.Controls.Add(this.FinVote);
            this.Controls.Add(this.EstVote);
            this.Controls.Add(this.DenVote);
            this.Controls.Add(this.CzeVote);
            this.Controls.Add(this.CypVote);
            this.Controls.Add(this.CroVote);
            this.Controls.Add(this.BulVote);
            this.Controls.Add(this.BelVote);
            this.Controls.Add(this.AusVote);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.MemberStatesVote);
            this.Controls.Add(this.CountriesList);
            this.Controls.Add(this.AllCountries);
            this.Controls.Add(this.EurozoneOnly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AusVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CroVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DenVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CzeVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CypVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItaVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IreVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HunVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GerVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FraVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlnVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlkVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuxVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LitVote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EurozoneOnly;
        private System.Windows.Forms.CheckBox AllCountries;
        private System.Windows.Forms.CheckedListBox CountriesList;
        private System.Windows.Forms.ProgressBar MemberStatesVote;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TrackBar AusVote;
        private System.Windows.Forms.TrackBar BelVote;
        private System.Windows.Forms.TrackBar CroVote;
        private System.Windows.Forms.TrackBar BulVote;
        private System.Windows.Forms.TrackBar EstVote;
        private System.Windows.Forms.TrackBar DenVote;
        private System.Windows.Forms.TrackBar CzeVote;
        private System.Windows.Forms.TrackBar CypVote;
        private System.Windows.Forms.TrackBar LatVote;
        private System.Windows.Forms.TrackBar ItaVote;
        private System.Windows.Forms.TrackBar IreVote;
        private System.Windows.Forms.TrackBar HunVote;
        private System.Windows.Forms.TrackBar GreVote;
        private System.Windows.Forms.TrackBar GerVote;
        private System.Windows.Forms.TrackBar FraVote;
        private System.Windows.Forms.TrackBar FinVote;
        private System.Windows.Forms.TrackBar SweVote;
        private System.Windows.Forms.TrackBar SpaVote;
        private System.Windows.Forms.TrackBar SlnVote;
        private System.Windows.Forms.TrackBar SlkVote;
        private System.Windows.Forms.TrackBar RomVote;
        private System.Windows.Forms.TrackBar PorVote;
        private System.Windows.Forms.TrackBar PolVote;
        private System.Windows.Forms.TrackBar NetVote;
        private System.Windows.Forms.TrackBar MalVote;
        private System.Windows.Forms.TrackBar LuxVote;
        private System.Windows.Forms.TrackBar LitVote;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ParticipatingStates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

