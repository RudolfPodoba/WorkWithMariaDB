namespace WorkWithMariaDB
{
    partial class PracaSMariaDb
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
            this.btn_NacitajPodlaId = new System.Windows.Forms.Button();
            this.lb_Zoznam = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_IdU = new System.Windows.Forms.TextBox();
            this.btn_NacitajZoznam = new System.Windows.Forms.Button();
            this.btn_Vloz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_MenoI = new System.Windows.Forms.TextBox();
            this.txb_PopisI = new System.Windows.Forms.TextBox();
            this.txb_StatusI = new System.Windows.Forms.TextBox();
            this.gb_Insert = new System.Windows.Forms.GroupBox();
            this.gb_SelectUpdate = new System.Windows.Forms.GroupBox();
            this.btn_Aktualizuj = new System.Windows.Forms.Button();
            this.txb_StatusU = new System.Windows.Forms.TextBox();
            this.txb_PopisU = new System.Windows.Forms.TextBox();
            this.txb_MenoU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_SelectZoznam = new System.Windows.Forms.GroupBox();
            this.gb_Delete = new System.Windows.Forms.GroupBox();
            this.btn_Vymaz = new System.Windows.Forms.Button();
            this.txb_IdD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_Insert.SuspendLayout();
            this.gb_SelectUpdate.SuspendLayout();
            this.gb_SelectZoznam.SuspendLayout();
            this.gb_Delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NacitajPodlaId
            // 
            this.btn_NacitajPodlaId.Location = new System.Drawing.Point(58, 45);
            this.btn_NacitajPodlaId.Name = "btn_NacitajPodlaId";
            this.btn_NacitajPodlaId.Size = new System.Drawing.Size(100, 23);
            this.btn_NacitajPodlaId.TabIndex = 0;
            this.btn_NacitajPodlaId.Text = "Načítaj podľa ID";
            this.btn_NacitajPodlaId.UseVisualStyleBackColor = true;
            this.btn_NacitajPodlaId.Click += new System.EventHandler(this.btn_NacitajPodlaId_Click);
            // 
            // lb_Zoznam
            // 
            this.lb_Zoznam.FormattingEnabled = true;
            this.lb_Zoznam.Location = new System.Drawing.Point(6, 45);
            this.lb_Zoznam.Name = "lb_Zoznam";
            this.lb_Zoznam.Size = new System.Drawing.Size(269, 69);
            this.lb_Zoznam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadaj ID:";
            // 
            // txb_IdU
            // 
            this.txb_IdU.Location = new System.Drawing.Point(58, 19);
            this.txb_IdU.Name = "txb_IdU";
            this.txb_IdU.Size = new System.Drawing.Size(100, 20);
            this.txb_IdU.TabIndex = 3;
            // 
            // btn_NacitajZoznam
            // 
            this.btn_NacitajZoznam.Location = new System.Drawing.Point(6, 16);
            this.btn_NacitajZoznam.Name = "btn_NacitajZoznam";
            this.btn_NacitajZoznam.Size = new System.Drawing.Size(102, 23);
            this.btn_NacitajZoznam.TabIndex = 4;
            this.btn_NacitajZoznam.Text = "Načítaj zoznam";
            this.btn_NacitajZoznam.UseVisualStyleBackColor = true;
            this.btn_NacitajZoznam.Click += new System.EventHandler(this.btn_NacitajZoznam_Click);
            // 
            // btn_Vloz
            // 
            this.btn_Vloz.Location = new System.Drawing.Point(69, 97);
            this.btn_Vloz.Name = "btn_Vloz";
            this.btn_Vloz.Size = new System.Drawing.Size(75, 23);
            this.btn_Vloz.TabIndex = 5;
            this.btn_Vloz.Text = "Vlož";
            this.btn_Vloz.UseVisualStyleBackColor = true;
            this.btn_Vloz.Click += new System.EventHandler(this.btn_Vloz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Meno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Popis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // txb_MenoI
            // 
            this.txb_MenoI.Location = new System.Drawing.Point(58, 19);
            this.txb_MenoI.Name = "txb_MenoI";
            this.txb_MenoI.Size = new System.Drawing.Size(100, 20);
            this.txb_MenoI.TabIndex = 9;
            // 
            // txb_PopisI
            // 
            this.txb_PopisI.Location = new System.Drawing.Point(58, 45);
            this.txb_PopisI.Name = "txb_PopisI";
            this.txb_PopisI.Size = new System.Drawing.Size(100, 20);
            this.txb_PopisI.TabIndex = 10;
            // 
            // txb_StatusI
            // 
            this.txb_StatusI.Location = new System.Drawing.Point(58, 71);
            this.txb_StatusI.Name = "txb_StatusI";
            this.txb_StatusI.Size = new System.Drawing.Size(100, 20);
            this.txb_StatusI.TabIndex = 11;
            // 
            // gb_Insert
            // 
            this.gb_Insert.Controls.Add(this.btn_Vloz);
            this.gb_Insert.Controls.Add(this.txb_StatusI);
            this.gb_Insert.Controls.Add(this.label2);
            this.gb_Insert.Controls.Add(this.txb_PopisI);
            this.gb_Insert.Controls.Add(this.label3);
            this.gb_Insert.Controls.Add(this.txb_MenoI);
            this.gb_Insert.Controls.Add(this.label4);
            this.gb_Insert.Location = new System.Drawing.Point(12, 12);
            this.gb_Insert.Name = "gb_Insert";
            this.gb_Insert.Size = new System.Drawing.Size(168, 128);
            this.gb_Insert.TabIndex = 12;
            this.gb_Insert.TabStop = false;
            this.gb_Insert.Text = "INSERT";
            // 
            // gb_SelectUpdate
            // 
            this.gb_SelectUpdate.Controls.Add(this.btn_Aktualizuj);
            this.gb_SelectUpdate.Controls.Add(this.txb_StatusU);
            this.gb_SelectUpdate.Controls.Add(this.txb_PopisU);
            this.gb_SelectUpdate.Controls.Add(this.txb_MenoU);
            this.gb_SelectUpdate.Controls.Add(this.label7);
            this.gb_SelectUpdate.Controls.Add(this.label6);
            this.gb_SelectUpdate.Controls.Add(this.label5);
            this.gb_SelectUpdate.Controls.Add(this.btn_NacitajPodlaId);
            this.gb_SelectUpdate.Controls.Add(this.label1);
            this.gb_SelectUpdate.Controls.Add(this.txb_IdU);
            this.gb_SelectUpdate.Location = new System.Drawing.Point(12, 146);
            this.gb_SelectUpdate.Name = "gb_SelectUpdate";
            this.gb_SelectUpdate.Size = new System.Drawing.Size(168, 199);
            this.gb_SelectUpdate.TabIndex = 13;
            this.gb_SelectUpdate.TabStop = false;
            this.gb_SelectUpdate.Text = "SELECT podľa ID a UPDATE";
            // 
            // btn_Aktualizuj
            // 
            this.btn_Aktualizuj.Location = new System.Drawing.Point(69, 168);
            this.btn_Aktualizuj.Name = "btn_Aktualizuj";
            this.btn_Aktualizuj.Size = new System.Drawing.Size(75, 23);
            this.btn_Aktualizuj.TabIndex = 10;
            this.btn_Aktualizuj.Text = "Aktualizuj";
            this.btn_Aktualizuj.UseVisualStyleBackColor = true;
            this.btn_Aktualizuj.Click += new System.EventHandler(this.btn_Aktualizuj_Click);
            // 
            // txb_StatusU
            // 
            this.txb_StatusU.Location = new System.Drawing.Point(58, 142);
            this.txb_StatusU.Name = "txb_StatusU";
            this.txb_StatusU.Size = new System.Drawing.Size(100, 20);
            this.txb_StatusU.TabIndex = 9;
            // 
            // txb_PopisU
            // 
            this.txb_PopisU.Location = new System.Drawing.Point(58, 116);
            this.txb_PopisU.Name = "txb_PopisU";
            this.txb_PopisU.Size = new System.Drawing.Size(100, 20);
            this.txb_PopisU.TabIndex = 8;
            // 
            // txb_MenoU
            // 
            this.txb_MenoU.Location = new System.Drawing.Point(58, 90);
            this.txb_MenoU.Name = "txb_MenoU";
            this.txb_MenoU.Size = new System.Drawing.Size(100, 20);
            this.txb_MenoU.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Popis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Meno:";
            // 
            // gb_SelectZoznam
            // 
            this.gb_SelectZoznam.Controls.Add(this.lb_Zoznam);
            this.gb_SelectZoznam.Controls.Add(this.btn_NacitajZoznam);
            this.gb_SelectZoznam.Location = new System.Drawing.Point(186, 12);
            this.gb_SelectZoznam.Name = "gb_SelectZoznam";
            this.gb_SelectZoznam.Size = new System.Drawing.Size(281, 128);
            this.gb_SelectZoznam.TabIndex = 14;
            this.gb_SelectZoznam.TabStop = false;
            this.gb_SelectZoznam.Text = "SELECT zoznam";
            // 
            // gb_Delete
            // 
            this.gb_Delete.Controls.Add(this.btn_Vymaz);
            this.gb_Delete.Controls.Add(this.txb_IdD);
            this.gb_Delete.Controls.Add(this.label8);
            this.gb_Delete.Location = new System.Drawing.Point(186, 146);
            this.gb_Delete.Name = "gb_Delete";
            this.gb_Delete.Size = new System.Drawing.Size(172, 79);
            this.gb_Delete.TabIndex = 15;
            this.gb_Delete.TabStop = false;
            this.gb_Delete.Text = "DELETE podľa ID";
            // 
            // btn_Vymaz
            // 
            this.btn_Vymaz.Location = new System.Drawing.Point(60, 45);
            this.btn_Vymaz.Name = "btn_Vymaz";
            this.btn_Vymaz.Size = new System.Drawing.Size(100, 23);
            this.btn_Vymaz.TabIndex = 2;
            this.btn_Vymaz.Text = "Vymaž podľa ID";
            this.btn_Vymaz.UseVisualStyleBackColor = true;
            this.btn_Vymaz.Click += new System.EventHandler(this.btn_Vymaz_Click);
            // 
            // txb_IdD
            // 
            this.txb_IdD.Location = new System.Drawing.Point(60, 20);
            this.txb_IdD.Name = "txb_IdD";
            this.txb_IdD.Size = new System.Drawing.Size(100, 20);
            this.txb_IdD.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Zadaj ID:";
            // 
            // PracaSMariaDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 349);
            this.Controls.Add(this.gb_Delete);
            this.Controls.Add(this.gb_SelectZoznam);
            this.Controls.Add(this.gb_SelectUpdate);
            this.Controls.Add(this.gb_Insert);
            this.Name = "PracaSMariaDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práca s MariaDB";
            this.gb_Insert.ResumeLayout(false);
            this.gb_Insert.PerformLayout();
            this.gb_SelectUpdate.ResumeLayout(false);
            this.gb_SelectUpdate.PerformLayout();
            this.gb_SelectZoznam.ResumeLayout(false);
            this.gb_Delete.ResumeLayout(false);
            this.gb_Delete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NacitajPodlaId;
        private System.Windows.Forms.ListBox lb_Zoznam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_IdU;
        private System.Windows.Forms.Button btn_NacitajZoznam;
        private System.Windows.Forms.Button btn_Vloz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_MenoI;
        private System.Windows.Forms.TextBox txb_PopisI;
        private System.Windows.Forms.TextBox txb_StatusI;
        private System.Windows.Forms.GroupBox gb_Insert;
        private System.Windows.Forms.GroupBox gb_SelectUpdate;
        private System.Windows.Forms.TextBox txb_StatusU;
        private System.Windows.Forms.TextBox txb_PopisU;
        private System.Windows.Forms.TextBox txb_MenoU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Aktualizuj;
        private System.Windows.Forms.GroupBox gb_SelectZoznam;
        private System.Windows.Forms.GroupBox gb_Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Vymaz;
        private System.Windows.Forms.TextBox txb_IdD;
    }
}

