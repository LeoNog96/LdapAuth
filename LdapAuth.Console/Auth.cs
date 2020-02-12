using Novell.Directory.Ldap;

namespace LdapAuth.Console
{
    public static class Auth
    {
        public static bool ValidateUser (string url, string domain, string username, string password)
        {
            string userDn = $"uid={username},{domain}";

            using var connection = new LdapConnection { SecureSocketLayer = false };

            connection.Connect(url, LdapConnection.DEFAULT_PORT);

            connection.Bind(userDn, password);

            return connection.Bound;
        }
    }
}