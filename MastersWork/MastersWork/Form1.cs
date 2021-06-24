using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MastersWork {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            OpenFile.Filter = "Text files(*.cpp)|*.cpp|All files(*.*)|*.*";
            OpenFile.InitialDirectory = AppDomain.CurrentDomain.RelativeSearchPath;
        }

        public Dictionary<string, string> lstWithNameAndTypeDataContainers;
        public List<string> lstWithTypeContainers;
        public List<int> lstWithCountOperationFindElementsInContainers;
        public List<int> lstWithIndexStrWithContainers;
        
        private void ToChooseFile_Click(object sender, EventArgs e) {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;

            richTextBox1.Text = ReadFile(OpenFile.FileName); ;
            statusStrip1.Visible = true;
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = OpenFile.FileName;
        }

        private string ReadFile(string path) {
            string text = "";
            try {
                using (StreamReader read = new StreamReader(path, System.Text.Encoding.Default)) {
                    string line = "";
                    while ((line = read.ReadLine()) != null) {
                        text += line + '\n';
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка чтения из файла: " + ex.Message + "\n" + ex.Source);
            }
            return text;
        }

        private void CodeAnalysis_Click(object sender, EventArgs e) {
            if (OpenFile.FileName == "") {
                MessageBox.Show("Не выбран файл");
            }
            else {
                ParsingClass parsing = new ParsingClass(richTextBox1.Text);
                parsing.ParsingText();
                lstWithNameAndTypeDataContainers = parsing.infoContainers;
                lstWithTypeContainers = parsing.lstWithTypeIter;
                lstWithCountOperationFindElementsInContainers = parsing.countOperationFindElement;
                lstWithIndexStrWithContainers = parsing.indexStrContainers;
                MyTable.Visible = true;
                MyTable.RowCount = lstWithNameAndTypeDataContainers.Count;
                ToFillTable();
                CalculationWin.Visible = true;
            }
        }

        /*
        * Заполнение таблицы начальными значениями
        */
        private void ToFillTable() {
            int index = 0;
            MyTable.Height = dataGridViewHeight();
            foreach (KeyValuePair<string, string> tmp in lstWithNameAndTypeDataContainers) {
                MyTable.Rows[index].Cells[1].Value = tmp.Key;
                MyTable.Rows[index].Cells[2].Value = tmp.Value;
                index++;
            }
            for (int i = 0; i < lstWithNameAndTypeDataContainers.Count; i++) {
                MyTable.Rows[i].Cells[0].Value = false;
                MyTable.Rows[i].Cells[5].Value = "???";
                MyTable.Rows[i].Cells[3].Value = lstWithTypeContainers[i];
                MyTable.Rows[i].Cells[4].Value = lstWithIndexStrWithContainers[i];
                MyTable.Rows[i].Cells[6].Value = lstWithCountOperationFindElementsInContainers[i];
            }
        }

        private int dataGridViewHeight() {
            int sum = MyTable.ColumnHeadersHeight;
            foreach (DataGridViewRow row in MyTable.Rows)
                sum += row.Height + 1;
            return sum;
        }

        public double myWin;
        double v, resultV, scomp, smap;
        int n;

        
        private void AutoCalcWinButton_Click(object sender, EventArgs e) {
            if (LimitMemory.Text == "" || CountIteration.Text == "" || IsCheckToPressButton() == false)
                MessageBox.Show("Не все параметры введены!");
            else {
                byte[] perebWinMonte = new byte[lstWithNameAndTypeDataContainers.Count];
                myWin = double.MaxValue; // лучшая значение целевой функции
                resultV = 0; // число задействованной памяти в лучшем переборе
                Random rnd = new Random();
                double[] arrayV = new double[lstWithNameAndTypeDataContainers.Count]; // массив с занимаемой памятью каждого контейнера
                byte[] perebor = new byte[lstWithNameAndTypeDataContainers.Count]; // массив выигрышного перебора
                v = Convert.ToDouble(LimitMemory.Text);
                n = Convert.ToInt32(CountIteration.Text);
                scomp = Convert.ToDouble(SCompareText.Text);
                smap = Convert.ToDouble(SMapText.Text);

                for (byte pere = 0; pere < perebor.Length; pere++) {
                    MyTable.Rows[pere].Cells[0].Value = 0;
                }
                if (flagAllSolution.Checked == true)
                    AllSolutionsTxtBox.Visible = true;
                else
                    AllSolutionsTxtBox.Visible = false;
                for (int i = 0; i < n; i++) {
                    for (int p = 0; p < perebor.Length; p++) perebor[p] = (byte)rnd.Next(0, 2);

                    double tmpF = 0;
                    double tmpV = 0;
                    double[] tmpArr = new double[lstWithNameAndTypeDataContainers.Count];
                    for (int j = 0; j < perebor.Length; j++) {
                        if(flagAllSolution.Checked == true) AllSolutionsTxtBox.Text += perebor[j] + " ";
                        if (perebor[j] == 1) {
                            tmpV += Convert.ToInt16(MyTable.Rows[j].Cells[5].Value) * ToDefineType(MyTable.Rows[j].Cells[2].Value.ToString());
                            double t = ToDefineType(MyTable.Rows[j].Cells[2].Value.ToString()) / scomp;
                            tmpF += Convert.ToInt16(MyTable.Rows[j].Cells[6].Value) * t * Math.Log(Convert.ToInt16(MyTable.Rows[j].Cells[5].Value), 2) + ((Convert.ToInt16(MyTable.Rows[j].Cells[5].Value) * ToDefineType(MyTable.Rows[j].Cells[2].Value.ToString())) / smap);
                            tmpArr[j] = Convert.ToInt16(MyTable.Rows[j].Cells[5].Value) * ToDefineType(MyTable.Rows[j].Cells[2].Value.ToString());
                        } else {
                            if (MyTable.Rows[j].Cells[3].Value.ToString() == "vector") {
                                double t = ToDefineType(MyTable.Rows[j].Cells[2].Value.ToString()) / scomp;
                                tmpF += Convert.ToInt16(MyTable.Rows[j].Cells[6].Value) * t * (Convert.ToInt16(MyTable.Rows[j].Cells[5].Value) / 2);
                            }
                            else {
                                double t = ToDefineType(MyTable.Rows[j].Cells[2].Value.ToString()) / scomp;
                                tmpF += Convert.ToInt16(MyTable.Rows[j].Cells[6].Value) * t * 15 * (Convert.ToInt16(MyTable.Rows[j].Cells[5].Value) / 2);
                            }
                        }
                    }
                    if (flagAllSolution.Checked == true) AllSolutionsTxtBox.Text += tmpF + " " + tmpV + "\n";
                    if (tmpV <= v && myWin > tmpF) {
                        myWin = tmpF;
                        resultV = tmpV;
                        Array.Copy(tmpArr, arrayV, arrayV.Length);
                        Array.Copy(perebor, perebWinMonte, perebor.Length);
                    }
                }

                for (int i = 0; i < perebor.Length; i++) {
                    if (perebWinMonte[i] == 0) {
                        MyTable.Rows[i].Cells[8].Style.BackColor = Color.Red;
                        MyTable.Rows[i].Cells[8].Value = "нет";
                    }
                    else {
                        MyTable.Rows[i].Cells[0].Value = true;
                        MyTable.Rows[i].Cells[8].Style.BackColor = Color.Green;
                        MyTable.Rows[i].Cells[8].Value = "да";
                    }
                    MyTable.Rows[i].Cells[7].Value = arrayV[i];
                }

                labelAWithWin.Text = "";
                labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
            }
        }

        bool IsCheckToPressButton() {
            for (int i = 0; i < lstWithNameAndTypeDataContainers.Count; i++) {
                if ((MyTable.Rows[i].Cells[5].Value.Equals("???")) || (MyTable.Rows[i].Cells[5].Value.Equals("")) || (Convert.ToInt16(MyTable.Rows[i].Cells[5].Value) <= 0))
                    return false;
            }
            return true;
        }

        double ToDefineType(string type) {
            switch (type) {
                case "byte":
                    return 1;
                case "int":
                    return 4;
                case "double":
                    return 8;
                case "float":
                    return 4;
                case "char":
                    return 2;
                default:
                    return 4;
            }
        }

        private void SMapText_Enter(object sender, EventArgs e) {
            SMapText.Text = "";
            SMapText.ForeColor = Color.Black;
        }

        private void SMapText_Leave(object sender, EventArgs e) {
            if (SMapText.Text == "") {
                SMapText.Text = "10000000000";
                SMapText.ForeColor = Color.Silver;
            }
        }

        private void SCompareText_Enter(object sender, EventArgs e) {
            SCompareText.Text = "";
            SCompareText.ForeColor = Color.Black;
        }

        int k = 0;
        private void MyTable_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (Convert.ToInt16(MyTable.SelectedCells[0].ColumnIndex) != 0)
                return;
            k = 0;
            MyTable.EndEdit();
            if (k == 1)
                return;
            else {
                if (LimitMemory.Text == "" || CountIteration.Text == "" || IsCheckToPressButton() == false) {
                    MyTable.Rows[MyTable.SelectedCells[0].RowIndex].Cells[0].Value = 0;
                    MessageBox.Show("Не все параметры введены!");
                    k = 1;
                    return;
                }
                else {
                    k++;
                    v = Convert.ToDouble(LimitMemory.Text);
                    int index = MyTable.SelectedCells[0].RowIndex;
                    if (Convert.ToBoolean(MyTable.CurrentCell.Value) == true) {
                        resultV += Convert.ToInt16(MyTable.Rows[index].Cells[5].Value) * ToDefineType(MyTable.Rows[index].Cells[2].Value.ToString());
                        MyTable.Rows[index].Cells[7].Value = resultV;
                        scomp = Convert.ToDouble(SCompareText.Text);
                        smap = Convert.ToDouble(SMapText.Text);
                        double t = ToDefineType(MyTable.Rows[index].Cells[2].Value.ToString()) / scomp;
                        myWin += Convert.ToInt16(MyTable.Rows[index].Cells[6].Value) * t * Math.Log(Convert.ToInt16(MyTable.Rows[index].Cells[5].Value), 2) + ((Convert.ToInt16(MyTable.Rows[index].Cells[5].Value) * ToDefineType(MyTable.Rows[index].Cells[2].Value.ToString())) / smap);
                        if (resultV <= v) {
                            labelAWithWin.Text = "";
                            labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
                        }
                        else {
                            labelAWithWin.Text = "";
                            labelAWithWin.Text = "Ограничение не выполняется, " + " затрачено: " + resultV + " байт";
                        }
                        return;
                    }
                    else {
                        scomp = Convert.ToDouble(SCompareText.Text);
                        smap = Convert.ToDouble(SMapText.Text);
                        resultV -= Convert.ToInt16(MyTable.Rows[index].Cells[5].Value) * ToDefineType(MyTable.Rows[index].Cells[2].Value.ToString());
                        double t = ToDefineType(MyTable.Rows[index].Cells[2].Value.ToString()) / scomp;
                        myWin -= Convert.ToInt16(MyTable.Rows[index].Cells[6].Value) * t * Math.Log(Convert.ToInt16(MyTable.Rows[index].Cells[5].Value), 2) + ((Convert.ToInt16(MyTable.Rows[index].Cells[5].Value) * ToDefineType(MyTable.Rows[index].Cells[2].Value.ToString())) / smap);
                        MyTable.Rows[index].Cells[6].Value = 0;
                        if (resultV <= v) {
                            labelAWithWin.Text = "";
                            labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
                        }
                        else {
                            labelAWithWin.Text = "";
                            labelAWithWin.Text = "Ограничение не выполняется, " + " затрачено: " + resultV + " байт";
                        }
                        return;
                    }
                }
            }
        }

        private void SCompareText_Leave(object sender, EventArgs e) {
            if (SCompareText.Text == "") {
                SCompareText.Text = "10000000000000";
                SCompareText.ForeColor = Color.Silver;
            }
        }

        private void CountIteration_Enter(object sender, EventArgs e) {
            CountIteration.Text = "";
            CountIteration.ForeColor = Color.Black;
        }

        private void CountIteration_Leave(object sender, EventArgs e) {
            if (CountIteration.Text == "") {
                CountIteration.Text = "10000";
                CountIteration.ForeColor = Color.Silver;
            }
        }

    }
}
