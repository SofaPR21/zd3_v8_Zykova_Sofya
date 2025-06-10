
namespace zd3_v8_Zykova_Sofya
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEcoFriendly = new System.Windows.Forms.CheckBox();
            this.btnAddImproved = new System.Windows.Forms.Button();
            this.btnAddRegular = new System.Windows.Forms.Button();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsumption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveByVIN = new System.Windows.Forms.Button();
            this.txtVINToRemove = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(9, 10);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(722, 251);
            this.listBoxCars.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkEcoFriendly);
            this.groupBox1.Controls.Add(this.btnAddImproved);
            this.groupBox1.Controls.Add(this.btnAddRegular);
            this.groupBox1.Controls.Add(this.txtVIN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConsumption);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMileage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить машину";
            // 
            // chkEcoFriendly
            // 
            this.chkEcoFriendly.AutoSize = true;
            this.chkEcoFriendly.Location = new System.Drawing.Point(262, 106);
            this.chkEcoFriendly.Name = "chkEcoFriendly";
            this.chkEcoFriendly.Size = new System.Drawing.Size(148, 17);
            this.chkEcoFriendly.TabIndex = 12;
            this.chkEcoFriendly.Text = "Экологичный транспорт";
            this.chkEcoFriendly.UseVisualStyleBackColor = true;
            // 
            // btnAddImproved
            // 
            this.btnAddImproved.Location = new System.Drawing.Point(262, 65);
            this.btnAddImproved.Name = "btnAddImproved";
            this.btnAddImproved.Size = new System.Drawing.Size(183, 33);
            this.btnAddImproved.TabIndex = 11;
            this.btnAddImproved.Text = "Добавить улучшенную машину";
            this.btnAddImproved.UseVisualStyleBackColor = true;
            this.btnAddImproved.Click += new System.EventHandler(this.btnAddImproved_Click);
            // 
            // btnAddRegular
            // 
            this.btnAddRegular.Location = new System.Drawing.Point(262, 24);
            this.btnAddRegular.Name = "btnAddRegular";
            this.btnAddRegular.Size = new System.Drawing.Size(183, 33);
            this.btnAddRegular.TabIndex = 10;
            this.btnAddRegular.Text = "Добавить обычную машину";
            this.btnAddRegular.UseVisualStyleBackColor = true;
            this.btnAddRegular.Click += new System.EventHandler(this.btnAddRegular_Click);
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(93, 122);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(151, 20);
            this.txtVIN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "VIN:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(93, 97);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(151, 20);
            this.txtModel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Модель:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(93, 73);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(76, 20);
            this.txtYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год выпуска:";
            // 
            // txtConsumption
            // 
            this.txtConsumption.Location = new System.Drawing.Point(93, 49);
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.Size = new System.Drawing.Size(76, 20);
            this.txtConsumption.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Расход (л/км):";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(93, 24);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(76, 20);
            this.txtMileage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пробег:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRemoveByVIN);
            this.groupBox2.Controls.Add(this.txtVINToRemove);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnRemoveSelected);
            this.groupBox2.Location = new System.Drawing.Point(513, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удалить машину";
            // 
            // btnRemoveByVIN
            // 
            this.btnRemoveByVIN.Location = new System.Drawing.Point(15, 76);
            this.btnRemoveByVIN.Name = "btnRemoveByVIN";
            this.btnRemoveByVIN.Size = new System.Drawing.Size(188, 33);
            this.btnRemoveByVIN.TabIndex = 3;
            this.btnRemoveByVIN.Text = "Удалить по VIN";
            this.btnRemoveByVIN.UseVisualStyleBackColor = true;
            this.btnRemoveByVIN.Click += new System.EventHandler(this.btnRemoveByVIN_Click);
            // 
            // txtVINToRemove
            // 
            this.txtVINToRemove.Location = new System.Drawing.Point(51, 53);
            this.txtVINToRemove.Name = "txtVINToRemove";
            this.txtVINToRemove.Size = new System.Drawing.Size(151, 20);
            this.txtVINToRemove.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "VIN:";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(15, 16);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(188, 33);
            this.btnRemoveSelected.TabIndex = 0;
            this.btnRemoveSelected.Text = "Удалить выбранную";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // lblStats
            // 
            this.lblStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStats.Location = new System.Drawing.Point(8, 423);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 17);
            this.lblStats.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(8, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(62, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Модель:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 583);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxCars);
            this.Name = "Form1";
            this.Text = "Учет качества машин";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsumption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEcoFriendly;
        private System.Windows.Forms.Button btnAddImproved;
        private System.Windows.Forms.Button btnAddRegular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveByVIN;
        private System.Windows.Forms.TextBox txtVINToRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
    }
}

