using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDB
{
    class openFormClass
    {
     public static void getForm(Form child,bool isDialog)
        {
            if(child != null && !isDialog)
            {
                child.Show();
            }
            else if(child!=null&& isDialog == true)
            {
                child.ShowDialog();
            }
        }
    }
}
