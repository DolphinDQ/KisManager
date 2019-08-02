using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KisManager.Sql
{
    public class SqlBlock
    {
        public Dictionary<string, string> OptionalParams { get; set; }

        public string SqlCommand { get; set; }

        public override string ToString()
        {
            OptionalParams = OptionalParams ?? new Dictionary<string, string>();
            var cmd = SqlCommand;
            foreach (var item in OptionalParams)
            {
                var key = $"{item.Key}";
                do
                {
                    cmd = cmd.Replace(key, item.Value);
                } while (SqlCommand.IndexOf(key) >= 0);
            }
            return cmd;
        }

    }
}
