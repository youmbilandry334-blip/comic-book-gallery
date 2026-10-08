using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Employee
{
    public partial class Form1 : Form
    {
        SqlDataAdapter Sqlda; DataSet dataSet; 
        public string ConnectionString { get; set; } = 
            @"Data Source=NOM_DU_SERVEUR;" + 
            @"Initial Catalog=Company;" + 
            @"Integrated Security=true;"; 
        public Form1() 
        { 
            InitializeComponent(); 
            Sqlda = new SqlDataAdapter(
                "SELECT * FROM Employee",ConnectionString);
            dataSet = new DataSet(); 
            Sqlda.Fill(dataSet, "Emp"); 
        } 
        // Le code des boutons est donné aux étapes suivantes
         }
        } 
