﻿
namespace AdvertisingAgency
{
    partial class Form22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._БД_Рекламного_агентства_DataSet = new AdvertisingAgency._БД_Рекламного_агентства_DataSet();
            this.список_заказовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_заказовTableAdapter = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.Список_заказовTableAdapter();
            this.tableAdapterManager = new AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager();
            this.список_заказовDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_заказовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_заказовDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 29);
            this.button1.TabIndex = 326;
            this.button1.Text = "ПОКАЗАТЬ ВСЕ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(891, 513);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 29);
            this.button4.TabIndex = 325;
            this.button4.Text = "ЗАКРЫТЬ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(20, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1045, 47);
            this.button3.TabIndex = 324;
            this.button3.Text = "ФИЛЬТРОВАТЬ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 47);
            this.label1.TabIndex = 321;
            this.label1.Text = "Фильтр \"Список заказов\" по дате";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _БД_Рекламного_агентства_DataSet
            // 
            this._БД_Рекламного_агентства_DataSet.DataSetName = "_БД_Рекламного_агентства_DataSet";
            this._БД_Рекламного_агентства_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_заказовBindingSource
            // 
            this.список_заказовBindingSource.DataMember = "Список заказов";
            this.список_заказовBindingSource.DataSource = this._БД_Рекламного_агентства_DataSet;
            // 
            // список_заказовTableAdapter
            // 
            this.список_заказовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = AdvertisingAgency._БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_рекламыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Дополнительные_услугиTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.Места_расположенияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // список_заказовDataGridView
            // 
            this.список_заказовDataGridView.AutoGenerateColumns = false;
            this.список_заказовDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.список_заказовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.список_заказовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.список_заказовDataGridView.DataSource = this.список_заказовBindingSource;
            this.список_заказовDataGridView.Location = new System.Drawing.Point(20, 139);
            this.список_заказовDataGridView.Name = "список_заказовDataGridView";
            this.список_заказовDataGridView.Size = new System.Drawing.Size(1045, 315);
            this.список_заказовDataGridView.TabIndex = 332;
            this.список_заказовDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.список_заказовDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_заказчика";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_заказчика";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Отметка_об_оплате";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Отметка об оплате";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_заказа";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата заказа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата_начала";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_окончания";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата окончания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дополнительные_услуги_Наименование";
            this.dataGridViewTextBoxColumn5.HeaderText = "Услуга №1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дополнительные_услуги_1_Наименование";
            this.dataGridViewTextBoxColumn6.HeaderText = "Услуга №2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дополнительные_услуги_2_Наименование";
            this.dataGridViewTextBoxColumn7.HeaderText = "Услуга №3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Заказчики_ФИО";
            this.dataGridViewTextBoxColumn8.HeaderText = "Заказчик";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Сотрудники_ФИО";
            this.dataGridViewTextBoxColumn9.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 323;
            this.label2.Text = "Дата  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 329;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 551);
            this.Controls.Add(this.список_заказовDataGridView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form22";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтр \"Список заказов\" по дате";
            this.Load += new System.EventHandler(this.Form22_Load);
            ((System.ComponentModel.ISupportInitialize)(this._БД_Рекламного_агентства_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_заказовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_заказовDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private _БД_Рекламного_агентства_DataSet _БД_Рекламного_агентства_DataSet;
        private System.Windows.Forms.BindingSource список_заказовBindingSource;
        private _БД_Рекламного_агентства_DataSetTableAdapters.Список_заказовTableAdapter список_заказовTableAdapter;
        private _БД_Рекламного_агентства_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView список_заказовDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}