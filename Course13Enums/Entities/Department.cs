using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course13Enums.Entities
{
    class Department
    {
        #region Atributos/Properties

        public string Name { get; set; }

        #endregion

        #region Construtores

        public Department() { }
        public Department(string name)
        {
            Name = name;
        }

        #endregion
    }
}
