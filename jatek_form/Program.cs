using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek_form
{
    internal static class Program
    {
        static public Form_open Form_Open = null;
        static public form_delete form_Delete = null;
        static public form_edit form_Edit = null;
        static public form_new form_New = null;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Delete = new form_delete();
            form_Edit = new form_edit();    
            form_New = new form_new();  
            Form_Open = new Form_open();
            Application.Run(new Form_open());
        }
    }
}
