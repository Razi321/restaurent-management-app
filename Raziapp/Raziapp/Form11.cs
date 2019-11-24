using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raziapp
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void TB_NCin_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_Chercher_Click(object sender, EventArgs e)
        {
            // Définition de la chaîne de connexion 
            string chaineConnexion1 = "datasource=localhost;username=root;password=;Initial Catalog=desktopapp";
            //Définition du texte de la requête sql 
            string Query1 = "select * from chefs where NCIN = " + this.TB_NCin.Text;

            //Instanciation d'une nouvelle connexion dans conn  
            MySqlConnection Conn1 = new MySqlConnection(chaineConnexion1);

            //Instanciation d'une nouvelle commande dans cmd
            MySqlCommand cmd1 = new MySqlCommand(Query1, Conn1);

            //Instanciation d'un nouveau data reader dr
            MySqlDataReader dr1;
            Conn1.Open();
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                MessageBox.Show("NCIN existe déjà");
                Conn1.Close();
            }
            else
            {
                try
                {
                    //Définition de la chaîne de connexion dans chaineConnexion
                    string chaineConnexion = "datasource=localhost;username=root;password=;Initial Catalog=desktopapp";
                    //Définition du texte de la requête sql dans query
                    string Query = "INSERT INTO CHEFS(NCIN, First_name ,Last_name,Specialty,experience,Date_of_birth ) VALUES(" +
 this.TB_NCin.Text + ",'" +
                        this.TB_Nom.Text + "','" +
                        this.TB_Prenom.Text + "','" +
                        this.TB_Specialty.Text + "','" +
                        this.TB_Exp.Text + "','" +
                        this.dateTimePicker1.Text + "');";




                    //Instanciation d'une nouvelle connexion dans conn  
                    MySqlConnection Conn = new MySqlConnection(chaineConnexion);

                    //Instanciation d'une nouvelle commande dans cmd
                    MySqlCommand cmd = new MySqlCommand(Query, Conn);

                    //Instanciation d'un nouveau data reader dr
                    MySqlDataReader dr;
                    Conn.Open();
                    dr = cmd.ExecuteReader();

                    BT_Modifier.Enabled = true;
                    BT_Supprimer.Enabled = true;
                    BT_Ajouter.Enabled = false;
                    Conn.Close();
                    MessageBox.Show("chef ajouté.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problème d''ajout, Texte de l'erreur: " + ex.Message);
                }
            }

        }

        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                //Définition de la chaîne de connexion dans chaineConnexion
                string chaineConnexion = "datasource=localhost;username=root;password=;Initial Catalog=desktopapp";
                //Définition du texte de la requête sql dans query
                string Query = "DELETE FROM chefs  where NCIN = " + this.TB_NCin.Text;

                //Instanciation d'une nouvelle connexion dans conn  
                MySqlConnection Conn = new MySqlConnection(chaineConnexion);

                //Instanciation d'une nouvelle commande dans cmd
                MySqlCommand cmd = new MySqlCommand(Query, Conn);

                //Instanciation d'un nouveau data reader dr
                MySqlDataReader dr;
                Conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("chef supprimé avec succès");
                this.TB_Nom.Text = "";
                this.TB_Prenom.Text = "";
                this.TB_Specialty.Text = "";
                this.TB_Exp.Text = "";
                this.dateTimePicker1.Text = "";
                

              
                BT_Modifier.Enabled = false;
                BT_Supprimer.Enabled = false;
                BT_Ajouter.Enabled = false;
                Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                //Définition de la chaîne de connexion dans chaineConnexion 
                string chaineConnexion = "datasource=localhost;username=root;password=;Initial Catalog=desktopapp";
                //Définition du texte de la requête sql dans query
                string Query = "SELECT * FROM chefs WHERE NCIN =" + this.TB_NCin.Text;

                //Instanciation d'une nouvelle connexion dans conn  
                MySqlConnection Conn = new MySqlConnection(chaineConnexion);

                //Instanciation d'une nouvelle commande dans cmd
                MySqlCommand cmd = new MySqlCommand(Query, Conn);

                //Instanciation d'un nouveau data reader dr
                MySqlDataReader dr;
                Conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.TB_Nom.Text = dr.GetString(1);
                    this.TB_Prenom.Text = dr.GetString(2);
                    this.TB_Specialty.Text = dr.GetString(3);
                    this.TB_Exp.Text = dr.GetString(4);
                    this.dateTimePicker1.Text = dr.GetDateTime(5).ToShortDateString();

                    

                    BT_Modifier.Enabled = true;
                    BT_Supprimer.Enabled = true;
                    BT_Ajouter.Enabled = false;
                    Conn.Close();
                }
                else
                {
                    this.TB_Nom.Text = "";
                    this.TB_Prenom.Text = "";
                    this.TB_Specialty.Text = "";
                    this.TB_Exp.Text = "";
                    this.dateTimePicker1.Text = "";
                   
                    MessageBox.Show("Chef innexistant");
                    

                    BT_Modifier.Enabled = false;
                    BT_Supprimer.Enabled = false;
                    BT_Ajouter.Enabled = true;
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.TB_Nom.Text = "";
                this.TB_Prenom.Text = "";
                this.TB_Specialty.Text = "";
                this.TB_Exp.Text = "";
                this.dateTimePicker1.Text = "";
               
                BT_Modifier.Enabled = false;
                BT_Supprimer.Enabled = false;
            }

        }

        private void BT_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                //Définition de la chaîne de connexion dans chaineConnexion
                string chaineConnexion = "datasource=localhost;username=root;password=;Initial Catalog=desktopapp";
                //Définition du texte de la requête sql dans query
               


                string Query = "UPDATE chefs SET First_name='" + this.TB_Nom.Text + "'," +
                              "Last_name='" + this.TB_Prenom.Text + "'," +
                              "Specialty='" + this.TB_Specialty.Text + "'," +
                              "experience='" + this.TB_Exp.Text + "'," +
                              
"Date_of_birth='" + this.dateTimePicker1.Text +
                              "' where NCIN = " + this.TB_NCin.Text;






                //Instanciation d'une nouvelle connexion dans conn  
                MySqlConnection Conn = new MySqlConnection(chaineConnexion);

                //Instanciation d'une nouvelle commande dans cmd
                MySqlCommand cmd = new MySqlCommand(Query, Conn);

                //Instanciation d'un nouveau data reader dr
                MySqlDataReader dr;
                Conn.Open();
                dr = cmd.ExecuteReader();

                BT_Modifier.Enabled = true;
                BT_Supprimer.Enabled = true;
                BT_Ajouter.Enabled = false;

                Conn.Close();
                MessageBox.Show("chef modifié avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 100);
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form10 t = new Form10();
            this.Hide();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            this.Hide();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 t = new Form4();
            this.Hide();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 t = new Form5();
            this.Hide();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 t = new Form6();
            this.Hide();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 t = new Form7();
            this.Hide();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 t = new Form8();
            this.Hide();
            t.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
