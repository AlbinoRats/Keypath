using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keypath
{
    class combinations
    {
        private string label;
        private string directoryPath;
        public combinations()
        {

        }
        public void setLabel(string Label)
        {
            label=Label;
        }
        public void setDirectory(string DirectoryPath)
        {
            directoryPath = DirectoryPath;
        }
        public string getLabel()
        {
            return label;
        }
        public string getPath()
        {
            return directoryPath;
        }
    }
}
