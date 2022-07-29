using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wvaConsoleInterface {
    internal class Presenter {
        public string SuggestionsToString(List<string> suggestions) {
            StringBuilder builder = new StringBuilder();

            foreach (var suggestion in suggestions) {
                builder.Append(suggestion + ", ");
            }

            return builder.ToString();
        }
    }
}
