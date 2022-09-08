
namespace ymriteXyesosi
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
            System.Windows.Forms.Label инвертарныйНомерОСLabel;
            System.Windows.Forms.Label mac_адрес12цифрLabel;
            System.Windows.Forms.Label ip_адресLabel;
            System.Windows.Forms.Label типПортовLabel;
            System.Windows.Forms.Label колВоПортовLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label точкаПодключенияLabel;
            System.Windows.Forms.Label датаУстановкиLabel;
            System.Windows.Forms.Label номерТелефонов_списокНомеровLabel;
            this.roboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oborDataSet = new ymriteXyesosi.oborDataSet();
            this.roboTableAdapter = new ymriteXyesosi.oborDataSetTableAdapters.roboTableAdapter();
            this.oborDataSet1 = new ymriteXyesosi.oborDataSet1();
            this.robooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.robooTableAdapter = new ymriteXyesosi.oborDataSet1TableAdapters.robooTableAdapter();
            this.oborDataSet2 = new ymriteXyesosi.oborDataSet2();
            this.robooBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.robooTableAdapter1 = new ymriteXyesosi.oborDataSet2TableAdapters.robooTableAdapter();
            this.tableAdapterManager = new ymriteXyesosi.oborDataSet1TableAdapters.TableAdapterManager();
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
            this.инвертарныйНомерОСTextBox = new System.Windows.Forms.TextBox();
            this.mac_адрес12цифрTextBox = new System.Windows.Forms.TextBox();
            this.ip_адресTextBox = new System.Windows.Forms.TextBox();
            this.типПортовTextBox = new System.Windows.Forms.TextBox();
            this.колВоПортовTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.точкаПодключенияTextBox = new System.Windows.Forms.TextBox();
            this.датаУстановкиTextBox = new System.Windows.Forms.TextBox();
            this.номерТелефонов_списокНомеровTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            типLabel = new System.Windows.Forms.Label();
            серийныйНомерLabel = new System.Windows.Forms.Label();
            инвертарныйНомерОСLabel = new System.Windows.Forms.Label();
            mac_адрес12цифрLabel = new System.Windows.Forms.Label();
            ip_адресLabel = new System.Windows.Forms.Label();
            типПортовLabel = new System.Windows.Forms.Label();
            колВоПортовLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            точкаПодключенияLabel = new System.Windows.Forms.Label();
            датаУстановкиLabel = new System.Windows.Forms.Label();
            номерТелефонов_списокНомеровLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Location = new System.Drawing.Point(31, 317);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(35, 17);
            типLabel.TabIndex = 1;
            типLabel.Text = "тип:";
            // 
            // серийныйНомерLabel
            // 
            серийныйНомерLabel.AutoSize = true;
            серийныйНомерLabel.Location = new System.Drawing.Point(31, 345);
            серийныйНомерLabel.Name = "серийныйНомерLabel";
            серийныйНомерLabel.Size = new System.Drawing.Size(126, 17);
            серийныйНомерLabel.TabIndex = 3;
            серийныйНомерLabel.Text = "Серийный Номер:";
            // 
            // инвертарныйНомерОСLabel
            // 
            инвертарныйНомерОСLabel.AutoSize = true;
            инвертарныйНомерОСLabel.Location = new System.Drawing.Point(31, 373);
            инвертарныйНомерОСLabel.Name = "инвертарныйНомерОСLabel";
            инвертарныйНомерОСLabel.Size = new System.Drawing.Size(171, 17);
            инвертарныйНомерОСLabel.TabIndex = 5;
            инвертарныйНомерОСLabel.Text = "инвертарный Номер ОС:";
            // 
            // mac_адрес12цифрLabel
            // 
            mac_адрес12цифрLabel.AutoSize = true;
            mac_адрес12цифрLabel.Location = new System.Drawing.Point(31, 401);
            mac_адрес12цифрLabel.Name = "mac_адрес12цифрLabel";
            mac_адрес12цифрLabel.Size = new System.Drawing.Size(133, 17);
            mac_адрес12цифрLabel.TabIndex = 7;
            mac_адрес12цифрLabel.Text = "Mac-адрес12цифр:";
            // 
            // ip_адресLabel
            // 
            ip_адресLabel.AutoSize = true;
            ip_адресLabel.Location = new System.Drawing.Point(31, 429);
            ip_адресLabel.Name = "ip_адресLabel";
            ip_адресLabel.Size = new System.Drawing.Size(67, 17);
            ip_адресLabel.TabIndex = 9;
            ip_адресLabel.Text = "ip-адрес:";
            // 
            // типПортовLabel
            // 
            типПортовLabel.AutoSize = true;
            типПортовLabel.Location = new System.Drawing.Point(31, 457);
            типПортовLabel.Name = "типПортовLabel";
            типПортовLabel.Size = new System.Drawing.Size(89, 17);
            типПортовLabel.TabIndex = 11;
            типПортовLabel.Text = "Тип Портов:";
            // 
            // колВоПортовLabel
            // 
            колВоПортовLabel.AutoSize = true;
            колВоПортовLabel.Location = new System.Drawing.Point(31, 485);
            колВоПортовLabel.Name = "колВоПортовLabel";
            колВоПортовLabel.Size = new System.Drawing.Size(110, 17);
            колВоПортовLabel.TabIndex = 13;
            колВоПортовLabel.Text = "Кол Во Портов:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(31, 513);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 15;
            адресLabel.Text = "Адрес:";
            // 
            // точкаПодключенияLabel
            // 
            точкаПодключенияLabel.AutoSize = true;
            точкаПодключенияLabel.Location = new System.Drawing.Point(31, 541);
            точкаПодключенияLabel.Name = "точкаПодключенияLabel";
            точкаПодключенияLabel.Size = new System.Drawing.Size(147, 17);
            точкаПодключенияLabel.TabIndex = 17;
            точкаПодключенияLabel.Text = "Точка Подключения:";
            // 
            // датаУстановкиLabel
            // 
            датаУстановкиLabel.AutoSize = true;
            датаУстановкиLabel.Location = new System.Drawing.Point(31, 569);
            датаУстановкиLabel.Name = "датаУстановкиLabel";
            датаУстановкиLabel.Size = new System.Drawing.Size(116, 17);
            датаУстановкиLabel.TabIndex = 19;
            датаУстановкиLabel.Text = "дата Установки:";
            // 
            // номерТелефонов_списокНомеровLabel
            // 
            номерТелефонов_списокНомеровLabel.AutoSize = true;
            номерТелефонов_списокНомеровLabel.Location = new System.Drawing.Point(31, 597);
            номерТелефонов_списокНомеровLabel.Name = "номерТелефонов_списокНомеровLabel";
            номерТелефонов_списокНомеровLabel.Size = new System.Drawing.Size(243, 17);
            номерТелефонов_списокНомеровLabel.TabIndex = 21;
            номерТелефонов_списокНомеровLabel.Text = "номер Телефонов/список Номеров:";
            // 
            // roboBindingSource
            // 
            this.roboBindingSource.DataMember = "robo";
            this.roboBindingSource.DataSource = this.oborDataSet;
            // 
            // oborDataSet
            // 
            this.oborDataSet.DataSetName = "oborDataSet";
            this.oborDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roboTableAdapter
            // 
            this.roboTableAdapter.ClearBeforeFill = true;
            // 
            // oborDataSet1
            // 
            this.oborDataSet1.DataSetName = "oborDataSet1";
            this.oborDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // robooBindingSource
            // 
            this.robooBindingSource.DataMember = "roboo";
            this.robooBindingSource.DataSource = this.oborDataSet1;
            // 
            // robooTableAdapter
            // 
            this.robooTableAdapter.ClearBeforeFill = true;
            // 
            // oborDataSet2
            // 
            this.oborDataSet2.DataSetName = "oborDataSet2";
            this.oborDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // robooBindingSource1
            // 
            this.robooBindingSource1.DataMember = "roboo";
            this.robooBindingSource1.DataSource = this.oborDataSet2;
            // 
            // robooTableAdapter1
            // 
            this.robooTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.robooTableAdapter = this.robooTableAdapter;
            this.tableAdapterManager.UpdateOrder = ymriteXyesosi.oborDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.robooDataGridView.Location = new System.Drawing.Point(1, 47);
            this.robooDataGridView.Name = "robooDataGridView";
            this.robooDataGridView.RowHeadersWidth = 51;
            this.robooDataGridView.RowTemplate.Height = 24;
            this.robooDataGridView.Size = new System.Drawing.Size(1303, 220);
            this.robooDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "тип";
            this.dataGridViewTextBoxColumn1.HeaderText = "тип";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "СерийныйНомер";
            this.dataGridViewTextBoxColumn2.HeaderText = "СерийныйНомер";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "инвертарныйНомерОС";
            this.dataGridViewTextBoxColumn3.HeaderText = "инвертарныйНомерОС";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mac-адрес12цифр";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mac-адрес12цифр";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ip-адрес";
            this.dataGridViewTextBoxColumn5.HeaderText = "ip-адрес";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ТипПортов";
            this.dataGridViewTextBoxColumn6.HeaderText = "ТипПортов";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "КолВоПортов";
            this.dataGridViewTextBoxColumn7.HeaderText = "КолВоПортов";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn8.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ТочкаПодключения";
            this.dataGridViewTextBoxColumn9.HeaderText = "ТочкаПодключения";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "датаУстановки";
            this.dataGridViewTextBoxColumn10.HeaderText = "датаУстановки";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "номерТелефонов/списокНомеров";
            this.dataGridViewTextBoxColumn11.HeaderText = "номерТелефонов/списокНомеров";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "тип", true));
            this.типTextBox.Location = new System.Drawing.Point(280, 314);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(100, 22);
            this.типTextBox.TabIndex = 2;
            // 
            // серийныйНомерTextBox
            // 
            this.серийныйНомерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "СерийныйНомер", true));
            this.серийныйНомерTextBox.Location = new System.Drawing.Point(280, 342);
            this.серийныйНомерTextBox.Name = "серийныйНомерTextBox";
            this.серийныйНомерTextBox.Size = new System.Drawing.Size(100, 22);
            this.серийныйНомерTextBox.TabIndex = 4;
            // 
            // инвертарныйНомерОСTextBox
            // 
            this.инвертарныйНомерОСTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "инвертарныйНомерОС", true));
            this.инвертарныйНомерОСTextBox.Location = new System.Drawing.Point(280, 370);
            this.инвертарныйНомерОСTextBox.Name = "инвертарныйНомерОСTextBox";
            this.инвертарныйНомерОСTextBox.Size = new System.Drawing.Size(100, 22);
            this.инвертарныйНомерОСTextBox.TabIndex = 6;
            // 
            // mac_адрес12цифрTextBox
            // 
            this.mac_адрес12цифрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "Mac-адрес12цифр", true));
            this.mac_адрес12цифрTextBox.Location = new System.Drawing.Point(280, 398);
            this.mac_адрес12цифрTextBox.Name = "mac_адрес12цифрTextBox";
            this.mac_адрес12цифрTextBox.Size = new System.Drawing.Size(100, 22);
            this.mac_адрес12цифрTextBox.TabIndex = 8;
            // 
            // ip_адресTextBox
            // 
            this.ip_адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "ip-адрес", true));
            this.ip_адресTextBox.Location = new System.Drawing.Point(280, 426);
            this.ip_адресTextBox.Name = "ip_адресTextBox";
            this.ip_адресTextBox.Size = new System.Drawing.Size(100, 22);
            this.ip_адресTextBox.TabIndex = 10;
            // 
            // типПортовTextBox
            // 
            this.типПортовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "ТипПортов", true));
            this.типПортовTextBox.Location = new System.Drawing.Point(280, 454);
            this.типПортовTextBox.Name = "типПортовTextBox";
            this.типПортовTextBox.Size = new System.Drawing.Size(100, 22);
            this.типПортовTextBox.TabIndex = 12;
            // 
            // колВоПортовTextBox
            // 
            this.колВоПортовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "КолВоПортов", true));
            this.колВоПортовTextBox.Location = new System.Drawing.Point(280, 482);
            this.колВоПортовTextBox.Name = "колВоПортовTextBox";
            this.колВоПортовTextBox.Size = new System.Drawing.Size(100, 22);
            this.колВоПортовTextBox.TabIndex = 14;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(280, 510);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 22);
            this.адресTextBox.TabIndex = 16;
            // 
            // точкаПодключенияTextBox
            // 
            this.точкаПодключенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "ТочкаПодключения", true));
            this.точкаПодключенияTextBox.Location = new System.Drawing.Point(280, 538);
            this.точкаПодключенияTextBox.Name = "точкаПодключенияTextBox";
            this.точкаПодключенияTextBox.Size = new System.Drawing.Size(100, 22);
            this.точкаПодключенияTextBox.TabIndex = 18;
            // 
            // датаУстановкиTextBox
            // 
            this.датаУстановкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "датаУстановки", true));
            this.датаУстановкиTextBox.Location = new System.Drawing.Point(280, 566);
            this.датаУстановкиTextBox.Name = "датаУстановкиTextBox";
            this.датаУстановкиTextBox.Size = new System.Drawing.Size(100, 22);
            this.датаУстановкиTextBox.TabIndex = 20;
            // 
            // номерТелефонов_списокНомеровTextBox
            // 
            this.номерТелефонов_списокНомеровTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.robooBindingSource, "номерТелефонов/списокНомеров", true));
            this.номерТелефонов_списокНомеровTextBox.Location = new System.Drawing.Point(280, 594);
            this.номерТелефонов_списокНомеровTextBox.Name = "номерТелефонов_списокНомеровTextBox";
            this.номерТелефонов_списокНомеровTextBox.Size = new System.Drawing.Size(100, 22);
            this.номерТелефонов_списокНомеровTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Абонент";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 33);
            this.button2.TabIndex = 26;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 35);
            this.button3.TabIndex = 27;
            this.button3.Text = "ТехПоддержка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 710);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(серийныйНомерLabel);
            this.Controls.Add(this.серийныйНомерTextBox);
            this.Controls.Add(инвертарныйНомерОСLabel);
            this.Controls.Add(this.инвертарныйНомерОСTextBox);
            this.Controls.Add(mac_адрес12цифрLabel);
            this.Controls.Add(this.mac_адрес12цифрTextBox);
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
            this.Controls.Add(номерТелефонов_списокНомеровLabel);
            this.Controls.Add(this.номерТелефонов_списокНомеровTextBox);
            this.Controls.Add(this.robooDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robooDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private oborDataSet oborDataSet;
        private System.Windows.Forms.BindingSource roboBindingSource;
        private oborDataSetTableAdapters.roboTableAdapter roboTableAdapter;
        private oborDataSet1 oborDataSet1;
        private System.Windows.Forms.BindingSource robooBindingSource;
        private oborDataSet1TableAdapters.robooTableAdapter robooTableAdapter;
        private oborDataSet2 oborDataSet2;
        private System.Windows.Forms.BindingSource robooBindingSource1;
        private oborDataSet2TableAdapters.robooTableAdapter robooTableAdapter1;
        private oborDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox инвертарныйНомерОСTextBox;
        private System.Windows.Forms.TextBox mac_адрес12цифрTextBox;
        private System.Windows.Forms.TextBox ip_адресTextBox;
        private System.Windows.Forms.TextBox типПортовTextBox;
        private System.Windows.Forms.TextBox колВоПортовTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox точкаПодключенияTextBox;
        private System.Windows.Forms.TextBox датаУстановкиTextBox;
        private System.Windows.Forms.TextBox номерТелефонов_списокНомеровTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

