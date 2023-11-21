﻿using System;
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

        private void tsi1_Generate_Click(object sender, EventArgs e) {
            if (lbl_File.Text == "")
                return;

            string newPath = lbl_File.Tag.ToString().Remove(lbl_File.Tag.ToString().Length - lbl_File.Text.Length) + "HorasLecionadas.txt";
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
                        MessageBox.Show(lvw1_Registo.Items[i].Text + " - " + lvw1_Registo.Items[idx].Text);
                        if (lvw1_Registo.Items[i].Text == lvw1_Registo.Items[idx].Text) {
                            if (lvw1_Registo.Items[i].SubItems[1].Text == lvw1_Registo.Items[idx].SubItems[1].Text) {
                                if (lvw1_Registo.Items[idx].SubItems[7].Text == "FALSE")
                                    qtdHrs += Convert.ToDouble(lvw1_Registo.Items[idx].SubItems[3].Text);
                            }
                        }
                    }
                }
                text += ";" + lvw1_Registo.Items[i].SubItems[1].Text;
                text += ";" + Convert.ToDecimal(qtdHrs).ToString();
            }

            using (StreamWriter fs = File.CreateText("C:\\Users\\rafae\\Desktop\\HorasLecionadas.txt")) {
                fs.WriteLine(text);
            }
        }

        private void tsi1_Open_Click(object sender, EventArgs e) {
            fld1_Aulas.ShowDialog();
        }

        private void fld_Explorer_FileOk(object sender, CancelEventArgs e) {
            string path = fld1_Aulas.FileName;

            if (Path.GetExtension(path) != ".csv")
                return;

            string[] fileName = path.Split('\\');
            lbl_File.Text = fileName[fileName.Length-1];
            lbl_File.Tag = fileName;

            string text = "";
            using (FileStream fs = File.OpenRead(path)) {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;

                
                while ((readLen = fs.Read(b, 0, b.Length)) > 0) {
                    text += (temp.GetString(b, 0, readLen));
                }

            }

            string[] info = text.Split(new char[] { '\n', ';' });


            for(int i = 0; i < info.Length - 8; i+=8) {
                ListViewItem lst = new ListViewItem();
                lst.Text = info[i];
                lst.SubItems.Add(info[i + 1]);
                lst.SubItems.Add(info[i + 2]);
                lst.SubItems.Add(info[i + 3]);
                lst.SubItems.Add(info[i + 4]);
                lst.SubItems.Add(info[i + 5]);
                lst.SubItems.Add(info[i + 6]);
                lst.SubItems.Add(info[i + 7]);

                lvw1_Registo.Items.Add(lst);
            }

           

        }

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



        #region TabPage 2

        private void tsi2_Open_Click(object sender, EventArgs e) {
            fld2_Plano.ShowDialog();
        }

        private void fld2_Plano_FileOk(object sender, CancelEventArgs e) {
            string path = fld2_Plano.FileName;

            if (Path.GetExtension(path) != ".csv")
                return;

            string text = "";
            
            using (FileStream fs = File.OpenRead(path)) {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;


                while ((readLen = fs.Read(b, 0, b.Length)) > 0) {
                    text += (temp.GetString(b, 0, readLen));
                }

            }
            string[] info = text.Split(new char[] { '\n', ';' });
            



            for (int i = 5; i < info.Length-1; i += 5) {
                ListViewItem lst = new ListViewItem();
                lst.Text = info[i];
                lst.SubItems.Add(info[i + 1]);
                lst.SubItems.Add(info[i + 2]);
                lst.SubItems.Add(info[i + 3]);
                lst.SubItems.Add(info[i + 4]);

                lvw2_Plano.Items.Add(lst);
            }
        }



        #endregion

        private void tsi2_Generate_Click(object sender, EventArgs e) {
            if (lvw1_Registo.SelectedItems.Count == 0) {
                MessageBox.Show("Não existe nenhuma turma selecionada", "Carga Horária : Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idx = -1;
            foreach(ListViewItem a in lvw2_Plano.Items) {
                if (a.Text == lvw1_Registo.SelectedItems[0].Text)
                    idx = a.Index;
            }
            if (idx == -1) {
                MessageBox.Show("Não existe registo de horas para a turma selecionada", "Carga Horária : Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlWrite();
                
        }
    }
}