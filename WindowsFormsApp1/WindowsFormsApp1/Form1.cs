using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: cambiar el nombre a algo mas intuitivo que WindowsFormsApp1
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Proceso 1
        string[] instP1;
        int[,] datL1P1;
        int[] regP1;

        //Proceso 2
        string[] instP2;
        int[,] datL1P2;
        int[] regP2;

        //Datos compartidos
        int[,] datL2;

        string[] mem;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitData();
            InitializeComponent();

            RefreshData(1);
        }

        private void InitData() {
            //Proceso 1
            instP1 = new string[4];
            datL1P1 = new int[4, 4];
            regP1 = new int[32];

            //Proceso 2
            instP2 = new string[4];
            datL1P2 = new int[4, 4];
            regP2 = new int[32];

            //Datos compartidos
            datL2 = new int[8, 4];
            mem = new string[200];
            for (int i = 0; i < 200; i++) {
                mem[i] = "0";
            }
        }


        //Recibe un parametro, si es 1, refresca memoria, sino solo los hilillos y la memoria L2
        public void RefreshData(int param) {
            LlenaProc(1);
            LlenaProc(2);
            LlenaComp(param);
        }

        //Recibe un parametro, si es 1, refresca memoria, sino solo los hilillos y la memoria L2
        private void LlenaComp(int param) {

            var dataP1 = getDataFromMatrix(datL2);
            (dataDataL2).Rows.Clear();
            foreach (var b in dataP1)
            {
                populateData(dataDataL2, b[0], b[1], b[2], b[3], b[4]);
            }
            dataP1 = null;

            //Memoria solo se actualiza cuando se cambia algo en memoria, esto es llamado por un hilo.
            if (param > 0)
                RefreshMem();
        }


        public void RefreshMem() {
            List<string> dataMe = mem.ToList();
            dataMem.Rows.Clear();
            populateMem(dataMem, dataMe);
            dataMe = null;
        }

        private void LlenaProc(int proc) {


            //Ingresa los valores de las instrucciones.
            var dataInstP1 = (proc < 2 ? instP1 : instP2).Select((x, index) => new { lineaInstP1 = index + 1, InstruccionP1 = x })
                                        .OrderBy(x => x.lineaInstP1).ToList();
            (proc < 2 ? dataInstructP1 : dataInstructP2).Rows.Clear();
            foreach (var b in dataInstP1)
            {
                populateInst(proc<2?dataInstructP1 : dataInstructP2, b.lineaInstP1, b.InstruccionP1);
            }
            dataInstP1 = null;
            
            //Ingresa los valores de los datos
            var dataP1 = getDataFromMatrix(proc < 2 ? datL1P1 : datL1P2);
            (proc < 2 ? dataDataL1P1 : dataDataL1P2).Rows.Clear();
            foreach (var b in dataP1)
            {
                populateData(proc < 2 ? dataDataL1P1 : dataDataL1P2, b[0], b[1], b[2], b[3], b[4]);
            }
            dataP1 = null;

            //Ingresa valores de registros
            var regP1Data = (proc < 2 ? regP1 : regP2).Select((x, index) => new { lineRegP1 = index + 1, estRegP1 = x })
                                        .OrderBy(x => x.lineRegP1).ToList();
            (proc < 2 ? dataRegP1 : dataRegP2).Rows.Clear(); 
            foreach (var b in regP1Data)
            {
                populateReg(proc < 2 ? dataRegP1 : dataRegP2, b.lineRegP1, b.estRegP1);
            }
            regP1Data = null;
        }
        
        private List<List<int>> getDataFromMatrix(int[,] datL1P1) {
            List<List<int>> resp = new List<List<int>>();
            List<int> auxList;
            int tam = datL1P1.Length/4;
            for (int i = 0; i < tam; i++) { 
                auxList = new List<int>();
                auxList.Add(i+1);
                for (int p = 0; p < 4; p++)
                    auxList.Add(datL1P1[i,p]);
                resp.Add(auxList);
            }
            return resp;
        }
        
        private void populateData(DataGridView dataGridView, int line, int? p1, int? p2, int? etiq, int? est)
        {
            dataGridView.Rows.Add(line, p1 == null ? "/" : p1.ToString(), p2 == null ? "/" : p2.ToString(), etiq == null ? "/" : etiq.ToString(), est == null ? "/" : est == 0 ? "C" : est == 1 ? "M" : "I");
        }

        private void populateInst(DataGridView dataGridView, int line, string inst)
        {
            dataGridView.Rows.Add(line, inst == null? "No hay.":inst);
        }

        private void populateReg(DataGridView dataGridView, int line, int? data)
        {
            dataGridView.Rows.Add(line, data == null ? "/" : data.ToString());
        }

        private void populateMem(DataGridView dataGridViewMem, List<string> memData)
        {
            int tam = memData.Count;

            //TODO: corregir este caso
            memData.Add("0");memData.Add("0"); memData.Add("0"); memData.Add("0");
            for (int i = 0; i < tam; i+=5)
            {
                dataGridViewMem.Rows.Add(i , memData[i], (i + 1) , memData[i + 1],
                                        (i + 2) , memData[i + 2], (i + 3) , memData[i + 3],
                                        (i + 4) , memData[i + 4], (i + 5) , memData[i + 5]);
            }
            //TODO: corregir este caso
            memData.Remove(memData.Last()); memData.Remove(memData.Last()); memData.Remove(memData.Last()); memData.Remove(memData.Last());
        }


        private void  DummyMethod(int sum) {
            for (int i = 0; i < datL1P1.Length/4; i++) {
                for (int j = 0; j < 2; j++)
                {
                    datL1P1[i,j] = datL1P1[i,j] + sum;
                }
            }

            for (int i = 0; i < datL1P2.Length/4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    datL1P2[i, j] = datL1P1[i, j] + sum;
                }
            }
        }


        private void btnNextStep_Click(object sender, EventArgs e)
        {
            Thread P1 = new Thread(() => DummyMethod(1));
            Thread P2 = new Thread(() => DummyMethod(4));
            P1.Start();
            P2.Start();
            
            Task.WaitAll();
            RefreshData(0);


            btnNextStep.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Thread P1 = new Thread(() => DummyMethod(2));
            Thread P2 = new Thread(() => DummyMethod(5));
            P1.Start();
            P2.Start();

            Task.WaitAll();

            btnContinue.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = " Archivos txt(*.txt)|*.txt";
            obj.Title = "Programa";
            if (obj.ShowDialog() == DialogResult.OK) {
                fileDirection.Text = obj.FileName;
            }
        }

        private void getProgram_Click(object sender, EventArgs e)
        {
            string data;
            if (fileDirection != null && fileDirection.Text.Length > 0) {
                try
                {
                    data = File.ReadAllText(@fileDirection.Text);
                }
                catch {
                    fileDirection.Text = "Error al cargar dicho archivo.";
                    
                }
            }
        }
    }
        
}
