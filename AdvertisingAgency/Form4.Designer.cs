
namespace AdvertisingAgency
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_должностиLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label кодLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._БД_Рекламного_агентства_DataSet = new AdvertisingAgency._БД_Рекламного_агентства_DataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.код_должностиTextBox = new System.Windows.Forms.TextBox();
            код_должностиLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            кодLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_должностиLabel
            // 
            код_должностиLabel.AutoSize = true;
            код_должностиLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_должностиLabel.ForeColor = System.Drawing.Color.Black;
            код_должностиLabel.Location = new System.Drawing.Point(9, 395);
            код_должностиLabel.Name = "код_должностиLabel";
            код_должностиLabel.Size = new System.Drawing.Size(161, 25);
            код_должностиLabel.TabIndex = 222;
            код_должностиLabel.Text = "Код должности:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            паспортные_данныеLabel.ForeColor = System.Drawing.Color.Black;
            паспортные_данныеLabel.Location = new System.Drawing.Point(9, 365);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(214, 25);
            паспортные_данныеLabel.TabIndex = 220;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.ForeColor = System.Drawing.Color.Black;
            телефонLabel.Location = new System.Drawing.Point(9, 334);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(98, 25);
            телефонLabel.TabIndex = 218;
            телефонLabel.Text = "Телефон:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.ForeColor = System.Drawing.Color.Black;
            адресLabel.Location = new System.Drawing.Point(9, 304);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(75, 25);
            адресLabel.TabIndex = 216;
            адресLabel.Text = "Адрес:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel.ForeColor = System.Drawing.Color.Black;
            полLabel.Location = new System.Drawing.Point(9, 272);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(53, 25);
            полLabel.TabIndex = 213;
            полLabel.Text = "Пол:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel.ForeColor = System.Drawing.Color.Black;
            возрастLabel.Location = new System.Drawing.Point(9, 240);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(95, 25);
            возрастLabel.TabIndex = 212;
            возрастLabel.Text = "Возраст:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.ForeColor = System.Drawing.Color.Black;
            фИОLabel.Location = new System.Drawing.Point(9, 207);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(62, 25);
            фИОLabel.TabIndex = 210;
            фИОLabel.Text = "ФИО:";
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодLabel.ForeColor = System.Drawing.Color.Black;
            кодLabel.Location = new System.Drawing.Point(9, 175);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(54, 25);
            кодLabel.TabIndex = 208;
            кодLabel.Text = "Код:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 195;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 47);
            this.label1.TabIndex = 196;
            this.label1.Text = "Сотрудники";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Sienna;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(14, 566);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(445, 29);
            this.button10.TabIndex = 245;
            this.button10.Text = "закрыть";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(14, 519);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(445, 29);
            this.button7.TabIndex = 244;
            this.button7.Text = "сохранить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(330, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 243;
            this.button3.Text = "удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(170, 484);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 29);
            this.button5.TabIndex = 242;
            this.button5.Text = "следующая";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(14, 484);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 29);
            this.button6.TabIndex = 241;
            this.button6.Text = "последняя";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(330, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 29);
            this.button2.TabIndex = 240;
            this.button2.Text = "добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(170, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 239;
            this.button1.Text = "предыдущая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(14, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 29);
            this.button4.TabIndex = 238;
            this.button4.Text = "первая";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _БД_Рекламного_агентства_DataSet
            // 
            this._БД_Рекламного_агентства_DataSet.DataSetName = "_БД_Рекламного_агентства_DataSet";
            this._БД_Рекламного_агентства_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._БД_Рекламного_агентства_DataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_рекламыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.Места_расположенияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Код_сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(286, 175);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(173, 20);
            this.код_сотрудникаTextBox.TabIndex = 247;
            this.код_сотрудникаTextBox.TextChanged += new System.EventHandler(this.код_сотрудникаTextBox_TextChanged);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(286, 207);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(173, 20);
            this.фИОTextBox.TabIndex = 248;
            this.фИОTextBox.TextChanged += new System.EventHandler(this.фИОTextBox_TextChanged_1);
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Возраст", true));
            this.возрастTextBox.Location = new System.Drawing.Point(286, 240);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(173, 20);
            this.возрастTextBox.TabIndex = 249;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(286, 272);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(173, 20);
            this.полTextBox.TabIndex = 250;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(286, 304);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(173, 20);
            this.адресTextBox.TabIndex = 251;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(286, 334);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(173, 20);
            this.телефонTextBox.TabIndex = 252;
            this.телефонTextBox.TextChanged += new System.EventHandler(this.телефонTextBox_TextChanged);
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Паспортные_данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(286, 365);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(173, 20);
            this.паспортные_данныеTextBox.TabIndex = 253;
            // 
            // код_должностиTextBox
            // 
            this.код_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Код_должности", true));
            this.код_должностиTextBox.Location = new System.Drawing.Point(286, 395);
            this.код_должностиTextBox.Name = "код_должностиTextBox";
            this.код_должностиTextBox.Size = new System.Drawing.Size(173, 20);
            this.код_должностиTextBox.TabIndex = 254;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 615);
            this.Controls.Add(this.код_должностиTextBox);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(код_должностиLabel);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(полLabel);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private _БД_Рекламного_агентства_DataSet _БД_Рекламного_агентства_DataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _БД_Рекламного_агентства_DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private _БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox код_должностиTextBox;
    }
}