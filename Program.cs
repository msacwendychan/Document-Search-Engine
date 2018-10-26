/* IFN647 Project - EduSearch Application created by 
 * Huanjiao Qiu n9582541
 * Wai Wing Chan n9781463
 * Zhiyi Wu n9589147
 * on 26 Oct 2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a
{
    // Runs the Search Interface 
    static class MainClass
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SearchInterface());
            
        }
    }
}
