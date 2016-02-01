using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA;
using Customization.Tagging;
using System.Drawing;


namespace MOD_DecisionTag
{
    public class Program
    {
        [MainMethod()]
        public static void Main()
        {
            SystemTag.Define("Teacher", "角色:校長", Color.Purple, "Role.0001", "設定「校長」", "校長");
        }        
    }
}
