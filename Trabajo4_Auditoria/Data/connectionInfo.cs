using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo4_Auditoria.Data
{
    public class ConnectionInfo
    {
        public string serverName;
        public string dbName;
        public string? password;
        public string? username;
        public bool isWindowsAuth = true;

        public ConnectionInfo() { }
        public ConnectionInfo(string serverName, string dBName, string? password, string? username, bool isWindowsAuth)
        {
            this.serverName = serverName;
            this.dbName = dBName;
            this.password = password!=null?password:"";
            this.username = username != null ? username : "";
            this.isWindowsAuth = isWindowsAuth;
        }
        public string GetConnectionString()
        {
            if (this.isWindowsAuth)
            {
                return $"Data Source={this.serverName};Initial Catalog={this.dbName}; Integrated Security=True";
            }
            return $"Data Source={this.serverName};Initial Catalog={this.dbName};User ID= {this.username};Password= {this.password}";
        }
    }
}
