using System;
using System.Windows;
using System.Windows.Threading;
using System.Data.SqlClient;

namespace seufinanceiro.View
{
    /// <summary>
    /// Lógica interna para Tela_principal.xaml
    /// </summary>
    public partial class Tela_principal : Window
    {
        string botao = "0";
        string user_name;
        int id_user_on;

        readonly DispatcherTimer dispatcherTimer = new DispatcherTimer();
        readonly Controller.Cls_Login ObjLogin_Cls = new Controller.Cls_Login();

        public Tela_principal(string user,int id_user)
        {
            user_name = user;
            id_user_on = id_user;

            StartClock();
            InitializeComponent();
            ChamaTela();

            txtb_NameUser.Text = user_name;
        }
        private void StartClock()
        {
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Tickevent; // Comente esta linha cara caso for fazer BreakPoint
            timer.Start();
        }
        public void ChamaTela()
        {
            switch (botao)
            {
                case "0": // Abrir a Tela Principal
                    UserControl_Inicio UC_obj_Dashboard = new UserControl_Inicio(id_user_on);

                    if (stk_cards_information.Children != null)
                    {
                        stk_cards_information.Children.Clear();
                        stk_cards_information.Children.Add(UC_obj_Dashboard);
                    }
                    else
                    {
                        stk_cards_information.Children.Add(UC_obj_Dashboard);
                    }
                    break;
                case "1": // Abrir a Tela de Carteira

                    UserControl_Carteira UC_obj_Carteira = new UserControl_Carteira(id_user_on);
                    //UC_obj_Carteira.Id_usr = Id_usr_User;

                    if (stk_cards_information.Children != null)
                    {
                        stk_cards_information.Children.Clear();
                        stk_cards_information.Children.Add(UC_obj_Carteira);
                    }
                    else
                    {
                        stk_cards_information.Children.Add(UC_obj_Carteira);
                    }
                    break;
            }
        }
        private void Tickevent(object sender, EventArgs e)
        {
            txtb_Clock.Text = DateTime.Now.ToString("t");
            txtb_Date.Text = DateTime.Now.ToString("d");
            txtb_Week.Text = DateTime.Now.ToString("dddd").ToUpper();
        }
        private void Btn_Sair_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Deseja Sair?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                SqlDataReader ObjDadosLoginDesconectar;
                ObjDadosLoginDesconectar = ObjLogin_Cls.ContaDeslogado(id_user_on.ToString());
                this.Close();
            }
        }
        private void Btn_inicio_Click(object sender, RoutedEventArgs e)
        {
            botao = "0";
            ChamaTela();
        }
        private void Btn_Carteira_Click(object sender, RoutedEventArgs e)
        {
            //UserControl_Carteira UC_obj_Carteira = new UserControl_Carteira();

            botao = "1";
            ChamaTela();

            //UC_obj_Carteira.Id_usr = Id_usr_User;
            //UC_obj_Carteira.CarregaWallets();
        }
        private void Btn_TrocaUser_Click(object sender, RoutedEventArgs e)
        {
            View.Login ObjLoginShow = new Login();

            this.Close();

            ObjLoginShow.txt_Username.Clear();
            ObjLoginShow.txt_Password.Clear();
            ObjLoginShow.cb_sPass.IsChecked = false;

            ObjLoginShow.Show();
        }
        private void Btn_Minimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}