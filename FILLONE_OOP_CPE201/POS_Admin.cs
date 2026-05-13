using FILLONE_OOP_CPE201;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace FILLONE_OOP_CPE201
{
    public partial class POS_Admin : Form
    {
        pos_dbconnection pos_dbconnect = new pos_dbconnection();
        private string picpath;
        private Image pic;

        public POS_Admin()
        {
            pos_dbconnect.pos_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\Ali\\Desktop\\OOP\\FILLONE_OOP_CPE201\\FILLONE_OOP_CPE201\\food bundles pictures\\default.jpg");
                picpathtxtbox1.Clear();
                picpathtxtbox2.Clear();
                picpathtxtbox3.Clear();
                picpathtxtbox4.Clear();
                picpathtxtbox5.Clear();
                picpathtxtbox6.Clear();
                picpathtxtbox7.Clear();
                picpathtxtbox8.Clear();
                picpathtxtbox9.Clear();
                picpathtxtbox10.Clear();
                picpathtxtbox11.Clear();
                picpathtxtbox12.Clear();
                picpathtxtbox13.Clear();
                picpathtxtbox14.Clear();
                picpathtxtbox15.Clear();
                picpathtxtbox16.Clear();
                picpathtxtbox17.Clear();
                picpathtxtbox18.Clear();
                picpathtxtbox19.Clear();
                picpathtxtbox20.Clear();

                picbox1.Image = pic;
                picbox2.Image = pic;
                picbox3.Image = pic;
                picbox4.Image = pic;
                picbox5.Image = pic;
                picbox6.Image = pic;
                picbox7.Image = pic;
                picbox8.Image = pic;
                picbox9.Image = pic;
                picbox10.Image = pic;
                picbox11.Image = pic;
                picbox12.Image = pic;
                picbox13.Image = pic;
                picbox14.Image = pic;
                picbox15.Image = pic;
                picbox16.Image = pic;
                picbox17.Image = pic;
                picbox18.Image = pic;
                picbox19.Image = pic;
                picbox20.Image = pic;

                pricetxtbox1.Clear();
                pricetxtbox2.Clear();
                pricetxtbox3.Clear();
                pricetxtbox4.Clear();
                pricetxtbox5.Clear();
                pricetxtbox6.Clear();
                pricetxtbox7.Clear();
                pricetxtbox8.Clear();
                pricetxtbox9.Clear();
                pricetxtbox10.Clear();
                pricetxtbox11.Clear();
                pricetxtbox12.Clear();
                pricetxtbox13.Clear();
                pricetxtbox14.Clear();
                pricetxtbox15.Clear();
                pricetxtbox16.Clear();
                pricetxtbox17.Clear();
                pricetxtbox18.Clear();
                pricetxtbox19.Clear();
                pricetxtbox20.Clear();

                nametxtbox1.Clear();
                nametxtbox2.Clear();
                nametxtbox3.Clear();
                nametxtbox4.Clear();
                nametxtbox4.Clear();
                nametxtbox5.Clear();
                nametxtbox6.Clear();
                nametxtbox7.Clear();
                nametxtbox8.Clear();
                nametxtbox9.Clear();
                nametxtbox10.Clear();
                nametxtbox11.Clear();
                nametxtbox12.Clear();
                nametxtbox13.Clear();
                nametxtbox14.Clear();
                nametxtbox15.Clear();
                nametxtbox16.Clear();
                nametxtbox17.Clear();
                nametxtbox18.Clear();
                nametxtbox19.Clear();
                nametxtbox20.Clear();
            }
            catch
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void open_file_image()
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            openFileDialog1.ShowDialog();
        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                picpathtxtbox1.Hide();
                picpathtxtbox2.Hide();
                picpathtxtbox3.Hide();
                picpathtxtbox4.Hide();
                picpathtxtbox5.Hide();
                picpathtxtbox6.Hide();
                picpathtxtbox7.Hide();
                picpathtxtbox8.Hide();
                picpathtxtbox9.Hide();
                picpathtxtbox10.Hide();
                picpathtxtbox11.Hide();
                picpathtxtbox12.Hide();
                picpathtxtbox13.Hide();
                picpathtxtbox14.Hide();
                picpathtxtbox15.Hide();
                picpathtxtbox16.Hide();
                picpathtxtbox17.Hide();
                picpathtxtbox18.Hide();
                picpathtxtbox19.Hide();
                picpathtxtbox20.Hide();

                pos_dbconnect.pos_select();
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterSelect();
                pos_dbconnect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = pos_dbconnect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                pos_dbconnect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) VALUES ('" + pos_id_comboBox.Text + "', '" + nametxtbox1.Text + "', '" + nametxtbox2.Text + "', '" + nametxtbox3.Text + "', '" + nametxtbox4.Text + "', '" + nametxtbox5.Text + "', '" + nametxtbox6.Text + "', '" + nametxtbox7.Text + "', '" + nametxtbox8.Text + "', '" + nametxtbox9.Text + "', '" + nametxtbox10.Text + "', '" + nametxtbox11.Text + "', '" + nametxtbox12.Text + "', '" + nametxtbox13.Text + "', '" + nametxtbox14.Text + "', '" + nametxtbox15.Text + "', '" + nametxtbox16.Text + "', '" + nametxtbox17.Text + "', '" + nametxtbox18.Text + "', '" + nametxtbox19.Text + "', '" + nametxtbox20.Text + "')";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterInsert();

                pos_dbconnect.pos_sql = "INSERT INTO pos_priceTbl (pos_id, price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20) VALUES ('" + pos_id_comboBox.Text + "', '" + pricetxtbox1.Text + "', '" + pricetxtbox2.Text + "', '" + pricetxtbox3.Text + "', '" + pricetxtbox4.Text + "', '" + pricetxtbox5.Text + "', '" + pricetxtbox6.Text + "', '" + pricetxtbox7.Text + "', '" + pricetxtbox8.Text + "', '" + pricetxtbox9.Text + "', '" + pricetxtbox10.Text + "', '" + pricetxtbox11.Text + "', '" + pricetxtbox12.Text + "', '" + pricetxtbox13.Text + "', '" + pricetxtbox14.Text + "', '" + pricetxtbox15.Text + "', '" + pricetxtbox16.Text + "', '" + pricetxtbox17.Text + "', '" + pricetxtbox18.Text + "', '" + pricetxtbox19.Text + "', '" + pricetxtbox20.Text + "')";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterInsert();

                pos_dbconnect.pos_sql = "INSERT INTO pos_picTBbl (pos_id, pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20) VALUES ('" + pos_id_comboBox.Text + "', '" + picpathtxtbox1.Text + "', '" + picpathtxtbox2.Text + "', '" + picpathtxtbox3.Text + "', '" + picpathtxtbox4.Text + "', '" + picpathtxtbox5.Text + "', '" + picpathtxtbox6.Text + "', '" + picpathtxtbox7.Text + "', '" + picpathtxtbox8.Text + "', '" + picpathtxtbox9.Text + "', '" + picpathtxtbox10.Text + "', '" + picpathtxtbox11.Text + "', '" + picpathtxtbox12.Text + "', '" + picpathtxtbox13.Text + "', '" + picpathtxtbox14.Text + "', '" + picpathtxtbox15.Text + "', '" + picpathtxtbox16.Text + "', '" + picpathtxtbox17.Text + "', '" + picpathtxtbox18.Text + "', '" + picpathtxtbox19.Text + "', '" + picpathtxtbox20.Text + "')";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterInsert();

                pos_dbconnect.pos_select();
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterSelect();
                pos_dbconnect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = pos_dbconnect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            try
            {
                pos_dbconnect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTBbl ON pos_nameTbl.pos_id = pos_picTBbl.pos_id INNER JOIN pos_priceTbl ON pos_picTBbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '" + pos_id_comboBox.Text + "'";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterSelect();

                pos_dbconnect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = pos_dbconnect.pos_sql_dataset.Tables[0];
                nametxtbox1.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                nametxtbox2.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                nametxtbox3.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                nametxtbox4.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                nametxtbox5.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                nametxtbox6.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                nametxtbox7.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                nametxtbox8.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                nametxtbox9.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                nametxtbox10.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                nametxtbox11.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                nametxtbox12.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                nametxtbox13.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                nametxtbox14.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                nametxtbox15.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                nametxtbox16.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                nametxtbox17.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                nametxtbox18.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                nametxtbox19.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                nametxtbox20.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpathtxtbox1.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                picbox1.Image = Image.FromFile(picpathtxtbox1.Text);

                picpathtxtbox2.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                picbox2.Image = Image.FromFile(picpathtxtbox2.Text);

                picpathtxtbox3.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                picbox3.Image = Image.FromFile(picpathtxtbox3.Text);

                picpathtxtbox4.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                picbox4.Image = Image.FromFile(picpathtxtbox4.Text);

                picpathtxtbox5.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                picbox5.Image = Image.FromFile(picpathtxtbox5.Text);

                picpathtxtbox6.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                picbox6.Image = Image.FromFile(picpathtxtbox6.Text);

                picpathtxtbox7.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                picbox7.Image = Image.FromFile(picpathtxtbox7.Text);

                picpathtxtbox8.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                picbox8.Image = Image.FromFile(picpathtxtbox8.Text);

                picpathtxtbox9.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                picbox9.Image = Image.FromFile(picpathtxtbox9.Text);

                picpathtxtbox10.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                picbox10.Image = Image.FromFile(picpathtxtbox10.Text);

                picpathtxtbox11.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                picbox11.Image = Image.FromFile(picpathtxtbox11.Text);

                picpathtxtbox12.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                picbox12.Image = Image.FromFile(picpathtxtbox12.Text);

                picpathtxtbox13.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                picbox13.Image = Image.FromFile(picpathtxtbox13.Text);

                picpathtxtbox14.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                picbox14.Image = Image.FromFile(picpathtxtbox14.Text);

                picpathtxtbox15.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                picbox15.Image = Image.FromFile(picpathtxtbox15.Text);

                picpathtxtbox16.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                picbox16.Image = Image.FromFile(picpathtxtbox16.Text);

                picpathtxtbox17.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                picbox17.Image = Image.FromFile(picpathtxtbox17.Text);

                picpathtxtbox18.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                picbox18.Image = Image.FromFile(picpathtxtbox18.Text);

                picpathtxtbox19.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                picbox19.Image = Image.FromFile(picpathtxtbox19.Text);

                picpathtxtbox20.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                picbox20.Image = Image.FromFile(picpathtxtbox20.Text);

                pricetxtbox1.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                pricetxtbox2.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                pricetxtbox3.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                pricetxtbox4.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                pricetxtbox5.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                pricetxtbox6.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                pricetxtbox7.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                pricetxtbox8.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                pricetxtbox9.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                pricetxtbox10.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                pricetxtbox11.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                pricetxtbox12.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                pricetxtbox13.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                pricetxtbox14.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                pricetxtbox15.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                pricetxtbox16.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                pricetxtbox17.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                pricetxtbox18.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                pricetxtbox19.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                pricetxtbox20.Text = pos_dbconnect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                pos_dbconnect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + nametxtbox1.Text + "', name2 = '" + nametxtbox2.Text + "', name3 = '" + nametxtbox3.Text + "', name4 = '" + nametxtbox4.Text + "', name5 = '" + nametxtbox5.Text + "', name6 = '" + nametxtbox6.Text + "', name7 = '" + nametxtbox7.Text + "', name8 = '" + nametxtbox8.Text + "', name9 = '" + nametxtbox9.Text + "', name10 = '" + nametxtbox10.Text + "', name11 = '" + nametxtbox11.Text + "', name12 = '" + nametxtbox12.Text + "', name13 = '" + nametxtbox13.Text + "', name14 = '" + nametxtbox14.Text + "', name15 = '" + nametxtbox15.Text + "', name16 = '" + nametxtbox16.Text + "', name17 = '" + nametxtbox17.Text + "', name18 = '" + nametxtbox18.Text + "', name19 = '" + nametxtbox19.Text + "', name20 = '" + nametxtbox20.Text + "' WHERE pos_id = '" + pos_id_comboBox.Text + "'";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterUpdate();

                pos_dbconnect.pos_sql = "UPDATE pos_picTBbl SET pic1 = '" + picpathtxtbox1.Text + "', pic2 = '" + picpathtxtbox2.Text + "', pic3 = '" + picpathtxtbox3.Text + "', pic4 = '" + picpathtxtbox4.Text + "', pic5 = '" + picpathtxtbox5.Text + "', pic6 = '" + picpathtxtbox6.Text + "', pic7 = '" + picpathtxtbox7.Text + "', pic8 = '" + picpathtxtbox8.Text + "', pic9 = '" + picpathtxtbox9.Text + "', pic10 = '" + picpathtxtbox10.Text + "', pic11 = '" + picpathtxtbox11.Text + "', pic12 = '" + picpathtxtbox12.Text + "', pic13 = '" + picpathtxtbox13.Text + "', pic14 = '" + picpathtxtbox14.Text + "', pic15 = '" + picpathtxtbox15.Text + "', pic16 = '" + picpathtxtbox16.Text + "', pic17 = '" + picpathtxtbox17.Text + "', pic18 = '" + picpathtxtbox18.Text + "', pic19 = '" + picpathtxtbox19.Text + "', pic20 = '" + picpathtxtbox20.Text + "' WHERE pos_id = '" + pos_id_comboBox.Text + "'";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterUpdate();

                pos_dbconnect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + pricetxtbox1.Text + "', price2 = '" + pricetxtbox2.Text + "', price3 = '" + pricetxtbox3.Text + "', price4 = '" + pricetxtbox4.Text + "', price5 = '" + pricetxtbox5.Text + "', price6 = '" + pricetxtbox6.Text + "', price7 = '" + pricetxtbox7.Text + "', price8 = '" + pricetxtbox8.Text + "', price9 = '" + pricetxtbox9.Text + "', price10 = '" + pricetxtbox10.Text + "', price11 = '" + pricetxtbox11.Text + "', price12 = '" + pricetxtbox12.Text + "', price13 = '" + pricetxtbox13.Text + "', price14 = '" + pricetxtbox14.Text + "', price15 = '" + pricetxtbox15.Text + "', price16 = '" + pricetxtbox16.Text + "', price17 = '" + pricetxtbox17.Text + "', price18 = '" + pricetxtbox18.Text + "', price19 = '" + pricetxtbox19.Text + "', price20 = '" + pricetxtbox20.Text + "' WHERE pos_id = '" + pos_id_comboBox.Text + "'";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterUpdate();

                pos_dbconnect.pos_select();
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterSelect();
                pos_dbconnect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = pos_dbconnect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                pos_dbconnect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_id = '" + pos_id_comboBox.Text + "'";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterDelete();

                pos_dbconnect.pos_sql = "DELETE FROM pos_picTBbl WHERE pos_id = '" + pos_id_comboBox.Text + "'";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterDelete();

                pos_dbconnect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_id = '" + pos_id_comboBox.Text + "'";
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterDelete();

                pos_dbconnect.pos_select();
                pos_dbconnect.pos_cmd();
                pos_dbconnect.pos_sqladapterSelect();
                pos_dbconnect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = pos_dbconnect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }

            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void new_cancelBTN_Click(object sender, EventArgs e)
        {
            cleartextboxes();
            pos_id_comboBox.SelectedIndex = -1;
            pos_id_comboBox.Text = string.Empty;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbox1_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox1.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox1.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox2_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox2.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox2.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox3.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox3.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox4.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox4.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox5_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox5.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox5.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox6_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox6.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox6.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox7_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox7.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox7.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox8_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox8.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox8.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox9_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox9.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox9.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox10_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox10.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox10.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox11_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox11.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox11.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox12_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox12.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox12.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox13_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox13.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox13.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox14_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox14.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox14.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox15_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox15.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox15.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox16_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox16.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox16.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox17_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox17.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox17.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox18_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox18.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox18.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox19_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox19.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox19.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void picbox20_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                picbox20.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathtxtbox20.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }
    }
}
