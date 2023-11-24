using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Registro_de_Aulas {
    public partial class Form1 : Form {

        string[] aulasSplited = null;
        string aulas = "";

        string[] registoSplited = null;
        string registo = "";

        public Form1() {
            InitializeComponent();
        }


        #region Metodos Proprios

        private void XmlWrite() {
            string path = @"C:\\Users\\rafae\\Desktop\\HorasEmFalta.xml";

            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = "";

            if (File.Exists(path))
                File.Delete(path);

            XmlWriter xml = XmlWriter.Create(path, xmlSettings);

            xml.WriteStartElement("Turma");

            xml.WriteElementString("Nome",lvw1_Registo.SelectedItems[0].Text.ToString());

                xml.WriteStartElement("Disciplina");

                xml.WriteElementString("Nome", lvw1_Registo.SelectedItems[0].SubItems[1].Text);

                int horas = 0;
                foreach(ListViewItem a in lvw2_Plano.Items) {
                    if (a.SubItems[1].Text == lvw1_Registo.SelectedItems[0].SubItems[1].Text)
                        horas = Convert.ToInt32(a.SubItems[4].Text) - Convert.ToInt32(a.SubItems[3].Text);
                }
                xml.WriteElementString("HorasFalta",horas.ToString());

            xml.WriteEndElement();

            xml.Close();
            MessageBox.Show(xml.ToString());
        }


        #endregion



        #region TabPage 1

        #region MenuStripItems

        private void tsi1_GenerateCSV_Click(object sender, EventArgs e) {
            if (lbl1_File.Text == "")
                return;

            string newPath = lbl1_File.Tag.ToString().Remove(lbl1_File.Tag.ToString().Length - lbl1_File.Text.Length) + "HorasLecionadas.txt";
            if (File.Exists(newPath))
                File.Delete(newPath);


            DateTime date = DateTime.Parse(lvw1_Registo.Items[0].SubItems[2].Text);

            string text = date.ToString("MMMM") + "-" + date.Year.ToString() + "\r\n";

            for (int i = 0; i < lvw1_Registo.Items.Count; i++) {
                DateTime tempDate = DateTime.Parse(lvw1_Registo.Items[i].SubItems[2].Text);

                if (tempDate.Month != date.Month && tempDate.Year != date.Year)
                    text += tempDate.Month.ToString() + "-" + tempDate.Year.ToString();

                text += lvw1_Registo.Items[i].Text;


                double qtdHrs = 0;
                for (int idx = 0; idx < lvw1_Registo.Items.Count; idx++) {

                    if (text.Contains(lvw1_Registo.Items[idx].Text + ";" + lvw1_Registo.Items[idx].SubItems[1].Text))
                        continue;


                    DateTime dateTemp = DateTime.Parse(lvw1_Registo.Items[idx].SubItems[2].Text);

                    if (tempDate.Month == dateTemp.Month && tempDate.Year == dateTemp.Year) {
                        if (lvw1_Registo.Items[i].Text == lvw1_Registo.Items[idx].Text) {
                            if (lvw1_Registo.Items[i].SubItems[1].Text == lvw1_Registo.Items[idx].SubItems[1].Text) {
                                if (lvw1_Registo.Items[idx].SubItems[7].Text.ToUpper().Contains("FALSE")) {
                                    qtdHrs += Convert.ToDouble(lvw1_Registo.Items[idx].SubItems[3].Text);
                                }                                    
                            }
                        }
                    }
                }
                text += ";" + lvw1_Registo.Items[i].SubItems[1].Text;
                text += ";" + Convert.ToDecimal(qtdHrs).ToString() + "\n";
            }

            using (StreamWriter fs = File.CreateText("C:\\Users\\rafae\\Desktop\\HorasLecionadas.csv")) {
                fs.WriteLine(text);
            }
        }

        private void tsi1_Open_Click(object sender, EventArgs e) {
            fld1_Aulas.ShowDialog();
        }

        private void tsi1_GenerateJSON_Click(object sender, EventArgs e)
        {

        }


        #endregion



        #region FileDialog

        private void fld1_Aulas_FileOk(object sender, CancelEventArgs e) {
            string path = fld1_Aulas.FileName;
            lbl1_File.Text = path.Split('\\')[path.Split('\\').Length - 1];
            lbl1_File.Tag = path;


            if (Path.GetExtension(path) != ".csv")
                return;

            aulas = "";
            using (FileStream fs = File.OpenRead(path)) {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;

                
                while ((readLen = fs.Read(b, 0, b.Length)) > 0) {
                    aulas += (temp.GetString(b, 0, readLen));
                }

            }

            aulasSplited = aulas.Split(new char[] { '\n', ';' });

            lvw1_Registo.Items.Clear();
            for (int i = 0; i < aulasSplited.Length - 8; i+=8) {
                ListViewItem lst = new ListViewItem();
                lst.Text = aulasSplited[i];
                lst.SubItems.Add(aulasSplited[i + 1]);
                lst.SubItems.Add(aulasSplited[i + 2]);
                lst.SubItems.Add(aulasSplited[i + 3]);
                lst.SubItems.Add(aulasSplited[i + 4]);
                lst.SubItems.Add(aulasSplited[i + 5]);
                lst.SubItems.Add(aulasSplited[i + 6]);
                lst.SubItems.Add(aulasSplited[i + 7]);

                lvw1_Registo.Items.Add(lst);
            }

           

        }


        #endregion



        #region CheckBoxs

        private void chk1_Turma_CheckedChanged(object sender, EventArgs e) {
            if (chk1_Turma.Checked)
                lvw1_Registo.Columns[0].Width = 0;
            else
                lvw1_Registo.Columns[0].Width = 130;
        }

        private void chk1_Disciplina_CheckedChanged(object sender, EventArgs e) {
            if (chk1_Disciplina.Checked)
                lvw1_Registo.Columns[1].Width = 0;
            else
                lvw1_Registo.Columns[1].Width = 130;
        }

        private void chk1_Docente_CheckedChanged(object sender, EventArgs e) {
            if (chk1_Docente.Checked)
                lvw1_Registo.Columns[4].Width = 0;
            else
                lvw1_Registo.Columns[4].Width = 130;
        }

        private void chk1_Faltou_CheckedChanged(object sender, EventArgs e) {
            if (chk1_Faltou.Checked)
                lvw1_Registo.Columns[7].Width = 0;
            else
                lvw1_Registo.Columns[7].Width = 130;
        }


        #endregion


        #endregion



        #region TabPage 2

        #region MenuStripItems

        private void tsi2_Open_Click(object sender, EventArgs e) {
            fld2_Plano.ShowDialog();
        }

        private void tsi2_GenerateXML_Click(object sender, EventArgs e) {

        }

        private void tsi2_GenerateBIN_Click(object sender, EventArgs e)
        {

        }

        private void tsi2_Update_Click(object sender, EventArgs e) {
            if (lvw2_Plano.Items.Count == 0) {
                MessageBox.Show("Não existe registo de aulas selecionado", "Carga Horária : Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(lbl2_File.Tag.ToString())) {
                return;
            }

            string text = "";
            using (FileStream fs = File.OpenRead(lbl2_File.Tag.ToString())) {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;


                while ((readLen = fs.Read(b, 0, b.Length)) > 0) {
                    text += (temp.GetString(b, 0, readLen));
                }

            }
            string[] info = text.Split(new char[] { '\n', ';' });

            for (int i = 5; i < info.Length-1; i += 5) {
                foreach(ListViewItem a in lvw1_Registo.Items) {
                    if(a.Text == info[i] && a.SubItems[1].Text == info[i+1])
                        info[i+3] = a.SubItems[3].Text;
                }
            }
            text = lvw2_Plano.Tag.ToString() + "\n";
            for(int i = 5; i < info.Length-1; i++) {
                text += info[i];
                if((i - 1) % 5 == 0) {
                    text += "\n";
                } else {
                    text += ";";
                }
            }

            using (StreamWriter writer = new StreamWriter(lbl2_File.Tag.ToString())) {
                writer.Write(text);
            }

        }


        #endregion



        #region FileDialog

        private void fld2_Plano_FileOk(object sender, CancelEventArgs e) {
            string path = fld2_Plano.FileName;
            lbl2_File.Text = path.Split('\\')[path.Split('\\').Length-1];
            lbl2_File.Tag = path;

            if (Path.GetExtension(path) != ".csv")
                return;

            registo = "";
            using (FileStream fs = File.OpenRead(path)) {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;


                while ((readLen = fs.Read(b, 0, b.Length)) > 0) {
                    registo += (temp.GetString(b, 0, readLen));
                }

            }
            registoSplited = registo.Split(new char[] { '\n', ';' });
            

            lvw2_Plano.Tag = registoSplited[0];

            lvw2_Plano.Items.Clear();
            int idx = 0;
            for(int i = 0; i < registoSplited.Length -1; i++) {
                DateTime date = new DateTime();
                bool temp = DateTime.TryParse(registoSplited[i], out date);
                if (temp) {
                    idx = i+1; 
                    break;
                }
            }
            for (int i = idx; i < registoSplited.Length-1; i += 5) {
                
                ListViewItem lst = new ListViewItem();
                lst.Text = registoSplited[i];
                lst.SubItems.Add(registoSplited[i + 1]);
                lst.SubItems.Add(registoSplited[i + 2]);
                lst.SubItems.Add(registoSplited[i + 3]);
                lst.SubItems.Add(registoSplited[i + 4]);

                lvw2_Plano.Items.Add(lst);
            }
        }






        #endregion



        #region Textbox

        private void txt2_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt2_Search.Text.Trim() == "")
                return;



            lvw2_Plano.Items.Clear();
            int idx = 0;
            for (int i = 0; i < registoSplited.Length - 1; i++)
            {
                DateTime date = new DateTime();
                bool temp = DateTime.TryParse(registoSplited[i], out date);
                if (temp)
                {
                    idx = i + 1;
                    break;
                }
            }
            for (int i = idx; i < registoSplited.Length - 1; i += 5)
            {
                if (registoSplited[i].ToUpper().Contains(txt2_Search.Text.ToUpper()) || registoSplited[i + 1].ToUpper().Contains(txt2_Search.Text.ToUpper()) || txt2_Search.Text.Trim().Length == 0)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = registoSplited[i];
                    lst.SubItems.Add(registoSplited[i + 1]);
                    lst.SubItems.Add(registoSplited[i + 2]);
                    lst.SubItems.Add(registoSplited[i + 3]);
                    lst.SubItems.Add(registoSplited[i + 4]);

                    lvw2_Plano.Items.Add(lst);
                }

            }
        }





        #endregion

        #endregion


    }
}
