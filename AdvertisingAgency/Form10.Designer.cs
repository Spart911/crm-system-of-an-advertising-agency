
namespace AdvertisingAgency
{
    partial class Form10
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._БД_Рекламного_агентства_DataSet = new AdvertisingAgency._БД_Рекламного_агентства_DataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_началаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_окончанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_заказчикаTextBox = new System.Windows.Forms.TextBox();
            this.код_местаTextBox = new System.Windows.Forms.TextBox();
            this.код_услуги_1TextBox = new System.Windows.Forms.TextBox();
            this.код_услуги_2TextBox = new System.Windows.Forms.TextBox();
            this.код_услуги_3TextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.отметка_об_оплатеCheckBox = new System.Windows.Forms.CheckBox();
            this.код_сотрудникаTextBox1 = new System.Windows.Forms.TextBox();
            код_должностиLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            кодLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_должностиLabel
            // 
            код_должностиLabel.AutoSize = true;
            код_должностиLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_должностиLabel.ForeColor = System.Drawing.Color.Black;
            код_должностиLabel.Location = new System.Drawing.Point(9, 395);
            код_должностиLabel.Name = "код_должностиLabel";
            код_должностиLabel.Size = new System.Drawing.Size(119, 25);
            код_должностиLabel.TabIndex = 264;
            код_должностиLabel.Text = "Услуга №3:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            паспортные_данныеLabel.ForeColor = System.Drawing.Color.Black;
            паспортные_данныеLabel.Location = new System.Drawing.Point(9, 365);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(119, 25);
            паспортные_данныеLabel.TabIndex = 263;
            паспортные_данныеLabel.Text = "Услуга №2:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.ForeColor = System.Drawing.Color.Black;
            телефонLabel.Location = new System.Drawing.Point(9, 334);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(119, 25);
            телефонLabel.TabIndex = 262;
            телефонLabel.Text = "Услуга №1:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.ForeColor = System.Drawing.Color.Black;
            адресLabel.Location = new System.Drawing.Point(9, 304);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(116, 25);
            адресLabel.TabIndex = 261;
            адресLabel.Text = "Код места:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel.ForeColor = System.Drawing.Color.Black;
            полLabel.Location = new System.Drawing.Point(9, 272);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(161, 25);
            полLabel.TabIndex = 260;
            полLabel.Text = "Код заказчика:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel.ForeColor = System.Drawing.Color.Black;
            возрастLabel.Location = new System.Drawing.Point(9, 240);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(174, 25);
            возрастLabel.TabIndex = 259;
            возрастLabel.Text = "Дата окончания:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.ForeColor = System.Drawing.Color.Black;
            фИОLabel.Location = new System.Drawing.Point(9, 207);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(138, 25);
            фИОLabel.TabIndex = 258;
            фИОLabel.Text = "Дата начала:";
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодLabel.ForeColor = System.Drawing.Color.Black;
            кодLabel.Location = new System.Drawing.Point(9, 175);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(136, 25);
            кодLabel.TabIndex = 257;
            кодLabel.Text = "Дата заказа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(7, 425);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 25);
            label2.TabIndex = 281;
            label2.Text = "Стоимость:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(10, 488);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(198, 25);
            label3.TabIndex = 283;
            label3.Text = "Отметка об оплате:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(12, 457);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(170, 25);
            label4.TabIndex = 284;
            label4.Text = "Код сотрудника:";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Sienna;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(12, 682);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(445, 29);
            this.button10.TabIndex = 272;
            this.button10.Text = "закрыть";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 635);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(445, 29);
            this.button7.TabIndex = 271;
            this.button7.Text = "сохранить";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(328, 600);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 270;
            this.button3.Text = "удалить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(168, 600);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 29);
            this.button5.TabIndex = 269;
            this.button5.Text = "следующая";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 600);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 29);
            this.button6.TabIndex = 268;
            this.button6.Text = "последняя";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(328, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 29);
            this.button2.TabIndex = 267;
            this.button2.Text = "добавить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(168, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 266;
            this.button1.Text = "предыдущая";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 565);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 29);
            this.button4.TabIndex = 265;
            this.button4.Text = "первая";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 47);
            this.label1.TabIndex = 256;
            this.label1.Text = "Заказы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 255;
            this.pictureBox1.TabStop = false;
            // 
            // _БД_Рекламного_агентства_DataSet
            // 
            this._БД_Рекламного_агентства_DataSet.DataSetName = "_БД_Рекламного_агентства_DataSet";
            this._БД_Рекламного_агентства_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this._БД_Рекламного_агентства_DataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_рекламыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.Места_расположенияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата_заказа", true));
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(284, 175);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.дата_заказаDateTimePicker.TabIndex = 286;
            // 
            // дата_началаDateTimePicker
            // 
            this.дата_началаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата_начала", true));
            this.дата_началаDateTimePicker.Location = new System.Drawing.Point(284, 207);
            this.дата_началаDateTimePicker.Name = "дата_началаDateTimePicker";
            this.дата_началаDateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.дата_началаDateTimePicker.TabIndex = 287;
            // 
            // дата_окончанияDateTimePicker
            // 
            this.дата_окончанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Дата_окончания", true));
            this.дата_окончанияDateTimePicker.Location = new System.Drawing.Point(284, 240);
            this.дата_окончанияDateTimePicker.Name = "дата_окончанияDateTimePicker";
            this.дата_окончанияDateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.дата_окончанияDateTimePicker.TabIndex = 288;
            // 
            // код_заказчикаTextBox
            // 
            this.код_заказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_заказчика", true));
            this.код_заказчикаTextBox.Location = new System.Drawing.Point(284, 272);
            this.код_заказчикаTextBox.Name = "код_заказчикаTextBox";
            this.код_заказчикаTextBox.Size = new System.Drawing.Size(175, 20);
            this.код_заказчикаTextBox.TabIndex = 289;
            // 
            // код_местаTextBox
            // 
            this.код_местаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_места", true));
            this.код_местаTextBox.Location = new System.Drawing.Point(284, 304);
            this.код_местаTextBox.Name = "код_местаTextBox";
            this.код_местаTextBox.Size = new System.Drawing.Size(175, 20);
            this.код_местаTextBox.TabIndex = 290;
            // 
            // код_услуги_1TextBox
            // 
            this.код_услуги_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_услуги_1", true));
            this.код_услуги_1TextBox.Location = new System.Drawing.Point(284, 334);
            this.код_услуги_1TextBox.Name = "код_услуги_1TextBox";
            this.код_услуги_1TextBox.Size = new System.Drawing.Size(175, 20);
            this.код_услуги_1TextBox.TabIndex = 291;
            // 
            // код_услуги_2TextBox
            // 
            this.код_услуги_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_услуги_2", true));
            this.код_услуги_2TextBox.Location = new System.Drawing.Point(284, 365);
            this.код_услуги_2TextBox.Name = "код_услуги_2TextBox";
            this.код_услуги_2TextBox.Size = new System.Drawing.Size(175, 20);
            this.код_услуги_2TextBox.TabIndex = 292;
            this.код_услуги_2TextBox.TextChanged += new System.EventHandler(this.код_услуги_2TextBox_TextChanged);
            // 
            // код_услуги_3TextBox
            // 
            this.код_услуги_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_услуги_3", true));
            this.код_услуги_3TextBox.Location = new System.Drawing.Point(284, 395);
            this.код_услуги_3TextBox.Name = "код_услуги_3TextBox";
            this.код_услуги_3TextBox.Size = new System.Drawing.Size(175, 20);
            this.код_услуги_3TextBox.TabIndex = 293;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(284, 425);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(175, 20);
            this.стоимостьTextBox.TabIndex = 294;
            // 
            // отметка_об_оплатеCheckBox
            // 
            this.отметка_об_оплатеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.заказыBindingSource, "Отметка_об_оплате", true));
            this.отметка_об_оплатеCheckBox.Location = new System.Drawing.Point(284, 492);
            this.отметка_об_оплатеCheckBox.Name = "отметка_об_оплатеCheckBox";
            this.отметка_об_оплатеCheckBox.Size = new System.Drawing.Size(42, 22);
            this.отметка_об_оплатеCheckBox.TabIndex = 295;
            this.отметка_об_оплатеCheckBox.UseVisualStyleBackColor = true;
            // 
            // код_сотрудникаTextBox1
            // 
            this.код_сотрудникаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Код_сотрудника", true));
            this.код_сотрудникаTextBox1.Location = new System.Drawing.Point(284, 457);
            this.код_сотрудникаTextBox1.Name = "код_сотрудникаTextBox1";
            this.код_сотрудникаTextBox1.Size = new System.Drawing.Size(175, 20);
            this.код_сотрудникаTextBox1.TabIndex = 296;
            this.код_сотрудникаTextBox1.TextChanged += new System.EventHandler(this.код_сотрудникаTextBox1_TextChanged);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 722);
            this.Controls.Add(this.код_сотрудникаTextBox1);
            this.Controls.Add(this.отметка_об_оплатеCheckBox);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.код_услуги_3TextBox);
            this.Controls.Add(this.код_услуги_2TextBox);
            this.Controls.Add(this.код_услуги_1TextBox);
            this.Controls.Add(this.код_местаTextBox);
            this.Controls.Add(this.код_заказчикаTextBox);
            this.Controls.Add(this.дата_окончанияDateTimePicker);
            this.Controls.Add(this.дата_началаDateTimePicker);
            this.Controls.Add(this.дата_заказаDateTimePicker);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
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
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _БД_Рекламного_агентства_DataSet _БД_Рекламного_агентства_DataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private _БД_Рекламного_агентства_DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private _БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_началаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_окончанияDateTimePicker;
        private System.Windows.Forms.TextBox код_заказчикаTextBox;
        private System.Windows.Forms.TextBox код_местаTextBox;
        private System.Windows.Forms.TextBox код_услуги_1TextBox;
        private System.Windows.Forms.TextBox код_услуги_2TextBox;
        private System.Windows.Forms.TextBox код_услуги_3TextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.CheckBox отметка_об_оплатеCheckBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox1;
    }
}