using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace seufinanceiro.View
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Login : Window
    {
        string loginsalvo = "1";
        string name_user;
        int ID_user;

        // 0 - LoginSalvo Desligado; 1 - LoginSalvo Ligado;

        readonly Controller.Cls_Messages ObjMessages = new Controller.Cls_Messages();

        public Login()
        {
            InitializeComponent();
            ValidarLogin();
            
        }

        public void ValidarLogin()
        {
            string usr = txt_Username.Text;
            string pwd = txt_Password.Password.ToString();
            string id_user, save = "1";

            switch (loginsalvo)
            {
                case "1": // Verifica se existe algum login salvo no BD e insere os dados nos campos.

                    Controller.Cls_Settings ObjSettings = new Controller.Cls_Settings();
                    SqlDataReader ObjDadosSettings, ObjDadosIDSettings;

                    ObjDadosSettings = ObjSettings.LoginSalvo();
                    ObjDadosSettings.Read();

                    ObjDadosIDSettings = ObjSettings.IDUserSave();
                    ObjDadosIDSettings.Read();

                    if (ObjDadosSettings["SaveLogin"].ToString() == "1")
                    {
                        usr = ObjDadosIDSettings["id_usr_login"].ToString();

                        Controller.Cls_Login ObjLogin2 = new Controller.Cls_Login();
                        SqlDataReader ObjDadosLogin2;

                        ObjDadosLogin2 = ObjLogin2.LoadSaveLogin(usr);
                        ObjDadosLogin2.Read();

                        txt_Username.Text = ObjDadosLogin2["usr"].ToString();
                        txt_Username.Foreground = Brushes.Black;

                        txt_Password.Password = ObjDadosLogin2["pwd"].ToString();
                        txt_Password.Foreground = Brushes.Black;

                        cb_sPass.IsChecked = true;
                    }
                    else
                    {
                        loginsalvo = "0";
                    }
                    break;

                case "2": // Faz o login, se o CheckBox estiver True ele salva o login. 

                    Controller.Cls_Settings ObjSettings2 = new Controller.Cls_Settings();
                    Controller.Cls_Login ObjLogin = new Controller.Cls_Login();

                    SqlDataReader ObjDadosLogin, ObjValidadorLogin;

                    ObjDadosLogin = ObjLogin.Logar(usr, pwd);
                    ObjDadosLogin.Read();

                    ObjValidadorLogin = ObjLogin.Existinguser(usr, pwd);
                    ObjValidadorLogin.Read();

                    if (ObjValidadorLogin["users"].ToString() == "0")
                    {
                        if (txt_Username.Text == "" && txt_Password.Password == "")
                        {
                            snkbar_E.MessageQueue?.Enqueue(ObjMessages.E1);
                        }
                        else if (txt_Username.Text != "" && txt_Password.Password != "")
                        {
                            snkbar_E.MessageQueue?.Enqueue(ObjMessages.E2);
                        }
                        else if (txt_Username.Text == "" && txt_Password.Password != "")
                        {
                            snkbar_E.MessageQueue?.Enqueue(ObjMessages.E3);
                        }
                        else if (txt_Username.Text != "" && txt_Password.Password == "")
                        {
                            snkbar_E.MessageQueue?.Enqueue(ObjMessages.E4);
                        }
                    }
                    else if (ObjValidadorLogin["users"].ToString() == "1")
                    {
                        id_user = ObjDadosLogin["id_usr"].ToString();
                        ID_user = int.Parse(ObjDadosLogin["id_usr"].ToString());
                        name_user = ObjDadosLogin["usr"].ToString();

                        Tela_principal obj_TelaPrincipal = new Tela_principal(name_user, ID_user);

                        if (cb_sPass.IsChecked == true)
                        {
                            ObjSettings2.SaveLoginAuto(id_user, save);

                            obj_TelaPrincipal.Show();
                            this.Close();
                        }
                        else
                        {
                            save = "2";
                            ObjSettings2.SaveLoginAuto(id_user, save);

                            obj_TelaPrincipal.Show();
                            this.Close();
                        }
                    }
                    break;
            }
        }
        public void CriarUsuario()
        {
            if (txt_Username.Text == "admin")
            {
                snkbar_A.MessageQueue?.Enqueue(ObjMessages.A1);
                
            }
            else if (txt_Username.Text == "dev" || txt_Username.Text == "developer")
            {
                snkbar_A.MessageQueue?.Enqueue(ObjMessages.A1);
            }
            else
            {
                string usr = txt_Username.Text;
                string pwd = txt_Password.Password.ToString();

                Controller.Cls_CadastrarLogin ObjCadastrarLogin = new Controller.Cls_CadastrarLogin();
                Controller.Cls_Settings ObjSettings = new Controller.Cls_Settings();
                Controller.Cls_Wallet ObjWallet = new Controller.Cls_Wallet();

                SqlDataReader ObjValidadorLogin, ObjID_User;

                ObjValidadorLogin = ObjCadastrarLogin.Exist_User(usr);
                ObjValidadorLogin.Read();

                if (ObjValidadorLogin["users"].ToString() == "1")
                {  // Usuario já existe
                    snkbar_E.MessageQueue?.Enqueue(ObjMessages.E5);
                }
                else if (ObjValidadorLogin["users"].ToString() == "0")
                {
                    ObjCadastrarLogin.CadastrarLogin(usr, pwd);

                    ObjID_User = ObjCadastrarLogin.LoadID_Usr(usr);
                    ObjID_User.Read();

                    ObjSettings.Create_Settings(ObjID_User["id_usr"].ToString());

                    ObjWallet.Create_Wallet(int.Parse(ObjID_User["id_usr"].ToString()));

                    loginsalvo = "2";
                    ValidarLogin();
                }
            }
        }
        private void Btn_sair_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void Btn_Um_Click(object sender, RoutedEventArgs e)
        {
            if (Btn_Um.Content.ToString() == "Entrar")
            {
                /* Quando o botão escrito ENTRAR ele fará a validação
                 * do login */

                loginsalvo = "2";
                ValidarLogin();
            }
            else if (Btn_Um.Content.ToString() == "Criar")
            {
                /* Quando o botão escrito CRIAR ele fará o cadatro de
                 * novo usuário no sistema*/

                CriarUsuario();
            }
        }
        private void Btn_Dois_Click(object sender, RoutedEventArgs e)
        {
            if (Btn_Dois.Content.ToString() == "Criar nova conta")
            {
                /* Mudará os botões e contents para cadastro */

                txt_Username.Clear();
                txt_Password.Clear();

                txtblock_1.Text = "Crie sua conta!";
                Btn_Dois.Content = "Voltar";
                Btn_Um.Content = "Criar";

                txtblock_1.Foreground = new SolidColorBrush(Colors.DarkOrange);

                txt_Username.CaretBrush = new SolidColorBrush(Colors.DarkOrange);
                txt_Password.CaretBrush = new SolidColorBrush(Colors.DarkOrange);

                Btn_Um.Background = new SolidColorBrush(Colors.DarkOrange);
                Btn_Um.BorderBrush = new SolidColorBrush(Colors.DarkOrange);
                Btn_Dois.Foreground = new SolidColorBrush(Colors.DarkOrange);

                cb_sPass.Background = new SolidColorBrush(Colors.DarkOrange);
                cb_sPass.BorderBrush = new SolidColorBrush(Colors.DarkOrange);

                Btn_Sair.Background = new SolidColorBrush(Colors.DarkOrange);
                Btn_Sair.BorderBrush = new SolidColorBrush(Colors.DarkOrange);
            }
            else if (Btn_Dois.Content.ToString() == "Voltar")
            {
                /* Voltará para contents anterior */

                ValidarLogin();

                txtblock_1.Text = "Bem-Vindo!";
                Btn_Dois.Content = "Criar nova conta";
                Btn_Um.Content = "Entrar";

                txtblock_1.Foreground = new SolidColorBrush(Colors.ForestGreen);

                txt_Username.CaretBrush = new SolidColorBrush(Colors.ForestGreen);
                txt_Password.CaretBrush = new SolidColorBrush(Colors.ForestGreen);

                Btn_Um.Background = new SolidColorBrush(Colors.ForestGreen);
                Btn_Um.BorderBrush = new SolidColorBrush(Colors.ForestGreen);
                Btn_Dois.Foreground = new SolidColorBrush(Colors.ForestGreen);

                cb_sPass.Background = new SolidColorBrush(Colors.ForestGreen);
                cb_sPass.BorderBrush = new SolidColorBrush(Colors.ForestGreen);

                Btn_Sair.Background = new SolidColorBrush(Colors.ForestGreen);
                Btn_Sair.BorderBrush = new SolidColorBrush(Colors.ForestGreen);
            }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Btn_Um.Content.ToString() == "Entrar")
                {
                    loginsalvo = "2";
                    ValidarLogin();
                }
                else if (Btn_Um.Content.ToString() == "Criar")
                {
                    CriarUsuario();
                }
            }
        }
    }
}
