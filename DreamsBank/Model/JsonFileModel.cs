using DreamsBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsBank
{
    public class JsonFileModel
    {
        public List<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
