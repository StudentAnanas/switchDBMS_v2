using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDBMS_v2
{
    class DB_client
    {
        private DB_commands commands;
        public DB_client(DB_commands commands)
        {
            this.commands = commands;
            RunAllCommands();
        }
        public void RunAllCommands()
        {
            commands.Type();
            commands.GetSet1();
            commands.GetSet2();
            commands.GetSet3();
            commands.GetSet4();
            commands.GetSet5();
            commands.GetSet6();
            commands.GetSet7();
            commands.GetSet8();
            commands.GetSet9();
            commands.GetSet10();
            
        }
    }
}
