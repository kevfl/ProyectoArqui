using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //No BORRAR
        private void Form1_Load(object sender, EventArgs e)
        {
            //Necesario para los hilos
            CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnStepByStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDataL2 = new System.Windows.Forms.DataGridView();
            this.numLinL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataL2P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataL2P2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataL2Etiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L2Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dataMem = new System.Windows.Forms.DataGridView();
            this.line1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memoria = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataRegP1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDataL1P1 = new System.Windows.Forms.DataGridView();
            this.dataInstructP1 = new System.Windows.Forms.DataGridView();
            this.lineaInstP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstruccionP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataRegP2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dataDataL1P2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataInstructP2 = new System.Windows.Forms.DataGridView();
            this.lineaInstP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstruccionP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineRegP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estRegP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumberRegP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueRegP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proc1P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proc1P2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etiqP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2Etiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMem)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataL1P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstructP1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataL1P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstructP2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(77, 10);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(97, 23);
            this.btnAuto.TabIndex = 12;
            this.btnAuto.Text = "Automatico";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // btnStepByStep
            // 
            this.btnStepByStep.Location = new System.Drawing.Point(77, 39);
            this.btnStepByStep.Name = "btnStepByStep";
            this.btnStepByStep.Size = new System.Drawing.Size(97, 23);
            this.btnStepByStep.TabIndex = 13;
            this.btnStepByStep.Text = "Paso a Paso";
            this.btnStepByStep.UseVisualStyleBackColor = true;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(81, 10);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(109, 23);
            this.btnNextStep.TabIndex = 16;
            this.btnNextStep.Text = "Siguiente Paso";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(87, 39);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(97, 23);
            this.btnContinue.TabIndex = 17;
            this.btnContinue.Text = "Continuar";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStepByStep);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Location = new System.Drawing.Point(44, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 67);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNextStep);
            this.groupBox2.Controls.Add(this.btnContinue);
            this.groupBox2.Location = new System.Drawing.Point(238, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 67);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // dataDataL2
            // 
            this.dataDataL2.AllowUserToAddRows = false;
            this.dataDataL2.AllowUserToDeleteRows = false;
            this.dataDataL2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataL2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numLinL2,
            this.dataL2P1,
            this.dataL2P2,
            this.dataL2Etiq,
            this.L2Est});
            this.dataDataL2.Location = new System.Drawing.Point(755, 29);
            this.dataDataL2.Name = "dataDataL2";
            this.dataDataL2.ReadOnly = true;
            this.dataDataL2.RowHeadersVisible = false;
            this.dataDataL2.Size = new System.Drawing.Size(138, 387);
            this.dataDataL2.TabIndex = 10;
            // 
            // numLinL2
            // 
            this.numLinL2.HeaderText = "#";
            this.numLinL2.Name = "numLinL2";
            this.numLinL2.ReadOnly = true;
            this.numLinL2.Width = 18;
            // 
            // dataL2P1
            // 
            this.dataL2P1.HeaderText = "P1";
            this.dataL2P1.Name = "dataL2P1";
            this.dataL2P1.ReadOnly = true;
            this.dataL2P1.Width = 23;
            // 
            // dataL2P2
            // 
            this.dataL2P2.HeaderText = "P2";
            this.dataL2P2.Name = "dataL2P2";
            this.dataL2P2.ReadOnly = true;
            this.dataL2P2.Width = 23;
            // 
            // dataL2Etiq
            // 
            this.dataL2Etiq.HeaderText = "Etiq.";
            this.dataL2Etiq.Name = "dataL2Etiq";
            this.dataL2Etiq.ReadOnly = true;
            this.dataL2Etiq.Width = 35;
            // 
            // L2Est
            // 
            this.L2Est.HeaderText = "Est.";
            this.L2Est.Name = "L2Est";
            this.L2Est.ReadOnly = true;
            this.L2Est.Width = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(798, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Datos L2";
            // 
            // dataMem
            // 
            this.dataMem.AllowUserToAddRows = false;
            this.dataMem.AllowUserToDeleteRows = false;
            this.dataMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.line1,
            this.data1,
            this.line2,
            this.value2,
            this.line3,
            this.value3,
            this.line4,
            this.value4,
            this.Line5,
            this.value5});
            this.dataMem.Location = new System.Drawing.Point(906, 35);
            this.dataMem.Name = "dataMem";
            this.dataMem.ReadOnly = true;
            this.dataMem.RowHeadersVisible = false;
            this.dataMem.Size = new System.Drawing.Size(299, 555);
            this.dataMem.TabIndex = 20;
            // 
            // line1
            // 
            this.line1.HeaderText = "#";
            this.line1.Name = "line1";
            this.line1.ReadOnly = true;
            this.line1.Width = 20;
            // 
            // data1
            // 
            this.data1.HeaderText = "V.";
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            this.data1.Width = 20;
            // 
            // line2
            // 
            this.line2.HeaderText = "#";
            this.line2.Name = "line2";
            this.line2.ReadOnly = true;
            this.line2.Width = 20;
            // 
            // value2
            // 
            this.value2.HeaderText = "V.";
            this.value2.Name = "value2";
            this.value2.ReadOnly = true;
            this.value2.Width = 20;
            // 
            // line3
            // 
            this.line3.HeaderText = "#";
            this.line3.Name = "line3";
            this.line3.ReadOnly = true;
            this.line3.Width = 20;
            // 
            // value3
            // 
            this.value3.HeaderText = "V.";
            this.value3.Name = "value3";
            this.value3.ReadOnly = true;
            this.value3.Width = 20;
            // 
            // line4
            // 
            this.line4.HeaderText = "#";
            this.line4.Name = "line4";
            this.line4.ReadOnly = true;
            this.line4.Width = 20;
            // 
            // value4
            // 
            this.value4.HeaderText = "V.";
            this.value4.Name = "value4";
            this.value4.ReadOnly = true;
            this.value4.Width = 20;
            // 
            // Line5
            // 
            this.Line5.HeaderText = "#";
            this.Line5.Name = "Line5";
            this.Line5.ReadOnly = true;
            this.Line5.Width = 20;
            // 
            // value5
            // 
            this.value5.HeaderText = "V.";
            this.value5.Name = "value5";
            this.value5.ReadOnly = true;
            this.value5.Width = 20;
            // 
            // Memoria
            // 
            this.Memoria.AutoSize = true;
            this.Memoria.Location = new System.Drawing.Point(975, 15);
            this.Memoria.Name = "Memoria";
            this.Memoria.Size = new System.Drawing.Size(59, 17);
            this.Memoria.TabIndex = 21;
            this.Memoria.Text = "Memoria";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dataRegP1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataDataL1P1);
            this.groupBox3.Controls.Add(this.dataInstructP1);
            this.groupBox3.Location = new System.Drawing.Point(6, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 573);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registros P1";
            // 
            // dataRegP1
            // 
            this.dataRegP1.AllowUserToAddRows = false;
            this.dataRegP1.AllowUserToDeleteRows = false;
            this.dataRegP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegP1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineRegP1,
            this.estRegP1});
            this.dataRegP1.Location = new System.Drawing.Point(269, 30);
            this.dataRegP1.Name = "dataRegP1";
            this.dataRegP1.ReadOnly = true;
            this.dataRegP1.RowHeadersVisible = false;
            this.dataRegP1.Size = new System.Drawing.Size(80, 537);
            this.dataRegP1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datos P1 L1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instrucciones P1";
            // 
            // dataDataL1P1
            // 
            this.dataDataL1P1.AllowUserToAddRows = false;
            this.dataDataL1P1.AllowUserToDeleteRows = false;
            this.dataDataL1P1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataL1P1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineDataP1,
            this.proc1P1,
            this.proc1P2,
            this.etiqP1,
            this.estP1});
            this.dataDataL1P1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataDataL1P1.Location = new System.Drawing.Point(117, 30);
            this.dataDataL1P1.Name = "dataDataL1P1";
            this.dataDataL1P1.ReadOnly = true;
            this.dataDataL1P1.RowHeadersVisible = false;
            this.dataDataL1P1.Size = new System.Drawing.Size(146, 123);
            this.dataDataL1P1.TabIndex = 3;
            // 
            // dataInstructP1
            // 
            this.dataInstructP1.AllowUserToAddRows = false;
            this.dataInstructP1.AllowUserToDeleteRows = false;
            this.dataInstructP1.AllowUserToResizeColumns = false;
            this.dataInstructP1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "0";
            this.dataInstructP1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataInstructP1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataInstructP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstructP1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineaInstP1,
            this.InstruccionP1});
            this.dataInstructP1.Location = new System.Drawing.Point(6, 30);
            this.dataInstructP1.Name = "dataInstructP1";
            this.dataInstructP1.ReadOnly = true;
            this.dataInstructP1.RowHeadersVisible = false;
            this.dataInstructP1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataInstructP1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInstructP1.Size = new System.Drawing.Size(105, 111);
            this.dataInstructP1.TabIndex = 1;
            this.dataInstructP1.TabStop = false;
            // 
            // lineaInstP1
            // 
            this.lineaInstP1.HeaderText = "#";
            this.lineaInstP1.Name = "lineaInstP1";
            this.lineaInstP1.ReadOnly = true;
            this.lineaInstP1.Width = 18;
            // 
            // InstruccionP1
            // 
            this.InstruccionP1.HeaderText = "Instruccion";
            this.InstruccionP1.Name = "InstruccionP1";
            this.InstruccionP1.ReadOnly = true;
            this.InstruccionP1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InstruccionP1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InstruccionP1.Width = 68;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataRegP2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dataDataL1P2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dataInstructP2);
            this.groupBox4.Location = new System.Drawing.Point(381, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 573);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procesador 2";
            // 
            // dataRegP2
            // 
            this.dataRegP2.AllowUserToAddRows = false;
            this.dataRegP2.AllowUserToDeleteRows = false;
            this.dataRegP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegP2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineNumberRegP2,
            this.valueRegP2});
            this.dataRegP2.Location = new System.Drawing.Point(269, 30);
            this.dataRegP2.Name = "dataRegP2";
            this.dataRegP2.ReadOnly = true;
            this.dataRegP2.RowHeadersVisible = false;
            this.dataRegP2.Size = new System.Drawing.Size(80, 537);
            this.dataRegP2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Registros P2";
            // 
            // dataDataL1P2
            // 
            this.dataDataL1P2.AllowUserToAddRows = false;
            this.dataDataL1P2.AllowUserToDeleteRows = false;
            this.dataDataL1P2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataL1P2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineNumber,
            this.dataP1,
            this.dataP2,
            this.p2Etiq,
            this.estP2});
            this.dataDataL1P2.Location = new System.Drawing.Point(118, 30);
            this.dataDataL1P2.Name = "dataDataL1P2";
            this.dataDataL1P2.ReadOnly = true;
            this.dataDataL1P2.RowHeadersVisible = false;
            this.dataDataL1P2.Size = new System.Drawing.Size(145, 123);
            this.dataDataL1P2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Datos P2 L1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Instrucciones P2";
            // 
            // dataInstructP2
            // 
            this.dataInstructP2.AllowUserToAddRows = false;
            this.dataInstructP2.AllowUserToDeleteRows = false;
            this.dataInstructP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstructP2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineaInstP2,
            this.InstruccionP2});
            this.dataInstructP2.Location = new System.Drawing.Point(6, 30);
            this.dataInstructP2.Name = "dataInstructP2";
            this.dataInstructP2.ReadOnly = true;
            this.dataInstructP2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataInstructP2.RowHeadersVisible = false;
            this.dataInstructP2.Size = new System.Drawing.Size(105, 111);
            this.dataInstructP2.TabIndex = 6;
            // 
            // lineaInstP2
            // 
            this.lineaInstP2.HeaderText = "#";
            this.lineaInstP2.Name = "lineaInstP2";
            this.lineaInstP2.ReadOnly = true;
            this.lineaInstP2.Width = 18;
            // 
            // InstruccionP2
            // 
            this.InstruccionP2.HeaderText = "Instruccion";
            this.InstruccionP2.Name = "InstruccionP2";
            this.InstruccionP2.ReadOnly = true;
            this.InstruccionP2.Width = 68;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.Memoria);
            this.groupBox5.Controls.Add(this.dataMem);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.dataDataL2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(11, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1211, 596);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estados";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WindowsFormsApp1.Program);
            // 
            // lineRegP1
            // 
            this.lineRegP1.HeaderText = "#";
            this.lineRegP1.Name = "lineRegP1";
            this.lineRegP1.ReadOnly = true;
            this.lineRegP1.Width = 25;
            // 
            // estRegP1
            // 
            this.estRegP1.HeaderText = "Valor";
            this.estRegP1.Name = "estRegP1";
            this.estRegP1.ReadOnly = true;
            this.estRegP1.Width = 40;
            // 
            // lineNumberRegP2
            // 
            this.lineNumberRegP2.HeaderText = "#";
            this.lineNumberRegP2.Name = "lineNumberRegP2";
            this.lineNumberRegP2.ReadOnly = true;
            this.lineNumberRegP2.Width = 25;
            // 
            // valueRegP2
            // 
            this.valueRegP2.HeaderText = "Valor";
            this.valueRegP2.Name = "valueRegP2";
            this.valueRegP2.ReadOnly = true;
            this.valueRegP2.Width = 40;
            // 
            // lineDataP1
            // 
            this.lineDataP1.HeaderText = "#";
            this.lineDataP1.Name = "lineDataP1";
            this.lineDataP1.ReadOnly = true;
            this.lineDataP1.Width = 25;
            // 
            // proc1P1
            // 
            this.proc1P1.HeaderText = "P1";
            this.proc1P1.Name = "proc1P1";
            this.proc1P1.ReadOnly = true;
            this.proc1P1.Width = 23;
            // 
            // proc1P2
            // 
            this.proc1P2.HeaderText = "P2";
            this.proc1P2.Name = "proc1P2";
            this.proc1P2.ReadOnly = true;
            this.proc1P2.Width = 23;
            // 
            // etiqP1
            // 
            this.etiqP1.HeaderText = "Etiq.";
            this.etiqP1.Name = "etiqP1";
            this.etiqP1.ReadOnly = true;
            this.etiqP1.Width = 35;
            // 
            // estP1
            // 
            this.estP1.HeaderText = "Est.";
            this.estP1.Name = "estP1";
            this.estP1.ReadOnly = true;
            this.estP1.Width = 27;
            // 
            // lineNumber
            // 
            this.lineNumber.HeaderText = "#";
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.ReadOnly = true;
            this.lineNumber.Width = 25;
            // 
            // dataP1
            // 
            this.dataP1.HeaderText = "P1";
            this.dataP1.Name = "dataP1";
            this.dataP1.ReadOnly = true;
            this.dataP1.Width = 23;
            // 
            // dataP2
            // 
            this.dataP2.HeaderText = "P2";
            this.dataP2.Name = "dataP2";
            this.dataP2.ReadOnly = true;
            this.dataP2.Width = 23;
            // 
            // p2Etiq
            // 
            this.p2Etiq.HeaderText = "Etiq.";
            this.p2Etiq.Name = "p2Etiq";
            this.p2Etiq.ReadOnly = true;
            this.p2Etiq.Width = 35;
            // 
            // estP2
            // 
            this.estP2.HeaderText = "Est.";
            this.estP2.Name = "estP2";
            this.estP2.ReadOnly = true;
            this.estP2.Width = 27;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1234, 693);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Procesador de hilillos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataL1P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstructP1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataL1P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstructP2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAuto;
        private Button btnStepByStep;
        private Button btnNextStep;
        private Button btnContinue;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private DataGridView dataDataL2;
        private Label label7;
        private DataGridView dataMem;
        private Label Memoria;
        private GroupBox groupBox3;
        private Label label2;
        private DataGridView dataRegP1;
        private Label label4;
        private Label label3;
        private DataGridView dataDataL1P1;
        private DataGridView dataInstructP1;
        private GroupBox groupBox4;
        private DataGridView dataDataL1P2;
        private Label label6;
        private Label label5;
        private DataGridView dataInstructP2;
        private DataGridView dataRegP2;
        private Label label8;
        private GroupBox groupBox5;
        private BindingSource programBindingSource;
        private DataGridViewTextBoxColumn lineaInstP1;
        private DataGridViewTextBoxColumn InstruccionP1;
        private DataGridViewTextBoxColumn lineaInstP2;
        private DataGridViewTextBoxColumn InstruccionP2;
        private DataGridViewTextBoxColumn numLinL2;
        private DataGridViewTextBoxColumn dataL2P1;
        private DataGridViewTextBoxColumn dataL2P2;
        private DataGridViewTextBoxColumn dataL2Etiq;
        private DataGridViewTextBoxColumn L2Est;
        private DataGridViewTextBoxColumn line1;
        private DataGridViewTextBoxColumn data1;
        private DataGridViewTextBoxColumn line2;
        private DataGridViewTextBoxColumn value2;
        private DataGridViewTextBoxColumn line3;
        private DataGridViewTextBoxColumn value3;
        private DataGridViewTextBoxColumn line4;
        private DataGridViewTextBoxColumn value4;
        private DataGridViewTextBoxColumn Line5;
        private DataGridViewTextBoxColumn value5;
        private DataGridViewTextBoxColumn lineRegP1;
        private DataGridViewTextBoxColumn estRegP1;
        private DataGridViewTextBoxColumn lineNumberRegP2;
        private DataGridViewTextBoxColumn valueRegP2;
        private DataGridViewTextBoxColumn lineDataP1;
        private DataGridViewTextBoxColumn proc1P1;
        private DataGridViewTextBoxColumn proc1P2;
        private DataGridViewTextBoxColumn etiqP1;
        private DataGridViewTextBoxColumn estP1;
        private DataGridViewTextBoxColumn lineNumber;
        private DataGridViewTextBoxColumn dataP1;
        private DataGridViewTextBoxColumn dataP2;
        private DataGridViewTextBoxColumn p2Etiq;
        private DataGridViewTextBoxColumn estP2;
    }

}

