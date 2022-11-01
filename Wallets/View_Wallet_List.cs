using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Data.SqlClient;

namespace seufinanceiro.View
{
    public class View_Wallet_List : INotifyPropertyChanged
    {
        int _id_wallet, _id_usr_wallet;
        string _name_wallet;
        string _balance_wallet;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id_Wallet
        {
            get => _id_wallet;
            set
            {
                if (_id_wallet != value)
                {
                    _id_wallet = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int Id_User_Wallet
        {
            get => _id_usr_wallet;
            set
            {
                if (_id_usr_wallet != value)
                {
                    _id_usr_wallet = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Name_Wallet
        {
            get => _name_wallet;
            set
            {
                if (_name_wallet != value)
                {
                    _name_wallet = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Balance_Wallet
        {
            get => _balance_wallet;
            set
            {
                if (_balance_wallet != value)
                {
                    _balance_wallet = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public void NotifyPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
