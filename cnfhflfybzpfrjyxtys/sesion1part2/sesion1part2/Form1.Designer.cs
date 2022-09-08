
namespace sesion1part2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label типLabel;
            System.Windows.Forms.Label серийныйНомерLabel;
            System.Windows.Forms.Label инвертарныйКодLabel;
            System.Windows.Forms.Label мас_адресLabel;
            System.Windows.Forms.Label ip_адресLabel;
            System.Windows.Forms.Label типПортовLabel;
            System.Windows.Forms.Label колВоПортовLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label точкаПодключенияLabel;
            System.Windows.Forms.Label датаУстановкиLabel;
            System.Windows.Forms.Label номерТелефонаLabel;
            this.abonentDataSet = new sesion1part2.abonentDataSet();
            this.abonentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonentDataSet1 = new sesion1part2.abonentDataSet1();
            this.robooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.robooTableAdapter = new sesion1part2.abonentDataSet1TableAdapters.robooTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new sesion1part2.abonentDataSet1TableAdapters.TableAdapterManager();
            this.robooDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.серийныйНомерTextBox = new System.Windows.Forms.TextBox();
            this.инвертарныйКодTextBox = new System.Windows.Forms.TextBox();
            this.мас_адресTextBox = new System.Windows.Forms.TextBox();
            this.ip_адресTextBox = new System.Windows.Forms.TextBox();
            this.типПортовTextBox = new System.Windows.Forms.TextBox();
            this.колВоПортовTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.точкаПодключенияTextBox = new System.Windows.Forms.TextBox();
            this.датаУстановкиTextBox = new System.Windows.Forms.TextBox();
            this.номерТелефонаTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            серийныйНомерLabel = new System.Windows.Forms.Label();
            инвертарныйКодLabel = new System.Windows.Forms.Label();
            мас_адресLabel = new System.Windows.Forms.Label();
            ip_адресLabel = new System.Windows.Forms.Label();
            типПортовLabel = new System.Windows.Forms.Label();
            колВоПортовLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            точкаПодключенияLabel = new System.Windows.Forms.Label();
            датаУстановкиLabel = new System.Windows.Forms.Label();
            номерТелефонаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // abonentDataSet
            // 
            this.abonentDataSet.DataSetName = "abonentDataSet";
            this.abonentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonentDataSetBindingSource
            // 
            this.abonentDataSetBindingSource.DataSource = this.abonentDataSet;
            this.abonentDataSetBindingSource.Position = 0;
            // 
            // abonentDataSet1
            // 
            this.abonentDataSet1.DataSetName = "abonentDataSet1";
            this.abonentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // robooBindingSource
            // 
            this.robooBindingSource.DataMember = "roboo";
            this.robooBindingSource.DataSource = this.abonentDataSet1;
            // 
            // robooTableAdapter
            // 
            this.robooTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.robooTableAdapter = this.robooTableAdapter;
            this.tableAdapterManager.UpdateOrder = sesion1part2.abonentDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // robooDataGridView
            // 
            this.robooDataGridView.AutoGenerateColumns = false;
            this.robooDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.robooDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.robooDataGridView.DataSource = this.robooBindingSource;
            this.robooDataGridView.Location = new System.Drawing.Point(12, 12);
            this.robooDataGridView.Name = "robooDataGridView";
            this.robooDataGridView.Size = new System.Drawing.Size(1144, 220);
            this.robooDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "тип";
            this.dataGridViewTextBoxColumn1.HeaderText = "тип";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "СерийныйНомер";
            this.dataGridViewTextBoxColumn2.HeaderText = "СерийныйНомер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "инвертарныйКод";
            this.dataGridViewTextBoxColumn3.HeaderText = "инвертарныйКод";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Мас-адрес";
            this.dataGridViewTextBoxColumn4.HeaderText = "Мас-адрес";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ip-адрес";
            this.dataGridViewTextBoxColumn5.HeaderText = "ip-адрес";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "типПортов";
            this.dataGridViewTextBoxColumn6.HeaderText = "типПортов";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "КолВоПортов";
            this.dataGridViewTextBoxColumn7.HeaderText = "КолВоПортов";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn8.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ТочкаПодключения";
            this.dataGridViewTextBoxColumn9.HeaderText = "ТочкаПодключения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ДатаУстановки";
            this.dataGridViewTextBoxColumn10.HeaderText = "ДатаУстановки";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "номерТелефона";
            this.dataGridViewTextBoxColumn11.HeaderText = "номерТелефона";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Location = new System.Drawing.Point(22, 262);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(27, 13);
            типLabel.TabIndex = 2;
            типLabel.Text = "тип:";
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "тип", true));
            this.типTextBox.Location = new System.Drawing.Point(140, 259);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(100, 20);
            this.типTextBox.TabIndex = 3;
            // 
            // серийныйНомерLabel
            // 
            серийныйНомерLabel.AutoSize = true;
            серийныйНомерLabel.Location = new System.Drawing.Point(22, 288);
            серийныйНомерLabel.Name = "серийныйНомерLabel";
            серийныйНомерLabel.Size = new System.Drawing.Size(98, 13);
            серийныйНомерLabel.TabIndex = 4;
            серийныйНомерLabel.Text = "Серийный Номер:";
            // 
            // серийныйНомерTextBox
            // 
            this.серийныйНомерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "СерийныйНомер", true));
            this.серийныйНомерTextBox.Location = new System.Drawing.Point(140, 285);
            this.серийныйНомерTextBox.Name = "серийныйНомерTextBox";
            this.серийныйНомерTextBox.Size = new System.Drawing.Size(100, 20);
            this.серийныйНомерTextBox.TabIndex = 5;
            // 
            // инвертарныйКодLabel
            // 
            инвертарныйКодLabel.AutoSize = true;
            инвертарныйКодLabel.Location = new System.Drawing.Point(22, 314);
            инвертарныйКодLabel.Name = "инвертарныйКодLabel";
            инвертарныйКодLabel.Size = new System.Drawing.Size(99, 13);
            инвертарныйКодLabel.TabIndex = 6;
            инвертарныйКодLabel.Text = "инвертарный Код:";
            // 
            // инвертарныйКодTextBox
            // 
            this.инвертарныйКодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "инвертарныйКод", true));
            this.инвертарныйКодTextBox.Location = new System.Drawing.Point(140, 311);
            this.инвертарныйКодTextBox.Name = "инвертарныйКодTextBox";
            this.инвертарныйКодTextBox.Size = new System.Drawing.Size(100, 20);
            this.инвертарныйКодTextBox.TabIndex = 7;
            // 
            // мас_адресLabel
            // 
            мас_адресLabel.AutoSize = true;
            мас_адресLabel.Location = new System.Drawing.Point(22, 340);
            мас_адресLabel.Name = "мас_адресLabel";
            мас_адресLabel.Size = new System.Drawing.Size(64, 13);
            мас_адресLabel.TabIndex = 8;
            мас_адресLabel.Text = "Мас-адрес:";
            // 
            // мас_адресTextBox
            // 
            this.мас_адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "Мас-адрес", true));
            this.мас_адресTextBox.Location = new System.Drawing.Point(140, 337);
            this.мас_адресTextBox.Name = "мас_адресTextBox";
            this.мас_адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.мас_адресTextBox.TabIndex = 9;
            // 
            // ip_адресLabel
            // 
            ip_адресLabel.AutoSize = true;
            ip_адресLabel.Location = new System.Drawing.Point(22, 366);
            ip_адресLabel.Name = "ip_адресLabel";
            ip_адресLabel.Size = new System.Drawing.Size(51, 13);
            ip_адресLabel.TabIndex = 10;
            ip_адресLabel.Text = "ip-адрес:";
            // 
            // ip_адресTextBox
            // 
            this.ip_адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "ip-адрес", true));
            this.ip_адресTextBox.Location = new System.Drawing.Point(140, 363);
            this.ip_адресTextBox.Name = "ip_адресTextBox";
            this.ip_адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.ip_адресTextBox.TabIndex = 11;
            // 
            // типПортовLabel
            // 
            типПортовLabel.AutoSize = true;
            типПортовLabel.Location = new System.Drawing.Point(22, 392);
            типПортовLabel.Name = "типПортовLabel";
            типПортовLabel.Size = new System.Drawing.Size(67, 13);
            типПортовLabel.TabIndex = 12;
            типПортовLabel.Text = "тип Портов:";
            // 
            // типПортовTextBox
            // 
            this.типПортовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "типПортов", true));
            this.типПортовTextBox.Location = new System.Drawing.Point(140, 389);
            this.типПортовTextBox.Name = "типПортовTextBox";
            this.типПортовTextBox.Size = new System.Drawing.Size(100, 20);
            this.типПортовTextBox.TabIndex = 13;
            // 
            // колВоПортовLabel
            // 
            колВоПортовLabel.AutoSize = true;
            колВоПортовLabel.Location = new System.Drawing.Point(22, 418);
            колВоПортовLabel.Name = "колВоПортовLabel";
            колВоПортовLabel.Size = new System.Drawing.Size(85, 13);
            колВоПортовLabel.TabIndex = 14;
            колВоПортовLabel.Text = "Кол Во Портов:";
            // 
            // колВоПортовTextBox
            // 
            this.колВоПортовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "КолВоПортов", true));
            this.колВоПортовTextBox.Location = new System.Drawing.Point(140, 415);
            this.колВоПортовTextBox.Name = "колВоПортовTextBox";
            this.колВоПортовTextBox.Size = new System.Drawing.Size(100, 20);
            this.колВоПортовTextBox.TabIndex = 15;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(22, 444);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 16;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(140, 441);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 17;
            // 
            // точкаПодключенияLabel
            // 
            точкаПодключенияLabel.AutoSize = true;
            точкаПодключенияLabel.Location = new System.Drawing.Point(22, 470);
            точкаПодключенияLabel.Name = "точкаПодключенияLabel";
            точкаПодключенияLabel.Size = new System.Drawing.Size(112, 13);
            точкаПодключенияLabel.TabIndex = 18;
            точкаПодключенияLabel.Text = "Точка Подключения:";
            // 
            // точкаПодключенияTextBox
            // 
            this.точкаПодключенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "ТочкаПодключения", true));
            this.точкаПодключенияTextBox.Location = new System.Drawing.Point(140, 467);
            this.точкаПодключенияTextBox.Name = "точкаПодключенияTextBox";
            this.точкаПодключенияTextBox.Size = new System.Drawing.Size(100, 20);
            this.точкаПодключенияTextBox.TabIndex = 19;
            // 
            // датаУстановкиLabel
            // 
            датаУстановкиLabel.AutoSize = true;
            датаУстановкиLabel.Location = new System.Drawing.Point(22, 496);
            датаУстановкиLabel.Name = "датаУстановкиLabel";
            датаУстановкиLabel.Size = new System.Drawing.Size(94, 13);
            датаУстановкиLabel.TabIndex = 20;
            датаУстановкиLabel.Text = "Дата Установки:";
            // 
            // датаУстановкиTextBox
            // 
            this.датаУстановкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "ДатаУстановки", true));
            this.датаУстановкиTextBox.Location = new System.Drawing.Point(140, 493);
            this.датаУстановкиTextBox.Name = "датаУстановкиTextBox";
            this.датаУстановкиTextBox.Size = new System.Drawing.Size(100, 20);
            this.датаУстановкиTextBox.TabIndex = 21;
            // 
            // номерТелефонаLabel
            // 
            номерТелефонаLabel.AutoSize = true;
            номерТелефонаLabel.Location = new System.Drawing.Point(22, 522);
            номерТелефонаLabel.Name = "номерТелефонаLabel";
            номерТелефонаLabel.Size = new System.Drawing.Size(96, 13);
            номерТелефонаLabel.TabIndex = 22;
            номерТелефонаLabel.Text = "номер Телефона:";
            // 
            // номерТелефонаTextBox
            // 
            this.номерТелефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "номерТелефона", true));
            this.номерТелефонаTextBox.Location = new System.Drawing.Point(140, 519);
            this.номерТелефонаTextBox.Name = "номерТелефонаTextBox";
            this.номерТелефонаTextBox.Size = new System.Drawing.Size(100, 20);
            this.номерТелефонаTextBox.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 25);
            this.button2.TabIndex = 24;
            this.button2.Text = "Тех.Поддержка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Абонент:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(серийныйНомерLabel);
            this.Controls.Add(this.серийныйНомерTextBox);
            this.Controls.Add(инвертарныйКодLabel);
            this.Controls.Add(this.инвертарныйКодTextBox);
            this.Controls.Add(мас_адресLabel);
            this.Controls.Add(this.мас_адресTextBox);
            this.Controls.Add(ip_адресLabel);
            this.Controls.Add(this.ip_адресTextBox);
            this.Controls.Add(типПортовLabel);
            this.Controls.Add(this.типПортовTextBox);
            this.Controls.Add(колВоПортовLabel);
            this.Controls.Add(this.колВоПортовTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(точкаПодключенияLabel);
            this.Controls.Add(this.точкаПодключенияTextBox);
            this.Controls.Add(датаУстановкиLabel);
            this.Controls.Add(this.датаУстановкиTextBox);
            this.Controls.Add(номерТелефонаLabel);
            this.Controls.Add(this.номерТелефонаTextBox);
            this.Controls.Add(this.robooDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource abonentDataSetBindingSource;
        private abonentDataSet abonentDataSet;
        private abonentDataSet1 abonentDataSet1;
        private System.Windows.Forms.BindingSource robooBindingSource;
        private abonentDataSet1TableAdapters.robooTableAdapter robooTableAdapter;
        private System.Windows.Forms.Button button1;
        private abonentDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView robooDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.TextBox серийныйНомерTextBox;
        private System.Windows.Forms.TextBox инвертарныйКодTextBox;
        private System.Windows.Forms.TextBox мас_адресTextBox;
        private System.Windows.Forms.TextBox ip_адресTextBox;
        private System.Windows.Forms.TextBox типПортовTextBox;
        private System.Windows.Forms.TextBox колВоПортовTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox точкаПодключенияTextBox;
        private System.Windows.Forms.TextBox датаУстановкиTextBox;
        private System.Windows.Forms.TextBox номерТелефонаTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

