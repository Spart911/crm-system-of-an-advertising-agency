
namespace AdvertisingAgency
{
    partial class Form7
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
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label кодLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._БД_Рекламного_агентства_DataSet = new AdvertisingAgency._БД_Рекламного_агентства_DataSet();
            this.виды_рекламыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.виды_рекламыTableAdapter = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.Виды_рекламыTableAdapter();
            this.tableAdapterManager = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager();
            this.код_видаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            возрастLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            кодLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_рекламыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel.ForeColor = System.Drawing.Color.Black;
            возрастLabel.Location = new System.Drawing.Point(9, 240);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(113, 25);
            возрастLabel.TabIndex = 270;
            возрастLabel.Text = "Описание:";
            возрастLabel.Click += new System.EventHandler(this.возрастLabel_Click);
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.ForeColor = System.Drawing.Color.Black;
            фИОLabel.Location = new System.Drawing.Point(9, 207);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(165, 25);
            фИОLabel.TabIndex = 269;
            фИОLabel.Text = "Наименование:";
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодLabel.ForeColor = System.Drawing.Color.Black;
            кодLabel.Location = new System.Drawing.Point(9, 175);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(54, 25);
            кодLabel.TabIndex = 268;
            кодLabel.Text = "Код:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(219, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 47);
            this.label1.TabIndex = 267;
            this.label1.Text = "Виды рекламы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 266;
            this.pictureBox1.TabStop = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Sienna;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(11, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(777, 29);
            this.button10.TabIndex = 281;
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
            this.button7.Location = new System.Drawing.Point(11, 351);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(777, 29);
            this.button7.TabIndex = 280;
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
            this.button3.Location = new System.Drawing.Point(534, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 29);
            this.button3.TabIndex = 279;
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
            this.button5.Location = new System.Drawing.Point(286, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 29);
            this.button5.TabIndex = 278;
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
            this.button6.Location = new System.Drawing.Point(11, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(269, 29);
            this.button6.TabIndex = 277;
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
            this.button2.Location = new System.Drawing.Point(534, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 29);
            this.button2.TabIndex = 276;
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
            this.button1.Location = new System.Drawing.Point(286, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 29);
            this.button1.TabIndex = 275;
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
            this.button4.Location = new System.Drawing.Point(11, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 29);
            this.button4.TabIndex = 274;
            this.button4.Text = "первая";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _БД_Рекламного_агентства_DataSet
            // 
            this._БД_Рекламного_агентства_DataSet.DataSetName = "_БД_Рекламного_агентства_DataSet";
            this._БД_Рекламного_агентства_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // виды_рекламыBindingSource
            // 
            this.виды_рекламыBindingSource.DataMember = "Виды_рекламы";
            this.виды_рекламыBindingSource.DataSource = this._БД_Рекламного_агентства_DataSet;
            // 
            // виды_рекламыTableAdapter
            // 
            this.виды_рекламыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_рекламыTableAdapter = this.виды_рекламыTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.Места_расположенияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // код_видаTextBox
            // 
            this.код_видаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_рекламыBindingSource, "Код_вида", true));
            this.код_видаTextBox.Location = new System.Drawing.Point(214, 175);
            this.код_видаTextBox.Name = "код_видаTextBox";
            this.код_видаTextBox.Size = new System.Drawing.Size(574, 20);
            this.код_видаTextBox.TabIndex = 283;
            this.код_видаTextBox.TextChanged += new System.EventHandler(this.код_видаTextBox_TextChanged);
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_рекламыBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(214, 207);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(574, 20);
            this.наименованиеTextBox.TabIndex = 284;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_рекламыBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(214, 240);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(574, 20);
            this.описаниеTextBox.TabIndex = 285;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 447);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.код_видаTextBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(кодLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вмды рекламы";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_рекламыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private _БД_Рекламного_агентства_DataSet _БД_Рекламного_агентства_DataSet;
        private System.Windows.Forms.BindingSource виды_рекламыBindingSource;
        private _БД_Рекламного_агентства_DataSetTableAdapters.Виды_рекламыTableAdapter виды_рекламыTableAdapter;
        private _БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_видаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
    }
}