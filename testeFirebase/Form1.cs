using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseSharp;
using FirebaseSharp.Portable;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Serialization.JsonNet;

namespace testeFirebase
{
    public partial class Form1 : Form
    {
        
        public static IFirebaseConfig firebaseConfig = new FirebaseConfig
        {
            AuthSecret = "AIzaSyAzF0P4W2TXJo4VhzjWOGwlWVkqDZIWI_Y",
            BasePath = "https://skengenhoam-default-rtdb.firebaseio.com/"
        };
        

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {

            FirebaseApp fb = new FirebaseApp(new Uri("https://skengenhoam-default-rtdb.firebaseio.com"));
            var tickets = fb.Child("/tickets");

            tickets.On("child_changed", (snap, child, context) =>
            {
                System.Diagnostics.Debug.WriteLine("ai ai ai");
                try
                {
                    System.Diagnostics.Debug.WriteLine(snap.Value());

                    string token = snap.Value();
                    if (token is null) return;
                    if (token.Trim() == "") return;

                    string[] valores = token.Split(',');

                    //EngenhoAM @id = 1,22 / 04 / 2021,18:13:41,-1,AAA1448,Entrada,Shirley Kroeff, Arroz em Casca,2021,Julio
                    DadosTicket tkt = new DadosTicket();
                    tkt.id = valores[0];
                    tkt.data = valores[1];
                    tkt.hora = valores[2];
                    tkt.peso = valores[3];
                    tkt.placa = valores[4];
                    tkt.operacao = valores[5];
                    tkt.origemDestino = valores[6];
                    tkt.produto = valores[7];
                    tkt.nf = valores[8];
                    tkt.operador = valores[9];

                    Invoke(new Action<DadosTicket>(UpdateGuiText), tkt);

                } catch (Exception) { }
                
            });


            //IFirebaseClient client = new FirebaseClient(firebaseConfig);
            //FirebaseResponse response = client.Get("/");
            //var res = response;

            //fbUser result = response.ResultAs<fbUser>();

        }

        private void UpdateGuiText(DadosTicket result)
        {
            lblData.Text = result.data.Trim();
            lblHora.Text = result.hora.Trim();
            lblOperador.Text = result.operador.Trim();
            lblPeso.Text = result.peso.Trim();
            lblPlaca.Text = result.placa.Trim();
            lblOperacao.Text = result.operacao.Trim();
            lblOrigDest.Text = result.origemDestino.Trim();
            lblProduto.Text = result.produto.Trim();
            lblNF.Text = result.nf.Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // cmdConnect_Click(sender, e);
        }

        private async void cmdSet_Click(object sender, EventArgs e)
        {
            var todo = new Todo
            {
                name = "Execute SET",
                priority = 1
            };

            /*
            FirebaseApp fb = new FirebaseApp(new Uri("https://skengenhoam-default-rtdb.firebaseio.com"));
            var balanca = fb.Child("/Tickets");
            balanca.Push()
            */

            /*
            IFirebaseClient  client = new FirebaseClient(firebaseConfig);
            SetResponse response = await client.SetTaskAsync("todos/set", todo);
            Todo result = response.ResultAs<Todo>(); //The response will contain the data written
            */

            /*
            FirebaseApp fb = new FirebaseApp(new Uri("https://skengenhoam-default-rtdb.firebaseio.com"));
            var raiz = fb.Child("/Tickets");
            var ret = raiz.Set("/todos/set", todos);
            */

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "RM9VBDQAc79RWpdUSUDxLbKNfL7xVEDRItEfye97",
                BasePath = "https://skengenhoam-default-rtdb.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);
            SetResponse response = client.Set("balanca", "90");
            //Todo result = response.ResultAs<Todo>(); //The response will contain the data written
        }

        private void setBalanca(string valor)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            System.Random R = new Random();
            int peso = R.Next(10, 1000);

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "RM9VBDQAc79RWpdUSUDxLbKNfL7xVEDRItEfye97",
                BasePath = "https://skengenhoam-default-rtdb.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);
            SetResponse response = client.Set("balanca", peso.ToString());
            

         
        }

    }


    public struct Todo
    {
        public string name { get; set; }
        public int priority { get; set; }
    }

    public struct DadosTicket
    {
        public string id { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public string peso { get; set; }
        public string placa { get; set; }
        public string operacao { get; set; }
        public string origemDestino { get; set; }
        public string produto { get; set; }
        public string nf { get; set; }
        public string operador { get; set; }
    }

}


