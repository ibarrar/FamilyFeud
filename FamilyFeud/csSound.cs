using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QuartzTypeLib;

namespace FamilyFeud
{
    public class csSound
    {
        private static QuartzTypeLib.IMediaControl mp3control;
        private static QuartzTypeLib.FilgraphManager graphManager;

        public csSound()
        {
        }

        public void PlayAMp3(string args)
        {           
            try
            {
                graphManager = new QuartzTypeLib.FilgraphManager();
                mp3control = (QuartzTypeLib.IMediaControl)graphManager;
                mp3control.RenderFile("sounds\\" + args);
                mp3control.Run();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error : {0} or \nMissing sound file: .\\sounds\\{1}",ex.Message,args));
            }
        }
    }
}
