﻿using System;

namespace virtual_receptionist.Exceptions
{
    /// <summary>
    /// Bejelentkezés kivétel
    /// </summary>
    public class LoginException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Bejelentkezés kivétel
        /// </summary>
        public LoginException() : base("Sikertelen bejelentkezés!\nHibás szállásazonosító vagy jelszó!")
        {
        }

        #endregion
    }
}
