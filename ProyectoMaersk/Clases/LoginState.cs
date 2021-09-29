using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaersk.Clases
{
    public class LoginState
    {
        public bool IsLoggedIn { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public bool EsAdministrador { get; set; } //verdadero o falso para verificar que sea admin

        public event Action OnChange; //para poder levantar eventos

        public void SetLogin(bool login, string user)
        {
            IsLoggedIn = login;
            codigo = user;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
