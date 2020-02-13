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
            this.ParticipatingStates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CountriesYes = new System.Windows.Forms.Label();
            this.CountriesNo = new System.Windows.Forms.Label();
            this.CountriesAbstain = new System.Windows.Forms.Label();
            this.VoteYesNumber = new System.Windows.Forms.Label();
            this.VoteNoNumber = new System.Windows.Forms.Label();
            this.VoteAbstainNumber = new System.Windows.Forms.Label();
            this.PassedFailed = new System.Windows.Forms.Label();
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
            this.CountriesList.Location = new System.Drawing.Point(5, 36);
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.Size = new System.Drawing.Size(143, 517);
            this.CountriesList.TabIndex = 4;
            this.CountriesList.TabStop = false;
            this.CountriesList.SelectedIndexChanged += new System.EventHandler(this.CountriesList_SelectedIndexChanged);
            // 
            // MemberStatesVote
            // 
            this.MemberStatesVote.Location = new System.Drawing.Point(670, 145);
            this.MemberStatesVote.MarqueeAnimationSpeed = 0;
            this.MemberStatesVote.Maximum = 0;
            this.MemberStatesVote.Name = "MemberStatesVote";
            this.MemberStatesVote.Size = new System.Drawing.Size(118, 23);
            this.MemberStatesVote.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MemberStatesVote.TabIndex = 5;
            // 
            // AusVote
            // 
            this.AusVote.AutoSize = false;
            this.AusVote.LargeChange = 1;
            this.AusVote.Location = new System.Drawing.Point(154, 41);
            this.AusVote.Maximum = 2;
            this.AusVote.Name = "AusVote";
            this.AusVote.Size = new System.Drawing.Size(201, 18);
            this.AusVote.TabIndex = 7;
            this.AusVote.Value = 2;
            this.AusVote.Scroll += new System.EventHandler(this.AusVote_Scroll);
            // 
            // BelVote
            // 
            this.BelVote.AutoSize = false;
            this.BelVote.LargeChange = 1;
            this.BelVote.Location = new System.Drawing.Point(154, 60);
            this.BelVote.Maximum = 2;
            this.BelVote.Name = "BelVote";
            this.BelVote.Size = new System.Drawing.Size(201, 18);
            this.BelVote.TabIndex = 8;
            this.BelVote.Value = 2;
            this.BelVote.Scroll += new System.EventHandler(this.BelVote_Scroll);
            // 
            // CroVote
            // 
            this.CroVote.AutoSize = false;
            this.CroVote.LargeChange = 1;
            this.CroVote.Location = new System.Drawing.Point(154, 98);
            this.CroVote.Maximum = 2;
            this.CroVote.Name = "CroVote";
            this.CroVote.Size = new System.Drawing.Size(201, 18);
            this.CroVote.TabIndex = 10;
            this.CroVote.Value = 2;
            this.CroVote.Scroll += new System.EventHandler(this.CroVote_Scroll);
            // 
            // BulVote
            // 
            this.BulVote.AutoSize = false;
            this.BulVote.LargeChange = 1;
            this.BulVote.Location = new System.Drawing.Point(154, 79);
            this.BulVote.Maximum = 2;
            this.BulVote.Name = "BulVote";
            this.BulVote.Size = new System.Drawing.Size(201, 18);
            this.BulVote.TabIndex = 9;
            this.BulVote.Value = 2;
            this.BulVote.Scroll += new System.EventHandler(this.BulVote_Scroll);
            // 
            // EstVote
            // 
            this.EstVote.AutoSize = false;
            this.EstVote.LargeChange = 1;
            this.EstVote.Location = new System.Drawing.Point(154, 174);
            this.EstVote.Maximum = 2;
            this.EstVote.Name = "EstVote";
            this.EstVote.Size = new System.Drawing.Size(201, 18);
            this.EstVote.TabIndex = 14;
            this.EstVote.Value = 2;
            this.EstVote.Scroll += new System.EventHandler(this.EstVote_Scroll);
            // 
            // DenVote
            // 
            this.DenVote.AutoSize = false;
            this.DenVote.LargeChange = 1;
            this.DenVote.Location = new System.Drawing.Point(154, 155);
            this.DenVote.Maximum = 2;
            this.DenVote.Name = "DenVote";
            this.DenVote.Size = new System.Drawing.Size(201, 18);
            this.DenVote.TabIndex = 13;
            this.DenVote.Value = 2;
            this.DenVote.Scroll += new System.EventHandler(this.DenVote_Scroll);
            // 
            // CzeVote
            // 
            this.CzeVote.AutoSize = false;
            this.CzeVote.LargeChange = 1;
            this.CzeVote.Location = new System.Drawing.Point(154, 136);
            this.CzeVote.Maximum = 2;
            this.CzeVote.Name = "CzeVote";
            this.CzeVote.Size = new System.Drawing.Size(201, 18);
            this.CzeVote.TabIndex = 12;
            this.CzeVote.Value = 2;
            this.CzeVote.Scroll += new System.EventHandler(this.CzeVote_Scroll);
            // 
            // CypVote
            // 
            this.CypVote.AutoSize = false;
            this.CypVote.LargeChange = 1;
            this.CypVote.Location = new System.Drawing.Point(154, 117);
            this.CypVote.Maximum = 2;
            this.CypVote.Name = "CypVote";
            this.CypVote.Size = new System.Drawing.Size(201, 18);
            this.CypVote.TabIndex = 11;
            this.CypVote.Value = 2;
            this.CypVote.Scroll += new System.EventHandler(this.CypVote_Scroll);
            // 
            // LatVote
            // 
            this.LatVote.AutoSize = false;
            this.LatVote.LargeChange = 1;
            this.LatVote.Location = new System.Drawing.Point(154, 326);
            this.LatVote.Maximum = 2;
            this.LatVote.Name = "LatVote";
            this.LatVote.Size = new System.Drawing.Size(201, 18);
            this.LatVote.TabIndex = 22;
            this.LatVote.Value = 2;
            this.LatVote.Scroll += new System.EventHandler(this.LatVote_Scroll);
            // 
            // ItaVote
            // 
            this.ItaVote.AutoSize = false;
            this.ItaVote.LargeChange = 1;
            this.ItaVote.Location = new System.Drawing.Point(154, 307);
            this.ItaVote.Maximum = 2;
            this.ItaVote.Name = "ItaVote";
            this.ItaVote.Size = new System.Drawing.Size(201, 18);
            this.ItaVote.TabIndex = 21;
            this.ItaVote.Value = 2;
            this.ItaVote.Scroll += new System.EventHandler(this.ItaVote_Scroll);
            // 
            // IreVote
            // 
            this.IreVote.AutoSize = false;
            this.IreVote.LargeChange = 1;
            this.IreVote.Location = new System.Drawing.Point(154, 288);
            this.IreVote.Maximum = 2;
            this.IreVote.Name = "IreVote";
            this.IreVote.Size = new System.Drawing.Size(201, 18);
            this.IreVote.TabIndex = 20;
            this.IreVote.Value = 2;
            this.IreVote.Scroll += new System.EventHandler(this.IreVote_Scroll);
            // 
            // HunVote
            // 
            this.HunVote.AutoSize = false;
            this.HunVote.LargeChange = 1;
            this.HunVote.Location = new System.Drawing.Point(154, 269);
            this.HunVote.Maximum = 2;
            this.HunVote.Name = "HunVote";
            this.HunVote.Size = new System.Drawing.Size(201, 18);
            this.HunVote.TabIndex = 19;
            this.HunVote.Value = 2;
            this.HunVote.Scroll += new System.EventHandler(this.HunVote_Scroll);
            // 
            // GreVote
            // 
            this.GreVote.AutoSize = false;
            this.GreVote.LargeChange = 1;
            this.GreVote.Location = new System.Drawing.Point(154, 250);
            this.GreVote.Maximum = 2;
            this.GreVote.Name = "GreVote";
            this.GreVote.Size = new System.Drawing.Size(201, 18);
            this.GreVote.TabIndex = 18;
            this.GreVote.Value = 2;
            this.GreVote.Scroll += new System.EventHandler(this.GreVote_Scroll);
            // 
            // GerVote
            // 
            this.GerVote.AutoSize = false;
            this.GerVote.LargeChange = 1;
            this.GerVote.Location = new System.Drawing.Point(154, 231);
            this.GerVote.Maximum = 2;
            this.GerVote.Name = "GerVote";
            this.GerVote.Size = new System.Drawing.Size(201, 18);
            this.GerVote.TabIndex = 17;
            this.GerVote.Value = 2;
            this.GerVote.Scroll += new System.EventHandler(this.GerVote_Scroll);
            // 
            // FraVote
            // 
            this.FraVote.AutoSize = false;
            this.FraVote.LargeChange = 1;
            this.FraVote.Location = new System.Drawing.Point(154, 212);
            this.FraVote.Maximum = 2;
            this.FraVote.Name = "FraVote";
            this.FraVote.Size = new System.Drawing.Size(201, 18);
            this.FraVote.TabIndex = 16;
            this.FraVote.Value = 2;
            this.FraVote.Scroll += new System.EventHandler(this.FraVote_Scroll);
            // 
            // FinVote
            // 
            this.FinVote.AutoSize = false;
            this.FinVote.LargeChange = 1;
            this.FinVote.Location = new System.Drawing.Point(154, 193);
            this.FinVote.Maximum = 2;
            this.FinVote.Name = "FinVote";
            this.FinVote.Size = new System.Drawing.Size(201, 18);
            this.FinVote.TabIndex = 15;
            this.FinVote.Value = 2;
            this.FinVote.Scroll += new System.EventHandler(this.FinVote_Scroll);
            // 
            // SweVote
            // 
            this.SweVote.AutoSize = false;
            this.SweVote.LargeChange = 1;
            this.SweVote.Location = new System.Drawing.Point(154, 535);
            this.SweVote.Maximum = 2;
            this.SweVote.Name = "SweVote";
            this.SweVote.Size = new System.Drawing.Size(201, 18);
            this.SweVote.TabIndex = 33;
            this.SweVote.Value = 2;
            this.SweVote.Scroll += new System.EventHandler(this.SweVote_Scroll);
            // 
            // SpaVote
            // 
            this.SpaVote.AutoSize = false;
            this.SpaVote.LargeChange = 1;
            this.SpaVote.Location = new System.Drawing.Point(154, 516);
            this.SpaVote.Maximum = 2;
            this.SpaVote.Name = "SpaVote";
            this.SpaVote.Size = new System.Drawing.Size(201, 18);
            this.SpaVote.TabIndex = 32;
            this.SpaVote.Value = 2;
            this.SpaVote.Scroll += new System.EventHandler(this.SpaVote_Scroll);
            // 
            // SlnVote
            // 
            this.SlnVote.AutoSize = false;
            this.SlnVote.LargeChange = 1;
            this.SlnVote.Location = new System.Drawing.Point(154, 497);
            this.SlnVote.Maximum = 2;
            this.SlnVote.Name = "SlnVote";
            this.SlnVote.Size = new System.Drawing.Size(201, 18);
            this.SlnVote.TabIndex = 31;
            this.SlnVote.Value = 2;
            this.SlnVote.Scroll += new System.EventHandler(this.SlnVote_Scroll);
            // 
            // SlkVote
            // 
            this.SlkVote.AutoSize = false;
            this.SlkVote.LargeChange = 1;
            this.SlkVote.Location = new System.Drawing.Point(154, 478);
            this.SlkVote.Maximum = 2;
            this.SlkVote.Name = "SlkVote";
            this.SlkVote.Size = new System.Drawing.Size(201, 18);
            this.SlkVote.TabIndex = 30;
            this.SlkVote.Value = 2;
            this.SlkVote.Scroll += new System.EventHandler(this.SlkVote_Scroll);
            // 
            // RomVote
            // 
            this.RomVote.AutoSize = false;
            this.RomVote.LargeChange = 1;
            this.RomVote.Location = new System.Drawing.Point(154, 459);
            this.RomVote.Maximum = 2;
            this.RomVote.Name = "RomVote";
            this.RomVote.Size = new System.Drawing.Size(201, 18);
            this.RomVote.TabIndex = 29;
            this.RomVote.Value = 2;
            this.RomVote.Scroll += new System.EventHandler(this.RomVote_Scroll);
            // 
            // PorVote
            // 
            this.PorVote.AutoSize = false;
            this.PorVote.LargeChange = 1;
            this.PorVote.Location = new System.Drawing.Point(154, 440);
            this.PorVote.Maximum = 2;
            this.PorVote.Name = "PorVote";
            this.PorVote.Size = new System.Drawing.Size(201, 18);
            this.PorVote.TabIndex = 28;
            this.PorVote.Value = 2;
            this.PorVote.Scroll += new System.EventHandler(this.PorVote_Scroll);
            // 
            // PolVote
            // 
            this.PolVote.AutoSize = false;
            this.PolVote.LargeChange = 1;
            this.PolVote.Location = new System.Drawing.Point(154, 421);
            this.PolVote.Maximum = 2;
            this.PolVote.Name = "PolVote";
            this.PolVote.Size = new System.Drawing.Size(201, 18);
            this.PolVote.TabIndex = 27;
            this.PolVote.Value = 2;
            this.PolVote.Scroll += new System.EventHandler(this.PolVote_Scroll);
            // 
            // NetVote
            // 
            this.NetVote.AutoSize = false;
            this.NetVote.LargeChange = 1;
            this.NetVote.Location = new System.Drawing.Point(154, 402);
            this.NetVote.Maximum = 2;
            this.NetVote.Name = "NetVote";
            this.NetVote.Size = new System.Drawing.Size(201, 18);
            this.NetVote.TabIndex = 26;
            this.NetVote.Value = 2;
            this.NetVote.Scroll += new System.EventHandler(this.NetVote_Scroll);
            // 
            // MalVote
            // 
            this.MalVote.AutoSize = false;
            this.MalVote.LargeChange = 1;
            this.MalVote.Location = new System.Drawing.Point(154, 383);
            this.MalVote.Maximum = 2;
            this.MalVote.Name = "MalVote";
            this.MalVote.Size = new System.Drawing.Size(201, 18);
            this.MalVote.TabIndex = 25;
            this.MalVote.Value = 2;
            this.MalVote.Scroll += new System.EventHandler(this.MalVote_Scroll);
            // 
            // LuxVote
            // 
            this.LuxVote.AutoSize = false;
            this.LuxVote.LargeChange = 1;
            this.LuxVote.Location = new System.Drawing.Point(154, 364);
            this.LuxVote.Maximum = 2;
            this.LuxVote.Name = "LuxVote";
            this.LuxVote.Size = new System.Drawing.Size(201, 18);
            this.LuxVote.TabIndex = 24;
            this.LuxVote.Value = 2;
            this.LuxVote.Scroll += new System.EventHandler(this.LuxVote_Scroll);
            // 
            // LitVote
            // 
            this.LitVote.AutoSize = false;
            this.LitVote.LargeChange = 1;
            this.LitVote.Location = new System.Drawing.Point(154, 345);
            this.LitVote.Maximum = 2;
            this.LitVote.Name = "LitVote";
            this.LitVote.Size = new System.Drawing.Size(201, 18);
            this.LitVote.TabIndex = 23;
            this.LitVote.Value = 2;
            this.LitVote.Scroll += new System.EventHandler(this.LitVote_Scroll);
            // 
            // ParticipatingStates
            // 
            this.ParticipatingStates.AutoSize = true;
            this.ParticipatingStates.Location = new System.Drawing.Point(667, 129);
            this.ParticipatingStates.Name = "ParticipatingStates";
            this.ParticipatingStates.Size = new System.Drawing.Size(27, 13);
            this.ParticipatingStates.TabIndex = 35;
            this.ParticipatingStates.Text = "N/A";
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
            this.label2.Location = new System.Drawing.Point(151, 26);
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
            this.label4.Location = new System.Drawing.Point(332, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Yes";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Qualified majority",
            "Reinforced qualified majority",
            "Simple Majority",
            "Unanimity"});
            this.comboBox1.Location = new System.Drawing.Point(667, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // CountriesYes
            // 
            this.CountriesYes.AutoSize = true;
            this.CountriesYes.Location = new System.Drawing.Point(667, 198);
            this.CountriesYes.Name = "CountriesYes";
            this.CountriesYes.Size = new System.Drawing.Size(25, 13);
            this.CountriesYes.TabIndex = 41;
            this.CountriesYes.Text = "Yes";
            // 
            // CountriesNo
            // 
            this.CountriesNo.AutoSize = true;
            this.CountriesNo.Location = new System.Drawing.Point(709, 198);
            this.CountriesNo.Name = "CountriesNo";
            this.CountriesNo.Size = new System.Drawing.Size(21, 13);
            this.CountriesNo.TabIndex = 42;
            this.CountriesNo.Text = "No";
            // 
            // CountriesAbstain
            // 
            this.CountriesAbstain.AutoSize = true;
            this.CountriesAbstain.Location = new System.Drawing.Point(749, 198);
            this.CountriesAbstain.Name = "CountriesAbstain";
            this.CountriesAbstain.Size = new System.Drawing.Size(42, 13);
            this.CountriesAbstain.TabIndex = 43;
            this.CountriesAbstain.Text = "Abstain";
            // 
            // VoteYesNumber
            // 
            this.VoteYesNumber.AutoSize = true;
            this.VoteYesNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.VoteYesNumber.Location = new System.Drawing.Point(670, 175);
            this.VoteYesNumber.Name = "VoteYesNumber";
            this.VoteYesNumber.Size = new System.Drawing.Size(19, 13);
            this.VoteYesNumber.TabIndex = 44;
            this.VoteYesNumber.Text = "27";
            // 
            // VoteNoNumber
            // 
            this.VoteNoNumber.AutoSize = true;
            this.VoteNoNumber.ForeColor = System.Drawing.Color.Red;
            this.VoteNoNumber.Location = new System.Drawing.Point(713, 175);
            this.VoteNoNumber.Name = "VoteNoNumber";
            this.VoteNoNumber.Size = new System.Drawing.Size(13, 13);
            this.VoteNoNumber.TabIndex = 45;
            this.VoteNoNumber.Text = "0";
            // 
            // VoteAbstainNumber
            // 
            this.VoteAbstainNumber.AutoSize = true;
            this.VoteAbstainNumber.Location = new System.Drawing.Point(762, 175);
            this.VoteAbstainNumber.Name = "VoteAbstainNumber";
            this.VoteAbstainNumber.Size = new System.Drawing.Size(13, 13);
            this.VoteAbstainNumber.TabIndex = 46;
            this.VoteAbstainNumber.Text = "0";
            // 
            // PassedFailed
            // 
            this.PassedFailed.AutoSize = true;
            this.PassedFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.PassedFailed.Location = new System.Drawing.Point(674, 48);
            this.PassedFailed.Name = "PassedFailed";
            this.PassedFailed.Size = new System.Drawing.Size(114, 36);
            this.PassedFailed.TabIndex = 47;
            this.PassedFailed.Text = "Passed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 564);
            this.Controls.Add(this.PassedFailed);
            this.Controls.Add(this.VoteAbstainNumber);
            this.Controls.Add(this.VoteNoNumber);
            this.Controls.Add(this.VoteYesNumber);
            this.Controls.Add(this.CountriesAbstain);
            this.Controls.Add(this.CountriesNo);
            this.Controls.Add(this.CountriesYes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParticipatingStates);
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
            this.Controls.Add(this.MemberStatesVote);
            this.Controls.Add(this.CountriesList);
            this.Controls.Add(this.AllCountries);
            this.Controls.Add(this.EurozoneOnly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Label ParticipatingStates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CountriesYes;
        private System.Windows.Forms.Label CountriesNo;
        private System.Windows.Forms.Label CountriesAbstain;
        private System.Windows.Forms.Label VoteYesNumber;
        private System.Windows.Forms.Label VoteNoNumber;
        private System.Windows.Forms.Label VoteAbstainNumber;
        private System.Windows.Forms.Label PassedFailed;
    }
}

