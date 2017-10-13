namespace SharpShell.ServerRegistration
{
    /// <summary>
    /// Represents the location for the server registration.
    /// See https://msdn.microsoft.com/en-us/library/ms724498.aspx for more information
    /// </summary>
    public sealed class RegistrationLocation
    {
        private readonly string _userSid;

        internal const string LocalMachinePseudoSid = "*lm*";
        internal const string CurrentUserPseudoSid = "*cu*";

        private RegistrationLocation(string userSid)
        {
            _userSid = userSid;
        }

        internal string UserSid { get { return _userSid; } }

        /// <summary>
        /// Use HKEY_LOCAL_MACHINE\Software\Classes
        /// </summary>
        public static RegistrationLocation LocalMachine { get { return new RegistrationLocation(LocalMachinePseudoSid); } }

        /// <summary>
        /// Use HKEY_CURRENT_USER\Software\Classes
        /// </summary>
        public static RegistrationLocation CurrentUser { get { return new RegistrationLocation(CurrentUserPseudoSid); } }

        /// <summary>
        /// Use HKEY_USERS\sid_Classes
        /// </summary>
        public static RegistrationLocation User(string userSid) { return new RegistrationLocation(userSid); }

    }
}