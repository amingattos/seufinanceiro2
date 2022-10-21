using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace seufinanceiro.View
{
    /// <summary>
    /// Lógica interna para SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        int loading = 0; // 0-Fechado 1-Abrir

        readonly DispatcherTimer dispatcherTimer = new DispatcherTimer();
        readonly DispatcherTimer dispatcherTimer2 = new DispatcherTimer();

        public SplashScreen()
        {
            InitializeComponent();
            PB_barraProcess.Value = 0;

            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            dispatcherTimer.Start();

            dispatcherTimer2.Tick += new EventHandler(DispatcherTimer2_Tick);
            dispatcherTimer2.Interval = new TimeSpan(0, 0, 0, 0, 10);
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("TESTANDO TIMER 2 SEGUNDOS!");
            dispatcherTimer.Stop();
            dispatcherTimer2.Start();

            Carregar();

        }
        private void DispatcherTimer2_Tick(object sender, EventArgs e)
        {
            if (PB_barraProcess.Value < 100)
            {
                PB_barraProcess.Value++;
                Txt_process.Text = PB_barraProcess.Value.ToString() + "%";
            }
            else
            {
                dispatcherTimer2.Stop();
            }
        }
        private void Carregar()
        {
            if (PB_barraProcess.Value != 100) //Iniciando
            {
                Controller.Cls_CreateDB objCreateDB = new Controller.Cls_CreateDB();
                objCreateDB.CriarDB();
                loading++;

                dispatcherTimer.Start();
            }
            else if (PB_barraProcess.Value == 100 && loading == 1)
            {
                Login ObjLogin = new Login();
                ObjLogin.Show();
                this.Close();
            }
        }


    }
}
